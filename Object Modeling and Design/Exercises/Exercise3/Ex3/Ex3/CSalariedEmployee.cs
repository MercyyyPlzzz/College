using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
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
