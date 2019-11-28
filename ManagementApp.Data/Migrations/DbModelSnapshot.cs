﻿// <auto-generated />
using System;
using ManagementApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ManagementApp.Data.Migrations
{
    [DbContext(typeof(Db))]
    partial class DbModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ManagementApp.Data.PaymentDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AccountNumber");

                    b.Property<int>("PaymentDetailsID");

                    b.Property<string>("SortCode");

                    b.HasKey("Id");

                    b.ToTable("PaymentDetails");
                });

            modelBuilder.Entity("ManagementApp.Data.Permission", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("PermissionID");

                    b.HasKey("Id");

                    b.ToTable("Permissions");
                });

            modelBuilder.Entity("ManagementApp.Data.PurchaseRequest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("PaymentDetailsID");

                    b.Property<int?>("PaymentId");

                    b.Property<string>("ProductName");

                    b.Property<double>("ProductPrice");

                    b.Property<int>("ProductQty");

                    b.Property<int>("PurchaseRequestID");

                    b.Property<int>("StaffID");

                    b.Property<int>("VendorID");

                    b.HasKey("Id");

                    b.HasIndex("PaymentId");

                    b.ToTable("PurchaseRequests");
                });

            modelBuilder.Entity("ManagementApp.Data.StaffAccount", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.Property<int>("PermissionID");

                    b.Property<int>("StaffID");

                    b.HasKey("Id");

                    b.HasIndex("PermissionID");

                    b.ToTable("StaffAccounts");
                });

            modelBuilder.Entity("ManagementApp.Data.PurchaseRequest", b =>
                {
                    b.HasOne("ManagementApp.Data.PaymentDetail", "Payment")
                        .WithMany()
                        .HasForeignKey("PaymentId");
                });

            modelBuilder.Entity("ManagementApp.Data.StaffAccount", b =>
                {
                    b.HasOne("ManagementApp.Data.Permission", "Permissions")
                        .WithMany()
                        .HasForeignKey("PermissionID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
