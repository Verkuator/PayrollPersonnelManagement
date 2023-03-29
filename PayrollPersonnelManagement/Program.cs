using PayrollPersonnelManagement.CreateSQLite;
using PayrollPersonnelManagement.View;
using System;
using System.Windows.Forms;
using PayrollPersonnelManagement.context;
using PayrollPersonnelManagement.View.UI.FormSave;
using PayrollPersonnelManagement.Infasrtucture.Controll;

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
            ControllHelper.Initialize(new PayrollPersonnelManagementContext());
            Application.Run(new Main());
        }
    }
}
