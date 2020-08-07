using System;
using System.Collections.Generic;

namespace Factory.Models
{
  public class Machine
  {
    public Machine()
    {
      this.Engineers = new HashSet<EngineerMachine>();
    }
    public int MachineId { get; set; }
    public string Model { get; set; }
    public string Manufacturer { get; set; }
    public int YearsInOperation { get; set; }
    public DateTime LastServiced { get; set; }
    public string MaintenanceInterval { get; set; }
    public ICollection<EngineerMachine> Engineers { get; set; }
  }
}