using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CTAPI.Models
{
    public partial class dbbtCalTContext : DbContext
    {
        public dbbtCalTContext()
        {
        }

        public dbbtCalTContext(DbContextOptions<dbbtCalTContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CtdCallCategories> CtdCallCategories { get; set; }
        public virtual DbSet<CtdCallerAssocs> CtdCallerAssocs { get; set; }
        public virtual DbSet<CtdCalls> CtdCalls { get; set; }
        public virtual DbSet<CtdCallStatuses> CtdCallStatuses { get; set; }
        public virtual DbSet<SetGroup> SetGroup { get; set; }
        public virtual DbSet<SetModule> SetModule { get; set; }
        public virtual DbSet<SetUser> SetUser { get; set; }

        // Unable to generate entity type for table 'dbo.set_group_access'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.set_user_access'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=jhassqlstg02.database.secure.windows.net,14412;Database=dbbtCalT;User ID=biztech;Password=B!$tech!123;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CtdCallCategories>(entity =>
            {
                entity.HasKey(e => e.CallCategoryId);

                entity.ToTable("CTD_CallCategories");

                entity.Property(e => e.CallCategoryId).HasColumnName("CallCategoryID");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.CallCategoryDesc)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CtdCallerAssocs>(entity =>
            {
                entity.HasKey(e => e.CallerAssocId);

                entity.ToTable("CTD_CallerAssocs");

                entity.Property(e => e.CallerAssocId).HasColumnName("CallerAssocID");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.CallerAssocDesc)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CtdCalls>(entity =>
            {
                entity.HasKey(e => e.CallId);

                entity.ToTable("CTD_Calls");

                entity.Property(e => e.CallId).HasColumnName("CallID");

                entity.Property(e => e.CallCategoryId).HasColumnName("CallCategoryID");

                entity.Property(e => e.CallStatusId).HasColumnName("CallStatusID");

                entity.Property(e => e.CallerAssocId).HasColumnName("CallerAssocID");

                entity.Property(e => e.CallerPhone)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DateOfCall)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasColumnName("user_name")
                    .HasMaxLength(25);

                entity.HasOne(d => d.CallCategory)
                    .WithMany(p => p.CtdCalls)
                    .HasForeignKey(d => d.CallCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CTD_Calls_CTD_CallCategories");

                entity.HasOne(d => d.CallStatus)
                    .WithMany(p => p.CtdCalls)
                    .HasForeignKey(d => d.CallStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CTD_Calls_CTD_CallStatuses");

                entity.HasOne(d => d.CallerAssoc)
                    .WithMany(p => p.CtdCalls)
                    .HasForeignKey(d => d.CallerAssocId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CTD_Calls_CTD_CallerAssocs");

                entity.HasOne(d => d.UserNameNavigation)
                    .WithMany(p => p.CtdCalls)
                    .HasForeignKey(d => d.UserName)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CTD_Calls_set_user1");
            });

            modelBuilder.Entity<CtdCallStatuses>(entity =>
            {
                entity.HasKey(e => e.CallStatusId);

                entity.ToTable("CTD_CallStatuses");

                entity.Property(e => e.CallStatusId).HasColumnName("CallStatusID");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.CallStatusDesc)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SetGroup>(entity =>
            {
                entity.HasKey(e => e.GrpId)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("set_group");

                entity.Property(e => e.GrpId)
                    .HasColumnName("grp_id")
                    .HasMaxLength(25)
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.GrpDesc)
                    .HasColumnName("grp_desc")
                    .HasMaxLength(255);

                entity.Property(e => e.GrpName)
                    .HasColumnName("grp_name")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<SetModule>(entity =>
            {
                entity.HasKey(e => e.ModId)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("set_module");

                entity.Property(e => e.ModId)
                    .HasColumnName("mod_id")
                    .HasMaxLength(25)
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModDesc)
                    .HasColumnName("mod_desc")
                    .HasMaxLength(255);

                entity.Property(e => e.ModName)
                    .HasColumnName("mod_name")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<SetUser>(entity =>
            {
                entity.HasKey(e => e.UserName)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("set_user");

                entity.Property(e => e.UserName)
                    .HasColumnName("user_name")
                    .HasMaxLength(25)
                    .ValueGeneratedNever();

                entity.Property(e => e.CanDev)
                    .HasColumnName("can_DEV")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CanPeer)
                    .HasColumnName("can_PEER")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CanProd)
                    .HasColumnName("can_PROD")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CanUat)
                    .HasColumnName("can_UAT")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UserFirstName)
                    .HasColumnName("user_first_name")
                    .HasMaxLength(50);

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasColumnName("user_id")
                    .HasMaxLength(25);

                entity.Property(e => e.UserLastName)
                    .HasColumnName("user_last_name")
                    .HasMaxLength(50);

                entity.Property(e => e.UserMiddleName)
                    .HasColumnName("user_middle_name")
                    .HasMaxLength(50);
            });
        }
    }
}
