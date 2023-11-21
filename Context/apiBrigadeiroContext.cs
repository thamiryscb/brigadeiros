using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using apiBrigadeiro.Model;
using brigadeiros.Model;

namespace apiBrigadeiro.Context
{
    public class apiBrigadeiroContext : DbContext
    {
        public apiBrigadeiroContext(DbContextOptions options) : base(options) {}
        public DbSet<Cliente>? Clientes { get; set; }
        public DbSet<Compras>? Compras {get; set;}
        public DbSet<Doce>? Doces {get; set;}
        public DbSet<Entrega> Entregas {get; set;}
        public DbSet<Avaliação> Avaliações { get; internal set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.LowercaseRelationalTableAndPropertyNames();
        }
    }
}