using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using OrderManagement.Api.Host;
using OrderManagement.Infrastructure.Context;
using OrderManagement.Infrastructure.SqlSeed;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace OrderManagement.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                var host = CreateHostBuilder(args)
                    .Build()
                    .MigrateDbContext<OrderManagementContext>((context, services) =>
                    {
                        new OrderManagementContextSeed().SeedAsync(context).Wait();
                    });
                host.Run();
            }
            catch (Exception ex)
            {
                
            }
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Microsoft.Extensions.Hosting.Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
