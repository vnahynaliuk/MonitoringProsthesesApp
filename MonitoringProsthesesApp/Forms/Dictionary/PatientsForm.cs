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
  public partial class PatientsForm : Form {
    private int _selectedRowIndex = 0;
    private ValidationMy _validation = new ValidationMy();
    PatientsProvider _PatientsProvider = new PatientsProvider();
    List<Patients> _PatientsList = new List<Patients>();

    public PatientsForm() {
      InitializeComponent();
      DataLoad();
    }

    private void AddBtn_Click(object sender, EventArgs e) {
      if (IsDataEnteringCorrect()) {
        _PatientsProvider.InsertPatients(LastNameTBox.Text, FirstNameTBox.Text, PhoneTBox.Text, AddressTBox.Text, EmailTBox.Text);
        DataLoad();
        ClearAllControls();
      }
    }

    private void ClearBtn_Click(object sender, EventArgs e) {
      ClearAllControls();
    }

    private void ExitBtn_Click(object sender, EventArgs e) {
      this.Close();
    }

    private void DataLoad() {
      int firstRowIndex = 0;
      if (PatientsGridView.FirstDisplayedScrollingRowIndex > 0) {
        firstRowIndex = PatientsGridView.FirstDisplayedScrollingRowIndex;
      }
      try {
        _PatientsList = _PatientsProvider.GetAllPatients();
        LoadDataInPatientsGridView(_PatientsList);
        if (_selectedRowIndex == PatientsGridView.Rows.Count) {
          _selectedRowIndex = PatientsGridView.Rows.Count - 1;
        }
        if (_selectedRowIndex >= 0) {
          PatientsGridView.FirstDisplayedScrollingRowIndex = firstRowIndex;
          PatientsGridView.Rows[_selectedRowIndex].Selected = true;
        }
      } catch { }
    }

    private void LoadDataInPatientsGridView(List<Patients> PatientsList) {
      PatientsGridView.DataSource = null;
      PatientsGridView.Columns.Clear();
      PatientsGridView.AutoGenerateColumns = false;
      PatientsGridView.RowHeadersVisible = false;

      PatientsGridView.DataSource = PatientsList;

      if (PatientsList.Count > 0) {
        if (PatientsList[0].Message == NamesMy.NoDataNames.NoDataInPatients) {
          DataGridViewColumn messageColumn = new DataGridViewTextBoxColumn();
          messageColumn.DataPropertyName = "Message";
          messageColumn.Width = PatientsGridView.Width - NamesMy.SizeOptins.MinusSizePanel;
          PatientsGridView.Columns.Add(messageColumn);
        } else {
          DataGridViewColumn DetailIdColumn = new DataGridViewTextBoxColumn();
          DetailIdColumn.DataPropertyName = "PatientsId";
          PatientsGridView.Columns.Add(DetailIdColumn);
          PatientsGridView.Columns[0].Visible = false;

          DataGridViewColumn numberColumn = new DataGridViewTextBoxColumn();
          numberColumn.HeaderText = "№ ";
          numberColumn.DataPropertyName = "Number";
          numberColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
          numberColumn.Width = NamesMy.SizeOptins.NumberSize;
          PatientsGridView.Columns.Add(numberColumn);

          DataGridViewColumn LastNameColumn = new DataGridViewTextBoxColumn();
          LastNameColumn.HeaderText = "Прізвище";
          LastNameColumn.DataPropertyName = "LastName";
          LastNameColumn.Width = 200;
          PatientsGridView.Columns.Add(LastNameColumn);

          DataGridViewColumn FirstNameColumn = new DataGridViewTextBoxColumn();
          FirstNameColumn.HeaderText = "Ім'я";
          FirstNameColumn.DataPropertyName = "FirstName";
          FirstNameColumn.Width = 200;
          PatientsGridView.Columns.Add(FirstNameColumn);

          DataGridViewColumn PhoneColumn = new DataGridViewTextBoxColumn();
          PhoneColumn.HeaderText = "№ телефону";
          PhoneColumn.DataPropertyName = "Phone";
          PhoneColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
          PhoneColumn.Width = 150;
          PatientsGridView.Columns.Add(PhoneColumn);

        }
        for (int i = 0; i < PatientsGridView.Columns.Count; i++) {
          PatientsGridView.Columns[i].HeaderCell.Style.BackColor = Color.LightGray;
        }
      }
    }

    private void ClearAllControls() {
      LastNameTBox.Text = String.Empty;
      FirstNameTBox.Text = String.Empty;
      PhoneTBox.Text = String.Empty;
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

    private void PatientsGridView_CellClick(object sender, DataGridViewCellEventArgs e) {
      if (e.RowIndex >= 0 && PatientsGridView[0, e.RowIndex].Value.ToString() != _PatientsList[0].Message) {
        _selectedRowIndex = e.RowIndex;
        UpdatePatientsForm updatePatientsForm = new UpdatePatientsForm(Convert.ToInt32(PatientsGridView[0, e.RowIndex].Value.ToString()));
        updatePatientsForm.ShowDialog();
        DataLoad();
      }
    }
  }
}
