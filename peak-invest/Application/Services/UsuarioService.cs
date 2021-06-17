
using Microsoft.AspNetCore.Mvc;
using peak_invest.Application.Interfaces;
using peak_invest.Domain.Interface;

namespace peak_invest.Application.Services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepository _usuarioRepository;
        public UsuarioService(IUsuarioRepository usarioRepository)
        {
            _usuarioRepository = usarioRepository;
        }
        public ActionResult<string> GetNomeUsuario(int idUsuario)
        {
            if (idUsuario > 3 || idUsuario < 1)
            {
                throw new System.Exception("Id fora do range");
            }

            var nomeUsuario = this._usuarioRepository.GetNomeUsuario(idUsuario);

            return nomeUsuario;
        }
    }
}
