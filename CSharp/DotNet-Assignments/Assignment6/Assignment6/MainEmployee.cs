using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    class Employee
    {
        public int EmpID;
        public string EmpName;
        public string EmpCity;
        public double EmpSalary;
    }

    class MainEmployee
    {
        static void Main()
        {
            Console.WriteLine("Enter List length:");

            int length = Convert.ToInt32(Console.ReadLine());

            List<Employee> emplylist = new List<Employee> { };

            for (int i = 0; i < length; i++)
            {
                Console.WriteLine("Enter Employe ID :");

                int EmployeeID = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Employe Name :");

                string EmployeeName = Console.ReadLine();

                Console.WriteLine("Enter Employe City :");

                string EmployeeCity = Console.ReadLine();

                Console.WriteLine("Enter Employe Salary :");

                double EmployeeSalary = Convert.ToDouble(Console.ReadLine());

                emplylist.Add(new Employee
                {
                    EmpID = EmployeeID,

                    EmpName = EmployeeName,

                    EmpCity = EmployeeCity,

                    EmpSalary = EmployeeSalary
                });

            }

            Console.WriteLine(" Details Of Employees*****");

            foreach (var x in emplylist)

            {

                Console.WriteLine(" Employee ID:{0} Name: {1} City:{2} Salary:{3} ", x.EmpID, x.EmpName, x.EmpCity, x.EmpSalary);

            }

            Console.WriteLine(" Employees Salary greater than 45000/-");

            foreach (var emp in emplylist)

            {
                if (emp.EmpSalary > 45000)

                 Console.WriteLine(emp.EmpName);
            }

            Console.WriteLine(" Employees belong to Bengaluru Region....");

            foreach (var emp in emplylist)

            {
                if (emp.EmpCity == "bengaluru"  || emp.EmpCity == "bengaluru")

                    Console.WriteLine(emp.EmpName + " from " + emp.EmpCity);
            }

            IEnumerable<Employee> Ascendingorder = emplylist.OrderBy(n => n.EmpName);

            Console.WriteLine(" Employee names in Ascending order....");

            foreach (var emp in Ascendingorder)

            {
                Console.WriteLine(emp.EmpName);
            }

            Console.ReadLine();

        }

    }
}
