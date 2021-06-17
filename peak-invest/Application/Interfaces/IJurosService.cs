using Microsoft.AspNetCore.Mvc;
using peak_invest.Application.ViewModel;

namespace peak_invest.Application.Interfaces
{
    public interface IJurosService
    {
        ActionResult<decimal> CalculaJuros(CalculaJurosVm queryCompanyPreviewVm);
    }
}
