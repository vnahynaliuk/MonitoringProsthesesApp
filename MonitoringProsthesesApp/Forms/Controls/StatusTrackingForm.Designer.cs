
namespace MonitoringProsthesesApp.Forms.Controls {
  partial class StatusTrackingForm {
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
      this.AddGBox = new System.Windows.Forms.GroupBox();
      this.MonitoringDateValidationLbl = new System.Windows.Forms.Label();
      this.ProsthesesValidationLbl = new System.Windows.Forms.Label();
      this.PatientsValidationLbl = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.LastNameLbl = new System.Windows.Forms.Label();
      this.MonitoringDateDTP = new System.Windows.Forms.DateTimePicker();
      this.label5 = new System.Windows.Forms.Label();
      this.ProsthesesCBox = new System.Windows.Forms.ComboBox();
      this.PatientsCBox = new System.Windows.Forms.ComboBox();
      this.TrackBtn = new System.Windows.Forms.Button();
      this.panel1 = new System.Windows.Forms.Panel();
      this.GraphicsCC = new LiveCharts.WinForms.CartesianChart();
      this.AddGBox.SuspendLayout();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // AddGBox
      // 
      this.AddGBox.Controls.Add(this.MonitoringDateValidationLbl);
      this.AddGBox.Controls.Add(this.ProsthesesValidationLbl);
      this.AddGBox.Controls.Add(this.PatientsValidationLbl);
      this.AddGBox.Controls.Add(this.label2);
      this.AddGBox.Controls.Add(this.LastNameLbl);
      this.AddGBox.Controls.Add(this.MonitoringDateDTP);
      this.AddGBox.Controls.Add(this.label5);
      this.AddGBox.Controls.Add(this.ProsthesesCBox);
      this.AddGBox.Controls.Add(this.PatientsCBox);
      this.AddGBox.Controls.Add(this.TrackBtn);
      this.AddGBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.AddGBox.Location = new System.Drawing.Point(12, 12);
      this.AddGBox.Name = "AddGBox";
      this.AddGBox.Size = new System.Drawing.Size(410, 158);
      this.AddGBox.TabIndex = 1;
      this.AddGBox.TabStop = false;
      // 
      // MonitoringDateValidationLbl
      // 
      this.MonitoringDateValidationLbl.AutoSize = true;
      this.MonitoringDateValidationLbl.ForeColor = System.Drawing.Color.Red;
      this.MonitoringDateValidationLbl.Location = new System.Drawing.Point(114, 81);
      this.MonitoringDateValidationLbl.Name = "MonitoringDateValidationLbl";
      this.MonitoringDateValidationLbl.Size = new System.Drawing.Size(13, 16);
      this.MonitoringDateValidationLbl.TabIndex = 121;
      this.MonitoringDateValidationLbl.Text = "*";
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
      this.LastNameLbl.Location = new System.Drawing.Point(7, 81);
      this.LastNameLbl.Name = "LastNameLbl";
      this.LastNameLbl.Size = new System.Drawing.Size(43, 16);
      this.LastNameLbl.TabIndex = 115;
      this.LastNameLbl.Text = "Дата:";
      // 
      // MonitoringDateDTP
      // 
      this.MonitoringDateDTP.Location = new System.Drawing.Point(133, 76);
      this.MonitoringDateDTP.Name = "MonitoringDateDTP";
      this.MonitoringDateDTP.Size = new System.Drawing.Size(162, 22);
      this.MonitoringDateDTP.TabIndex = 114;
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
      // TrackBtn
      // 
      this.TrackBtn.Location = new System.Drawing.Point(286, 117);
      this.TrackBtn.Name = "TrackBtn";
      this.TrackBtn.Size = new System.Drawing.Size(109, 23);
      this.TrackBtn.TabIndex = 3;
      this.TrackBtn.Text = "Відстежити";
      this.TrackBtn.UseVisualStyleBackColor = true;
      this.TrackBtn.Click += new System.EventHandler(this.TrackBtn_Click);
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.AddGBox);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
      this.panel1.Location = new System.Drawing.Point(0, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(431, 414);
      this.panel1.TabIndex = 2;
      // 
      // GraphicsCC
      // 
      this.GraphicsCC.Dock = System.Windows.Forms.DockStyle.Fill;
      this.GraphicsCC.Location = new System.Drawing.Point(431, 0);
      this.GraphicsCC.Name = "GraphicsCC";
      this.GraphicsCC.Size = new System.Drawing.Size(763, 414);
      this.GraphicsCC.TabIndex = 3;
      this.GraphicsCC.Text = "cartesianChart1";
      // 
      // StatusTrackingForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1194, 414);
      this.Controls.Add(this.GraphicsCC);
      this.Controls.Add(this.panel1);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "StatusTrackingForm";
      this.ShowIcon = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Відстежування  стану протезу";
      this.AddGBox.ResumeLayout(false);
      this.AddGBox.PerformLayout();
      this.panel1.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.GroupBox AddGBox;
    private System.Windows.Forms.Label ProsthesesValidationLbl;
    private System.Windows.Forms.Label PatientsValidationLbl;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label LastNameLbl;
    private System.Windows.Forms.DateTimePicker MonitoringDateDTP;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.ComboBox ProsthesesCBox;
    private System.Windows.Forms.ComboBox PatientsCBox;
    private System.Windows.Forms.Button TrackBtn;
    private System.Windows.Forms.Panel panel1;
    private LiveCharts.WinForms.CartesianChart GraphicsCC;
    private System.Windows.Forms.Label MonitoringDateValidationLbl;
  }
}