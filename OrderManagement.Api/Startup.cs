using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using Newtonsoft.Json.Serialization;
using OrderManagement.Api.Service;
using OrderManagement.Api.Service.Interface;
using OrderManagement.Domain.Interface;
using OrderManagement.Infrastructure.Context;
using OrderManagement.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace OrderManagement.Api
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

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "OrderManagement.Api", Version = "v1" });
            });
            AddCustomDbContext(services,Configuration);
            services.AddAutoMapper(typeof(Startup));
            services.AddControllers()
    .AddNewtonsoftJson(options =>
    {
        options.SerializerSettings.ContractResolver = new DefaultContractResolver();
    });
            services.AddTransient<ISupplierService, SupplierService>();
            services.AddTransient<ISupplierRepository, SupplierRepository>();
            services.AddTransient<IStateService, StateService>();
            services.AddTransient<IStateRepository, StateRepository>();
            services.AddTransient<ICityService, CityService>();
            services.AddTransient<ICityRepository, CityRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "OrderManagement.Api v1"));
            }
            app.UseRouting();
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
        public static IServiceCollection AddCustomDbContext( IServiceCollection services, IConfiguration configuration)
        {
            string connectionString = configuration[@"ConnectionStrings:OrderManagementDB"];
            string migrationAssemblyName = "OrderManagement.Infrastructure";
            services.AddDbContext<OrderManagementContext>(options =>
            {
                options.UseSqlServer(connectionString,
                                     sqlServerOptionsAction: sqlOptions =>
                                     {
                                         sqlOptions.MigrationsAssembly(migrationAssemblyName);
                                         sqlOptions.EnableRetryOnFailure(maxRetryCount: 10, maxRetryDelay: TimeSpan.FromSeconds(30), errorNumbersToAdd: null);
                                         sqlOptions.MigrationsHistoryTable("__EFMigrationsHistory");
                                     })
                                     .EnableDetailedErrors()
                                     .EnableSensitiveDataLogging();
            });
            return services;
        }
    }
}
