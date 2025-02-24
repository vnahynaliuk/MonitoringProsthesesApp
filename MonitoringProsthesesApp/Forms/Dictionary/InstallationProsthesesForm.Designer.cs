
namespace MonitoringProsthesesApp.Forms.Dictionary {
  partial class InstallationProsthesesForm {
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
      this.DescriptionTBox = new System.Windows.Forms.TextBox();
      this.DescriptionValiadtionLbl = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.PriceValidationLbl = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.PriceTBox = new System.Windows.Forms.TextBox();
      this.ProsthesesValidationLbl = new System.Windows.Forms.Label();
      this.PatientsValidationLbl = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.LastNameLbl = new System.Windows.Forms.Label();
      this.InstallationDateDTP = new System.Windows.Forms.DateTimePicker();
      this.label5 = new System.Windows.Forms.Label();
      this.AddPanel = new System.Windows.Forms.Panel();
      this.AddGBox = new System.Windows.Forms.GroupBox();
      this.ProsthesesCBox = new System.Windows.Forms.ComboBox();
      this.PatientsCBox = new System.Windows.Forms.ComboBox();
      this.ExitBtn = new System.Windows.Forms.Button();
      this.ClearBtn = new System.Windows.Forms.Button();
      this.AddBtn = new System.Windows.Forms.Button();
      this.InstallationProsthesesGridView = new System.Windows.Forms.DataGridView();
      this.AddPanel.SuspendLayout();
      this.AddGBox.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.InstallationProsthesesGridView)).BeginInit();
      this.SuspendLayout();
      // 
      // DescriptionTBox
      // 
      this.DescriptionTBox.Location = new System.Drawing.Point(9, 160);
      this.DescriptionTBox.MaxLength = 200;
      this.DescriptionTBox.Multiline = true;
      this.DescriptionTBox.Name = "DescriptionTBox";
      this.DescriptionTBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.DescriptionTBox.Size = new System.Drawing.Size(386, 241);
      this.DescriptionTBox.TabIndex = 125;
      // 
      // DescriptionValiadtionLbl
      // 
      this.DescriptionValiadtionLbl.AutoSize = true;
      this.DescriptionValiadtionLbl.ForeColor = System.Drawing.Color.Red;
      this.DescriptionValiadtionLbl.Location = new System.Drawing.Point(56, 141);
      this.DescriptionValiadtionLbl.Name = "DescriptionValiadtionLbl";
      this.DescriptionValiadtionLbl.Size = new System.Drawing.Size(13, 16);
      this.DescriptionValiadtionLbl.TabIndex = 127;
      this.DescriptionValiadtionLbl.Text = "*";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label4.Location = new System.Drawing.Point(6, 141);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(44, 16);
      this.label4.TabIndex = 126;
      this.label4.Text = "Опис:";
      // 
      // PriceValidationLbl
      // 
      this.PriceValidationLbl.AutoSize = true;
      this.PriceValidationLbl.ForeColor = System.Drawing.Color.Red;
      this.PriceValidationLbl.Location = new System.Drawing.Point(114, 77);
      this.PriceValidationLbl.Name = "PriceValidationLbl";
      this.PriceValidationLbl.Size = new System.Drawing.Size(13, 16);
      this.PriceValidationLbl.TabIndex = 123;
      this.PriceValidationLbl.Text = "*";
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label6.Location = new System.Drawing.Point(6, 77);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(39, 16);
      this.label6.TabIndex = 122;
      this.label6.Text = "Ціна:";
      // 
      // PriceTBox
      // 
      this.PriceTBox.Location = new System.Drawing.Point(133, 76);
      this.PriceTBox.MaxLength = 10;
      this.PriceTBox.Name = "PriceTBox";
      this.PriceTBox.Size = new System.Drawing.Size(116, 22);
      this.PriceTBox.TabIndex = 121;
      this.PriceTBox.Text = "0";
      this.PriceTBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // ProsthesesValidationLbl
      // 
      this.ProsthesesValidationLbl.AutoSize = true;
      this.ProsthesesValidationLbl.ForeColor = System.Drawing.Color.Red;
      this.ProsthesesValidationLbl.Location = new System.Drawing.Point(114, 49);
      this.ProsthesesValidationLbl.Name = "ProsthesesValidationLbl";
      this.ProsthesesValidationLbl.Size = new System.Drawing.Size(13, 16);
      this.ProsthesesValidationLbl.TabIndex = 120;
      this.ProsthesesValidationLbl.Text = "*";
      // 
      // PatientsValidationLbl
      // 
      this.PatientsValidationLbl.AutoSize = true;
      this.PatientsValidationLbl.ForeColor = System.Drawing.Color.Red;
      this.PatientsValidationLbl.Location = new System.Drawing.Point(114, 19);
      this.PatientsValidationLbl.Name = "PatientsValidationLbl";
      this.PatientsValidationLbl.Size = new System.Drawing.Size(13, 16);
      this.PatientsValidationLbl.TabIndex = 119;
      this.PatientsValidationLbl.Text = "*";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label2.Location = new System.Drawing.Point(6, 17);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(63, 16);
      this.label2.TabIndex = 103;
      this.label2.Text = "Пацієнт:";
      // 
      // LastNameLbl
      // 
      this.LastNameLbl.AutoSize = true;
      this.LastNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.LastNameLbl.Location = new System.Drawing.Point(9, 107);
      this.LastNameLbl.Name = "LastNameLbl";
      this.LastNameLbl.Size = new System.Drawing.Size(139, 16);
      this.LastNameLbl.TabIndex = 115;
      this.LastNameLbl.Text = "Дата встановлення:";
      // 
      // InstallationDateDTP
      // 
      this.InstallationDateDTP.Location = new System.Drawing.Point(150, 104);
      this.InstallationDateDTP.Name = "InstallationDateDTP";
      this.InstallationDateDTP.Size = new System.Drawing.Size(162, 22);
      this.InstallationDateDTP.TabIndex = 114;
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label5.Location = new System.Drawing.Point(6, 47);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(60, 16);
      this.label5.TabIndex = 109;
      this.label5.Text = "Протез:";
      // 
      // AddPanel
      // 
      this.AddPanel.Controls.Add(this.AddGBox);
      this.AddPanel.Dock = System.Windows.Forms.DockStyle.Left;
      this.AddPanel.Location = new System.Drawing.Point(0, 0);
      this.AddPanel.Name = "AddPanel";
      this.AddPanel.Size = new System.Drawing.Size(437, 562);
      this.AddPanel.TabIndex = 136;
      // 
      // AddGBox
      // 
      this.AddGBox.Controls.Add(this.DescriptionTBox);
      this.AddGBox.Controls.Add(this.DescriptionValiadtionLbl);
      this.AddGBox.Controls.Add(this.label4);
      this.AddGBox.Controls.Add(this.PriceValidationLbl);
      this.AddGBox.Controls.Add(this.label6);
      this.AddGBox.Controls.Add(this.PriceTBox);
      this.AddGBox.Controls.Add(this.ProsthesesValidationLbl);
      this.AddGBox.Controls.Add(this.PatientsValidationLbl);
      this.AddGBox.Controls.Add(this.label2);
      this.AddGBox.Controls.Add(this.LastNameLbl);
      this.AddGBox.Controls.Add(this.InstallationDateDTP);
      this.AddGBox.Controls.Add(this.label5);
      this.AddGBox.Controls.Add(this.ProsthesesCBox);
      this.AddGBox.Controls.Add(this.PatientsCBox);
      this.AddGBox.Controls.Add(this.ExitBtn);
      this.AddGBox.Controls.Add(this.ClearBtn);
      this.AddGBox.Controls.Add(this.AddBtn);
      this.AddGBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.AddGBox.Location = new System.Drawing.Point(12, 12);
      this.AddGBox.Name = "AddGBox";
      this.AddGBox.Size = new System.Drawing.Size(419, 455);
      this.AddGBox.TabIndex = 0;
      this.AddGBox.TabStop = false;
      // 
      // ProsthesesCBox
      // 
      this.ProsthesesCBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.ProsthesesCBox.DropDownWidth = 400;
      this.ProsthesesCBox.FormattingEnabled = true;
      this.ProsthesesCBox.Location = new System.Drawing.Point(133, 46);
      this.ProsthesesCBox.Name = "ProsthesesCBox";
      this.ProsthesesCBox.Size = new System.Drawing.Size(262, 24);
      this.ProsthesesCBox.TabIndex = 108;
      // 
      // PatientsCBox
      // 
      this.PatientsCBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.PatientsCBox.DropDownWidth = 400;
      this.PatientsCBox.FormattingEnabled = true;
      this.PatientsCBox.Location = new System.Drawing.Point(133, 16);
      this.PatientsCBox.Name = "PatientsCBox";
      this.PatientsCBox.Size = new System.Drawing.Size(262, 24);
      this.PatientsCBox.TabIndex = 105;
      // 
      // ExitBtn
      // 
      this.ExitBtn.Location = new System.Drawing.Point(314, 417);
      this.ExitBtn.Name = "ExitBtn";
      this.ExitBtn.Size = new System.Drawing.Size(81, 23);
      this.ExitBtn.TabIndex = 5;
      this.ExitBtn.Text = "Вихід";
      this.ExitBtn.UseVisualStyleBackColor = true;
      this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
      // 
      // ClearBtn
      // 
      this.ClearBtn.Location = new System.Drawing.Point(212, 417);
      this.ClearBtn.Name = "ClearBtn";
      this.ClearBtn.Size = new System.Drawing.Size(81, 23);
      this.ClearBtn.TabIndex = 4;
      this.ClearBtn.Text = "Очистити";
      this.ClearBtn.UseVisualStyleBackColor = true;
      this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
      // 
      // AddBtn
      // 
      this.AddBtn.Location = new System.Drawing.Point(110, 417);
      this.AddBtn.Name = "AddBtn";
      this.AddBtn.Size = new System.Drawing.Size(81, 23);
      this.AddBtn.TabIndex = 3;
      this.AddBtn.Text = "Додати";
      this.AddBtn.UseVisualStyleBackColor = true;
      this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
      // 
      // InstallationProsthesesGridView
      // 
      this.InstallationProsthesesGridView.AllowUserToAddRows = false;
      this.InstallationProsthesesGridView.AllowUserToDeleteRows = false;
      dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
      dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
      dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
      dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
      this.InstallationProsthesesGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
      this.InstallationProsthesesGridView.BackgroundColor = System.Drawing.SystemColors.Control;
      this.InstallationProsthesesGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.InstallationProsthesesGridView.ColumnHeadersHeight = 29;
      this.InstallationProsthesesGridView.Dock = System.Windows.Forms.DockStyle.Fill;
      this.InstallationProsthesesGridView.GridColor = System.Drawing.SystemColors.Control;
      this.InstallationProsthesesGridView.Location = new System.Drawing.Point(437, 0);
      this.InstallationProsthesesGridView.MultiSelect = false;
      this.InstallationProsthesesGridView.Name = "InstallationProsthesesGridView";
      this.InstallationProsthesesGridView.ReadOnly = true;
      this.InstallationProsthesesGridView.RowHeadersWidth = 20;
      dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.InstallationProsthesesGridView.RowsDefaultCellStyle = dataGridViewCellStyle2;
      this.InstallationProsthesesGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.InstallationProsthesesGridView.Size = new System.Drawing.Size(651, 562);
      this.InstallationProsthesesGridView.TabIndex = 137;
      this.InstallationProsthesesGridView.TabStop = false;
      this.InstallationProsthesesGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.InstallationProsthesesGridView_CellClick);
      // 
      // InstallationProsthesesForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1088, 562);
      this.Controls.Add(this.InstallationProsthesesGridView);
      this.Controls.Add(this.AddPanel);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "InstallationProsthesesForm";
      this.ShowIcon = false;
      this.Text = "Встановлення протезів пацієнтам";
      this.AddPanel.ResumeLayout(false);
      this.AddGBox.ResumeLayout(false);
      this.AddGBox.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.InstallationProsthesesGridView)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion
    private System.Windows.Forms.TextBox DescriptionTBox;
    private System.Windows.Forms.Label DescriptionValiadtionLbl;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label PriceValidationLbl;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.TextBox PriceTBox;
    private System.Windows.Forms.Label ProsthesesValidationLbl;
    private System.Windows.Forms.Label PatientsValidationLbl;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label LastNameLbl;
    private System.Windows.Forms.DateTimePicker InstallationDateDTP;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Panel AddPanel;
    private System.Windows.Forms.GroupBox AddGBox;
    private System.Windows.Forms.ComboBox ProsthesesCBox;
    private System.Windows.Forms.ComboBox PatientsCBox;
    private System.Windows.Forms.Button ExitBtn;
    private System.Windows.Forms.Button ClearBtn;
    private System.Windows.Forms.Button AddBtn;
    private System.Windows.Forms.DataGridView InstallationProsthesesGridView;
  }
}