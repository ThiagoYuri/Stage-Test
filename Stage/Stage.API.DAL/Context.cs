using Microsoft.EntityFrameworkCore;
using Stage.API.DAL.Models;
using System.Diagnostics;

namespace Stage.API.DAL
{
    public class Context:DbContext
    {
        public Context(DbContextOptions<Context> options): base(options)
        {
        }
        public DbSet<Area> Areas { get; set; }
        public DbSet<Processo> Processos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Stage;Data Source=THIAGOYURI;TrustServerCertificate=True");
            }
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {



        }

    }
}
