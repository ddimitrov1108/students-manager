using MySql.Data.MySqlClient;
using StudentsManager.Classes;
using StudentsManager.Forms;

namespace StudentsManager
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            DotNetEnv.Env.Load();

            MySqlConnection connection = new MySqlConnection(
                $"SERVER={ DotNetEnv.Env.GetString("DATABASE_SERVER") };" +
                $"DATABASE={ DotNetEnv.Env.GetString("DATABASE_NAME") };" +
                $"UID={ DotNetEnv.Env.GetString("DATABASE_USER") };" +
                $"PASSWORD={ DotNetEnv.Env.GetString("DATABASE_PASSWORD") };"
            );

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
                Application.Run(new LoginForm(connection));
        }
    }
}