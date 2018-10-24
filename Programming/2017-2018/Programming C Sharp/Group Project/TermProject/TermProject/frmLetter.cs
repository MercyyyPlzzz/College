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
    public partial class frmLetter : Form
    {
        public frmLetter()
        {
            InitializeComponent();

            List<Daves> McCaves = new List<Daves>();

            string[] date = new string[3];
            int[] birth = new int[3];
            string[] row = new string[3];
            string[] column = System.IO.File.ReadAllLines(@"C:\Users\Ken\OneDrive - Limerick Institute Of Technology\Programming\2017-2018\Programming C Sharp\Group Project\TermProject\TermProject\list.txt");

            foreach (string line in column)
            {
                row = line.Split(',');
                McCaves.Add(new Daves() { name = row[0], DOB = row[1], details = row[2] });
            }

            listLetter.View = View.Details;
            listLetter.FullRowSelect = true;
            listLetter.Columns.Add("Name", 200);
            List<Daves> sort = new List<Daves>();
            sort = McCaves.OrderBy(Daves => Daves.name).ToList();
            for(int i=0;i<sort.Count;i++)
            {
                listLetter.Items.Add(sort[i].name);
            }
        }
    }
}
