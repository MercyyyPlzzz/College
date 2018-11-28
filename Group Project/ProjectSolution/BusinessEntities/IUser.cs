using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public interface IUser
    {
        string firstName { get; set; }
        string LastName { get; set; }
        string Address1 { get; set; }
        string Address2 { get; set; }
        string City { get; set; }
        string County { get; set; }
        string PhoneNumber { get; set; }
        DateTime DOB { get; set; }
        string Password { get; set; }
        string Department { get; set; }
        int UserID { get; set; }
    }
}
