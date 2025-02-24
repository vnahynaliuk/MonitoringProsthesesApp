
namespace MonitoringProsthesesApp.Forms.Raport {
  partial class TypesProsthesesRaportForm {
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
      this.TypesProsthesesValidationLbl = new System.Windows.Forms.Label();
      this.label10 = new System.Windows.Forms.Label();
      this.TypesProsthesesCBox = new System.Windows.Forms.ComboBox();
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
      this.RaportTBox.Size = new System.Drawing.Size(970, 443);
      this.RaportTBox.TabIndex = 106;
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.TypesProsthesesValidationLbl);
      this.groupBox2.Controls.Add(this.label10);
      this.groupBox2.Controls.Add(this.TypesProsthesesCBox);
      this.groupBox2.Controls.Add(this.SearchBtn);
      this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
      this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.groupBox2.Location = new System.Drawing.Point(0, 0);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(970, 85);
      this.groupBox2.TabIndex = 105;
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
      // TypesProsthesesValidationLbl
      // 
      this.TypesProsthesesValidationLbl.AutoSize = true;
      this.TypesProsthesesValidationLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.TypesProsthesesValidationLbl.ForeColor = System.Drawing.Color.Red;
      this.TypesProsthesesValidationLbl.Location = new System.Drawing.Point(130, 28);
      this.TypesProsthesesValidationLbl.Name = "TypesProsthesesValidationLbl";
      this.TypesProsthesesValidationLbl.Size = new System.Drawing.Size(13, 16);
      this.TypesProsthesesValidationLbl.TabIndex = 126;
      this.TypesProsthesesValidationLbl.Text = "*";
      // 
      // label10
      // 
      this.label10.AutoSize = true;
      this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label10.Location = new System.Drawing.Point(21, 28);
      this.label10.Name = "label10";
      this.label10.Size = new System.Drawing.Size(94, 16);
      this.label10.TabIndex = 125;
      this.label10.Text = "Тип протезу:";
      // 
      // TypesProsthesesCBox
      // 
      this.TypesProsthesesCBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.TypesProsthesesCBox.DropDownWidth = 400;
      this.TypesProsthesesCBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.TypesProsthesesCBox.FormattingEnabled = true;
      this.TypesProsthesesCBox.Location = new System.Drawing.Point(159, 25);
      this.TypesProsthesesCBox.Name = "TypesProsthesesCBox";
      this.TypesProsthesesCBox.Size = new System.Drawing.Size(284, 24);
      this.TypesProsthesesCBox.TabIndex = 124;
      // 
      // TypesProsthesesRaportForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(970, 528);
      this.Controls.Add(this.RaportTBox);
      this.Controls.Add(this.groupBox2);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "TypesProsthesesRaportForm";
      this.ShowIcon = false;
      this.Text = "По типу протезу";
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox RaportTBox;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.Button SearchBtn;
    private System.Windows.Forms.Label TypesProsthesesValidationLbl;
    private System.Windows.Forms.Label label10;
    private System.Windows.Forms.ComboBox TypesProsthesesCBox;
  }
}