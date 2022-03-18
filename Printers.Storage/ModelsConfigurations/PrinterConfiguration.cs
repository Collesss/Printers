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
            throw new NotImplementedException();
        }
    }
}
