

using Microsoft.AspNetCore.Mvc;
using peak_invest.Application.Interfaces;
using peak_invest.Application.ViewModel;

namespace peak_invest.Application.Services
{
    public class JurosService : IJurosService
    {
        public ActionResult<decimal> CalculaJuros(CalculaJurosVm queryCompanyPreviewVm)
        {
            decimal total = queryCompanyPreviewVm.parcelas * queryCompanyPreviewVm.valor;
            decimal result = total + (total * 0.05m);

            return result;
        }

    }
}
