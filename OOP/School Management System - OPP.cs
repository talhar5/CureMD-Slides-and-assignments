using System;

namespace School_Management_System___OPP
{
    public class Person
    {
        private string Name { get; set; }
        private DateTime Dob { get; set; }
        private string Address { get; set; }

        public Person()
        {
            Name = 
        }
    }
    public class Student : Person
    {
        public string Grade { get; set; }
        public Teacher ClassTeacher { get; set; }
        public Student(string name, DateTime dob, string address, string grade) : base(name, dob, address)
        {
            Grade = grade;
        }
        public void AssignTeacher(Teacher teacher)
        {
            ClassTeacher = teacher;
            Console.WriteLine(teacher.Name + " teacher assigned to the student " + this.Name);
        }
    }
    public class Teacher : Person
    {
        public string Subject { get; set; }
        public Teacher(string name, DateTime dob, string address, string subject) : base(name, dob, address)
        {
            Subject = subject;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Now you can create instances of students and teachers, and assign teachers to students:
            
            Teacher mrSmith = new Teacher("Mr. Smith", new DateTime(1980, 1, 1), "123 St", "Maths");
            Student john = new Student("John", new DateTime(2010, 1, 1), "456 St", "5");

            john.AssignTeacher(mrSmith);

            Console.ReadKey();

            Person person = new Person("John", jbhdjhfjk, ujshdkjsh);
            
           
        }
    }
}
