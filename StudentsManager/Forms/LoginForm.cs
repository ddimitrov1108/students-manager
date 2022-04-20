using MySql.Data.MySqlClient;
using StudentsManager.Classes;
using System.Media;

namespace StudentsManager.Forms
{
    public partial class LoginForm : Form
    {
        MySqlConnection db;

        public LoginForm(MySqlConnection connection)
        {
            db = connection;
            db.Open();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(emailInput.Text))
            {
                try
                {
                    using (MySqlCommand cmd = db.CreateCommand())
                    {

                        cmd.CommandText = "SELECT * FROM users WHERE email = ?email LIMIT 1";
                        cmd.Parameters.AddRange(new MySqlParameter[]
                        {
                        new MySqlParameter("?email", emailInput.Text)
                        });

                        MySqlDataReader dr = cmd.ExecuteReader();
                        dr.Read();

                        if (dr.HasRows)
                        {
                            if(BCrypt.Net.BCrypt.Verify(passwordInput.Text, dr.GetString("password")))
                                MessageBox.Show("Verified!");
                        }

                        dr.Close();
                    }
                }
                catch (MySqlException error)
                {
                    throw error;
                }
            }
            else
                SystemSounds.Beep.Play();
        }
    }
}
