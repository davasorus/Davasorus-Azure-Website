using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace StreamWebPage.Models
{
    public partial class StreamingDBContext : DbContext
    {
        public StreamingDBContext()
        {
        }

        public StreamingDBContext(DbContextOptions<StreamingDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AppPub> AppPub { get; set; }
        public virtual DbSet<AspNetRoleClaims> AspNetRoleClaims { get; set; }
        public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUserRoles> AspNetUserRoles { get; set; }
        public virtual DbSet<AspNetUserTokens> AspNetUserTokens { get; set; }
        public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }
        public virtual DbSet<ChannelAnalytics> ChannelAnalytics { get; set; }
        public virtual DbSet<GameName> GameName { get; set; }
        public virtual DbSet<GameType> GameType { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("DefaultConnection");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppPub>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AppName)
                    .HasColumnName("App_Name")
                    .HasMaxLength(50);

                entity.Property(e => e.AppVersion)
                    .HasColumnName("App_Version")
                    .HasMaxLength(50);

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.TransactionDate)
                    .HasColumnName("Transaction_Date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

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
                    .HasName("RoleNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedName] IS NOT NULL)");

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

                entity.Property(e => e.LoginProvider).HasMaxLength(128);

                entity.Property(e => e.ProviderKey).HasMaxLength(128);

                entity.Property(e => e.UserId).IsRequired();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserLogins)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserRoles>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId });

                entity.HasIndex(e => e.RoleId);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.RoleId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserTokens>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name });

                entity.Property(e => e.LoginProvider).HasMaxLength(128);

                entity.Property(e => e.Name).HasMaxLength(128);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserTokens)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUsers>(entity =>
            {
                entity.HasIndex(e => e.NormalizedEmail)
                    .HasName("EmailIndex");

                entity.HasIndex(e => e.NormalizedUserName)
                    .HasName("UserNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedUserName] IS NOT NULL)");

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.NormalizedEmail).HasMaxLength(256);

                entity.Property(e => e.NormalizedUserName).HasMaxLength(256);

                entity.Property(e => e.UserName).HasMaxLength(256);
            });

            modelBuilder.Entity<ChannelAnalytics>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AdBreaksMinutes).HasColumnName("Ad_Breaks_Minutes");

                entity.Property(e => e.AdRevenue).HasColumnName("Ad_Revenue");

                entity.Property(e => e.AdTimeSecondsPerHour).HasColumnName("Ad_Time_Seconds_Per_Hour");

                entity.Property(e => e.AverageViewers).HasColumnName("Average_Viewers");

                entity.Property(e => e.BitsRevenue).HasColumnName("Bits_Revenue");

                entity.Property(e => e.BountiesRevenue).HasColumnName("Bounties_Revenue");

                entity.Property(e => e.ChatMessages).HasColumnName("Chat_Messages");

                entity.Property(e => e.ClipViews).HasColumnName("Clip_Views");

                entity.Property(e => e.ClipsCreated).HasColumnName("Clips_Created");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.ExtensionsRevenue).HasColumnName("Extensions_Revenue");

                entity.Property(e => e.GameSalesRevenue).HasColumnName("Game_Sales_Revenue");

                entity.Property(e => e.GiftedSubsRevenue).HasColumnName("Gifted_Subs_Revenue");

                entity.Property(e => e.GiftedTier1Subs).HasColumnName("Gifted_Tier_1_subs");

                entity.Property(e => e.HostsAndRaidsViewers).HasColumnName("Hosts_and_Raids_Viewers");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.LiveViews).HasColumnName("Live_Views");

                entity.Property(e => e.MaxViewers).HasColumnName("Max_Viewers");

                entity.Property(e => e.MinutesStreamed).HasColumnName("Minutes_Streamed");

                entity.Property(e => e.MinutesWatched).HasColumnName("Minutes_Watched");

                entity.Property(e => e.PrimeRevenue).HasColumnName("Prime_Revenue");

                entity.Property(e => e.PrimeSubs).HasColumnName("Prime_Subs");

                entity.Property(e => e.SubRevenue).HasColumnName("Sub_Revenue");

                entity.Property(e => e.Tier1Subs).HasColumnName("Tier_1_subs");

                entity.Property(e => e.TotalGiftedSubs).HasColumnName("Total_Gifted_Subs");

                entity.Property(e => e.TotalPaidSubs).HasColumnName("Total_Paid_Subs");

                entity.Property(e => e.UniqueViewers).HasColumnName("Unique_Viewers");
            });

            modelBuilder.Entity<GameName>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.GameName1)
                    .HasColumnName("GameName")
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.GameTypeId).HasColumnName("GameTypeID");

                entity.Property(e => e.GameTypeName)
                    .HasMaxLength(50)
                    .IsFixedLength();
            });

            modelBuilder.Entity<GameType>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.GameTypeId).HasColumnName("GameTypeID");

                entity.Property(e => e.GameTypeName).IsRequired();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}