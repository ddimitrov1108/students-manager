namespace StudentsManager.Classes
{
    public class StudentsList
    {
        private List<Student> studentsList;

        public StudentsList() => 
            this.studentsList = new List<Student>();

        public StudentsList(StudentsList studentListObject) =>
            this.studentsList = new List<Student>(studentListObject.studentsList);

        public int Count =>
            this.studentsList.Count;

        public List<Student> GetCollection() { return this.studentsList; }

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

        public StudentsList? SearchByFacultyNumber(string _fromFacNum, string _ToFacNum)
        {
            StudentsList tempStudentsList = new StudentsList();

            foreach(Student studentObject in this.studentsList)
            {
                if (studentObject.FacultyNumber != null && studentObject.FacultyNumber != "")
                {
                    if (studentObject.FacultyNumber.CompareTo(_fromFacNum) >= 0 && studentObject.FacultyNumber.CompareTo(_ToFacNum) <= 1)
                        tempStudentsList.AddElement(studentObject);
                }
            }

            return tempStudentsList;
        }
    }
}
