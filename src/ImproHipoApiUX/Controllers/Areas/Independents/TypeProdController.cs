using Application.Boundaries;
using ImproHipoApiUX.Filters;
using Microsoft.AspNetCore.Mvc;

namespace ImproHipoApiUX.Controllers.Areas.Independents
{
    [ApiController]
    [Route("api/v1/tipo_producto")]
    //[TypeFilter(typeof(ExceptionManagerFilter))]
    public class TypeProdController : Controller
    {
        /*en todos hay una injections de dependecia de una Interface diferente*/
        protected readonly ITypeProdBoundary iTypeProdBoundary;

        public TypeProdController(ITypeProdBoundary _iTypeProdBoundary)
        {
            iTypeProdBoundary = _iTypeProdBoundary;
        }

        /*START CONCIDENCIA EN LAS DEMAS INTERFACES, SOOLO CAMBIA la injection dependency*/
        //[Authorize]
        [HttpGet("lista")]
        public async Task<IActionResult> lista()
        {
            //lista briuta sin diferenciar las de la cual BD es, podria existir repetidos
            try
            {
                var prepareResponse = new
                {
                    CodeStatus = 200,
                    Success = true,
                    Message = "Todo salió bien",
                    Data = await iTypeProdBoundary.GetAllRefactorDistinctEnterprisesAsync(),
                };
                return Ok(prepareResponse);
            }
            catch (Exception ex)
            {
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
                    Data = await iTypeProdBoundary.GetAllImproAsync(),
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
                    Data = await iTypeProdBoundary.GetAllHipoAsync(),
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
                    Data = await iTypeProdBoundary.GetAllAuxAsync(),
                };
                return Ok(prepareResponse);
            }
            catch (Exception ex)
            {
                //throw new Exception(ex.Message);
                return BadRequest("modelo de respuesta generico (data and error): " + ex.Message);
            }
        }
        /*END CONCIDENCIA EN LAS DEMAS INTERFACES, SOOLO CAMBIA la injection dependency*/

    }
}
