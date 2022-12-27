using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Application.Models;

public partial class EmpolyeeContext : DbContext
{
    public EmpolyeeContext()
    {
    }

    public EmpolyeeContext(DbContextOptions<EmpolyeeContext> options)
        : base(options)
    {
    }

    public virtual DbSet<ApplicationEmp> ApplicationEmps { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
{
    
}
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ApplicationEmp>(entity =>
        {
            entity.HasKey(e => e.EmployeeCode).HasName("PK__Applicat__0A34D2A8B872F5C8");

            entity.ToTable("ApplicationEmp");

            entity.Property(e => e.EmployeeCode).HasColumnName("EMPLOYEE_CODE");
            entity.Property(e => e.Basic)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("BASIC");
            entity.Property(e => e.Ctc)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("CTC");
            entity.Property(e => e.EmployeeName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("Employee_Name");
            entity.Property(e => e.Fual)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("FUAL");
            entity.Property(e => e.Hra)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("HRA");
            entity.Property(e => e.HraType)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("HRA_TYPE");
            entity.Property(e => e.Lta)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("LTA");
            entity.Property(e => e.Pf)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("PF");
            entity.Property(e => e.Special)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
