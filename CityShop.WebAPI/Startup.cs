using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using CityShop.Data.IRepositories;
using CityShop.Data.Repositories;
using CityShop.Service.Dxos;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace CityShop.WebAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy(name: "PublicWebAppOrigins",
                    builder =>
                    {
                        builder.AllowAnyOrigin()
                        .AllowAnyMethod()
                        .AllowAnyHeader();
                    });
            });
            services.AddControllers();
            services.AddSwaggerDocument();

            services.AddScoped<IProductRepository, InMemoryProductRespository>();
            services.AddScoped<IProductDxos, ProductDxos>();
            var assembly = AppDomain.CurrentDomain.Load("CityShop.Service");
            services.AddMediatR(assembly);

            services.AddLogging();
        }


        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseCors();

            app.UseAuthorization();


            //Enabling Cors policy for CityShop.Web.
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers()
                    .RequireCors("PublicWebAppOrigins");
            });

            app.UseOpenApi();
            app.UseSwaggerUi3();
        }
    }
}
