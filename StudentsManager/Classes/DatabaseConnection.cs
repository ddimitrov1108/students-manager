using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace StudentsManager.Classes
{
    public class DatabaseConnection
    {
        private MySqlConnection? connection = null;
        private MySqlCommand? command = null;
        private MySqlDataReader? reader = null;

        public DatabaseConnection()
        {
            this.connection = new MySqlConnection(
                $"SERVER={ DotNetEnv.Env.GetString("DATABASE_SERVER") };" +
                $"DATABASE={ DotNetEnv.Env.GetString("DATABASE_NAME") };" +
                $"UID={ DotNetEnv.Env.GetString("DATABASE_USER") };" +
                $"PASSWORD={ DotNetEnv.Env.GetString("DATABASE_PASSWORD") };"
            );
        }

        public void openConnection()
        {
            try
            {
                if(this.connection != null)
                    this.connection.Open();
            }
            catch(MySqlException error)
            {
                MessageBox.Show(error.Message, "Database Error");
                Application.Exit();
            }
        }

        public void endConnection()
        {
            connection = null;
        }

        public void ExecuteQuery(string queryString, MySqlParameter[] paramsArray)
        {

        }

        public MySqlConnection Connection { get; }
    }
}
