using blazor.fcimiddleware.fondos.web.admin.Models.Components.DataGrid;
using blazor.fcimiddleware.fondos.web.admin.Models.Shared;
using blazor.fcimiddleware.fondos.web.admin.Models.V1.Paises;
using Microsoft.AspNetCore.Components;

namespace blazor.fcimiddleware.fondos.web.admin.Pages.Paises
{
    public partial class DataGridPais
    {
        string _orderDesc = "fa-angle-up";
        string _orderCafci = "fa-angle-up";
        string _search = "";
        string _sort = "";
        int _countRegister = 1;
        int _pageCount = 1;
        bool isLoading;
        int _pageIndex = 1;
        int _pageSize = 10;
        int _firstPage = 1;
        int _lastPage = 1;

        private List<Pais> dataListPais { get; set; } = new List<Pais>();
        private List<DataGridColumns> dataGridColumns { get; set; } = new List<DataGridColumns>();
        
        [Parameter] 
        public List<DataGridColumns> GridColumns { get; set; } = new List<DataGridColumns>();        
        [Parameter]
        [EditorRequired]
        public PaginationQueryResponse<Pais> DataListPais { get; set; }
        [Parameter] 
        public EventCallback OnToRefresh {  get; set; }
        [Parameter]
        public EventCallback OnToCreate { get; set; }
        [Parameter]
        public EventCallback<(int, bool)> OnToEdit { get; set; }


        protected override void OnParametersSet()
        {
            dataGridColumns = GridColumns;
            if (DataListPais != null)
            {
                dataListPais = DataListPais.Data.ToList();
                _countRegister = DataListPais.Count;
                _firstPage = 1;
                _lastPage = DataListPais.PageCount;
                _pageCount = DataListPais.PageCount;
            }
        }

        #region "Metodos"
        protected async Task OnGoToCreate()
        {
            await OnToCreate.InvokeAsync();
        }

        protected async Task OnGoToRefresh()
        {
            await OnToRefresh.InvokeAsync();
        }

        protected async Task OnGoToSearch()
        {

        }

        protected async Task OnChangeOrderDesc()
        {

        }

        protected async Task OnChangeOrderCafci()
        {

        }

        protected async Task OnGoToView(int value)
        {

        }

        protected async Task OnGoToEdit(int value, bool isDeleted)
        {
            await OnToEdit.InvokeAsync((value, isDeleted));
        }

        protected string OnStatus(bool isDeleted)
        {
            return isDeleted ? "disabled" : "";
        }

        protected async Task OnGoToDelete(int value, bool isDeleted)
        {

        }

        protected async Task OnFirstPage()
        {

        }

        protected async Task OnPageIndex(int value)
        {

        }

        protected async Task OnLastPage()
        {

        }
        #endregion
    }
}
