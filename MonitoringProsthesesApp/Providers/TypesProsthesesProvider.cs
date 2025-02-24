using MonitoringProsthesesApp.AppCode;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonitoringProsthesesApp.Providers {
  class TypesProsthesesProvider {
    private string _ConnString = System.Configuration.ConfigurationSettings.AppSettings["CONNECT"];

    public void InsertTypesProstheses(string TypesProsthesesName, string Description) {
      string SqlString = "INSERT INTO TypesProstheses (TypesProsthesesName, Description" +
        ") Values(?, ?)";

      using (OleDbConnection conn = new OleDbConnection(_ConnString)) {
        using (OleDbCommand cmd = new OleDbCommand(SqlString, conn)) {
          cmd.CommandType = CommandType.Text;
          cmd.Parameters.AddWithValue("TypesProsthesesName", TypesProsthesesName);
          cmd.Parameters.AddWithValue("Description", Description);
          conn.Open();
          cmd.ExecuteNonQuery();
          conn.Close();
        }
      }
    }

    public List<TypesProstheses> GetAllTypesProstheses() {
      int i = 0;
      string SqlString = "SELECT * FROM TypesProstheses";

      List<TypesProstheses> listTypesProstheses = new List<TypesProstheses>();
      using (OleDbConnection conn = new OleDbConnection(_ConnString)) {
        using (OleDbCommand cmd = new OleDbCommand(SqlString, conn)) {
          conn.Open();
          using (OleDbDataReader reader = cmd.ExecuteReader()) {
            while (reader.Read()) {
              TypesProstheses oneTypesProstheses = new TypesProstheses();
              oneTypesProstheses.Number = ++i;
              oneTypesProstheses.TypesProsthesesId = Convert.ToInt32(reader["TypesProsthesesId"]);
              oneTypesProstheses.TypesProsthesesName = reader["TypesProsthesesName"].ToString();
              oneTypesProstheses.Description = reader["Description"].ToString();
              listTypesProstheses.Add(oneTypesProstheses);
            }
          }
          conn.Close();
        }
      }

      if (listTypesProstheses.Count == 0) {
        TypesProstheses noTypesProstheses = new TypesProstheses();
        noTypesProstheses.TypesProsthesesId = 0;
        noTypesProstheses.Message = NamesMy.NoDataNames.NoDataInTypesProstheses;
        listTypesProstheses.Add(noTypesProstheses);
      }
      return listTypesProstheses;
    }

    public TypesProstheses SelectedTypesProsthesesByTypesProsthesesId(int TypesProsthesesId) {
      string SqlString = "SELECT * FROM TypesProstheses Where TypesProsthesesId=" + TypesProsthesesId.ToString();

      TypesProstheses oneTypesProstheses = new TypesProstheses();
      using (OleDbConnection conn = new OleDbConnection(_ConnString)) {
        using (OleDbCommand cmd = new OleDbCommand(SqlString, conn)) {
          conn.Open();
          using (OleDbDataReader reader = cmd.ExecuteReader()) {
            while (reader.Read()) {
              oneTypesProstheses.TypesProsthesesId = Convert.ToInt32(reader["TypesProsthesesId"]);
              oneTypesProstheses.TypesProsthesesName = reader["TypesProsthesesName"].ToString();
              oneTypesProstheses.Description = reader["Description"].ToString();
            }
          }
        }
        conn.Close();
      }
      return oneTypesProstheses;
    }

    public void UpdateTypesProstheses(string TypesProsthesesName, string Description, int TypesProsthesesId) {
      string SqlString = "UPDATE TypesProstheses SET TypesProsthesesName=?, Description=?  " +
  "WHERE TypesProsthesesId=?";

      using (OleDbConnection conn = new OleDbConnection(_ConnString)) {
        using (OleDbCommand cmd = new OleDbCommand(SqlString, conn)) {
          cmd.CommandType = CommandType.Text;
          cmd.Parameters.AddWithValue("TypesProsthesesName", TypesProsthesesName);
          cmd.Parameters.AddWithValue("Description", Description);
          cmd.Parameters.AddWithValue("TypesProsthesesId", TypesProsthesesId);
          conn.Open();
          cmd.ExecuteNonQuery();
          conn.Close();
        }
      }
    }

    public void DeleteTypesProsthesesByTypesProsthesesId(int TypesProsthesesId) {
      string SqlString = "DELETE FROM TypesProstheses WHERE TypesProsthesesId=" + TypesProsthesesId.ToString();
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


public class TypesProstheses {
  private int _Number;
  private int _TypesProsthesesId;
  private string _TypesProsthesesName;
  private string _Description;
  private string _Message;

  public TypesProstheses() {
    _Number = 0;
    _TypesProsthesesId = 0;
    _TypesProsthesesName = String.Empty;
    _Description = String.Empty;
    _Message = String.Empty;
  }

  public int Number {
    set { _Number = value; }
    get { return _Number; }
  }
  public int TypesProsthesesId {
    set { _TypesProsthesesId = value; }
    get { return _TypesProsthesesId; }
  }
  public string TypesProsthesesName {
    set { _TypesProsthesesName = value; }
    get { return _TypesProsthesesName; }
  }
  public string Description {
    set { _Description = value; }
    get { return _Description; }
  }
  public string Message {
    set { _Message = value; }
    get { return _Message; }
  }
}

