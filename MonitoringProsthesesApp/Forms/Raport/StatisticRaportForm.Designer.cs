
namespace MonitoringProsthesesApp.Forms.Raport {
  partial class StatisticRaportForm {
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
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.label1 = new System.Windows.Forms.Label();
      this.EndDTP = new System.Windows.Forms.DateTimePicker();
      this.LastNameLbl = new System.Windows.Forms.Label();
      this.StartDTP = new System.Windows.Forms.DateTimePicker();
      this.SearchBtn = new System.Windows.Forms.Button();
      this.GraphicsCC = new LiveCharts.WinForms.CartesianChart();
      this.ProsthesesValidationLbl = new System.Windows.Forms.Label();
      this.PatientsValidationLbl = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.ProsthesesCBox = new System.Windows.Forms.ComboBox();
      this.PatientsCBox = new System.Windows.Forms.ComboBox();
      this.groupBox2.SuspendLayout();
      this.SuspendLayout();
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.ProsthesesValidationLbl);
      this.groupBox2.Controls.Add(this.PatientsValidationLbl);
      this.groupBox2.Controls.Add(this.label2);
      this.groupBox2.Controls.Add(this.label5);
      this.groupBox2.Controls.Add(this.ProsthesesCBox);
      this.groupBox2.Controls.Add(this.PatientsCBox);
      this.groupBox2.Controls.Add(this.label1);
      this.groupBox2.Controls.Add(this.EndDTP);
      this.groupBox2.Controls.Add(this.LastNameLbl);
      this.groupBox2.Controls.Add(this.StartDTP);
      this.groupBox2.Controls.Add(this.SearchBtn);
      this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
      this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.groupBox2.Location = new System.Drawing.Point(0, 0);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(1222, 121);
      this.groupBox2.TabIndex = 109;
      this.groupBox2.TabStop = false;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label1.Location = new System.Drawing.Point(449, 59);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(123, 20);
      this.label1.TabIndex = 119;
      this.label1.Text = "Кінець періоду:";
      // 
      // EndDTP
      // 
      this.EndDTP.Location = new System.Drawing.Point(594, 57);
      this.EndDTP.Name = "EndDTP";
      this.EndDTP.Size = new System.Drawing.Size(191, 22);
      this.EndDTP.TabIndex = 118;
      // 
      // LastNameLbl
      // 
      this.LastNameLbl.AutoSize = true;
      this.LastNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.LastNameLbl.Location = new System.Drawing.Point(449, 24);
      this.LastNameLbl.Name = "LastNameLbl";
      this.LastNameLbl.Size = new System.Drawing.Size(139, 20);
      this.LastNameLbl.TabIndex = 117;
      this.LastNameLbl.Text = "Початок періоду:";
      // 
      // StartDTP
      // 
      this.StartDTP.Location = new System.Drawing.Point(594, 24);
      this.StartDTP.Name = "StartDTP";
      this.StartDTP.Size = new System.Drawing.Size(191, 22);
      this.StartDTP.TabIndex = 116;
      // 
      // SearchBtn
      // 
      this.SearchBtn.Location = new System.Drawing.Point(806, 55);
      this.SearchBtn.Name = "SearchBtn";
      this.SearchBtn.Size = new System.Drawing.Size(109, 30);
      this.SearchBtn.TabIndex = 102;
      this.SearchBtn.Text = "Формувати";
      this.SearchBtn.UseVisualStyleBackColor = true;
      this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
      // 
      // GraphicsCC
      // 
      this.GraphicsCC.Dock = System.Windows.Forms.DockStyle.Fill;
      this.GraphicsCC.Location = new System.Drawing.Point(0, 121);
      this.GraphicsCC.Name = "GraphicsCC";
      this.GraphicsCC.Size = new System.Drawing.Size(1222, 552);
      this.GraphicsCC.TabIndex = 110;
      this.GraphicsCC.Text = "cartesianChart1";
      // 
      // ProsthesesValidationLbl
      // 
      this.ProsthesesValidationLbl.AutoSize = true;
      this.ProsthesesValidationLbl.ForeColor = System.Drawing.Color.Red;
      this.ProsthesesValidationLbl.Location = new System.Drawing.Point(129, 57);
      this.ProsthesesValidationLbl.Name = "ProsthesesValidationLbl";
      this.ProsthesesValidationLbl.Size = new System.Drawing.Size(13, 16);
      this.ProsthesesValidationLbl.TabIndex = 126;
      this.ProsthesesValidationLbl.Text = "*";
      // 
      // PatientsValidationLbl
      // 
      this.PatientsValidationLbl.AutoSize = true;
      this.PatientsValidationLbl.ForeColor = System.Drawing.Color.Red;
      this.PatientsValidationLbl.Location = new System.Drawing.Point(129, 27);
      this.PatientsValidationLbl.Name = "PatientsValidationLbl";
      this.PatientsValidationLbl.Size = new System.Drawing.Size(13, 16);
      this.PatientsValidationLbl.TabIndex = 125;
      this.PatientsValidationLbl.Text = "*";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label2.Location = new System.Drawing.Point(21, 25);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(63, 16);
      this.label2.TabIndex = 121;
      this.label2.Text = "Пацієнт:";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label5.Location = new System.Drawing.Point(21, 55);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(60, 16);
      this.label5.TabIndex = 124;
      this.label5.Text = "Протез:";
      // 
      // ProsthesesCBox
      // 
      this.ProsthesesCBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.ProsthesesCBox.DropDownWidth = 400;
      this.ProsthesesCBox.FormattingEnabled = true;
      this.ProsthesesCBox.Location = new System.Drawing.Point(148, 54);
      this.ProsthesesCBox.Name = "ProsthesesCBox";
      this.ProsthesesCBox.Size = new System.Drawing.Size(262, 24);
      this.ProsthesesCBox.TabIndex = 123;
      // 
      // PatientsCBox
      // 
      this.PatientsCBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.PatientsCBox.DropDownWidth = 400;
      this.PatientsCBox.FormattingEnabled = true;
      this.PatientsCBox.Location = new System.Drawing.Point(148, 24);
      this.PatientsCBox.Name = "PatientsCBox";
      this.PatientsCBox.Size = new System.Drawing.Size(262, 24);
      this.PatientsCBox.TabIndex = 122;
      // 
      // StatisticRaportForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1222, 673);
      this.Controls.Add(this.GraphicsCC);
      this.Controls.Add(this.groupBox2);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "StatisticRaportForm";
      this.ShowIcon = false;
      this.Text = "Динаміка протезу пацієнта";
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.DateTimePicker EndDTP;
    private System.Windows.Forms.Label LastNameLbl;
    private System.Windows.Forms.DateTimePicker StartDTP;
    private System.Windows.Forms.Button SearchBtn;
    private LiveCharts.WinForms.CartesianChart GraphicsCC;
    private System.Windows.Forms.Label ProsthesesValidationLbl;
    private System.Windows.Forms.Label PatientsValidationLbl;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.ComboBox ProsthesesCBox;
    private System.Windows.Forms.ComboBox PatientsCBox;
  }
}