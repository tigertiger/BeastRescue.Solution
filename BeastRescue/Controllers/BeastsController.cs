using System;
using System.Linq;
using BeastRescue.Models;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;

namespace BeastRescue.Controllers
{

  [Route("api/[controller]")]
  [ApiController]
  public class BeastsController : ControllerBase
  {
    private readonly BeastRescueContext _db;

    public BeastsController(BeastRescueContext db)
    {
      _db = db;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Beast>>> Get()
    {
      return await _db.Beasts.ToListAsync();
    }
  }

}
