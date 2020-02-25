using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSalary
{
    class Salaried:Employee
    {
        //additional field for salaried employee
        private double weeklySalary;

        //property
        public double WeeklySalary
        {
            get { return weeklySalary; }
            set { weeklySalary = value; }
        }
        //constructor
        public Salaried(string firstName, string lastName, string securtyNumber, double weeklySalary) :base(firstName,lastName,securtyNumber)
        {
            this.weeklySalary = weeklySalary;
        }
        public override double Earnings()
        {
            if (WeeklySalary > 0)
                return weeklySalary;
            else
            {
                Console.WriteLine("Weekly salary must be > 0");
                return 0;
            }
        }

        public override string ToString()
        {
            return String.Format("Salaried Employee: {0} {1}, Securiy number: {2}, Weekly Fixed Salary: {3}", FirstName, LastName, SecurityNumber, WeeklySalary);
        }
    }

    class Hourly:Employee
    {
        //additional field for salaried employee
        private double hoursWorked;
        private double wagePerHour;

        //property
        public double HoursWorked
        {
            get { return hoursWorked; }
            set { hoursWorked = value; }
        }

        protected double WagePerHour
        {
            get { return wagePerHour; }
            set { wagePerHour = value; }
        }
        //constructor
        public Hourly(string firstName, string lastName, string securityNumber, double hoursWorked, double wagePerHour) :base(firstName,lastName,securityNumber)
        { 
            this.hoursWorked = hoursWorked;
            this.wagePerHour = wagePerHour;
        }
        //method
        public override double Earnings()
        {
            double totalSalary = 0;
            double maxHours = 40;
            double overtimeRate = 1.5;
            if (HoursWorked > 0 && HoursWorked < 40)
            {
                totalSalary = HoursWorked * WagePerHour;
                return totalSalary;
            }
            else if (HoursWorked > 40)
            {
                double overtimeSalary = 0;
                totalSalary = maxHours * WagePerHour;
                overtimeSalary = (HoursWorked - maxHours) * overtimeRate;
                totalSalary += overtimeSalary;
                return totalSalary;
            }
            else
            {
                Console.WriteLine("Hours worked must be more than 0");
                return 0;
            }
        }
        public override string ToString()
        {
            return String.Format("Hourly Employee: {0} {1}, Securiy number: {2}, Hours worked this week: {3}, Houry Rate: {4}",
                                  FirstName, LastName, SecurityNumber, HoursWorked, WagePerHour);
        }
    }
    class Commission:Employee
    {
        private double commissionRate;
        private double salesMade;

        public double CommissionRate
        {
            get { return commissionRate; }
            set { commissionRate = value; }
        }
        public double SalesMade
        {
            get { return salesMade; }
            set { salesMade = value; }
        }
        //constructor
        public Commission(string firstName, string lastName, string securityNumber, double commissionRate, double salesMade)
                          :base(firstName,lastName,securityNumber)
        {
            this.commissionRate = commissionRate/100;
            this.salesMade = salesMade;
        }
        //mehtd
        public override double Earnings()
        {
            double totalSalary = 0;
            totalSalary = salesMade * CommissionRate;
            return totalSalary;
           
        }
        public override string ToString()
        {
            return String.Format("Commision Employee: {0} {1}, Securiy number: {2}, Commision Rate: {3}, Sales Made: {4}", FirstName, LastName, SecurityNumber, CommissionRate, SalesMade);

        }
    }
    class SalariedCommission: Commission
    {
        private double weeklySalary;

        public double WeeklySalary
        {
            get { return weeklySalary; }
            set { weeklySalary = value; }
        }
        //constructor
        public SalariedCommission(string firstName, string lastName, string securityNumber, double weeklySalary, double commisionRate, double salesMade)
                                  :base(firstName,lastName,securityNumber,commisionRate,salesMade)
        {
            this.weeklySalary = weeklySalary;
        }

        public override double Earnings()
        {

            return WeeklySalary + base.Earnings();
        }
        public override string ToString()
        {
            return String.Format("Salaried Commission Employee: {0} {1}, Securiy number: {2}, Weekly Fixed Salary: {3},Commision Rate: {4}, Sales Made: {5}", 
                                  FirstName, LastName, SecurityNumber, WeeklySalary,CommissionRate, SalesMade);

        }
    }
}
