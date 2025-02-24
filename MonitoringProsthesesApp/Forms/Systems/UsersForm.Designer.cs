﻿namespace MonitoringProsthesesApp.Forms.Systems {
  partial class UsersForm {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
      this.panel1 = new System.Windows.Forms.Panel();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.PasswordAndRePasswordDontMatchLbl = new System.Windows.Forms.Label();
      this.FirstNameLbl = new System.Windows.Forms.Label();
      this.AddBtn = new System.Windows.Forms.Button();
      this.FirstNameTBox = new System.Windows.Forms.TextBox();
      this.ExitBtn = new System.Windows.Forms.Button();
      this.FirstNameValiadtionLbl = new System.Windows.Forms.Label();
      this.ClearBtn = new System.Windows.Forms.Button();
      this.LastNameValiadtionLbl = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.LastNameTBox = new System.Windows.Forms.TextBox();
      this.UserLoginValidationLbl = new System.Windows.Forms.Label();
      this.LastNameLbl = new System.Windows.Forms.Label();
      this.label9 = new System.Windows.Forms.Label();
      this.PasswordTbx = new System.Windows.Forms.TextBox();
      this.DescriptionTbx = new System.Windows.Forms.TextBox();
      this.RePasswordValidationLbl = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.RolesCBox = new System.Windows.Forms.ComboBox();
      this.label6 = new System.Windows.Forms.Label();
      this.RePasswordTbx = new System.Windows.Forms.TextBox();
      this.PasswordValidationLbl = new System.Windows.Forms.Label();
      this.UserLoginTbx = new System.Windows.Forms.TextBox();
      this.UsersGridView = new System.Windows.Forms.DataGridView();
      this.panel1.SuspendLayout();
      this.groupBox1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.UsersGridView)).BeginInit();
      this.SuspendLayout();
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.groupBox1);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
      this.panel1.Location = new System.Drawing.Point(0, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(405, 744);
      this.panel1.TabIndex = 77;
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.PasswordAndRePasswordDontMatchLbl);
      this.groupBox1.Controls.Add(this.FirstNameLbl);
      this.groupBox1.Controls.Add(this.AddBtn);
      this.groupBox1.Controls.Add(this.FirstNameTBox);
      this.groupBox1.Controls.Add(this.ExitBtn);
      this.groupBox1.Controls.Add(this.FirstNameValiadtionLbl);
      this.groupBox1.Controls.Add(this.ClearBtn);
      this.groupBox1.Controls.Add(this.LastNameValiadtionLbl);
      this.groupBox1.Controls.Add(this.label2);
      this.groupBox1.Controls.Add(this.LastNameTBox);
      this.groupBox1.Controls.Add(this.UserLoginValidationLbl);
      this.groupBox1.Controls.Add(this.LastNameLbl);
      this.groupBox1.Controls.Add(this.label9);
      this.groupBox1.Controls.Add(this.PasswordTbx);
      this.groupBox1.Controls.Add(this.DescriptionTbx);
      this.groupBox1.Controls.Add(this.RePasswordValidationLbl);
      this.groupBox1.Controls.Add(this.label5);
      this.groupBox1.Controls.Add(this.label4);
      this.groupBox1.Controls.Add(this.RolesCBox);
      this.groupBox1.Controls.Add(this.label6);
      this.groupBox1.Controls.Add(this.RePasswordTbx);
      this.groupBox1.Controls.Add(this.PasswordValidationLbl);
      this.groupBox1.Controls.Add(this.UserLoginTbx);
      this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.groupBox1.Location = new System.Drawing.Point(12, 12);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(375, 385);
      this.groupBox1.TabIndex = 1;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Додати:";
      // 
      // PasswordAndRePasswordDontMatchLbl
      // 
      this.PasswordAndRePasswordDontMatchLbl.AutoSize = true;
      this.PasswordAndRePasswordDontMatchLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.PasswordAndRePasswordDontMatchLbl.ForeColor = System.Drawing.Color.Red;
      this.PasswordAndRePasswordDontMatchLbl.Location = new System.Drawing.Point(147, 230);
      this.PasswordAndRePasswordDontMatchLbl.Name = "PasswordAndRePasswordDontMatchLbl";
      this.PasswordAndRePasswordDontMatchLbl.Size = new System.Drawing.Size(184, 12);
      this.PasswordAndRePasswordDontMatchLbl.TabIndex = 83;
      this.PasswordAndRePasswordDontMatchLbl.Text = "Поля пароль і підтвердити не співпадають";
      this.PasswordAndRePasswordDontMatchLbl.Visible = false;
      // 
      // FirstNameLbl
      // 
      this.FirstNameLbl.AutoSize = true;
      this.FirstNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.FirstNameLbl.Location = new System.Drawing.Point(67, 52);
      this.FirstNameLbl.Name = "FirstNameLbl";
      this.FirstNameLbl.Size = new System.Drawing.Size(33, 16);
      this.FirstNameLbl.TabIndex = 84;
      this.FirstNameLbl.Text = "Ім\'я:";
      // 
      // AddBtn
      // 
      this.AddBtn.Location = new System.Drawing.Point(68, 345);
      this.AddBtn.Name = "AddBtn";
      this.AddBtn.Size = new System.Drawing.Size(81, 23);
      this.AddBtn.TabIndex = 71;
      this.AddBtn.Text = "Додати";
      this.AddBtn.UseVisualStyleBackColor = true;
      this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
      // 
      // FirstNameTBox
      // 
      this.FirstNameTBox.Location = new System.Drawing.Point(145, 49);
      this.FirstNameTBox.MaxLength = 200;
      this.FirstNameTBox.Name = "FirstNameTBox";
      this.FirstNameTBox.Size = new System.Drawing.Size(214, 22);
      this.FirstNameTBox.TabIndex = 65;
      // 
      // ExitBtn
      // 
      this.ExitBtn.Location = new System.Drawing.Point(279, 345);
      this.ExitBtn.Name = "ExitBtn";
      this.ExitBtn.Size = new System.Drawing.Size(81, 23);
      this.ExitBtn.TabIndex = 73;
      this.ExitBtn.Text = "Вихід";
      this.ExitBtn.UseVisualStyleBackColor = true;
      this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
      // 
      // FirstNameValiadtionLbl
      // 
      this.FirstNameValiadtionLbl.AutoSize = true;
      this.FirstNameValiadtionLbl.ForeColor = System.Drawing.Color.Red;
      this.FirstNameValiadtionLbl.Location = new System.Drawing.Point(118, 52);
      this.FirstNameValiadtionLbl.Name = "FirstNameValiadtionLbl";
      this.FirstNameValiadtionLbl.Size = new System.Drawing.Size(13, 16);
      this.FirstNameValiadtionLbl.TabIndex = 87;
      this.FirstNameValiadtionLbl.Text = "*";
      // 
      // ClearBtn
      // 
      this.ClearBtn.Location = new System.Drawing.Point(174, 345);
      this.ClearBtn.Name = "ClearBtn";
      this.ClearBtn.Size = new System.Drawing.Size(81, 23);
      this.ClearBtn.TabIndex = 72;
      this.ClearBtn.Text = "Очистити";
      this.ClearBtn.UseVisualStyleBackColor = true;
      this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
      // 
      // LastNameValiadtionLbl
      // 
      this.LastNameValiadtionLbl.AutoSize = true;
      this.LastNameValiadtionLbl.ForeColor = System.Drawing.Color.Red;
      this.LastNameValiadtionLbl.Location = new System.Drawing.Point(118, 24);
      this.LastNameValiadtionLbl.Name = "LastNameValiadtionLbl";
      this.LastNameValiadtionLbl.Size = new System.Drawing.Size(13, 16);
      this.LastNameValiadtionLbl.TabIndex = 86;
      this.LastNameValiadtionLbl.Text = "*";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(58, 246);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(47, 16);
      this.label2.TabIndex = 74;
      this.label2.Text = "Логин";
      // 
      // LastNameTBox
      // 
      this.LastNameTBox.Location = new System.Drawing.Point(145, 21);
      this.LastNameTBox.MaxLength = 200;
      this.LastNameTBox.Name = "LastNameTBox";
      this.LastNameTBox.Size = new System.Drawing.Size(214, 22);
      this.LastNameTBox.TabIndex = 64;
      // 
      // UserLoginValidationLbl
      // 
      this.UserLoginValidationLbl.AutoSize = true;
      this.UserLoginValidationLbl.ForeColor = System.Drawing.Color.Red;
      this.UserLoginValidationLbl.Location = new System.Drawing.Point(119, 249);
      this.UserLoginValidationLbl.Name = "UserLoginValidationLbl";
      this.UserLoginValidationLbl.Size = new System.Drawing.Size(13, 16);
      this.UserLoginValidationLbl.TabIndex = 79;
      this.UserLoginValidationLbl.Text = "*";
      // 
      // LastNameLbl
      // 
      this.LastNameLbl.AutoSize = true;
      this.LastNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.LastNameLbl.Location = new System.Drawing.Point(34, 24);
      this.LastNameLbl.Name = "LastNameLbl";
      this.LastNameLbl.Size = new System.Drawing.Size(73, 16);
      this.LastNameLbl.TabIndex = 85;
      this.LastNameLbl.Text = "Прізвище:";
      // 
      // label9
      // 
      this.label9.AutoSize = true;
      this.label9.Location = new System.Drawing.Point(67, 82);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(41, 16);
      this.label9.TabIndex = 80;
      this.label9.Text = "Опис";
      // 
      // PasswordTbx
      // 
      this.PasswordTbx.Location = new System.Drawing.Point(144, 280);
      this.PasswordTbx.MaxLength = 20;
      this.PasswordTbx.Name = "PasswordTbx";
      this.PasswordTbx.Size = new System.Drawing.Size(216, 22);
      this.PasswordTbx.TabIndex = 69;
      this.PasswordTbx.UseSystemPasswordChar = true;
      // 
      // DescriptionTbx
      // 
      this.DescriptionTbx.Location = new System.Drawing.Point(144, 79);
      this.DescriptionTbx.MaxLength = 200;
      this.DescriptionTbx.Multiline = true;
      this.DescriptionTbx.Name = "DescriptionTbx";
      this.DescriptionTbx.Size = new System.Drawing.Size(214, 75);
      this.DescriptionTbx.TabIndex = 66;
      // 
      // RePasswordValidationLbl
      // 
      this.RePasswordValidationLbl.AutoSize = true;
      this.RePasswordValidationLbl.ForeColor = System.Drawing.Color.Red;
      this.RePasswordValidationLbl.Location = new System.Drawing.Point(119, 310);
      this.RePasswordValidationLbl.Name = "RePasswordValidationLbl";
      this.RePasswordValidationLbl.Size = new System.Drawing.Size(13, 16);
      this.RePasswordValidationLbl.TabIndex = 78;
      this.RePasswordValidationLbl.Text = "*";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(14, 310);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(91, 16);
      this.label5.TabIndex = 77;
      this.label5.Text = "Підтвердити";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(48, 283);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(57, 16);
      this.label4.TabIndex = 75;
      this.label4.Text = "Пароль";
      // 
      // RolesCBox
      // 
      this.RolesCBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.RolesCBox.FormattingEnabled = true;
      this.RolesCBox.Location = new System.Drawing.Point(143, 200);
      this.RolesCBox.Name = "RolesCBox";
      this.RolesCBox.Size = new System.Drawing.Size(215, 24);
      this.RolesCBox.TabIndex = 67;
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(65, 203);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(40, 16);
      this.label6.TabIndex = 81;
      this.label6.Text = "Роль";
      // 
      // RePasswordTbx
      // 
      this.RePasswordTbx.Location = new System.Drawing.Point(143, 307);
      this.RePasswordTbx.MaxLength = 20;
      this.RePasswordTbx.Name = "RePasswordTbx";
      this.RePasswordTbx.Size = new System.Drawing.Size(216, 22);
      this.RePasswordTbx.TabIndex = 70;
      this.RePasswordTbx.UseSystemPasswordChar = true;
      // 
      // PasswordValidationLbl
      // 
      this.PasswordValidationLbl.AutoSize = true;
      this.PasswordValidationLbl.ForeColor = System.Drawing.Color.Red;
      this.PasswordValidationLbl.Location = new System.Drawing.Point(119, 283);
      this.PasswordValidationLbl.Name = "PasswordValidationLbl";
      this.PasswordValidationLbl.Size = new System.Drawing.Size(13, 16);
      this.PasswordValidationLbl.TabIndex = 76;
      this.PasswordValidationLbl.Text = "*";
      // 
      // UserLoginTbx
      // 
      this.UserLoginTbx.Location = new System.Drawing.Point(143, 246);
      this.UserLoginTbx.MaxLength = 50;
      this.UserLoginTbx.Name = "UserLoginTbx";
      this.UserLoginTbx.Size = new System.Drawing.Size(216, 22);
      this.UserLoginTbx.TabIndex = 68;
      // 
      // UsersGridView
      // 
      this.UsersGridView.AllowUserToAddRows = false;
      this.UsersGridView.AllowUserToDeleteRows = false;
      dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
      dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
      dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
      dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
      this.UsersGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
      this.UsersGridView.BackgroundColor = System.Drawing.SystemColors.Control;
      this.UsersGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.UsersGridView.Dock = System.Windows.Forms.DockStyle.Fill;
      this.UsersGridView.GridColor = System.Drawing.SystemColors.Control;
      this.UsersGridView.Location = new System.Drawing.Point(405, 0);
      this.UsersGridView.MultiSelect = false;
      this.UsersGridView.Name = "UsersGridView";
      this.UsersGridView.ReadOnly = true;
      this.UsersGridView.RowHeadersWidth = 20;
      dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.UsersGridView.RowsDefaultCellStyle = dataGridViewCellStyle2;
      this.UsersGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.UsersGridView.Size = new System.Drawing.Size(527, 744);
      this.UsersGridView.TabIndex = 78;
      this.UsersGridView.TabStop = false;
      this.UsersGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UsersGridView_CellClick);
      // 
      // UsersForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(932, 744);
      this.Controls.Add(this.UsersGridView);
      this.Controls.Add(this.panel1);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "UsersForm";
      this.Text = "Користувачі";
      this.panel1.ResumeLayout(false);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.UsersGridView)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.Label PasswordAndRePasswordDontMatchLbl;
    private System.Windows.Forms.Label FirstNameLbl;
    private System.Windows.Forms.Button AddBtn;
    private System.Windows.Forms.TextBox FirstNameTBox;
    private System.Windows.Forms.Button ExitBtn;
    private System.Windows.Forms.Label FirstNameValiadtionLbl;
    private System.Windows.Forms.Button ClearBtn;
    private System.Windows.Forms.Label LastNameValiadtionLbl;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox LastNameTBox;
    private System.Windows.Forms.Label UserLoginValidationLbl;
    private System.Windows.Forms.Label LastNameLbl;
    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.TextBox PasswordTbx;
    private System.Windows.Forms.TextBox DescriptionTbx;
    private System.Windows.Forms.Label RePasswordValidationLbl;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.ComboBox RolesCBox;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.TextBox RePasswordTbx;
    private System.Windows.Forms.Label PasswordValidationLbl;
    private System.Windows.Forms.TextBox UserLoginTbx;
    private System.Windows.Forms.DataGridView UsersGridView;
  }
}