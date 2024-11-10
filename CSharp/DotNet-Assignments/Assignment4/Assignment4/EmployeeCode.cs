using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class Employee
    {
        private int Empid;
        private string Empname;
        private float Salary;
        public int Emplyid
        {
            get { return Empid; }
            set { Empid = value; }
        }
        public string Emplyname
        {
            get { return Empname; }
            set { Empname = value; }
        }
        public float Emplysalary
        {
            get { return Salary; }
            set { Salary = value; }
        }
        public Employee(int Empid, String Empname, float Salary)
        {
            this.Empid = Empid;
            this.Empname = Empname;
            this.Salary = Salary;
        }
        public void details()
        {
            Console.WriteLine($"Employee id   : {Empid}");
            Console.WriteLine($"Employee name : {Empname}");
            Console.WriteLine($"Salary  : {Salary}");
        }
    }
    class ParttimeEmployee : Employee
    {
        private float wages;
        public float Empwages
        {
            get { return wages; }
            set { wages = value; }
        }
        public ParttimeEmployee(int Empid, string Empname, float Salary, float wages) : base(Empid, Empname, Salary)
        {
            this.wages = wages;
        }
        public void displaywages()
        {
            base.details();
            Console.WriteLine($"Wages  : {wages}");
        }
    }
    class EmployeeCode
    {
        static void Main()
        {
            Console.WriteLine("Enter employee id");
            int empid = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter employee name");
            string empname = Console.ReadLine();
            Console.WriteLine("Enter employee salary");
            float salary = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Enter employee wages");
            float wages = Convert.ToSingle(Console.ReadLine());
            ParttimeEmployee p = new ParttimeEmployee(empid, empname, salary, wages);
            p.displaywages();
            Console.Read();
        }
    }
}

