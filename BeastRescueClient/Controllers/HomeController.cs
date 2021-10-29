using Microsoft.AspNetCore.Mvc;
using BeastRescue.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;

namespace BeastRescue.Controllers
{
  public class HomeController : Controller
  {
    private readonly BeastRescueContext _db;

    public HomeController(BeastRescueContext db)
    {
      _db = db;
    }

    [HttpGet("/")]
    public ActionResult Index() { 
      return View(); 
    }
  
  }
}