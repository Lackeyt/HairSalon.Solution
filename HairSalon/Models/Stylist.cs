using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace HairSalon.Models
{
  public class Stylist
  {
    public Stylist()
    {
      this.Clients = new HashSet<Client>();
    }
    public int StylistId { get; set; }
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)] //allows SQL Workbench to apply DB defined default values when passed null from the program
    public string Name { get; set; }
    public string Details { get; set; }
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Datetime HireDate { get; set; }
    public virtual ICollection<Client> Clients { get; set; }
  }
}