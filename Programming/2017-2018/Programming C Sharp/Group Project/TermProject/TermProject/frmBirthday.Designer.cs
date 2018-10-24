namespace TermProject
{
    partial class frmBirthday
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
            this.listBirthday = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // listBirthday
            // 
            this.listBirthday.Location = new System.Drawing.Point(13, 13);
            this.listBirthday.Name = "listBirthday";
            this.listBirthday.Size = new System.Drawing.Size(728, 234);
            this.listBirthday.TabIndex = 0;
            this.listBirthday.UseCompatibleStateImageBehavior = false;
            // 
            // frmBirthday
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 262);
            this.Controls.Add(this.listBirthday);
            this.Name = "frmBirthday";
            this.Text = "Birthdays";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listBirthday;
    }
}