using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace T27_Ejercicio4.Modelos
{
    public class APIContext : DbContext
    {

        public APIContext(DbContextOptions<APIContext> options)
            : base(options)
        {

        }

        public virtual DbSet<Facultad> Facultades { get; set; }
        public virtual DbSet<Investigador> Investigadores { get; set; }
        public virtual DbSet<Equipo> Equipos { get; set; }
        public virtual DbSet<Reserva> Reserva { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Facultad>(entity =>
            {

                entity.ToTable("Facultad");
                entity.HasKey(e => e.Codigo);
                entity.Property(e => e.Codigo).HasColumnName("codigo");

                entity.Property(e => e.Nombre).HasColumnName("nombre")
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);
            });

            modelBuilder.Entity<Investigador>(entity =>
            {

                entity.ToTable("Investigadores");
                entity.HasKey(e => e.DNI);
                entity.Property(e => e.DNI).HasColumnName("dni")
                .HasMaxLength(8);

                entity.Property(e => e.NomApels).HasColumnName("nomApels")
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(false);

                entity.HasOne(d => d.Facultad)
               .WithMany(e => e.Investigadores)
               .HasForeignKey(d => d.IdFacultad)
               .OnDelete(DeleteBehavior.ClientSetNull);

            });

            modelBuilder.Entity<Equipo>(entity =>
            {

                entity.ToTable("Equipos");
                entity.HasKey(e => e.NumSerie);
                entity.Property(e => e.NumSerie).HasColumnName("numSerie")
               .HasMaxLength(4);

                entity.Property(e => e.Nombre).HasColumnName("nombre")
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);

                entity.HasOne(d => d.Facultad)
               .WithMany(e => e.Equipos)
               .HasForeignKey(d => d.IdFacultad)
               .OnDelete(DeleteBehavior.ClientSetNull);

            });

            modelBuilder.Entity<Reserva>(entity =>
            {
                entity.ToTable("Reserva");
                entity.HasKey(e => e.IdInvestigador);
                entity.HasKey(f => f.IdEquipo);


                entity.Property(e => e.IdInvestigador).HasColumnName("dni");

                entity.Property(e => e.IdEquipo).HasColumnName("numSerie");

                entity.Property(e => e.Comienzo).HasColumnName("comienzo")
                .HasColumnType("date");

                entity.Property(e => e.Fin).HasColumnName("fin")
                .HasColumnType("date");


                entity.HasOne(d => d.Investigador)
                .WithMany(e => e.Reservas)
                .HasForeignKey(d => d.IdInvestigador)
                .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Equipo)
                .WithMany(e => e.Reservas)
                .HasForeignKey(d => d.IdEquipo)
                .OnDelete(DeleteBehavior.ClientSetNull);

            });
        }
    }
}
