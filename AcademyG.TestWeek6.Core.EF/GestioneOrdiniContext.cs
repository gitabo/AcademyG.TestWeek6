using AcademyG.TestWeek6.Core.EF.Configuration;
using AcademyG.TestWeek6.Core.Model;
using Microsoft.EntityFrameworkCore;
using System;

namespace AcademyG.TestWeek6.Core.EF
{
    public class GestioneOrdiniContext : DbContext
    {
        public GestioneOrdiniContext(DbContextOptions<GestioneOrdiniContext> options) : base(options) { }   // ASP.NET Core

        public GestioneOrdiniContext() : base() { }   // WCF

        public DbSet<Cliente> Clienti { get; set; }

        public DbSet<Ordine> Ordini { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            if (!options.IsConfigured)
            {
                string connectionString = "Server=(localdb)\\mssqllocaldb;Database=GestioneOrdini;Integrated Security=true;MultipleActiveResultSets=True;";
                options.UseSqlServer(connectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ClienteConfiguration());
            modelBuilder.ApplyConfiguration(new OrdineConfiguration());
        }

    }
}
