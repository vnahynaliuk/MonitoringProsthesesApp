using MonitoringProsthesesApp.AppCode;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonitoringProsthesesApp.Providers {
  class ProsthesesProvider {
    private string _ConnString = System.Configuration.ConfigurationSettings.AppSettings["CONNECT"];
    TypesProsthesesProvider _TypesProsthesesProvider = new TypesProsthesesProvider();
    List<TypesProstheses> _TypesProsthesesList = new List<TypesProstheses>();

    public void InsertProstheses(string ProsthesesName, string Producer, string Model, DateTime GraduationDate, string Material, 
      int Sizes, double Price, string Description,  int TypesProsthesesId) {
      //Створюємо запит на додавання замовлення у базу даних
      string SqlString = "INSERT INTO Prostheses (ProsthesesName, Producer, Model, GraduationDate, Material, " +
        "Sizes, Price, Description, TypesProsthesesId) Values(?, ?, ?, ?, ?, ?, ?, ?, ?)";

      using (OleDbConnection conn = new OleDbConnection(_ConnString)) { //Задаємо параметри з'єднання
        using (OleDbCommand cmd = new OleDbCommand(SqlString, conn)) { //Створюємо команду на додавання даних
          cmd.CommandType = CommandType.Text; //Тип команди задаємо тексторий
          cmd.Parameters.AddWithValue("ProsthesesName", ProsthesesName); //Додаємо параметри команди
          cmd.Parameters.AddWithValue("Producer", Producer);
          cmd.Parameters.AddWithValue("Model", Model);
          cmd.Parameters.AddWithValue("GraduationDate", GraduationDate.ToString());
          cmd.Parameters.AddWithValue("Material", Material);
          cmd.Parameters.AddWithValue("Sizes", Sizes);
          cmd.Parameters.AddWithValue("Price", Price);
          cmd.Parameters.AddWithValue("Description", Description);
          cmd.Parameters.AddWithValue("TypesProsthesesId", TypesProsthesesId);
          conn.Open(); //Відкриваємо з'єднання
          cmd.ExecuteNonQuery(); //Виконуємо команду
          conn.Close(); //Закриваємо з'єднання
        }
      }
    }

    public List<Prostheses> GetAllProstheses() {
      _TypesProsthesesList = _TypesProsthesesProvider.GetAllTypesProstheses(); //Витягуємо список побутових товарів

      int i = 0; //Обнуляємо лічильник к-сті записів
      string SqlString = "SELECT * FROM Prostheses";

      List<Prostheses> listAllProstheses = new List<Prostheses>(); //Створюємо список замовлень
      using (OleDbConnection conn = new OleDbConnection(_ConnString)) { //Задаємо параметри з'єднання
        using (OleDbCommand cmd = new OleDbCommand(SqlString, conn)) { //Створюємо команду на додавання 
          conn.Open(); //Відкриваємо з'єднання
          using (OleDbDataReader reader = cmd.ExecuteReader()) { //Зчитуємо дані із БД за доп. обєкту OleDbDataReader
            while (reader.Read()) { //Читаємо по 1 запису
              Prostheses oneProstheses = new Prostheses(); //сюди записуємо дані одного замовлення
              oneProstheses.Number = ++i;
              oneProstheses.ProsthesesId = Convert.ToInt32(reader["ProsthesesId"]); //Додаємо ідентифікатор
              oneProstheses.ProsthesesName = reader["ProsthesesName"].ToString();
              oneProstheses.Producer = reader["Producer"].ToString();
              oneProstheses.Model = reader["Model"].ToString();
              oneProstheses.GraduationDate = Convert.ToDateTime(reader["GraduationDate"]);
              oneProstheses.Material = reader["Material"].ToString();
              oneProstheses.Sizes = Convert.ToInt32(reader["Sizes"]);
              oneProstheses.Price = Convert.ToDouble(reader["Price"]);
              oneProstheses.Description = reader["Description"].ToString();
              oneProstheses.TypesProsthesesId = Convert.ToInt32(reader["TypesProsthesesId"]);
              listAllProstheses.Add(oneProstheses); //Додаємо один запис про у список
            }
          }
          conn.Close(); // Закриваємо з'єднання
        }
      }
      if (listAllProstheses.Count == 0) { //Якщо не знайдено жодного запису у базі
        Prostheses noProstheses = new Prostheses(); //Створюємо запис без даних
        noProstheses.ProsthesesId = 0; //Присвоюємо 0 ідентифікатор
        noProstheses.Message = NamesMy.NoDataNames.NoDataInProstheses; //Додаємо повідомлення про відсутність протезу
        listAllProstheses.Add(noProstheses); //додаємо запис без даних у список
      } else { //Інакше, якщо к-сть записів більше 0
        for (int j = 0; j < listAllProstheses.Count; j++) {//Пробігаємся по всім записам
          listAllProstheses[j].TypesProsthesesName = GetTypesProsthesesName(listAllProstheses[j].TypesProsthesesId, _TypesProsthesesList); //Додаємо інформацію про тип протезу
        }
      }
      return listAllProstheses; //Повертаємо список протезів
    }

 
    private string GetTypesProsthesesName(int TypesProsthesesId, List<TypesProstheses> TypesProsthesesList) {
      for (int i = 0; i < TypesProsthesesList.Count; i++) {
        if (TypesProsthesesId == TypesProsthesesList[i].TypesProsthesesId) {
          return TypesProsthesesList[i].TypesProsthesesName.ToString();
        }
      }
      return "";
    }


    public Prostheses SelectedProsthesesByProsthesesId(int ProsthesesId) {
      //Створюємо запит на зчитування даних про протез у базу даних
      string SqlString = "SELECT * FROM Prostheses Where ProsthesesId=" + ProsthesesId.ToString();
      Prostheses oneProstheses = new Prostheses(); //Створюємо екземпляр класу одного замовлення
      using (OleDbConnection conn = new OleDbConnection(_ConnString)) { //Відкриваємо з'єднання
        using (OleDbCommand cmd = new OleDbCommand(SqlString, conn)) { //Створюємо команду на додавання даних
          conn.Open();//Відкриваємо з'єднання
          using (OleDbDataReader reader = cmd.ExecuteReader()) { //Зчитуємо дані із БД за доп. обєкту OleDbDataReader
            while (reader.Read()) { //Читаємо по 1 об'єкту
              oneProstheses.ProsthesesId = Convert.ToInt32(reader["ProsthesesId"]); //Додаємо ідентифікатор продезу
              oneProstheses.ProsthesesName = reader["ProsthesesName"].ToString();
              oneProstheses.Producer = reader["Producer"].ToString();
              oneProstheses.Model = reader["Model"].ToString();
              oneProstheses.GraduationDate = Convert.ToDateTime(reader["GraduationDate"]);
              oneProstheses.Material = reader["Material"].ToString();
              oneProstheses.Sizes = Convert.ToInt32(reader["Sizes"]);
              oneProstheses.Price = Convert.ToDouble(reader["Price"]);
              oneProstheses.Description = reader["Description"].ToString();
              oneProstheses.TypesProsthesesId = Convert.ToInt32(reader["TypesProsthesesId"]);
            }
          }
        }
        conn.Close(); //Закриваємо з'єднання
      }
      return oneProstheses; //Повертаємо протез по його ідентифікатору
    }

    public void UpdateProstheses(string ProsthesesName, string Producer, string Model, DateTime GraduationDate, string Material, 
      int Sizes, double Price, string Description, int TypesProsthesesId, int ProsthesesId) {
      //Створюємо запит на редагування замовлення у базу даних
      string SqlString = "UPDATE Prostheses SET ProsthesesName=?, Producer=?, Model=?, GraduationDate=?, Material=?, " +
  "Sizes=?, Price=?, Description=?, TypesProsthesesId=? WHERE ProsthesesId=?";

      using (OleDbConnection conn = new OleDbConnection(_ConnString)) { //Відкриваємо з'єднання
        using (OleDbCommand cmd = new OleDbCommand(SqlString, conn)) { //Створюємо команду на додавання даних
          cmd.CommandType = CommandType.Text; //Тип команди задаємо тексторий
          //Додаємо значення параметрів для запису даних у БД
          cmd.Parameters.AddWithValue("ProsthesesName", ProsthesesName); //Додаємо параметри команди
          cmd.Parameters.AddWithValue("Producer", Producer);
          cmd.Parameters.AddWithValue("Model", Model);
          cmd.Parameters.AddWithValue("GraduationDate", GraduationDate.ToString());
          cmd.Parameters.AddWithValue("Material", Material);
          cmd.Parameters.AddWithValue("Sizes", Sizes);
          cmd.Parameters.AddWithValue("Price", Price);
          cmd.Parameters.AddWithValue("Description", Description);
          cmd.Parameters.AddWithValue("TypesProsthesesId", TypesProsthesesId);
          cmd.Parameters.AddWithValue("ProsthesesId", ProsthesesId);
          conn.Open(); //Відкриваємо з'єднання
          cmd.ExecuteNonQuery(); //Виконуємо команду
          conn.Close(); //Закриваємо з'єднання
        }
      }
    }

    public void DeleteProsthesesByProsthesesId(int ProsthesesId) {
      //Створюємо запит на видалення замовлення у базу даних
      string SqlString = "DELETE FROM Prostheses WHERE ProsthesesId=" + ProsthesesId.ToString(); //Додаємо ідентифікатор  у запит
      using (OleDbConnection conn = new OleDbConnection(_ConnString)) { //Відкриваємо з'єднання
        using (OleDbCommand cmd = new OleDbCommand(SqlString, conn)) { //Створюємо команду на видалення даних
          conn.Open(); //Відкриваємо з'єднання
          cmd.ExecuteNonQuery(); //Виконуємо команду
          conn.Close(); //Закриваємо з'єднання
        }
      }
    }

  }
}


public class Prostheses {
  private int _Number;
  private int _ProsthesesId;
  private string _ProsthesesName;
  private string _Producer;
  private string _Model;
  private DateTime _GraduationDate;
  private string _Material;
  private int _Sizes;
  private double _Price;
  private string _Description;
  private int _TypesProsthesesId;
  private string _TypesProsthesesName;
  private string _Message;

  public Prostheses() {
    _Number = 0;
    _ProsthesesId = 0;
    _ProsthesesName = String.Empty;
    _Producer = String.Empty;
    _Model = String.Empty;
    _GraduationDate = new DateTime();
    _Material = String.Empty;
    _Sizes = 0;
    _Price = 0.0;
    _Description = String.Empty;
    _TypesProsthesesId = 0;
    _TypesProsthesesName = String.Empty;
    _Message = String.Empty;
  }

  public int Number {
    set { _Number = value; }
    get { return _Number; }
  }
  public int ProsthesesId {
    set { _ProsthesesId = value; }
    get { return _ProsthesesId; }
  }
  public string ProsthesesName {
    set { _ProsthesesName = value; }
    get { return _ProsthesesName; }
  }
  public string Producer {
    set { _Producer = value; }
    get { return _Producer; }
  }
  public string Model {
    set { _Model = value; }
    get { return _Model; }
  }
  public DateTime GraduationDate {
    set { _GraduationDate = value; }
    get { return _GraduationDate; }
  }
  public string Material {
    set { _Material = value; }
    get { return _Material; }
  }
  public int Sizes {
    set { _Sizes = value; }
    get { return _Sizes; }
  }
  public double Price {
    set { _Price = value; }
    get { return _Price; }
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
