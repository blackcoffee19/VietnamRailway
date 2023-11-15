using Newtonsoft.Json;
using VietNameRailway.Models;

namespace VietNameRailway.Services
{
    public class RailwayService : IRailwayService
    {
        HttpClient client;
        public const string BASE_URL = "https://dsvn.vn/api/banveweb/";
        public RailwayService (HttpClient client)
        {
            this.client = client;
        }
        public async Task<List<Station>?> GetAllGaBacNam()
        {
            string url = BASE_URL + "GetAllGaBacNam";
            var res = await client.GetAsync(url);
            List<Station>? list = null;
            if (res.IsSuccessStatusCode)
            {
                var str = await res.Content.ReadAsStringAsync();
                list = JsonConvert.DeserializeObject<List<Station>>(str);
            }
            return list;
        }
        public async Task<List<Carriages>?> GetAllToaXe() {
            string url = BASE_URL + "GetAllToaXe";
            var res = await client.GetAsync(url);
            List<Carriages>? list = null;
            if (res.IsSuccessStatusCode)
            {
                var str = await res.Content.ReadAsStringAsync();
                list = JsonConvert.DeserializeObject<List<Carriages>>(str);
            }
            return list;
        }
        
        public class SearchTau
        {
            public string GaDi { get; set; }
            public string GaDen { get; set; }
            public string NgayDi {  get; set; }
            public int NgayDen { get; set;}
            public bool khuHoi {  get; set; }
            
        }
        //string gaDi, string gaDen, string ngayDi, string ngayVe, bool khuHoi
        public async Task<Booking?> SearchTauByGaDiGaDenNgayXP()
        {
            string url = BASE_URL + "SearchTauByGaDiGaDenNgayXP";
            string json = "{ 1 : 'SGO', 2 : 'HNO', 3 : '2023-11-17', 4 : '2023-11-17', 5 : true, 6 : '' }";
            Console.WriteLine(JsonConvert.DeserializeObject(json));
            var strcontent = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
            var resp = await client.PostAsync(url, strcontent);
            if (resp.IsSuccessStatusCode)
            {
                var result = await resp.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<Booking>(result);

            }
            return null;            
        } 
    }
}
