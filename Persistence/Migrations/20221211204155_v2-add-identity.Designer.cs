﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persistence.Database;

#nullable disable

namespace Persistence.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20221211204155_v2-add-identity")]
    partial class v2addidentity
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Domain.Models.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Price")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = new Guid("c64c6feb-2706-4079-882a-af29f6e7d4f8"),
                            Description = "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients",
                            Name = "Handmade Fresh Chips",
                            Price = "958.73"
                        },
                        new
                        {
                            Id = new Guid("cd5aa79e-04b5-44f5-afdb-0a1394600b50"),
                            Description = "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support",
                            Name = "Handmade Concrete Fish",
                            Price = "908.15"
                        },
                        new
                        {
                            Id = new Guid("967f0264-8d6e-4b12-98d1-df376a4a198f"),
                            Description = "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J",
                            Name = "Fantastic Wooden Pizza",
                            Price = "351.61"
                        },
                        new
                        {
                            Id = new Guid("1052a722-4bad-4007-8c93-5c6a3edbc737"),
                            Description = "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients",
                            Name = "Rustic Wooden Pants",
                            Price = "765.75"
                        },
                        new
                        {
                            Id = new Guid("be84d1f9-4b7f-4225-9788-b2488510718b"),
                            Description = "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart",
                            Name = "Awesome Soft Sausages",
                            Price = "741.29"
                        },
                        new
                        {
                            Id = new Guid("fb106614-229a-43a8-a87e-cf962c92539a"),
                            Description = "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive",
                            Name = "Fantastic Steel Ball",
                            Price = "505.05"
                        },
                        new
                        {
                            Id = new Guid("cd2a3a50-b540-474b-94a4-1b9c63c13078"),
                            Description = "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J",
                            Name = "Incredible Wooden Pizza",
                            Price = "823.21"
                        },
                        new
                        {
                            Id = new Guid("e97c589b-1bf0-42b0-8cbb-44f69c3a6af6"),
                            Description = "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit",
                            Name = "Fantastic Concrete Pizza",
                            Price = "715.80"
                        },
                        new
                        {
                            Id = new Guid("f3a2fbfa-d523-48f5-a180-700c46803741"),
                            Description = "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J",
                            Name = "Refined Concrete Pizza",
                            Price = "242.27"
                        },
                        new
                        {
                            Id = new Guid("2dbddf09-d29d-4b38-95f6-d44f5604da0a"),
                            Description = "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016",
                            Name = "Small Concrete Chicken",
                            Price = "13.64"
                        },
                        new
                        {
                            Id = new Guid("77bf7f84-4f82-4054-964f-8ddcf275629c"),
                            Description = "The Football Is Good For Training And Recreational Purposes",
                            Name = "Fantastic Soft Shoes",
                            Price = "844.51"
                        },
                        new
                        {
                            Id = new Guid("376dc413-6e41-4706-8da5-c5d519810258"),
                            Description = "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit",
                            Name = "Generic Soft Gloves",
                            Price = "19.66"
                        },
                        new
                        {
                            Id = new Guid("acb2a2b9-09e2-47a7-ada5-d5db061e083a"),
                            Description = "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality",
                            Name = "Unbranded Frozen Keyboard",
                            Price = "83.32"
                        },
                        new
                        {
                            Id = new Guid("2f61d61f-6a12-4c6d-adf0-2148f9eb4195"),
                            Description = "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality",
                            Name = "Awesome Rubber Towels",
                            Price = "488.13"
                        },
                        new
                        {
                            Id = new Guid("6c61a6f9-5de5-4c8e-8e30-0501ce287b5f"),
                            Description = "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design",
                            Name = "Refined Rubber Sausages",
                            Price = "600.51"
                        },
                        new
                        {
                            Id = new Guid("992116ce-db94-45ac-b3f7-beeab1a6dda9"),
                            Description = "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design",
                            Name = "Generic Soft Salad",
                            Price = "399.39"
                        },
                        new
                        {
                            Id = new Guid("af78a6a4-bf80-46b0-8b62-ae773f27f249"),
                            Description = "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart",
                            Name = "Refined Wooden Chair",
                            Price = "250.62"
                        },
                        new
                        {
                            Id = new Guid("e139d502-2e4d-4337-8ee5-e3bdd4152505"),
                            Description = "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design",
                            Name = "Unbranded Granite Pants",
                            Price = "374.35"
                        },
                        new
                        {
                            Id = new Guid("25f6f6db-56e8-4314-9271-712699f6a7b4"),
                            Description = "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality",
                            Name = "Ergonomic Plastic Tuna",
                            Price = "209.53"
                        },
                        new
                        {
                            Id = new Guid("8f9bd6ca-faa7-4902-8ad9-f727bbd4ba24"),
                            Description = "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals",
                            Name = "Sleek Rubber Ball",
                            Price = "9.45"
                        },
                        new
                        {
                            Id = new Guid("52a6a7f1-6efa-475b-bda7-bb6454983f8b"),
                            Description = "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016",
                            Name = "Awesome Granite Gloves",
                            Price = "103.29"
                        },
                        new
                        {
                            Id = new Guid("cb907ae5-efee-4464-9d1c-cbeaca19364e"),
                            Description = "The Football Is Good For Training And Recreational Purposes",
                            Name = "Handmade Steel Towels",
                            Price = "756.56"
                        },
                        new
                        {
                            Id = new Guid("93664166-aab6-45cf-b75d-678f5ea9115d"),
                            Description = "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design",
                            Name = "Intelligent Soft Cheese",
                            Price = "179.73"
                        },
                        new
                        {
                            Id = new Guid("1fec2a49-af75-4777-a0f7-97f985bd480c"),
                            Description = "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit",
                            Name = "Handcrafted Metal Gloves",
                            Price = "253.54"
                        },
                        new
                        {
                            Id = new Guid("14401fec-c682-4811-9697-6b46a3c67b29"),
                            Description = "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design",
                            Name = "Handmade Wooden Sausages",
                            Price = "775.18"
                        },
                        new
                        {
                            Id = new Guid("3c7f0bd1-d00b-46f5-a8e0-3362cf3aa8db"),
                            Description = "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart",
                            Name = "Handmade Granite Chair",
                            Price = "352.36"
                        },
                        new
                        {
                            Id = new Guid("84bca415-23da-41d4-a393-c69fcf190997"),
                            Description = "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles",
                            Name = "Gorgeous Frozen Bacon",
                            Price = "329.73"
                        },
                        new
                        {
                            Id = new Guid("fa81854f-0de0-4271-b229-0021a468d898"),
                            Description = "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles",
                            Name = "Unbranded Frozen Soap",
                            Price = "700.97"
                        },
                        new
                        {
                            Id = new Guid("fe1bb3b2-03fa-4e09-8b21-1cd51332434f"),
                            Description = "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive",
                            Name = "Generic Rubber Bacon",
                            Price = "38.77"
                        },
                        new
                        {
                            Id = new Guid("c14bbb2b-dd26-48c2-bbd9-bcdbc89e273b"),
                            Description = "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals",
                            Name = "Rustic Wooden Shirt",
                            Price = "597.80"
                        },
                        new
                        {
                            Id = new Guid("777569ca-fa50-4009-af0c-87d633be179b"),
                            Description = "The Football Is Good For Training And Recreational Purposes",
                            Name = "Refined Concrete Bike",
                            Price = "105.60"
                        },
                        new
                        {
                            Id = new Guid("b1315539-1db5-493c-9993-dac500f4106b"),
                            Description = "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J",
                            Name = "Generic Concrete Ball",
                            Price = "412.79"
                        },
                        new
                        {
                            Id = new Guid("e69f9bc0-3a31-4cf8-a80c-353dda3533e5"),
                            Description = "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals",
                            Name = "Ergonomic Plastic Sausages",
                            Price = "38.62"
                        },
                        new
                        {
                            Id = new Guid("2c1cd185-cfc3-44e0-b6ea-7311c971ce37"),
                            Description = "The Football Is Good For Training And Recreational Purposes",
                            Name = "Ergonomic Fresh Shoes",
                            Price = "523.46"
                        },
                        new
                        {
                            Id = new Guid("b676d9b9-b6d6-46ac-865f-18af10839a2d"),
                            Description = "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive",
                            Name = "Incredible Wooden Ball",
                            Price = "882.69"
                        },
                        new
                        {
                            Id = new Guid("c707c49d-89ed-479e-bac5-bcbe23f4cc19"),
                            Description = "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart",
                            Name = "Unbranded Concrete Towels",
                            Price = "813.97"
                        },
                        new
                        {
                            Id = new Guid("da67644c-a999-4363-b15c-ba2e1db1aeac"),
                            Description = "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J",
                            Name = "Generic Wooden Salad",
                            Price = "158.20"
                        },
                        new
                        {
                            Id = new Guid("bb65bbfa-fa8e-4c6c-aef1-94902c3ae877"),
                            Description = "The Football Is Good For Training And Recreational Purposes",
                            Name = "Refined Frozen Ball",
                            Price = "528.62"
                        },
                        new
                        {
                            Id = new Guid("df574ec5-ca96-475d-9d29-6194e3d3f734"),
                            Description = "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals",
                            Name = "Tasty Rubber Chicken",
                            Price = "889.50"
                        },
                        new
                        {
                            Id = new Guid("d76f786c-7ed5-48bc-8113-47fff300491c"),
                            Description = "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016",
                            Name = "Gorgeous Cotton Chicken",
                            Price = "453.93"
                        },
                        new
                        {
                            Id = new Guid("c78cdf3d-2677-457b-a4eb-217082acf152"),
                            Description = "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart",
                            Name = "Awesome Granite Bacon",
                            Price = "360.91"
                        },
                        new
                        {
                            Id = new Guid("984dab8e-7279-41f8-8140-085effb804e2"),
                            Description = "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart",
                            Name = "Gorgeous Cotton Chips",
                            Price = "824.14"
                        },
                        new
                        {
                            Id = new Guid("f8687ef7-c622-45f3-b152-75621e2d5acb"),
                            Description = "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles",
                            Name = "Refined Granite Table",
                            Price = "18.83"
                        },
                        new
                        {
                            Id = new Guid("50d830f1-1f64-4a14-b1b4-6dd86d90a599"),
                            Description = "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive",
                            Name = "Awesome Rubber Bacon",
                            Price = "55.62"
                        },
                        new
                        {
                            Id = new Guid("93f868fd-b8fb-45a0-afe7-c2350276242b"),
                            Description = "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J",
                            Name = "Sleek Soft Shoes",
                            Price = "638.25"
                        },
                        new
                        {
                            Id = new Guid("bc47c040-7e60-4877-9280-3b0cf2f107b0"),
                            Description = "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart",
                            Name = "Awesome Rubber Soap",
                            Price = "305.36"
                        },
                        new
                        {
                            Id = new Guid("5481576a-92f0-4fee-93f3-10e4c64805e0"),
                            Description = "The Football Is Good For Training And Recreational Purposes",
                            Name = "Handmade Concrete Chicken",
                            Price = "466.57"
                        },
                        new
                        {
                            Id = new Guid("741a9765-a8f7-4ecc-9f03-3cfe64b4d234"),
                            Description = "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support",
                            Name = "Incredible Plastic Pizza",
                            Price = "161.22"
                        },
                        new
                        {
                            Id = new Guid("00961171-9252-4a07-bc37-44201b76a765"),
                            Description = "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J",
                            Name = "Handcrafted Concrete Ball",
                            Price = "964.25"
                        },
                        new
                        {
                            Id = new Guid("3f8068b9-f83d-4611-828c-403fa1f7a857"),
                            Description = "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart",
                            Name = "Gorgeous Granite Fish",
                            Price = "48.93"
                        },
                        new
                        {
                            Id = new Guid("6ba0addb-662f-4d89-a128-1bdee7f6be9d"),
                            Description = "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive",
                            Name = "Generic Wooden Pizza",
                            Price = "334.39"
                        },
                        new
                        {
                            Id = new Guid("0359626f-c8c9-4114-a5a4-e2517a455eb5"),
                            Description = "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support",
                            Name = "Gorgeous Frozen Tuna",
                            Price = "554.76"
                        },
                        new
                        {
                            Id = new Guid("4fffec20-3255-4005-bba4-aa02df4f5189"),
                            Description = "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support",
                            Name = "Generic Plastic Cheese",
                            Price = "718.03"
                        },
                        new
                        {
                            Id = new Guid("1f0a77b5-a99e-4041-83b5-6e7cc1d7c196"),
                            Description = "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit",
                            Name = "Licensed Metal Car",
                            Price = "610.56"
                        },
                        new
                        {
                            Id = new Guid("f5d5a370-886f-45a7-8b5e-41aa893fff3a"),
                            Description = "The Football Is Good For Training And Recreational Purposes",
                            Name = "Fantastic Frozen Fish",
                            Price = "207.78"
                        },
                        new
                        {
                            Id = new Guid("d5e2dcad-d309-4fdf-8b7e-9c8c3e423abb"),
                            Description = "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016",
                            Name = "Unbranded Granite Chair",
                            Price = "826.24"
                        },
                        new
                        {
                            Id = new Guid("c75e7014-a5a0-4a05-9f59-f2dd805bf197"),
                            Description = "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive",
                            Name = "Incredible Plastic Chips",
                            Price = "869.02"
                        },
                        new
                        {
                            Id = new Guid("f9a808de-240e-49bb-8dbe-f498e2ecf267"),
                            Description = "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive",
                            Name = "Awesome Soft Bike",
                            Price = "682.29"
                        },
                        new
                        {
                            Id = new Guid("71160ad1-ffc6-44a8-94a3-951ce52b4ec6"),
                            Description = "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive",
                            Name = "Sleek Wooden Chips",
                            Price = "379.89"
                        },
                        new
                        {
                            Id = new Guid("6440ad8b-5564-4019-b2a5-2fb250970570"),
                            Description = "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart",
                            Name = "Refined Soft Hat",
                            Price = "947.52"
                        },
                        new
                        {
                            Id = new Guid("098aff23-4666-42e1-bbe3-81d6aa64cb12"),
                            Description = "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals",
                            Name = "Rustic Concrete Sausages",
                            Price = "266.21"
                        },
                        new
                        {
                            Id = new Guid("5aedd4b3-4cb5-433c-a246-4c4a694afb2c"),
                            Description = "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles",
                            Name = "Awesome Frozen Salad",
                            Price = "371.98"
                        },
                        new
                        {
                            Id = new Guid("ba083013-8a9d-4af4-8518-7085461f4b2f"),
                            Description = "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design",
                            Name = "Licensed Granite Shoes",
                            Price = "341.92"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
