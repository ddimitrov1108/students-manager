using MySql.Data.MySqlClient;
using StudentsManager.Classes;

namespace StudentsManager.Forms
{
    public partial class MainAppForm : Form
    {
        private User loggedUser;
        private StudentsList students;
        public MainAppForm(User user)
        {
            this.loggedUser = user;
            this.students = new StudentsList();
            InitializeComponent();
        }

        private void MainAppForm_Load(object sender, EventArgs e)
        {
            this.WelcomeHeaderText.Text = $"Welcome back, {this.loggedUser.Name}";
            this.ReadAllStudents();
        }

        private void MainAppForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void ReadAllStudents()
        {
            try
            {
                Program.dbConnection.Open();
                this.students.LoadDataFromDatabase();
                Program.dbConnection.Close();
                this.students.SortByFacultyNumber();
                this.StudentsDataGrid.DataSource = this.students.GetCollection();
                this.SetDataGridSettings();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Program.dbConnection.Close();
            }
        }

        private void SetDataGridSettings()
        {
            this.StudentsDataGrid.Columns[0].HeaderText = "Faculty Number";
            this.StudentsDataGrid.Columns[0].Width = 140;
            this.StudentsDataGrid.Columns[1].HeaderText = "First Name";
            this.StudentsDataGrid.Columns[1].Width = 130;
            this.StudentsDataGrid.Columns[2].HeaderText = "Last Name";
            this.StudentsDataGrid.Columns[2].Width = 130;
            this.StudentsDataGrid.Columns[3].HeaderText = "Phone";
            this.StudentsDataGrid.Columns[4].HeaderText = "Degree";
            this.StudentsDataGrid.Columns[5].HeaderText = "Specialty";
            this.StudentsDataGrid.Columns[6].HeaderText = "Form";
            this.StudentsDataGrid.Columns[7].HeaderText = "Year";
            this.StudentsDataGrid.Columns[8].HeaderText = "GPA";

            if (this.StudentsDataGrid.Columns.Contains("EducationPaused"))
                this.StudentsDataGrid.Columns.Remove("EducationPaused");

            MessageBox.Show(this.StudentsDataGrid.SelectedRows.Count.ToString());
        }

        private void ReadAllRecordsBtn_Click(object sender, EventArgs e)
        {
            this.ReadAllStudents();
        }

        private void AddNewRecordBtn_Click(object sender, EventArgs e)
        {
            // @ TODO
        }

        private void EditSelectedRowBtn_Click(object sender, EventArgs e)
        {
            // @ TODO
        }

        private void DeleteSelectedRowBtn_Click(object sender, EventArgs e)
        {
            // @ TODO
        }

        private void LogOutFAIcon_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void cButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
