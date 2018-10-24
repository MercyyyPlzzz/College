using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TermProject
{
    public partial class frmNewChild : Form
    {
        List<Daves> McCaves = new List<Daves>();

        public frmNewChild()
        {
            InitializeComponent();
        }

        private void frmNewChild_Load(object sender, EventArgs e)
        {
            string[] row = new string[3];
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\Ken\OneDrive - Limerick Institute Of Technology\Programming\2017-2018\Programming C Sharp\Group Project\TermProject\TermProject\list.txt");
            List<Daves> McCaves = new List<Daves>();

            foreach (string line in lines)
            {
                row = line.Split(',');

                McCaves.Add(new Daves() { name = row[0], DOB = row[1], details = row[2], birth = 0 });

            }
        }

        private void add(string name, string dob, string comments)
        {
            string[] row = { name, dob, comments };
            ListViewItem item = new ListViewItem(row);
        }

        private void btnAddNewChild_Click(object sender, EventArgs e)
        {
            string NewName = txtName.Text;
            string NewDob = dtpDOB.Text;
            string NewComment = txtComment.Text;
            McCaves.Add(new Daves() { name = NewName, DOB = NewDob, details = NewComment });

            TextWriter tw = new StreamWriter(@"C:\Users\Ken\OneDrive - Limerick Institute Of Technology\Programming\2017-2018\Programming C Sharp\Group Project\TermProject\TermProject\list.txt", true);

            //Write to file
            for (int i = 0; i < McCaves.Count; i++)
            {
                tw.WriteLine(McCaves[i].name + "," + McCaves[i].DOB + "," + McCaves[i].details);
            }
            MessageBox.Show("Congratulations on your new child " + txtName.Text + "!");
            //Close File
            tw.Close();

            txtName.Text = "";
            dtpDOB.Text = "";
            txtComment.Text = "";

            for (int i = 0; i < McCaves.Count; i++)
            {
                add(McCaves[i].name, McCaves[i].DOB, McCaves[i].details);
            }

            txtName.Text = "";
            txtComment.Text = "";
        }

        private void dtpDOB_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}

