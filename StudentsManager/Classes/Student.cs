﻿using MySql.Data.MySqlClient;

namespace StudentsManager.Classes
{
    public interface IStudentCRUD
    {
        int Create(MySqlConnection connection, int degreeId, int specialtyId, int formId);
        int Read(MySqlConnection connection);
        int Update(MySqlConnection connection, int degreeId, int specialtyId, int formId);
        int Delete(MySqlConnection connection);
    }
    public class Student : IStudentCRUD, IComparable<Student>
    {
        private string facultyNumber;
        private string firstName, lastName, phoneNumber;
        private string degreeType, specialtyName, formType;
        private int year;
        private double gpa;
        private bool educationPaused;

        public Student()
        {
            this.facultyNumber = "";
            this.firstName = "";
            this.lastName = "";
            this.phoneNumber = "";
            this.degreeType = "";
            this.specialtyName = "";
            this.formType = "";
            this.year = 0;
            this.gpa = 0.0;
            this.educationPaused = false;
        }

        public Student(string _facNum) =>
            this.facultyNumber = _facNum;

        public Student(Student studentObject)
        {
            this.facultyNumber = studentObject.facultyNumber;
            this.firstName = studentObject.firstName;
            this.lastName = studentObject.lastName;
            this.phoneNumber = studentObject.phoneNumber;
            this.degreeType = studentObject.degreeType;
            this.specialtyName = studentObject.specialtyName;
            this.formType = studentObject.formType;
            this.year = studentObject.year;
            this.gpa = studentObject.gpa;
            this.educationPaused = studentObject.educationPaused;
        }

        public Student(string _facNum, string _fn, string _ln, string _phoneNum, string _degreeType, string _specName, string _formType, int _year, double _gpa, bool _eduPaused)
        {
            this.facultyNumber = _facNum;
            this.firstName = _fn;
            this.lastName = _ln;
            this.phoneNumber = _phoneNum;
            this.degreeType = _degreeType;
            this.specialtyName = _specName;
            this.formType = _formType;
            this.year = _year;
            this.gpa = _gpa;
            this.educationPaused = _eduPaused;
        }

        public string FullName { get => $"{ this.firstName } { this.lastName }"; }
        public string FacultyNumber { get => this.facultyNumber; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string DegreeType { get; set; }
        public string SpecialtyName { get; set; }
        public string FormType { get; set; }
        public int Year { get; set; }
        public double Gpa { get; set; }
        public bool EducationPaused { get; set; }

        public override string ToString()
        {
            return "{" +
                $"facultyNumber: { this.facultyNumber }, " +
                $"fullName: { this.FullName }, " +
                $"phoneNumber: { this.phoneNumber }, " +
                $"degree: { this.degreeType }, " +
                $"specialty: { this.specialtyName }, " +
                $"form: { this.formType }, " +
                $"year: { this.year }, " +
                $"gpa: { this.gpa }, " +
                $"eduPaused: { this.educationPaused.ToString() } " + "}";
        }
        
        public int CompareTo(Student? studentObject) => 
            studentObject == null ? 1 : this.facultyNumber.CompareTo(studentObject.facultyNumber);

        public override bool Equals(Object? obj) =>
            obj == null || !this.GetType().Equals(obj.GetType()) ? false : this.facultyNumber.CompareTo(((Student) obj).facultyNumber) == 0;

        public int Create(MySqlConnection connection, int degreeId, int specialtyId, int formId)
        {
            try
            {
                using (MySqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO students VALUES(null, ?facNum, ?fn, ?ln, ?phn, ?dtid, ?snid, ?ftid, ?year, ?gpa, ?edup, default, default)";
                    cmd.Parameters.AddRange(new MySqlParameter[] 
                    {
                        new MySqlParameter("?facNum", this.facultyNumber),
                        new MySqlParameter("?fn", this.firstName),
                        new MySqlParameter("?ln", this.lastName),
                        new MySqlParameter("?phn", this.phoneNumber),
                        new MySqlParameter("?dtid", degreeId),
                        new MySqlParameter("?snid", specialtyId),
                        new MySqlParameter("?ftid", formId),
                        new MySqlParameter("?year", this.year),
                        new MySqlParameter("?gpa", this.gpa),
                        new MySqlParameter("?edup", this.educationPaused)
                    });

                    return cmd.ExecuteNonQuery();
                }
            }
            catch (MySqlException error)
            {
                 MessageBox.Show(error.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }

        public int Read(MySqlConnection connection)
        {
            try
            {
                if(connection == null)
                {
                    MessageBox.Show("no connection");
                    return 0;
                }
                using (MySqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText =
                        "SELECT" +
                            " facultyNumber, firstName, lastName, phoneNumber," +
                            " edu_degree_types.degree, edu_specialties.specialty, edu_forms.form," +
                            " year, gpa, eduPaused" +
                        " FROM students" +
                            " INNER JOIN edu_degree_types ON students.degreeId = edu_degree_types.id" +
                            " INNER JOIN edu_specialties ON students.specialtyId = edu_specialties.id" +
                            " INNER JOIN edu_forms ON students.formId = edu_forms.id" +
                        " WHERE facultyNumber = ?facNum LIMIT 1";

                    cmd.Parameters.AddWithValue("?facNum", this.facultyNumber);
                    MySqlDataReader dataReader = cmd.ExecuteReader();

                    if (dataReader.HasRows && dataReader.Read())
                    {
                        this.facultyNumber = dataReader.GetString("facultyNumber");
                        this.firstName = dataReader.GetString("firstName");
                        this.lastName = dataReader.GetString("lastName");
                        this.phoneNumber = dataReader.GetString("phoneNumber");
                        this.degreeType = dataReader.GetString("degree");
                        this.specialtyName = dataReader.GetString("specialty");
                        this.formType = dataReader.GetString("form");
                        this.year = dataReader.GetInt32("year");
                        this.gpa = dataReader.GetDouble("gpa");
                        this.educationPaused = dataReader.GetBoolean("EduPaused");
                        dataReader.Close();
                        return 1;
                    }

                    dataReader.Close();
                    return 0;
                } 
            }
            catch (MySqlException error)
            {
                MessageBox.Show(error.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }

        public int Update(MySqlConnection connection, int degreeId, int specialtyId, int formId)
        {
            try
            {
                using (MySqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText =
                        "UPDATE students SET" +
                            " firstName = ?fn," +
                            " lastName = ?ln," +
                            " phoneNumber = ?phn," +
                            " degreeId = ?dtid," +
                            " specialtyId = ?snid," +
                            " formId = ?ftid," +
                            " year = ?year," +
                            " gpa = ?gpa," +
                            " eduPaused = ? edup," +
                            " updated_at = now()" +
                        " WHERE facultyNumber = ?facNum";

                    cmd.Parameters.AddRange(new MySqlParameter[] 
                    {
                        new MySqlParameter("?fn", this.firstName),
                        new MySqlParameter("?ln", this.lastName),
                        new MySqlParameter("?phn", this.phoneNumber),
                        new MySqlParameter("?dtid", degreeId),
                        new MySqlParameter("?snid", specialtyId),
                        new MySqlParameter("?ftid", formId),
                        new MySqlParameter("?year", this.year),
                        new MySqlParameter("?gpa", this.gpa),
                        new MySqlParameter("?edup", this.educationPaused),
                        new MySqlParameter("?facNum", this.facultyNumber)
                    });

                    return cmd.ExecuteNonQuery();
                }
            }
            catch(MySqlException error)
            {
                 MessageBox.Show(error.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }

        public int Delete(MySqlConnection connection)
        {
            try
            {
                using (MySqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "DELETE FROM students WHERE facultyNumber = ?facNum";
                    cmd.Parameters.AddWithValue("?facNum", this.facultyNumber);
                    return cmd.ExecuteNonQuery();
                }
                    
            }
            catch(MySqlException error)
            {
                MessageBox.Show(error.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }

        public override int GetHashCode() => throw new NotImplementedException();
    }
}