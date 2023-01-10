using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using OrderManagement.Domain.AggregatesModel;
using OrderManagement.Domain.Interface;
using OrderManagement.Infrastructure.EntityConfiguration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagement.Infrastructure.Context
{
    public class OrderManagementContext: DbContext, IUnitOfWork
    {
        //DB set
        public DbSet<State> State { get; set; }
        public DbSet<City> City { get; set; }
        public DbSet<Supplier> Supplier { get; set; }


        // class variable
        private readonly IConfiguration _configuration;
        public OrderManagementContext(DbContextOptions<OrderManagementContext> options, IConfiguration configuration) : base(options)
        {
            _configuration = configuration;
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            /// <summary>
            ///  here we have configure the all entity and its property like class name and class property name and its type and size
            /// </summary>

            builder.ApplyConfiguration(new StateEntityTypeConfiguration(builder));
            builder.ApplyConfiguration(new CityEntityTypeConfiguration(builder));
            builder.ApplyConfiguration(new SupplierEntityTypeConfiguration(builder));
        }
        public async Task<bool> Save()
        {
            var result = await base.SaveChangesAsync();
            return true;
        }
    }
}
