namespace VietNameRailway.Models
{
    public class Booking
    {
        public ICollection<Train> TauDis {  get; set; }
        public string? TauVes {  get; set; }
        public string? BookingCode { get; set; }
        public bool CaptchaStatus { get; set; }
        public string? TauDiAlias {  get; set; }
        public string? TauVeAlias { get; set; }

    }
}
