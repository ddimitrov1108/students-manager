using StudentsManager.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentsManager.Forms
{
    public partial class MainAppForm : Form
    {
        private User loggedUser;

        public MainAppForm(User user)
        {
            loggedUser = user;
            InitializeComponent();
        }

        private void MainAppForm_Load(object sender, EventArgs e)
        {
            MessageBox.Show($"{this.loggedUser.Id} {this.loggedUser.Name}, {this.loggedUser.Email}, {this.loggedUser.IsAdmin}");
            Application.Exit();
        }
    }
}
