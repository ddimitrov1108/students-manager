using MySql.Data.MySqlClient;
using StudentsManager.Classes;

namespace StudentsManager
{
    public partial class Form1 : Form
    {
        private DatabaseConnection dbConnection;
        private User user;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dbConnection = new DatabaseConnection();
            StudentsList studentsList = new StudentsList();
            MySqlDataReader? dr = dbConnection.ExecuteQuery("SELECT facultyNumber FROM students");

            if(dr != null)
            {
                dr.Read();
                while(dr.HasRows)
                {
                    studentsList.AddElement(new Student(dr.GetString("facultyNumber")));
                }
            }

            if(studentsList.Count > 0)
                MessageBox.Show("Data readed");
        }
    }
}