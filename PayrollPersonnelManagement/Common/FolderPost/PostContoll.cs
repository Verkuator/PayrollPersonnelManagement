using System.Windows.Forms;

namespace PayrollPersonnelManagement.Common
{
    class PostContoll : AddEditRead
    {
        Label NameLabel = new Label();
        TextBox NameTextBox = new TextBox();
        Label SalaryLabel = new Label();
        NumericUpDown SalaryNumericUpDown = new NumericUpDown();
        Post Post { get; set; }
        const string TableName = "Post";
        const string Name = "[Должность]";
        const string Salary = "[Оклад]";
        public string SelectQuery = "Select * FROM " + TableName;
        public PostContoll(DataSQLite dataSQLite) : base(dataSQLite) { }
        public PostContoll(Panel panel, EditForm editForm, DataSQLite dataSQLite)
            : base(panel, editForm, dataSQLite)
        {
            Title = "Должность";

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
            Post getItem = (Post) GetSelectItem();
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
            if (Post is null)
            {
                string queryUpdate = "INSERT INTO " + TableName + " " +
                    "( " + Name + ", " + Salary + ") " +
                     " VALUES ( '" + NameTextBox.Text + "', '" + SalaryNumericUpDown.Value.ToString() + "');";
                dataSQLite.Update(queryUpdate);
            }
            else
            {
                string queryUpdate = "UPDATE " + TableName + " " +
                                 "SET " + Name + " = '" + NameTextBox.Text + "', " +
                                 Salary + " = '" + SalaryNumericUpDown.Value.ToString() +  "' " +
                                 "WHERE ИД =" + Post.ID + ";";
                dataSQLite.Update(queryUpdate);
            }
            editForm.Close();
            Refresh();
        }



        private void EditButton_MouseClick(object sender, MouseEventArgs e)
        {
            Post getItem = (Post) GetSelectItem();
            if (getItem != null)
            {
                Post = getItem;

                NameTextBox.Text = Post.Name;
                SalaryNumericUpDown.Value = Post.Salary;
                editForm.ShowDialog();
                Post = null;
                Refresh();
            }

        }

        private void Clear()
        {
            NameTextBox.Text = string.Empty;
            SalaryNumericUpDown.Value = decimal.Zero;
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
            if (directorys.dataGridView1.Columns.Count >= 3)
            {
                directorys.dataGridView1.Columns[0].HeaderText = "ИД";
                directorys.dataGridView1.Columns[1].HeaderText = "Должность";
                directorys.dataGridView1.Columns[2].HeaderText = "Оклад";
            }
        }

        public override void LoadEditForm()
        {
            InitLabel(NameLabel, "Name", "Должность");
            InitTextbox(NameTextBox, "Name");

            InitLabel(SalaryLabel, "Salary", "Оклад");
            InitNumericUpDown(SalaryNumericUpDown, "Salary", 2);
        }

        public override object ReaderVirtual()
        {            
            Post post = new Post()
            {
                ID = int.Parse(reader.GetValue(0).ToString()),
                Name = reader.GetValue(1).ToString(),
                Salary = decimal.Parse(reader.GetValue(2).ToString())
            };
            if (listCombobox)
            {
                ComboboxItem comboboxItem = new ComboboxItem()
                {
                    Text = post.Name,
                    Value = post
                };
                return comboboxItem;
            }

            return post;
        }
    }
}
