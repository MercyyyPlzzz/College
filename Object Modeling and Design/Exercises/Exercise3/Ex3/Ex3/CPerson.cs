using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
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
}
