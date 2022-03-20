using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Printers.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Printers.Storage.ModelsConfigurations
{
    public class СartridgeConfiguration : IEntityTypeConfiguration<Сartridge>
    {
        void IEntityTypeConfiguration<Сartridge>.Configure(EntityTypeBuilder<Сartridge> builder)
        {
            builder.HasKey(c => c.Id);

            builder.HasAlternateKey(c => c.Model);

            builder.Property(c => c.Model)
                .HasMaxLength(50);

            builder.HasMany(c => c.Printers)
                .WithMany(p => p.Cartridges);
        }
    }
}
