using Microsoft.EntityFrameworkCore;
using Printers.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Printers.Storage
{
    public class PrintersDbContext : DbContext
    {
        public DbSet<PhysicalPrinter> PhysicalPrinters { get; set; }
        public DbSet<Printer> Printers { get; set; }
        public DbSet<Сartridge> Сartridges { get; set; }

        public PrintersDbContext(DbContextOptions<PrintersDbContext> dbContextOptions) : base(dbContextOptions) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


        }
    }
}
