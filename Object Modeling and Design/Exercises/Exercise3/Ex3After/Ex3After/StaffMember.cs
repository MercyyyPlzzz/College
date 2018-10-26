using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3After
{
    class StaffMember:IDatabase,IPay
    { 
        //private FileLogger obj = new FileLogger();
        private string name;
        private string address;
        private string phone;
        private string socialSecurityNumber;
        private double payRate;
        private double bonus;
        private string staffMember;
        private ILogger obj;


        //Problem with Dependency Inversion Principle
        public StaffMember(ILogger i)
        {
            //obj = 1;
        }

        public StaffMember() { }

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

    public virtual double pay()
    {
            return getPayRate();
    }

        public double getBonus()
        {
            return this.bonus;
        }

        public double getPayRate()
    {
        return this.payRate;
    }

    public string getStaffMember()
    {
        return this.staffMember;
    }

    public virtual void Add(int handle)
    {
        try
        {
            // Add to DB code goes here //
        }
        catch (Exception ex)
        {
                if(handle==1)
                {
                    obj = new FileLogger();
                }
                else
                {
                    obj = new EventViewerLogger();
                }             
                obj.Handle(ex.Message.ToString());
        }
    }
}
}
