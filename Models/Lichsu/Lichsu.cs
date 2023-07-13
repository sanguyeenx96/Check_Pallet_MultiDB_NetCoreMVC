using System;
using System.Collections.Generic;

namespace pdc.Models.Lichsu
{
    public partial class Lichsu
    {
        public int Id { get; set; }
        public string Model { get; set; } = null!;
        public string Merchandide { get; set; } = null!;
        public string Numberpallet { get; set; } = null!;
        public string Bodyno { get; set; } = null!;
        public DateTime Datecheck { get; set; }
    }
}
