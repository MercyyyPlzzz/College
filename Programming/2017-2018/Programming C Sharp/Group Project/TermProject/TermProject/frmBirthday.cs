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
    public partial class frmBirthday : Form
    {
        List<Daves> McCaves = new List<Daves>();
        public frmBirthday()
        {
            InitializeComponent();

            listBirthday.View = View.Details;
            listBirthday.FullRowSelect = true;
            listBirthday.Columns.Add("Name", 200);
            listBirthday.Columns.Add("Age", 100);
            listBirthday.Columns.Add("Traits", 200);

            string[] date = new string[3];
            int[] birth = new int[3];
            string[] row = new string[3];
            string[] column = System.IO.File.ReadAllLines(@"C:\Users\Ken\OneDrive - Limerick Institute Of Technology\Programming\2017-2018\Programming C Sharp\Group Project\TermProject\TermProject\list.txt");

            foreach (string line in column)
            {
                row = line.Split(',');
                McCaves.Add(new Daves() { name = row[0], DOB = row[1], details = row[2] });
            }

            for (int i = 0; i <= McCaves.Count; i++)
            {
                int years = 0;
                int day=0, month=0, year=0, days=0;
                date = McCaves[i].DOB.Split();
                day = Int32.Parse(date[0]);
                month = Int32.Parse(date[1]);
                year = Int32.Parse(date[2]);
                
                DateTime age = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
                DateTime dob2 = new DateTime(year, month, day);
                years = DateTime.Now.Subtract(age).Days;
                days = DateTime.Now.Subtract(dob2).Days;
                years = (years / 365);
                days = (days * -1);
                if (days > 0)
                {
                    years--;
                }
                if ((days <= 7) & (days >= 0))
                {
                    add(McCaves[i].name, " " + years + " ", McCaves[i].details);
                }
            };
        }
        private void add(string name, string dob, string traits)
        {
            string[] row = { name, dob, traits };
            ListViewItem item = new ListViewItem(row);
            listBirthday.Items.Add(item);
        }
    }
}

