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
    public partial class formDeleteUser : Form
    {

        #region Instance Attributes
        IModel Model;
        formContainer fc;
        #endregion

        #region Constructors
        public formDeleteUser(formContainer parent, IModel Model)
        {
            InitializeComponent();
            MdiParent = parent;
            fc = parent;
            this.Model = Model;
        }
        #endregion

        private void buttonDeleteUser_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Delete " + listViewUsers.SelectedItems.ToString() + " ? ", "Are you sure !", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                return;
            foreach (User user in Model.UserList)
            {
                if (user.FirstName == listViewUsers.SelectedItems.ToString())
                {
                    Model.deleteUser(user);
                    listViewUsers.Items.Remove(listViewUsers.SelectedItems); //remove name from listbox
                    break;
                }
            }
        }

        private void formDeleteUser_Load(object sender, EventArgs e)
        {
            foreach (User user in Model.UserList)
            {
                listViewUsers.Items.Add(user.FirstName);
            }
        }
    }
}
