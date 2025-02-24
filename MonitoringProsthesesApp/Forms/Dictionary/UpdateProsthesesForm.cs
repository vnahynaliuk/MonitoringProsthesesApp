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
  public partial class UpdateProsthesesForm : Form {
    private int _ProsthesesId = 0;
    private ValidationMy _validation = new ValidationMy();
    private ProsthesesProvider _ProsthesesProvider = new ProsthesesProvider();
    private Prostheses _selectedProstheses = new Prostheses();
    private TypesProsthesesProvider _TypesProsthesesProviderProvider = new TypesProsthesesProvider();
    private List<TypesProstheses> _TypesProsthesesList = new List<TypesProstheses>();

    public UpdateProsthesesForm(int ProsthesesId) {
      InitializeComponent();
      _ProsthesesId = ProsthesesId;
      LoadAllDate();
    }

    private void SaveBtn_Click(object sender, EventArgs e) {
      if (IsDataEnteringCorrect()) {
        _ProsthesesProvider.UpdateProstheses(ProsthesesNameTBox.Text, ProducerTBox.Text, ModelTBox.Text, GraduationDateDTP.Value, MaterialTBox.Text,
          Convert.ToInt32(SizesTBox.Text), Convert.ToDouble(PriceTBox.Text), DescriptionTBox.Text, Convert.ToInt32(TypesProsthesesCBox.SelectedValue), _ProsthesesId);
        this.Close();
      }
    }

    private void DeleteBtn_Click(object sender, EventArgs e) {
      if (MessageBox.Show("Ви дійсно хочете видалити цей елемент?", "Видалити", MessageBoxButtons.YesNo) == DialogResult.Yes) {
        _ProsthesesProvider.DeleteProsthesesByProsthesesId(_ProsthesesId);
        this.Close();
      }
    }

    private void ExitBtn_Click(object sender, EventArgs e) {
      this.Close();
    }

    private void LoadAllDate() {
      _TypesProsthesesList = _TypesProsthesesProviderProvider.GetAllTypesProstheses();
      TypesProsthesesCBox.DataSource = _TypesProsthesesList;
      TypesProsthesesCBox.ValueMember = "TypesProsthesesId";
      TypesProsthesesCBox.DisplayMember = "TypesProsthesesName";

      _selectedProstheses = _ProsthesesProvider.SelectedProsthesesByProsthesesId(_ProsthesesId);
      ProsthesesNameTBox.Text = _selectedProstheses.ProsthesesName;
      ProducerTBox.Text = _selectedProstheses.Producer;
      ModelTBox.Text = _selectedProstheses.Model;
      GraduationDateDTP.Value = _selectedProstheses.GraduationDate;
      MaterialTBox.Text = _selectedProstheses.Material;
      SizesTBox.Text = _selectedProstheses.Sizes.ToString();
      PriceTBox.Text = _selectedProstheses.Price.ToString();
      DescriptionTBox.Text = _selectedProstheses.Description;
      TypesProsthesesCBox.SelectedValue = _selectedProstheses.TypesProsthesesId;
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


  }
}
