
namespace MonitoringProsthesesApp.Forms.Raport {
  partial class ErorRaportForm {
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
      this.SearchBtn = new System.Windows.Forms.Button();
      this.ProsthesesValidationLbl = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.ProsthesesCBox = new System.Windows.Forms.ComboBox();
      this.groupBox2.SuspendLayout();
      this.SuspendLayout();
      // 
      // RaportTBox
      // 
      this.RaportTBox.Dock = System.Windows.Forms.DockStyle.Fill;
      this.RaportTBox.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.RaportTBox.Location = new System.Drawing.Point(0, 85);
      this.RaportTBox.Multiline = true;
      this.RaportTBox.Name = "RaportTBox";
      this.RaportTBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.RaportTBox.Size = new System.Drawing.Size(800, 365);
      this.RaportTBox.TabIndex = 108;
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.ProsthesesValidationLbl);
      this.groupBox2.Controls.Add(this.label5);
      this.groupBox2.Controls.Add(this.ProsthesesCBox);
      this.groupBox2.Controls.Add(this.SearchBtn);
      this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
      this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.groupBox2.Location = new System.Drawing.Point(0, 0);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(800, 85);
      this.groupBox2.TabIndex = 107;
      this.groupBox2.TabStop = false;
      // 
      // SearchBtn
      // 
      this.SearchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.SearchBtn.Location = new System.Drawing.Point(459, 21);
      this.SearchBtn.Name = "SearchBtn";
      this.SearchBtn.Size = new System.Drawing.Size(109, 30);
      this.SearchBtn.TabIndex = 102;
      this.SearchBtn.Text = "Формувати";
      this.SearchBtn.UseVisualStyleBackColor = true;
      this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
      // 
      // ProsthesesValidationLbl
      // 
      this.ProsthesesValidationLbl.AutoSize = true;
      this.ProsthesesValidationLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.ProsthesesValidationLbl.ForeColor = System.Drawing.Color.Red;
      this.ProsthesesValidationLbl.Location = new System.Drawing.Point(159, 28);
      this.ProsthesesValidationLbl.Name = "ProsthesesValidationLbl";
      this.ProsthesesValidationLbl.Size = new System.Drawing.Size(13, 16);
      this.ProsthesesValidationLbl.TabIndex = 123;
      this.ProsthesesValidationLbl.Text = "*";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label5.Location = new System.Drawing.Point(75, 28);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(60, 16);
      this.label5.TabIndex = 122;
      this.label5.Text = "Протез:";
      // 
      // ProsthesesCBox
      // 
      this.ProsthesesCBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.ProsthesesCBox.DropDownWidth = 400;
      this.ProsthesesCBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.ProsthesesCBox.FormattingEnabled = true;
      this.ProsthesesCBox.Location = new System.Drawing.Point(191, 25);
      this.ProsthesesCBox.Name = "ProsthesesCBox";
      this.ProsthesesCBox.Size = new System.Drawing.Size(262, 24);
      this.ProsthesesCBox.TabIndex = 121;
      // 
      // ErorRaportForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.RaportTBox);
      this.Controls.Add(this.groupBox2);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "ErorRaportForm";
      this.ShowIcon = false;
      this.Text = "Відмови протезів";
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox RaportTBox;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.Button SearchBtn;
    private System.Windows.Forms.Label ProsthesesValidationLbl;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.ComboBox ProsthesesCBox;
  }
}