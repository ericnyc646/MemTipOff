using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace MemTipOff.Web.Models
{
    public partial class memorytipoffdbContext : DbContext
    {
        public memorytipoffdbContext()
        {
        }

        public memorytipoffdbContext(DbContextOptions<memorytipoffdbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<QstoTechnologies> QstoTechnologies { get; set; }
        public virtual DbSet<QuickSheetRatings> QuickSheetRatings { get; set; }
        public virtual DbSet<QuickSheets> QuickSheets { get; set; }
        public virtual DbSet<QuickSheetViews> QuickSheetViews { get; set; }
        public virtual DbSet<TechCategories> TechCategories { get; set; }
        public virtual DbSet<Technologies> Technologies { get; set; }
        public virtual DbSet<UserPurchaseHistory> UserPurchaseHistory { get; set; }
        public virtual DbSet<UserRoleDefinition> UserRoleDefinition { get; set; }
        public virtual DbSet<UserRoles> UserRoles { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        public virtual DbSet<Customer> Customers { get; set; }

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
//                optionsBuilder.UseSqlServer("Server=tcp:memorytipoffdbserver.database.windows.net,1433;Initial Catalog=memorytipoffdb;Persist Security Info=False;User ID=ecesteroowner;Password=7oQ*fgS2pnN5;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30");
//            }
//        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<QstoTechnologies>(entity =>
            {
                entity.ToTable("QStoTechnologies");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                //entity.HasOne(d => d.IdNavigation)
                //    .WithOne(p => p.QstoTechnologies)
                //    .HasForeignKey<QstoTechnologies>(d => d.Id)
                //    .OnDelete(DeleteBehavior.ClientSetNull)
                //    .HasConstraintName("FK_QStoTechnologies_QuickSheets");

                //entity.HasOne(d => d.Technology)
                //    .WithMany(p => p.QstoTechnologies)
                //    .HasForeignKey(d => d.TechnologyId)
                //    .OnDelete(DeleteBehavior.ClientSetNull)
                //    .HasConstraintName("FK_QStoTechnologies_Technologies");
            });

            modelBuilder.Entity<QuickSheetRatings>(entity =>
            {
                entity.Property(e => e.RatingComments).HasMaxLength(1000);

                entity.Property(e => e.RatingDate).HasColumnType("datetime");

                entity.Property(e => e.RatingTitle).HasMaxLength(20);

                //entity.HasOne(d => d.QuickSheet)
                //    .WithMany(p => p.QuickSheetRatings)
                //    .HasForeignKey(d => d.QuickSheetId)
                //    .OnDelete(DeleteBehavior.ClientSetNull)
                //    .HasConstraintName("FK_QuickSheetRatings_QuickSheets");

                //entity.HasOne(d => d.User)
                //    .WithMany(p => p.QuickSheetRatings)
                //    .HasForeignKey(d => d.UserId)
                //    .OnDelete(DeleteBehavior.ClientSetNull)
                //    .HasConstraintName("FK_QuickSheetRatings_Users");
            });

            modelBuilder.Entity<QuickSheets>(entity =>
            {
                entity.Property(e => e.Attribution)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.Property(e => e.Author).HasMaxLength(100);

                entity.Property(e => e.Description).HasMaxLength(2000);

                entity.Property(e => e.Json)
                    .IsRequired()
                    .HasColumnName("JSON")
                    .HasColumnType("text");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<QuickSheetViews>(entity =>
            {
                entity.Property(e => e.Topic).HasMaxLength(20);

                entity.Property(e => e.ViewDateTime).HasColumnType("datetime");

                //entity.HasOne(d => d.QuickSheet)
                //    .WithMany(p => p.QuickSheetViews)
                //    .HasForeignKey(d => d.QuickSheetId)
                //    .OnDelete(DeleteBehavior.ClientSetNull)
                //    .HasConstraintName("FK_QuickSheetViews_QuickSheets");

                //entity.HasOne(d => d.User)
                //    .WithMany(p => p.QuickSheetViews)
                //    .HasForeignKey(d => d.UserId)
                //    .OnDelete(DeleteBehavior.ClientSetNull)
                //    .HasConstraintName("FK_QuickSheetViews_Users");
            });

            modelBuilder.Entity<TechCategories>(entity =>
            {
                entity.Property(e => e.CategoryName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FontAwesomeIcon)
                    .IsRequired()
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<Technologies>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                //entity.HasOne(d => d.Category)
                //    .WithMany(p => p.Technologies)
                //    .HasForeignKey(d => d.CategoryId)
                //    .OnDelete(DeleteBehavior.ClientSetNull)
                //    .HasConstraintName("FK_Technologies_TechCategories");
            });

            modelBuilder.Entity<UserPurchaseHistory>(entity =>
            {
                entity.Property(e => e.PricePaid).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.SaleDate).HasColumnType("datetime");

                //entity.HasOne(d => d.User)
                //    .WithMany(p => p.UserPurchaseHistory)
                //    .HasForeignKey(d => d.UserId)
                //    .OnDelete(DeleteBehavior.ClientSetNull)
                //    .HasConstraintName("FK_UserPurchaseHistory_Users");
            });

            modelBuilder.Entity<UserRoleDefinition>(entity =>
            {
                entity.Property(e => e.RoleName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<UserRoles>(entity =>
            {
                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                //entity.HasOne(d => d.Role)
                //    .WithMany(p => p.UserRoles)
                //    .HasForeignKey(d => d.RoleId)
                //    .OnDelete(DeleteBehavior.ClientSetNull)
                //    .HasConstraintName("FK_UserRoles_UserRoleDefinition");

                //entity.HasOne(d => d.User)
                //    .WithMany(p => p.UserRoles)
                //    .HasForeignKey(d => d.UserId)
                //    .OnDelete(DeleteBehavior.ClientSetNull)
                //    .HasConstraintName("FK_UserRoles_Users");
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.Property(e => e.EmailAddress)
                    .IsRequired()
                    .HasMaxLength(320)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(15);
            });
        }
    }
}
