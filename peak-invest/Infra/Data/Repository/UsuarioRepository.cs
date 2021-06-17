using Microsoft.AspNetCore.Mvc;
using peak_invest.Domain.Interface;
using System.Collections.Generic;

namespace peak_invest.Infra.Data.Repository
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private List<KeyValuePair<int, string>> Lista { get; set; }
        public UsuarioRepository()
        {
            Lista = ListaUsuarios();
        }
        public ActionResult<string> GetNomeUsuario(int idUsuario)
        {
            var nomeUsuario = this.Lista.Find((usuario) => usuario.Key == idUsuario).Value;
            return nomeUsuario;
        }

        private List<KeyValuePair<int, string>> ListaUsuarios()
        {
            var usuarios = new List<KeyValuePair<int, string>>();
            usuarios.Add(new KeyValuePair<int, string>(1, "João"));
            usuarios.Add(new KeyValuePair<int, string>(2, "Maria"));
            usuarios.Add(new KeyValuePair<int, string>(3, "Ana"));

            return usuarios;
        }
    }
}
