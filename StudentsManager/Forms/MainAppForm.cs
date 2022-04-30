using MySql.Data.MySqlClient;
using StudentsManager.Classes;
using System.Media;
using System.Text.RegularExpressions;

namespace StudentsManager.Forms
{
    public partial class MainAppForm : Form
    {
        private User loggedUser;
        private StudentsList studentsCollection;
        private int selectedStudentRow = -1;
        public MainAppForm(User user)
        {
            InitializeComponent();

            this.loggedUser = user;
            this.studentsCollection = new StudentsList();
            this.WelcomeHeaderText.Text = $"Welcome back, {this.loggedUser.Name}";
            this.ReadAllStudents();
        }

        private void MainAppForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void LogOutFAIcon_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void ReadAllStudents()
        {
            try
            {
                Program.dbConnection.Open();
                this.studentsCollection.LoadDataFromDatabase();
                this.SetDataGridSource();
                Program.dbConnection.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Program.dbConnection.Close();
            }
        }

        private void SetDataGridSource()
        {
            this.StudentsDataGrid.DataSource = null;
            this.studentsCollection.SortByFacultyNumber();
            this.StudentsDataGrid.DataSource = this.studentsCollection.GetCollection();
            this.UpdateDataGridInfo();
            this.SetDataGridSettings();
        }

        private void UpdateDataGridInfo()
        {
            if (this.studentsCollection.Count > 0)
            {
                this.selectedStudentRow = 0;
            }
            else
            {
                this.selectedStudentRow = -1;
            }       
        }

        private void SetDataGridSettings()
        {
            this.StudentsDataGrid.Columns[0].HeaderText = "Faculty Number";
            this.StudentsDataGrid.Columns[0].Width = 144;
            this.StudentsDataGrid.Columns[1].HeaderText = "First Name";
            this.StudentsDataGrid.Columns[1].Width = 129;
            this.StudentsDataGrid.Columns[2].HeaderText = "Last Name";
            this.StudentsDataGrid.Columns[2].Width = 129;
            this.StudentsDataGrid.Columns[3].HeaderText = "Phone";
            this.StudentsDataGrid.Columns[4].HeaderText = "Degree";
            this.StudentsDataGrid.Columns[5].HeaderText = "Specialty";
            this.StudentsDataGrid.Columns[6].HeaderText = "Form";
            this.StudentsDataGrid.Columns[7].HeaderText = "Year";
            this.StudentsDataGrid.Columns[8].HeaderText = "GPA";

            if (this.StudentsDataGrid.Columns.Contains("EducationPaused"))
                this.StudentsDataGrid.Columns.Remove("EducationPaused");
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(this.QuickSearchFacNumberInput.Value))
            {
                if(new Regex(@"^\d+$").IsMatch(this.QuickSearchFacNumberInput.Value))
                {
                    Student? searchFilterStudent = this.studentsCollection.SearchByFacultyNumber(this.QuickSearchFacNumberInput.Value);

                    if (searchFilterStudent != null)
                        this.StudentsDataGrid.DataSource = new List<Student>() { searchFilterStudent };
                    else
                    {
                        SystemSounds.Beep.Play();
                        MessageBox.Show("Cant find existing record with this faculty number as uuid!", "Quick Search", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    SystemSounds.Beep.Play();
                    MessageBox.Show("Incorrect Faculty Number input for Quick Search!", "Quick Search", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if(!string.IsNullOrWhiteSpace(this.FromFacultyNumberInput.Value) && !string.IsNullOrWhiteSpace(this.ToFacultyNumberInput.Value))
            {
                if(new Regex(@"^\d+$").IsMatch(this.FromFacultyNumberInput.Value) && new Regex(@"^\d+$").IsMatch(this.ToFacultyNumberInput.Value))
                {

                }
                else 
                {
                    SystemSounds.Beep.Play();
                    MessageBox.Show("Incorrect Faculty Number inputs for Search In Range!", "Search In Range", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                    
            }
            else
                SystemSounds.Beep.Play();

            this.QuickSearchFacNumberInput.Value = "";
            this.FromFacultyNumberInput.Value = "";
            this.ToFacultyNumberInput.Value = "";
        }

        private void ReadAllRecordsBtn_Click(object sender, EventArgs e)
        {
            this.ReadAllStudents();
        }

        private void AddNewRecordBtn_Click(object sender, EventArgs e)
        {
            new StudentsDetailsForm(this.studentsCollection).ShowDialog();
            this.SetDataGridSource();
        }

        private void EditSelectedRowBtn_Click(object sender, EventArgs e)
        {
            new StudentsDetailsForm(this.studentsCollection, 1, this.selectedStudentRow).ShowDialog();
            this.SetDataGridSource();
        }

        private void DeleteSelectedRowBtn_Click(object sender, EventArgs e)
        {
            // @ TODO
            Student studentToDelete = this.studentsCollection.ElementAt(selectedStudentRow);

            DialogResult dialogResult = MessageBox.Show(
                    $"Are you sure that you want to delete student with faculty number: {studentToDelete.FacultyNumber}",
                    "Confirmation on Delete Request",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning
                );
            if (dialogResult == DialogResult.Yes)
            {
                Program.dbConnection.Open();
                this.studentsCollection.ElementAt(selectedStudentRow).Delete();
                this.studentsCollection.RemoveAt(selectedStudentRow);
                this.SetDataGridSource();
                Program.dbConnection.Close();
            }
        }

        private void StudentsDataGrid_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (e.StateChanged == DataGridViewElementStates.Selected)
            {
                if (e.Row.Index != -1 && e.Row.Index < this.studentsCollection.Count)
                {
                    this.selectedStudentRow = e.Row.Index;
                    this.SelectedRowInfo.Text = $"Selected Row: {this.studentsCollection.ElementAt(this.selectedStudentRow).FacultyNumber}";
                    this.EditSelectedRowBtn.Enabled = true;
                    this.DeleteSelectedRowBtn.Enabled = true;
                }
            }
            else
            {
                this.selectedStudentRow = -1;
                this.SelectedRowInfo.Text = "Selected Row: None";
                this.EditSelectedRowBtn.Enabled = false;
                this.DeleteSelectedRowBtn.Enabled = false;
            }
        }
    }
}
