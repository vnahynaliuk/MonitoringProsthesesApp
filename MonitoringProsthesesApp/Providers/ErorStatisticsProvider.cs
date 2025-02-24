using MonitoringProsthesesApp.AppCode;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonitoringProsthesesApp.Providers {
  class ErorStatisticsProvider {
    private string _ConnString = System.Configuration.ConfigurationSettings.AppSettings["CONNECT"];
    PatientsProvider _PatientsProvider = new PatientsProvider();
    List<Patients> _PatientsList = new List<Patients>();
    ProsthesesProvider _ProsthesesProvider = new ProsthesesProvider();
    List<Prostheses> _ProsthesesList = new List<Prostheses>();

    public void InsertErorStatistics(string Description, DateTime ErorDate, int PatientsId, int ProsthesesId) {
      string SqlString = "INSERT INTO ErorStatistics (Description, ErorDate, PatientsId, ProsthesesId" +
        ") Values(?, ?, ?, ?)";

      using (OleDbConnection conn = new OleDbConnection(_ConnString)) {
        using (OleDbCommand cmd = new OleDbCommand(SqlString, conn)) {
          cmd.CommandType = CommandType.Text;
          cmd.Parameters.AddWithValue("Description", Description);
          cmd.Parameters.AddWithValue("ErorDate", ErorDate.ToString());
          cmd.Parameters.AddWithValue("PatientsId", PatientsId);
          cmd.Parameters.AddWithValue("ProsthesesId", ProsthesesId);
          conn.Open();
          cmd.ExecuteNonQuery();
          conn.Close();
        }
      }
    }

    public List<ErorStatistics> GetAllErorStatisticsByProsthesesId(int ProsthesesId) {
      int i = 0;
      string SqlString = "SELECT * FROM ErorStatistics WHERE ProsthesesId=" + ProsthesesId;
      _PatientsList = _PatientsProvider.GetAllPatients();
      _ProsthesesList = _ProsthesesProvider.GetAllProstheses();
      List<ErorStatistics> listErorStatistics = new List<ErorStatistics>();
      using (OleDbConnection conn = new OleDbConnection(_ConnString)) {
        using (OleDbCommand cmd = new OleDbCommand(SqlString, conn)) {
          conn.Open();
          using (OleDbDataReader reader = cmd.ExecuteReader()) {
            while (reader.Read()) {
              ErorStatistics oneErorStatistics = new ErorStatistics();
              oneErorStatistics.Number = ++i;
              oneErorStatistics.ErorStatisticsId = Convert.ToInt32(reader["ErorStatisticsId"]);
              oneErorStatistics.Description = reader["Description"].ToString();
              oneErorStatistics.ErorDate = Convert.ToDateTime(reader["ErorDate"]);
              oneErorStatistics.PatientsId = Convert.ToInt32(reader["PatientsId"]);
              oneErorStatistics.ProsthesesId = Convert.ToInt32(reader["ProsthesesId"]);
              listErorStatistics.Add(oneErorStatistics);
            }
          }
          conn.Close();
        }
      }

      if (listErorStatistics.Count == 0) {
        ErorStatistics noErorStatistics = new ErorStatistics();
        noErorStatistics.ErorStatisticsId = 0;
        noErorStatistics.Message = NamesMy.NoDataNames.NoDataInErorStatistics;
        listErorStatistics.Add(noErorStatistics);
      } else {
        for (int j = 0; j < listErorStatistics.Count; j++) {//Пробігаємся по всім замовленням
          listErorStatistics[j].PatientsFIO = GetPatientsFIO(listErorStatistics[j].PatientsId, _PatientsList);
          listErorStatistics[j].ProsthesesName = GetProsthesesName(listErorStatistics[j].ProsthesesId, _ProsthesesList);
        }
      }
        return listErorStatistics;
    }

    private string GetProsthesesName(int ProsthesesId, List<Prostheses> ProsthesesList) {
      for (int i = 0; i < ProsthesesList.Count; i++) {
        if (ProsthesesId == ProsthesesList[i].ProsthesesId) {
          return ProsthesesList[i].ProsthesesName.ToString();
        }
      }
      return "";
    }

    private string GetPatientsFIO(int PatientsId, List<Patients> PatientsList) {
      for (int i = 0; i < PatientsList.Count; i++) {
        if (PatientsId == PatientsList[i].PatientsId) {
          return PatientsList[i].FIO;
        }
      }
      return "";
    }

  }
}


public class ErorStatistics {
  private int _Number;
  private int _ErorStatisticsId;
  private string _Description;
  private DateTime _ErorDate;
  private int _PatientsId;
  private string _PatientsFIO;
  private int _ProsthesesId;
  private string _ProsthesesName;
  private string _Message;

  public ErorStatistics() {
    _Number = 0;
    _ErorStatisticsId = 0;
    _Description = String.Empty;
    _ErorDate = new DateTime();
    _PatientsId = 0;
    _PatientsFIO = String.Empty;
    _ProsthesesId = 0;
    _ProsthesesName = String.Empty;
    _Message = String.Empty;
  }

  public int Number {
    set { _Number = value; }
    get { return _Number; }
  }
  public int ErorStatisticsId {
    set { _ErorStatisticsId = value; }
    get { return _ErorStatisticsId; }
  }
  public string Description {
    set { _Description = value; }
    get { return _Description; }
  }
  public DateTime ErorDate {
    set { _ErorDate = value; }
    get { return _ErorDate; }
  }
  public int PatientsId {
    set { _PatientsId = value; }
    get { return _PatientsId; }
  }
  public string PatientsFIO {
    set { _PatientsFIO = value; }
    get { return _PatientsFIO; }
  }
  public int ProsthesesId {
    set { _ProsthesesId = value; }
    get { return _ProsthesesId; }
  }
  public string ProsthesesName {
    set { _ProsthesesName = value; }
    get { return _ProsthesesName; }
  }
  public string Message {
    set { _Message = value; }
    get { return _Message; }
  }
}
