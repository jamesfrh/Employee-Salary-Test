using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSalary
{
    class abcCompany
    {
        List<Employee> abcEmployees = new List<Employee>();

        public void AddEmployee(Employee anEmployee)
        {
            abcEmployees.Add(anEmployee);
        }

        public void PrintEmployees()
        {
            List<string> employeeList = new List<string>();
            for(int i =0; i < abcEmployees.Count; i++)
            {
                Employee x = abcEmployees[i];
                int indexOfEmployee = employeeList.IndexOf(x.SecurityNumber);
                if(indexOfEmployee <0)
                {
                    employeeList.Add(x.SecurityNumber);
                }
            }
            foreach (string employeeSecurityNumber in employeeList)
                Console.WriteLine(employeeSecurityNumber);

        }

        public double TotalWeeklyPayroll()
        {
            double totalWeeklyPay = 0;
            for(int i=0; i<abcEmployees.Count; i++)
            {
                Employee x = abcEmployees[i];
                if (x.Earnings() > 0)
                {
                    totalWeeklyPay += x.Earnings();
                }
                
            }
            return totalWeeklyPay;
        }

        public override string ToString()
        {
            return String.Format("Weekly payroll for all employees in ABC company is : {0}", TotalWeeklyPayroll());
        }
    }
}
