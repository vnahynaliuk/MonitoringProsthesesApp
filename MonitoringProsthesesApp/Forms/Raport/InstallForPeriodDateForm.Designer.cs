
namespace MonitoringProsthesesApp.Forms.Raport {
  partial class InstallForPeriodDateForm {
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
      this.RaportTBox = new System.Windows.Forms.TextBox();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.label1 = new System.Windows.Forms.Label();
      this.EndDTP = new System.Windows.Forms.DateTimePicker();
      this.LastNameLbl = new System.Windows.Forms.Label();
      this.StartDTP = new System.Windows.Forms.DateTimePicker();
      this.SearchBtn = new System.Windows.Forms.Button();
      this.groupBox2.SuspendLayout();
      this.SuspendLayout();
      // 
      // RaportTBox
      // 
      this.RaportTBox.Dock = System.Windows.Forms.DockStyle.Fill;
      this.RaportTBox.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.RaportTBox.Location = new System.Drawing.Point(0, 121);
      this.RaportTBox.Multiline = true;
      this.RaportTBox.Name = "RaportTBox";
      this.RaportTBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.RaportTBox.Size = new System.Drawing.Size(1120, 433);
      this.RaportTBox.TabIndex = 108;
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.label1);
      this.groupBox2.Controls.Add(this.EndDTP);
      this.groupBox2.Controls.Add(this.LastNameLbl);
      this.groupBox2.Controls.Add(this.StartDTP);
      this.groupBox2.Controls.Add(this.SearchBtn);
      this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
      this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.groupBox2.Location = new System.Drawing.Point(0, 0);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(1120, 121);
      this.groupBox2.TabIndex = 107;
      this.groupBox2.TabStop = false;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label1.Location = new System.Drawing.Point(54, 63);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(123, 20);
      this.label1.TabIndex = 119;
      this.label1.Text = "Кінець періоду:";
      // 
      // EndDTP
      // 
      this.EndDTP.Location = new System.Drawing.Point(199, 58);
      this.EndDTP.Name = "EndDTP";
      this.EndDTP.Size = new System.Drawing.Size(191, 26);
      this.EndDTP.TabIndex = 118;
      // 
      // LastNameLbl
      // 
      this.LastNameLbl.AutoSize = true;
      this.LastNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.LastNameLbl.Location = new System.Drawing.Point(54, 30);
      this.LastNameLbl.Name = "LastNameLbl";
      this.LastNameLbl.Size = new System.Drawing.Size(139, 20);
      this.LastNameLbl.TabIndex = 117;
      this.LastNameLbl.Text = "Початок періоду:";
      // 
      // StartDTP
      // 
      this.StartDTP.Location = new System.Drawing.Point(199, 25);
      this.StartDTP.Name = "StartDTP";
      this.StartDTP.Size = new System.Drawing.Size(191, 26);
      this.StartDTP.TabIndex = 116;
      // 
      // SearchBtn
      // 
      this.SearchBtn.Location = new System.Drawing.Point(405, 58);
      this.SearchBtn.Name = "SearchBtn";
      this.SearchBtn.Size = new System.Drawing.Size(109, 30);
      this.SearchBtn.TabIndex = 102;
      this.SearchBtn.Text = "Формувати";
      this.SearchBtn.UseVisualStyleBackColor = true;
      this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
      // 
      // InstallForPeriodDateForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1120, 554);
      this.Controls.Add(this.RaportTBox);
      this.Controls.Add(this.groupBox2);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "InstallForPeriodDateForm";
      this.ShowIcon = false;
      this.Text = "Встановлі протези за період часу";
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox RaportTBox;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.DateTimePicker EndDTP;
    private System.Windows.Forms.Label LastNameLbl;
    private System.Windows.Forms.DateTimePicker StartDTP;
    private System.Windows.Forms.Button SearchBtn;
  }
}