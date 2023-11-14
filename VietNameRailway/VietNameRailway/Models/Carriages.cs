using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace VietNameRailway.Models
{
    public class Carriages
    {
        [Key]
        public string? ToaXe {  get; set; }
        [DisplayName("Diễn Giải")]
        public string? DienGiai { get; set;}
        public int? LayoutId { get; set; }
        [DisplayName("Nhóm Chỗ")]
        public string? NhomCho {  get; set; }
    }
}
