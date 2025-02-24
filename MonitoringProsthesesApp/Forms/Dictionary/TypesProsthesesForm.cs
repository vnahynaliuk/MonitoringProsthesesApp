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
  public partial class TypesProsthesesForm : Form {
    private int _selectedRowIndex = 0;
    private ValidationMy _validation = new ValidationMy();
    private TypesProsthesesProvider _TypesProsthesesProvider = new TypesProsthesesProvider();
    private List<TypesProstheses> _TypesProsthesesList = new List<TypesProstheses>();

    public TypesProsthesesForm() {
      InitializeComponent();
      DataLoad();
    }

    private void AddBtn_Click(object sender, EventArgs e) {
      if (IsDataEnteringCorrect()) {
        _TypesProsthesesProvider.InsertTypesProstheses(TypesProsthesesNameTBox.Text, DescriptionTBox.Text);
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
      if (TypesProsthesesGridView.FirstDisplayedScrollingRowIndex > 0) {
        firstRowIndex = TypesProsthesesGridView.FirstDisplayedScrollingRowIndex;
      }
      try {
        _TypesProsthesesList = _TypesProsthesesProvider.GetAllTypesProstheses();
        LoadDataInTypesProsthesesGridView(_TypesProsthesesList);
        if (_selectedRowIndex == TypesProsthesesGridView.Rows.Count) {
          _selectedRowIndex = TypesProsthesesGridView.Rows.Count - 1;
        }
        if (_selectedRowIndex >= 0) {
          TypesProsthesesGridView.FirstDisplayedScrollingRowIndex = firstRowIndex;
          TypesProsthesesGridView.Rows[_selectedRowIndex].Selected = true;
        }
      } catch { }
    }

    private void LoadDataInTypesProsthesesGridView(List<TypesProstheses> TypesProsthesesList) {
      TypesProsthesesGridView.DataSource = null;
      TypesProsthesesGridView.Columns.Clear();
      TypesProsthesesGridView.AutoGenerateColumns = false;
      TypesProsthesesGridView.RowHeadersVisible = false;

      TypesProsthesesGridView.DataSource = TypesProsthesesList;

      if (TypesProsthesesList.Count > 0) {
        if (TypesProsthesesList[0].Message == NamesMy.NoDataNames.NoDataInTypesProstheses) {
          DataGridViewColumn messageColumn = new DataGridViewTextBoxColumn();
          messageColumn.DataPropertyName = "Message";
          messageColumn.Width = TypesProsthesesGridView.Width - NamesMy.SizeOptins.MinusSizePanel;
          TypesProsthesesGridView.Columns.Add(messageColumn);
        } else {
          DataGridViewColumn DetailIdColumn = new DataGridViewTextBoxColumn();
          DetailIdColumn.DataPropertyName = "TypesProsthesesId";
          TypesProsthesesGridView.Columns.Add(DetailIdColumn);
          TypesProsthesesGridView.Columns[0].Visible = false;

          DataGridViewColumn numberColumn = new DataGridViewTextBoxColumn();
          numberColumn.HeaderText = "№ ";
          numberColumn.DataPropertyName = "Number";
          numberColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
          numberColumn.Width = NamesMy.SizeOptins.NumberSize;
          TypesProsthesesGridView.Columns.Add(numberColumn);

          DataGridViewColumn TypesProsthesesNameColumn = new DataGridViewTextBoxColumn();
          TypesProsthesesNameColumn.HeaderText = "Категорії";
          TypesProsthesesNameColumn.DataPropertyName = "TypesProsthesesName";
          TypesProsthesesNameColumn.Width = NamesMy.SizeOptins.NameSize;
          TypesProsthesesGridView.Columns.Add(TypesProsthesesNameColumn);


        }
        for (int i = 0; i < TypesProsthesesGridView.Columns.Count; i++) {
          TypesProsthesesGridView.Columns[i].HeaderCell.Style.BackColor = Color.LightGray;
        }
      }
    }

    private void ClearAllControls() {
      TypesProsthesesNameTBox.Text = String.Empty;
      DescriptionTBox.Text = String.Empty;
    }

    private bool IsDataEnteringCorrect() {
      bool isCorrect = true;
      if (_validation.IsDataEntering(TypesProsthesesNameTBox.Text)) {
        TypesProsthesesNameValiadtionLbl.Text = NamesMy.ProgramButtons.RequiredValidation;
      } else {
        TypesProsthesesNameValiadtionLbl.Text = NamesMy.ProgramButtons.ErrorValidation;
        isCorrect = false;
      }
      return isCorrect;
    }

    private void TypesProsthesesGridView_CellClick(object sender, DataGridViewCellEventArgs e) {
      if (e.RowIndex >= 0 && TypesProsthesesGridView[0, e.RowIndex].Value.ToString() != _TypesProsthesesList[0].Message) {
        _selectedRowIndex = e.RowIndex;
        UpdateTypesProsthesesForm updateTypesProsthesesForm = new UpdateTypesProsthesesForm(Convert.ToInt32(TypesProsthesesGridView[0, e.RowIndex].Value.ToString()));
        updateTypesProsthesesForm.ShowDialog();
        DataLoad();
      }
    }
  }
}
