using System;
using System.Linq;
using BeastRescue.Models;
using System.Collections;
using System.Threading.Tasks;
using System.Security.Claims;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BeastRescue.Controllers
{
  public class BeastsController : Controller
  {
    private readonly BeastRescueContext _db;

    public ActionResult Index()
    {
      List<Beast> sorted = _db.Beasts.ToList().OrderBy(beast => beast.Name).ToList();
      return View(sorted);
    }

  }
}