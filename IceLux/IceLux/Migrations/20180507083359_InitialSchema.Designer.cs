﻿// <auto-generated />
using IceLux.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace IceLux.Migrations
{
    [DbContext(typeof(TakingContext))]
    [Migration("20180507083359_InitialSchema")]
    partial class InitialSchema
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("IceLux.Domain.Core.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("CustomerIdentifier");

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("IceLux.Domain.Core.Center", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("CenterId");

                    b.Property<string>("Code");

                    b.Property<int>("FirmId");

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsDefault");

                    b.Property<string>("Name");

                    b.Property<int?>("ParentCenterId");

                    b.HasKey("Id");

                    b.HasIndex("CenterId");

                    b.HasIndex("FirmId");

                    b.HasIndex("ParentCenterId");

                    b.ToTable("Centers");
                });

            modelBuilder.Entity("IceLux.Domain.Core.Firm", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<DateTime?>("ApproveDate");

                    b.Property<string>("Code");

                    b.Property<string>("ContactNumber");

                    b.Property<DateTime>("CreateDate");

                    b.Property<string>("Email");

                    b.Property<bool>("IsActive");

                    b.Property<string>("Name");

                    b.Property<string>("OwnerId");

                    b.HasKey("Id");

                    b.ToTable("Firms");
                });

            modelBuilder.Entity("IceLux.Domain.Core.FirmMember", b =>
                {
                    b.Property<int>("FirmId");

                    b.Property<string>("UserId");

                    b.Property<bool?>("AllowTaking");

                    b.Property<string>("ApplicationUserId");

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsAdmin");

                    b.HasKey("FirmId", "UserId");

                    b.HasIndex("ApplicationUserId");

                    b.ToTable("FirmMembers");
                });

            modelBuilder.Entity("IceLux.Domain.Core.Item", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Code");

                    b.Property<DateTime>("CreateDate");

                    b.Property<int>("FirmId");

                    b.Property<bool>("IsActive");

                    b.Property<int?>("LocaltoCenter");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("FirmId");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("IceLux.Domain.Core.Subscription", b =>
                {
                    b.Property<int>("SubscriptionId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Amount");

                    b.Property<Guid>("ApiKey");

                    b.Property<string>("ApplicationUserId");

                    b.Property<DateTime>("Expiry");

                    b.Property<string>("FigureAllowed");

                    b.Property<string>("PaymentSubscriptionId");

                    b.Property<DateTime>("PurchaseDate");

                    b.Property<string>("Type");

                    b.Property<string>("UserId");

                    b.HasKey("SubscriptionId");

                    b.HasIndex("ApplicationUserId");

                    b.ToTable("Subscriptions");
                });

            modelBuilder.Entity("IceLux.Domain.Core.Take", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CenterId");

                    b.Property<string>("TakeAsAt");

                    b.Property<DateTime>("TakeDate");

                    b.Property<string>("TakeType");

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("CenterId");

                    b.ToTable("Takes");
                });

            modelBuilder.Entity("IceLux.Domain.Core.TakeDetail", b =>
                {
                    b.Property<int>("TakeDetailId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("DetailBreakDown");

                    b.Property<bool?>("IsMainUnit");

                    b.Property<int>("ItemId");

                    b.Property<decimal>("Quantiy");

                    b.Property<int>("TakeId");

                    b.HasKey("TakeDetailId");

                    b.HasIndex("ItemId");

                    b.HasIndex("TakeId");

                    b.ToTable("TakeDetails");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("IceLux.Domain.Core.Center", b =>
                {
                    b.HasOne("IceLux.Domain.Core.Center")
                        .WithMany("Children")
                        .HasForeignKey("CenterId");

                    b.HasOne("IceLux.Domain.Core.Firm", "Firm")
                        .WithMany("Centers")
                        .HasForeignKey("FirmId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("IceLux.Domain.Core.Center", "ParentCenter")
                        .WithMany()
                        .HasForeignKey("ParentCenterId");
                });

            modelBuilder.Entity("IceLux.Domain.Core.FirmMember", b =>
                {
                    b.HasOne("IceLux.Domain.Core.ApplicationUser", "ApplicationUser")
                        .WithMany("FirmMembers")
                        .HasForeignKey("ApplicationUserId");

                    b.HasOne("IceLux.Domain.Core.Firm", "Firm")
                        .WithMany("FirmMembers")
                        .HasForeignKey("FirmId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("IceLux.Domain.Core.Item", b =>
                {
                    b.HasOne("IceLux.Domain.Core.Firm", "Firm")
                        .WithMany("Items")
                        .HasForeignKey("FirmId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("IceLux.Domain.Core.Subscription", b =>
                {
                    b.HasOne("IceLux.Domain.Core.ApplicationUser")
                        .WithMany("Subscriptions")
                        .HasForeignKey("ApplicationUserId");
                });

            modelBuilder.Entity("IceLux.Domain.Core.Take", b =>
                {
                    b.HasOne("IceLux.Domain.Core.Center", "Center")
                        .WithMany("Takes")
                        .HasForeignKey("CenterId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("IceLux.Domain.Core.TakeDetail", b =>
                {
                    b.HasOne("IceLux.Domain.Core.Item", "Item")
                        .WithMany()
                        .HasForeignKey("ItemId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("IceLux.Domain.Core.Take", "Take")
                        .WithMany("TakeDetails")
                        .HasForeignKey("TakeId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("IceLux.Domain.Core.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("IceLux.Domain.Core.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("IceLux.Domain.Core.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("IceLux.Domain.Core.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
