using System;
using System.Data.SQLite;
using System.IO;

namespace PayrollPersonnelManagement.CreateSQLite
{
    public class SQLiteCreateDb
    {
        public static string ConnectionSring { get; set; }
        private static string _sqliteFile = "PayrollPersonnelManagement.sqlite";

        public static void CreateSQLite()
        {
            ConnectionSring = "Data Source=" + _sqliteFile + "; Version=3;";
            if (File.Exists(Environment.CurrentDirectory + @"\" + _sqliteFile))
            {
                return;
            }
            SQLiteConnection.CreateFile(_sqliteFile);
        }
    }
}
