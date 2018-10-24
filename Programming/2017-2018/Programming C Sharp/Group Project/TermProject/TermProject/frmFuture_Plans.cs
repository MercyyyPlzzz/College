using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TermProject
{
    public partial class frmFuture_Plans : Form
    {
        List<Daves> McCaves = new List<Daves>();

        public static int DOB(string dob)
        {
            string[] date = new string[3];
            date = dob.Split('/');
            int day = Int32.Parse(date[0]);
            int month = Int32.Parse(date[1]);
            int year = Int32.Parse(date[2]);
            DateTime newDob = new DateTime(year, month, day);
            int dates = DateTime.Now.Subtract(newDob).Days;
            return dates;
        }

        public frmFuture_Plans()
        {
            InitializeComponent();
            string[] date = new string[3];
            int[] birth = new int[3];
            string[] row = new string[3];
            string[] column = System.IO.File.ReadAllLines(@"C:\Users\Ken\OneDrive - Limerick Institute Of Technology\Programming\2017-2018\Programming C Sharp\Group Project\TermProject\TermProject\list.txt");
            string[] sort = new string[5];
            foreach (string line in column)
            {
                row = line.Split(',');
                McCaves.Add(new Daves() { name = row[0], DOB = row[1], details = row[2] });
            }

            listPreSchool.View = View.Details;
            listPreSchool.FullRowSelect = true;
            listPreSchool.Columns.Add("~~~~~~~~~~~", 100);

            listPrimarySchool.View = View.Details;
            listPrimarySchool.FullRowSelect = true;
            listPrimarySchool.Columns.Add("~~~~~~~~~~~", 100);

            listSecondarySchool.View = View.Details;
            listSecondarySchool.FullRowSelect = true;
            listSecondarySchool.Columns.Add("~~~~~~~~~~~", 100);

            listCollege.View = View.Details;
            listCollege.FullRowSelect = true;
            listCollege.Columns.Add("~~~~~~~~~~~", 100);

            listFinished.View = View.Details;
            listFinished.FullRowSelect = true;
            listFinished.Columns.Add("~~~~~~~~~~~", 100);
        }

        private void add(string name)
        {
            string[] row = { name};
            ListViewItem info = new ListViewItem(row);
            listPreSchool.Items.Add(info);
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            string year = txtBox_yearInput.Text;
            int preSchool = Convert.ToInt32(year);
            preSchool -= 5;
            int primarySchool = preSchool - 8;
            int secondarySchool = primarySchool - 6;
            int college = secondarySchool - 4;
            DateTime pre = new DateTime(preSchool, 9, 30);
            DateTime prime = new DateTime(primarySchool, 9, 30);
            DateTime secondary = new DateTime(secondarySchool, 9, 30);
            DateTime third = new DateTime(college, 9, 30);
            int inPre = DateTime.Now.Subtract(pre).Days;
            int inPrime = DateTime.Now.Subtract(prime).Days;
            int inSecond = DateTime.Now.Subtract(secondary).Days;
            int inThird = DateTime.Now.Subtract(third).Days;

            int age;
            for (int i = 0; i < McCaves.Count; i++)
            {
                age = DOB(McCaves[i].DOB);
                if (age <= inPre)
                {
                    listPreSchool.Items.Add(McCaves[i].name);
                }
                else if (age <= inPrime && age > inPre)
                {
                    listPrimarySchool.Items.Add(McCaves[i].name);
                }
                else if (age <= inSecond && age > inPrime)
                {
                    listSecondarySchool.Items.Add(McCaves[i].name);
                }
                else if (age <= inThird && age > inSecond)
                {
                    listCollege.Items.Add(McCaves[i].name);
                }
                else
                {
                    listFinished.Items.Add(McCaves[i].name);
                }
            }
        }
    }
}
