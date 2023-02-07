using System;
using System.Collections.Generic;
using System.Text;
using System;
using DataAccess.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataAccess.Migrations
{
 
//    [DbContext(typeof(ContactContext))]
//    [Migration("20221214091727_FirstFullCompleteMigration")]
//    partial class ContactMigration
//    {
//          //ovveriding the wrong class
//        protected override void BuildTargetModel(ModelBuilder modelBuilder)
//        {

//#pragma warning disable 612, 618
//            modelBuilder
//                .HasAnnotation("ProductVersion", "3.1.29")
//                .HasAnnotation("Relational:MaxIdentifierLength", 128)
//                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

//            modelBuilder.Entity("Domain.Models.Category", b =>
//            {
//                b.Property<int>("Id")
//                    .ValueGeneratedOnAdd()
//                    .HasColumnType("int")
//                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

//                b.Property<string>("FirstName")
//                    .HasColumnType("nvarchar(255)")
//                    .HasMaxLength(255);

//                b.Property<string>("LastName")
//                .HasColumnType("nvarchar(255)")
//                .HasMaxLength(255);

//                b.Property<string>("MobileNumber")
//                .HasColumnType("nvarchar(15)")
//                .HasMaxLength(15);



//                b.HasKey("Id");

//                b.ToTable("Contacts");
//            });

//            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
//            {
//                b.Property<string>("Id")
//                    .HasColumnType("nvarchar(450)");

//                b.Property<string>("ConcurrencyStamp")
//                    .IsConcurrencyToken()
//                    .HasColumnType("nvarchar(max)");

//                b.Property<string>("Name")
//                    .HasColumnType("nvarchar(256)")
//                    .HasMaxLength(256);

//                b.Property<string>("NormalizedName")
//                    .HasColumnType("nvarchar(256)")
//                    .HasMaxLength(256);

//                b.HasKey("Id");

//                b.HasIndex("NormalizedName")
//                    .IsUnique()
//                    .HasName("RoleNameIndex")
//                    .HasFilter("[NormalizedName] IS NOT NULL");

//                b.ToTable("AspNetRoles");
//            });

//            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
//            {
//                b.Property<int>("Id")
//                    .ValueGeneratedOnAdd()
//                    .HasColumnType("int")
//                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

//                b.Property<string>("ClaimType")
//                    .HasColumnType("nvarchar(max)");

//                b.Property<string>("ClaimValue")
//                    .HasColumnType("nvarchar(max)");

//                b.Property<string>("RoleId")
//                    .IsRequired()
//                    .HasColumnType("nvarchar(450)");

//                b.HasKey("Id");

//                b.HasIndex("RoleId");

//                b.ToTable("AspNetRoleClaims");
//            });

//            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
//            {
//                b.Property<int>("Id")
//                    .ValueGeneratedOnAdd()
//                    .HasColumnType("int")
//                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

//                b.Property<string>("ClaimType")
//                    .HasColumnType("nvarchar(max)");

//                b.Property<string>("ClaimValue")
//                    .HasColumnType("nvarchar(max)");

//                b.Property<string>("UserId")
//                    .IsRequired()
//                    .HasColumnType("nvarchar(450)");

//                b.HasKey("Id");

//                b.HasIndex("UserId");

//                b.ToTable("AspNetUserClaims");
//            });

//            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
//            {
//                b.Property<string>("LoginProvider")
//                    .HasColumnType("nvarchar(128)")
//                    .HasMaxLength(128);

//                b.Property<string>("ProviderKey")
//                    .HasColumnType("nvarchar(128)")
//                    .HasMaxLength(128);

//                b.Property<string>("ProviderDisplayName")
//                    .HasColumnType("nvarchar(max)");

//                b.Property<string>("UserId")
//                    .IsRequired()
//                    .HasColumnType("nvarchar(450)");

//                b.HasKey("LoginProvider", "ProviderKey");

//                b.HasIndex("UserId");

//                b.ToTable("AspNetUserLogins");
//            });

//            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
//            {
//                b.Property<string>("UserId")
//                    .HasColumnType("nvarchar(450)");

//                b.Property<string>("RoleId")
//                    .HasColumnType("nvarchar(450)");

//                b.HasKey("UserId", "RoleId");

//                b.HasIndex("RoleId");

//                b.ToTable("AspNetUserRoles");
//            });

//            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
//            {
//                b.Property<string>("UserId")
//                    .HasColumnType("nvarchar(450)");

//                b.Property<string>("LoginProvider")
//                    .HasColumnType("nvarchar(128)")
//                    .HasMaxLength(128);

//                b.Property<string>("Name")
//                    .HasColumnType("nvarchar(128)")
//                    .HasMaxLength(128);

//                b.Property<string>("Value")
//                    .HasColumnType("nvarchar(max)");

//                b.HasKey("UserId", "LoginProvider", "Name");

//                b.ToTable("AspNetUserTokens");
//            });

//            modelBuilder.Entity("Domain.Models.Item", b =>
//            {
//                b.HasOne("Domain.Models.Category", "Category")
//                    .WithMany()
//                    .HasForeignKey("CategoryId")
//                    .OnDelete(DeleteBehavior.Cascade)
//                    .IsRequired();
//            });

//            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
//            {
//                b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
//                    .WithMany()
//                    .HasForeignKey("RoleId")
//                    .OnDelete(DeleteBehavior.Cascade)
//                    .IsRequired();
//            });

//            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
//            {
//                b.HasOne("Domain.Models.CustomUser", null)
//                    .WithMany()
//                    .HasForeignKey("UserId")
//                    .OnDelete(DeleteBehavior.Cascade)
//                    .IsRequired();
//            });

//            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
//            {
//                b.HasOne("Domain.Models.CustomUser", null)
//                    .WithMany()
//                    .HasForeignKey("UserId")
//                    .OnDelete(DeleteBehavior.Cascade)
//                    .IsRequired();
//            });

//            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
//            {
//                b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
//                    .WithMany()
//                    .HasForeignKey("RoleId")
//                    .OnDelete(DeleteBehavior.Cascade)
//                    .IsRequired();

//                b.HasOne("Domain.Models.CustomUser", null)
//                    .WithMany()
//                    .HasForeignKey("UserId")
//                    .OnDelete(DeleteBehavior.Cascade)
//                    .IsRequired();
//            });

//            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
//            {
//                b.HasOne("Domain.Models.CustomUser", null)
//                    .WithMany()
//                    .HasForeignKey("UserId")
//                    .OnDelete(DeleteBehavior.Cascade)
//                    .IsRequired();
//            });
//#pragma warning restore 612, 618
//        }
//    }
}

