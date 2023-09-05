using System.Runtime.CompilerServices;

namespace ImproHipoApiUX.ConfigureServiceCollections
{
    public static class ControllersConfigsSericeCollections
    {
        public static IServiceCollection AddConttrollerExtend (this IServiceCollection services)
        {
            services.AddMvc()
            //compatibilidad con NewtonsoftJson //se le añadio por si acaso
            .AddNewtonsoftJson(options =>
            {
                /// TODO : ASi ya no tenemos necesidad de configurar en cada Controlador, el formato de json
                // Quita las referencias 
                options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
                // quita del json los params con nulo
                options.SerializerSettings.NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore;
                // configura el tiempo en UTC, tambien se puede definir en Local
                options.SerializerSettings.DateTimeZoneHandling = Newtonsoft.Json.DateTimeZoneHandling.Utc;
                // config para que use CamelCase
                options.UseCamelCasing(false);
            });
            return services;
        }
    }
}
