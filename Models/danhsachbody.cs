using Microsoft.EntityFrameworkCore;

namespace pdc.Models
{
    public partial class danhsachbody
    {
        public string? model { get; set; }
        public string? thitruong { get; set; }
        public string? mapallet { get; set; }
        public string? bodydb { get; set; }
        public string? bodycheck { get; set; }
    }
}