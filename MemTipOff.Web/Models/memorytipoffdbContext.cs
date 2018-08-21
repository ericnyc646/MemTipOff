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

        public virtual DbSet<AspNetRoleClaims> AspNetRoleClaims { get; set; }
        public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }
        public virtual DbSet<Customers> Customers { get; set; }
        public virtual DbSet<Faqcategories> Faqcategories { get; set; }
        public virtual DbSet<Faqs> Faqs { get; set; }
        public virtual DbSet<OrderLineDetail> OrderLineDetail { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<Pricing> Pricing { get; set; }
        public virtual DbSet<QstoTechnologies> QstoTechnologies { get; set; }
        public virtual DbSet<QuickSheetRatings> QuickSheetRatings { get; set; }
        public virtual DbSet<QuickSheets> QuickSheets { get; set; }
        public virtual DbSet<QuickSheetViews> QuickSheetViews { get; set; }
        public virtual DbSet<TechCategories> TechCategories { get; set; }
        public virtual DbSet<Technologies> Technologies { get; set; }
        public virtual DbSet<UserPurchaseHistory> UserPurchaseHistory { get; set; }

        // Unable to generate entity type for table 'dbo.AspNetUserTokens'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.AspNetUserRoles'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=tcp:memorytipoffdbserver.database.windows.net,1433;Initial Catalog=memorytipoffdb;Persist Security Info=False;User ID=ecesteroowner;Password=7oQ*fgS2pnN5;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AspNetRoleClaims>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.RoleId).HasMaxLength(450);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetRoleClaims)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<AspNetRoles>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.NormalizedName).HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetUserClaims>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.UserId).HasMaxLength(450);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserClaims)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<AspNetUserLogins>(entity =>
            {
                entity.HasKey(e => e.LoginProvider);

                entity.Property(e => e.LoginProvider).ValueGeneratedNever();

                entity.Property(e => e.ProviderKey).HasMaxLength(450);

                entity.Property(e => e.UserId).HasMaxLength(450);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserLogins)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<AspNetUsers>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.NormalizedEmail).HasMaxLength(256);

                entity.Property(e => e.NormalizedUserName).HasMaxLength(256);

                entity.Property(e => e.PictureUrl).HasColumnName("PictureURL");

                entity.Property(e => e.UserName).HasMaxLength(256);
            });

            modelBuilder.Entity<Customers>(entity =>
            {
                entity.Property(e => e.IdentityId).HasMaxLength(450);

                entity.HasOne(d => d.Identity)
                    .WithMany(p => p.Customers)
                    .HasForeignKey(d => d.IdentityId)
                    .OnDelete(DeleteBehavior.Cascade);
            });

            //modelBuilder.Entity<Faqcategories>(entity =>
            //{
            //    entity.ToTable("FAQCategories");

            //    entity.Property(e => e.CategoryName)
            //        .IsRequired()
            //        .HasMaxLength(25);

            //    entity.Property(e => e.DisplayCategory)
            //        .IsRequired()
            //        .HasDefaultValueSql("((1))");
            //});

            //modelBuilder.Entity<Faqs>(entity =>
            //{
            //    entity.ToTable("FAQs");

            //    entity.Property(e => e.Answer)
            //        .IsRequired()
            //        .HasColumnType("text");

            //    entity.Property(e => e.DisplayItem)
            //        .IsRequired()
            //        .HasDefaultValueSql("((1))");

            //    entity.Property(e => e.Faqname)
            //        .IsRequired()
            //        .HasColumnName("FAQName")
            //        .HasMaxLength(50)
            //        .IsUnicode(false);

            //    entity.Property(e => e.Question)
            //        .IsRequired()
            //        .HasMaxLength(200);

            //    entity.HasOne(d => d.Category)
            //        .WithMany(p => p.Faqs)
            //        .HasForeignKey(d => d.CategoryId)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK_FAQs_FAQCategories");
            //});

            modelBuilder.Entity<OrderLineDetail>(entity =>
            {
                entity.Property(e => e.Price).HasColumnType("decimal(18, 0)");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.OrderLineDetail)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrderLineDetail_Orders");
            });

            modelBuilder.Entity<Orders>(entity =>
            {
                entity.Property(e => e.ApprovalCode)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.BillingCity)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.BillingCountry)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BillingMethod)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.BillingPhoneNumber)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.BillingPostalCode)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.BillingStateProvince)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.BillingStreetAddress1)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.BillingStreetAddress2)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.OrderDate).HasColumnType("datetime");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.UserIpaddress)
                    .IsRequired()
                    .HasColumnName("UserIPAddress")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<Pricing>(entity =>
            {
                entity.Property(e => e.PriceStartDate).HasColumnType("datetime");

                entity.Property(e => e.Qsid).HasColumnName("QSId");

                entity.Property(e => e.SaleEndDate).HasColumnType("datetime");

                entity.HasOne(d => d.Qs)
                    .WithMany(p => p.Pricing)
                    .HasForeignKey(d => d.Qsid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Pricing_QuickSheets");
            });

            modelBuilder.Entity<QstoTechnologies>(entity =>
            {
                entity.ToTable("QStoTechnologies");

                entity.HasOne(d => d.QuickSheet)
                    .WithMany(p => p.QstoTechnologies)
                    .HasForeignKey(d => d.QuickSheetId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_QStoTechnologies_QuickSheets1");

                entity.HasOne(d => d.Technology)
                    .WithMany(p => p.QstoTechnologies)
                    .HasForeignKey(d => d.TechnologyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_QStoTechnologies_Technologies");
            });

            modelBuilder.Entity<QuickSheetRatings>(entity =>
            {
                entity.Property(e => e.RatingComments).HasMaxLength(1000);

                entity.Property(e => e.RatingDate).HasColumnType("datetime");

                entity.Property(e => e.RatingTitle).HasMaxLength(20);

                entity.HasOne(d => d.QuickSheet)
                    .WithMany(p => p.QuickSheetRatings)
                    .HasForeignKey(d => d.QuickSheetId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_QuickSheetRatings_QuickSheets");
            });

            modelBuilder.Entity<QuickSheets>(entity =>
            {
                entity.Property(e => e.Attribution)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

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

                entity.HasOne(d => d.QuickSheet)
                    .WithMany(p => p.QuickSheetViews)
                    .HasForeignKey(d => d.QuickSheetId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_QuickSheetViews_QuickSheets");
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

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Technologies)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Technologies_TechCategories");
            });

            modelBuilder.Entity<UserPurchaseHistory>(entity =>
            {
                entity.Property(e => e.PricePaid).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.SaleDate).HasColumnType("datetime");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.HasOne(d => d.QuickSheet)
                    .WithMany(p => p.UserPurchaseHistory)
                    .HasForeignKey(d => d.QuickSheetId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserPurchaseHistory_QuickSheets");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserPurchaseHistory)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserPurchaseHistory_AspNetUsers");
            });
        }
    }
}
