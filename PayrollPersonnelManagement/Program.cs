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
            DateTime date = new DateTime(1969, 5, 15);

            PayrollPersonnelManagementContext _dbContext = new PayrollPersonnelManagementContext();

            PhisicalFaceControll phisicalFaceControll = new PhisicalFaceControll(_dbContext);

            phisicalFaceControll.AddPhisicalFace("Жмышенко", "Валерий", "Альбертович", date);
            var persons = phisicalFaceControll.GetPhisicalFaceList();
            Console.WriteLine(persons);
        }
    }
}
