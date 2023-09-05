using ImproHipoApiUX.Exceptions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Newtonsoft.Json;
//TODO:PIEZA - CON CLASE OWN EXCEPTIONS
namespace ImproHipoApiUX.Filters
{
    //implementamos nuestra Exception filtro
    public class ExceptionManagerFilter : IExceptionFilter
    {
        //puedo obtener datos de mi aplicacion //adicionado
        protected readonly IWebHostEnvironment _webHostEnvironment;
        //datos de los modelos que reciba mis controladores, cual es la informacion que estamos obteniendo de las solicitudes o requests //adicionado
        protected readonly IModelMetadataProvider _modelMetadataProvider;

        public ExceptionManagerFilter(IWebHostEnvironment webHostEnvironment, IModelMetadataProvider modelMetadataProvider)
        {
            _webHostEnvironment = webHostEnvironment;
            _modelMetadataProvider = modelMetadataProvider;
        }

        public void OnException(ExceptionContext context)
        {
            context.HttpContext.Response.StatusCode = 400;
            var responseError = new
            {
                CodeStatus = 400,
                Message = "Falló algo en la aplicación " + _webHostEnvironment.ApplicationName + "la Excepcion del tipo: " + context.Exception.GetType() + " con Mensaje: " + context.Exception.Message,
                IsSuccess = false,
                Data = ""
            };

            if (context.Exception is OwnException)
            {
                context.Result = new JsonResult(responseError);
            }
        }
    }
}
