using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Data.SqlClient;

namespace AbbeyMotors
{
    class Model
    {
        //private formContainer fc;
        private User currentUser;
        private SqlConnection con;
        private ArrayList userList;

        public Model()
        {
            userList = new ArrayList();
            con = new SqlConnection();
            con.ConnectionString = "Server=tcp:thecodeignitorspt.database.windows.net,1433;Initial Catalog=prototype;Persist Security Info=False;User ID=codeignitors;Password=Test123Test123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=True;Connection Timeout=30;";

            try
            {
                con.Open();
                //MessageBox.Show("DB Open");
            }
            catch(System.Exception ex)
            {
                MessageBox.Show(ex.Message);
                Environment.Exit(0);//Forces the app to close
            }
        }

        ~Model()
        {
            con.Close();
        }

        public User CurrentUser { get => currentUser; set => currentUser = value; }
        public SqlConnection Con { get => con; set => con = value; }
        public ArrayList UserList { get => userList; set => userList = value; }
      //  public formContainer Fc { get => fc; set => fc = value; }
    }
}
