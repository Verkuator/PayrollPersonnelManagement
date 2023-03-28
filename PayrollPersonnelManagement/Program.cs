using PayrollPersonnelManagement.CreateSQLite;
using PayrollPersonnelManagement.View;
using System;
using System.Windows.Forms;
using PayrollPersonnelManagement.Infasrtucture.Controll;
using PayrollPersonnelManagement.context;

namespace PayrollPersonnelManagement
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            SQLiteCreateDb.CreateSQLite();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());
        }
    }
}
