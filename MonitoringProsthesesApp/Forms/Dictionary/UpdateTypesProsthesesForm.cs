using MonitoringProsthesesApp.AppCode;
using MonitoringProsthesesApp.Providers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonitoringProsthesesApp.Forms.Dictionary {
  public partial class UpdateTypesProsthesesForm : Form {
    private int _TypesProsthesesId = 0;
    private TypesProstheses _selectedTypesProstheses = new TypesProstheses();
    private TypesProsthesesProvider _TypesProsthesesProvider = new TypesProsthesesProvider();
    private ValidationMy _Validation = new ValidationMy();

    public UpdateTypesProsthesesForm(int TypesProsthesesId) {
      InitializeComponent();
      _TypesProsthesesId = TypesProsthesesId;
      LoadAllDate();
    }

    private void SaveBtn_Click(object sender, EventArgs e) {
      if (IsDataEnteringCorrect()) {
        _TypesProsthesesProvider.UpdateTypesProstheses(TypesProsthesesNameTBox.Text, DescriptionTBox.Text, _TypesProsthesesId);
        this.Close();
      }
    }

    private void DeleteBtn_Click(object sender, EventArgs e) {
      if (MessageBox.Show("Ви дійсно хочете видалити цей елемент?", "Видалити", MessageBoxButtons.YesNo) == DialogResult.Yes) {
        _TypesProsthesesProvider.DeleteTypesProsthesesByTypesProsthesesId(_TypesProsthesesId);
        this.Close();
      }
    }

    private void ExitBtn_Click(object sender, EventArgs e) {
      this.Close();
    }

    private void LoadAllDate() {
      _selectedTypesProstheses = _TypesProsthesesProvider.SelectedTypesProsthesesByTypesProsthesesId(_TypesProsthesesId);
      TypesProsthesesNameTBox.Text = _selectedTypesProstheses.TypesProsthesesName;
      DescriptionTBox.Text = _selectedTypesProstheses.Description;
    }

    private bool IsDataEnteringCorrect() {
      bool isCorrect = true;
      if (_Validation.IsDataEntering(TypesProsthesesNameTBox.Text)) {
        TypesProsthesesNameValiadtionLbl.Text = NamesMy.ProgramButtons.RequiredValidation;
      } else {
        TypesProsthesesNameValiadtionLbl.Text = NamesMy.ProgramButtons.ErrorValidation;
        isCorrect = false;
      }
      return isCorrect;
    }


  }
}
