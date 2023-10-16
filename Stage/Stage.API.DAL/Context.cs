using Microsoft.EntityFrameworkCore;
using Stage.API.DAL.Models;
using System.Diagnostics;

namespace Stage.API.DAL
{
    public class Context: DbContext
    {
        public DbSet<Empresa> Empresas { get; set; }
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
            #region Processo
            modelBuilder.Entity<Processo>()
            .HasOne(e => e.Area)
            .WithMany()
            .HasForeignKey(e => e.PK_Area)
            .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Processo>()
           .HasOne(e => e.Empresa)
           .WithMany()
           .HasForeignKey(e => e.PK_Empresa)
           .OnDelete(DeleteBehavior.NoAction);
            #endregion

            #region AreaEmpresa
            modelBuilder.Entity("AreaEmpresa", b =>
            {
                b.HasOne("Stage.API.DAL.Models.Empresa", null)
                    .WithMany()
                    .HasForeignKey("PK_Area")
                    .OnDelete(DeleteBehavior.NoAction)
                    .IsRequired();

                b.HasOne("Stage.API.DAL.Models.Area", null)
                    .WithMany()
                    .HasForeignKey("PK_Empresa")
                    .OnDelete(DeleteBehavior.NoAction)
                    .IsRequired();
            });
            #endregion
        }

    }
}
