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
        public int create(MySqlConnection connection, int degreeId, int specialtyId, int formId);
        public int read(MySqlConnection connection);
        public int update(MySqlConnection connection, int degreeId, int specialtyId, int formId);
        public int delete(MySqlConnection connection);

    }
    public class Student : IStudentDatabaseQueries
    {
        private string facultyNumber;
        private string firstName, lastName, phoneNumber;
        private string degreeType, specialtyName, formType;
        private double gpa;
        private int year;
        private bool isEducationPaused;

        private MySqlCommand? command = null;
        private MySqlDataReader? reader = null;

        public Student()
        {
            this.facultyNumber = "";
            this.firstName = "";
            this.lastName = "";
            this.phoneNumber = "";
            this.degreeType = "";
            this.specialtyName = "";
            this.formType = "";
            this.gpa = 0.0;
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

        public int create(MySqlConnection connection, int degreeId, int specialtyId, int formId)
        {
            int executed = 0;

            try
            {
                this.command = connection.CreateCommand();

                this.command.CommandText = "INSERT INTO students VALUES(null, `?facNum`, `?fn`, `?ln`, `?phn`, ?dtid, ?snid, ?ftid, ?year, ?gpa, ?edup, default, default)";

                this.command.Parameters.AddRange(new MySqlParameter[] {
                    new MySqlParameter("?facNum", this.facultyNumber),
                    new MySqlParameter("?fn", this.firstName),
                    new MySqlParameter("?ln", this.lastName),
                    new MySqlParameter("?phn", this.phoneNumber),
                    new MySqlParameter("?dtid", degreeId),
                    new MySqlParameter("?snid", specialtyId),
                    new MySqlParameter("?ftid", formId),
                    new MySqlParameter("?year", this.year),
                    new MySqlParameter("?gpa", this.gpa),
                    new MySqlParameter("?edup", this.isEducationPaused)
                });

                executed = this.command.ExecuteNonQuery();
            }
            catch (MySqlException error)
            {
                MessageBox.Show(error.Message, "Database Error");
                Application.Exit();
            }
            finally
            {
                this.command = null;
                this.reader = null;
            }

            return executed;
        }

        public int read(MySqlConnection connection)
        {
            int executed = 0;

            try
            {
                this.command = connection.CreateCommand();
                this.command.CommandText =
                    "SELECT " +
                        "facultyNumber, firstName, lastName, phoneNumber," +
                        "edu_degree_types.degree, edu_specialties.specialty, edu_forms.form," +
                        "year, gpa,eduPaused" +
                    "FROM students" +
                        "INNER JOIN edu_degree_types ON students.degreeId = edu_degree_types.id" +
                        "INNER JOIN edu_specialties ON students.specialtyId = edu_specialties.id" +
                        "INNER JOIN edu_forms ON students.formId = edu_forms.id" +
                    "WHERE facultyNumber = `?facNum` LIMIT 1";

                this.command.Parameters.AddWithValue("?facNum", this.facultyNumber);
                this.reader = command.ExecuteReader();
                this.reader.Read();

                if(this.reader.HasRows)
                {
                    this.facultyNumber = reader.GetString("facultyNumber");
                    this.firstName = reader.GetString("firstName");
                    this.lastName = reader.GetString("lastName");
                    this.phoneNumber = reader.GetString("phoneNumber");
                    this.degreeType = reader.GetString("degree");
                    this.specialtyName = reader.GetString("specialty");
                    this.formType = reader.GetString("form");
                    this.year = reader.GetInt32("year");
                    this.gpa = reader.GetDouble("gpa");
                    this.isEducationPaused = reader.GetBoolean("EduPaused");
                    executed = 1;
                }
            }
            catch (MySqlException error)
            {
                MessageBox.Show(error.Message, "Database Error");
                Application.Exit();
            }
            finally
            {
                this.command = null;
                this.reader = null;
            }

            return executed;
        }

        public int update(MySqlConnection connection, int degreeId, int specialtyId, int formId)
        {
            int executed = 0;

            try
            {
                this.command = connection.CreateCommand();
                this.command.CommandText =
                    "UPDATE students SET" +
                        "firstName = `?fn`," +
                        "lastName = `?ln`," +
                        "phoneNumber = `?phn`," +
                        "degreeId = ?dtid," +
                        "specialtyId = ?snid," +
                        "formId = ?ftid," +
                        "year = ?year," +
                        "gpa = ?gpa," +
                        "eduPaused = ? edup," +
                        "updated_at = now()" +
                    "WHERE facultyNumber = `?facNum`";

                this.command.Parameters.AddRange(new MySqlParameter[] {
                    new MySqlParameter("?fn", this.firstName),
                    new MySqlParameter("?ln", this.lastName),
                    new MySqlParameter("?phn", this.phoneNumber),
                    new MySqlParameter("?dtid", degreeId),
                    new MySqlParameter("?snid", specialtyId),
                    new MySqlParameter("?ftid", formId),
                    new MySqlParameter("?year", this.year),
                    new MySqlParameter("?gpa", this.gpa),
                    new MySqlParameter("?edup", this.isEducationPaused),
                    new MySqlParameter("?facNum", this.facultyNumber)
                });

                executed = this.command.ExecuteNonQuery();
            }
            catch(MySqlException error)
            {
                MessageBox.Show(error.Message, "Database Error");
                Application.Exit();
            }
            finally
            {
                this.command = null;
            }

            return executed;
        }

        public int delete(MySqlConnection connection)
        {
            int executed = 0;

            try
            {
                this.command = connection.CreateCommand();
                this.command.CommandText = "DELETE FROM students WHERE facultyNumber = `?facNum`";
                this.command.Parameters.AddWithValue("?facNum", this.facultyNumber);
                executed = this.command.ExecuteNonQuery();
            }
            catch(MySqlException error)
            {
                MessageBox.Show(error.Message, "Database Error");
                Application.Exit();
            }
            finally
            {
                this.command = null;
            }

            return executed;
        }

    }
}