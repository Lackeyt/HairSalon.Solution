using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System;

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
    public string About { get; set; }
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public DateTime HireDate { get; set; }
    public virtual ICollection<Client> Clients { get; set; }
  }
}