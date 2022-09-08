using MySql.Data.MySqlClient;

namespace StudentsManager.Classes
{
    public class StudentsList
    {
        private List<Student> studentsList;

        public StudentsList() => 
            this.studentsList = new List<Student>();

        public StudentsList(StudentsList studentListObject) =>
            this.studentsList = new List<Student>(studentListObject.studentsList);

        public int Count => this.studentsList.Count;

        public List<Student> GetCollection { get => this.studentsList; }

        public void SortByFacultyNumber() =>
            this.studentsList.Sort();

        public int IndexOf(Student studentObject) =>
            this.studentsList.IndexOf(studentObject);

        public Student? ElementAt(int index) =>
            index < 0 || index > this.studentsList.Count ? null : this.studentsList.ElementAt(index);

        public void AddElement(Student studentObject) =>
            this.studentsList.Add(studentObject);

        public int RemoveAt(int index)
        {
            if (index < 0 || index >= this.studentsList.Count)
                return -1;

            this.studentsList.RemoveAt(index);
            return 1;
        }

        public Student? SearchByFacultyNumber(string _facNum)
        {
            foreach(Student studentObject in this.studentsList)
            {
                if (studentObject.FacultyNumber == _facNum)
                    return studentObject;
            }

            return null;
        }

        public List<Student> SearchByFacultyNumber(string _fromFacNum, string _toFacNum)
        {
            List<Student> tempStudentsList = new List<Student>();

            foreach (Student studentObject in this.studentsList)
            {
                if (studentObject.FacultyNumber != null && studentObject.FacultyNumber != "")
                {
                    if (studentObject.CompareTo(new Student(_fromFacNum)) >= 0 && studentObject.CompareTo(new Student(_toFacNum)) < 1)
                        tempStudentsList.Add(studentObject);
                }
            }

            return tempStudentsList;
        }

        public int LoadDataFromDatabase()
        {
            try
            {
                using (MySqlCommand cmd = Program.dbConnection.CreateCommand())
                {
                    cmd.CommandText =
                        "SELECT" +
                            " facultyNumber, firstName, lastName, phoneNumber," +
                            " edu_degree_types.degree, edu_specialties.specialty, edu_forms.form," +
                            " year, gpa" +
                        " FROM students" +
                            " INNER JOIN edu_degree_types ON students.degreeId = edu_degree_types.id" +
                            " INNER JOIN edu_specialties ON students.specialtyId = edu_specialties.id" +
                            " INNER JOIN edu_forms ON students.formId = edu_forms.id ORDER BY facultyNumber DESC";

                    MySqlDataReader dataReader = cmd.ExecuteReader();

                    if (dataReader.HasRows)
                    {
                        this.studentsList = new List<Student>();

                        while (dataReader.Read())
                        {
                            this.studentsList.Add(new Student(
                                dataReader.GetString("facultyNumber"),
                                dataReader.GetString("firstName"),
                                dataReader.GetString("lastName"),
                                dataReader.GetString("phoneNumber"),
                                dataReader.GetString("degree"),
                                dataReader.GetString("specialty"),
                                dataReader.GetString("form"),
                                dataReader.GetInt32("year"),
                                dataReader.GetDouble("gpa")
                            ));
                        }

                        dataReader.Close();
                        return 1;
                    }

                    dataReader.Close();
                    return 0;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }
    }
}
