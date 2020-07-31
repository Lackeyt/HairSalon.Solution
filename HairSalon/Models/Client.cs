using System.ComponentModel.DataAnnotations.Schema;

namespace HairSalon.Models
{
  public class Client
  {
    public int ClientId { get; set; }
    public int StylistId { get; set; }
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public string Name { get; set; }
    public int PhoneNumber { get; set; }
    public string HairStyle { get; set; }
    public virtual Stylist Stylist { get; set; }
  }
}