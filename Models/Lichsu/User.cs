using System;
using System.Collections.Generic;

namespace pdc.Models.Lichsu
{
    public partial class User
    {
        public int Id { get; set; }
        public string Manv { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string? Hoten { get; set; }
        public string? Bophan { get; set; }
        public string? Calamviec { get; set; }
    }
}
