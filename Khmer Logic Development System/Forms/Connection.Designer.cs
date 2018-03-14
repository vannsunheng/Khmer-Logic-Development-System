partial class Connection
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
        this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.panel1 = new System.Windows.Forms.Panel();
        this.label1 = new System.Windows.Forms.Label();
        this.pictureBox1 = new System.Windows.Forms.PictureBox();
        this.groupBox1 = new System.Windows.Forms.GroupBox();
        this.ch = new System.Windows.Forms.CheckBox();
        this.txtDatabase = new System.Windows.Forms.TextBox();
        this.label5 = new System.Windows.Forms.Label();
        this.txtUser = new System.Windows.Forms.TextBox();
        this.label4 = new System.Windows.Forms.Label();
        this.txtPassword = new System.Windows.Forms.TextBox();
        this.label3 = new System.Windows.Forms.Label();
        this.txtServer = new System.Windows.Forms.TextBox();
        this.label2 = new System.Windows.Forms.Label();
        this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
        this.btnTest = new System.Windows.Forms.Button();
        this.btnSave = new System.Windows.Forms.Button();
        this.btnClose = new System.Windows.Forms.Button();
        this.panel1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
        this.groupBox1.SuspendLayout();
        this.tableLayoutPanel1.SuspendLayout();
        this.SuspendLayout();
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
        // panel1
        // 
        this.panel1.BackgroundImage = global::Khmer_Logic_Development_System.Properties.Resources.plant_underline_hi;
        this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
        this.panel1.Controls.Add(this.label1);
        this.panel1.Controls.Add(this.pictureBox1);
        this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
        this.panel1.Location = new System.Drawing.Point(0, 0);
        this.panel1.Name = "panel1";
        this.panel1.Size = new System.Drawing.Size(347, 71);
        this.panel1.TabIndex = 0;
        // 
        // label1
        // 
        this.label1.AutoSize = true;
        this.label1.BackColor = System.Drawing.Color.Transparent;
        this.label1.Font = new System.Drawing.Font("News701 BT", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.label1.Location = new System.Drawing.Point(104, 28);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(187, 35);
        this.label1.TabIndex = 1;
        this.label1.Text = "Connection";
        // 
        // pictureBox1
        // 
        this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
        this.pictureBox1.Image = global::Khmer_Logic_Development_System.Properties.Resources.server__1_;
        this.pictureBox1.Location = new System.Drawing.Point(0, 0);
        this.pictureBox1.Name = "pictureBox1";
        this.pictureBox1.Size = new System.Drawing.Size(76, 71);
        this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
        this.pictureBox1.TabIndex = 0;
        this.pictureBox1.TabStop = false;
        // 
        // groupBox1
        // 
        this.groupBox1.Controls.Add(this.ch);
        this.groupBox1.Controls.Add(this.txtDatabase);
        this.groupBox1.Controls.Add(this.label5);
        this.groupBox1.Controls.Add(this.txtUser);
        this.groupBox1.Controls.Add(this.label4);
        this.groupBox1.Controls.Add(this.txtPassword);
        this.groupBox1.Controls.Add(this.label3);
        this.groupBox1.Controls.Add(this.txtServer);
        this.groupBox1.Controls.Add(this.label2);
        this.groupBox1.Location = new System.Drawing.Point(9, 73);
        this.groupBox1.Name = "groupBox1";
        this.groupBox1.Size = new System.Drawing.Size(332, 186);
        this.groupBox1.TabIndex = 7;
        this.groupBox1.TabStop = false;
        // 
        // ch
        // 
        this.ch.AutoSize = true;
        this.ch.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.ch.Location = new System.Drawing.Point(103, 43);
        this.ch.Name = "ch";
        this.ch.Size = new System.Drawing.Size(120, 17);
        this.ch.TabIndex = 15;
        this.ch.Text = "Use Trust Connection";
        this.ch.UseVisualStyleBackColor = true;
        this.ch.CheckedChanged += new System.EventHandler(this.ch_CheckedChanged);
        // 
        // txtDatabase
        // 
        this.txtDatabase.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.txtDatabase.Location = new System.Drawing.Point(101, 129);
        this.txtDatabase.Name = "txtDatabase";
        this.txtDatabase.Size = new System.Drawing.Size(209, 27);
        this.txtDatabase.TabIndex = 14;
        // 
        // label5
        // 
        this.label5.AutoSize = true;
        this.label5.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.label5.Location = new System.Drawing.Point(23, 132);
        this.label5.Name = "label5";
        this.label5.Size = new System.Drawing.Size(70, 19);
        this.label5.TabIndex = 13;
        this.label5.Text = "Database";
        // 
        // txtUser
        // 
        this.txtUser.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.txtUser.Location = new System.Drawing.Point(101, 63);
        this.txtUser.Name = "txtUser";
        this.txtUser.Size = new System.Drawing.Size(209, 27);
        this.txtUser.TabIndex = 11;
        // 
        // label4
        // 
        this.label4.AutoSize = true;
        this.label4.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.label4.Location = new System.Drawing.Point(37, 67);
        this.label4.Name = "label4";
        this.label4.Size = new System.Drawing.Size(56, 19);
        this.label4.TabIndex = 9;
        this.label4.Text = "User ID";
        // 
        // txtPassword
        // 
        this.txtPassword.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.txtPassword.Location = new System.Drawing.Point(101, 96);
        this.txtPassword.Name = "txtPassword";
        this.txtPassword.PasswordChar = '*';
        this.txtPassword.Size = new System.Drawing.Size(209, 27);
        this.txtPassword.TabIndex = 12;
        // 
        // label3
        // 
        this.label3.AutoSize = true;
        this.label3.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.label3.Location = new System.Drawing.Point(24, 99);
        this.label3.Name = "label3";
        this.label3.Size = new System.Drawing.Size(69, 19);
        this.label3.TabIndex = 10;
        this.label3.Text = "Password&";
        // 
        // txtServer
        // 
        this.txtServer.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.txtServer.Location = new System.Drawing.Point(101, 13);
        this.txtServer.Name = "txtServer";
        this.txtServer.Size = new System.Drawing.Size(209, 27);
        this.txtServer.TabIndex = 8;
        // 
        // label2
        // 
        this.label2.AutoSize = true;
        this.label2.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.label2.Location = new System.Drawing.Point(45, 16);
        this.label2.Name = "label2";
        this.label2.Size = new System.Drawing.Size(49, 19);
        this.label2.TabIndex = 7;
        this.label2.Text = "Server";
        // 
        // tableLayoutPanel1
        // 
        this.tableLayoutPanel1.ColumnCount = 3;
        this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
        this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
        this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 66F));
        this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
        this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
        this.tableLayoutPanel1.Controls.Add(this.btnTest, 1, 0);
        this.tableLayoutPanel1.Controls.Add(this.btnSave, 0, 0);
        this.tableLayoutPanel1.Controls.Add(this.btnClose, 2, 0);
        this.tableLayoutPanel1.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.tableLayoutPanel1.Location = new System.Drawing.Point(112, 265);
        this.tableLayoutPanel1.Name = "tableLayoutPanel1";
        this.tableLayoutPanel1.RowCount = 1;
        this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.44444F));
        this.tableLayoutPanel1.Size = new System.Drawing.Size(207, 30);
        this.tableLayoutPanel1.TabIndex = 8;
        // 
        // btnTest
        // 
        this.btnTest.Anchor = System.Windows.Forms.AnchorStyles.None;
        this.btnTest.Location = new System.Drawing.Point(74, 3);
        this.btnTest.Name = "btnTest";
        this.btnTest.Size = new System.Drawing.Size(61, 23);
        this.btnTest.TabIndex = 2;
        this.btnTest.Text = "Test";
        this.btnTest.UseVisualStyleBackColor = false;
        this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
        // 
        // btnSave
        // 
        this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
        this.btnSave.Location = new System.Drawing.Point(4, 3);
        this.btnSave.Name = "btnSave";
        this.btnSave.Size = new System.Drawing.Size(61, 23);
        this.btnSave.TabIndex = 1;
        this.btnSave.Text = "Save";
        this.btnSave.UseVisualStyleBackColor = false;
        this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
        // 
        // btnClose
        // 
        this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.None;
        this.btnClose.Location = new System.Drawing.Point(143, 3);
        this.btnClose.Name = "btnClose";
        this.btnClose.Size = new System.Drawing.Size(61, 23);
        this.btnClose.TabIndex = 0;
        this.btnClose.Text = "Close";
        this.btnClose.UseVisualStyleBackColor = false;
        this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
        // 
        // Connection
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.BackColor = System.Drawing.Color.White;
        this.ClientSize = new System.Drawing.Size(347, 312);
        this.Controls.Add(this.tableLayoutPanel1);
        this.Controls.Add(this.groupBox1);
        this.Controls.Add(this.panel1);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        this.MaximizeBox = false;
        this.MinimizeBox = false;
        this.Name = "Connection";
        this.ShowInTaskbar = false;
        this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "Connection";
        this.Load += new System.EventHandler(this.Connection_Load);
        this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Connection_KeyDown);
        this.panel1.ResumeLayout(false);
        this.panel1.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
        this.groupBox1.ResumeLayout(false);
        this.groupBox1.PerformLayout();
        this.tableLayoutPanel1.ResumeLayout(false);
        this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    private System.Windows.Forms.Panel panel1;
    internal System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.TextBox txtDatabase;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.TextBox txtUser;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox txtPassword;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox txtServer;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.CheckBox ch;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.Button btnTest;
    private System.Windows.Forms.Button btnSave;
    private System.Windows.Forms.Button btnClose;
}
