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

        public virtual DbSet<QuickSheets> QuickSheets { get; set; }

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            if (!optionsBuilder.IsConfigured)
//            {
//                optionsBuilder.UseSqlServer("Server=tcp:memorytipoffdbserver.database.windows.net,1433;Initial Catalog=memorytipoffdb;Persist Security Info=False;User ID=ecesteroowner;Password=7oQ*fgS2pnN5;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
//            }
//        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
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
        }
    }
}
