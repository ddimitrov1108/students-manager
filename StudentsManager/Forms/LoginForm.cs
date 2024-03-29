﻿using MySql.Data.MySqlClient;
using StudentsManager.Classes;
using System.Media;
using System.Text.RegularExpressions;

namespace StudentsManager.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(EmailInput.Value) && !string.IsNullOrWhiteSpace(PasswordInput.Value))
            {
                if(new Regex(@"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z").IsMatch(EmailInput.Value) && 
                    (new Regex(@"[0-9]+").IsMatch(PasswordInput.Value) && new Regex(@".{6,}").IsMatch(PasswordInput.Value)))
                {
                    try
                    {
                        using (MySqlCommand cmd = Program.dbConnection.CreateCommand())
                        {
                            cmd.CommandText = "SELECT * FROM users WHERE email = ?email LIMIT 1";
                            cmd.Parameters.AddWithValue("?email", EmailInput.Value);
                            MySqlDataReader dataReader = cmd.ExecuteReader();

                            if (dataReader.HasRows && dataReader.Read())
                            {
                                if (BCrypt.Net.BCrypt.Verify(PasswordInput.Value, dataReader.GetString("password")))
                                {
                                    LoginFormErrorLabel.Visible = false;
                                    this.Hide();
                                    this.Enabled = false;
                                    this.LoginBtn.Enabled = false;

                                    User user = new User(
                                        dataReader.GetInt32("id"),
                                        $"{dataReader.GetString("firstName")} {dataReader.GetString("lastName")}",
                                        dataReader.GetString("email"),
                                        dataReader.GetBoolean("isAdmin")
                                    );

                                    dataReader.Close();
                                    new MainAppForm(user).Visible = true;
                                }
                                else
                                {
                                    SystemSounds.Beep.Play();
                                    LoginFormErrorLabel.Text = "Email or password is incorrect";
                                    LoginFormErrorLabel.Visible = true;

                                }
                            }
                            else
                            {
                                SystemSounds.Beep.Play();
                                LoginFormErrorLabel.Text = "No account associated with this email";
                                LoginFormErrorLabel.Visible = true;
                            }

                            dataReader.Close();
                        }
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    SystemSounds.Beep.Play();
                    LoginFormErrorLabel.Text = "Email or password is invalid";
                    LoginFormErrorLabel.Visible = true;
                }
            }
            else
                SystemSounds.Beep.Play();
        }
    }
}