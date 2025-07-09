using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace MohammadCartonAutomation.Models;

public partial class ApplicationDbContext : DbContext
{
    public ApplicationDbContext()
    {
    }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<CalculationFormula> CalculationFormulas { get; set; }

    public virtual DbSet<FlutStep> FlutSteps { get; set; }

    public virtual DbSet<TbBom> TbBoms { get; set; }

    public virtual DbSet<TbCartonPriceForm> TbCartonPriceForms { get; set; }

    public virtual DbSet<TbCartonSpecification> TbCartonSpecifications { get; set; }

    public virtual DbSet<TbCustomer> TbCustomers { get; set; }

    public virtual DbSet<TbMachin> TbMachins { get; set; }

    public virtual DbSet<TbMaterial> TbMaterials { get; set; }

    public virtual DbSet<TbProductionOrder> TbProductionOrders { get; set; }

    public virtual DbSet<TbProformaDetail> TbProformaDetails { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=db.MohammadCartonAutomation;User ID=sa;Password='M@ 12345678 @m';TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CalculationFormula>(entity =>
        {
            entity.HasKey(e => e.FormulaId).HasName("PK__Calculat__227429A57B2ECC59");

            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.FormulaDescription).HasMaxLength(500);
            entity.Property(e => e.FormulaExpression).HasMaxLength(1000);
            entity.Property(e => e.FormulaName).HasMaxLength(100);
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.OutputUnit).HasMaxLength(50);
            entity.Property(e => e.Variables).HasMaxLength(500);
        });

        modelBuilder.Entity<FlutStep>(entity =>
        {
            entity.HasKey(e => e.FluteId);

            entity.ToTable("FlutStep");

            entity.Property(e => e.FluteId).HasColumnName("FluteID");
            entity.Property(e => e.FlutStep1).HasColumnName("FlutStep");
        });

        modelBuilder.Entity<TbBom>(entity =>
        {
            entity.HasKey(e => e.Bomid);

            entity.ToTable("TB_BOM");

            entity.Property(e => e.Bomid).HasColumnName("BOMID");
            entity.Property(e => e.ParmetrName).HasMaxLength(50);

            entity.HasOne(d => d.Material).WithMany(p => p.TbBoms)
                .HasForeignKey(d => d.MaterialId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TB_BOM_TB_Material");
        });

        modelBuilder.Entity<TbCartonPriceForm>(entity =>
        {
            entity.HasKey(e => e.FormId);

            entity.ToTable("TB_CartonPriceForm");

            entity.Property(e => e.CartonType).HasMaxLength(50);
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.FlutId).HasColumnName("FlutID");
            entity.Property(e => e.LastPrice).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.ProductCode)
                .HasMaxLength(10)
                .IsFixedLength();

            entity.HasOne(d => d.Customer).WithMany(p => p.TbCartonPriceForms)
                .HasForeignKey(d => d.CustomerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TB_CartonPriceForm_TB_Customers");

            entity.HasOne(d => d.Flut).WithMany(p => p.TbCartonPriceForms)
                .HasForeignKey(d => d.FlutId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TB_CartonPriceForm_FlutStep");
        });

        modelBuilder.Entity<TbCartonSpecification>(entity =>
        {
            entity.HasKey(e => e.SpecId).HasName("PK__CartonSp__883D567BCAAD36C6");

            entity.ToTable("TB_CartonSpecifications");

            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.DoorCount).HasMaxLength(50);
            entity.Property(e => e.DoorType).HasMaxLength(50);
            entity.Property(e => e.LayerType).HasMaxLength(50);
            entity.Property(e => e.PieceType).HasMaxLength(50);

            entity.HasOne(d => d.Form).WithMany(p => p.TbCartonSpecifications)
                .HasForeignKey(d => d.FormId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TB_CartonSpecifications_TB_CartonPriceForm");
        });

        modelBuilder.Entity<TbCustomer>(entity =>
        {
            entity.HasKey(e => e.CustomerId);

            entity.ToTable("TB_Customers");

            entity.Property(e => e.CustomerName).HasMaxLength(50);
            entity.Property(e => e.PhoneNumber).HasMaxLength(11);
        });

        modelBuilder.Entity<TbMachin>(entity =>
        {
            entity.HasKey(e => e.MachinId);

            entity.ToTable("TB_Machin");

            entity.Property(e => e.MachinId).HasColumnName("MachinID");
            entity.Property(e => e.FlutId).HasColumnName("FlutID");

            entity.HasOne(d => d.Flut).WithMany(p => p.TbMachins)
                .HasForeignKey(d => d.FlutId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TB_Machin_FlutStep");
        });

        modelBuilder.Entity<TbMaterial>(entity =>
        {
            entity.HasKey(e => e.MaterialId);

            entity.ToTable("TB_Material");

            entity.Property(e => e.MaterialName).HasMaxLength(50);
        });

        modelBuilder.Entity<TbProductionOrder>(entity =>
        {
            entity.HasKey(e => e.OrderId);

            entity.ToTable("TB_ProductionOrder");

            entity.Property(e => e.ProductCode).HasMaxLength(50);

            entity.HasOne(d => d.Customer).WithMany(p => p.TbProductionOrders)
                .HasForeignKey(d => d.CustomerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TB_ProductionOrder_TB_Customers");
        });

        modelBuilder.Entity<TbProformaDetail>(entity =>
        {
            entity.HasKey(e => e.VariationId);

            entity.ToTable("TB_ProformaDetails");

            entity.Property(e => e.VariationId).HasColumnName("VariationID");
            entity.Property(e => e.Bomid).HasColumnName("BOMID");
            entity.Property(e => e.Quantity).HasColumnType("decimal(18, 0)");

            entity.HasOne(d => d.Bom).WithMany(p => p.TbProformaDetails)
                .HasForeignKey(d => d.Bomid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TB_ProformaDetails_TB_BOM1");

            entity.HasOne(d => d.Order).WithMany(p => p.TbProformaDetails)
                .HasForeignKey(d => d.OrderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TB_ProformaDetails_TB_ProductionOrder");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
