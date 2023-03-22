namespace PayrollPersonnelManagement.CreateSQLite
{
    public class SQLiteCreateDb
    {
        public static string ConnectionSring { get; set; }
        private static string _sqliteFile = "PayrollPersonnelManagement.sqlite";

        public static void CreateSQLite()
        {
            //SQLitePCL.Batteries.Init();

            //using (var connection = new SqliteConnection("Data Source=PayrollPersonnelManagement.db"))
            //{
            //    connection.Open();
            //}

            //var MyDataConnection = new SqliteConnection("Data Source=PayrollPersonnelManagement.db;");
            SQLitePCL.Batteries.Init();
            //MyDataConnection.Open();
        }
    }
}
