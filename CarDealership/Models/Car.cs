using System;
using System.Collections.Generic;

namespace CarDealership.Models {

  public class Car
  {
    private string _makeModel;
    private int _price;
    private int _miles;
    private string _message;
    private static List<Car> _instances = new List<Car>() ;

    public Car(string makeModel, int price, int miles, string message)
    {
      _makeModel = makeModel;
      _price = price;
      _miles = miles;
      _message = message;
      _instances.Add(this);
    }

    public string MakeModel { get => _makeModel; set => _makeModel = value; }
    public int Price { get => _price; set => _price = value; }
    public int Miles { get => _miles; set => _miles = value; }
    public string Message { get => _message; set => _message = value; }

    public void SetExclamation(string newMessage)
    {
      _message = _message + newMessage;
    }

    public bool WorthBuying(int maxPrice, int maxMiles)
    {
        return (_price < maxPrice && _miles < maxMiles);
    }

    public static List<Car> GetAll()
    {
        return _instances;
    }

    public static void ClearAll()
    {
        _instances.Clear();
    }
  }

}
