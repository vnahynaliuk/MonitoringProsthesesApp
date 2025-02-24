using MonitoringProsthesesApp.AppCode;
using MonitoringProsthesesApp.BLL;
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

namespace MonitoringProsthesesApp.Forms.Raport {
  public partial class TypesProsthesesRaportForm : Form {
    RapBLL _RaportBLL = new RapBLL();
    List<Prostheses> _ProsthesesList = new List<Prostheses>();
    private TypesProsthesesProvider _TypesProsthesesProviderProvider = new TypesProsthesesProvider();
    private List<TypesProstheses> _TypesProsthesesList = new List<TypesProstheses>();

    public TypesProsthesesRaportForm() {
      InitializeComponent();
      LoadAllDate();
    }

    private void LoadAllDate() {
      _TypesProsthesesList = _TypesProsthesesProviderProvider.GetAllTypesProstheses();
      TypesProsthesesCBox.DataSource = _TypesProsthesesList;
      TypesProsthesesCBox.ValueMember = "TypesProsthesesId";
      TypesProsthesesCBox.DisplayMember = "TypesProsthesesName";

    }

    private void SearchBtn_Click(object sender, EventArgs e) {
      if (IsDataEnteringCorrect()) {
        _ProsthesesList = _RaportBLL.GetAllProsthesesByTypesProsthesesId(Convert.ToInt32(TypesProsthesesCBox.SelectedValue));
        GetRaport(_ProsthesesList);
      }
    }

    private bool IsDataEnteringCorrect() {
      bool isCorrect = true;
      if (Convert.ToInt32(TypesProsthesesCBox.SelectedValue) > 0) {
        TypesProsthesesValidationLbl.Text = NamesMy.ProgramButtons.RequiredValidation;
      } else {
        TypesProsthesesValidationLbl.Text = NamesMy.ProgramButtons.ErrorValidation;
        isCorrect = false;
      }
      return isCorrect;
    }

    public void GetRaport(List<Prostheses> ProsthesesList) {
      if (ProsthesesList.Count > 0) {
        RaportTBox.Text = "Звіт по вибраному типу протезу: " + TypesProsthesesCBox.Text + ":\r\n";
        RaportTBox.Text += "--------------------------------------------\r\n";

        RaportTBox.Text += String.Format("{0,3}|{1, -40}|{2, -20}|{3, -15}|{4, -15}|\r\n", "№", "Назва протезу", "Виробкик", "Дата випуску", "Ціна");
        for (int i = 0; i < ProsthesesList.Count(); i++) {
          string raportString = String.Format("{0,3}|{1, -40}|{2, -20}|{3, -15}|{4, 15}|\r\n",
          ProsthesesList[i].Number,
          ProsthesesList[i].ProsthesesName,
          ProsthesesList[i].Producer,
          ProsthesesList[i].GraduationDate.ToShortDateString(),
          ProsthesesList[i].Price);
          RaportTBox.Text += raportString;
        }
      } else {
        RaportTBox.Text = "По вибраному типу протезу даних не знайдено!";
      }
    }


  }
}
