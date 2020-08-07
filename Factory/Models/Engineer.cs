using System.Collections.Generic;

namespace Factory.Models
{
  public class Engineer
  {
    public Engineer()
    {
      this.Machines = new HashSet<EngineerMachine>();
    }
    public string Name { get; set; }
    public string Shift { get; set; }
    public int ExperienceLevel { get; set; }
    public virtual ICollection<EngineerMachine> Machines { get; set; }
  }
}