using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSalary
{
    class PayrollSystemTest
    {
        static void Main(string[] args)
        {
            Employee salariesEmployee1 = new Salaried("James", "Foo", "54842658", 5000);
            Console.WriteLine(salariesEmployee1.ToString());
            Console.WriteLine("Total salary is : {0}",salariesEmployee1.Earnings());

            Employee salariesEmployee2 = new Salaried("John", "Lee", "65842159", 8000);
            Console.WriteLine(salariesEmployee2.ToString());
            Console.WriteLine("Total salary is : {0}", salariesEmployee2.Earnings());

            Employee commissionEmployee1 = new Commission("Jane", "Ong", "96548254", 30, 12000);
            Console.WriteLine(commissionEmployee1.ToString());
            Console.WriteLine("Total salary is : {0}", commissionEmployee1.Earnings());

            Employee hourlyEmployee1 = new Hourly("Bob", "Tan", "54124845", 30, 50);
            Console.WriteLine(hourlyEmployee1.ToString());
            Console.WriteLine("Total salary is : {0}", hourlyEmployee1.Earnings());

            Employee hourlyEmployee2 = new Hourly("Adam", "Khoo", "75412685", 50, 40);
            Console.WriteLine(hourlyEmployee2.ToString());
            Console.WriteLine("Total salary is : {0}", hourlyEmployee2.Earnings());

            Commission salariedCommissionEmployee1 = new SalariedCommission("Mike", "Lim", "65482315", 2000, 20,10000);
            Console.WriteLine(salariedCommissionEmployee1.ToString());
            Console.WriteLine("Total salary is : {0}", salariedCommissionEmployee1.Earnings());
            Console.WriteLine();

            abcCompany abcCompany = new abcCompany();
            abcCompany.AddEmployee(salariesEmployee1);
            abcCompany.AddEmployee(commissionEmployee1);
            abcCompany.AddEmployee(hourlyEmployee1);
            abcCompany.AddEmployee(hourlyEmployee2);
            abcCompany.AddEmployee(salariedCommissionEmployee1);
            abcCompany.AddEmployee(salariesEmployee2);

            Console.WriteLine(abcCompany.ToString());
            abcCompany.PrintEmployees();




        }
    }
}
