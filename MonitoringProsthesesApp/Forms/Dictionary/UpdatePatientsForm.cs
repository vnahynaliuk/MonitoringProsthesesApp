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
  public partial class UpdatePatientsForm : Form {
    private int _PatientsId = 0;
    private Patients _selectedPatients = new Patients();
    private PatientsProvider _PatientsProvider = new PatientsProvider();
    private ValidationMy _validation = new ValidationMy();

    public UpdatePatientsForm(int PatientsId) {
      InitializeComponent();
      _PatientsId = PatientsId;
      LoadAllDate();
    }

    private void SaveBtn_Click(object sender, EventArgs e) {
      if (IsDataEnteringCorrect()) {
        _PatientsProvider.UpdatePatients(LastNameTBox.Text, FirstNameTBox.Text, PhoneTBox.Text, AddressTBox.Text, EmailTBox.Text, _PatientsId);
        this.Close();
      }
    }

    private void DeleteBtn_Click(object sender, EventArgs e) {
      if (MessageBox.Show("Ви дійсно хочете видалити цей елемент?", "Видалити", MessageBoxButtons.YesNo) == DialogResult.Yes) {
        _PatientsProvider.DeletePatientsByPatientsId(_PatientsId);
        this.Close();
      }
    }

    private void ExitBtn_Click(object sender, EventArgs e) {
      this.Close();
    }

    private void LoadAllDate() {
      _selectedPatients = _PatientsProvider.SelectedPatientsByPatientsId(_PatientsId);
      LastNameTBox.Text = _selectedPatients.LastName;
      FirstNameTBox.Text = _selectedPatients.FirstName;
      PhoneTBox.Text = _selectedPatients.Phone;
      AddressTBox.Text = _selectedPatients.Address;
      EmailTBox.Text = _selectedPatients.Email;
    }

    private bool IsDataEnteringCorrect() {
      bool isCorrect = true;
      if (_validation.IsDataEntering(LastNameTBox.Text)) {
        LastNameValiadtionLbl.Text = NamesMy.ProgramButtons.RequiredValidation;
      } else {
        LastNameValiadtionLbl.Text = NamesMy.ProgramButtons.ErrorValidation;
        isCorrect = false;
      }
      if (_validation.IsDataEntering(FirstNameTBox.Text)) {
        FirstNameValiadtionLbl.Text = NamesMy.ProgramButtons.RequiredValidation;
      } else {
        FirstNameValiadtionLbl.Text = NamesMy.ProgramButtons.ErrorValidation;
        isCorrect = false;
      }
      if (_validation.IsDataEntering(PhoneTBox.Text)) {
        PhoneValiadtionLbl.Text = NamesMy.ProgramButtons.RequiredValidation;
      } else {
        PhoneValiadtionLbl.Text = NamesMy.ProgramButtons.ErrorValidation;
        isCorrect = false;
      }
      return isCorrect;
    }

  }
}
