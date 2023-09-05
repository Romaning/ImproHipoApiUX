namespace ImproHipoApiUX.ConfigureServiceCollections
{
    public static class HttpRequestPipelineConfigsServiceCollections
    {
        public static void InitHttpRequestExtend(this IApplicationBuilder app, IWebHostEnvironment env)
        {
            // Configure the HTTP request pipeline.
            if (env.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();
            //app.UseAuthentication();
            app.UseAuthorization();

            // Cambiamos por otra linea app.MapControllers();
            app.UseEndpoints(endpoints => { endpoints.MapControllers(); });

        }
    }
}
