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
  public partial class ErorRaportForm : Form {
    RapBLL _RaportBLL = new RapBLL();
    List<ErorStatistics> _ErorStatisticsList = new List<ErorStatistics>();
    private ProsthesesProvider _ProsthesesProviderProvider = new ProsthesesProvider();
    private List<Prostheses> _ProsthesesList = new List<Prostheses>();

    public ErorRaportForm() {
      InitializeComponent();
      LoadAllDate();
    }

    private void LoadAllDate() {
      _ProsthesesList = _ProsthesesProviderProvider.GetAllProstheses();
      ProsthesesCBox.DataSource = _ProsthesesList;
      ProsthesesCBox.ValueMember = "ProsthesesId";
      ProsthesesCBox.DisplayMember = "ProsthesesName";
    }

    private void SearchBtn_Click(object sender, EventArgs e) {
      if (IsDataEnteringCorrect()) {
        _ErorStatisticsList = _RaportBLL.GetErorStatisticsByProsthesesId(Convert.ToInt32(ProsthesesCBox.SelectedValue));
        GetRaport(_ErorStatisticsList);
      }
    }

    private bool IsDataEnteringCorrect() {
      bool isCorrect = true;
      if (Convert.ToInt32(ProsthesesCBox.SelectedValue) > 0) {
        ProsthesesValidationLbl.Text = NamesMy.ProgramButtons.RequiredValidation;
      } else {
        ProsthesesValidationLbl.Text = NamesMy.ProgramButtons.ErrorValidation;
        isCorrect = false;
      }
      return isCorrect;
    }

    public void GetRaport(List<ErorStatistics> ErorStatisticsList) {
      if (ErorStatisticsList.Count > 0) {
        RaportTBox.Text = "Звіт по вибраному протезу: " + ProsthesesCBox.Text + ":\r\n";
        RaportTBox.Text += "------------------------------------------------------------------------------------------------------------------------------------\r\n";
        RaportTBox.Text += String.Format("{0,3}|{1, -80}|{2, -15}|{3, -30}|\r\n", "№", "Помилка", "Дата", "Пацієнт");
        for (int i = 0; i < ErorStatisticsList.Count(); i++) {
          string raportString = String.Format("{0,3}|{1, -80}|{2, 15}|{3, -30}|\r\n",
          ErorStatisticsList[i].Number,
          ErorStatisticsList[i].Description,
          ErorStatisticsList[i].ErorDate.ToShortDateString(),
          ErorStatisticsList[i].PatientsFIO);
          RaportTBox.Text += raportString;
        }
        RaportTBox.Text += "------------------------------------------------------------------------------------------------------------------------------------\r\n";
      } else {
        RaportTBox.Text = "По вибраному протезу даних не знайдено!";
      }
    }

  }
}
