namespace blazor.fcimiddleware.fondos.web.admin.Models.Shared
{
    public class PaginationQueryRequest
    {
        public string? Search { get; set; } = string.Empty;
        public string? Sort { get; set; } = string.Empty;
        public int PageIndex { get; set; }
        public int PageSize { get; set; }
    }
}
