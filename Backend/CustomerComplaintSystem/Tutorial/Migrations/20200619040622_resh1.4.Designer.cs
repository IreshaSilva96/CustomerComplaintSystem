﻿// <auto-generated />
using System;
using CustomerComplaintSystem.DataBase;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CustomerComplaintSystem.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20200619040622_resh1.4")]
    partial class resh14
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CustomerComplaintSystem.Entities.Account", b =>
                {
                    b.Property<int>("AccountID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AccountHolderID")
                        .HasColumnType("int");

                    b.Property<int>("AccountTypeID")
                        .HasColumnType("int");

                    b.Property<int>("BranchID")
                        .HasColumnType("int");

                    b.HasKey("AccountID");

                    b.HasIndex("AccountHolderID");

                    b.HasIndex("AccountTypeID");

                    b.HasIndex("BranchID");

                    b.ToTable("Account");
                });

            modelBuilder.Entity("CustomerComplaintSystem.Entities.AccountHolder", b =>
                {
                    b.Property<int>("AccountHolderID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AccountID")
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<int>("ContactNumber")
                        .HasColumnType("int")
                        .HasMaxLength(20);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<int>("GenderID")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("NIC")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.HasKey("AccountHolderID");

                    b.HasIndex("AccountID");

                    b.HasIndex("GenderID");

                    b.ToTable("AccountHolder");
                });

            modelBuilder.Entity("CustomerComplaintSystem.Entities.AccountType", b =>
                {
                    b.Property<int>("AccountTypeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AccountTypeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.HasKey("AccountTypeID");

                    b.ToTable("AccountType");
                });

            modelBuilder.Entity("CustomerComplaintSystem.Entities.Agent", b =>
                {
                    b.Property<int>("AgentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AgentTypeID")
                        .HasColumnType("int");

                    b.Property<string>("AgentUserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<int>("EmployeeID")
                        .HasColumnType("int");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.HasKey("AgentID");

                    b.HasIndex("AgentTypeID");

                    b.HasIndex("EmployeeID");

                    b.ToTable("Agent");
                });

            modelBuilder.Entity("CustomerComplaintSystem.Entities.AgentType", b =>
                {
                    b.Property<int>("AgentTypeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AgentTypeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.HasKey("AgentTypeID");

                    b.ToTable("AgentType");
                });

            modelBuilder.Entity("CustomerComplaintSystem.Entities.Branch", b =>
                {
                    b.Property<int>("BranchID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BranchName")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.HasKey("BranchID");

                    b.ToTable("Branch");
                });

            modelBuilder.Entity("CustomerComplaintSystem.Entities.CategoryOfComplaint", b =>
                {
                    b.Property<int>("CategoryOfComplaintID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryOfComplaintName")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.HasKey("CategoryOfComplaintID");

                    b.ToTable("CategoryOfComplaint");
                });

            modelBuilder.Entity("CustomerComplaintSystem.Entities.Complaint", b =>
                {
                    b.Property<int>("ComplaintID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AccountHolder")
                        .HasColumnType("int");

                    b.Property<int>("AccountHolderID")
                        .HasColumnType("int");

                    b.Property<int>("AccountID")
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<int>("BranchID")
                        .HasColumnType("int");

                    b.Property<int>("CategoryID")
                        .HasColumnType("int");

                    b.Property<DateTime>("ComplaintLoggedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("ComplaintStatusID")
                        .HasColumnType("int");

                    b.Property<int>("ContactNumber")
                        .HasColumnType("int")
                        .HasMaxLength(20);

                    b.Property<int>("CustomerTypeID")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateOfComplaint")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(500)")
                        .HasMaxLength(500);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("NIC")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.HasKey("ComplaintID");

                    b.HasIndex("AccountHolder");

                    b.HasIndex("AccountID");

                    b.HasIndex("BranchID");

                    b.HasIndex("CategoryID");

                    b.HasIndex("ComplaintStatusID");

                    b.HasIndex("CustomerTypeID");

                    b.ToTable("Complaint");
                });

            modelBuilder.Entity("CustomerComplaintSystem.Entities.ComplaintStatus", b =>
                {
                    b.Property<int>("ComplaintStatusID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AgentID")
                        .HasColumnType("int");

                    b.Property<string>("ComplaintStatusName")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.HasKey("ComplaintStatusID");

                    b.HasIndex("AgentID");

                    b.ToTable("ComplaintStatus");
                });

            modelBuilder.Entity("CustomerComplaintSystem.Entities.CustomerType", b =>
                {
                    b.Property<int>("CustomerTypeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CustomerTypeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.HasKey("CustomerTypeID");

                    b.ToTable("CustomerType");
                });

            modelBuilder.Entity("CustomerComplaintSystem.Entities.Employee", b =>
                {
                    b.Property<int>("EmployeeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<int>("BranchID")
                        .HasColumnType("int");

                    b.Property<int>("ContactNumber")
                        .HasColumnType("int")
                        .HasMaxLength(20);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("NIC")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.HasKey("EmployeeID");

                    b.HasIndex("BranchID");

                    b.ToTable("Employee");
                });

            modelBuilder.Entity("CustomerComplaintSystem.Entities.Gender", b =>
                {
                    b.Property<int>("GenderID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("GenderName")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.HasKey("GenderID");

                    b.ToTable("Gender");
                });

            modelBuilder.Entity("CustomerComplaintSystem.Entities.NatureOfComplaint", b =>
                {
                    b.Property<int>("NatureOfComplaintID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NatureOfComplaintName")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<int>("ProductAndServiceID")
                        .HasColumnType("int");

                    b.HasKey("NatureOfComplaintID");

                    b.HasIndex("ProductAndServiceID");

                    b.ToTable("NatureOfComplaint");
                });

            modelBuilder.Entity("CustomerComplaintSystem.Entities.ProductAndService", b =>
                {
                    b.Property<int>("ProductAndServiceID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryOfComplaintID")
                        .HasColumnType("int");

                    b.Property<string>("ProductAndServiceName")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.HasKey("ProductAndServiceID");

                    b.HasIndex("CategoryOfComplaintID");

                    b.ToTable("ProductAndService");
                });

            modelBuilder.Entity("CustomerComplaintSystem.Entities.Account", b =>
                {
                    b.HasOne("CustomerComplaintSystem.Entities.AccountHolder", "ParentAccountHolder")
                        .WithMany()
                        .HasForeignKey("AccountHolderID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CustomerComplaintSystem.Entities.Account", "ParentAccount")
                        .WithMany()
                        .HasForeignKey("AccountTypeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CustomerComplaintSystem.Entities.Branch", "ParentBranch")
                        .WithMany()
                        .HasForeignKey("BranchID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CustomerComplaintSystem.Entities.AccountHolder", b =>
                {
                    b.HasOne("CustomerComplaintSystem.Entities.Account", "ParentAccount")
                        .WithMany()
                        .HasForeignKey("AccountID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CustomerComplaintSystem.Entities.Gender", "ParentGender")
                        .WithMany()
                        .HasForeignKey("GenderID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CustomerComplaintSystem.Entities.Agent", b =>
                {
                    b.HasOne("CustomerComplaintSystem.Entities.Agent", "ParentAgent")
                        .WithMany()
                        .HasForeignKey("AgentTypeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CustomerComplaintSystem.Entities.Employee", "ParentEmployee")
                        .WithMany()
                        .HasForeignKey("EmployeeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CustomerComplaintSystem.Entities.Complaint", b =>
                {
                    b.HasOne("CustomerComplaintSystem.Entities.AccountHolder", "ParentAccountHoldr")
                        .WithMany()
                        .HasForeignKey("AccountHolder");

                    b.HasOne("CustomerComplaintSystem.Entities.Account", "ParentAccount")
                        .WithMany()
                        .HasForeignKey("AccountID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CustomerComplaintSystem.Entities.Branch", "ParentBranch")
                        .WithMany()
                        .HasForeignKey("BranchID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CustomerComplaintSystem.Entities.CategoryOfComplaint", "ParentCategoryOfComplaint")
                        .WithMany()
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CustomerComplaintSystem.Entities.ComplaintStatus", "ParentComplaintStatus")
                        .WithMany()
                        .HasForeignKey("ComplaintStatusID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CustomerComplaintSystem.Entities.CustomerType", "ParentCustomerType")
                        .WithMany()
                        .HasForeignKey("CustomerTypeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CustomerComplaintSystem.Entities.ComplaintStatus", b =>
                {
                    b.HasOne("CustomerComplaintSystem.Entities.Agent", "ParentAgent")
                        .WithMany()
                        .HasForeignKey("AgentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CustomerComplaintSystem.Entities.Employee", b =>
                {
                    b.HasOne("CustomerComplaintSystem.Entities.Branch", "ParentBranch")
                        .WithMany()
                        .HasForeignKey("BranchID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CustomerComplaintSystem.Entities.NatureOfComplaint", b =>
                {
                    b.HasOne("CustomerComplaintSystem.Entities.ProductAndService", "ParentProductAndService")
                        .WithMany()
                        .HasForeignKey("ProductAndServiceID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CustomerComplaintSystem.Entities.ProductAndService", b =>
                {
                    b.HasOne("CustomerComplaintSystem.Entities.CategoryOfComplaint", "ParentCategoryOfComplaint")
                        .WithMany()
                        .HasForeignKey("CategoryOfComplaintID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
