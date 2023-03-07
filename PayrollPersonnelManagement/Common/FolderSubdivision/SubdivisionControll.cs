using System.Windows.Forms;

namespace PayrollPersonnelManagement.Common
{
    class SubdivisionControll : AddEditRead
    {
        Label NameLabel = new Label();
        TextBox NameTextBox = new TextBox();
        Label AllowanceLabel = new Label();
        NumericUpDown AllowanceNumericUpDown = new NumericUpDown();
        Subdivision Subdivision { get; set; }
        const string TableName = "Subdivision";
        const string Name = "[Подразделение]";
        const string Allowance = "[Надбавка]";
        public string SelectQuery = "Select * FROM " + TableName;
        public SubdivisionControll(DataSQLite dataSQLite) : base(dataSQLite) { }

        public SubdivisionControll(Panel panel, EditForm editForm, DataSQLite dataSQLite)
            : base(panel, editForm, dataSQLite)
        {
            Title = "Подразделение";

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
            Subdivision getItem = (Subdivision)GetSelectItem();
            if (getItem != null)
            {
                int ID = getItem.ID;

                string queryUpdate = "DELETE FROM " + TableName + " " +
                                 "WHERE ИД =" + ID + ";";
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
            if (Subdivision is null)
            {
                string queryUpdate = "INSERT INTO " + TableName + " " +
                    "( " + Name + ", " + Allowance + ") " +
                     " VALUES ( '" + NameTextBox.Text + "', '" + AllowanceNumericUpDown.Value + "');";
                dataSQLite.Update(queryUpdate);
            }
            else
            {
                string queryUpdate = "UPDATE " + TableName + " " +
                                 "SET " + Name + " = '" + NameTextBox.Text + "', " +
                                 Allowance + " = '" + AllowanceNumericUpDown.Value + "' " +
                                 "WHERE ИД =" + Subdivision.ID + ";";
                dataSQLite.Update(queryUpdate);
            }
            editForm.Close();
            Refresh();
        }



        private void EditButton_MouseClick(object sender, MouseEventArgs e)
        {
            Subdivision getItem = (Subdivision)GetSelectItem();
            if (getItem != null)
            {
                Subdivision = getItem;

                NameTextBox.Text = Subdivision.Name;
                AllowanceNumericUpDown.Value = Subdivision.Allowance;

                editForm.ShowDialog();
                Subdivision = null;
                Refresh();
            }

        }

        private void Clear()
        {
            NameTextBox.Text = string.Empty;
            AllowanceNumericUpDown.Value = decimal.Zero;
        }
        private void AddButton_MouseClick(object sender, MouseEventArgs e)
        {
            Clear();
            editForm.ShowDialog();
        }

        private void Refresh()
        {
            directorys.dataGridView1.DataSource = Select(SelectQuery);
            ColumnNameHeader();
        }

        private void ColumnNameHeader()
        {
            if(directorys.dataGridView1.Columns.Count >= 3)
            {
                directorys.dataGridView1.Columns[0].HeaderText = "ИД";
                directorys.dataGridView1.Columns[1].HeaderText = "Подразделение";
                directorys.dataGridView1.Columns[2].HeaderText = "Надбавка";

            }
        }


        public override void LoadEditForm()
        {
            InitLabel(NameLabel, "Name", "Подразделение");
            InitTextbox(NameTextBox, "Name");

            InitLabel(AllowanceLabel, "Allowance", "Надбавка");
            InitNumericUpDown(AllowanceNumericUpDown, "Allowance", 2);
        }

        public override object ReaderVirtual()
        {
            Subdivision subdivision = new Subdivision()
            {
                ID = int.Parse(reader.GetValue(0).ToString()),
                Name = reader.GetValue(1).ToString(),
                Allowance = decimal.Parse(reader.GetValue(2).ToString())
            };
            if (listCombobox)
            {
                ComboboxItem comboboxItem = new ComboboxItem()
                {
                    Text = subdivision.Name,
                    Value = subdivision
                };
                return comboboxItem;
            }
            return subdivision;
        }
    }
}
