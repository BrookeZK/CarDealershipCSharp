using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using CarDealership.Controllers;
using CarDealership.Models;

namespace CarDealership.Controllers
{
  public class HomeController : Controller
  {

    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }

  }
}
