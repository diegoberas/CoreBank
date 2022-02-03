using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CoreBanking.Models
{
    public partial class DBCoreContext : DbContext
    {
        public DBCoreContext()
        {
        }

        public DBCoreContext(DbContextOptions<DBCoreContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TblClientes> TblClientes { get; set; }
        public virtual DbSet<TblCuentas> TblCuentas { get; set; }
        public virtual DbSet<TblPrestamos> TblPrestamos { get; set; }
        public virtual DbSet<TblTransaccion> TblTransaccion { get; set; }
        public virtual DbSet<TblUsuarios> TblUsuarios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TblClientes>(entity =>
            {
                entity.ToTable("tblClientes");

                entity.Property(e => e.Apellido)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Cedula)
                    .IsRequired()
                    .HasMaxLength(11);

                entity.Property(e => e.CorreoElectronico)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Telefono)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Usuario)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TblCuentas>(entity =>
            {
                entity.ToTable("tblCuentas");

                entity.Property(e => e.Balance)
                    .HasColumnType("decimal(18, 0)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.Cedula)
                    .IsRequired()
                    .HasMaxLength(11);

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.Moneda)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Propietario)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.UltimaVisita)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<TblPrestamos>(entity =>
            {
                entity.ToTable("tblPrestamos");

                entity.Property(e => e.Apellido)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CantidadSolicitada).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Cedula)
                    .IsRequired()
                    .HasMaxLength(11);

                entity.Property(e => e.CorreoElectronico)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Telefono)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<TblTransaccion>(entity =>
            {
                entity.ToTable("tblTransaccion");

                entity.Property(e => e.Cedula)
                    .IsRequired()
                    .HasMaxLength(11);

                entity.Property(e => e.FechaTransaccion)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IdCuentaEmisora)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.IdCuentaReceptora)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.NombreProducto)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.PrecioProducto).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.TipoTransaccion)
                    .IsRequired()
                    .HasMaxLength(1);
            });

            modelBuilder.Entity<TblUsuarios>(entity =>
            {
                entity.ToTable("tblUsuarios");

                entity.Property(e => e.Contraseña)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TipoUsuario)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Usuario)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
