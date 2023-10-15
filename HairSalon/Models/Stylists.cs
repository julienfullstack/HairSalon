using System.Collections.Generic;

namespace EauClairesSalon.Models
{
  public class Stylist
  {
    public int StylistId { get; set; }
    public string Name { get; set; }
    public List<Client> Clients { get; set; }
  }
}