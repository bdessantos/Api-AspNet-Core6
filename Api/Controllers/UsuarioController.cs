using Dal.Data;
using Microsoft.AspNetCore.Mvc;
using System.Data.Entity.Core;

namespace Api.Controllers
{
    public class UsuarioController : Controller
    {
        Context _context;

        public UsuarioController(Context context)
        {
            _context = context;
        }

        /// <summary>
        /// Pesquisa usuário cadastrado
        /// </summary>
        [HttpGet]
        [Route("[action]/id")]
        public JsonResult Get(int id)
        {
            try
            {
                var usuario = _context.Usuario.Where(w => w.Id == id).FirstOrDefault();
            }
            catch (EntityException ex)
            {
                return new JsonResult(new { Status = 0, Mensagem = ex.Message });
            }
            catch (Exception ex)
            {
                return new JsonResult(new { Status = 0, Mensagem = ex.Message });
            }


        }
    }
}
