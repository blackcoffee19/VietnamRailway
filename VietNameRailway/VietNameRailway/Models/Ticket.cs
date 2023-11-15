using System.ComponentModel;

namespace VietNameRailway.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        public int DMTauID { get; set; }
        [DisplayName("Loại Chỗ")]
        public string? LoaiCho { get; set; }
        [DisplayName("Tên Loại Chỗ")]
        public string? TenLoaiCho { get; set;}
        public int GiamGiaTG { get; set; }  
        public int Thue {  get; set; }
        public int BaoHiem { get; set; }
        public int PhiTra {  get; set; }
        [DisplayName("Giá Vé")]
        public int GiaVe { get; set; }
        public int GiamGiaPT { get; set; }
        public int LoaiGiam { get; set;}
        public int TyLe {  get; set; }
        public string? DienGiai3 {  get; set; }
        public string? DienGiai4 {  get; set; }
        public int Chos {  get; set; }
    }
}
