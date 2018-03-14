namespace Khmer_Logic_Development_System
{
    partial class Dashboard
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblEnglishName = new System.Windows.Forms.Label();
            this.lblKhmerName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Khmer_Logic_Development_System.Properties.Resources.loan;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(203, 182);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblEnglishName
            // 
            this.lblEnglishName.AutoSize = true;
            this.lblEnglishName.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnglishName.Location = new System.Drawing.Point(221, 12);
            this.lblEnglishName.Name = "lblEnglishName";
            this.lblEnglishName.Size = new System.Drawing.Size(242, 30);
            this.lblEnglishName.TabIndex = 1;
            this.lblEnglishName.Text = "Company Name English";
            // 
            // lblKhmerName
            // 
            this.lblKhmerName.AutoSize = true;
            this.lblKhmerName.Font = new System.Drawing.Font("Khmer OS Siemreap", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKhmerName.Location = new System.Drawing.Point(221, 55);
            this.lblKhmerName.Name = "lblKhmerName";
            this.lblKhmerName.Size = new System.Drawing.Size(248, 38);
            this.lblKhmerName.TabIndex = 2;
            this.lblKhmerName.Text = "Company Name Khmer";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 389);
            this.Controls.Add(this.lblKhmerName);
            this.Controls.Add(this.lblEnglishName);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblEnglishName;
        private System.Windows.Forms.Label lblKhmerName;
    }
}