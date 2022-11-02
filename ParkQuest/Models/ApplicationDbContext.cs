using Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParkQuest.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
        {

        }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source = tcp:parkquestdbserver.database.windows.net, 1433; Initial Catalog = ParkQuest_db; User Id = herbertnordson@parkquestdbserver; Password = puc@eixo2!");
            }
        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Estacionamento> Estacionamentos { get; set; }
    }
}
