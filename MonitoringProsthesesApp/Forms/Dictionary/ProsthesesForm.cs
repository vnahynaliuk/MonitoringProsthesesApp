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
  public partial class ProsthesesForm : Form {
    private int _selectedRowIndex = 0;
    private ValidationMy _validation = new ValidationMy();
    private TypesProsthesesProvider _TypesProsthesesProviderProvider = new TypesProsthesesProvider();
    private List<TypesProstheses> _TypesProsthesesList = new List<TypesProstheses>();
    private ProsthesesProvider _ServiceProvider = new ProsthesesProvider();
    private List<Prostheses> _ServiceList = new List<Prostheses>();

    public ProsthesesForm() {
      InitializeComponent();
      LoadAllDate();
      DataLoad();
    }

    private void LoadAllDate() {
      _TypesProsthesesList = _TypesProsthesesProviderProvider.GetAllTypesProstheses();
      TypesProsthesesCBox.DataSource = _TypesProsthesesList;
      TypesProsthesesCBox.ValueMember = "TypesProsthesesId";
      TypesProsthesesCBox.DisplayMember = "TypesProsthesesName";

    }

    private void AddBtn_Click(object sender, EventArgs e) {
      if (IsDataEnteringCorrect()) {
        _ServiceProvider.InsertProstheses(ProsthesesNameTBox.Text, ProducerTBox.Text, ModelTBox.Text, GraduationDateDTP.Value, MaterialTBox.Text,
          Convert.ToInt32(SizesTBox.Text), Convert.ToDouble(PriceTBox.Text), DescriptionTBox.Text, Convert.ToInt32(TypesProsthesesCBox.SelectedValue));
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
      if (ProsthesesGridView.FirstDisplayedScrollingRowIndex > 0) {
        firstRowIndex = ProsthesesGridView.FirstDisplayedScrollingRowIndex;
      }
      try {
        _ServiceList = _ServiceProvider.GetAllProstheses();
        LoadDataInProsthesesGridView(_ServiceList);
        if (_selectedRowIndex == ProsthesesGridView.Rows.Count) {
          _selectedRowIndex = ProsthesesGridView.Rows.Count - 1;
        }
        if (_selectedRowIndex >= 0) {
          ProsthesesGridView.FirstDisplayedScrollingRowIndex = firstRowIndex;
          ProsthesesGridView.Rows[_selectedRowIndex].Selected = true;
        }
      } catch { }
    }

    private void LoadDataInProsthesesGridView(List<Prostheses> ServiceList) {
      ProsthesesGridView.DataSource = null;
      ProsthesesGridView.Columns.Clear();
      ProsthesesGridView.AutoGenerateColumns = false;
      ProsthesesGridView.RowHeadersVisible = false;

      ProsthesesGridView.DataSource = ServiceList;

      if (ServiceList.Count > 0) {
        if (ServiceList[0].Message == NamesMy.NoDataNames.NoDataInProstheses) {
          DataGridViewColumn messageColumn = new DataGridViewTextBoxColumn();
          messageColumn.DataPropertyName = "Message";
          messageColumn.Width = ProsthesesGridView.Width - NamesMy.SizeOptins.MinusSizePanel;
          ProsthesesGridView.Columns.Add(messageColumn);
        } else {
          DataGridViewColumn ProsthesesIdColumn = new DataGridViewTextBoxColumn();
          ProsthesesIdColumn.DataPropertyName = "ProsthesesId";
          ProsthesesGridView.Columns.Add(ProsthesesIdColumn);
          ProsthesesGridView.Columns[0].Visible = false;

          DataGridViewColumn numberColumn = new DataGridViewTextBoxColumn();
          numberColumn.HeaderText = "№ ";
          numberColumn.DataPropertyName = "Number";
          numberColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
          numberColumn.Width = NamesMy.SizeOptins.NumberSize;
          ProsthesesGridView.Columns.Add(numberColumn);

          DataGridViewColumn ProsthesesNameColumn = new DataGridViewTextBoxColumn();
          ProsthesesNameColumn.HeaderText = "Назва протезу";
          ProsthesesNameColumn.DataPropertyName = "ProsthesesName";
          ProsthesesNameColumn.Width = 300;
          ProsthesesGridView.Columns.Add(ProsthesesNameColumn);

          DataGridViewColumn ProducerColumn = new DataGridViewTextBoxColumn();
          ProducerColumn.HeaderText = "Виробник";
          ProducerColumn.DataPropertyName = "Producer";
          ProducerColumn.Width = 140;
          ProsthesesGridView.Columns.Add(ProducerColumn);

          DataGridViewColumn ModelColumn = new DataGridViewTextBoxColumn();
          ModelColumn.HeaderText = "Модель";
          ModelColumn.DataPropertyName = "Model";
          ModelColumn.Width = 140;
          ProsthesesGridView.Columns.Add(ModelColumn);

          DataGridViewColumn GraduationDateColumn = new DataGridViewTextBoxColumn();
          GraduationDateColumn.HeaderText = "Даата випуску";
          GraduationDateColumn.DataPropertyName = "GraduationDate";
          GraduationDateColumn.Width = 130;
          GraduationDateColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
          ProsthesesGridView.Columns.Add(GraduationDateColumn);

          DataGridViewColumn SizesColumn = new DataGridViewTextBoxColumn();
          SizesColumn.HeaderText = "Розмір";
          SizesColumn.DataPropertyName = "Sizes";
          SizesColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
          SizesColumn.Width = NamesMy.SizeOptins.Price;
          ProsthesesGridView.Columns.Add(SizesColumn);

          DataGridViewColumn PriceColumn = new DataGridViewTextBoxColumn();
          PriceColumn.HeaderText = "Ціна";
          PriceColumn.DataPropertyName = "Price";
          PriceColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
          PriceColumn.Width = NamesMy.SizeOptins.Price;
          ProsthesesGridView.Columns.Add(PriceColumn);
        }
        for (int i = 0; i < ProsthesesGridView.Columns.Count; i++) {
          ProsthesesGridView.Columns[i].HeaderCell.Style.BackColor = Color.LightGray;
        }
      }
    }

    private void ClearAllControls() {
      ProsthesesNameTBox.Text = String.Empty;
      ProducerTBox.Text = String.Empty;
      ModelTBox.Text = String.Empty;
      GraduationDateDTP.Value = DateTime.Now;
      MaterialTBox.Text = String.Empty;
      SizesTBox.Text = "0";
      DescriptionTBox.Text = String.Empty;
      PriceTBox.Text = "0,0";
    }

    private bool IsDataEnteringCorrect() {
      bool isCorrect = true;
      if (_validation.IsDataEntering(ProsthesesNameTBox.Text)) {
        ProsthesesNameValiadtionLbl.Text = NamesMy.ProgramButtons.RequiredValidation;
      } else {
        ProsthesesNameValiadtionLbl.Text = NamesMy.ProgramButtons.ErrorValidation;
        isCorrect = false;
      }
      if (_validation.IsDataEntering(ProducerTBox.Text)) {
        ProducerValiadtionLbl.Text = NamesMy.ProgramButtons.RequiredValidation;
      } else {
        ProducerValiadtionLbl.Text = NamesMy.ProgramButtons.ErrorValidation;
        isCorrect = false;
      }
      if (_validation.IsDataEntering(ModelTBox.Text)) {
        ModelValiadtionLbl.Text = NamesMy.ProgramButtons.RequiredValidation;
      } else {
        ModelValiadtionLbl.Text = NamesMy.ProgramButtons.ErrorValidation;
        isCorrect = false;
      }
      if (_validation.IsDataEntering(MaterialTBox.Text)) {
        MaterialValiadtionLbl.Text = NamesMy.ProgramButtons.RequiredValidation;
      } else {
        MaterialValiadtionLbl.Text = NamesMy.ProgramButtons.ErrorValidation;
        isCorrect = false;
      }
      if (_validation.IsDataConvertToInt(SizesTBox.Text)) {
        SizesValiadtionLbl.Text = NamesMy.ProgramButtons.RequiredValidation;
      } else {
        SizesValiadtionLbl.Text = NamesMy.ProgramButtons.ErrorValidation;
        isCorrect = false;
      }
      if (_validation.IsDataConvertToDouble(PriceTBox.Text)) {
        PriceValiadtionLbl.Text = NamesMy.ProgramButtons.RequiredValidation;
      } else {
        PriceValiadtionLbl.Text = NamesMy.ProgramButtons.ErrorValidation;
        isCorrect = false;
      }
      if (Convert.ToInt32(TypesProsthesesCBox.SelectedValue) > 0) {
        TypesProsthesesValidationLbl.Text = NamesMy.ProgramButtons.RequiredValidation;
      } else {
        TypesProsthesesValidationLbl.Text = NamesMy.ProgramButtons.ErrorValidation;
        isCorrect = false;
      }
      return isCorrect;
    }

    private void ProsthesesGridView_CellClick(object sender, DataGridViewCellEventArgs e) {
      if (e.RowIndex >= 0 && ProsthesesGridView[0, e.RowIndex].Value.ToString() != _ServiceList[0].Message) {
        _selectedRowIndex = e.RowIndex;
        UpdateProsthesesForm updateServiceForm = new UpdateProsthesesForm(Convert.ToInt32(ProsthesesGridView[0, e.RowIndex].Value.ToString()));
        updateServiceForm.ShowDialog();
        DataLoad();
      }
    }
  }
}
