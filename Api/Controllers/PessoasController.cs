using Api.Repositorio;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class PessoasController : ControllerBase
    {
        /// <summary>
        /// Pesquisa pessoas cadastradas
        /// </summary>
        [HttpGet]
        [Route("[action]")]
        public JsonResult GetPessoas()
        {
            var lstPessoas = PessoaRepositorio.GetPessoas();

            return new JsonResult(new { Status = 1, Mensagem = string.Empty, pessoas = lstPessoas });
        }
    }
}
