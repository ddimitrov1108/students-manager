using MySql.Data.MySqlClient;
using StudentsManager.Classes;
using StudentsManager.Forms;

namespace StudentsManager
{
    internal static class Program
    {
        public static MySqlConnection dbConnection;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            DotNetEnv.Env.Load();

            Program.dbConnection = new MySqlConnection(
                $"SERVER={ DotNetEnv.Env.GetString("DATABASE_SERVER") };" +
                $"DATABASE={ DotNetEnv.Env.GetString("DATABASE_NAME") };" +
                $"UID={ DotNetEnv.Env.GetString("DATABASE_USER") };" +
                $"PASSWORD={ DotNetEnv.Env.GetString("DATABASE_PASSWORD") };"
            );

            try
            {
                Program.dbConnection.Open();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
                Application.Run(new LoginForm());
        }
    }
}