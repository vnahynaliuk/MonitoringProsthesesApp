using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonitoringProsthesesApp.Providers {
  class StatisticsProsthesesProvider {
    private string _ConnString = System.Configuration.ConfigurationSettings.AppSettings["CONNECT"];
    public void InsertBatchStatisticsProstheses(List<StatisticsProstheses> StatisticsProstheses) {
      string SqlString = "INSERT INTO StatisticsProstheses (PatientsId, ProsthesesId, MonitoringDate, Bending, Rotating, Compressing) Values(?, ?, ?, ?, ?, ?)";
      using (OleDbConnection conn = new OleDbConnection(_ConnString)) {
        using (OleDbCommand cmd = new OleDbCommand(SqlString, conn)) {
          cmd.CommandType = CommandType.Text;
          conn.Open();
          for (int i = 0; i < StatisticsProstheses.Count; i++) {
            cmd.Parameters.AddWithValue("PatientsId", StatisticsProstheses[i].PatientsId);
            cmd.Parameters.AddWithValue("ProsthesesId", StatisticsProstheses[i].ProsthesesId);
            cmd.Parameters.AddWithValue("MonitoringDate", StatisticsProstheses[i].MonitoringDate.ToString());
            cmd.Parameters.AddWithValue("Bending", StatisticsProstheses[i].Bending);
            cmd.Parameters.AddWithValue("Rotating", StatisticsProstheses[i].Rotating);
            cmd.Parameters.AddWithValue("Compressing", StatisticsProstheses[i].Compressing);
            cmd.ExecuteNonQuery();
            while (cmd.Parameters.Count > 0) {
              cmd.Parameters.RemoveAt(0);
            }
          }
          conn.Close();
        }
      }
    }

    public List<StatisticsProstheses> GetAllStatisticsProsthesesByPatientsIdAndProsthesesId(int PatientsId, int ProsthesesId) {
      int i = 0;
      string SqlString = "SELECT * FROM StatisticsProstheses WHERE PatientsId=" + PatientsId + " AND ProsthesesId=" + ProsthesesId;

      List<StatisticsProstheses> StatisticsProstheses = new List<StatisticsProstheses>();
      using (OleDbConnection conn = new OleDbConnection(_ConnString)) {
        using (OleDbCommand cmd = new OleDbCommand(SqlString, conn)) {
          conn.Open();
          using (OleDbDataReader reader = cmd.ExecuteReader()) {
            while (reader.Read()) {
              StatisticsProstheses oneStatisticsProstheses = new StatisticsProstheses();
              oneStatisticsProstheses.Number = ++i;
              oneStatisticsProstheses.StatisticsProsthesesId = Convert.ToInt32(reader["StatisticsProsthesesId"]);
              oneStatisticsProstheses.PatientsId = Convert.ToInt32(reader["PatientsId"]);
              oneStatisticsProstheses.ProsthesesId = Convert.ToInt32(reader["ProsthesesId"]);
              oneStatisticsProstheses.MonitoringDate = Convert.ToDateTime(reader["MonitoringDate"]);
              oneStatisticsProstheses.Bending = Convert.ToInt32(reader["Bending"]);
              oneStatisticsProstheses.Rotating = Convert.ToInt32(reader["Rotating"]);
              oneStatisticsProstheses.Compressing = Convert.ToInt32(reader["Compressing"]);
              StatisticsProstheses.Add(oneStatisticsProstheses);
            }
          }
          conn.Close();
        }
      }
      return StatisticsProstheses;
    }


    public List<StatisticsProstheses> GetAllStatisticsProsthesesByPatientsIdAndProsthesesIdAndMonitoringDate(int PatientsId, int ProsthesesId, DateTime MonitoringDate) {
      int i = 0;
      string SqlString = "SELECT * FROM StatisticsProstheses WHERE PatientsId=" + PatientsId + " AND ProsthesesId=" + ProsthesesId + " AND MonitoringDate BETWEEN @DateStart AND @DateEnd";

      List<StatisticsProstheses> StatisticsProstheses = new List<StatisticsProstheses>();
      using (OleDbConnection conn = new OleDbConnection(_ConnString)) {
        using (OleDbCommand cmd = new OleDbCommand(SqlString, conn)) {
          cmd.Parameters.AddWithValue("@DateStart", new DateTime(MonitoringDate.Year, MonitoringDate.Month, MonitoringDate.Day, 0,0,0));
          cmd.Parameters.AddWithValue(" @DateEnd", new DateTime(MonitoringDate.Year, MonitoringDate.Month, MonitoringDate.Day, 23, 59, 59));
          conn.Open();
          using (OleDbDataReader reader = cmd.ExecuteReader()) {
            while (reader.Read()) {
              StatisticsProstheses oneStatisticsProstheses = new StatisticsProstheses();
              oneStatisticsProstheses.Number = ++i;
              oneStatisticsProstheses.StatisticsProsthesesId = Convert.ToInt32(reader["StatisticsProsthesesId"]);
              oneStatisticsProstheses.PatientsId = Convert.ToInt32(reader["PatientsId"]);
              oneStatisticsProstheses.ProsthesesId = Convert.ToInt32(reader["ProsthesesId"]);
              oneStatisticsProstheses.MonitoringDate = Convert.ToDateTime(reader["MonitoringDate"]);
              oneStatisticsProstheses.Bending = Convert.ToInt32(reader["Bending"]);
              oneStatisticsProstheses.Rotating = Convert.ToInt32(reader["Rotating"]);
              oneStatisticsProstheses.Compressing = Convert.ToInt32(reader["Compressing"]);
              StatisticsProstheses.Add(oneStatisticsProstheses);
            }
          }
          conn.Close();
        }
      }
      return StatisticsProstheses;
    }



  }
}



public class StatisticsProstheses {
  private int _Number;
  private int _StatisticsProsthesesId;
  private int _PatientsId;
  private int _ProsthesesId;
  private DateTime _MonitoringDate;
  private int _Bending;
  private int _Rotating;
  private int _Compressing;


  private string _Message;

  public StatisticsProstheses() {
    _Number = 0;
    _StatisticsProsthesesId = 0;
    _PatientsId = 0;
    _ProsthesesId = 0;
    _MonitoringDate = new DateTime();
    _Bending = 0;
    _Rotating = 0;
    _Compressing = 0;
  }

  public int Number {
    set { _Number = value; }
    get { return _Number; }
  }
  public int StatisticsProsthesesId {
    set { _StatisticsProsthesesId = value; }
    get { return _StatisticsProsthesesId; }
  }
  public int PatientsId {
    set { _PatientsId = value; }
    get { return _PatientsId; }
  }
  public int ProsthesesId {
    set { _ProsthesesId = value; }
    get { return _ProsthesesId; }
  }
  public DateTime MonitoringDate {
    set { _MonitoringDate = value; }
    get { return _MonitoringDate; }
  }
  public int Bending {
    set { _Bending = value; }
    get { return _Bending; }
  }
  public int Rotating {
    set { _Rotating = value; }
    get { return _Rotating; }
  }
  public int Compressing {
    set { _Compressing = value; }
    get { return _Compressing; }
  }
  public string Message {
    set { _Message = value; }
    get { return _Message; }
  }
}