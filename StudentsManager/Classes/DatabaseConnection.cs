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

        public MySqlDataReader? ExecuteQuery(string queryString, MySqlParameter[] paramsArray)
        {
            if (this.connection != null)
            {
                try
                {
                    using (MySqlCommand cmd = this.connection.CreateCommand())
                    {
                        cmd.CommandText = queryString;
                        cmd.Parameters.AddRange(paramsArray);
                        return cmd.ExecuteReader();
                    }
                }
                catch (MySqlException error)
                {
                    MessageBox.Show(error.Message, "Database Error");
                    return null;
                }
            }
            else
                return null;
        }

        public MySqlConnection Connection { get; }
    }
}
