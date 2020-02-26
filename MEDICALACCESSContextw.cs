﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace SyncfusionASPNETCoreApplication2
{
    public partial class MEDICALACCESSContextw : DbContext
    {
        public MEDICALACCESSContextw()
        {
        }

        public MEDICALACCESSContextw(DbContextOptions<MEDICALACCESSContextw> options)
            : base(options)
        {
        }

        public virtual DbSet<AArtProductClassification> AArtProductClassification { get; set; }
        public virtual DbSet<MigrationHistory> MigrationHistory { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AArtProductClassification>(entity =>
            {
                entity.HasKey(e => e.ArtProductClassificationCode);

                entity.ToTable("A_ART_Product_Classification");

                entity.Property(e => e.ArtProductClassificationCode)
                    .HasColumnName("ART_product_classification_code")
                    .ValueGeneratedNever();

                entity.Property(e => e.ArtProductClassificationDesc)
                    .HasColumnName("ART_product_classification_desc")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<MigrationHistory>(entity =>
            {
                entity.HasKey(e => new { e.MigrationId, e.ContextKey })
                    .HasName("PK_dbo.__MigrationHistory");

                entity.ToTable("__MigrationHistory");

                entity.Property(e => e.MigrationId).HasMaxLength(150);

                entity.Property(e => e.ContextKey).HasMaxLength(300);

                entity.Property(e => e.Model).IsRequired();

                entity.Property(e => e.ProductVersion)
                    .IsRequired()
                    .HasMaxLength(32);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}