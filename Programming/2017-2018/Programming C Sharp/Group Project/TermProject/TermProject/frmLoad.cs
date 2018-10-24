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
    public partial class frmLoad : Form
    {
        public frmLoad()
        {
            InitializeComponent();
        }

        private void btnPath_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog op = new OpenFileDialog();
                if(op.ShowDialog()== DialogResult.OK)
                {
                    txtPath.Text = op.FileName;
                }
            }
            catch
            {

            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    string[] lines = System.IO.File.ReadAllLines(txtPath.Text.Trim());
                    foreach (string line in lines)
                    {
                        listTextFile.Items.Add(line);
                    }
                }
                catch { }
            }
            catch { }
        }
    }
}
