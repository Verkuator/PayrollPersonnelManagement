using PayrollPersonnelManagement.CreateSQLite;
using System;

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
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Main());
        }
    }
}
