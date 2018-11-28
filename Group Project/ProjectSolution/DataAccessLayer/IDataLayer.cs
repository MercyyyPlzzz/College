using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntities;
namespace DataAccessLayer
{
    public interface IDataLayer
    {

        void closeConnection();
        List<IUser> getAllUsers();
        void addNewUserToDB(BusinessEntities.IUser theUser);
        bool deleteUserFromDB(BusinessEntities.IUser user);
        System.Data.SqlClient.SqlConnection getConnection();
        void openConnection();      
 }
}
