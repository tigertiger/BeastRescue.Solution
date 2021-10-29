using System;
using System.Linq;
using System.Collections;
using System.Threading.Tasks;
using System.Security.Claims;
using BeastRescueClient.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BeastRescueClient.Controllers
{
  public class BeastsController : Controller
  {

    public IActionResult Index()
    {
      var allBeasts = Beast.GetBeasts();
      return View(allBeasts);
    }

  }
}