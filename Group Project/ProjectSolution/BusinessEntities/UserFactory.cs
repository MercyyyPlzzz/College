using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public static class UserFactory
    {
        private static IUser user = null;

        public static IUser GetUser(string firstName, string lastName, string address1, string address2, string city, string county, string phonenumber, DateTime dob, string password, string department, int userID)
        {
            if(user !=null)
            {
                return user;
            }
            else
            {
                return new User(firstName, lastName, address1, address2, city, county, phonenumber, dob, password, department, userID);
            }
        }

        public static void SetUser(IUser aUser)
        {
            user = aUser;
        }
    }
}
