using MonitoringProsthesesApp.AppCode;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonitoringProsthesesApp.Providers {
  class InstallationProsthesesProvider {
    private string _ConnString = System.Configuration.ConfigurationSettings.AppSettings["CONNECT"];
    PatientsProvider _PatientsProvider = new PatientsProvider();
    List<Patients> _PatientsList = new List<Patients>();
    ProsthesesProvider _ProsthesesProvider = new ProsthesesProvider();
    List<Prostheses> _ProsthesesList = new List<Prostheses>();

    public void InsertInstallationProstheses(int PatientsId, int ProsthesesId, DateTime InstallationDate, double Price, string Description) {
      //Створюємо запит на додавання замовлення у базу даних
      string SqlString = "INSERT INTO InstallationProstheses (PatientsId, ProsthesesId, InstallationDate, " +
        "Price, Description) Values(?, ?, ?, ?, ?)";

      using (OleDbConnection conn = new OleDbConnection(_ConnString)) { //Задаємо параметри з'єднання
        using (OleDbCommand cmd = new OleDbCommand(SqlString, conn)) { //Створюємо команду на додавання даних
          cmd.CommandType = CommandType.Text; //Тип команди задаємо тексторий
          cmd.Parameters.AddWithValue("PatientsId", PatientsId); //Додаємо параметри команди
          cmd.Parameters.AddWithValue("ProsthesesId", ProsthesesId);
          cmd.Parameters.AddWithValue("InstallationDate", InstallationDate.ToString());
          cmd.Parameters.AddWithValue("Price", Price);
          cmd.Parameters.AddWithValue("Description", Description);
          conn.Open(); //Відкриваємо з'єднання
          cmd.ExecuteNonQuery(); //Виконуємо команду
          conn.Close(); //Закриваємо з'єднання
        }
      }
    }

    public List<InstallationProstheses> GetAllInstallationProstheses() {
      _PatientsList = _PatientsProvider.GetAllPatients();
      _ProsthesesList = _ProsthesesProvider.GetAllProstheses(); 

      int i = 0; //Обнуляємо лічильник к-сті записів
      string SqlString = "SELECT * FROM InstallationProstheses";

      List<InstallationProstheses> listAllInstallationProstheses = new List<InstallationProstheses>();
      using (OleDbConnection conn = new OleDbConnection(_ConnString)) {
        using (OleDbCommand cmd = new OleDbCommand(SqlString, conn)) { 
          conn.Open(); //Відкриваємо з'єднання
          using (OleDbDataReader reader = cmd.ExecuteReader()) { 
            while (reader.Read()) { 
              InstallationProstheses oneInstallationProstheses = new InstallationProstheses(); 
              oneInstallationProstheses.Number = ++i;
              oneInstallationProstheses.InstallationProsthesesId = Convert.ToInt32(reader["InstallationProsthesesId"]); 
              oneInstallationProstheses.PatientsId = Convert.ToInt32(reader["PatientsId"]);
              oneInstallationProstheses.ProsthesesId = Convert.ToInt32(reader["ProsthesesId"]);
              oneInstallationProstheses.InstallationDate = Convert.ToDateTime(reader["InstallationDate"]);
              oneInstallationProstheses.Price = Convert.ToDouble(reader["Price"]);
              oneInstallationProstheses.Description = reader["Description"].ToString();
              listAllInstallationProstheses.Add(oneInstallationProstheses); 
            }
          }
          conn.Close(); // Закриваємо з'єднання
        }
      }
      if (listAllInstallationProstheses.Count == 0) { 
        InstallationProstheses noInstallationProstheses = new InstallationProstheses(); 
        noInstallationProstheses.InstallationProsthesesId = 0; 
        noInstallationProstheses.Message = NamesMy.NoDataNames.NoDataInInstallationProstheses; 
        listAllInstallationProstheses.Add(noInstallationProstheses); 
      } else {
        for (int j = 0; j < listAllInstallationProstheses.Count; j++) {//Пробігаємся по всім замовленням
          listAllInstallationProstheses[j].PatientsFIO = GetPatientsFIO(listAllInstallationProstheses[j].PatientsId, _PatientsList); 
          listAllInstallationProstheses[j].ProsthesesName = GetProsthesesName(listAllInstallationProstheses[j].ProsthesesId, _ProsthesesList); 
        }
      }
      return listAllInstallationProstheses; //Повертаємо список замовлень
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
    public InstallationProstheses SelectedInstallationProsthesesByInstallationProsthesesId(int InstallationProsthesesId) {
      string SqlString = "SELECT * FROM InstallationProstheses Where InstallationProsthesesId=" + InstallationProsthesesId.ToString();
      InstallationProstheses oneInstallationProstheses = new InstallationProstheses(); 
      using (OleDbConnection conn = new OleDbConnection(_ConnString)) {
        using (OleDbCommand cmd = new OleDbCommand(SqlString, conn)) {
          conn.Open();
          using (OleDbDataReader reader = cmd.ExecuteReader()) { 
            while (reader.Read()) {
              oneInstallationProstheses.InstallationProsthesesId = Convert.ToInt32(reader["InstallationProsthesesId"]);
              oneInstallationProstheses.PatientsId = Convert.ToInt32(reader["PatientsId"]);
              oneInstallationProstheses.ProsthesesId = Convert.ToInt32(reader["ProsthesesId"]);
              oneInstallationProstheses.InstallationDate = Convert.ToDateTime(reader["InstallationDate"]);
              oneInstallationProstheses.Price = Convert.ToDouble(reader["Price"]);
              oneInstallationProstheses.Description = reader["Description"].ToString();
            }
          }
        }
        conn.Close(); //Закриваємо з'єднання
      }
      return oneInstallationProstheses; 
    }

    public InstallationProstheses SelectedInstallationByPatientsIdAndProsthesesId(int PatientsId, int ProsthesesId) {
      string SqlString = "SELECT * FROM InstallationProstheses Where PatientsId=" + PatientsId + " AND ProsthesesId=" + ProsthesesId;
      InstallationProstheses oneInstallationProstheses = new InstallationProstheses();
      using (OleDbConnection conn = new OleDbConnection(_ConnString)) {
        using (OleDbCommand cmd = new OleDbCommand(SqlString, conn)) {
          conn.Open();
          using (OleDbDataReader reader = cmd.ExecuteReader()) {
            while (reader.Read()) {
              oneInstallationProstheses.InstallationProsthesesId = Convert.ToInt32(reader["InstallationProsthesesId"]);
              oneInstallationProstheses.PatientsId = Convert.ToInt32(reader["PatientsId"]);
              oneInstallationProstheses.ProsthesesId = Convert.ToInt32(reader["ProsthesesId"]);
              oneInstallationProstheses.InstallationDate = Convert.ToDateTime(reader["InstallationDate"]);
              oneInstallationProstheses.Price = Convert.ToDouble(reader["Price"]);
              oneInstallationProstheses.Description = reader["Description"].ToString();
            }
          }
        }
        conn.Close(); //Закриваємо з'єднання
      }
      return oneInstallationProstheses;
    }

    public void UpdateInstallationProstheses(int PatientsId, int ProsthesesId, DateTime InstallationDate, double Price, string Description, int InstallationProsthesesId) {
      //Створюємо запит на редагування замовлення у базу даних
      string SqlString = "UPDATE InstallationProstheses SET PatientsId=?, ProsthesesId=?, InstallationDate=?, " +
  "Price=?, Description=?  WHERE InstallationProsthesesId=?";

      using (OleDbConnection conn = new OleDbConnection(_ConnString)) { //Відкриваємо з'єднання
        using (OleDbCommand cmd = new OleDbCommand(SqlString, conn)) { //Створюємо команду на додавання даних
          cmd.CommandType = CommandType.Text; //Тип команди задаємо тексторий
          //Додаємо значення параметрів для запису даних у БД
          cmd.Parameters.AddWithValue("PatientsId", PatientsId);
          cmd.Parameters.AddWithValue("ProsthesesId", ProsthesesId);
          cmd.Parameters.AddWithValue("InstallationDate", InstallationDate.ToString());
          cmd.Parameters.AddWithValue("Price", Price);
          cmd.Parameters.AddWithValue("Description", Description);
          cmd.Parameters.AddWithValue("InstallationProsthesesId", InstallationProsthesesId);
          conn.Open(); //Відкриваємо з'єднання
          cmd.ExecuteNonQuery(); //Виконуємо команду
          conn.Close(); //Закриваємо з'єднання
        }
      }
    }

    public void DeleteInstallationProsthesesByInstallationProsthesesId(int InstallationProsthesesId) {
      string SqlString = "DELETE FROM InstallationProstheses WHERE InstallationProsthesesId=" + InstallationProsthesesId.ToString(); 
      using (OleDbConnection conn = new OleDbConnection(_ConnString)) { 
        using (OleDbCommand cmd = new OleDbCommand(SqlString, conn)) { 
          conn.Open(); //Відкриваємо з'єднання
          cmd.ExecuteNonQuery(); //Виконуємо команду
          conn.Close(); //Закриваємо з'єднання
        }
      }
    }

  }
}




public class InstallationProstheses {
  private int _Number;
  private int _InstallationProsthesesId;
  private int _PatientsId;
  private string _PatientsFIO;
  private int _ProsthesesId;
  private string _ProsthesesName;
  private DateTime _InstallationDate;
  private double _Price;
  private string _Description;
  private string _Message;

  public InstallationProstheses() {
    _Number = 0;
    _InstallationProsthesesId = 0;
    _PatientsId = 0;
    _PatientsFIO = String.Empty;
    _ProsthesesId = 0;
    _ProsthesesName = String.Empty;
    _InstallationDate = new DateTime();
    _Price = 0.0;
    _Description = String.Empty;
    _Message = String.Empty;
  }

  public int Number {
    set { _Number = value; }
    get { return _Number; }
  }
  public int InstallationProsthesesId {
    set { _InstallationProsthesesId = value; }
    get { return _InstallationProsthesesId; }
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
  public DateTime InstallationDate {
    set { _InstallationDate = value; }
    get { return _InstallationDate; }
  }
  public double Price {
    set { _Price = value; }
    get { return _Price; }
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
