using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RevisionLab6_calc_
{
    public partial class Form1 : Form
    {
        double value1, value2;
        bool hasDecimal = false;
        bool inputTaken = true;
        string symbol;

        public Form1()
        {
            InitializeComponent();
        }

        #region numberButton
        private void bZero_Click(object sender, EventArgs e)
        {
            if (inputTaken)
            {
                if (txtAnswer.Text.Length >= 1)
                {
                    txtAnswer.Text += bZero.Text;
                }
            }
        }

        private void bOne_Click(object sender, EventArgs e)
        {
            if (inputTaken)
            {
                txtAnswer.Text += bOne.Text;
            }
            else
            {
                txtAnswer.Text = bOne.Text;
                inputTaken = true;
            }
        }

        private void bTwo_Click(object sender, EventArgs e)
        {
            if (inputTaken)
            {
                txtAnswer.Text += bTwo.Text;
            }
            else
            {
                txtAnswer.Text += bTwo.Text;
                inputTaken = true;
            }
        }

        private void bThree_Click(object sender, EventArgs e)
        {
            if (inputTaken)
            {
                txtAnswer.Text += bThree.Text;
            }
            else
            {
                txtAnswer.Text = bThree.Text;
                inputTaken = true;
            }
        }

        private void bFour_Click(object sender, EventArgs e)
        {
            if (inputTaken)
            {
                txtAnswer.Text += bFour.Text;
            }
            else
            {
                txtAnswer.Text = bFour.Text;
                inputTaken = true;
            }
        }

        private void bFive_Click(object sender, EventArgs e)
        {
            if (inputTaken)
            {
                txtAnswer.Text += bFive.Text;
            }
            else
            {
                txtAnswer.Text = bFive.Text;
                inputTaken = true;
            }
        }

        private void bSix_Click(object sender, EventArgs e)
        {
            if (inputTaken)
            {
                txtAnswer.Text += bSix.Text;
            }
            else
            {
                txtAnswer.Text = bSix.Text;
                inputTaken = true;
            }
        }

        private void bSeven_Click(object sender, EventArgs e)
        {
            if (inputTaken)
            {
                txtAnswer.Text += bSeven.Text;
            }
            else
            {
                txtAnswer.Text = bSeven.Text;
                inputTaken = true;
            }
        }

        private void bEight_Click(object sender, EventArgs e)
        {
            if (inputTaken)
            {
                txtAnswer.Text += bEight.Text;
            }
            else
            {
                txtAnswer.Text = bEight.Text;
                inputTaken = true;
            }
        }

        private void bNine_Click(object sender, EventArgs e)
        {
            if (inputTaken)
            {
                txtAnswer.Text += bNine.Text;
            }
            else
            {
                txtAnswer.Text = bNine.Text;
                inputTaken = true;
            }
        }
        #endregion

        #region operators
        private void bAdd_Click(object sender, EventArgs e)
        {
            if (txtAnswer.Text.Length != 0)
            {
                if (symbol == string.Empty)
                {
                    value1 = double.Parse(txtAnswer.Text);
                    txtAnswer.Text = string.Empty;
                }
                else
                {
                    Calculate();
                }
                symbol = "Add";
                hasDecimal = false;
            }
        }

        private void bMinus_Click(object sender, EventArgs e)
        {
            if (txtAnswer.Text.Length != 0)
            {
                if (symbol == string.Empty)
                {
                    value1 = double.Parse(txtAnswer.Text);
                    txtAnswer.Text = string.Empty;
                }
                else
                {
                    Calculate();
                }
                symbol = "Minus";
                hasDecimal = false;
            }
        }

        private void bMultiply_Click(object sender, EventArgs e)
        {
            if (txtAnswer.Text.Length != 0)
            {
                if (symbol == string.Empty)
                {
                    value1 = double.Parse(txtAnswer.Text);
                    txtAnswer.Text = string.Empty;
                }
                else
                {
                    Calculate();
                }
                symbol = "Multiply";
                hasDecimal = false;
            }
        }

        private void bDivide_Click(object sender, EventArgs e)
        {
            if (txtAnswer.Text.Length != 0)
            {
                if (symbol == string.Empty)
                {
                    value1 = double.Parse(txtAnswer.Text);
                    txtAnswer.Text = string.Empty;
                }
                else
                {
                    Calculate();
                }
                symbol = "Divide";
                hasDecimal = false;
            }
        }

        private void bClearEntry_Click(object sender, EventArgs e)
        {
            txtAnswer.Text = string.Empty;
            hasDecimal = false;
        }

        private void bClear_Click(object sender, EventArgs e)
        {
            txtAnswer.Text = string.Empty;
            value1 = 0;
            value2 = 0;
            symbol = string.Empty;
            hasDecimal = false;
        }

        private void bDecimal_Click(object sender, EventArgs e)
        {
            if (inputTaken)
            {
                if (!hasDecimal)
                {
                    if (txtAnswer.Text.Length != 0)
                    {
                        txtAnswer.Text += bDecimal.Text;
                        hasDecimal = true;
                    }
                }
                else
                {
                    txtAnswer.Text = "0.";
                }
                hasDecimal = true;
            }
        }

        private void bEquals_Click(object sender, EventArgs e)
        {
            if(txtAnswer.Text.Length != 0 && value1 != 0)
            {
                Calculate();
                symbol = string.Empty;
                hasDecimal = false;
            }
        }
        #endregion

        #region calculate
        private void Calculate()
        {
            value2 = double.Parse(txtAnswer.Text);
            switch (symbol)
            {
                case "Add":
                    value1 += value2;
                    break;
                case "Minus":
                    value1 -= value2;
                    break;
                case "Divide":
                    value1 = value1 / value2;
                    break;
                case "Multiply":
                    value1 = value1 * value2;
                    break;
            }
            txtAnswer.Text = value1.ToString();
            inputTaken = false;
        }
#endregion
    }
}
