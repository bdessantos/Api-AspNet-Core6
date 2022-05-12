using Api.AuthJWTBearer;
using Api.Repositorio;
using Dal.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        /// <summary>
        /// Realiza authenticação do usuário
        /// </summary>
        [AllowAnonymous]
        [HttpPost]
        [Route("[action]")]
        public JsonResult Autenticacao(Usuario usuarioAutenticar)
        {
            var usuario = UsuarioRepositorio.Get(usuarioAutenticar.Nome, usuarioAutenticar.Senha);

            if(usuario == null)
                return new JsonResult(new { Status = 0, Mensagem = "Usuário não encontrado!" });

            var usuarioAutenticao = new UsuarioAutenticao(usuario.Id, usuario.Nome, usuario.Senha, String.Empty);

            var token =  ServicoToken.GerarToken(usuarioAutenticao);

            usuarioAutenticao.Chave = token;
            usuario.Senha = String.Empty;


            return new JsonResult(new { Status = 1, Mensagem = "Autenticação realizada com sucesso!", usuario = usuarioAutenticao });

        }
    }
}
