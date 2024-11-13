using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment2
{
    abstract class Student
    {
        public string Name; 
        public int StudentId;
        public double Grade; 

        public Student(string name, int studentId, double grade)
        {
            Name = name;
            StudentId = studentId;
            Grade = grade;
        }

        // Abstract method 
        public abstract bool IsPassed(double grade);
    }

    class Undergraduate : Student
    {
        public Undergraduate(string name, int studentId, double grade) : base(name, studentId, grade) { }

        public override bool IsPassed(double grade)
        {
            return grade > 70.0;
        }
    }

    class Graduate : Student
    {
        public Graduate(string name, int studentId, double grade) : base(name, studentId, grade) { }
        public override bool IsPassed(double grade)
        {
            return grade > 80.0;
        }
    }
    class StudentProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the name of the student:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter the student ID:");
            int studentId = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the grade:");
            double grade = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the type of student (1 for Undergraduate, 2 for Graduate):");
            int studentType = int.Parse(Console.ReadLine());

            Student student;

            if (studentType == 1)
            {
                student = new Undergraduate(name, studentId, grade);
            }
            else if (studentType == 2)
            {
                student = new Graduate(name, studentId, grade);
            }
            else
            {
                Console.WriteLine("Invalid student type.");
                return;
            }
            if (student.IsPassed(student.Grade))
            {
                Console.WriteLine("Student " + student.Name + " has passed.");
            }
            else
            {
                Console.WriteLine("Student " + student.Name + " has not passed.");
            }
            Console.Read();
        }
    }
}
   