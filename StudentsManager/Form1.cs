using MySql.Data.MySqlClient;
using StudentsManager.Classes;

namespace StudentsManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           /* db.openConnection();

            StudentsList studentsList = new StudentsList();
            MySqlDataReader? dataReader = db.ExecuteQuery(
                "SELECT" +
                    " facultyNumber, firstName, lastName, phoneNumber," +
                    " edu_degree_types.degree, edu_specialties.specialty, edu_forms.form," +
                    " year, gpa, eduPaused" +
                " FROM students" +
                    " INNER JOIN edu_degree_types ON students.degreeId = edu_degree_types.id" +
                    " INNER JOIN edu_specialties ON students.specialtyId = edu_specialties.id" +
                    " INNER JOIN edu_forms ON students.formId = edu_forms.id"
            );

            if (dataReader != null)
            {
                while (dataReader.Read())
                    studentsList.AddElement(new Student(
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

            dataReader.Close();

            if (studentsList.Count > 0)
            {
                List<Student> students = new List<Student>(studentsList.GetCollection());

                foreach(Student s in students)
                {
                    MessageBox.Show(s.ToString());
                }
            }

            db.closeConnection(); */
        }
    }
}