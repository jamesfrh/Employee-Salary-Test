using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSalary
{
    class Employee
    {
        //field
        private string firstName;
        private string lastName;
        private string securityNumber;
        //properties
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public string SecurityNumber
        {
            get { return securityNumber; }
            set { securityNumber = value; }
        }

        //constructor
        public Employee(string firstName, string lastName, string securityNumber)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.securityNumber = securityNumber;
        }
        //method
        public virtual double Earnings()
        {
            return 0;   
        }

        public override string ToString()
        {
            string m = String.Format("Employye name: {0} {1}. Security number: {2}", FirstName, LastName, SecurityNumber);
            return m;
        }
    }
}
