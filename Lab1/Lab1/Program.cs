using System;

namespace Lab1
{
    class Student
    {
        private int id;
        private string name;

        public Student(int id,string name)
        {
            this.id = id;
            this.name = name;
        }
        public void showDetails()
        {
            Console.WriteLine(this.id);
            Console.WriteLine(this.name);
        }
    }
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Student stud1 = new Student(1001, "name");
            int id = Convert.ToInt32(Console.ReadLine());
            string name = Console.ReadLine();
            Student stud1 = new Student(id, name);
            stud1.showDetails();
        }
    }
}
