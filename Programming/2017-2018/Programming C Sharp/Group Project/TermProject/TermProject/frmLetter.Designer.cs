namespace TermProject
{
    partial class frmLetter
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
            this.listLetter = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // listLetter
            // 
            this.listLetter.Location = new System.Drawing.Point(13, 13);
            this.listLetter.Name = "listLetter";
            this.listLetter.Size = new System.Drawing.Size(484, 238);
            this.listLetter.TabIndex = 0;
            this.listLetter.UseCompatibleStateImageBehavior = false;
            // 
            // frmLetter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 263);
            this.Controls.Add(this.listLetter);
            this.Name = "frmLetter";
            this.Text = "List By Letter";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listLetter;
    }
}