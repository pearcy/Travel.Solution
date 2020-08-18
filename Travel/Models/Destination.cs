using System.ComponentModel.DataAnnotations;

namespace Travel.Models
{
  public class Destination
  {
    public int DestinationId { get; set; }
    public string Country { get; set; }
    public string City { get; set; }
    public int Rating { get; set; }
    public string Topspot { get; set; }
    public string Review { get; set; }
  }
}