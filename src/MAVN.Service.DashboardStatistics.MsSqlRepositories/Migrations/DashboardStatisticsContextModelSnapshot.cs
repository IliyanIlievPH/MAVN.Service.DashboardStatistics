﻿// <auto-generated />
using System;
using MAVN.Service.DashboardStatistics.MsSqlRepositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MAVN.Service.DashboardStatistics.MsSqlRepositories.Migrations
{
    [DbContext(typeof(DashboardStatisticsContext))]
    partial class DashboardStatisticsContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("dashboard_statistic")
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MAVN.Service.DashboardStatistics.MsSqlRepositories.Entities.CustomerActivityEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<DateTime>("ActivityDate")
                        .HasColumnName("activity_date");

                    b.Property<int?>("ActivityType")
                        .HasColumnName("activity_type");

                    b.Property<Guid>("CustomerId")
                        .HasColumnName("customer_id");

                    b.Property<Guid?>("PartnerId")
                        .HasColumnName("partner_id");

                    b.HasKey("Id");

                    b.ToTable("customer_activities");
                });

            modelBuilder.Entity("MAVN.Service.DashboardStatistics.MsSqlRepositories.Entities.CustomerStatisticEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<Guid>("CustomerId")
                        .HasColumnName("customer_id");

                    b.Property<Guid?>("PartnerId")
                        .HasColumnName("partner_id");

                    b.Property<DateTime>("TimeStamp")
                        .HasColumnName("time_stamp");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("PartnerId");

                    b.ToTable("customer_statistics");
                });

            modelBuilder.Entity("MAVN.Service.DashboardStatistics.MsSqlRepositories.Entities.PartnerVouchersDailyStatsEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Currency")
                        .IsRequired()
                        .HasColumnName("currency");

                    b.Property<DateTime>("Date")
                        .HasColumnName("date");

                    b.Property<string>("OperationType")
                        .IsRequired()
                        .HasColumnName("operation_type");

                    b.Property<Guid>("PartnerId")
                        .HasColumnName("partner_id");

                    b.Property<decimal>("Sum")
                        .HasColumnName("sum");

                    b.Property<int>("TotalCount")
                        .HasColumnName("total_count");

                    b.HasKey("Id");

                    b.HasIndex("PartnerId", "OperationType");

                    b.ToTable("partner_vouchers_daily_stats");
                });

            modelBuilder.Entity("MAVN.Service.DashboardStatistics.MsSqlRepositories.Entities.VoucherOperationsStatisticsEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<string>("Currency")
                        .HasColumnName("currency");

                    b.Property<string>("OperationType")
                        .IsRequired()
                        .HasColumnName("operation_type");

                    b.Property<Guid>("PartnerId")
                        .HasColumnName("partner_id");

                    b.Property<decimal>("Sum")
                        .HasColumnName("sum");

                    b.Property<int>("TotalCount")
                        .HasColumnName("total_count");

                    b.HasKey("Id");

                    b.HasIndex("PartnerId", "OperationType");

                    b.ToTable("voucher_operations_statistics");
                });
#pragma warning restore 612, 618
        }
    }
}
