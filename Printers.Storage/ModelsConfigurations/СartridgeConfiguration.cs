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
            throw new NotImplementedException();
        }
    }
}
