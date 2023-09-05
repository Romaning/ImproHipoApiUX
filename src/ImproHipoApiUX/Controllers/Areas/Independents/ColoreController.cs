using Application.Boundaries;
using Microsoft.AspNetCore.Mvc;

namespace ImproHipoApiUX.Controllers.Areas.Independents
{
    [ApiController]
    [Route("api/v1/colores")]
    public class ColoreController : Controller
    {
        [HttpGet("")]
        public async Task<IActionResult> Index()
        {
            try
            {
                //la lista de clases solo hace la union de las 3 listas en bruto, podrian existir ID duplicados
                var prepareResponse = new
                {
                    CodeStatus = 200,
                    Success = true,
                    Message = "Todo salió bien",
                    Data = new { Descripcion = "rojo"},
                };
                return Ok(prepareResponse);
            }
            catch (Exception ex)
            {
                //throw new Exception(ex.Message);
                return BadRequest("modelo de respuesta generico (data and error): " + ex.Message);
            }
        }
    }
}
