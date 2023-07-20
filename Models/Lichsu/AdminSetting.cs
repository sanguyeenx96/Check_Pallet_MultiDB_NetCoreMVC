using System;
using System.Collections.Generic;

namespace pdc.Models.Lichsu
{
    public partial class AdminSetting
    {
        public int Id { get; set; }
        public string Mode { get; set; } = null!;
        public int Value { get; set; }
    }
}
