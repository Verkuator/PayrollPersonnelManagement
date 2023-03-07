using System;
using System.Linq;
using System.Windows.Forms;

namespace PayrollPersonnelManagement.Common
{
    class OneAccuralControll : AddEditRead
    {
        Label EmployeeLabel = new Label();
        ComboBox EmployeeComboBox = new ComboBox();
        Label InDateLabel = new Label();
        DateTimePicker InDateDateTimePicker = new DateTimePicker();
        Label HoursMonthLabel = new Label();
        NumericUpDown HoursMonthNumericUpDown = new NumericUpDown();
        Label ViewSumLabel = new Label();
        Label SumLabel = new Label();
        Button AccuralButton = new Button();
        OneAccrual OneAccrual { get; set; }
        const string TableName = "OneAccrual";
        const string EmployeeST = "Employee";
        const string InDateST = "InDate";
        const string HoursMonthST = "HoursMonth";
        const string SumST = "Sum";
        public string SelectQuery = "SELECT " +
                                "Employee.ID, " +
                                "PhisicalFace.*, " +
                                "Post.*, " +
                                "Subdivision.*, " +
                                TableName + ".ID, " +
                                "OneAccrual.InDate, " +
                                "OneAccrual.HoursMonth, " +
                                "OneAccrual.Sum " +
                                "FROM " + TableName + " " +
                                "INNER JOIN Employee ON Employee.ID = " + TableName + ".Employee " +
                                "INNER JOIN PhisicalFace ON PhisicalFace.ИД = Employee.PhisicalFace " +
                                "INNER JOIN Post ON Post.ИД = Employee.Post " +
                                "INNER JOIN Subdivision ON Subdivision.ИД = Employee.Subdivision; ";
        public OneAccuralControll(DataSQLite dataSQLite) : base(dataSQLite) { }
        public OneAccuralControll(Panel panel, EditForm editForm, DataSQLite dataSQLite)
            : base(panel, editForm, dataSQLite)
        {
            Title = "Разовое начисление";

            AddButton.MouseClick += AddButton_MouseClick;
            EditButton.MouseClick += EditButton_MouseClick;
            DeleteButton.MouseClick += DeleteButton_MouseClick;
            RefreshButton.MouseClick += RefreshButton_MouseClick;
            directorys.dataGridView1.MouseDoubleClick += EditButton_MouseClick;

            Record.MouseClick += Record_MouseClick;
            AccuralButton.MouseClick += AccuralButton_MouseClick;
            Refresh();
        }

        private void AccuralButton_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                DateTime now = InDateDateTimePicker.Value;
                DateTime first = new DateTime(now.Year, now.Month, 1);
                DateTime last = new DateTime(now.Year, now.Month + 1, 1).AddDays(-1);
                decimal daysWork = decimal.Parse(GetBusinessDays(first, last).ToString());
                decimal hoursWork = daysWork * 8;
                decimal hourlyRate = ((Employee)((ComboboxItem)EmployeeComboBox.SelectedItem).Value)._Post.Salary / hoursWork;
                decimal sum = HoursMonthNumericUpDown.Value * hourlyRate *
                    ((Employee)((ComboboxItem)EmployeeComboBox.SelectedItem).Value)._Subdivision.Allowance;
                SumLabel.Text = System.Math.Round(sum,2).ToString();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message, "Ошибка",
                       System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        private double GetBusinessDays(DateTime startD, DateTime endD)
        {
            double calcBusinessDays =
                1 + ((endD - startD).TotalDays * 5 -
                (startD.DayOfWeek - endD.DayOfWeek) * 2) / 7;

            if (endD.DayOfWeek == DayOfWeek.Saturday) calcBusinessDays--;
            if (startD.DayOfWeek == DayOfWeek.Sunday) calcBusinessDays--;

            return calcBusinessDays;
        }


        private void DeleteButton_MouseClick(object sender, MouseEventArgs e)
        {
            OneAccrual getItem = (OneAccrual)GetSelectItem();
            if (getItem != null)
            {
                int ID = getItem.ID;

                string queryUpdate = "DELETE FROM " + TableName + " " +
                                 "WHERE ID =" + ID + ";";
                dataSQLite.Update(queryUpdate);
                Refresh();
            }
        }

        private void RefreshButton_MouseClick(object sender, MouseEventArgs e)
        {
            Refresh();
        }

        private void Record_MouseClick(object sender, MouseEventArgs e)
        {
            decimal res = 0;
            if(!decimal.TryParse(SumLabel.Text, out res))
            {
                System.Windows.Forms.MessageBox.Show("Расчитайте начисление", "Информация",
                        System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
                return;
            }
            if(!(res > 0))
            {
                System.Windows.Forms.MessageBox.Show("Расчитайте начисление", "Информация",
                        System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
                return;
            }
            if (OneAccrual is null)
            {
                string queryUpdate = "INSERT INTO " + TableName + " " +
                    "( " + EmployeeST + ", " + InDateST + ", " +
                      HoursMonthST+ ", " + SumST + ") " +
                     " VALUES ( '" + ((Employee)((ComboboxItem)EmployeeComboBox.SelectedItem).Value).ID + "', '"
                     + InDateDateTimePicker.Text + "', '" + HoursMonthNumericUpDown.Value.ToString() + "', '" +
                      res.ToString() + "');";
                dataSQLite.Update(queryUpdate);
            }
            else
            {
                string queryUpdate = "UPDATE " + TableName + " " +
                                 "SET " + EmployeeST + " = '" + ((Employee)((ComboboxItem)EmployeeComboBox.SelectedItem).Value).ID + "', " +
                                 InDateST + " = '" + InDateDateTimePicker.Text + "', " +
                                 HoursMonthST + " = '" + HoursMonthNumericUpDown.Value.ToString() + "', " +
                                 SumST + " = '" + res.ToString() + "' " +
                                 "WHERE ID =" + OneAccrual.ID + ";";
                dataSQLite.Update(queryUpdate);
            }
            editForm.Close();
            Refresh();
        }

        private void FillCombobox()
        {
            EmployeeContoll employeeContoll = new EmployeeContoll(dataSQLite);
            var employeeList = employeeContoll.Select(employeeContoll.SelectQuery);
            ComboBoxDataSource(EmployeeComboBox, employeeList);
        }

        private void EditButton_MouseClick(object sender, MouseEventArgs e)
        {
            FillCombobox();
            OneAccrual getItem = (OneAccrual)GetSelectItem();
            if (getItem != null)
            {
                OneAccrual = getItem;
                try
                {
                    EmployeeComboBox.SelectedItem = EmployeeComboBox.Items.Cast<ComboboxItem>().Where(a => ((Employee)a.Value).ID == OneAccrual._Employee.ID).First();
                    InDateDateTimePicker.Value = OneAccrual.InDate;
                    HoursMonthNumericUpDown.Value = OneAccrual.HoursMonth;
                    SumLabel.Text = OneAccrual.Sum.ToString();
                    editForm.ShowDialog();
                    OneAccrual = null;
                    Refresh();
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message, "Ошибка",
                        System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                }

            }

        }


        private void AddButton_MouseClick(object sender, MouseEventArgs e)
        {
            FillCombobox();
            Clear();
            editForm.ShowDialog();
        }

        private void Clear()
        {
            InDateDateTimePicker.Value = DateTime.Now;
            HoursMonthNumericUpDown.Value = decimal.Zero;
            SumLabel.Text = decimal.Zero.ToString();
        }

        private void Refresh()
        {            
            directorys.dataGridView1.DataSource = Select(SelectQuery);
            ColumnNameHeader();
        }

        private void ColumnNameHeader()
        {
            if (directorys.dataGridView1.Columns.Count >= 4)
            {
                directorys.dataGridView1.Columns[0].HeaderText = "ИД";
                directorys.dataGridView1.Columns[1].HeaderText = "ФИО должность";
                directorys.dataGridView1.Columns[2].HeaderText = "На дату";
                directorys.dataGridView1.Columns[3].HeaderText = "Количество часов";
                directorys.dataGridView1.Columns[4].HeaderText = "Сумма";
                directorys.dataGridView1.Columns[5].Visible = false;
            }
        }


        public override void LoadEditForm()
        {
            InitLabel(EmployeeLabel, "Employee", "Сотрудник");
            InitComboBox(EmployeeComboBox, "Employee");

            InitLabel(InDateLabel, "InDate", "На дату");
            InitDateTimePiker(InDateDateTimePicker, "InDateDate");

            InitLabel(HoursMonthLabel, "HoursMonth", "Отработанных часов");
            InitNumericUpDown(HoursMonthNumericUpDown, "HoursMonth", 2);

            InitLabel(ViewSumLabel, "ViewSum", "Итого сумма:");
            InitLabel(SumLabel, "SumLabel", decimal.Zero.ToString());

            InitEditDefaultButton(AccuralButton, "AccuralButton", "Расчитать");
        }

        public override object ReaderVirtual()
        {
            DateTime DateBirth = reader.GetValue(5).ToString() == string.Empty ? DateTime.Now : DateTime.Parse(reader.GetValue(5).ToString());
            DateTime inDate = reader.GetValue(13).ToString() == string.Empty ? DateTime.Now : DateTime.Parse(reader.GetValue(13).ToString());
            PhisicalFace phisicalFace = new PhisicalFace()
            {
                ID = int.Parse(reader.GetValue(1).ToString()),
                Surname = reader.GetValue(2).ToString(),
                Name = reader.GetValue(3).ToString(),
                Patronymic = reader.GetValue(4).ToString(),
                DateBirth = DateBirth
            };
            Post post = new Post()
            {
                ID = int.Parse(reader.GetValue(6).ToString()),
                Name = reader.GetValue(7).ToString(),
                Salary = decimal.Parse(reader.GetValue(8).ToString())
            };
            Subdivision subdivision = new Subdivision()
            {
                ID = int.Parse(reader.GetValue(9).ToString()),
                Name = reader.GetValue(10).ToString(),
                Allowance = decimal.Parse(reader.GetValue(11).ToString())
            };
            Employee employee = new Employee()
            {
                ID = int.Parse(reader.GetValue(0).ToString()),
                _PhisicalFace = phisicalFace,
                _Post = post,
                _Subdivision = subdivision
            };

            OneAccrual oneAccrual = new OneAccrual()
            {
                _Employee = employee,
                ID = int.Parse(reader.GetValue(12).ToString()),
                InDate = inDate,
                HoursMonth = decimal.Parse(reader.GetValue(14).ToString()),
                Sum = decimal.Parse(reader.GetValue(15).ToString())
            };

            return oneAccrual;
        }
    }
}
