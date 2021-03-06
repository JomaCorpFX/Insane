﻿// <auto-generated />
using System;
using Insane.AspNet.Identity.Model1.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Insane.Migrations.SqlServer.IdentitySqlServerDbContext_
{
    [DbContext(typeof(IdentitySqlServerDbContext))]
    partial class IdentitySqlServerDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Insane.AspNet.Identity.Model1.Entity.IdentityOrganization", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 10000)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset>("ActiveUntil")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("AddressLine1")
                        .IsRequired()
                        .HasMaxLength(128)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("AddresssLine2")
                        .IsRequired()
                        .HasMaxLength(128)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(128)");

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<bool>("Enabled")
                        .HasColumnType("bit");

                    b.Property<string>("LogoUri")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(128)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(16)
                        .HasColumnType("nvarchar(16)");

                    b.HasKey("Id")
                        .HasName("P_IdentityOrganization_Id_dbb7e");

                    b.HasIndex("Name")
                        .IsUnique()
                        .HasDatabaseName("U_IdentityOrganization_Name_f13bc");

                    b.ToTable("IdentityOrganization");
                });

            modelBuilder.Entity("Insane.AspNet.Identity.Model1.Entity.IdentityPermission", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 10000)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset>("ActiveUntil")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<bool>("Enabled")
                        .HasColumnType("bit");

                    b.Property<long>("OrganizationId")
                        .HasColumnType("bigint");

                    b.Property<long>("RoleId")
                        .HasColumnType("bigint");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("Id")
                        .HasName("P_IdentityPermission_Id_aa4e4");

                    b.HasIndex("OrganizationId")
                        .HasDatabaseName("I_IdentityPermission_OrganizationId_ef38a");

                    b.HasIndex("RoleId")
                        .HasDatabaseName("I_IdentityPermission_RoleId_c1b82");

                    b.HasIndex("UserId")
                        .HasDatabaseName("I_IdentityPermission_UserId_a10ab");

                    b.HasIndex("UserId", "RoleId", "OrganizationId")
                        .IsUnique()
                        .HasDatabaseName("U_IdentityPermission_UserId_RoleId_OrganizationId_800d6");

                    b.ToTable("IdentityPermission");
                });

            modelBuilder.Entity("Insane.AspNet.Identity.Model1.Entity.IdentityPlatform", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 10000)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset>("ActiveUntil")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(512)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(512)");

                    b.Property<bool>("Enabled")
                        .HasColumnType("bit");

                    b.Property<string>("LogoUri")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(128)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("SecretKey")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.HasKey("Id")
                        .HasName("P_IdentityPlatform_Id_a8230");

                    b.HasIndex("Name")
                        .IsUnique()
                        .HasDatabaseName("U_IdentityPlatform_Name_423b5");

                    b.HasIndex("SecretKey")
                        .IsUnique()
                        .HasDatabaseName("U_IdentityPlatform_SecretKey_e10ba");

                    b.ToTable("IdentityPlatform");
                });

            modelBuilder.Entity("Insane.AspNet.Identity.Model1.Entity.IdentityRole", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 10000)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset>("ActiveUntil")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<bool>("Enabled")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(128)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(128)");

                    b.HasKey("Id")
                        .HasName("P_IdentityRole_Id_5f896");

                    b.HasIndex("Name")
                        .IsUnique()
                        .HasDatabaseName("U_IdentityRole_Name_36689");

                    b.ToTable("IdentityRole");
                });

            modelBuilder.Entity("Insane.AspNet.Identity.Model1.Entity.IdentitySession", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 10000)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClientFriendlyName")
                        .IsRequired()
                        .HasMaxLength(128)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ClientIP")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.Property<decimal>("ClientLatitude")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("ClientLongitude")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ClientOS")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<int>("ClientTimezone")
                        .HasColumnType("int");

                    b.Property<string>("ClientUserAgent")
                        .IsRequired()
                        .HasMaxLength(512)
                        .HasColumnType("nvarchar(512)");

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset>("ExpiresAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Jti")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Key")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<long>("PermissionId")
                        .HasColumnType("bigint");

                    b.Property<long>("PlatformId")
                        .HasColumnType("bigint");

                    b.Property<string>("RefreshToken")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<bool>("Revoked")
                        .HasColumnType("bit");

                    b.Property<string>("TokenHash")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.HasKey("Id")
                        .HasName("P_IdentitySession_Id_ecb1d");

                    b.HasIndex("Jti")
                        .IsUnique()
                        .HasDatabaseName("U_IdentitySession_Jti_b9210");

                    b.HasIndex("Key")
                        .IsUnique()
                        .HasDatabaseName("U_IdentitySession_Key_45f50");

                    b.HasIndex("PermissionId")
                        .HasDatabaseName("I_IdentitySession_PermissionId_eb569");

                    b.HasIndex("PlatformId")
                        .HasDatabaseName("I_IdentitySession_PlatformId_0a8ea");

                    b.HasIndex("RefreshToken")
                        .IsUnique()
                        .HasDatabaseName("U_IdentitySession_RefreshToken_bc11c");

                    b.HasIndex("TokenHash")
                        .IsUnique()
                        .HasDatabaseName("U_IdentitySession_TokenHash_15499");

                    b.ToTable("IdentitySession");
                });

            modelBuilder.Entity("Insane.AspNet.Identity.Model1.Entity.IdentityUser", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 10000)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("EmailConfirmationCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("EmailConfirmationDeadline")
                        .HasColumnType("datetimeoffset");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("Enabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset>("LockoutUntil")
                        .HasColumnType("datetimeoffset");

                    b.Property<int>("LoginFailCount")
                        .HasColumnType("int");

                    b.Property<string>("Mobile")
                        .IsRequired()
                        .HasMaxLength(16)
                        .HasColumnType("nvarchar(16)");

                    b.Property<string>("MobileConfirmationCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("MobileConfirmationDeadline")
                        .HasColumnType("datetimeoffset");

                    b.Property<bool>("MobileConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("NormalizedEmail")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("NormalizedUsername")
                        .IsRequired()
                        .HasMaxLength(128)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Phone")
                        .HasMaxLength(16)
                        .HasColumnType("nvarchar(16)");

                    b.Property<string>("UniqueId")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(128)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(128)");

                    b.HasKey("Id")
                        .HasName("P_IdentityUser_Id_d06a2");

                    b.HasIndex("Email")
                        .IsUnique()
                        .HasDatabaseName("U_IdentityUser_Email_a5252");

                    b.HasIndex("Mobile")
                        .IsUnique()
                        .HasDatabaseName("U_IdentityUser_Mobile_b52fb");

                    b.HasIndex("UniqueId")
                        .IsUnique()
                        .HasDatabaseName("U_IdentityUser_UniqueId_e083b");

                    b.HasIndex("Username")
                        .IsUnique()
                        .HasDatabaseName("U_IdentityUser_Username_85643");

                    b.ToTable("IdentityUser");
                });

            modelBuilder.Entity("Insane.AspNet.Identity.Model1.Entity.IdentityPermission", b =>
                {
                    b.HasOne("Insane.AspNet.Identity.Model1.Entity.IdentityOrganization", "Organization")
                        .WithMany("Permissions")
                        .HasForeignKey("OrganizationId")
                        .HasConstraintName("F_IdentityPermission_OrganizationId_98097")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Insane.AspNet.Identity.Model1.Entity.IdentityRole", "Role")
                        .WithMany("Permissions")
                        .HasForeignKey("RoleId")
                        .HasConstraintName("F_IdentityPermission_RoleId_63ea2")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Insane.AspNet.Identity.Model1.Entity.IdentityUser", "User")
                        .WithMany("Permissions")
                        .HasForeignKey("UserId")
                        .HasConstraintName("F_IdentityPermission_UserId_c3dfe")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Organization");

                    b.Navigation("Role");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Insane.AspNet.Identity.Model1.Entity.IdentitySession", b =>
                {
                    b.HasOne("Insane.AspNet.Identity.Model1.Entity.IdentityPermission", "Permission")
                        .WithMany("Sessions")
                        .HasForeignKey("PermissionId")
                        .HasConstraintName("F_IdentitySession_PermissionId_68abc")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Insane.AspNet.Identity.Model1.Entity.IdentityPlatform", "Platform")
                        .WithMany("Sessions")
                        .HasForeignKey("PlatformId")
                        .HasConstraintName("F_IdentitySession_PlatformId_83f1d")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Permission");

                    b.Navigation("Platform");
                });

            modelBuilder.Entity("Insane.AspNet.Identity.Model1.Entity.IdentityOrganization", b =>
                {
                    b.Navigation("Permissions");
                });

            modelBuilder.Entity("Insane.AspNet.Identity.Model1.Entity.IdentityPermission", b =>
                {
                    b.Navigation("Sessions");
                });

            modelBuilder.Entity("Insane.AspNet.Identity.Model1.Entity.IdentityPlatform", b =>
                {
                    b.Navigation("Sessions");
                });

            modelBuilder.Entity("Insane.AspNet.Identity.Model1.Entity.IdentityRole", b =>
                {
                    b.Navigation("Permissions");
                });

            modelBuilder.Entity("Insane.AspNet.Identity.Model1.Entity.IdentityUser", b =>
                {
                    b.Navigation("Permissions");
                });
#pragma warning restore 612, 618
        }
    }
}
