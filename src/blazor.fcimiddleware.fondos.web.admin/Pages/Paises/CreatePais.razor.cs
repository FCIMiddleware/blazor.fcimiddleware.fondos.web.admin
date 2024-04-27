using blazor.fcimiddleware.fondos.web.admin.Helpers;
using blazor.fcimiddleware.fondos.web.admin.Models.V1.Paises;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace blazor.fcimiddleware.fondos.web.admin.Pages.Paises
{
    public partial class CreatePais
    {
        #region "Public propierties"
        public bool EstaProcesando { get; set; } = false;
        public CreatePaisRequest createPaisRequest { get; set; } = null!;
        #endregion

        #region "Parameter"
        [Parameter]
        [EditorRequired]
        public bool ProcesandoComponentePadre { get; set; }
        [Parameter]
        [EditorRequired]
        public EventCallback<string> ValidSubmit { get; set; }
        [Parameter]
        [EditorRequired]
        public EventCallback<string> CancelSubmit { get; set; }
        [Parameter]
        [EditorRequired]
        public CreatePaisRequest ValidObject { get; set; } = null!;
        #endregion

        protected override void OnParametersSet()
        {
            EstaProcesando = ProcesandoComponentePadre;
            createPaisRequest = ValidObject;
        }

        private string OnProcess()
        {
            return EstaProcesando ? "disabled" : "";
        }

        private async Task OnCancel()
        {
            await CancelSubmit.InvokeAsync(CustomActions.Create);
        }

        protected async Task OnValidSubmit()
        {
            await ValidSubmit.InvokeAsync(CustomActions.Create);
        }
    }
}
