using Microsoft.Extensions.Hosting;
using OrderManagement.Domain.AggregatesModel;
using OrderManagement.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagement.Infrastructure.SqlSeed
{
    public class OrderManagementContextSeed
    {

        public async Task SeedAsync(OrderManagementContext context)
        {
            var _env = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
            try
            {
                if (_env == "Development")
                {
                    if (!context.State.Any())
                    {
                        await context.State.AddRangeAsync(AddState());
                        await context.SaveChangesAsync();
                    }
                    if (!context.City.Any())
                    {
                        await context.City.AddRangeAsync(AddCity());
                        await context.SaveChangesAsync();
                    }
                    if (!context.Supplier.Any())
                    {
                        await context.Supplier.AddRangeAsync(AddSupplier());
                        await context.SaveChangesAsync();
                    }

                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private IEnumerable<State> AddState()
        {
            return new List<State>()
            {
                 new State(){
                     Name="Gujarat"
                 },
                 new State(){
                     Name="Haryana"
                 },
                 new State(){
                     Name="Himachal Pradesh"
                 },
                new State(){
                     Name="Jharkhand"
                 }
            };
        }
        private IEnumerable<City> AddCity()
        {
            return new List<City>()
            {
                 new City(){
                     Name="Ahmedabad",
                     StateId=1
                 },
                 new City(){
                     Name="Surat",
                      StateId=1
                 },
                 new City(){
                     Name="Panipat",
                       StateId=2
                 },
                new City(){
                     Name="Sonipat",
                      StateId=2
                 },
                 new City(){
                     Name="Shimla",
                     StateId=3
                 },
                 new City(){
                     Name="Dharamsala",
                      StateId=3
                 },
                 new City(){
                     Name="Jamshedpur",
                       StateId=4
                 },
                 new City(){
                     Name="Dhanbad",
                       StateId=4
                 }
            };
        }
        private IEnumerable<Supplier> AddSupplier()
        {
            return new List<Supplier>()
            {
                 new Supplier("Sunil Kumar","House No 110","Panipat","132103",2,1){
                 }
            };
        }
    }
}
