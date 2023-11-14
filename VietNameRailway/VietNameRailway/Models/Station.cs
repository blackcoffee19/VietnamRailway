using System.ComponentModel;

namespace VietNameRailway.Models
{
    public class Station
    {
        public int Id { get; set; }
        [DisplayName("Mã Ga")]
        public string? MaGa { get; set; }
        [DisplayName("Tên Ga")]
        public string? TenGa { get; set;}
        public string? SKeys { get; set; }
    }
}
