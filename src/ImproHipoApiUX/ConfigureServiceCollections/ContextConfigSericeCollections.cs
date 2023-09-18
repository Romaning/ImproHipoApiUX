using Persistence.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace ImproHipoApiUX.ConfigureServiceCollections
{
    public static class ContextConfigSericeCollections
    {
        public static IServiceCollection AddContextsExtend(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbImproContext>(optionsBuilder => optionsBuilder
            .UseSqlServer(configuration.GetConnectionString("ConnSqlServerIprocons")
                , optionsBuilder => optionsBuilder.UseQuerySplittingBehavior(QuerySplittingBehavior.SplitQuery)
                )
            .ConfigureWarnings(warnings => warnings.Throw(RelationalEventId.MultipleCollectionIncludeWarning))
            );

            services.AddDbContext<ApplicationDbHipoContext>(optionsBuilder => optionsBuilder
            .UseSqlServer(configuration.GetConnectionString("ConnSqlServerHipotina")
                , optionsBuilder => optionsBuilder.UseQuerySplittingBehavior(QuerySplittingBehavior.SplitQuery)
                )
            .ConfigureWarnings(warnings => warnings.Throw(RelationalEventId.MultipleCollectionIncludeWarning))
            );

            services.AddDbContext<ApplicationDbAuxContext>(optionsBuilder => optionsBuilder.UseSqlServer(configuration.GetConnectionString("ConnSqlServerAuxiliar"), 
                optionsBuilder => optionsBuilder.UseQuerySplittingBehavior(QuerySplittingBehavior.SplitQuery)
                
                )
            .ConfigureWarnings(warnings => warnings.Throw(RelationalEventId.MultipleCollectionIncludeWarning)));
            return services;
        }
    }
}
