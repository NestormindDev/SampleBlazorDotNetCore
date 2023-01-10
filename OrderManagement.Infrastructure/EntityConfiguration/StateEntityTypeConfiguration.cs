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
    public class StateEntityTypeConfiguration : IEntityTypeConfiguration<State>
    {
        ModelBuilder modelBuilder=null;
        public StateEntityTypeConfiguration(ModelBuilder _modelBuilder)
        {
            modelBuilder = _modelBuilder;
        }
        public void Configure(EntityTypeBuilder<State> tableConfiguration)
        {
            tableConfiguration.ToTable("State");
            tableConfiguration.HasKey(s => s.Id);
            tableConfiguration.Property(s => s.Id).ValueGeneratedOnAdd();
            tableConfiguration.Property(c => c.Id).HasColumnName("Id");
            tableConfiguration.Property(s => s.Name).HasColumnName("Name");
        }
    }
}
