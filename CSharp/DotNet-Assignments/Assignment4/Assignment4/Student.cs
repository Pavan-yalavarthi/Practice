using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class Student
    {
        interface IStudent
        {
            int StudentId { get; set; }
            String Name { get; set; }
            void ShowDetails();
        }
        class Dayscholar : Student
        {
            public int StudentId { get; set; }
            public String Name { get; set; }
            public int Value
            {
                get { return StudentId; }
                set { StudentId = value; }
            }
            public String Values
            {
                get { return Name; }
                set { Name = value; }
            }
            public void ShowDetails()
            {
                Console.WriteLine("DayScholar class:");
                Console.WriteLine("The Student id is:" + StudentId);
                Console.WriteLine("The Student name is:" + Name);
            }
        }
        public class Resident : Student
        {
            public int StudentId { get; set; }
            public String Name { get; set; }
            public int Value
            {
                get { return StudentId; }
                set { StudentId = value;}
            }
            public String student
            {
                get { return Name; }
                set { Name = value; }
            }
            public void ShowDetails()
            {
                Console.WriteLine("Resident class:");
                Console.WriteLine("The student id is:" + StudentId);
                Console.WriteLine("The Name is:" + Name);

            }
            public static void Main(String[] args)
            {

                Resident r = new Resident();
                Console.WriteLine("Enter the StudentId in Resident class");
                r.Value = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Student name in Resident class:");
                r.student = (Console.ReadLine());
                r.ShowDetails();
                Dayscholar d = new Dayscholar();
                Console.WriteLine("Enter the Studentid in Dayscholar class:");
                d.Value = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the StudentName in Dayscholar class:");
                d.Values = (Console.ReadLine());
                d.ShowDetails();
                Console.Read();
            }
        }
    }
}
