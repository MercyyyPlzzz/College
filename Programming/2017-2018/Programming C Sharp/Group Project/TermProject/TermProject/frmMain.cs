using System;
using System.IO;
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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            
            InitializeComponent();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            Form loadForm = new frmLoad();
            loadForm.ShowDialog();
        }

        private void btnBirthday_Click(object sender, EventArgs e)
        {
            Form birthdayForm = new frmBirthday();
            birthdayForm.ShowDialog();
        }

        private void btnLetter_Click(object sender, EventArgs e)
        {
            Form letterForm = new frmLetter();
            letterForm.ShowDialog();
        }

        private void btnMultiple_Click(object sender, EventArgs e)
        {
            Form multipleForm = new frmMultiple();
            multipleForm.ShowDialog();
        }

        private void btnNameGenerator_Click(object sender, EventArgs e)
        {
            Form nameGenerator_Form = new frmNameGen();
            nameGenerator_Form.ShowDialog();
        }

        private void btnMonthly_Click(object sender, EventArgs e)
        {
            Form monthlyForm = new frmMonthly();
            monthlyForm.ShowDialog();
        }

        private void btnPlans_Click(object sender, EventArgs e)
        {
            Form futureForm = new frmFuture_Plans();
            futureForm.ShowDialog();
        }

        private void btnAge_Click(object sender, EventArgs e)
        {
            Form ListByAge = new frmListAge();
            ListByAge.ShowDialog();
        }

        private void btnAddNewChild_Click(object sender, EventArgs e)
        {
            Form NewChild = new frmNewChild();
            NewChild.ShowDialog();
        }

        private void btnYearlyAllowance_Click(object sender, EventArgs e)
        {
            Form Yearly = new frmYearlyAllowance();
            Yearly.ShowDialog();
        }

        private void btnDynamicInfographic_Click(object sender, EventArgs e)
        {
            
           // Form DynamicInfographic = new frmDynamicInfographic();
            //DynamicInfographic.ShowDialog();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }
    }
}
