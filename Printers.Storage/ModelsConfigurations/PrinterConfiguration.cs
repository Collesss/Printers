using Microsoft.EntityFrameworkCore;
using Printers.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Printers.Storage.ModelsConfigurations
{
    public class PrinterConfiguration : IEntityTypeConfiguration<Printer>
    {
        void IEntityTypeConfiguration<Printer>.Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Printer> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Manufacturer)
                .HasMaxLength(20)
                .IsRequired();

            builder.HasIndex(p => p.Manufacturer);

            builder.HasAlternateKey(p => p.Model);

            builder.Property(p => p.Model)
                .HasMaxLength(50);
        }
    }
}
