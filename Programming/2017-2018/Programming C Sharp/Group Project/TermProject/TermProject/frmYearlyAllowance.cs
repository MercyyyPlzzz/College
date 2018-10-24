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
    public partial class frmYearlyAllowance : Form
    {

        public frmYearlyAllowance()
        {
            InitializeComponent();
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
        List<Daves> McCaves = new List<Daves>();

        private void frmYearlyAllowance_Load(object sender, EventArgs e)
        {
            string[] DMY = new string[3];
            int[] DOB = new int[3];
            string[] row = new string[3];
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\Ken\OneDrive - Limerick Institute Of Technology\Programming\2017-2018\Programming C Sharp\Group Project\TermProject\TermProject\list.txt");
            foreach (string line in lines)
            {
                row = line.Split(',');

                McCaves.Add(new Daves() { name = row[0], DOB = row[1], details = row[2], birth = 0 });

            }
            lvMonthlyEarnings.View = View.Details;
            lvMonthlyEarnings.FullRowSelect = true;
            lvMonthlyEarnings.Columns.Add("Month", 100);
            lvMonthlyEarnings.Columns.Add("Amount per Month", 110);

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int earned = 0;
            int year18 = Convert.ToInt32(txtSelect.Text);
            int Counter = 0;
            year18 -= 18;
            int daynow = 1;
            int monthnow = 1;
            int[] ages = new int[25];
            do
            {
                DateTime born = new DateTime((year18 + 18), monthnow, daynow);
                DateTime adult = new DateTime(year18, monthnow, daynow);
                int adults = DateTime.Now.Subtract(adult).Days;
                int baby = DateTime.Now.Subtract(born).Days;
                ages[monthnow] = adults;
                ages[monthnow + 12] = baby;
                monthnow++;
            } while (monthnow <= 12);

            int monthearn = 0;

            //Calculate Welfare
            for (int i = 0; i < McCaves.Count; i++)
            {
                int days2;
                days2 = dob(McCaves[i].DOB);


                for (int intrnl = 0; intrnl < McCaves.Count; intrnl++)
                {

                    int days3 = dob(McCaves[intrnl].DOB);
                    if (intrnl != i)
                    {
                        if (days2 == days3)
                        {
                            McCaves[i].twins++;
                        }
                    }
                }
            }
            for (int z = 1; z <= 12; z++)
            {
                monthearn = 0;
                for (int i = 0; i < McCaves.Count; i++)
                {
                    int days2;
                    days2 = dob(McCaves[i].DOB);
                    if (ages[z] > days2 && ages[z + 12] < days2)
                    {

                        switch (McCaves[i].twins)
                        {
                            case 0:
                                earned += 140;
                                monthearn += 140;
                                break;
                            case 1:
                                earned += 210;
                                monthearn += 210;
                                break;
                            case 2:
                                earned += 280;
                                monthearn += 280;
                                break;
                            default:
                                break;
                        }
                    }
                }
                add("Month: " + z, "Earned: " + monthearn);
                txtTotal.Text = ("€" + earned);
            }

            Counter++;
            if (Counter == 2)
            {
                this.Close();
            }

        }

        private void add(string month, string amount)
        {
            string[] row = { month, amount };
            ListViewItem item = new ListViewItem(row);
            lvMonthlyEarnings.Items.Add(item);
        }

        private void frmYearlyAllowance_Load_1(object sender, EventArgs e)
        {

        }
    }
}