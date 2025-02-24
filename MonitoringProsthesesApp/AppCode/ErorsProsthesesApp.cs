using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonitoringProsthesesApp.AppCode {
  class ErorsProsthesesApp {
    public List<ErorProstheses> GetErorProsthesesList() {
      List<ErorProstheses> ErorProsthesesList = new List<ErorProstheses>();
      ErorProsthesesList.Add(new ErorProstheses(1, "Втрата сигналу між сенсором та контролером"));
      ErorProsthesesList.Add(new ErorProstheses(2, "Перегрів електронних компонентів"));
      ErorProsthesesList.Add(new ErorProstheses(3, "Пошкодження джойстика управління"));
      ErorProsthesesList.Add(new ErorProstheses(4, "Не відповідає датчик кута нахилу"));
      ErorProsthesesList.Add(new ErorProstheses(5, "Відмова вбудованого блока живлення"));
      ErorProsthesesList.Add(new ErorProstheses(6, "Відмова електродвигунів, які відповідають за рухи протеза"));
      ErorProsthesesList.Add(new ErorProstheses(7, "Відсутність можливості міцно фіксувати протез на тілі"));
      ErorProsthesesList.Add(new ErorProstheses(8, "Необхідність регулярного калібрування системи"));
      ErorProsthesesList.Add(new ErorProstheses(9, "Недостатній контроль над вибором дії користувача"));
      ErorProsthesesList.Add(new ErorProstheses(10, "Погана якість м'язових сигналів, що приходять від користувача"));
      ErorProsthesesList.Add(new ErorProstheses(11, "Пошкодження програмного забезпечення управління протезом"));
      return ErorProsthesesList;
    }
  }
}


public class ErorProstheses {
  private int _ErorProsthesesId;
  private string _ErorProsthesesName;
  public ErorProstheses() {
    _ErorProsthesesId = 0;
    _ErorProsthesesName = String.Empty;
  }
  public ErorProstheses(int ErorProsthesesId, string ErorProsthesesName) {
    _ErorProsthesesId = ErorProsthesesId;
    _ErorProsthesesName = ErorProsthesesName;
  }

  public int ErorProsthesesId {
    set { _ErorProsthesesId = value; }
    get { return _ErorProsthesesId; }
  }
  public string ErorProsthesesName {
    set { _ErorProsthesesName = value; }
    get { return _ErorProsthesesName; }
  }
}
