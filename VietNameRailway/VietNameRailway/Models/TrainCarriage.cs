using System.ComponentModel;

namespace VietNameRailway.Models
{
    public class TrainCarriage
    {
        public int Id { get; set; }
        public int DMTauVatLyId {  get; set; }
        [DisplayName("Toa Số")]
        public string? ToaSo {  get; set; }
        public int ToaSoSX {  get; set; }
        public string? ToaXe {  get; set; }
        [DisplayName("Kiểu Toa")]
        public int ToaXeLayout { get;set; }
        public string? ChoVatLyKeys { get; set; }
        public string? ChoPhuKeys { get; set; }
        public string? ListLoaiCho { get; set; }
        [DisplayName("Mô tả")]
        public string? ToaXeDienGiai { get; set; }
        public string? ToaXeGhiChu { get; set; }
        public int ToaXeStatus { get; set; }
        public string? NhomChoWeb {  get; set; }
        [DisplayName("Số Chỗ Còn")]
        public int SoChoCon {  get; set; }
        public int SoChoLock {  get; set; }
        public int SoChoLonger {  get; set; }
        public int SoChoKhoa {  get; set; }
        public int SoChoTrong {  get; set; }
    }
}
