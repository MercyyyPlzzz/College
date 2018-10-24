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
    public partial class frmListAge : Form
    {
        public static int Age(string DOB)
        {
            string[] DMY = new string[3];

            int years = 0;
            DMY = DOB.Split('/');

            int day = Int32.Parse(DMY[0]);
            int month = Int32.Parse(DMY[1]);
            int year = Int32.Parse(DMY[2]);
            DateTime age = new DateTime(year, DateTime.Now.Month, DateTime.Now.Day);
            DateTime dob2 = new DateTime(2018, month, day);
            years = DateTime.Now.Subtract(age).Days;
            int days = DateTime.Now.Subtract(dob2).Days;
            days += 1;
            years = (years / 365);
            if (days < 0)
            {
                years--;
            }
            return years;
        }

        public static int dob(string dob)
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

        public frmListAge()
        {
            InitializeComponent();

            string[] DMY = new string[3];
            int[] DOB = new int[3];
            string[] row = new string[3];
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\Ken\OneDrive - Limerick Institute Of Technology\Programming\2017-2018\Programming C Sharp\Group Project\TermProject\TermProject\list.txt");
            List<Daves> McCaves = new List<Daves>();


            foreach (string line in lines)
            {
                row = line.Split('/');
                McCaves.Add(new Daves() { name = row[0], DOB = row[1], details = row[2], birth = 0 });
                
            }
            lvListAge.View = View.Details;
            lvListAge.FullRowSelect = true;
            lvListAge.Columns.Add("Name", 130);
            lvListAge.Columns.Add("Age", 130);

            List<Daves> temp = new List<Daves>();

            temp = McCaves;

            for (int y = 0; y <= McCaves.Count; y++)
            {
                McCaves[y].birth = dob(McCaves[y].DOB);
            }
            McCaves = McCaves.OrderBy(x => x.birth).ToList();
            for (int j = 0; j < McCaves.Count; j++)
            {
                McCaves[j].age = Age(McCaves[j].DOB);
                add(McCaves[j].name, "" + McCaves[j].age);
            }
        }

        private void add(string name, string dob)
        {
            string[] row = { name, dob };
            ListViewItem item = new ListViewItem(row);
            lvListAge.Items.Add(item);
        }
    }
}
