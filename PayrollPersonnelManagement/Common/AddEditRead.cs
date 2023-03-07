using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Windows.Forms;

namespace PayrollPersonnelManagement.Common
{
    abstract class AddEditRead
    {
        private string _title = string.Empty;
        protected string Title
        {
            get
            { return _title; }
            set 
            { 
                _title = value;
                directorys.Title.Text = _title;
                EditDefault.Title.Text = _title;
            }
        }
        protected bool listCombobox = false;

        protected Panel panelMain { get; set; }
        protected EditForm editForm { get; set; }
        protected Directorys directorys {get; set;}
        protected EditDefault EditDefault { get; set; }
        protected DataSQLite dataSQLite { get; set; }

        protected SQLiteDataReader reader;


        protected Button AddButton = new Button();
        protected Button EditButton = new Button();
        protected Button DeleteButton = new Button();
        protected Button RefreshButton = new Button();
        protected Button Record = new Button();
        public AddEditRead(DataSQLite dataSQLite) { this.dataSQLite = dataSQLite; listCombobox = true; }
        public AddEditRead(Panel panel, EditForm editForm, DataSQLite dataSQLite)
        {
            panelMain = panel;
            this.editForm = editForm;
            this.dataSQLite = dataSQLite;

            panelMain.Controls.Clear();
            directorys = new Directorys();
            panelMain.Controls.Add(directorys);
            directorys.Dock = DockStyle.Fill;

            EditDefault = new EditDefault();
            editForm.panel1.Controls.Add(EditDefault);
            EditDefault.Dock = DockStyle.Fill;

            directorys.flowLayoutPanel1.Controls.Add(AddButton);
            directorys.flowLayoutPanel1.Controls.Add(EditButton);
            directorys.flowLayoutPanel1.Controls.Add(DeleteButton);
            directorys.flowLayoutPanel1.Controls.Add(RefreshButton);

            AddButton.Text = "Добавить";
            EditButton.Text = "Изменить";
            DeleteButton.Text = "Удалить";
            RefreshButton.Text = "Обновить";
            InitEditDefaultButton(Record, "Record", "Записать");

            LoadEditForm();
        }

        protected System.Drawing.Font GetFont()
        {
            return new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        }


        public abstract void LoadEditForm();

        protected void InitLabel(Label label, string name, string text)
        {
            label.AutoSize = true;
            label.Font = GetFont();
            label.Name = name + "Label";
            label.Text = text;
            EditDefault.flowLayoutPanel1.Controls.Add(label);
        }

        protected void InitTextbox(TextBox textBox, string name)
        {
            textBox.Font = GetFont();
            textBox.MaxLength = 50;
            textBox.Name = name + "TextBox";
            textBox.Size = new System.Drawing.Size(350, 30);
            EditDefault.flowLayoutPanel1.Controls.Add(textBox);
        }

        protected void InitDateTimePiker(DateTimePicker dateTimePicker, string name)
        {
            dateTimePicker.Name = name + "DateTimePicker";
            dateTimePicker.Size = new System.Drawing.Size(200, 22);
            EditDefault.flowLayoutPanel1.Controls.Add(dateTimePicker);
        }

        protected void InitEditDefaultButton(Button button, string name, string text)
        {
            button.Dock = System.Windows.Forms.DockStyle.Top;
            button.Location = new System.Drawing.Point(3, 18);
            button.Name = name;
            button.Size = new System.Drawing.Size(408, 37);
            button.TabIndex = 0;
            button.Text = text;
            button.UseVisualStyleBackColor = true;
            EditDefault.groupBox1.Controls.Add(button);
        }

        public List<object> Select(string query)
        {
            try
            {
                List<object> listobj = new List<object>();
                SQLiteCommand command = new SQLiteCommand(query, dataSQLite.SQLiteConnection);
                using (reader = command.ExecuteReader())
                {
                    if (reader.HasRows) // если есть данные
                    {
                        while (reader.Read())   // построчно считываем данные
                        {
                            object obj = ReaderVirtual();
                            listobj.Add(obj);
                        }
                    }
                }
                return listobj;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message, "Ошибка",
                        System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                return null;
            }
        }

        public abstract object ReaderVirtual();

        protected void InitNumericUpDown(NumericUpDown numericUpDown, string name, int decimalPlaces)
        {
            numericUpDown.DecimalPlaces = decimalPlaces;
            numericUpDown.Font = GetFont();
            numericUpDown.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            numericUpDown.Name = name+"NumericUpDown";
            numericUpDown.Size = new System.Drawing.Size(350, 30);
            EditDefault.flowLayoutPanel1.Controls.Add(numericUpDown);
        }

        protected void ComboBoxDataSource(ComboBox comboBox, List<object> listobj)
        {
            comboBox.DataSource = listobj;
            comboBox.DisplayMember = "Text";
            comboBox.ValueMember = "Value";            
        }

        protected void InitComboBox(ComboBox comboBox, string name)
        {
            comboBox.Font = GetFont();
            comboBox.FormattingEnabled = true;
            comboBox.Name = name + "ComboBox";
            comboBox.Size = new System.Drawing.Size(350, 30);
            comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            EditDefault.flowLayoutPanel1.Controls.Add(comboBox);
        }

        protected object GetSelectItem()
        {
            object getItem = null;
            DataGridViewSelectedRowCollection getRows = directorys.dataGridView1.SelectedRows;
            if (getRows.Count > 0 && getRows[0].DataBoundItem != null)
            {
                getItem = getRows[0].DataBoundItem;
            }
            return getItem;
        }

    }
}
