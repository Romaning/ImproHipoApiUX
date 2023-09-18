using ImproHipoApiUX.ConfigureServiceCollections;
using ImproHipoApiUX.MemoryCaching.Implement;
using ImproHipoApiUX.MemoryCaching.Service;

var builder = WebApplication.CreateBuilder(args);

var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

// Add services to the container.
//editamos para que el la serializacaion tenga un formato
builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.ResolveConflictingActions(apiDescriptions => apiDescriptions.First());
    // Other Swashbuckle configuration
});

// Newtonsoft
ControllersConfigsSericeCollections.AddConttrollerExtend(builder.Services);

// Contexts
ContextConfigSericeCollections.AddContextsExtend(builder.Services, builder.Configuration);

//Services and Repositories
InjectionObejctsConfigsServiceCollectionsIoC.AddInjectionDependecy(builder.Services);

//CORS

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: MyAllowSpecificOrigins,
                      policy =>
                      {
                          policy.WithOrigins("http://localhost", "http://18.220.88.59", "http://18.220.88.59");
                          policy.AllowAnyMethod()
                                .AllowAnyHeader()
                                .SetIsOriginAllowed(origin => true) // allow any origin
                                .AllowCredentials();
                      });
});
//servicios
builder.Services.AddScoped<ICacheService, CacheServiceImpl>();

builder.Services.AddAutoMapper(typeof(Program));

//default configures
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors(MyAllowSpecificOrigins);
app.UseAuthorization();
//app.UseAuthentication();
app.MapControllers();
//HttpRequestPipelineConfigsServiceCollections.InitHttpRequestExtend(app, app.Environment);
app.Run();
