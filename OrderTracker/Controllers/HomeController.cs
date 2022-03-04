using Microsoft.AspNetCore.Mvc;
using Ordertracker.Models;
using System.Collections.Generic;

namespace OrderTracker.Controllers
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