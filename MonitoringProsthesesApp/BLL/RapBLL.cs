using MonitoringProsthesesApp.Providers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonitoringProsthesesApp.BLL {
  class RapBLL {
    ProsthesesProvider _ProsthesesProvider = new ProsthesesProvider();
    List<Prostheses> _ProsthesesList = new List<Prostheses>();
    InstallationProsthesesProvider _InstallationProsthesesProvider = new InstallationProsthesesProvider();
    ErorStatisticsProvider _ErorStatisticsProvider = new ErorStatisticsProvider();
    StatisticsProsthesesProvider _StatisticsProsthesesProvider = new StatisticsProsthesesProvider();

    public List<Prostheses> GetAllProsthesesByTypesProsthesesId(int TypesProsthesesId) {
      _ProsthesesList = _ProsthesesProvider.GetAllProstheses();
      List<Prostheses> selProsthesesList = new List<Prostheses>();
      for (int i = 0; i < _ProsthesesList.Count; i++) {
        if (TypesProsthesesId == _ProsthesesList[i].TypesProsthesesId) {
          selProsthesesList.Add(_ProsthesesList[i]);
        }
      }
      return selProsthesesList;
    }

    public List<InstallationProstheses> GetInstallationForPeriodDate(DateTime StartDT, DateTime EndDT) {
      List<InstallationProstheses> InstallationProsthesesList = new List<InstallationProstheses>();
      InstallationProsthesesList = _InstallationProsthesesProvider.GetAllInstallationProstheses();
      List<InstallationProstheses> searchInstallationProsthesesList = new List<InstallationProstheses>();

      for (int i = 0; i < InstallationProsthesesList.Count(); i++) {
        if (InstallationProsthesesList[i].InstallationDate >= StartDT && InstallationProsthesesList[i].InstallationDate <= EndDT) {
          searchInstallationProsthesesList.Add(InstallationProsthesesList[i]);
        }
      }
      return searchInstallationProsthesesList;
    }

    public List<ErorStatistics> GetErorStatisticsByProsthesesId(int ProsthesesId) {
      List<ErorStatistics> selErorStatistics = new List<ErorStatistics>();
      selErorStatistics = _ErorStatisticsProvider.GetAllErorStatisticsByProsthesesId(ProsthesesId);
      return selErorStatistics;
    }

    public List<StatisticsProstheses> GetRaportForPeriodDate(int PatientsId, int ProsthesesId, DateTime StartDT, DateTime EndDT) {
      List<StatisticsProstheses> StatisticsProsthesesList = new List<StatisticsProstheses>();
      StatisticsProsthesesList = _StatisticsProsthesesProvider.GetAllStatisticsProsthesesByPatientsIdAndProsthesesId(PatientsId, ProsthesesId);
      List<StatisticsProstheses> searchStatisticsProsthesesList = new List<StatisticsProstheses>();

      for (int i = 0; i < StatisticsProsthesesList.Count(); i++) {
        if (StatisticsProsthesesList[i].MonitoringDate >= StartDT && StatisticsProsthesesList[i].MonitoringDate <= EndDT) {
          searchStatisticsProsthesesList.Add(StatisticsProsthesesList[i]);
        }
      }
      return searchStatisticsProsthesesList;
    }


  }
}
