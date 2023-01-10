using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OrderManagement.Domain.AggregatesModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagement.Infrastructure.EntityConfiguration
{
    public class CityEntityTypeConfiguration : IEntityTypeConfiguration<City>
    {
        ModelBuilder modelBuilder = null;
        public CityEntityTypeConfiguration(ModelBuilder _modelBuilder)
        {
            modelBuilder = _modelBuilder;
        }
        public void Configure(EntityTypeBuilder<City> tableConfiguration)
        {
            tableConfiguration.ToTable("City");
            tableConfiguration.HasKey(s => s.Id);
            tableConfiguration.Property(s => s.Id).ValueGeneratedOnAdd();
            tableConfiguration.Property(s => s.Id).HasColumnName("Id");
            tableConfiguration.Property(s => s.Name).HasColumnName("Name");
            tableConfiguration.Property(s => s.StateId).HasColumnName("StateId");

            // define  one to many relationship between city and state
            modelBuilder.Entity<City>()
           .HasOne<State>(s => s.State)
           .WithMany(g => g.City)
           .HasForeignKey(s => s.StateId);
        }
    }
}
