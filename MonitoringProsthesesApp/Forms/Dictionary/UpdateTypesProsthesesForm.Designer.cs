
namespace MonitoringProsthesesApp.Forms.Dictionary {
  partial class UpdateTypesProsthesesForm {
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
      this.ExitBtn = new System.Windows.Forms.Button();
      this.DeleteBtn = new System.Windows.Forms.Button();
      this.SaveBtn = new System.Windows.Forms.Button();
      this.TypesProsthesesNameValiadtionLbl = new System.Windows.Forms.Label();
      this.DescriptionTBox = new System.Windows.Forms.TextBox();
      this.TypesProsthesesNameTBox = new System.Windows.Forms.TextBox();
      this.DescriptionLbl = new System.Windows.Forms.Label();
      this.СomputerLbl = new System.Windows.Forms.Label();
      this.AddGBox.SuspendLayout();
      this.SuspendLayout();
      // 
      // AddGBox
      // 
      this.AddGBox.Controls.Add(this.ExitBtn);
      this.AddGBox.Controls.Add(this.DeleteBtn);
      this.AddGBox.Controls.Add(this.SaveBtn);
      this.AddGBox.Controls.Add(this.TypesProsthesesNameValiadtionLbl);
      this.AddGBox.Controls.Add(this.DescriptionTBox);
      this.AddGBox.Controls.Add(this.TypesProsthesesNameTBox);
      this.AddGBox.Controls.Add(this.DescriptionLbl);
      this.AddGBox.Controls.Add(this.СomputerLbl);
      this.AddGBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.AddGBox.Location = new System.Drawing.Point(12, 12);
      this.AddGBox.Name = "AddGBox";
      this.AddGBox.Size = new System.Drawing.Size(335, 280);
      this.AddGBox.TabIndex = 20;
      this.AddGBox.TabStop = false;
      // 
      // ExitBtn
      // 
      this.ExitBtn.Location = new System.Drawing.Point(237, 243);
      this.ExitBtn.Name = "ExitBtn";
      this.ExitBtn.Size = new System.Drawing.Size(91, 23);
      this.ExitBtn.TabIndex = 30;
      this.ExitBtn.Text = "Вихід";
      this.ExitBtn.UseVisualStyleBackColor = true;
      this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
      // 
      // DeleteBtn
      // 
      this.DeleteBtn.Location = new System.Drawing.Point(134, 243);
      this.DeleteBtn.Name = "DeleteBtn";
      this.DeleteBtn.Size = new System.Drawing.Size(91, 23);
      this.DeleteBtn.TabIndex = 29;
      this.DeleteBtn.Text = "Видалити";
      this.DeleteBtn.UseVisualStyleBackColor = true;
      this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
      // 
      // SaveBtn
      // 
      this.SaveBtn.Location = new System.Drawing.Point(32, 243);
      this.SaveBtn.Name = "SaveBtn";
      this.SaveBtn.Size = new System.Drawing.Size(91, 23);
      this.SaveBtn.TabIndex = 28;
      this.SaveBtn.Text = "Зберегти";
      this.SaveBtn.UseVisualStyleBackColor = true;
      this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
      // 
      // TypesProsthesesNameValiadtionLbl
      // 
      this.TypesProsthesesNameValiadtionLbl.AutoSize = true;
      this.TypesProsthesesNameValiadtionLbl.ForeColor = System.Drawing.Color.Red;
      this.TypesProsthesesNameValiadtionLbl.Location = new System.Drawing.Point(89, 22);
      this.TypesProsthesesNameValiadtionLbl.Name = "TypesProsthesesNameValiadtionLbl";
      this.TypesProsthesesNameValiadtionLbl.Size = new System.Drawing.Size(13, 16);
      this.TypesProsthesesNameValiadtionLbl.TabIndex = 23;
      this.TypesProsthesesNameValiadtionLbl.Text = "*";
      // 
      // DescriptionTBox
      // 
      this.DescriptionTBox.Location = new System.Drawing.Point(9, 97);
      this.DescriptionTBox.MaxLength = 1500;
      this.DescriptionTBox.Multiline = true;
      this.DescriptionTBox.Name = "DescriptionTBox";
      this.DescriptionTBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.DescriptionTBox.Size = new System.Drawing.Size(319, 128);
      this.DescriptionTBox.TabIndex = 2;
      // 
      // TypesProsthesesNameTBox
      // 
      this.TypesProsthesesNameTBox.Location = new System.Drawing.Point(6, 41);
      this.TypesProsthesesNameTBox.MaxLength = 250;
      this.TypesProsthesesNameTBox.Name = "TypesProsthesesNameTBox";
      this.TypesProsthesesNameTBox.Size = new System.Drawing.Size(323, 22);
      this.TypesProsthesesNameTBox.TabIndex = 1;
      // 
      // DescriptionLbl
      // 
      this.DescriptionLbl.AutoSize = true;
      this.DescriptionLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.DescriptionLbl.Location = new System.Drawing.Point(6, 78);
      this.DescriptionLbl.Name = "DescriptionLbl";
      this.DescriptionLbl.Size = new System.Drawing.Size(44, 16);
      this.DescriptionLbl.TabIndex = 1;
      this.DescriptionLbl.Text = "Опис:";
      // 
      // СomputerLbl
      // 
      this.СomputerLbl.AutoSize = true;
      this.СomputerLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.СomputerLbl.Location = new System.Drawing.Point(6, 22);
      this.СomputerLbl.Name = "СomputerLbl";
      this.СomputerLbl.Size = new System.Drawing.Size(53, 16);
      this.СomputerLbl.TabIndex = 0;
      this.СomputerLbl.Text = "Назва:";
      // 
      // UpdateTypesProsthesesForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(364, 309);
      this.Controls.Add(this.AddGBox);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "UpdateTypesProsthesesForm";
      this.ShowIcon = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Редагувати";
      this.AddGBox.ResumeLayout(false);
      this.AddGBox.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.GroupBox AddGBox;
    private System.Windows.Forms.Button ExitBtn;
    private System.Windows.Forms.Button DeleteBtn;
    private System.Windows.Forms.Button SaveBtn;
    private System.Windows.Forms.Label TypesProsthesesNameValiadtionLbl;
    private System.Windows.Forms.TextBox DescriptionTBox;
    private System.Windows.Forms.TextBox TypesProsthesesNameTBox;
    private System.Windows.Forms.Label DescriptionLbl;
    private System.Windows.Forms.Label СomputerLbl;
  }
}