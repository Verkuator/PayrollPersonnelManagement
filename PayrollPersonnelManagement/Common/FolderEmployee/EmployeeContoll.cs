using System;
using System.Linq;
using System.Windows.Forms;

namespace PayrollPersonnelManagement.Common
{
    
    class EmployeeContoll : AddEditRead
    {
        Label PhisicalFaceLabel = new Label();
        ComboBox PhisicalFaceComboBox = new ComboBox();
        Label PostLabel = new Label();
        ComboBox PostComboBox = new ComboBox();
        Label SubdivisionLabel = new Label();
        ComboBox SubdivisionComboBox = new ComboBox();
        Employee Employee { get; set; }
        const string TableName = "Employee";
        const string PhisicalFaceST = "PhisicalFace";
        const string PostST = "Post";
        const string SubdivisionST = "Subdivision";

        public string SelectQuery = "SELECT " +
                TableName + ".ID, " +
                " PhisicalFace.*, " +
                "Post.*, " +
                "Subdivision.* " +
                "FROM " + TableName + " " +
                "INNER JOIN PhisicalFace ON PhisicalFace.ИД = Employee.PhisicalFace " +
                "INNER JOIN Post ON Post.ИД = Employee.Post " +
                "INNER JOIN Subdivision ON Subdivision.ИД = Employee.Subdivision; ";

        public EmployeeContoll(DataSQLite dataSQLite) : base(dataSQLite) { }
        public EmployeeContoll(Panel panel, EditForm editForm, DataSQLite dataSQLite)
            : base(panel, editForm, dataSQLite)
        {
            Title = "Сотрудник";

            AddButton.MouseClick += AddButton_MouseClick;
            EditButton.MouseClick += EditButton_MouseClick;
            DeleteButton.MouseClick += DeleteButton_MouseClick;
            RefreshButton.MouseClick += RefreshButton_MouseClick;
            directorys.dataGridView1.MouseDoubleClick += EditButton_MouseClick;

            Record.MouseClick += Record_MouseClick;
            Refresh();
        }

        private void DeleteButton_MouseClick(object sender, MouseEventArgs e)
        {
            Employee getItem = (Employee)GetSelectItem();
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
            if (Employee is null)
            {
                string queryUpdate = "INSERT INTO " + TableName + " " +
                    "( " + PhisicalFaceST + ", " + PostST + ", " + SubdivisionST + ") " +
                     " VALUES ( '" + ((PhisicalFace)((ComboboxItem)PhisicalFaceComboBox.SelectedItem).Value).ID + "', '" 
                     + ((Post)((ComboboxItem)PostComboBox.SelectedItem).Value).ID + "', '"
                     + ((Subdivision)((ComboboxItem)SubdivisionComboBox.SelectedItem).Value).ID + "');";
                dataSQLite.Update(queryUpdate);
            }
            else
            {
                string queryUpdate = "UPDATE " + TableName + " " +
                                 "SET " + PhisicalFaceST + " = '" + ((PhisicalFace)((ComboboxItem)PhisicalFaceComboBox.SelectedItem).Value).ID + "', " +
                                 PostST + " = '" + ((Post)((ComboboxItem)PostComboBox.SelectedItem).Value).ID + "', " +
                                 SubdivisionST + " = '" + ((Subdivision)((ComboboxItem)SubdivisionComboBox.SelectedItem).Value).ID + "' " +
                                 "WHERE ID =" + Employee.ID + ";";
                dataSQLite.Update(queryUpdate);
            }
            editForm.Close();
            Refresh();
        }

        private void FillCombobox()
        {
            PhisicalFaceControll phisicalFaceControll = new PhisicalFaceControll(dataSQLite);
            var phisicalFaceList = phisicalFaceControll.Select(phisicalFaceControll.SelectQuery);
            ComboBoxDataSource(PhisicalFaceComboBox, phisicalFaceList);

            PostContoll postControll = new PostContoll(dataSQLite);
            var postList = postControll.Select(postControll.SelectQuery);
            ComboBoxDataSource(PostComboBox, postList);

            SubdivisionControll subdivisionControll = new SubdivisionControll(dataSQLite);
            var subdivisionList = subdivisionControll.Select(subdivisionControll.SelectQuery);
            ComboBoxDataSource(SubdivisionComboBox, subdivisionList);
        }

        private void EditButton_MouseClick(object sender, MouseEventArgs e)
        {
            FillCombobox();
            Employee getItem = (Employee)GetSelectItem();
            if (getItem != null)
            {
                Employee = getItem;
                try
                {
                    PhisicalFaceComboBox.SelectedItem = PhisicalFaceComboBox.Items.Cast<ComboboxItem>().Where(a => ((PhisicalFace)a.Value).ID == Employee._PhisicalFace.ID).First();
                    PostComboBox.SelectedItem = PostComboBox.Items.Cast<ComboboxItem>().Where(a => ((Post)a.Value).ID == Employee._Post.ID).First();
                    SubdivisionComboBox.SelectedItem = SubdivisionComboBox.Items.Cast<ComboboxItem>().Where(a => ((Subdivision)a.Value).ID == Employee._Subdivision.ID).First();
                    editForm.ShowDialog();
                    Employee = null;
                    Refresh();
                }
                catch(Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message, "Ошибка",
                        System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                }
                
            }

        }

        
        private void AddButton_MouseClick(object sender, MouseEventArgs e)
        {            
            FillCombobox();
            //Clear();
            editForm.ShowDialog();
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
                directorys.dataGridView1.Columns[1].HeaderText = "ФИО";
                directorys.dataGridView1.Columns[2].HeaderText = "Подразделение";
                directorys.dataGridView1.Columns[3].HeaderText = "Должность";
                directorys.dataGridView1.Columns[4].Visible = false;
                directorys.dataGridView1.Columns[5].Visible = false;
                directorys.dataGridView1.Columns[6].Visible = false;
            }
        }


        public override void LoadEditForm()
        {
            InitLabel(PhisicalFaceLabel, "PhisicalFace", "Физическое лицо");
            InitComboBox(PhisicalFaceComboBox, "PhisicalFace");

            InitLabel(SubdivisionLabel, "Subdivision", "Подразделение");
            InitComboBox(SubdivisionComboBox, "Subdivision");

            InitLabel(PostLabel, "Post", "Должность");
            InitComboBox(PostComboBox, "Post");
        }

        public override object ReaderVirtual()
        {
            DateTime DateBirth = reader.GetValue(5).ToString() == string.Empty ? DateTime.Now : DateTime.Parse(reader.GetValue(5).ToString());
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

            if (listCombobox)
            {
                ComboboxItem comboboxItem = new ComboboxItem()
                {
                    Text = employee.FIO + " " + employee.Post,
                    Value = employee
                };
                return comboboxItem;
            }

            return employee;
        }
    }
}
