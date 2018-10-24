using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
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
}
