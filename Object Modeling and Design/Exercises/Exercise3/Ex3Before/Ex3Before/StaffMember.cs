using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3Before
{
    class StaffMember
    {        
        private string name;
        private string address;
        private string phone;
        private string socialSecurityNumber;
        private double payRate;
        private double bonus;
        private string staffMember;

        public StaffMember(string name, string address, string phone, string socialSecNo, double bonus, double payRate)
        {
            this.name = name;
            this.address = address;
            this.phone = phone;
            this.socialSecurityNumber = socialSecNo;
            this.bonus = bonus;
            this.payRate = payRate;
            this.staffMember = "Executive";
        }

        public StaffMember(string name, string address, string phone)
        {
            this.name = name;
            this.address = address;
            this.phone = phone;
            this.staffMember = "Volunteer";
        }

        public StaffMember(string name, string address, string phone, string socialSecNo, double payRate)
        {
            this.name = name;
            this.address = address;
            this.phone = phone;
            this.socialSecurityNumber = socialSecNo;
            this.payRate = payRate;
            this.staffMember = "Employee";
        }

         public double pay()
        {
            if (this.getStaffMember() == "Employee")
            {
                return getPayRate();
            }
            else if (this.getStaffMember() == "Executive")
            {
                return this.getPayRate() + this.bonus;
            }
            else if(this.getStaffMember()=="Volunteer")
            {
                return this.getPayRate() + 0;
            }
            else
            {
                return 0;
            }
        }

  
     public double getPayRate()
        {
            return this.payRate;
        }

        public string getStaffMember()
        {
            return this.staffMember;
        }

        public void Add()
        {
            try
            {
                // Add to DB code goes here //
            }
            catch (Exception ex)
            {
                System.IO.File.WriteAllText(@"c:\Error.txt", ex.ToString());
            }
        }


    }
}
