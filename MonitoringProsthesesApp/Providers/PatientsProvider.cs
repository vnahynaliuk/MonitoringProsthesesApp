using MonitoringProsthesesApp.AppCode;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonitoringProsthesesApp.Providers {
  class PatientsProvider {
    private string _ConnString = System.Configuration.ConfigurationSettings.AppSettings["CONNECT"];
    public void InsertPatients(string LastName, string FirstName, string Phone, string Address, string Email) {
      string SqlString = "INSERT INTO Patients (LastName, FirstName, Phone, Address, " +
        "Email) Values(?, ?, ?, ?, ?)";

      using (OleDbConnection conn = new OleDbConnection(_ConnString)) {
        using (OleDbCommand cmd = new OleDbCommand(SqlString, conn)) {
          cmd.CommandType = CommandType.Text;
          cmd.Parameters.AddWithValue("LastName", LastName);
          cmd.Parameters.AddWithValue("FirstName", FirstName);
          cmd.Parameters.AddWithValue("Phone", Phone);
          cmd.Parameters.AddWithValue("Address", Address);
          cmd.Parameters.AddWithValue("Email", Email);
          conn.Open();
          cmd.ExecuteNonQuery();
          conn.Close();
        }
      }
    }

    public List<Patients> GetAllPatients() {
      int i = 0;
      string SqlString = "SELECT * FROM Patients";

      List<Patients> listAllPatients = new List<Patients>();
      using (OleDbConnection conn = new OleDbConnection(_ConnString)) {
        using (OleDbCommand cmd = new OleDbCommand(SqlString, conn)) {
          conn.Open();
          using (OleDbDataReader reader = cmd.ExecuteReader()) {
            while (reader.Read()) {
              Patients onePatients = new Patients();
              onePatients.Number = ++i;
              onePatients.PatientsId = Convert.ToInt32(reader["PatientsId"].ToString());
              onePatients.FirstName = reader["FirstName"].ToString();
              onePatients.LastName = reader["LastName"].ToString();
              onePatients.FIO = onePatients.LastName + " " + onePatients.FirstName;
              onePatients.Phone = reader["Phone"].ToString();
              onePatients.Address = reader["Address"].ToString();
              onePatients.Email = reader["Email"].ToString();

              listAllPatients.Add(onePatients);
            }
          }
          conn.Close();
        }
      }

      if (listAllPatients.Count == 0) {
        Patients noPatients = new Patients();
        noPatients.PatientsId = 0;
        noPatients.Message = NamesMy.NoDataNames.NoDataInPatients;
        listAllPatients.Add(noPatients);
      }
      return listAllPatients;
    }

    public Patients SelectedPatientsByPatientsId(int PatientsId) {
      string SqlString = "SELECT * FROM Patients Where PatientsId=" + PatientsId.ToString();

      Patients onePatients = new Patients();
      using (OleDbConnection conn = new OleDbConnection(_ConnString)) {
        using (OleDbCommand cmd = new OleDbCommand(SqlString, conn)) {
          conn.Open();
          using (OleDbDataReader reader = cmd.ExecuteReader()) {
            while (reader.Read()) {
              onePatients.PatientsId = Convert.ToInt32(reader["PatientsId"].ToString());
              onePatients.FirstName = reader["FirstName"].ToString();
              onePatients.LastName = reader["LastName"].ToString();
              onePatients.FIO = onePatients.LastName + " " + onePatients.FirstName;
              onePatients.Phone = reader["Phone"].ToString();
              onePatients.Address = reader["Address"].ToString();
              onePatients.Email = reader["Email"].ToString();
            }
          }
        }
        conn.Close();
      }
      return onePatients;
    }

    public void UpdatePatients(string LastName, string FirstName, string Phone, string Address, string Email, int PatientsId) {
      string SqlString = "UPDATE Patients SET FirstName=?, LastName=?, Phone=?, " +
  "Address=?, Email=? WHERE PatientsId=?";

      using (OleDbConnection conn = new OleDbConnection(_ConnString)) {
        using (OleDbCommand cmd = new OleDbCommand(SqlString, conn)) {
          cmd.CommandType = CommandType.Text;
          cmd.Parameters.AddWithValue("FirstName", FirstName);
          cmd.Parameters.AddWithValue("LastName", LastName);
          cmd.Parameters.AddWithValue("Phone", Phone);
          cmd.Parameters.AddWithValue("Address", Address);
          cmd.Parameters.AddWithValue("Email", Email);
          cmd.Parameters.AddWithValue("PatientsId", PatientsId);
          conn.Open();
          cmd.ExecuteNonQuery();
          conn.Close();
        }
      }
    }

    public void DeletePatientsByPatientsId(int PatientsId) {
      string SqlString = "DELETE FROM Patients WHERE PatientsId=" + PatientsId.ToString();
      using (OleDbConnection conn = new OleDbConnection(_ConnString)) {
        using (OleDbCommand cmd = new OleDbCommand(SqlString, conn)) {
          conn.Open();
          cmd.ExecuteNonQuery();
          conn.Close();
        }
      }
    }

  }
}


public class Patients {
  private int _Number;
  private int _PatientsId;
  private string _FirstName;
  private string _LastName;
  private string _Phone;
  private string _Address;
  private string _Email;
  private string _FIO;
  private string _Message;

  public Patients() {
    _Number = 0;
    _PatientsId = 0;
    _FirstName = String.Empty;
    _LastName = String.Empty;
    _Phone = String.Empty;
    _Address = String.Empty;
    _Email = String.Empty;
    _FIO = String.Empty;
    _Message = String.Empty;
  }

  public int Number {
    set { _Number = value; }
    get { return _Number; }
  }
  public int PatientsId {
    set { _PatientsId = value; }
    get { return _PatientsId; }
  }
  public string FirstName {
    set { _FirstName = value; }
    get { return _FirstName; }
  }
  public string LastName {
    set { _LastName = value; }
    get { return _LastName; }
  }
  public string Phone {
    set { _Phone = value; }
    get { return _Phone; }
  }
  public string Address {
    set { _Address = value; }
    get { return _Address; }
  }
  public string Email {
    set { _Email = value; }
    get { return _Email; }
  }
  public string FIO {
    set { _FIO = value; }
    get { return _FIO; }
  }
  public string Message {
    set { _Message = value; }
    get { return _Message; }
  }
}

