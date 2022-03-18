using System;
using System.Collections.Generic;
using System.Text;

namespace Printers.Models
{
    public class Сartridge
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public List<Printer> Printers { get; set; } = new List<Printer>();
    }
}
