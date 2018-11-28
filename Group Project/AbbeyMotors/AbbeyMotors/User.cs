using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbbeyMotors
{
    public class User
    {
        private string fname;
        private string lname;
        private string dept;
        private string password;
        private string address1;
        private string address2;
        private string city;
        private string county;
        private string phoneNum;
        private DateTime dob;

        public User()
        {

        }

        public User(string fname, string lname, string dept, string password, string address1, string address2, string city, string county, string phoneNum, DateTime dob)
        {
            this.fname = fname;
            this.lname = lname;
            this.dept = dept;
            this.password = password;
            this.address1 = address1;
            this.address2 = address2;
            this.city = city;
            this.county = county;
            this.phoneNum = phoneNum;
            this.dob = dob;
        }

        public string Fname { get => fname; set => fname = value; }
        public string Lname { get => lname; set => lname = value; }
        public string Dept { get => dept; set => dept = value; }
        public string Password { get => password; set => password = value; }
        public string Address1 { get => address1; set => address1 = value; }
        public string Address2 { get => address2; set => address2 = value; }
        public string City { get => city; set => city = value; }
        public string County { get => county; set => county = value; }
        public string PhoneNum { get => phoneNum; set => phoneNum = value; }
        public DateTime Dob { get => dob; set => dob = value; }
    }
}
