using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class User : BusinessEntities.IUser
    {
        #region Instance Properties
        private string firstname;
        private string lastname;
        private string address1;
        private string address2;
        private string city;
        private string county;
        private string phonenumber;
        private DateTime dob;
        private string password;
        private string department;
        private int userID;


        #endregion
   
        #region Get/Setters
        public string FirstName { get => firstname; set => firstname = FirstName; }
        public string LastName { get => lastname; set => lastname = LastName; }
        public string Address1 { get => address1; set => address1 = Address1; }
        public string Address2 { get => address2; set => address2 = Address2; }
        public string City { get => city; set => city= City; }
        public string County { get => county; set => county= County; }
        public string PhoneNumber { get => phonenumber; set => phonenumber= PhoneNumber; }
        public DateTime DOB { get => dob; set =>dob =DOB; }
        public string Password { get => password; set => password = Password; }
        public string Department { get => department; set => department = Department; }
        public int UserID { get => userID; set => userID =UserID; }
        #endregion

        #region Constructors
        public User()
        {
            throw new System.NotImplementedException();
        }
        public User(string firstName,string lastName,string address1,string address2,string city,string county,string phonenumber,DateTime dob,string password,string department,int userID)
        {
            this.firstname = firstName;
            this.lastname = lastName;
            this.address1 = address1;
            this.address2 = address2;
            this.city = city;
            this.county = county;
            this.phonenumber = phonenumber;
            this.dob = dob;
            this.password = password;
            this.department = department;
            this.userID = userID;
        }

       
        #endregion
    }
}
