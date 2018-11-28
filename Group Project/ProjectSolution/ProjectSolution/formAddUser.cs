using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccessLayer;
using BusinessEntities;
using BusinessLayouts;

namespace ProjectSolution
{
    public partial class formAddUser : Form
    {

        #region Instance Attributes
        IModel Model;
        formContainer fc;
        #endregion

        #region Constructors
        public formAddUser(formContainer parent, IModel Model)
        {
            InitializeComponent();
            MdiParent = parent;
            fc = parent;
            this.Model = Model;
        }
        #endregion

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonSubmit_Click_Click(object sender, EventArgs e)
        {
            /*  if (listBoxUserType.SelectedIndex != -1)
              { // some validation on userName, we won't allow duplicate usernames
                  IUser duplicateUser = Model.UserList.FirstOrDefault(user => user.Name == textBoxName.Text.Trim());
                  /* provides a shortcut to accessing the element that occurs first in the collection or query,
                  while protecting against invalid accesses if there are no elements.It'sa linq query. FirstOrDefault is a generic method which means it accepts a type parameter that indicates what types it acts upon. 
                  The => is a lambda operator. Anything before the => are the input parameters, and anything after is the expression. You can have multiple input parameters.
                  Think of a lambda expression as"given x, do something with x"       */
                    if (Model.addNewUser(txtfirstName.Text,txtlastName.Text,txtAddress1.Text,txtAddress2.Text,txtCity.Text,txtCounty.Text,txtPhoneNum.Text,Convert.ToDateTime(dateTimeDOB), txtPassword.Text,txtDepartment.Text,Convert.ToInt16(txtID.Text)))
                    {
                        MessageBox.Show("User created");
                        txtfirstName.Text = "";
                        txtlastName.Text = "";
                        txtAddress1.Text = "";
                        txtAddress2.Text = "";
                        txtCity.Text = "";
                        txtCounty.Text = "";
                        txtPhoneNum.Text = "";
                        dateTimeDOB = default(DateTimePicker);
                        txtPassword.Text = "";
                        txtDepartment.Text = "";
                        txtID.Text = "0";
                    }            
        }
    }
}
