using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntities;
using DataAccessLayer;

namespace BusinessLayouts
{
    public interface IModel
    {
        bool addNewUser(string firstName, string lastName, string address1, string address2, string city, string county, string phonenumber, DateTime dob, string password, string department, int userID);
        bool login(string name, string password);
        BusinessEntities.IUser CurrentUser { get;set; }
        DataAccessLayer.IDataLayer DataLayer { get; set; }
        bool deleteUser(BusinessEntities.IUser user);
        List<IUser> UserList { get; }
    }
}
