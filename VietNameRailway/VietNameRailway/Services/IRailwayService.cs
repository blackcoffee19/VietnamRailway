using VietNameRailway.Models;

namespace VietNameRailway.Services
{
    public interface IRailwayService
    {
        public Task<List<Station>?> GetAllGaBacNam();
        public Task<List<Carriages>?> GetAllToaXe();
    }
}
