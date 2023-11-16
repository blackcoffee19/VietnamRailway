using System.ComponentModel;

namespace VietNameRailway.Models
{
    public class Train
    {
        public int Id { get; set; }
        public int? DMTauVatLyId {  get; set; }
        public string? MaGaDi {  get; set; }
        public string? TenGaDi {  get; set; }
        public string? MaGaDen { get; set; }
        public string? TenGaDen { get; set; }
        public int? GaDiKM { get; set; }
        public int? GaDenKM { get; set;}
        public string? NgayDi {  get; set; }
        public string? NgayDen { get; set;}
        [DisplayName("Mác Tàu")]
        public string? MacTau {  get; set; }
        public string? GioDi {  get; set; }
        public string? GioDen { get; set;}
        [DisplayName("Tổng Chỗ Còn")]
        public int? TongChoCon {  get; set; }
        public int? TongChoLock { get; set; }
        public int? TongChoLonger {  get; set; }
        public string? NgayXP { get; set; }
        [DisplayName("Bảng giá vé")]
        public ICollection<Ticket>? BangGiaVes { get; set; }
        public List<int?>? BangGiaVeKeys { get; set; }
        [DisplayName("Toa Xe")]
        public ICollection<TrainCarriage>? ToaXes { get; set; }
        public string? DMTauVatLy { get; set; }
        public string? ListToaP { get; set; }
        public int? Ngay {  get; set; }
        public int? Ngay_XP {  get; set; }
        public int? HanhTrinhID {  get; set; }
        public List<string>? TauXeKeys {  get; set; }
        [DisplayName("Ngày Giờ Đi- Đến")]
        public string? NgayGioDi {  get; set; }
        public string? NgayGioDen { get; set; }
        public string? OnTrainTime {  get; set; }
        public bool HasCheapTicket {  get; set; }=false;
        public string? ListThongBao {  get; set; }

    }
}
