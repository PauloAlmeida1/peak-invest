using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace peak_invest.Domain.Interface
{
    public interface IUsuarioRepository
    {
        ActionResult<string> GetNomeUsuario(int idUsuario);
    }
}
