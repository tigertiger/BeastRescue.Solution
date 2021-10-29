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

    [HttpGet("{id}")]
    public async Task<ActionResult<Beast>> GetBeast(int id)
    {
      var beast = await _db.Beasts.FindAsync(id);

      if (beast == null)
      {
        return NotFound();
      }
      return beast;
    }

    [HttpPost]
    public async Task<ActionResult<Beast>> Post(Beast beast)
    {
      _db.Beasts.Add(beast);
      await _db.SaveChangesAsync();

      return CreatedAtAction("Post", new {id = beast.BeastId}, beast);
    }

    [HttpPatch("{id}")]
    public async Task<IActionResult> Patch(int id, Beast beast)
    {
      if (id != beast.BeastId)
      {
        return BadRequest();
      }

      _db.Entry(beast).State = EntityState.Modified;

      try
      {
        await _db.SaveChangesAsync();
      }
      catch (DbUpdateConcurrencyException)
      {
        if (!BeastExists(id))
        {
          return NotFound();
        }
        else
        {
          throw;
        }
      }

      return NoContent();
    }



    private bool BeastExists(int id)
    {
      return _db.Beasts.Any(e => e.BeastId == id);
    }
  }

}
