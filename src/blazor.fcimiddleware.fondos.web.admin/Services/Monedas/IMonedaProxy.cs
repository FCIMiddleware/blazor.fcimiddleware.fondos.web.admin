using blazor.fcimiddleware.fondos.web.admin.Models.Shared;
using blazor.fcimiddleware.fondos.web.admin.Models.V1.Monedas;

namespace blazor.fcimiddleware.fondos.web.admin.Services.Monedas
{
    public interface IMonedaProxy
    {
        Task<HttpResponseMessage> Create(CreateMonedaRequest request);
        Task<HttpResponseMessage> Update(UpdateMonedaRequest request);
        Task<HttpResponseMessage> Delete(GetByIdMonedaRequest request);
        Task<HttpResponseMessage> Pagination(PaginationQueryRequest request);
        Task<HttpResponseMessage> List(PaginationQueryRequest request);
        Task<HttpResponseMessage> GetById(GetByIdMonedaRequest request);
    }
}
