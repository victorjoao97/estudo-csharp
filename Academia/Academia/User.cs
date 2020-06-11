using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia
{
    class User
    {
        private int id;
        private string username;
        private string password;
        
        public User()
        {
            id = 0;
            username = null;
            password = null;
        }

        public User(int id, string username, string password)
        {
            this.id = id;
            this.username = username;
            this.password = password;
        }

        public static User Exists(string username, string password)
        {
            DataTable dataTable = new DataTable();

            dataTable = Banco.Query($"select * from usuarios where usuario = '{username}' and senha = '{password}'");

            if(dataTable.Rows.Count > 0)
            {
                return new User(Int32.Parse(dataTable.Rows[0]["id"].ToString()), dataTable.Rows[0]["username"].ToString(), dataTable.Rows[0]["password"].ToString());
            }
            else
            {
                return new User();
            }
        }
    }
}
