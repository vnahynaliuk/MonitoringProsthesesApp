using LiveCharts;
using LiveCharts.Wpf;
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

namespace MonitoringProsthesesApp.Forms.Controls {
  public partial class StatusTrackingForm : Form {
    private InstallationProsthesesProvider _InstallationProsthesesProvider = new InstallationProsthesesProvider();
    private InstallationProstheses _SelectedInstallationProstheses = new InstallationProstheses();
    private PatientsProvider _PatientsProvider = new PatientsProvider();
    private List<Patients> _PatientsList = new List<Patients>();
    private ProsthesesProvider _ProsthesesProvider = new ProsthesesProvider();
    private List<Prostheses> _ProsthesesList = new List<Prostheses>();
    private StatisticsProsthesesProvider _StatisticsProsthesesProvider = new StatisticsProsthesesProvider();
    private List<StatisticsProstheses> _StatisticsProsthesesList = new List<StatisticsProstheses>();
    private ErorStatisticsProvider _ErorStatisticsProvider = new ErorStatisticsProvider();
    private ErorsProsthesesApp _ErorsProsthesesApp = new ErorsProsthesesApp();
    private List<ErorProstheses> _ErorProsthesesList = new List<ErorProstheses>();

    public StatusTrackingForm() {
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

      MonitoringDateDTP.Value = DateTime.Now.AddDays(-1);
      _ErorProsthesesList = _ErorsProsthesesApp.GetErorProsthesesList();
    }

    //private void AddBtn_Click(object sender, EventArgs e) {
    //  if (IsDataEnteringCorrect()) {
    //    GeterateData();
    //    BildGraphics(_StatisticsProsthesesList);
    //  }
    //}

    private void TrackBtn_Click(object sender, EventArgs e) {
      if (IsDataEnteringCorrect()) {
        GeterateData();
        BildGraphics(_StatisticsProsthesesList);
      }
    }

    private void GeterateData() {
      Random rand = new Random();
      _StatisticsProsthesesList.Clear();
      _StatisticsProsthesesList = _StatisticsProsthesesProvider.GetAllStatisticsProsthesesByPatientsIdAndProsthesesIdAndMonitoringDate(Convert.ToInt32(PatientsCBox.SelectedValue),
        Convert.ToInt32(ProsthesesCBox.SelectedValue), MonitoringDateDTP.Value);

      if (_StatisticsProsthesesList.Count == 0) {
        DateTime start = new DateTime(MonitoringDateDTP.Value.Year, MonitoringDateDTP.Value.Month, MonitoringDateDTP.Value.Day, 0, 0, 0); // початкова дата
        DateTime end = new DateTime(MonitoringDateDTP.Value.Year, MonitoringDateDTP.Value.Month, MonitoringDateDTP.Value.Day + 1, 0, 0, 0); // кінцева дата
        int intervalInHours = 1; // інтервал у годинах

        while (start < end) {
          StatisticsProstheses oneStatisticsProstheses = new StatisticsProstheses();
          oneStatisticsProstheses.Bending = rand.Next(0, 500);
          oneStatisticsProstheses.Rotating = rand.Next(0, 300);
          oneStatisticsProstheses.Compressing = rand.Next(0, 100);
          oneStatisticsProstheses.PatientsId = Convert.ToInt32(PatientsCBox.SelectedValue);
          oneStatisticsProstheses.ProsthesesId = Convert.ToInt32(ProsthesesCBox.SelectedValue);
          oneStatisticsProstheses.MonitoringDate = start;
          _StatisticsProsthesesList.Add(oneStatisticsProstheses);
          start = start.AddHours(intervalInHours); // додаємо інтервал до дати
        }
        int erorRand = rand.Next(1, _ErorProsthesesList.Count-1);
        _ErorStatisticsProvider.InsertErorStatistics(_ErorProsthesesList[erorRand].ErorProsthesesName, start, Convert.ToInt32(PatientsCBox.SelectedValue), Convert.ToInt32(ProsthesesCBox.SelectedValue));
        _StatisticsProsthesesProvider.InsertBatchStatisticsProstheses(_StatisticsProsthesesList);

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
      if (MonitoringDateDTP.Value.ToShortDateString() != DateTime.Now.ToShortDateString()) {
        MonitoringDateValidationLbl.Text = NamesMy.ProgramButtons.RequiredValidation;
      } else {
        MessageBox.Show("Немає даних на вибрану дату", "Увага!");
        MonitoringDateValidationLbl.Text = NamesMy.ProgramButtons.ErrorValidation;
        isCorrect = false;
      }
      _SelectedInstallationProstheses = _InstallationProsthesesProvider.SelectedInstallationByPatientsIdAndProsthesesId(Convert.ToInt32(PatientsCBox.SelectedValue), 
        Convert.ToInt32(ProsthesesCBox.SelectedValue));

      if (_SelectedInstallationProstheses.InstallationProsthesesId != 0) {
        DateTime curDate = new DateTime(MonitoringDateDTP.Value.Year, MonitoringDateDTP.Value.Month, MonitoringDateDTP.Value.Day, 0, 0, 0);
        if (curDate < _SelectedInstallationProstheses.InstallationDate) {
          MessageBox.Show("На вибрану дату ще не було встановлено протезу!", "Увага!");
          isCorrect = false;
        }
      } else {
        MessageBox.Show("Даному пацієнту не встановлено такий протез!", "Увага!");
        isCorrect = false;
      }
      return isCorrect;
    }


  }
}
