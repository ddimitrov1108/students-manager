using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace StudentsManager.Classes
{
    public interface IStudentDatabaseQueries
    {
        public bool create(MySqlConnection connection);
        public void read(MySqlConnection connection);
        public bool update(MySqlConnection connection);
        public void delete(MySqlConnection connection);

    }
    public class Student : IStudentDatabaseQueries
    {
        private string facultyNumber;
        private string firstName, lastName, phoneNumber;
        private string degreeType, specialtyName, formType;
        private double gpa;
        private int year;
        private bool isEducationPaused;

        public Student()
        {
            this.facultyNumber = "";
            this.firstName = "";
            this.lastName = "";
            this.phoneNumber = "";
            this.degreeType = "";
            this.specialtyName = "";
            this.formType = "";
            this.gpa = 0.00;
            this.year = 0;
            this.isEducationPaused = true;
        }

        public Student(Student studentObject)
        {
            this.facultyNumber = studentObject.facultyNumber;
            this.firstName = studentObject.firstName;
            this.lastName = studentObject.lastName;
            this.phoneNumber = studentObject.phoneNumber;
            this.degreeType = studentObject.degreeType;
            this.specialtyName = studentObject.specialtyName;
            this.formType = studentObject.formType;
            this.gpa = studentObject.gpa;
            this.year = studentObject.year;
            this.isEducationPaused = studentObject.isEducationPaused;
        }

        public Student(string _facNum, string _fn, string _ln, string _phoneNum, string _degreeType, string _specName, string _formType, double _gpa, int _year, bool _isEduPaused)
        {
            this.facultyNumber = _facNum;
            this.firstName = _fn;
            this.lastName = _ln;
            this.phoneNumber = _phoneNum;
            this.degreeType = _degreeType;
            this.specialtyName = _specName;
            this.formType = _formType;
            this.gpa = _gpa;
            this.year = _year;
            this.isEducationPaused = _isEduPaused;
        }

        public string FullName { get => $"{ this.firstName } { this.lastName }"; }
        public string FacultyNumber { get; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string DegreeType { get; set; }
        public string SpecialtyName { get; set; }
        public string FormType { get; set; }
        public double Gpa { get; set; }
        public int Year { get; set; }
        public bool IsEducationPaused { get; set; }

        public override string ToString()
        {
            return "{" +
                $"facultyNumber: { this.facultyNumber }, " +
                $"fullName: { this.FullName }, " +
                $"phoneNumber: { this.phoneNumber }, " +
                $"degree: { this.degreeType }, " +
                $"specialty: { this.specialtyName }, " +
                $"form: { this.formType }, " +
                $"gpa: { this.gpa }, " +
                $"year: { this.year }, " +
                $"eduPaused: { this.isEducationPaused.ToString() } " + "}";
        }
        public int CompareTo(Student? studentObject)
        {
            if (studentObject == null)
                return 1;
            else
                return this.facultyNumber.CompareTo(studentObject.facultyNumber);
        }

        public override bool Equals(Object? obj)
        {
            if (obj == null || !this.GetType().Equals(obj.GetType()))
                return false;

            Student stud = (Student)obj;
            return this.facultyNumber.CompareTo(stud.facultyNumber) == 0;
        }

        public bool create(MySqlConnection connection)
        {
            using (MySqlCommand command = connection.CreateCommand())
            {
                int degreeId = 0;
                int specialtyId = 0;
                int formId = 0;

                command.CommandText = "SELECT id FROM edu_degree_types WHERE degree = ?d";
                command.Parameters.Add("?d", this.degreeType);
                MySqlDataReader reader;

                command.CommandText = "INSERT INTO students VALUES(null, ?facNum, ?fn, ?ln, ?phn, ?dt, ?sn, ?ft, ?year, ?gpa, ?edup, default, default)";
                command.Parameters.AddRange(new MySqlParameter[] {
                    new MySqlParameter("?facNum", this.facultyNumber),
                    new MySqlParameter("?fn", this.firstName),
                    new MySqlParameter("?ln", this.lastName),
                    new MySqlParameter("?phn", this.phoneNumber),
                    new MySqlParameter("?dt", this.degreeType),
                    new MySqlParameter("?sn", this.specialtyName),
                    new MySqlParameter("?ft", this.formType),
                    new MySqlParameter("?year", this.year),
                    new MySqlParameter("?gpa", this.gpa),
                    new MySqlParameter("?edup", this.isEducationPaused)
                });
                return command.ExecuteNonQuery() == 1;
            }
        }

        public void read(MySqlConnection connection)
        {

        }

        public bool update(MySqlConnection connection)
        {
            return true;
        }

        public void delete(MySqlConnection connection)
        {

        }

    }
}
