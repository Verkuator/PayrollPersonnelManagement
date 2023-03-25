using PayrollPersonnelManagement.CreateSQLite;
using PayrollPersonnelManagement.View;
using System;
using System.Windows.Forms;
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
            Application.Run(new frmMain());
            DateTime date = new DateTime(1969, 5, 15);
            PhisicalFaceControll.AddPhisicalFace("Жмышенко", "Валерий", "Альбертович", date);
            var persons = PhisicalFaceControll.GetPhisicalFaceList();
            Console.WriteLine(persons);
        }
    }
}
