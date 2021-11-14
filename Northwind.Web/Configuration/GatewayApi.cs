namespace Northwind.Web.Configuration
{
    using System.Net.Http;
    using System.Threading.Tasks;

    public class GatewayApi
    {
        private readonly HttpClient _httpClient;

        public GatewayApi(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<HttpResponseMessage> GetAsync(string serviceRoute)
        {
            return await _httpClient.GetAsync($"api/{serviceRoute}");
        }
    }
}