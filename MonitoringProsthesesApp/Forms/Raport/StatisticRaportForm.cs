using LiveCharts;
using LiveCharts.Wpf;
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
  public partial class StatisticRaportForm : Form {
    RapBLL _RaportBLL = new RapBLL();
    private List<StatisticsProstheses> _StatisticsProsthesesList = new List<StatisticsProstheses>();
    private PatientsProvider _PatientsProvider = new PatientsProvider();
    private List<Patients> _PatientsList = new List<Patients>();
    private ProsthesesProvider _ProsthesesProvider = new ProsthesesProvider();
    private List<Prostheses> _ProsthesesList = new List<Prostheses>();

    public StatisticRaportForm() {
      InitializeComponent();
      LoadAllDate();
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
    }

    private void SearchBtn_Click(object sender, EventArgs e) {
      if (IsDataEnteringCorrect()) {
        DateTime start = new DateTime(StartDTP.Value.Year, StartDTP.Value.Month, StartDTP.Value.Day, 0, 0, 0);
        DateTime end = new DateTime(EndDTP.Value.Year, EndDTP.Value.Month, EndDTP.Value.Day, 23, 59, 59);
        _StatisticsProsthesesList = _RaportBLL.GetRaportForPeriodDate(Convert.ToInt32(PatientsCBox.SelectedValue),
          Convert.ToInt32(ProsthesesCBox.SelectedValue), start, end);
        if (_StatisticsProsthesesList.Count == 0) {
          MessageBox.Show("За вибраними параметрами даних немає!", "Увага!");
        } else {
          BildGraphics(_StatisticsProsthesesList);
        }
      }
    }


    private void BildGraphics(List<StatisticsProstheses> StatisticsProsthesesList) {
      GraphicsCC.AxisX.Clear();

      SeriesCollection series = new SeriesCollection();
      ChartValues<double> bendingValue = new ChartValues<double>();
      ChartValues<double> rotatingValue = new ChartValues<double>();
      ChartValues<double> compressingValue = new ChartValues<double>();
      List<string> dates = new List<string>();
      for (int i = 0; i < StatisticsProsthesesList.Count; i++) {
        bendingValue.Add(StatisticsProsthesesList[i].Bending);
        rotatingValue.Add(StatisticsProsthesesList[i].Rotating);
        compressingValue.Add(StatisticsProsthesesList[i].Compressing);
        dates.Add(StatisticsProsthesesList[i].MonitoringDate.ToShortTimeString());
      }


      GraphicsCC.AxisX.Add(new LiveCharts.Wpf.Axis() {
        Title = "Час",
        Labels = dates
      });

      LineSeries bendingLine = new LineSeries();
      bendingLine.Title = "Згинання";
      bendingLine.Values = bendingValue;
      series.Add(bendingLine);

      LineSeries rotatingLine = new LineSeries();
      rotatingLine.Title = "Обертання";
      rotatingLine.Values = rotatingValue;
      series.Add(rotatingLine);

      LineSeries compressingLine = new LineSeries();
      compressingLine.Title = "Стискання";
      compressingLine.Values = compressingValue;
      series.Add(compressingLine);

      GraphicsCC.Series = series;
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

      return isCorrect;
    }


  }
}
