using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Travel.Models;
using Microsoft.EntityFrameworkCore;

namespace Travel.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class TravelsController : ControllerBase
  {
    private TravelContext _db;

    public TravelsController(TravelContext db)
    {
      _db = db;
    }

  [HttpGet]
  public ActionResult<IEnumerable<Destination>> Get(string country, string city, string topspot, string review)
  {
    var query = _db.Destinations.AsQueryable(); 

    if (country != null)
    {
      query = query.Where(entry => entry.Country == country);
    }

    if (city != null)
    {
      query = query.Where(entry => entry.City == city);
    }

    if (topspot != null)
    {
      query = query.Where(entry => entry.Topspot == topspot);
    }

    if (review != null)
    {
      query = query.Where(entry => entry.Review == review);
    }

    return query.ToList();
  }

   public ActionResult<IEnumerable<Destination>> Get()
    {
      return _db.Destinations.ToList();
    }

    // POST api/
    [HttpPost]
    public void Post([FromBody] Destination destination)
    {
      _db.Destinations.Add(destination);
      _db.SaveChanges();
    }



   
  }
}


