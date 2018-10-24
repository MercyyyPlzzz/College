namespace TermProject
{
    partial class frmYearlyAllowance
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblSelect = new System.Windows.Forms.Label();
            this.txtSelect = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblMonthlyEarnings = new System.Windows.Forms.Label();
            this.lvMonthlyEarnings = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // lblSelect
            // 
            this.lblSelect.AutoSize = true;
            this.lblSelect.Location = new System.Drawing.Point(55, 28);
            this.lblSelect.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSelect.Name = "lblSelect";
            this.lblSelect.Size = new System.Drawing.Size(120, 17);
            this.lblSelect.TabIndex = 6;
            this.lblSelect.Text = "Select which Year";
            // 
            // txtSelect
            // 
            this.txtSelect.Location = new System.Drawing.Point(194, 25);
            this.txtSelect.Margin = new System.Windows.Forms.Padding(4);
            this.txtSelect.Multiline = true;
            this.txtSelect.Name = "txtSelect";
            this.txtSelect.Size = new System.Drawing.Size(132, 27);
            this.txtSelect.TabIndex = 7;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(135, 73);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(40, 17);
            this.lblTotal.TabIndex = 8;
            this.lblTotal.Text = "Total";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(194, 70);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotal.Multiline = true;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(132, 27);
            this.txtTotal.TabIndex = 9;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(366, 67);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(4);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(99, 28);
            this.btnCalculate.TabIndex = 10;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblMonthlyEarnings
            // 
            this.lblMonthlyEarnings.AutoSize = true;
            this.lblMonthlyEarnings.Location = new System.Drawing.Point(55, 112);
            this.lblMonthlyEarnings.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMonthlyEarnings.Name = "lblMonthlyEarnings";
            this.lblMonthlyEarnings.Size = new System.Drawing.Size(117, 17);
            this.lblMonthlyEarnings.TabIndex = 11;
            this.lblMonthlyEarnings.Text = "Monthly Earnings";
            // 
            // lvMonthlyEarnings
            // 
            this.lvMonthlyEarnings.Location = new System.Drawing.Point(13, 138);
            this.lvMonthlyEarnings.Margin = new System.Windows.Forms.Padding(4);
            this.lvMonthlyEarnings.Name = "lvMonthlyEarnings";
            this.lvMonthlyEarnings.Size = new System.Drawing.Size(452, 184);
            this.lvMonthlyEarnings.TabIndex = 12;
            this.lvMonthlyEarnings.UseCompatibleStateImageBehavior = false;
            // 
            // frmYearlyAllowance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 335);
            this.Controls.Add(this.lvMonthlyEarnings);
            this.Controls.Add(this.lblMonthlyEarnings);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.txtSelect);
            this.Controls.Add(this.lblSelect);
            this.Name = "frmYearlyAllowance";
            this.Text = "frmYearlyAllowance";
            this.Load += new System.EventHandler(this.frmYearlyAllowance_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSelect;
        private System.Windows.Forms.TextBox txtSelect;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblMonthlyEarnings;
        private System.Windows.Forms.ListView lvMonthlyEarnings;
    }
}