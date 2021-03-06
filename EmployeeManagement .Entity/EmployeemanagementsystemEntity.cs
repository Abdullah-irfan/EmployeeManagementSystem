// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace EmployeeManagement_.Entity
{
    public partial class EmployeemanagementsystemEntity : DbContext
    {
        public EmployeemanagementsystemEntity()
        {
        }

        public EmployeemanagementsystemEntity(DbContextOptions<EmployeemanagementsystemEntity> options)
            : base(options)
        {
        }

        public virtual DbSet<EmployeeDepartmentDetails> EmployeeDepartmentDetails { get; set; }
        public virtual DbSet<EmployeeManagementDetails> EmployeeManagementDetails { get; set; }
        public virtual DbSet<UserLoginDetails> UserLoginDetails { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-A46N9C4\\SQLEXPRESS;Initial Catalog=EmployeeManagementSystem;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<EmployeeDepartmentDetails>(entity =>
            {
                entity.Property(e => e.Department_Id).ValueGeneratedNever();

                entity.Property(e => e.Created_Time_Stamp).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Department_Name).IsUnicode(false);

                entity.Property(e => e.Updated_Time_Stamp).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<EmployeeManagementDetails>(entity =>
            {
                entity.Property(e => e.Address).IsUnicode(false);

                entity.Property(e => e.Created_Time_Stamp).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Department).IsUnicode(false);

                entity.Property(e => e.Email).IsUnicode(false);

                entity.Property(e => e.Full_Name).IsUnicode(false);

                entity.Property(e => e.Gender).IsFixedLength(true);

                entity.Property(e => e.Matricule).IsUnicode(false);

                entity.Property(e => e.Updated_Time_Stamp).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.User_Name).IsUnicode(false);
            });

            modelBuilder.Entity<UserLoginDetails>(entity =>
            {
                entity.Property(e => e.Created_Time_Stamp).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Password).IsUnicode(false);

                entity.Property(e => e.Updated_Time_Stamp).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.User_Name).IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}