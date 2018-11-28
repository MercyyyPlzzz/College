using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

using BusinessEntities;
namespace DataAccessLayer 
{
    class DataLayer : IDataLayer
    {
        #region Instance Attributes
        private SqlConnection con;   // DB Connection
        DataSet ds;                 //Declare the DataSet object
        SqlDataAdapter da;          //Declare the DataAdapter object
        int totUsers;
        SqlCommandBuilder cb;
        #endregion

        #region Static Attributes
        private static IDataLayer dataLayerSingletonInstance;  // DataLayer object is a singleton so only one instance allowed
        static readonly object padlock = new object(); // Need this for thread safety on the DataLayer singleton creation. ie in GetInstance () method
        #endregion

        #region Constructors
        public static IDataLayer GetInstance() // With Singleton pattern this method is used rather than constructor
        {
            lock (padlock) //   only one thread can entry this block of code
            {
                if (dataLayerSingletonInstance == null)
                {
                    dataLayerSingletonInstance = new DataLayer();
                }
                return dataLayerSingletonInstance;
            }
        }
        private DataLayer()  // The constructor is private as its a singleton and I only allow one instance which is created with the GetInstance() method
        {
            openConnection();
        }
        #endregion

        public void openConnection()
        {
            con = new SqlConnection();
            //con.ConnectionString = "Data Source=SQL1.student.litdom.lit.ie\\INST18SDT5 ;Initial Catalog=prototype;Integrated Security=True";
            con.ConnectionString = "Server=tcp:thecodeignitorspt.database.windows.net,1433;Initial Catalog=prototype;Persist Security Info=False;User ID=codeignitors;Password=Test123Test123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=True;Connection Timeout=30;";
            try
            {
                con.Open();
                //MessageBox.Show("Database Open");
            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
                Environment.Exit(0); //Force the application to close
            }

        }
        public void closeConnection()
        {
            con.Close();
        }

        public SqlConnection getConnection()
        {
            return con;
        }

        public void addNewUserToDB(BusinessEntities.IUser theUser)
        {
            try
            {
                DataSet ds = new DataSet();
                string sql = "SELECT * FROM user";
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                SqlCommandBuilder cb = new SqlCommandBuilder(da);
                da.Fill(ds, "UsersData");
                totUsers = ds.Tables["UsersData"].Rows.Count;
                DataRow dRow = ds.Tables["UsersData"].NewRow();
                dRow[0] = theUser.UserID;
                dRow[1] = theUser.Department;
                dRow[2] = theUser.FirstName;
                dRow[3] = theUser.LastName;
                dRow[4] = theUser.Address1;
                dRow[5] = theUser.Address2;
                dRow[6] = theUser.City;
                dRow[7] = theUser.County;
                dRow[8] = theUser.PhoneNumber;
                dRow[9] = theUser.DOB;
                dRow[10] = theUser.Password;

                ds.Tables["UsersData"].Rows.Add(dRow);
                da.Update(ds, "UsersData");
            }
            catch(System.Exception ex)
            {
                if(con.State.ToString()=="Open")
                {
                    con.Close();
                }
                Application.Exit();
                //Environment.Exit(0);
            }
        }

        public bool deleteUserFromDB(BusinessEntities.IUser user)
        {
            try
            {
                ds = new DataSet();
                string sql = "SELECT * FROM user";
                da = new SqlDataAdapter(sql, con);
                da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                cb = new SqlCommandBuilder(da);
                da.Fill(ds, "UsersData");
                DataRow findRow = ds.Tables["UsersData"].Rows.Find(user.UserID);
                if(findRow!=null)
                {
                    findRow.Delete();
                }
                da.Update(ds, "UsersData");
            }
            catch(System.Exception ex)
            {
                MessageBox.Show(ex.Message);
                if (getConnection().ToString() == "Open")
                    closeConnection();
                Application.Exit();
            }
            return true;
        }

        public List<IUser> getAllUsers()
        {
            List<IUser> UserList = new List<IUser>();
            try
            {

                ds = new DataSet();
                string sql = "SELECT * From user";
                da = new SqlDataAdapter(sql, con);
                cb = new SqlCommandBuilder(da);  //Generates
                da.Fill(ds, "UsersData");
                totUsers = ds.Tables["UsersData"].Rows.Count;
                for (int i = 0; i < totUsers; i++)
                {
                    DataRow dRow = ds.Tables["UsersData"].Rows[i];
                    IUser user = UserFactory.GetUser(dRow.ItemArray.GetValue(0).ToString(),  // Using a Factory to create the user entity object. ie seperating object creation from business logic
                                                        dRow.ItemArray.GetValue(1).ToString(),
                                                        dRow.ItemArray.GetValue(2).ToString(),
                                                        dRow.ItemArray.GetValue(3).ToString(),
                                                        dRow.ItemArray.GetValue(4).ToString(),
                                                        dRow.ItemArray.GetValue(5).ToString(),
                                                        dRow.ItemArray.GetValue(6).ToString(),
                                                        Convert.ToDateTime(dRow.ItemArray.GetValue(7)),
                                                        dRow.ItemArray.GetValue(8).ToString(),
                                                        dRow.ItemArray.GetValue(9).ToString(),
                                                       Convert.ToInt16((dRow.ItemArray.GetValue(10))));

                    UserList.Add(user);
                }
            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
                if (con.State.ToString() == "Open")
                    con.Close();
                Application.Exit();
                //Environment.Exit(0); //Force the application to close
            }
            return UserList;
        }
    }
}
