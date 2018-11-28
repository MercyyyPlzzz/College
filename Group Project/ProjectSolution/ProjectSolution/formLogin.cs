using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayouts;
using DataAccessLayer;
using BusinessEntities;

namespace ProjectSolution
{
    public partial class formLogin : Form
    {
        private IModel Model;

        public formLogin(IModel Model)
        {
            InitializeComponent();
            this.Model = Model;
        }

        private void buttonLogin_Click_Click(object sender, EventArgs e)
        {
            bool validUser = Model.login(textBoxName.Text, textBoxPassword.Text);

            if (validUser)
                Close();
            else
            {
                MessageBox.Show("Invalid name or password");
                textBoxName.Text = "";
                textBoxPassword.Text = "";
                textBoxName.Select();
            }
        }

        private void buttonExit_Click_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
