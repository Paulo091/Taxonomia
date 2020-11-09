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

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=PAULO\SQLEXPRESS;Database=TaxonomiaDB;Trusted_Connection=True;");
        }
    }
}
