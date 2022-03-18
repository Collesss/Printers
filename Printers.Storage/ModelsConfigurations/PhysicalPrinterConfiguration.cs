using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Printers.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Printers.Storage.ModelsConfigurations
{
    public class PhysicalPrinterConfiguration : IEntityTypeConfiguration<PhysicalPrinter>
    {
        void IEntityTypeConfiguration<PhysicalPrinter>.Configure(EntityTypeBuilder<PhysicalPrinter> builder)
        {
            builder.HasKey(p => p.Id);

            builder.HasAlternateKey(p => p.PrinterName);

            builder.HasIndex(p => p.Location);

            builder.Property(p => p.Location)
                .HasMaxLength(20);
        }
    }
}
