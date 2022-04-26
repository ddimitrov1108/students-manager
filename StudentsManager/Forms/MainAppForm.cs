using MySql.Data.MySqlClient;
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
        private StudentsList students;
        public MainAppForm(User user)
        {
            this.loggedUser = user;
            this.students = new StudentsList();
            InitializeComponent();
        }

        private void MainAppForm_Load(object sender, EventArgs e)
        {
            //MessageBox.Show($"{this.loggedUser.Id} {this.loggedUser.Name}, {this.loggedUser.Email}, {this.loggedUser.IsAdmin}");
            this.ReadAllStudents();
        }

        private void MainAppForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void ReadAllStudents()
        {
            Program.dbConnection.Open();

            using (MySqlCommand cmd = Program.dbConnection.CreateCommand())
            {
                cmd.CommandText =
                    "SELECT" +
                        " facultyNumber, firstName, lastName, phoneNumber," +
                        " edu_degree_types.degree, edu_specialties.specialty, edu_forms.form," +
                        " year, gpa, eduPaused" +
                    " FROM students" +
                        " INNER JOIN edu_degree_types ON students.degreeId = edu_degree_types.id" +
                        " INNER JOIN edu_specialties ON students.specialtyId = edu_specialties.id" +
                        " INNER JOIN edu_forms ON students.formId = edu_forms.id";

                MySqlDataReader dataReader = cmd.ExecuteReader();

                if (dataReader.HasRows)
                {
                    this.students = new StudentsList();

                    while (dataReader.Read())
                    {
                        this.students.AddElement(new Student(
                            dataReader.GetString("facultyNumber"),
                            dataReader.GetString("firstName"),
                            dataReader.GetString("lastName"),
                            dataReader.GetString("phoneNumber"),
                            dataReader.GetString("degree"),
                            dataReader.GetString("specialty"),
                            dataReader.GetString("form"),
                            dataReader.GetInt32("year"),
                            dataReader.GetDouble("gpa"),
                            dataReader.GetBoolean("EduPaused")
                        ));
                    }

                    this.StudentsDataGrid.DataSource = this.students.GetCollection();
                }

                dataReader.Close();
            }

            Program.dbConnection.Close();
            this.SetDataGridSettings();
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
    }
}
