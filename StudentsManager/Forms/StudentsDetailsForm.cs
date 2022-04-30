using FontAwesome.Sharp;
using MySql.Data.MySqlClient;
using StudentsManager.Classes;
using StudentsManager.Components.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentsManager.Forms
{
    public partial class StudentsDetailsForm : Form
    {
        public StudentsDetailsForm(StudentsList studentsCollection, int edit = 0, int editIndex = -1)
        {
            InitializeComponent();

            try
            {
                Program.dbConnection.Open();

                using (MySqlCommand cmd = Program.dbConnection.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM edu_degree_types";
                    this.EduTypeCombo.SetListItems(ProccessComboBoxData(cmd.ExecuteReader(), "degree"));

                    cmd.CommandText = "SELECT * FROM edu_specialties";
                    this.EduSpecialtyCombo.SetListItems(ProccessComboBoxData(cmd.ExecuteReader(), "specialty"));

                    cmd.CommandText = "SELECT * FROM edu_forms";
                    this.EduFormCombo.SetListItems(ProccessComboBoxData(cmd.ExecuteReader(), "form"));
                }

                Program.dbConnection.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Program.dbConnection.Close();
            }

            if (edit == 1)
            {
                this.Text = "Editing Student Record";
                this.FacultyNumberInput.ReadOnly = true;
                this.StudentsDetailsBtn.ColorSelected = ColorType.Secondary;
                this.StudentsDetailsBtn.Text = "Edit Student Record";
                this.headerText1.Text = "Editing Student Record";
                this.faIcon2.IconChar = IconChar.UserEdit;
                this.faIcon2.ColorSelected = ColorType.Secondary;

                Student? studentToEdit = studentsCollection.ElementAt(editIndex);

                if(studentToEdit != null)
                {
                    this.FacultyNumberInput.Value = studentToEdit.FacultyNumber;
                    this.FirstNameInput.Value = studentToEdit.FirstName;
                    this.LastNameInput.Value = studentToEdit.LastName;
                    this.PhoneNumberInput.Value = studentToEdit.PhoneNumber;
                    this.EduTypeCombo.SetActiveItem(studentToEdit.DegreeType);
                    this.EduSpecialtyCombo.SetActiveItem(studentToEdit.SpecialtyName);
                    this.EduFormCombo.SetActiveItem(studentToEdit.FormType);
                    this.EduYearInput.Value = studentToEdit.Year.ToString();
                    this.EduGpaInput.Value = studentToEdit.Gpa.ToString();
                    this.EduPausedCheckbox.Checked = studentToEdit.EducationPaused;

                    MessageBox.Show($"{studentToEdit.DegreeType} {studentToEdit.SpecialtyName} {studentToEdit.FormType}");

                    this.StudentsDetailsBtn.Click += new EventHandler((s, e) =>
                    {
                        if(ValidateFormInputs())
                        {
                            studentToEdit.FirstName = this.FirstNameInput.Value;
                            studentToEdit.LastName = this.LastNameInput.Value;
                            studentToEdit.PhoneNumber = this.PhoneNumberInput.Value;
                            studentToEdit.Year = int.Parse(this.EduYearInput.Value);
                            studentToEdit.Gpa = double.Parse(this.EduGpaInput.Value);

                            try
                            {
                                Program.dbConnection.Open();

                                studentToEdit.Update(
                                    this.EduTypeCombo.Value,
                                    this.EduSpecialtyCombo.Value,
                                    this.EduFormCombo.Value
                                );

                                studentToEdit.Read();
                                Program.dbConnection.Close();
                            } 
                            catch(MySqlException ex)
                            {
                                MessageBox.Show(ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                Program.dbConnection.Close();
                            }

                            this.Close();
                        }
                        else
                        {
                            SystemSounds.Hand.Play();
                            MessageBox.Show("Form not filled corectly!", "Form Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    });
                }
                else
                {
                    MessageBox.Show("Student doesnt exists.", "Record error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
            else
            {
                this.StudentsDetailsBtn.Click += new EventHandler((s, e) =>
                {
                    if (ValidateFormInputs())
                    {
                        Student newStudent = new Student(
                            this.FacultyNumberInput.Value,
                            this.FirstNameInput.Value,
                            this.LastNameInput.Value,
                            this.PhoneNumberInput.Value,
                            "", "", "",
                            int.Parse(this.EduYearInput.Value),
                            double.Parse(this.EduGpaInput.Value),
                            this.EduPausedCheckbox.Checked
                        );

                        Program.dbConnection.Open();
                        newStudent.Create(
                            this.EduTypeCombo.Value,
                            this.EduSpecialtyCombo.Value,
                            this.EduFormCombo.Value
                        );

                        newStudent.Read();
                        Program.dbConnection.Close();

                        studentsCollection.AddElement(newStudent);
                        this.Close();
                    }
                    else
                    {
                        SystemSounds.Hand.Play();
                        MessageBox.Show("Form not filled corectly!", "Form Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                });
            }
        }

        private bool ValidateFormInputs()
        {
            return (
                !string.IsNullOrWhiteSpace(this.FacultyNumberInput.Value) && !string.IsNullOrWhiteSpace(this.FirstNameInput.Value)
                && !string.IsNullOrWhiteSpace(this.LastNameInput.Value) && !string.IsNullOrWhiteSpace(this.PhoneNumberInput.Value)
                && (int.Parse(this.EduYearInput.Value) > 0 && int.Parse(this.EduYearInput.Value) <= 4)
                && (double.Parse(this.EduGpaInput.Value) > 2.0f && double.Parse(this.EduGpaInput.Value) <= 6.0f)
            );
        }

        private DataTable ProccessComboBoxData(MySqlDataReader dataReader, string displayMember, string valueMember = "id")
        {
            DataTable comboBoxData = new DataTable();
            comboBoxData.Columns.AddRange(new DataColumn[] { new DataColumn(valueMember, typeof(int)), new DataColumn(displayMember, typeof(string)) });

            if(dataReader.HasRows)
            {
                while(dataReader.Read())
                    comboBoxData.Rows.Add(dataReader.GetInt32(valueMember), dataReader.GetString(displayMember));
            }

            dataReader.Close();
            return comboBoxData;
        }
    }
}
