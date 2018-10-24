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
    public partial class frmMonthly : Form
    {
        List<Daves> McCaves = new List<Daves>();

        public frmMonthly()
        {
            InitializeComponent();
            listMonthly.View = View.Details;
            listMonthly.FullRowSelect = true;
            listMonthly.Columns.Add("Name", 200);
            listMonthly.Columns.Add("Total", 200);

            string[] date = new string[3];
            int[] birth = new int[3];
            string[] row = new string[3];
            string[] column = System.IO.File.ReadAllLines(@"C:\Users\Ken\OneDrive - Limerick Institute Of Technology\Programming\2017-2018\Programming C Sharp\Group Project\TermProject\TermProject\list.txt");

            foreach (string line in column)
            {
                row = line.Split(',');
                McCaves.Add(new Daves() { name = row[0], DOB = row[1], details = row[2] });
            }

            int presentMonth = DateTime.Now.Month;
            int presentDay = DateTime.Now.Day;
            int presentYear = DateTime.Now.Year;
            presentYear -= 18;
            DateTime peak = new DateTime(presentYear,presentMonth,presentDay);
            int adult = DateTime.Now.Subtract(peak).Days;

            int gained = 0;
            for (int i = 0; i < McCaves.Count; i++)
            {
                int days;
                days = DOB(McCaves[i].DOB);
                for (int j = 0; j < McCaves.Count; j++)
                {
                    int day = DOB(McCaves[j].DOB);
                    if (j != i)
                    {
                        if (days == day)
                        {
                            McCaves[i].twins++;
                        }
                    }
                }
                Console.WriteLine(McCaves[i].name + " " + days + " " + McCaves[i].twins);
                Console.WriteLine();
                if (adult > days)
                {
                    switch (McCaves[i].twins)
                    {
                        case 0:
                            gained += 140;
                            add(McCaves[i].name, "140");
                            break;
                        case 1:
                            gained += 210;
                            add(McCaves[i].name, "210");
                            break;
                        case 2:
                            gained += 280;
                            add(McCaves[i].name, "280");
                            break;
                        default:
                            Console.WriteLine("Error,Error");
                            break;
                    }
                }
                txtDisplay.Text = ("€" + gained);
            }
        }

        private void add(string name, string money)
        {
            string[] row = { name, money };
            ListViewItem info = new ListViewItem(row);
            listMonthly.Items.Add(info);
        }

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
    }
}
