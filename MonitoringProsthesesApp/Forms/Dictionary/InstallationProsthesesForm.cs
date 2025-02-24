using MonitoringProsthesesApp.AppCode;
using MonitoringProsthesesApp.Forms.Systems;
using MonitoringProsthesesApp.Provider;
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
  public partial class InstallationProsthesesForm : Form {
    private int _selectedRowIndex = 0;
    private ValidationMy _Validation = new ValidationMy();
    private InstallationProsthesesProvider _InstallationProsthesesProvider = new InstallationProsthesesProvider();
    private List<InstallationProstheses> _InstallationProsthesesList = new List<InstallationProstheses>();
    private PatientsProvider _PatientsProvider = new PatientsProvider();
    private List<Patients> _PatientsList = new List<Patients>();
    private ProsthesesProvider _ProsthesesProvider = new ProsthesesProvider();
    private List<Prostheses> _ProsthesesList = new List<Prostheses>();
    private LogsProvider _LogsProvider = new LogsProvider();


    public InstallationProsthesesForm() {
      InitializeComponent();
      LoadAllDate();
      DataLoad();
    }

    private void AddBtn_Click(object sender, EventArgs e) {
      if (IsDataEnteringCorrect()) {
        _InstallationProsthesesProvider.InsertInstallationProstheses(Convert.ToInt32(PatientsCBox.SelectedValue), Convert.ToInt32(ProsthesesCBox.SelectedValue),
          InstallationDateDTP.Value, Convert.ToDouble(PriceTBox.Text), DescriptionTBox.Text);
        _LogsProvider.InsertLogs(LoginForm.CurrentUser.UsersId, "Встановлено протез " + ProsthesesCBox.Text + " пацієнту " + PatientsCBox.Text, DateTime.Now);
        DataLoad();
        LoadAllDate();
        ClearAllControls();
      }
    }

    private void ClearBtn_Click(object sender, EventArgs e) {
      ClearAllControls();
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

      InstallationDateDTP.Value = DateTime.Now;
    }

    private void DataLoad() {
      int firstRowIndex = 0;
      if (InstallationProsthesesGridView.FirstDisplayedScrollingRowIndex > 0) {
        firstRowIndex = InstallationProsthesesGridView.FirstDisplayedScrollingRowIndex;
      }
      try {
        _InstallationProsthesesList = _InstallationProsthesesProvider.GetAllInstallationProstheses();
        LoadDataInGridView(_InstallationProsthesesList);
        if (_selectedRowIndex == InstallationProsthesesGridView.Rows.Count) {
          _selectedRowIndex = InstallationProsthesesGridView.Rows.Count - 1;
        }
        if (_selectedRowIndex >= 0) {
          InstallationProsthesesGridView.FirstDisplayedScrollingRowIndex = firstRowIndex;
          InstallationProsthesesGridView.Rows[_selectedRowIndex].Selected = true;
        }
      } catch { }
    }

    private void LoadDataInGridView(List<InstallationProstheses> InstallationProsthesesList) {
      InstallationProsthesesGridView.DataSource = null;
      InstallationProsthesesGridView.Columns.Clear();
      InstallationProsthesesGridView.AutoGenerateColumns = false;
      InstallationProsthesesGridView.RowHeadersVisible = false;

      InstallationProsthesesGridView.DataSource = InstallationProsthesesList;

      if (InstallationProsthesesList.Count > 0) {
        if (InstallationProsthesesList[0].Message == NamesMy.NoDataNames.NoDataInInstallationProstheses) {
          DataGridViewColumn messageColumn = new DataGridViewTextBoxColumn();
          messageColumn.DataPropertyName = "Message";
          messageColumn.Width = InstallationProsthesesGridView.Width - NamesMy.SizeOptins.MinusSizePanel;
          InstallationProsthesesGridView.Columns.Add(messageColumn);
        } else {
          DataGridViewColumn InstallationProsthesesIdColumn = new DataGridViewTextBoxColumn();
          InstallationProsthesesIdColumn.DataPropertyName = "InstallationProsthesesId";
          InstallationProsthesesGridView.Columns.Add(InstallationProsthesesIdColumn);
          InstallationProsthesesGridView.Columns[0].Visible = false;

          DataGridViewColumn numberColumn = new DataGridViewTextBoxColumn();
          numberColumn.HeaderText = "№ ";
          numberColumn.DataPropertyName = "Number";
          numberColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
          numberColumn.Width = NamesMy.SizeOptins.NumberSize;
          InstallationProsthesesGridView.Columns.Add(numberColumn);

          DataGridViewColumn StartDateColumn = new DataGridViewTextBoxColumn();
          StartDateColumn.HeaderText = "Дата встановлення";
          StartDateColumn.DataPropertyName = "InstallationDate";
          StartDateColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
          StartDateColumn.Width = NamesMy.SizeOptins.Date;
          InstallationProsthesesGridView.Columns.Add(StartDateColumn);

          DataGridViewColumn PatientsFIOColumn = new DataGridViewTextBoxColumn();
          PatientsFIOColumn.HeaderText = "Пацієнт";
          PatientsFIOColumn.DataPropertyName = "PatientsFIO";
          PatientsFIOColumn.Width = 180;
          InstallationProsthesesGridView.Columns.Add(PatientsFIOColumn);

          DataGridViewColumn ProsthesesNameColumn = new DataGridViewTextBoxColumn();
          ProsthesesNameColumn.HeaderText = "Протез";
          ProsthesesNameColumn.DataPropertyName = "ProsthesesName";
          ProsthesesNameColumn.Width = 220;
          InstallationProsthesesGridView.Columns.Add(ProsthesesNameColumn);

          DataGridViewColumn PriceColumn = new DataGridViewTextBoxColumn();
          PriceColumn.HeaderText = "Ціна";
          PriceColumn.DataPropertyName = "Price";
          PriceColumn.Width = 60;
          PriceColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
          InstallationProsthesesGridView.Columns.Add(PriceColumn);
        }
        for (int i = 0; i < InstallationProsthesesGridView.Columns.Count; i++) {
          InstallationProsthesesGridView.Columns[i].HeaderCell.Style.BackColor = Color.LightGray;
        }
      }
    }

    private void ClearAllControls() {
      ProsthesesCBox.SelectedItem = 1;
      InstallationDateDTP.Value = DateTime.Now;

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

    private void InstallationProsthesesGridView_CellClick(object sender, DataGridViewCellEventArgs e) {
      if (e.RowIndex >= 0 && InstallationProsthesesGridView[0, e.RowIndex].Value.ToString() != _InstallationProsthesesList[0].Message) {
        _selectedRowIndex = e.RowIndex;
        UpdateInstallationProsthesesForm updateCategoryForm = new UpdateInstallationProsthesesForm(Convert.ToInt32(InstallationProsthesesGridView[0, e.RowIndex].Value.ToString()));
        updateCategoryForm.ShowDialog();
        DataLoad();
        LoadAllDate();
      }
    }
  }
}
