using MySql.Data.MySqlClient;
using StudentsManager.Classes;
using System.Media;
using System.Net.Mail;
using System.Text.RegularExpressions;

namespace StudentsManager.Forms
{
    public partial class LoginForm : Form
    {
        MySqlConnection db;

        private Regex emailRegex = new Regex(@"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z");

        public LoginForm(MySqlConnection connection)
        {
            db = connection;
            db.Open();
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(EmailInput.Value) && !string.IsNullOrWhiteSpace(PasswordInput.Value))
            {
                if(emailRegex.IsMatch(EmailInput.Value) && 
                    (new Regex(@"[0-9]+").IsMatch(PasswordInput.Value) && new Regex(@".{6,}").IsMatch(PasswordInput.Value)))
                {
                    using (MySqlCommand cmd = db.CreateCommand())
                    {
                        cmd.CommandText = "SELECT * FROM users WHERE email = ?email LIMIT 1";
                        cmd.Parameters.AddWithValue("?email", EmailInput.Value);
                        MySqlDataReader dataReader = cmd.ExecuteReader();

                        if(dataReader.Read() && dataReader.HasRows)
                        {
                            if(BCrypt.Net.BCrypt.Verify(PasswordInput.Value, dataReader.GetString("password")))
                            {
                                MessageBox.Show("Verified!");
                                LoginFormErrorLabel.Visible = false;
                            }
                            else
                            {
                                LoginFormErrorLabel.Text = "Email or password is incorrect";
                                LoginFormErrorLabel.Visible = true;
                                SystemSounds.Beep.Play();
                            }
                        }
                        else
                        {
                            LoginFormErrorLabel.Text = "No account associated with this email";
                            LoginFormErrorLabel.Visible = true;
                            SystemSounds.Beep.Play();
                        }

                        dataReader.Close();
                    }
                }
                else
                {
                    LoginFormErrorLabel.Text = "Email or password is invalid";
                    LoginFormErrorLabel.Visible = true;
                    SystemSounds.Beep.Play();
                }
            }
            else
                SystemSounds.Beep.Play();
        }
    }
}
