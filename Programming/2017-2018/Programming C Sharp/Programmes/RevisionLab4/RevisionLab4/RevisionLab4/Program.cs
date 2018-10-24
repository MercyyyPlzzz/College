using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisionLab4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\tPayDay!!");
            Console.WriteLine("\n\t\tWaged Employees : \n");

            CWagedEmployee Waged1 = new CWagedEmployee("Ken", 110, 25, 15);
            if (Waged1.HoursWorked >= 40)
                Waged1.HourlyPayRate *= 1.5;
            Console.WriteLine("Name = {0}\n\n Employee Number: {1}\n Hourly Pay Rate: {2}\n Hours Worked: {3}\n Weekly Wage: {4}\n", Waged1.Name, Waged1.EmployeeNumber, Waged1.HourlyPayRate, Waged1.HoursWorked, Waged1.WeekWage);

            CWagedEmployee Waged2 = new CWagedEmployee("Kevin", 100, 20, 10);
            if (Waged2.HoursWorked >= 40)
                Waged2.HourlyPayRate *= 1.5;
            Console.WriteLine("Name = {0}\n\n Employee Number: {1}\n Hourly Pay Rate: {2}\n Hours Worked: {3}\n Weekly Wage: {4}\n", Waged2.Name, Waged2.EmployeeNumber, Waged2.HourlyPayRate, Waged2.HoursWorked, Waged2.WeekWage);

            Console.WriteLine("\n\n\t\t Salaried Employees: \n");
            CSalariedEmployee Salary1 = new CSalariedEmployee("Sally", 700, 60000);
            Console.WriteLine("Name: {0}\n\n Employee Number: {1}\n Annual Salary: {2}\n Weekly Pay: {3}\n", Salary1.Name, Salary1.EmployeeNumber, Salary1.AnnualSalary, Salary1.WeeklyPay);
        }
        public abstract class CPerson
        {
            public string Name { get; set; }
            public int EmployeeNumber { get; set; }

            public CPerson(string Name, int EmployeeNumber)
            {
                this.Name = Name;
                this.EmployeeNumber = EmployeeNumber;
            }
            public CPerson()
            {
                Name = " ";
                EmployeeNumber = 0;
            }
        }
        public class CWagedEmployee : CPerson
        {
            public double HourlyPayRate { get; set; }
            public int HoursWorked { get; set; }
            public double WeekWage { get; set; }
            public CWagedEmployee() : base()
            {
                HourlyPayRate = 0;
                HoursWorked = 0;
            }
            public CWagedEmployee(string Name, int EmployeeNumber, double HourlyPayRate, int HoursWorked) : base(Name, EmployeeNumber)
            {
                this.HourlyPayRate = HourlyPayRate;
                this.HoursWorked = HoursWorked;
                WeekWage = HourlyPayRate * HoursWorked;
            }
        }
        public class CSalariedEmployee : CPerson
        {
            public int AnnualSalary { get; set; }
            public double WeeklyPay { get; set; }
            public CSalariedEmployee() : base()
            {
                AnnualSalary = 0;
            }
            public CSalariedEmployee(string Name, int EmployeeNumber, int Salary) : base(Name, EmployeeNumber)
            {
                AnnualSalary = Salary;
                WeeklyPay = AnnualSalary / 52;
            }
        }
    }
}
