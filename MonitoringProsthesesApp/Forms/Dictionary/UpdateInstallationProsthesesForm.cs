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
  public partial class UpdateInstallationProsthesesForm : Form {
    private int _InstallationProsthesesId = 0;
    private InstallationProstheses _selectedInstallationProstheses = new InstallationProstheses();
    private InstallationProsthesesProvider _InstallationProsthesesProvider = new InstallationProsthesesProvider();
    private ValidationMy _Validation = new ValidationMy();
    private PatientsProvider _PatientsProvider = new PatientsProvider();
    private List<Patients> _PatientsList = new List<Patients>();
    private ProsthesesProvider _ProsthesesProvider = new ProsthesesProvider();
    private List<Prostheses> _ProsthesesList = new List<Prostheses>();

    public UpdateInstallationProsthesesForm(int InstallationProsthesesId) {
      InitializeComponent();
      _InstallationProsthesesId = InstallationProsthesesId;
      LoadAllDate();
    }

    private void SaveBtn_Click(object sender, EventArgs e) {
      if (IsDataEnteringCorrect()) {
        _InstallationProsthesesProvider.UpdateInstallationProstheses(Convert.ToInt32(PatientsCBox.SelectedValue), Convert.ToInt32(ProsthesesCBox.SelectedValue),
          InstallationDateDTP.Value, Convert.ToDouble(PriceTBox.Text), DescriptionTBox.Text, _InstallationProsthesesId);
        this.Close();
      }
    }

    private void DeleteBtn_Click(object sender, EventArgs e) {
      if (MessageBox.Show("Ви дійсно хочете видалити цей елемент?", "Видалити", MessageBoxButtons.YesNo)
== DialogResult.Yes) {
        _InstallationProsthesesProvider.DeleteInstallationProsthesesByInstallationProsthesesId(_InstallationProsthesesId);
        this.Close();
      }
    }

    private void ExitBtn_Click(object sender, EventArgs e) {
      this.Close();
    }

    private void LoadAllDate() {
      _PatientsList = _PatientsProvider.GetAllPatients();
      PatientsCBox.DataSource = _PatientsList;
      PatientsCBox.ValueMember = "PatientsId";
      PatientsCBox.DisplayMember = "FIO";

      _ProsthesesList = _ProsthesesProvider.GetAllProstheses();
      ProsthesesCBox.DataSource = _ProsthesesList;
      ProsthesesCBox.ValueMember = "ProsthesesId";
      ProsthesesCBox.DisplayMember = "ProsthesesName";

      _selectedInstallationProstheses = _InstallationProsthesesProvider.SelectedInstallationProsthesesByInstallationProsthesesId(_InstallationProsthesesId);
      PatientsCBox.SelectedValue = _selectedInstallationProstheses.PatientsId;
      ProsthesesCBox.SelectedValue = _selectedInstallationProstheses.ProsthesesId;
      InstallationDateDTP.Value = _selectedInstallationProstheses.InstallationDate;
      PriceTBox.Text = _selectedInstallationProstheses.Price.ToString();
      DescriptionTBox.Text = _selectedInstallationProstheses.Description;
    }

    private bool IsDataEnteringCorrect() {
      bool isCorrect = true;
      if (Convert.ToInt32(PatientsCBox.SelectedValue) > 0) {
        PatientsValidationLbl.Text = NamesMy.ProgramButtons.RequiredValidation;
      } else {
        PatientsValidationLbl.Text = NamesMy.ProgramButtons.ErrorValidation;
        isCorrect = false;
      }
      if (Convert.ToInt32(ProsthesesCBox.SelectedValue) > 0) {
        ProsthesesValidationLbl.Text = NamesMy.ProgramButtons.RequiredValidation;
      } else {
        ProsthesesValidationLbl.Text = NamesMy.ProgramButtons.ErrorValidation;
        isCorrect = false;
      }
      if (_Validation.IsDataConvertToDouble(PriceTBox.Text)) {
        PriceValidationLbl.Text = NamesMy.ProgramButtons.RequiredValidation;
      } else {
        PriceValidationLbl.Text = NamesMy.ProgramButtons.ErrorValidation;
        isCorrect = false;
      }
      if (_Validation.IsDataConvertToDouble(PriceTBox.Text)) {
        PriceValidationLbl.Text = NamesMy.ProgramButtons.RequiredValidation;
      } else {
        PriceValidationLbl.Text = NamesMy.ProgramButtons.ErrorValidation;
        isCorrect = false;
      }
      return isCorrect;
    }
  }
}
