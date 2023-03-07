using System;
using System.Windows.Forms;

namespace PayrollPersonnelManagement.Common
{
    class PhisicalFaceControll : AddEditRead
    {
        Label SurnameLabel = new Label();
        TextBox SurnameTextBox = new TextBox();
        Label NameLabel = new Label();
        TextBox NameTextBox = new TextBox();
        Label PatronymicLabel = new Label();
        TextBox PatronymicTextBox = new TextBox();
        Label DateBirthLabel = new Label();
        DateTimePicker DateBirthDateTimePicker = new DateTimePicker();
        PhisicalFace PhisicalFace { get; set; }
        const string TableName = "PhisicalFace";
        const string Surname = "[Фамилия]";
        const string Name = "[Имя]";
        const string Patronymic = "[Отчество]";
        const string DateBirth = "[Дата рождения]";
        public string SelectQuery = "Select * FROM " + TableName;
        public PhisicalFaceControll(DataSQLite dataSQLite) : base(dataSQLite) { }
        public PhisicalFaceControll(Panel panel, EditForm editForm, DataSQLite dataSQLite) 
            : base(panel, editForm, dataSQLite)
        {
            Title = "Физическое лицо";            

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
            PhisicalFace getItem = (PhisicalFace) GetSelectItem();
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
            if(PhisicalFace is null)
            {
                string queryUpdate = "INSERT INTO " + TableName + " " +
                    "( " + Surname + ", " + Name + ", " + Patronymic + ", " + DateBirth + ") " +
                     " VALUES ( '" + SurnameTextBox.Text + "', '" + NameTextBox.Text + "', '" + PatronymicTextBox.Text + "', '"
                     + DateBirthDateTimePicker.Text + "');";
                dataSQLite.Update(queryUpdate);
            }
            else
            {
                string queryUpdate = "UPDATE " + TableName + " " +
                                 "SET " + Surname + " = '" + SurnameTextBox.Text + "', " +
                                 Name + " = '" + NameTextBox.Text + "', " +
                                 Patronymic + " = '" + PatronymicTextBox.Text + "', " +
                                 DateBirth + " = '" + DateBirthDateTimePicker.Text + "' " +
                                 "WHERE ИД =" + PhisicalFace.ID + ";";
                dataSQLite.Update(queryUpdate);                
            }
            editForm.Close();
            Refresh();
        }

        

        private void EditButton_MouseClick(object sender, MouseEventArgs e)
        {
            PhisicalFace getItem = (PhisicalFace) GetSelectItem();
            if(getItem != null)
            { 
                PhisicalFace = getItem;

                SurnameTextBox.Text = PhisicalFace.Surname;
                NameTextBox.Text = PhisicalFace.Name;
                PatronymicTextBox.Text = PhisicalFace.Patronymic;
                DateBirthDateTimePicker.Value = PhisicalFace.DateBirth;
                editForm.ShowDialog();
                PhisicalFace = null;
                Refresh();
            }            

        }

        private void Clear()
        {
            SurnameTextBox.Text = string.Empty;
            NameTextBox.Text = string.Empty;
            PatronymicTextBox.Text = string.Empty;
            DateBirthDateTimePicker.Value = DateTime.Now;
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
            if (directorys.dataGridView1.Columns.Count >= 5)
            {
                directorys.dataGridView1.Columns[0].HeaderText = "ИД";
                directorys.dataGridView1.Columns[1].HeaderText = "Фамилия";
                directorys.dataGridView1.Columns[2].HeaderText = "Имя";
                directorys.dataGridView1.Columns[3].HeaderText = "Отчество";
                directorys.dataGridView1.Columns[4].HeaderText = "Дата рождения";
            }
        }


        public override void LoadEditForm()
        {
            InitLabel(SurnameLabel, "Surname", "Фамилия");
            InitTextbox(SurnameTextBox, "Surname");

            InitLabel(NameLabel, "Name", "Имя");
            InitTextbox(NameTextBox, "Name");

            InitLabel(PatronymicLabel, "Patronymic", "Отчество");
            InitTextbox(PatronymicTextBox, "Patronymic");

            InitLabel(DateBirthLabel, "DateBirth", "Дата рождения");
            InitDateTimePiker(DateBirthDateTimePicker, "DateBirth");
        }

        public override object ReaderVirtual()
        {
            DateTime DateBirth = reader.GetValue(4).ToString() == string.Empty ? DateTime.Now : DateTime.Parse(reader.GetValue(4).ToString());
            PhisicalFace phisicalFace = new PhisicalFace()
            {
                ID = int.Parse(reader.GetValue(0).ToString()),
                Surname = reader.GetValue(1).ToString(),
                Name = reader.GetValue(2).ToString(),
                Patronymic = reader.GetValue(3).ToString(),
                DateBirth = DateBirth
            };
            if (listCombobox)
            {
                ComboboxItem comboboxItem = new ComboboxItem()
                {
                    Text = phisicalFace.Surname +" "+ phisicalFace.Name + " " + phisicalFace.Patronymic,
                    Value = phisicalFace
                };
                return comboboxItem;
            }
            
            return phisicalFace;
        }
    }
}
