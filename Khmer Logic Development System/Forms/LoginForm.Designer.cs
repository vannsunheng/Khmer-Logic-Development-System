partial class LoginForm
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
        this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
        this.btnSave = new System.Windows.Forms.Button();
        this.btnClose = new System.Windows.Forms.Button();
        this.txtUser = new System.Windows.Forms.TextBox();
        this.label4 = new System.Windows.Forms.Label();
        this.txtPassword = new System.Windows.Forms.TextBox();
        this.label3 = new System.Windows.Forms.Label();
        this.pictureBox1 = new System.Windows.Forms.PictureBox();
        this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.tableLayoutPanel1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
        this.SuspendLayout();
        // 
        // tableLayoutPanel1
        // 
        this.tableLayoutPanel1.ColumnCount = 2;
        this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
        this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
        this.tableLayoutPanel1.Controls.Add(this.btnSave, 0, 0);
        this.tableLayoutPanel1.Controls.Add(this.btnClose, 1, 0);
        this.tableLayoutPanel1.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.tableLayoutPanel1.Location = new System.Drawing.Point(63, 276);
        this.tableLayoutPanel1.Name = "tableLayoutPanel1";
        this.tableLayoutPanel1.RowCount = 1;
        this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
        this.tableLayoutPanel1.Size = new System.Drawing.Size(179, 35);
        this.tableLayoutPanel1.TabIndex = 8;
        // 
        // btnSave
        // 
        this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
        this.btnSave.Location = new System.Drawing.Point(5, 3);
        this.btnSave.Name = "btnSave";
        this.btnSave.Size = new System.Drawing.Size(78, 29);
        this.btnSave.TabIndex = 1;
        this.btnSave.Text = "&Login";
        this.btnSave.UseVisualStyleBackColor = false;
        this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
        // 
        // btnClose
        // 
        this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.None;
        this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        this.btnClose.Location = new System.Drawing.Point(94, 3);
        this.btnClose.Name = "btnClose";
        this.btnClose.Size = new System.Drawing.Size(79, 29);
        this.btnClose.TabIndex = 2;
        this.btnClose.Text = "C&lose";
        this.btnClose.UseVisualStyleBackColor = false;
        // 
        // txtUser
        // 
        this.txtUser.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.txtUser.Location = new System.Drawing.Point(26, 117);
        this.txtUser.Name = "txtUser";
        this.txtUser.Size = new System.Drawing.Size(227, 27);
        this.txtUser.TabIndex = 15;
        this.txtUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
        // 
        // label4
        // 
        this.label4.AutoSize = true;
        this.label4.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.label4.Location = new System.Drawing.Point(106, 80);
        this.label4.Name = "label4";
        this.label4.Size = new System.Drawing.Size(87, 21);
        this.label4.TabIndex = 13;
        this.label4.Text = "User Name";
        // 
        // txtPassword
        // 
        this.txtPassword.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.txtPassword.Location = new System.Drawing.Point(26, 204);
        this.txtPassword.Name = "txtPassword";
        this.txtPassword.PasswordChar = '*';
        this.txtPassword.Size = new System.Drawing.Size(227, 27);
        this.txtPassword.TabIndex = 16;
        this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
        // 
        // label3
        // 
        this.label3.AutoSize = true;
        this.label3.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.label3.Location = new System.Drawing.Point(111, 168);
        this.label3.Name = "label3";
        this.label3.Size = new System.Drawing.Size(77, 21);
        this.label3.TabIndex = 14;
        this.label3.Text = "Password&";
        // 
        // pictureBox1
        // 
        this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
        this.pictureBox1.Image = global::Khmer_Logic_Development_System.Properties.Resources.LoginLogo;
        this.pictureBox1.Location = new System.Drawing.Point(0, 0);
        this.pictureBox1.Name = "pictureBox1";
        this.pictureBox1.Size = new System.Drawing.Size(288, 72);
        this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
        this.pictureBox1.TabIndex = 9;
        this.pictureBox1.TabStop = false;
        // 
        // dataGridViewTextBoxColumn1
        // 
        this.dataGridViewTextBoxColumn1.HeaderText = "Column1";
        this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
        // 
        // dataGridViewTextBoxColumn2
        // 
        this.dataGridViewTextBoxColumn2.HeaderText = "Column2";
        this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
        // 
        // dataGridViewTextBoxColumn3
        // 
        this.dataGridViewTextBoxColumn3.HeaderText = "Column3";
        this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
        // 
        // dataGridViewTextBoxColumn4
        // 
        this.dataGridViewTextBoxColumn4.HeaderText = "Column4";
        this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
        // 
        // dataGridViewTextBoxColumn5
        // 
        this.dataGridViewTextBoxColumn5.HeaderText = "Column5";
        this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
        // 
        // dataGridViewTextBoxColumn6
        // 
        this.dataGridViewTextBoxColumn6.HeaderText = "Column6";
        this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
        // 
        // LoginForm
        // 
        this.AcceptButton = this.btnSave;
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.BackColor = System.Drawing.Color.White;
        this.CancelButton = this.btnClose;
        this.ClientSize = new System.Drawing.Size(288, 352);
        this.Controls.Add(this.txtUser);
        this.Controls.Add(this.label4);
        this.Controls.Add(this.txtPassword);
        this.Controls.Add(this.label3);
        this.Controls.Add(this.pictureBox1);
        this.Controls.Add(this.tableLayoutPanel1);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        this.MaximizeBox = false;
        this.MinimizeBox = false;
        this.Name = "LoginForm";
        this.ShowInTaskbar = false;
        this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "Login Form";
        this.Load += new System.EventHandler(this.LoginForm_Load);
        this.Shown += new System.EventHandler(this.LoginForm_Shown);
        this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LoginForm_KeyDown);
        this.tableLayoutPanel1.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
        this.ResumeLayout(false);
        this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.Button btnSave;
    private System.Windows.Forms.Button btnClose;
    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.TextBox txtUser;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox txtPassword;
    private System.Windows.Forms.Label label3;
}
