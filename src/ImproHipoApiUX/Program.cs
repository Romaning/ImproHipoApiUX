using ImproHipoApiUX.ConfigureServiceCollections;

var builder = WebApplication.CreateBuilder(args);


// Add services to the container.
//editamos para que el la serializacaion tenga un formato
builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen (c =>
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

builder.Services.AddAutoMapper(typeof(Program));

//default configures
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();
//app.UseAuthentication();
app.MapControllers();
//HttpRequestPipelineConfigsServiceCollections.InitHttpRequestExtend(app, app.Environment);
app.Run();
