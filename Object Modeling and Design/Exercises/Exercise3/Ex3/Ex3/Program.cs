using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
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
    }
}
