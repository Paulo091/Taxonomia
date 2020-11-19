using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Taxonomia.API.Models;

namespace Taxonomia.API.Context
{
    public class TaxonomiaContext : DbContext
    {
        public DbSet<Dominio> Dominios { get; set; }
        public DbSet<Reino> Reinos { get; set; }
        public DbSet<Filo> Filos { get; set; }
        public DbSet<Classe> Classes { get; set; }
        public DbSet<Ordem> Ordens { get; set; }
        public DbSet<Familia> Familias { get; set; }
        public DbSet<Genero> Generos { get; set; }
        public DbSet<Especie> Especies { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=PAULO\SQLEXPRESS;Database=TaxonomiaDB;Trusted_Connection=True;");
        }
    }
}
