namespace LMS
{
    internal class Student
    {
        private string name;
        private int password;
        private int id;

        public Student()
        {
        }

        public Student(string name, int password, int id)
        {
            this.name = name;
            this.password = password;
            this.id = id;
        }
    }
}