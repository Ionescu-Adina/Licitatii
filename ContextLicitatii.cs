using Licitatii.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Licitatii
{
    public class ContextLicitatii : DbContext
    {
        public DbSet<Licitatie> Licitatii { get; set; }
        public DbSet<Oferta> Oferte { get; set; }
        public DbSet<Candidat> Candidati { get; set; }

        public ContextLicitatii()
        {
            try
            {
               Database.Migrate();
            }
            catch (Exception ex)
            {
               Console.WriteLine("Database already exists.");
            }
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlite("Data Source=licitatii.db");
    }
}
