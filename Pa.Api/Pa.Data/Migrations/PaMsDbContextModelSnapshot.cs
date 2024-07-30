﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Pa.Data.Context;

#nullable disable

namespace Pa.Data.Migrations
{
    [DbContext(typeof(PaMsDbContext))]
    partial class PaMsDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Pa.Data.Domain.Factory", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<int>("Capacity")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime2");

                    b.Property<long>("CreateUserId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("DeleteTime")
                        .HasColumnType("datetime2");

                    b.Property<long>("DeleteUserId")
                        .HasColumnType("bigint");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("EmployeeCount")
                        .HasColumnType("int");

                    b.Property<DateTime>("EstablishedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FactoryName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("TaxNumber")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("UpdateTime")
                        .HasColumnType("datetime2");

                    b.Property<long>("UpdateUserId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("TaxNumber")
                        .IsUnique();

                    b.ToTable("Factories", "dbo");
                });

            modelBuilder.Entity("Pa.Data.Domain.FactoryDetail", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime2");

                    b.Property<long>("CreateUserId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("DeleteTime")
                        .HasColumnType("datetime2");

                    b.Property<long>("DeleteUserId")
                        .HasColumnType("bigint");

                    b.Property<string>("FactoryCertificates")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("FactoryHistory")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<long>("FactoryId")
                        .HasColumnType("bigint");

                    b.Property<string>("FactoryMission")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("FactoryProfile")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("FactoryQualityPolicy")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("FactoryValues")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("FactoryVision")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<DateTime>("UpdateTime")
                        .HasColumnType("datetime2");

                    b.Property<long>("UpdateUserId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("FactoryId")
                        .IsUnique();

                    b.ToTable("FactoryDetails", "dbo");
                });

            modelBuilder.Entity("Pa.Data.Domain.FactoryLocation", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime2");

                    b.Property<long>("CreateUserId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("DeleteTime")
                        .HasColumnType("datetime2");

                    b.Property<long>("DeleteUserId")
                        .HasColumnType("bigint");

                    b.Property<string>("District")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<long>("FactoryId")
                        .HasColumnType("bigint");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("LocationName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("PostalCode")
                        .IsRequired()
                        .HasMaxLength(6)
                        .HasColumnType("nvarchar(6)");

                    b.Property<DateTime>("UpdateTime")
                        .HasColumnType("datetime2");

                    b.Property<long>("UpdateUserId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("FactoryId");

                    b.ToTable("FactoryLocations", "dbo");
                });

            modelBuilder.Entity("Pa.Data.Domain.FactoryPhone", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("CountryCode")
                        .IsRequired()
                        .HasMaxLength(3)
                        .HasColumnType("nvarchar(3)");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime2");

                    b.Property<long>("CreateUserId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("DeleteTime")
                        .HasColumnType("datetime2");

                    b.Property<long>("DeleteUserId")
                        .HasColumnType("bigint");

                    b.Property<long>("FactoryId")
                        .HasColumnType("bigint");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsPrimary")
                        .HasColumnType("bit");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<DateTime>("UpdateTime")
                        .HasColumnType("datetime2");

                    b.Property<long>("UpdateUserId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("FactoryId");

                    b.HasIndex("CountryCode", "PhoneNumber")
                        .IsUnique();

                    b.ToTable("FactoryPhones", "dbo");
                });

            modelBuilder.Entity("Pa.Data.Domain.FactoryDetail", b =>
                {
                    b.HasOne("Pa.Data.Domain.Factory", "Factory")
                        .WithOne("FactoryDetail")
                        .HasForeignKey("Pa.Data.Domain.FactoryDetail", "FactoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Factory");
                });

            modelBuilder.Entity("Pa.Data.Domain.FactoryLocation", b =>
                {
                    b.HasOne("Pa.Data.Domain.Factory", "Factory")
                        .WithMany("FactoryLocations")
                        .HasForeignKey("FactoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Factory");
                });

            modelBuilder.Entity("Pa.Data.Domain.FactoryPhone", b =>
                {
                    b.HasOne("Pa.Data.Domain.Factory", "Factory")
                        .WithMany("FactoryPhones")
                        .HasForeignKey("FactoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Factory");
                });

            modelBuilder.Entity("Pa.Data.Domain.Factory", b =>
                {
                    b.Navigation("FactoryDetail")
                        .IsRequired();

                    b.Navigation("FactoryLocations");

                    b.Navigation("FactoryPhones");
                });
#pragma warning restore 612, 618
        }
    }
}
