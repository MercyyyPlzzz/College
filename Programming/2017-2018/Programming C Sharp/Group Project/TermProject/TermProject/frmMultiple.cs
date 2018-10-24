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
    public partial class frmMultiple : Form
    {
        List<Daves> McCaves = new List<Daves>();

        public frmMultiple()
        {
            InitializeComponent();
            string[] date = new string[3];
            int[] birth = new int[3];
            string[] row = new string[3];
            string[] column = System.IO.File.ReadAllLines(@"C:\Users\Ken\OneDrive - Limerick Institute Of Technology\Programming\2017-2018\Programming C Sharp\Group Project\TermProject\TermProject\list.txt");

            foreach (string line in column)
            {
                row = line.Split(',');
                McCaves.Add(new Daves() { name = row[0], DOB = row[1], details = row[2] });
            }
            //Single Borns Only
            listSingle.View = View.Details;
            listSingle.FullRowSelect = true;
            listSingle.Columns.Add("~~~~~~~~~", 100);

            //Twins Only
            listTwins.View = View.Details;
            listTwins.FullRowSelect = true;
            listTwins.Columns.Add("~~~~~~~~~", 100);

            //Triplets Only
            listTriplets.View = View.Details;
            listTriplets.FullRowSelect = true;
            listTriplets.Columns.Add("~~~~~~~~~", 100);

            for (int i = 0; i < McCaves.Count; i++)
            {
                int dates;
                dates = DOB(McCaves[i].DOB);
                for (int count = 0; count < McCaves.Count; count++)
                {
                    int day = DOB(McCaves[count].DOB);
                    if (count != i)
                    {
                        if (dates == day)
                        {
                            McCaves[i].twins++;
                        }
                    }
                }
            }
            for (int j = 0; j < McCaves.Count; j++)
                switch (McCaves[j].twins)
                {
                    case 0:
                        listSingle.Items.Add(McCaves[j].name);
                        break;
                    case 1:
                        listTwins.Items.Add(McCaves[j].name);//twin box
                        break;
                    case 2:
                        listTriplets.Items.Add(McCaves[j].name);//triplet box
                        break;
                    default:
                        Console.WriteLine("Error, Data not Found!");
                        break;
                }
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
