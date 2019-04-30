using Microsoft.AspNetCore.Mvc;
using CarDealership.Models;
using System.Collections.Generic;

namespace CarDealership.Controllers
{
  public class CarController : Controller
  {

    [HttpGet("/cars")]
    public ActionResult PageOfCars()
    {
      List<Car> allCars = Car.GetAll();
      return View(allCars);
    }

    [HttpGet("/admin")]
    public ActionResult Admin()
    {
      return View();
    }

    [HttpPost("/cars")]
    public ActionResult MakeCar(string makeModel, int price, int miles, string message)
    {
      Car newCar = new Car(makeModel, price, miles, message);
      return RedirectToAction("PageOfCars");
    }

  }
}
