using System;
using System.Collections.Generic;

namespace Factory.Models
{
  public class Engineer
  {
    public Engineer()
    {
      this.Machines = new HashSet<EngineerMachine>();
    }
    public int EngineerId { get; set; }
    public string Name { get; set; }
    public string Shift { get; set; }
    public DateTime HireDate { get; set; }
    public int ExperienceLevel { get; set; }
    public virtual ICollection<EngineerMachine> Machines { get; set; }
  }
}