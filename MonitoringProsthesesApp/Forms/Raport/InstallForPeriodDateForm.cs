using MonitoringProsthesesApp.BLL;
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
  public partial class InstallForPeriodDateForm : Form {
    RapBLL _RaportBLL = new RapBLL();
    List<InstallationProstheses> _InstallationProsthesesList = new List<InstallationProstheses>();

    public InstallForPeriodDateForm() {
      InitializeComponent();
    }

    private void SearchBtn_Click(object sender, EventArgs e) {
      DateTime start = new DateTime(StartDTP.Value.Year, StartDTP.Value.Month, StartDTP.Value.Day, 0, 0, 0);
      DateTime end = new DateTime(EndDTP.Value.Year, EndDTP.Value.Month, EndDTP.Value.Day, 23, 59, 59);
      _InstallationProsthesesList = _RaportBLL.GetInstallationForPeriodDate(start, end);
      GetRaport(_InstallationProsthesesList);
    }

    public void GetRaport(List<InstallationProstheses> InstallationProsthesesList) {
      double allPrice = 0;
      if (InstallationProsthesesList.Count > 0) {
        RaportTBox.Text = "Звіт за вибраний перід з " + StartDTP.Value.ToShortDateString() + " до " + EndDTP.Value.ToShortDateString() + ":\r\n";
        RaportTBox.Text += "--------------------------------------------\r\n";

        RaportTBox.Text += String.Format("{0,3}|{1, -30}|{2, -30}|{3, -15}|\r\n", "№", "Назва протезу", "Пацієнт", "Ціна");
        for (int i = 0; i < InstallationProsthesesList.Count(); i++) {
          string raportString = String.Format("{0,3}|{1, -30}|{2, -30}|{3, 15}|\r\n",
          InstallationProsthesesList[i].Number,
          InstallationProsthesesList[i].ProsthesesName,
          InstallationProsthesesList[i].PatientsFIO,
          InstallationProsthesesList[i].Price);
          RaportTBox.Text += raportString;
          allPrice += InstallationProsthesesList[i].Price;
        }
        RaportTBox.Text += String.Format("{0,65} {1, 15}\r\n", "Загальна сума: ", allPrice);
      } else {
        RaportTBox.Text = "За вибраний період даних не знайдено!";
      }
    }
  }
}
