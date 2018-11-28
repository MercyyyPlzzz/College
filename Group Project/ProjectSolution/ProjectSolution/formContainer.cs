using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessEntities;
using DataAccessLayer;
using BusinessLayouts;

namespace ProjectSolution
{
    public partial class formContainer : Form
    {
        #region Instance Attributes
        private IModel Model;
        #endregion 

        #region Constructors
        public formContainer(IModel _Model) // gets passed a reference to the model object
        {
            InitializeComponent();
            Model = _Model;
        }
        #endregion

        private void formContainer_Shown(object sender, EventArgs e)
        {
            formLogin formLgn = new formLogin(Model);
            formLgn.ShowDialog();


           /* switch (Model.getUserTypeForCurrentuser())
            {
                case "Manager":
                    formManager form1 = new formManager(this, Model); // All forms get passed the formContainer and a reference to the model object. 
                    this.Text = this.Text + "-Manager";
                    form1.Dock = DockStyle.Fill;
                    form1.Show();
                    break;
            }*/


        }
    }
}
