using System;
using System.Data.SQLite;
namespace PayrollPersonnelManagement.Common
{
    class DataSQLite
    {
        internal SQLiteConnection SQLiteConnection;

        public DataSQLite(string pathSQLite)
        {
            try
            {
                if(!System.IO.File.Exists(pathSQLite))
                {
                    System.Windows.Forms.MessageBox.Show("База данных не найдена", "Ошибка",
                        System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);  
                }
                else
                {
                    SQLiteConnection = new SQLiteConnection("data source="+pathSQLite);
                    SQLiteConnection.Open();
                }
            }
            catch(Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message, "Ошибка",
                        System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }


        

        public void Update(string query)
        {
            try
            {
                SQLiteCommand cmd = new SQLiteCommand(query, SQLiteConnection);
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message, "Ошибка",
                        System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }
    }
}
