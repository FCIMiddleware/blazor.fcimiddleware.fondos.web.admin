using blazor.fcimiddleware.fondos.web.admin.Models.Shared;
using blazor.fcimiddleware.fondos.web.admin.Models.V1.Paises;
using System.Text.Json;
using System.Text;

namespace blazor.fcimiddleware.fondos.web.admin.Services.Paises
{
    public class PaisProxy : IPaisProxy
    {
        private readonly HttpClient _httpClient;
        private readonly ILogger<PaisProxy> _logger;
        private string _entidad = "Pais";
        private string _version = "v1";

        public PaisProxy(
            HttpClient httpClient, 
            ILogger<PaisProxy> logger)
        {
            _httpClient = httpClient;
            _logger = logger;
        }

        public async Task<HttpResponseMessage> Create(CreatePaisRequest request)
        {
            StringContent content = new StringContent(
                JsonSerializer.Serialize(request),
                Encoding.UTF8,
                "application/json"
                );

            return await _httpClient.PostAsync($"api/{_version}/{_entidad}", content);
        }

        public async Task<HttpResponseMessage> Delete(GetByIdPaisRequest request)
        {
            return await _httpClient.DeleteAsync($"api/{_version}/{_entidad}/{request.Id}");
        }

        public async Task<HttpResponseMessage> GetById(GetByIdPaisRequest request)
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

        public async Task<HttpResponseMessage> Update(UpdatePaisRequest request)
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
