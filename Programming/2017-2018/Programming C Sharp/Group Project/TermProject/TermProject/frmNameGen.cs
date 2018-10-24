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
    public partial class frmNameGen : Form
    {
        string[] firstNames = System.IO.File.ReadAllLines(@"C:\Users\Ken\OneDrive - Limerick Institute Of Technology\Programming\2017-2018\Programming C Sharp\Group Project\TermProject\TermProject\nameList.txt");
        string[] middleNames = System.IO.File.ReadAllLines(@"C:\Users\Ken\OneDrive - Limerick Institute Of Technology\Programming\2017-2018\Programming C Sharp\Group Project\TermProject\TermProject\middleName_List.txt");
        Random rand = new Random();

        public frmNameGen()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            int iFirst = rand.Next(firstNames.Length);
            int iMiddle = rand.Next(middleNames.Length);
            this.txtBox_First.Text = firstNames[iFirst];
            this.txtBox_Middle.Text = middleNames[iMiddle];
        }
    }
}
