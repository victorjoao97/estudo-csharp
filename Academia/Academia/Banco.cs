using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;

namespace Academia
{
    class Banco
    {
        private static SQLiteConnection connection;

        private static SQLiteConnection Conectar()
        {
            connection = new SQLiteConnection(@"Data Source = C:\Users\victo\source\repos\Academia\Academia\banco\banco_academia.db");
            connection.Open();
            return connection;
        }

        public static DataTable GetAllUsers()
        {
            DataTable dataTable = new DataTable();

            SQLiteCommand command = Conectar().CreateCommand();
            command.CommandText = "select * from usuarios";
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
            adapter.Fill(dataTable);
            Conectar().Close();
            return dataTable;
        }

        public static DataTable Query(string sql)
        {
            DataTable dataTable = new DataTable();

            SQLiteCommand command = Conectar().CreateCommand();
            command.CommandText = sql;
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
            adapter.Fill(dataTable);
            Conectar().Close();
            return dataTable;
        }


    }
}
