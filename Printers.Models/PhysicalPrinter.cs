using System;
using System.Collections.Generic;
using System.Text;

namespace Printers.Models
{
    public class PhysicalPrinter
    {
        public int Id { get; set; }
        public string PrinterName { get; set; }
        public string Location { get; set; }
        public int PrinterInfoId { get; set; }
        public Printer PrinterInfo { get; set; }
    }
}
