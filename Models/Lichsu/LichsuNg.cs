using System;
using System.Collections.Generic;

namespace pdc.Models.Lichsu
{
    public partial class LichsuNg
    {
        public int Id { get; set; }
        public string Model { get; set; } = null!;
        public string Thitruong { get; set; } = null!;
        public string Mapallet { get; set; } = null!;
        public string Mabodydb { get; set; } = null!;
        public string Mabodycheck { get; set; } = null!;
        public DateTime Ngaygio { get; set; }
        public string Nguoithaotac { get; set; } = null!;
    }
}
