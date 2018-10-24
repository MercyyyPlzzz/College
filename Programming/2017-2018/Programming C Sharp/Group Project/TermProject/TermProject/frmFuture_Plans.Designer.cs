namespace TermProject
{
    partial class frmFuture_Plans
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
            this.txtBox_yearInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listPreSchool = new System.Windows.Forms.ListView();
            this.listPrimarySchool = new System.Windows.Forms.ListView();
            this.listSecondarySchool = new System.Windows.Forms.ListView();
            this.listCollege = new System.Windows.Forms.ListView();
            this.listFinished = new System.Windows.Forms.ListView();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBox_yearInput
            // 
            this.txtBox_yearInput.Location = new System.Drawing.Point(120, 17);
            this.txtBox_yearInput.Name = "txtBox_yearInput";
            this.txtBox_yearInput.Size = new System.Drawing.Size(124, 22);
            this.txtBox_yearInput.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter Year : ";
            // 
            // listPreSchool
            // 
            this.listPreSchool.Location = new System.Drawing.Point(29, 124);
            this.listPreSchool.Name = "listPreSchool";
            this.listPreSchool.Size = new System.Drawing.Size(152, 233);
            this.listPreSchool.TabIndex = 2;
            this.listPreSchool.UseCompatibleStateImageBehavior = false;
            // 
            // listPrimarySchool
            // 
            this.listPrimarySchool.Location = new System.Drawing.Point(205, 124);
            this.listPrimarySchool.Name = "listPrimarySchool";
            this.listPrimarySchool.Size = new System.Drawing.Size(152, 233);
            this.listPrimarySchool.TabIndex = 3;
            this.listPrimarySchool.UseCompatibleStateImageBehavior = false;
            // 
            // listSecondarySchool
            // 
            this.listSecondarySchool.Location = new System.Drawing.Point(379, 124);
            this.listSecondarySchool.Name = "listSecondarySchool";
            this.listSecondarySchool.Size = new System.Drawing.Size(171, 233);
            this.listSecondarySchool.TabIndex = 4;
            this.listSecondarySchool.UseCompatibleStateImageBehavior = false;
            // 
            // listCollege
            // 
            this.listCollege.Location = new System.Drawing.Point(572, 124);
            this.listCollege.Name = "listCollege";
            this.listCollege.Size = new System.Drawing.Size(152, 233);
            this.listCollege.TabIndex = 5;
            this.listCollege.UseCompatibleStateImageBehavior = false;
            // 
            // listFinished
            // 
            this.listFinished.Location = new System.Drawing.Point(743, 124);
            this.listFinished.Name = "listFinished";
            this.listFinished.Size = new System.Drawing.Size(152, 233);
            this.listFinished.TabIndex = 6;
            this.listFinished.UseCompatibleStateImageBehavior = false;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(162, 53);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(110, 23);
            this.btnGenerate.TabIndex = 7;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(58, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "PreSchool";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(221, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Primary School";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(389, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Secondary School";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(612, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "College";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(781, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Finished";
            // 
            // frmFuture_Plans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 384);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.listFinished);
            this.Controls.Add(this.listCollege);
            this.Controls.Add(this.listSecondarySchool);
            this.Controls.Add(this.listPrimarySchool);
            this.Controls.Add(this.listPreSchool);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBox_yearInput);
            this.Name = "frmFuture_Plans";
            this.Text = "Future Education Planner";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBox_yearInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listPreSchool;
        private System.Windows.Forms.ListView listPrimarySchool;
        private System.Windows.Forms.ListView listSecondarySchool;
        private System.Windows.Forms.ListView listCollege;
        private System.Windows.Forms.ListView listFinished;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}