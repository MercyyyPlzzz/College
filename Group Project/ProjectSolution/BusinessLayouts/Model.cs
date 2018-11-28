using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntities;
using DataAccessLayer;

namespace BusinessLayouts
{
    public class Model:IModel
    {
        #region Static Attributes
        private static IModel modelSingletonInstance;  // Model object is a singleton so only one instance allowed
        static readonly object padlock = new object(); // Need this for thread safety on the Model singleton creation. ie in GetInstance () method
        #endregion

        #region Instance Attribures
        private IDataLayer dataLayer;
        private IUser currentUser;
        private List<IUser> userList;
        #endregion

        #region Instance Properties
        public IDataLayer DataLayer
        {
            get { return dataLayer; }
            set { dataLayer = value; }
        }

        public IUser CurrentUser
        {
            get
            {
                return currentUser;
            }
            set
            {
                currentUser = value;
            }
        }

        public List<IUser> UserList
        {
            get
            {
                return userList;
            }
            //set
            //{
            //}
        }
        #endregion

        #region Constructors/Destructors
        public static IModel GetInstance(IDataLayer _DataLayer) // With Singleton pattern this method is used rather than constructor
        {
            lock (padlock) //   only one thread can entry this block of code
            {
                if (modelSingletonInstance == null)
                {
                    modelSingletonInstance = new Model(_DataLayer);
                }
                return modelSingletonInstance;
            }
        }

        private Model(IDataLayer _DataLayer)  // The constructor is private as its a singleton and I only allow one instance which is created with the GetInstance() method
        {
            userList = new List<IUser>();
            dataLayer = _DataLayer;
            userList = dataLayer.getAllUsers(); // setup Models userList so we can login
        }

        ~Model()
        {
            tearDown();
        }
        #endregion

        public void tearDown()
        {
            DataLayer.closeConnection();
        }

        public Boolean addNewUser(string firstName, string lastName, string address1, string address2, string city, string county, string phonenumber, DateTime dob, string password, string department, int userID)
        {
            try
            {
                int maxId = 0;
                // need some code to avoid dulicate usernames
                // maybe add some logic (busiess rules) about password policy
                //      IUser user = new User(name, password, userType); // Construct a User Object
                foreach (User user in UserList)
                {
                    if (user.UserID > maxId)
                        maxId = user.UserID;
                }
                IUser theUser = UserFactory.GetUser(firstName,lastName,address1,address2,city,county,phonenumber,dob,password,department, maxId + 1);   // Using a Factory to create the user entity object. ie seperating object creation from business logic
                UserList.Add(theUser);                             // Add a reference to the newly created object to the Models UserList
                DataLayer.addNewUserToDB(theUser); //Gets the DataLayer to add the new user to the DB. 
                return true;
            }
            catch (System.Exception excep)
            {
                return false;
            }
        }

        public bool deleteUser(IUser user)
        {

            DataLayer.deleteUserFromDB(user);
            UserList.Remove(user); //remove object from collection
            return true;

        }

        public Boolean login(String name, String password)
        {

            //foreach (User user in userList) // now using template so can simplify this code as shown below
            //{
            //    if (name == user.Name && password == user.Password)
            //    {

            //        CurrentUser=user;
            //        return true;
            //    }
            //}
            //return false;

            IUser matchUser = userList.FirstOrDefault(user => user.FirstName == name && user.Password == password);
            if (matchUser == null)
            {
                return false;
            }
            else
            {
                CurrentUser = matchUser;
                return true;
            }
        }
    }
}
