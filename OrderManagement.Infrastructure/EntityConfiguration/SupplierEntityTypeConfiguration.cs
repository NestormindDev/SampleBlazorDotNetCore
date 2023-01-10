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
    class SupplierEntityTypeConfiguration : IEntityTypeConfiguration<Supplier>
    {
        ModelBuilder modelBuilder = null;
        public SupplierEntityTypeConfiguration(ModelBuilder _modelBuilder)
        {
            modelBuilder = _modelBuilder;
        }
        public void Configure(EntityTypeBuilder<Supplier> tableConfiguration)
        {
            tableConfiguration.ToTable("Supplier");
            tableConfiguration.HasKey(s => s.Id);
            tableConfiguration.Property(s => s.Id).ValueGeneratedOnAdd();
            tableConfiguration.Property(s => s.Id).HasColumnName("Id");
            tableConfiguration.Property(s => s.SupplierName).HasColumnName("SupplierName");
            tableConfiguration.Property(s => s.AddressLine1).HasColumnName("AddressLine1");
            tableConfiguration.Property(s => s.AddressLine1).HasColumnName("AddressLine1");
            tableConfiguration.Property(s => s.PostalCode).HasColumnName("PostalCode");
            tableConfiguration.Property(s => s.CityId).HasColumnName("CityId");
            tableConfiguration.Property(s => s.StateId).HasColumnName("StateId");
            tableConfiguration.HasIndex(h => h.StateId).IsUnique(false);
            tableConfiguration.HasIndex(h => h.CityId).IsUnique(false);


            /// <summary>
            ///  Here We define one to one relationship between state and supplier
            /// </summary

            modelBuilder.Entity<Supplier>()
              .HasOne<State>(s => s.State)
              .WithOne(ad => ad.Supplier)
              .HasForeignKey<Supplier>(ad => ad.StateId);

            /// <summary>
            ///  Here We define one to one relationship between city and supplier
            /// </summary

            modelBuilder.Entity<Supplier>()
           .HasOne<City>(s => s.City)
           .WithOne(ad => ad.Supplier)
           .HasForeignKey<Supplier>(ad => ad.CityId);
        }
    }
}
