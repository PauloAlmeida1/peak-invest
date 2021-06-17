using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace peak_invest.Application.Interfaces
{
    public interface IUsuarioService
    {
        ActionResult<string> GetNomeUsuario(int idUsuario);

    }
}
