using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using BookByIdApi.Businness;
using BookByIdApi.Businness.Implementations;
using BookByIdApi.Model.Context;
using Microsoft.EntityFrameworkCore;
using Serilog;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using BookByIdApi.Repository.Generic;
using Microsoft.OpenApi.Models;
using Microsoft.AspNetCore.Rewrite;

namespace BookByIdApi
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        public IWebHostEnvironment Environment { get; }
        public Startup(IConfiguration configuration, IWebHostEnvironment environment)
        {
            Configuration = configuration;
            Environment = environment;
            Log.Logger = new LoggerConfiguration().WriteTo.Console().CreateLogger();
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddControllers();
            //connection
            var connection = Configuration["MySqlConnection:MySqlConnectionString"];
            services.AddDbContext<MySqlContext>(options => options.UseMySql(connection));

            if (Environment.IsDevelopment())
            {
                MigrateDataBase(connection);
            }

            //versionamento da API
            services.AddApiVersioning();

            //documentacao com swager
            services.AddSwaggerGen(c => {
                c.SwaggerDoc("v1",
                        new OpenApiInfo
                        {
                            Title = "ApiRest Aplicação BookById (reserve pelo id)",
                            Version = "v1",
                            Description = "ApiRest desenvolvida para consumo do aplicativo BookById e demais aplicações",
                            Contact = new OpenApiContact
                            {
                                Name = "Kleiton Freitas",
                                Url = new Uri("https://github.com/kleiton-freitas")

                            }
                        }
                    ); 
            });


            //Dependency Injection
            services.AddScoped<IEstablishmentBusinness, EstablishmentBusinnessImplementation>();
            services.AddScoped<ICategory, CategoryImplementation>();
            services.AddScoped(typeof(IRepository<>), typeof(GenericRepository<>));
        }

        //This method gets called by the runtime.Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();
            //documentation with swagger
            app.UseSwagger();

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Rest para aplicativo BookById");
            });

            var option = new RewriteOptions();
            option.AddRedirect("ˆ$", "swagger");
            app.UseRewriter(option);
            //
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
        private void MigrateDataBase(string connection)
        {
            try
            {
                var evolveConnection = new MySql.Data.MySqlClient.MySqlConnection(connection);
                var evolve = new Evolve.Evolve(evolveConnection, msg => Log.Information(msg)) {
                    Locations = new List<string> { "db/migrations", "db/dataset"}
                };
                evolve.Migrate();
            }
            catch (Exception ex)
            {
                Log.Error("Erro ao rodar Migration", ex);
            }
        }
    }
}
