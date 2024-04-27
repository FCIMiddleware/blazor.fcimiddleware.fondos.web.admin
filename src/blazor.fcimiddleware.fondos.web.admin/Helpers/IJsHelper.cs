using Microsoft.JSInterop;

namespace blazor.fcimiddleware.fondos.web.admin.Helpers
{
    public static class IJsHelper
    {
        public static async ValueTask ToastrSuccess(this IJSRuntime JSRuntime, string message, string tittle)
        {
            await JSRuntime.InvokeVoidAsync("ShowToastr", "success", message, tittle);
        }

        public static async ValueTask ToastrError(this IJSRuntime JSRuntime, string message, string tittle)
        {
            await JSRuntime.InvokeVoidAsync("ShowToastr", "error", message, tittle);
        }

        public static async ValueTask SeewtAlertSuccess(this IJSRuntime JSRuntime, string message, string tittle)
        {
            await JSRuntime.InvokeVoidAsync("ShowSwal", "success", message, tittle);
        }

        public static async ValueTask SeewtAlertError(this IJSRuntime JSRuntime, string message, string tittle)
        {
            await JSRuntime.InvokeVoidAsync("ShowSwal", "error", message, tittle);
        }
    }
}
