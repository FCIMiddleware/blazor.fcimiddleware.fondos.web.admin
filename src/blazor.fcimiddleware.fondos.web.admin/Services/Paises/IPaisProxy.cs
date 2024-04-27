using blazor.fcimiddleware.fondos.web.admin.Models.Shared;
using blazor.fcimiddleware.fondos.web.admin.Models.V1.Paises;

namespace blazor.fcimiddleware.fondos.web.admin.Services.Paises
{
    public interface IPaisProxy
    {
        Task<HttpResponseMessage> Create(CreatePaisRequest request);
        Task<HttpResponseMessage> Update(UpdatePaisRequest request);
        Task<HttpResponseMessage> Delete(GetByIdPaisRequest request);
        Task<HttpResponseMessage> Pagination(PaginationQueryRequest request);
        Task<HttpResponseMessage> List(PaginationQueryRequest request);
        Task<HttpResponseMessage> GetById(GetByIdPaisRequest request);
    }
}
