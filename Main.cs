using System;
using System.Windows.Forms;
using PayrollPersonnelManagement.Common;

namespace PayrollPersonnelManagement
{
    public partial class Main : Form
    {
        AddEditRead Table { get; set; }
        DataSQLite DataSQLite;
        string pathSQLite = System.IO.Directory.GetCurrentDirectory()+ @"\PayrollPersonnelManagement.db";
        public Main()
        {
            InitializeComponent();
            DataSQLite = new DataSQLite(pathSQLite);
            Table = new EmployeeContoll(panel3, new EditForm(), DataSQLite);
        }

        private void сотрудникToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Table = new EmployeeContoll(panel3, new EditForm(), DataSQLite);
        }


        private void физическоеЛицоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Table = new PhisicalFaceControll(panel3, new EditForm(), DataSQLite);
        }

        private void должностьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Table = new PostContoll(panel3, new EditForm(), DataSQLite);
        }

        private void подразделениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Table = new SubdivisionControll(panel3, new EditForm(), DataSQLite);
        }

        private void расчетToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Table = new OneAccuralControll(panel3, new EditForm(), DataSQLite);
        }
    }
}
