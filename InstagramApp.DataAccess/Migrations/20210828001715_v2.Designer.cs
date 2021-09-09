﻿// <auto-generated />
using InstagramApp.DataAccess.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace InstagramApp.DataAccess.Migrations
{
    [DbContext(typeof(InstagramAppDbContext))]
    [Migration("20210828001715_v2")]
    partial class v2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("InstagramApp.DataEntity.Models.Referral", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(50)
                        .HasColumnType("int")
                        .HasColumnName("Id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Point")
                        .HasMaxLength(255)
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("point");

                    b.Property<string>("Referee")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("Referee");

                    b.Property<string>("Referrer")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("Referrer");

                    b.HasKey("Id");

                    b.ToTable("tbl_Referral");
                });

            modelBuilder.Entity("InstagramApp.DataEntity.Models.User", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("UserId");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(125)
                        .HasColumnType("nvarchar(125)")
                        .HasColumnName("Email");

                    b.Property<string>("FcmToken")
                        .HasMaxLength(125)
                        .HasColumnType("nvarchar(125)")
                        .HasColumnName("FcmToken");

                    b.Property<string>("Firstname")
                        .IsRequired()
                        .HasMaxLength(125)
                        .HasColumnType("nvarchar(125)")
                        .HasColumnName("FirstName");

                    b.Property<string>("Lastname")
                        .IsRequired()
                        .HasMaxLength(125)
                        .HasColumnType("nvarchar(125)")
                        .HasColumnName("Lastname");

                    b.Property<string>("ReferralCode")
                        .HasMaxLength(125)
                        .HasColumnType("nvarchar(125)")
                        .HasColumnName("ReferralCode");

                    b.Property<string>("Telephone")
                        .IsRequired()
                        .HasMaxLength(125)
                        .HasColumnType("nvarchar(125)")
                        .HasColumnName("Telephone");

                    b.Property<decimal>("WalletBalance")
                        .HasMaxLength(125)
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("WalletBalance");

                    b.HasKey("Id");

                    b.ToTable("tbl_User");
                });
#pragma warning restore 612, 618
        }
    }
}
