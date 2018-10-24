namespace TermProject
{
    partial class frmMultiple
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
            this.listSingle = new System.Windows.Forms.ListView();
            this.listTriplets = new System.Windows.Forms.ListView();
            this.listTwins = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listSingle
            // 
            this.listSingle.Location = new System.Drawing.Point(184, 37);
            this.listSingle.Name = "listSingle";
            this.listSingle.Size = new System.Drawing.Size(151, 264);
            this.listSingle.TabIndex = 0;
            this.listSingle.UseCompatibleStateImageBehavior = false;
            // 
            // listTriplets
            // 
            this.listTriplets.Location = new System.Drawing.Point(353, 37);
            this.listTriplets.Name = "listTriplets";
            this.listTriplets.Size = new System.Drawing.Size(151, 264);
            this.listTriplets.TabIndex = 1;
            this.listTriplets.UseCompatibleStateImageBehavior = false;
            // 
            // listTwins
            // 
            this.listTwins.Location = new System.Drawing.Point(12, 37);
            this.listTwins.Name = "listTwins";
            this.listTwins.Size = new System.Drawing.Size(151, 264);
            this.listTwins.TabIndex = 2;
            this.listTwins.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Single Born";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(234, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Twins";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(398, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Triplets";
            // 
            // frmMultiple
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 326);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listTwins);
            this.Controls.Add(this.listTriplets);
            this.Controls.Add(this.listSingle);
            this.Name = "frmMultiple";
            this.Text = "Multiple Births";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listSingle;
        private System.Windows.Forms.ListView listTriplets;
        private System.Windows.Forms.ListView listTwins;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}