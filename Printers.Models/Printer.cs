using System;
using System.Collections.Generic;
using System.Text;

namespace Printers.Models
{
    public class Printer
    {
        public int Id { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public List<Сartridge> Cartridges { get; set; } = new List<Сartridge>();
        public List<PhysicalPrinter> PhysicalPrinters { get; set; } = new List<PhysicalPrinter>();
    }
}
