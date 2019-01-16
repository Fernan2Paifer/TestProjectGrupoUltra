using Microsoft.EntityFrameworkCore;

namespace ApiCajaAhorro.Models
    {
    public partial class CajaAhorroDBContext : DbContext
        {
        public CajaAhorroDBContext()
            {
            }

        public CajaAhorroDBContext(DbContextOptions<CajaAhorroDBContext> options)
            : base(options)
            {
            }

        public virtual DbSet<AspNetRoleClaims> AspNetRoleClaims { get; set; }
        public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUserRoles> AspNetUserRoles { get; set; }
        public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }
        public virtual DbSet<AspNetUserTokens> AspNetUserTokens { get; set; }
        public virtual DbSet<EAhorro> EAhorro { get; set; }
        public virtual DbSet<EPrestamo> EPrestamo { get; set; }
        public virtual DbSet<ETrabajador> ETrabajador { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
            modelBuilder.Entity<AspNetRoleClaims>(entity =>
            {
                entity.HasIndex(e => e.RoleId);

                entity.Property(e => e.RoleId).IsRequired();

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetRoleClaims)
                    .HasForeignKey(d => d.RoleId);
            });

            modelBuilder.Entity<AspNetRoles>(entity =>
            {
                entity.HasIndex(e => e.NormalizedName)
                    .HasName("RoleNameIndex");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.NormalizedName).HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetUserClaims>(entity =>
            {
                entity.HasIndex(e => e.UserId);

                entity.Property(e => e.UserId).IsRequired();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserClaims)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserLogins>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });

                entity.HasIndex(e => e.UserId);

                entity.Property(e => e.UserId).IsRequired();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserLogins)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserRoles>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId });

                entity.HasIndex(e => e.RoleId);

                entity.HasIndex(e => e.UserId);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.RoleId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUsers>(entity =>
            {
                entity.HasIndex(e => e.NormalizedEmail)
                    .HasName("EmailIndex");

                entity.HasIndex(e => e.NormalizedUserName)
                    .HasName("UserNameIndex")
                    .IsUnique();

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.NormalizedEmail).HasMaxLength(256);

                entity.Property(e => e.NormalizedUserName).HasMaxLength(256);

                entity.Property(e => e.UserName).HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetUserTokens>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name });
            });

            modelBuilder.Entity<EAhorro>(entity =>
            {
                entity.HasKey(e => e.IdAhorro);

                entity.ToTable("E_Ahorro");

                entity.Property(e => e.IdAhorro).HasColumnName("idAhorro");

                entity.Property(e => e.Fecha)
                    .HasColumnName("fecha")
                    .HasColumnType("date");

                entity.Property(e => e.FkTrabajador).HasColumnName("Fk_trabajador");

                entity.HasOne(d => d.FkTrabajadorNavigation)
                    .WithMany(p => p.EAhorro)
                    .HasForeignKey(d => d.FkTrabajador)
                    .HasConstraintName("Fk_ahorroTrabajador");
            });

            modelBuilder.Entity<EPrestamo>(entity =>
            {
                entity.HasKey(e => e.IdPrestamo);

                entity.ToTable("E_Prestamo");

                entity.Property(e => e.IdPrestamo).HasColumnName("idPrestamo");

                entity.Property(e => e.Fecha)
                    .HasColumnName("fecha")
                    .HasColumnType("date");

                entity.Property(e => e.FkTrabajador).HasColumnName("Fk_Trabajador");

                entity.Property(e => e.Monto).HasColumnName("monto");

                entity.HasOne(d => d.FkTrabajadorNavigation)
                    .WithMany(p => p.EPrestamo)
                    .HasForeignKey(d => d.FkTrabajador)
                    .HasConstraintName("Fk_PrestamoTrabajador");
            });

            modelBuilder.Entity<ETrabajador>(entity =>
            {
                entity.HasKey(e => e.IdTrabajador);

                entity.ToTable("E_Trabajador");

                entity.Property(e => e.IdTrabajador).HasColumnName("idTrabajador");

                entity.Property(e => e.FechaInicioRl)
                    .HasColumnName("fechaInicioRL")
                    .HasColumnType("date");

                entity.Property(e => e.FkUser)
                    .HasColumnName("FK_User")
                    .HasMaxLength(450);

                entity.Property(e => e.Inscrito).HasColumnName("inscrito");

                entity.Property(e => e.MontoAinicial).HasColumnName("montoAinicial");

                entity.HasOne(d => d.FkUserNavigation)
                    .WithMany(p => p.ETrabajador)
                    .HasForeignKey(d => d.FkUser)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_UserTrabajador");
            });
            }
        }
    }
