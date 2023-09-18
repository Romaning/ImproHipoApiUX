using ImproHipoApiUX.Filters;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ImproHipoApiUX.Controllers.Areas.WebPage;

namespace ImproHipoApiUX.Controllers.Areas.Home
{
    [EnableCors("_myAllowSpecificOrigins")]
    [ApiController]
    [Route("")]
    [TypeFilter(typeof(ExceptionManagerFilter))]
    public class HomeController : Controller
    {
        // GET: HomeController
        [HttpGet("")]
        public async Task<IActionResult> Index()
        {
            return RedirectToAction(actionName: "Other"/*, controllerName: "MainController"*/);
            //eturn Ok("hola mundo");
        }

        [HttpGet("other")]
        public async Task<IActionResult> Other()
        {
            return Ok("hola mundo desde otro");
            //eturn Ok("hola mundo");
        }
    }
}
