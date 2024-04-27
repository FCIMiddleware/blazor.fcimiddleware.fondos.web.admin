using blazor.fcimiddleware.fondos.web.admin.Models.Settings;
using blazor.fcimiddleware.fondos.web.admin.Models.Shared;
using blazor.fcimiddleware.fondos.web.admin.Models.V1.Monedas;
using System.Text;
using System.Text.Json;

namespace blazor.fcimiddleware.fondos.web.admin.Services.Monedas
{
    public class MonedaProxy : IMonedaProxy
    {
        private readonly HttpClient _httpClient;
        private readonly ILogger<MonedaProxy> _logger;
        private string _entidad = "Moneda";
        private string _version = "v1";

        public MonedaProxy(
            HttpClient httpClient, 
            ILogger<MonedaProxy> logger)
        {
            _httpClient = httpClient;
            _logger = logger;
        }

        public async Task<HttpResponseMessage> Create(CreateMonedaRequest request)
        {
            StringContent content = new StringContent(
                JsonSerializer.Serialize(request),
                Encoding.UTF8,
                "application/json"
                );

            return await _httpClient.PostAsync($"api/{_version}/{_entidad}", content);

        }

        public async Task<HttpResponseMessage> Delete(GetByIdMonedaRequest request)
        {
            return await _httpClient.DeleteAsync($"api/{_version}/{_entidad}/{request.Id}");
        }

        public async Task<HttpResponseMessage> GetById(GetByIdMonedaRequest request)
        {
            return await _httpClient.GetAsync($"api/{_version}/{_entidad}/id?Id={request.Id}");
        }

        public async Task<HttpResponseMessage> List(PaginationQueryRequest request)
        {
            return
                await _httpClient
                .GetAsync(
                    $"api/{_version}/{_entidad}/list?PageIndex={request.PageIndex}&PageSize={request.PageSize}&Search={request.Search}&Sort={request.Sort}");
        }

        public async Task<HttpResponseMessage> Pagination(PaginationQueryRequest request)
        {
            return
                await _httpClient
                .GetAsync(
                    $"api/{_version}/{_entidad}/pagination?PageIndex={request.PageIndex}&PageSize={request.PageSize}&Search={request.Search}&Sort={request.Sort}");
        }

        public async Task<HttpResponseMessage> Update(UpdateMonedaRequest request)
        {
            StringContent content = new StringContent(
                JsonSerializer.Serialize(request),
                Encoding.UTF8,
                "application/json"
                );

            return await _httpClient.PutAsync($"api/{_version}/{_entidad}", content);
        }
    }
}
