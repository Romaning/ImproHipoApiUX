using Application.Boundaries;
using ImproHipoApiUX.Filters;
using Microsoft.AspNetCore.Mvc;

namespace ImproHipoApiUX.Controllers.Areas.Independents
{
    [ApiController]
    [Route("api/v1/producto")]
    //[TypeFilter(typeof(ExceptionManagerFilter))]
    public class ProductController : Controller
    {
        /*en todos hay una injections de dependecia de una Interface diferente*/
        protected readonly IProdBoundary iProdBoundary;

        public ProductController(IProdBoundary prodBoundary)
        {
            iProdBoundary = prodBoundary;
        }

        /*START CONCIDENCIA EN LAS DEMAS INTERFACES, SOOLO CAMBIA LA ENTIDAD y la injection dependency*/
        //[Authorize]
        [HttpGet("lista")]
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
                    Data = await iProdBoundary.GetAllImproAsync(),
                };
                return Ok(prepareResponse);
            }
            catch (Exception ex)
            {
                //throw new Exception(ex.Message);
                return BadRequest("modelo de respuesta generico (data and error): " + ex.Message);
            }
        }

        //[Authorize]
        [HttpGet("lista/improcons")]
        public async Task<IActionResult> ListImpro()
        {
            try
            {
                var prepareResponse = new
                {
                    CodeStatus = 200,
                    Success = true,
                    Message = "Todo salió bien",
                    Data = await iProdBoundary.GetAllImproAsync(),
                };
                return Ok(prepareResponse);
            }
            catch (Exception ex)
            {
                //throw new Exception(ex.Message);
                return BadRequest("modelo de respuesta generico (data and error): " + ex.Message);
            }
        }

        //[Authorize]
        [HttpGet("lista/hipotina")]
        public async Task<IActionResult> ListHipo()
        {
            try
            {
                var prepareResponse = new
                {
                    CodeStatus = 200,
                    Success = true,
                    Message = "Todo salió bien",
                    Data = await iProdBoundary.GetAllHipoAsync(),
                };
                return Ok(prepareResponse);
            }
            catch (Exception ex)
            {
                //throw new Exception(ex.Message);
                return BadRequest("modelo de respuesta generico (data and error): " + ex.Message);
            }
        }

        //[Authorize]
        [HttpGet("lista/auxiliar")]
        public async Task<IActionResult> ListAux()
        {
            try
            {
                var prepareResponse = new
                {
                    CodeStatus = 200,
                    Success = true,
                    Message = "Todo salió bien",
                    Data = await iProdBoundary.GetAllAuxAsync(),
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
