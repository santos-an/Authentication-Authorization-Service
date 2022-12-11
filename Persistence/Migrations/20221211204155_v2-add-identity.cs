using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class v2addidentity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("006c5c42-62ca-4604-a08b-63429fc47fce"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("02eea13c-c632-4077-8f09-186371d87738"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0e7da4d0-bdd2-4261-9a33-4de0233cd4de"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1326ef6c-2446-4023-a0e4-5ccce1c4cc84"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("17437190-0385-4fc9-a3c3-b7eca1aeeb47"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("18739b05-a6a2-4ebc-b009-7c492ee5a2bc"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1953eab9-48a5-4877-8164-21213c09f633"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1aa7e2dd-dcba-43e6-a628-7ff1e1bca851"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("24ff8308-81cf-4b1b-a650-c3f0ac5fb872"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2524dccd-9ae8-4c74-9260-8d4d652e752b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("276f0776-7870-4858-a135-856b2367f49a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2ea13d61-8095-4860-88d7-73a4ae30903d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2f247d47-2149-43b5-88e9-f06bfc73e8c7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3870dff0-1d25-4bfc-8179-c61294924dbb"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("40010837-9b5b-4c4f-97a0-ea32c8e16e43"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("407b95ca-cd5b-4297-bc2b-c00697b0df59"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("444291ea-f052-4c08-9456-956bf5fc3cb4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("44543f72-ede7-49c3-9a02-8d1283a23f5e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("48c2e651-435b-4339-945d-a3489aedd093"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("48d9474d-5afe-4429-8200-482f5f1fa73c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("512d6b22-9858-4473-aa2f-836bceab4b0b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("536bd696-c455-4893-a25f-26392b41d3c4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("55079c16-7ae0-4cd0-9261-e06be6693455"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("566a675a-eef1-425f-a516-9bb64bb6bd05"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("56882157-ef94-42de-9d52-c48bec0d018c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5b8aa408-9a7a-4265-9e1d-8ca69e112226"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5c56912d-7459-4afb-b4ff-304a50ed5b04"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5cdf4ea8-d493-4166-b101-10190c4bd5f3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5dd714b9-904f-49bc-bbd6-689b14c28808"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("623edeb5-2562-436a-9049-7b2a28d887e2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6498309c-060b-436d-9d86-1c5c37181a51"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("666bb009-7699-4f1a-af63-c77cc051a36a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("66c8508d-bac9-4c1c-9bec-bd887a502beb"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("67691693-8414-4dc4-a24e-54c1e0fdad31"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6c6a2500-e92d-4b77-93e3-75a00ac3d251"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("76175ffd-f04c-4e9a-bf5f-2c7d77e2b2a3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7b2e0079-33ae-41f5-8e19-560b1741a4ae"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7eaed778-e52e-4e5d-bf27-7dea55ee0383"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7f74a069-9e0d-4fb6-8b0c-136d6285f2c8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7ffd8abe-874c-46b2-9be7-2dc4004e1e45"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("814d50d7-d8a1-45f9-8985-4874fcef6f99"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("81d5a9df-6351-4618-929c-fc0f5d7bc6dd"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("84f2aaea-f131-41f6-b765-efa7c7fe85de"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("85cda0e5-c5d0-4b4d-92b0-dcd5ab0361ee"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("891bc6c4-9e41-445a-aa9a-1705e803d97c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("89c90a04-9b4b-4fb0-aee3-d77920e1965b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8b413dbd-8272-4ef7-95eb-d58b2c83d40e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8be82d3f-adf8-4241-9560-2b7d634d75fa"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8bf2b17e-b6ac-49e6-a94e-815b028fcb81"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8fa586fc-5351-40ad-b347-0a2a3b1d7f1e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9628a2f2-98a6-4114-b089-bf4217538ef7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("98df2ff4-1adf-4c2b-b6a0-fe41d99612c0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9a07c97b-781e-4df1-a0f1-410746b0e785"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9b14fb40-e7aa-4c75-8ee6-9ac56f248a59"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a2969bf9-3bf5-4f23-bbe7-c1e325664d07"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a816eb31-b920-47ff-a08b-3edc3fa55211"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a8690b96-3a40-419f-9266-4d1a3308de4c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a88e00c1-22a0-4284-b500-28927f74bc27"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ad8aff89-4e11-4b15-9ea7-f300e43e217b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b254e750-15ec-4644-a01e-01561a811e37"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b2715386-e67c-4e40-90d4-0b160b7eff6b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b62c01ce-98b1-45b8-a021-70bedc6e7789"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b9901066-6fa4-4998-8b5f-d75363a16d5a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ba460e59-92d9-4170-8da0-61d2c423cb13"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ba62f464-f04a-4fcc-ae5a-135763ecada8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bb70e0ab-72b6-4c0f-9fad-a579d6695115"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c65a0386-0922-4ea9-98bd-6ba4ccf05744"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cb8fbee9-bebb-4612-bfd4-a9e5c3408713"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cba0d752-732a-499d-9198-09e81c5e5a30"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cce5cc97-8c1d-440c-9ed6-e19c2fda83c1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d266e84e-9119-4cd3-a893-356ae870bb32"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e12a8de8-fc2f-4bcf-b561-3c87f463716b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e2ea0a0f-0a31-48f4-a35a-459107b3f46e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e4ff1c8b-8448-406c-aaa0-9f99b94caf73"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e7b7bde1-e8aa-4a44-bb9e-3f71dd4de034"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e8fd5ec8-adcf-4126-bc3e-732d155c1b6f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("eabd4ad1-3e02-46fc-9c8e-d3f14fdf692a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ec4e3258-484a-4124-a341-35185bc3c06c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f6e7c7ba-6b77-4207-8789-6de2ff5b290f"));

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("00961171-9252-4a07-bc37-44201b76a765"), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Handcrafted Concrete Ball", "964.25" },
                    { new Guid("0359626f-c8c9-4114-a5a4-e2517a455eb5"), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Gorgeous Frozen Tuna", "554.76" },
                    { new Guid("098aff23-4666-42e1-bbe3-81d6aa64cb12"), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Rustic Concrete Sausages", "266.21" },
                    { new Guid("1052a722-4bad-4007-8c93-5c6a3edbc737"), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Rustic Wooden Pants", "765.75" },
                    { new Guid("14401fec-c682-4811-9697-6b46a3c67b29"), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Handmade Wooden Sausages", "775.18" },
                    { new Guid("1f0a77b5-a99e-4041-83b5-6e7cc1d7c196"), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Licensed Metal Car", "610.56" },
                    { new Guid("1fec2a49-af75-4777-a0f7-97f985bd480c"), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Handcrafted Metal Gloves", "253.54" },
                    { new Guid("25f6f6db-56e8-4314-9271-712699f6a7b4"), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Ergonomic Plastic Tuna", "209.53" },
                    { new Guid("2c1cd185-cfc3-44e0-b6ea-7311c971ce37"), "The Football Is Good For Training And Recreational Purposes", "Ergonomic Fresh Shoes", "523.46" },
                    { new Guid("2dbddf09-d29d-4b38-95f6-d44f5604da0a"), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Small Concrete Chicken", "13.64" },
                    { new Guid("2f61d61f-6a12-4c6d-adf0-2148f9eb4195"), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Awesome Rubber Towels", "488.13" },
                    { new Guid("376dc413-6e41-4706-8da5-c5d519810258"), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Generic Soft Gloves", "19.66" },
                    { new Guid("3c7f0bd1-d00b-46f5-a8e0-3362cf3aa8db"), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Handmade Granite Chair", "352.36" },
                    { new Guid("3f8068b9-f83d-4611-828c-403fa1f7a857"), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Gorgeous Granite Fish", "48.93" },
                    { new Guid("4fffec20-3255-4005-bba4-aa02df4f5189"), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Generic Plastic Cheese", "718.03" },
                    { new Guid("50d830f1-1f64-4a14-b1b4-6dd86d90a599"), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Awesome Rubber Bacon", "55.62" },
                    { new Guid("52a6a7f1-6efa-475b-bda7-bb6454983f8b"), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Awesome Granite Gloves", "103.29" },
                    { new Guid("5481576a-92f0-4fee-93f3-10e4c64805e0"), "The Football Is Good For Training And Recreational Purposes", "Handmade Concrete Chicken", "466.57" },
                    { new Guid("5aedd4b3-4cb5-433c-a246-4c4a694afb2c"), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Awesome Frozen Salad", "371.98" },
                    { new Guid("6440ad8b-5564-4019-b2a5-2fb250970570"), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Refined Soft Hat", "947.52" },
                    { new Guid("6ba0addb-662f-4d89-a128-1bdee7f6be9d"), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Generic Wooden Pizza", "334.39" },
                    { new Guid("6c61a6f9-5de5-4c8e-8e30-0501ce287b5f"), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Refined Rubber Sausages", "600.51" },
                    { new Guid("71160ad1-ffc6-44a8-94a3-951ce52b4ec6"), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Sleek Wooden Chips", "379.89" },
                    { new Guid("741a9765-a8f7-4ecc-9f03-3cfe64b4d234"), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Incredible Plastic Pizza", "161.22" },
                    { new Guid("777569ca-fa50-4009-af0c-87d633be179b"), "The Football Is Good For Training And Recreational Purposes", "Refined Concrete Bike", "105.60" },
                    { new Guid("77bf7f84-4f82-4054-964f-8ddcf275629c"), "The Football Is Good For Training And Recreational Purposes", "Fantastic Soft Shoes", "844.51" },
                    { new Guid("84bca415-23da-41d4-a393-c69fcf190997"), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Gorgeous Frozen Bacon", "329.73" },
                    { new Guid("8f9bd6ca-faa7-4902-8ad9-f727bbd4ba24"), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Sleek Rubber Ball", "9.45" },
                    { new Guid("93664166-aab6-45cf-b75d-678f5ea9115d"), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Intelligent Soft Cheese", "179.73" },
                    { new Guid("93f868fd-b8fb-45a0-afe7-c2350276242b"), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Sleek Soft Shoes", "638.25" },
                    { new Guid("967f0264-8d6e-4b12-98d1-df376a4a198f"), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Fantastic Wooden Pizza", "351.61" },
                    { new Guid("984dab8e-7279-41f8-8140-085effb804e2"), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Gorgeous Cotton Chips", "824.14" },
                    { new Guid("992116ce-db94-45ac-b3f7-beeab1a6dda9"), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Generic Soft Salad", "399.39" },
                    { new Guid("acb2a2b9-09e2-47a7-ada5-d5db061e083a"), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Unbranded Frozen Keyboard", "83.32" },
                    { new Guid("af78a6a4-bf80-46b0-8b62-ae773f27f249"), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Refined Wooden Chair", "250.62" },
                    { new Guid("b1315539-1db5-493c-9993-dac500f4106b"), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Generic Concrete Ball", "412.79" },
                    { new Guid("b676d9b9-b6d6-46ac-865f-18af10839a2d"), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Incredible Wooden Ball", "882.69" },
                    { new Guid("ba083013-8a9d-4af4-8518-7085461f4b2f"), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Licensed Granite Shoes", "341.92" },
                    { new Guid("bb65bbfa-fa8e-4c6c-aef1-94902c3ae877"), "The Football Is Good For Training And Recreational Purposes", "Refined Frozen Ball", "528.62" },
                    { new Guid("bc47c040-7e60-4877-9280-3b0cf2f107b0"), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Awesome Rubber Soap", "305.36" },
                    { new Guid("be84d1f9-4b7f-4225-9788-b2488510718b"), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Awesome Soft Sausages", "741.29" },
                    { new Guid("c14bbb2b-dd26-48c2-bbd9-bcdbc89e273b"), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Rustic Wooden Shirt", "597.80" },
                    { new Guid("c64c6feb-2706-4079-882a-af29f6e7d4f8"), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Handmade Fresh Chips", "958.73" },
                    { new Guid("c707c49d-89ed-479e-bac5-bcbe23f4cc19"), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Unbranded Concrete Towels", "813.97" },
                    { new Guid("c75e7014-a5a0-4a05-9f59-f2dd805bf197"), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Incredible Plastic Chips", "869.02" },
                    { new Guid("c78cdf3d-2677-457b-a4eb-217082acf152"), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Awesome Granite Bacon", "360.91" },
                    { new Guid("cb907ae5-efee-4464-9d1c-cbeaca19364e"), "The Football Is Good For Training And Recreational Purposes", "Handmade Steel Towels", "756.56" },
                    { new Guid("cd2a3a50-b540-474b-94a4-1b9c63c13078"), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Incredible Wooden Pizza", "823.21" },
                    { new Guid("cd5aa79e-04b5-44f5-afdb-0a1394600b50"), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Handmade Concrete Fish", "908.15" },
                    { new Guid("d5e2dcad-d309-4fdf-8b7e-9c8c3e423abb"), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Unbranded Granite Chair", "826.24" },
                    { new Guid("d76f786c-7ed5-48bc-8113-47fff300491c"), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Gorgeous Cotton Chicken", "453.93" },
                    { new Guid("da67644c-a999-4363-b15c-ba2e1db1aeac"), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Generic Wooden Salad", "158.20" },
                    { new Guid("df574ec5-ca96-475d-9d29-6194e3d3f734"), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Tasty Rubber Chicken", "889.50" },
                    { new Guid("e139d502-2e4d-4337-8ee5-e3bdd4152505"), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Unbranded Granite Pants", "374.35" },
                    { new Guid("e69f9bc0-3a31-4cf8-a80c-353dda3533e5"), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Ergonomic Plastic Sausages", "38.62" },
                    { new Guid("e97c589b-1bf0-42b0-8cbb-44f69c3a6af6"), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Fantastic Concrete Pizza", "715.80" },
                    { new Guid("f3a2fbfa-d523-48f5-a180-700c46803741"), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Refined Concrete Pizza", "242.27" },
                    { new Guid("f5d5a370-886f-45a7-8b5e-41aa893fff3a"), "The Football Is Good For Training And Recreational Purposes", "Fantastic Frozen Fish", "207.78" },
                    { new Guid("f8687ef7-c622-45f3-b152-75621e2d5acb"), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Refined Granite Table", "18.83" },
                    { new Guid("f9a808de-240e-49bb-8dbe-f498e2ecf267"), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Awesome Soft Bike", "682.29" },
                    { new Guid("fa81854f-0de0-4271-b229-0021a468d898"), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Unbranded Frozen Soap", "700.97" },
                    { new Guid("fb106614-229a-43a8-a87e-cf962c92539a"), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Fantastic Steel Ball", "505.05" },
                    { new Guid("fe1bb3b2-03fa-4e09-8b21-1cd51332434f"), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Generic Rubber Bacon", "38.77" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("00961171-9252-4a07-bc37-44201b76a765"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0359626f-c8c9-4114-a5a4-e2517a455eb5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("098aff23-4666-42e1-bbe3-81d6aa64cb12"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1052a722-4bad-4007-8c93-5c6a3edbc737"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("14401fec-c682-4811-9697-6b46a3c67b29"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1f0a77b5-a99e-4041-83b5-6e7cc1d7c196"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1fec2a49-af75-4777-a0f7-97f985bd480c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("25f6f6db-56e8-4314-9271-712699f6a7b4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2c1cd185-cfc3-44e0-b6ea-7311c971ce37"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2dbddf09-d29d-4b38-95f6-d44f5604da0a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2f61d61f-6a12-4c6d-adf0-2148f9eb4195"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("376dc413-6e41-4706-8da5-c5d519810258"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3c7f0bd1-d00b-46f5-a8e0-3362cf3aa8db"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3f8068b9-f83d-4611-828c-403fa1f7a857"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4fffec20-3255-4005-bba4-aa02df4f5189"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("50d830f1-1f64-4a14-b1b4-6dd86d90a599"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("52a6a7f1-6efa-475b-bda7-bb6454983f8b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5481576a-92f0-4fee-93f3-10e4c64805e0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5aedd4b3-4cb5-433c-a246-4c4a694afb2c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6440ad8b-5564-4019-b2a5-2fb250970570"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6ba0addb-662f-4d89-a128-1bdee7f6be9d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6c61a6f9-5de5-4c8e-8e30-0501ce287b5f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("71160ad1-ffc6-44a8-94a3-951ce52b4ec6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("741a9765-a8f7-4ecc-9f03-3cfe64b4d234"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("777569ca-fa50-4009-af0c-87d633be179b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("77bf7f84-4f82-4054-964f-8ddcf275629c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("84bca415-23da-41d4-a393-c69fcf190997"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8f9bd6ca-faa7-4902-8ad9-f727bbd4ba24"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("93664166-aab6-45cf-b75d-678f5ea9115d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("93f868fd-b8fb-45a0-afe7-c2350276242b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("967f0264-8d6e-4b12-98d1-df376a4a198f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("984dab8e-7279-41f8-8140-085effb804e2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("992116ce-db94-45ac-b3f7-beeab1a6dda9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("acb2a2b9-09e2-47a7-ada5-d5db061e083a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("af78a6a4-bf80-46b0-8b62-ae773f27f249"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b1315539-1db5-493c-9993-dac500f4106b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b676d9b9-b6d6-46ac-865f-18af10839a2d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ba083013-8a9d-4af4-8518-7085461f4b2f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bb65bbfa-fa8e-4c6c-aef1-94902c3ae877"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bc47c040-7e60-4877-9280-3b0cf2f107b0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("be84d1f9-4b7f-4225-9788-b2488510718b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c14bbb2b-dd26-48c2-bbd9-bcdbc89e273b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c64c6feb-2706-4079-882a-af29f6e7d4f8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c707c49d-89ed-479e-bac5-bcbe23f4cc19"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c75e7014-a5a0-4a05-9f59-f2dd805bf197"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c78cdf3d-2677-457b-a4eb-217082acf152"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cb907ae5-efee-4464-9d1c-cbeaca19364e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cd2a3a50-b540-474b-94a4-1b9c63c13078"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cd5aa79e-04b5-44f5-afdb-0a1394600b50"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d5e2dcad-d309-4fdf-8b7e-9c8c3e423abb"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d76f786c-7ed5-48bc-8113-47fff300491c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("da67644c-a999-4363-b15c-ba2e1db1aeac"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("df574ec5-ca96-475d-9d29-6194e3d3f734"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e139d502-2e4d-4337-8ee5-e3bdd4152505"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e69f9bc0-3a31-4cf8-a80c-353dda3533e5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e97c589b-1bf0-42b0-8cbb-44f69c3a6af6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f3a2fbfa-d523-48f5-a180-700c46803741"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f5d5a370-886f-45a7-8b5e-41aa893fff3a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f8687ef7-c622-45f3-b152-75621e2d5acb"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f9a808de-240e-49bb-8dbe-f498e2ecf267"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fa81854f-0de0-4271-b229-0021a468d898"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fb106614-229a-43a8-a87e-cf962c92539a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fe1bb3b2-03fa-4e09-8b21-1cd51332434f"));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("006c5c42-62ca-4604-a08b-63429fc47fce"), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Refined Concrete Hat", "901.33" },
                    { new Guid("02eea13c-c632-4077-8f09-186371d87738"), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Gorgeous Wooden Tuna", "189.20" },
                    { new Guid("0e7da4d0-bdd2-4261-9a33-4de0233cd4de"), "The Football Is Good For Training And Recreational Purposes", "Generic Fresh Pizza", "454.12" },
                    { new Guid("1326ef6c-2446-4023-a0e4-5ccce1c4cc84"), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Awesome Soft Table", "819.99" },
                    { new Guid("17437190-0385-4fc9-a3c3-b7eca1aeeb47"), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Intelligent Soft Table", "67.21" },
                    { new Guid("18739b05-a6a2-4ebc-b009-7c492ee5a2bc"), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Intelligent Fresh Shirt", "685.49" },
                    { new Guid("1953eab9-48a5-4877-8164-21213c09f633"), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Unbranded Concrete Chair", "809.50" },
                    { new Guid("1aa7e2dd-dcba-43e6-a628-7ff1e1bca851"), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Fantastic Wooden Gloves", "302.07" },
                    { new Guid("24ff8308-81cf-4b1b-a650-c3f0ac5fb872"), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Gorgeous Wooden Chicken", "793.31" },
                    { new Guid("2524dccd-9ae8-4c74-9260-8d4d652e752b"), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Rustic Soft Chips", "562.43" },
                    { new Guid("276f0776-7870-4858-a135-856b2367f49a"), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Handcrafted Granite Car", "342.19" },
                    { new Guid("2ea13d61-8095-4860-88d7-73a4ae30903d"), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Sleek Frozen Pants", "451.26" },
                    { new Guid("2f247d47-2149-43b5-88e9-f06bfc73e8c7"), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Unbranded Fresh Towels", "998.09" },
                    { new Guid("3870dff0-1d25-4bfc-8179-c61294924dbb"), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Gorgeous Steel Bike", "542.09" },
                    { new Guid("40010837-9b5b-4c4f-97a0-ea32c8e16e43"), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Intelligent Rubber Car", "771.85" },
                    { new Guid("407b95ca-cd5b-4297-bc2b-c00697b0df59"), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Generic Plastic Salad", "494.11" },
                    { new Guid("444291ea-f052-4c08-9456-956bf5fc3cb4"), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Practical Granite Chicken", "838.22" },
                    { new Guid("44543f72-ede7-49c3-9a02-8d1283a23f5e"), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Sleek Plastic Chicken", "150.65" },
                    { new Guid("48c2e651-435b-4339-945d-a3489aedd093"), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Licensed Granite Cheese", "575.46" },
                    { new Guid("48d9474d-5afe-4429-8200-482f5f1fa73c"), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Gorgeous Cotton Soap", "590.66" },
                    { new Guid("512d6b22-9858-4473-aa2f-836bceab4b0b"), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Handcrafted Steel Salad", "350.08" },
                    { new Guid("536bd696-c455-4893-a25f-26392b41d3c4"), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Unbranded Cotton Ball", "187.52" },
                    { new Guid("55079c16-7ae0-4cd0-9261-e06be6693455"), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Ergonomic Concrete Tuna", "200.79" },
                    { new Guid("566a675a-eef1-425f-a516-9bb64bb6bd05"), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Small Concrete Bike", "545.38" },
                    { new Guid("56882157-ef94-42de-9d52-c48bec0d018c"), "The Football Is Good For Training And Recreational Purposes", "Small Soft Ball", "901.22" },
                    { new Guid("5b8aa408-9a7a-4265-9e1d-8ca69e112226"), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Awesome Frozen Table", "326.79" },
                    { new Guid("5c56912d-7459-4afb-b4ff-304a50ed5b04"), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Handcrafted Soft Table", "627.53" },
                    { new Guid("5cdf4ea8-d493-4166-b101-10190c4bd5f3"), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Gorgeous Frozen Car", "52.57" },
                    { new Guid("5dd714b9-904f-49bc-bbd6-689b14c28808"), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Awesome Plastic Car", "117.55" },
                    { new Guid("623edeb5-2562-436a-9049-7b2a28d887e2"), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Gorgeous Soft Pizza", "211.59" },
                    { new Guid("6498309c-060b-436d-9d86-1c5c37181a51"), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Handmade Granite Gloves", "899.58" },
                    { new Guid("666bb009-7699-4f1a-af63-c77cc051a36a"), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Small Plastic Shoes", "44.74" },
                    { new Guid("66c8508d-bac9-4c1c-9bec-bd887a502beb"), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Handmade Steel Chair", "741.27" },
                    { new Guid("67691693-8414-4dc4-a24e-54c1e0fdad31"), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Sleek Cotton Hat", "428.92" },
                    { new Guid("6c6a2500-e92d-4b77-93e3-75a00ac3d251"), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Practical Cotton Fish", "829.74" },
                    { new Guid("76175ffd-f04c-4e9a-bf5f-2c7d77e2b2a3"), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Handcrafted Soft Computer", "571.16" },
                    { new Guid("7b2e0079-33ae-41f5-8e19-560b1741a4ae"), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Incredible Cotton Pizza", "573.17" },
                    { new Guid("7eaed778-e52e-4e5d-bf27-7dea55ee0383"), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Practical Metal Car", "484.64" },
                    { new Guid("7f74a069-9e0d-4fb6-8b0c-136d6285f2c8"), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Ergonomic Frozen Sausages", "852.61" },
                    { new Guid("7ffd8abe-874c-46b2-9be7-2dc4004e1e45"), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Fantastic Frozen Ball", "985.07" },
                    { new Guid("814d50d7-d8a1-45f9-8985-4874fcef6f99"), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Licensed Plastic Computer", "967.27" },
                    { new Guid("81d5a9df-6351-4618-929c-fc0f5d7bc6dd"), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Sleek Frozen Keyboard", "983.63" },
                    { new Guid("84f2aaea-f131-41f6-b765-efa7c7fe85de"), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Gorgeous Cotton Gloves", "992.13" },
                    { new Guid("85cda0e5-c5d0-4b4d-92b0-dcd5ab0361ee"), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Generic Concrete Tuna", "62.18" },
                    { new Guid("891bc6c4-9e41-445a-aa9a-1705e803d97c"), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Ergonomic Fresh Towels", "521.93" },
                    { new Guid("89c90a04-9b4b-4fb0-aee3-d77920e1965b"), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Licensed Plastic Chips", "982.45" },
                    { new Guid("8b413dbd-8272-4ef7-95eb-d58b2c83d40e"), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Tasty Plastic Chair", "798.04" },
                    { new Guid("8be82d3f-adf8-4241-9560-2b7d634d75fa"), "The Football Is Good For Training And Recreational Purposes", "Fantastic Granite Cheese", "520.44" },
                    { new Guid("8bf2b17e-b6ac-49e6-a94e-815b028fcb81"), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Refined Rubber Salad", "392.62" },
                    { new Guid("8fa586fc-5351-40ad-b347-0a2a3b1d7f1e"), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Sleek Soft Gloves", "549.34" },
                    { new Guid("9628a2f2-98a6-4114-b089-bf4217538ef7"), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Tasty Steel Ball", "991.05" },
                    { new Guid("98df2ff4-1adf-4c2b-b6a0-fe41d99612c0"), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Gorgeous Wooden Soap", "306.73" },
                    { new Guid("9a07c97b-781e-4df1-a0f1-410746b0e785"), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Fantastic Concrete Chips", "837.21" },
                    { new Guid("9b14fb40-e7aa-4c75-8ee6-9ac56f248a59"), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Unbranded Concrete Soap", "903.95" },
                    { new Guid("a2969bf9-3bf5-4f23-bbe7-c1e325664d07"), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Refined Plastic Shirt", "954.55" },
                    { new Guid("a816eb31-b920-47ff-a08b-3edc3fa55211"), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Unbranded Fresh Table", "363.45" },
                    { new Guid("a8690b96-3a40-419f-9266-4d1a3308de4c"), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Licensed Cotton Chips", "797.01" },
                    { new Guid("a88e00c1-22a0-4284-b500-28927f74bc27"), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Handcrafted Rubber Cheese", "376.62" },
                    { new Guid("ad8aff89-4e11-4b15-9ea7-f300e43e217b"), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Licensed Frozen Shoes", "620.49" },
                    { new Guid("b254e750-15ec-4644-a01e-01561a811e37"), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Unbranded Fresh Chair", "96.37" },
                    { new Guid("b2715386-e67c-4e40-90d4-0b160b7eff6b"), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Generic Metal Shirt", "790.67" },
                    { new Guid("b62c01ce-98b1-45b8-a021-70bedc6e7789"), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Unbranded Wooden Table", "207.44" },
                    { new Guid("b9901066-6fa4-4998-8b5f-d75363a16d5a"), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Unbranded Rubber Chair", "444.32" },
                    { new Guid("ba460e59-92d9-4170-8da0-61d2c423cb13"), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Sleek Granite Table", "444.09" },
                    { new Guid("ba62f464-f04a-4fcc-ae5a-135763ecada8"), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Generic Fresh Computer", "43.75" },
                    { new Guid("bb70e0ab-72b6-4c0f-9fad-a579d6695115"), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Fantastic Steel Hat", "20.67" },
                    { new Guid("c65a0386-0922-4ea9-98bd-6ba4ccf05744"), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Ergonomic Soft Bacon", "388.69" },
                    { new Guid("cb8fbee9-bebb-4612-bfd4-a9e5c3408713"), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Handmade Soft Salad", "445.19" },
                    { new Guid("cba0d752-732a-499d-9198-09e81c5e5a30"), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Awesome Soft Shoes", "713.44" },
                    { new Guid("cce5cc97-8c1d-440c-9ed6-e19c2fda83c1"), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Gorgeous Soft Computer", "460.65" },
                    { new Guid("d266e84e-9119-4cd3-a893-356ae870bb32"), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Rustic Concrete Salad", "701.75" },
                    { new Guid("e12a8de8-fc2f-4bcf-b561-3c87f463716b"), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Handcrafted Cotton Chicken", "876.80" },
                    { new Guid("e2ea0a0f-0a31-48f4-a35a-459107b3f46e"), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Tasty Frozen Shirt", "544.73" },
                    { new Guid("e4ff1c8b-8448-406c-aaa0-9f99b94caf73"), "The Football Is Good For Training And Recreational Purposes", "Tasty Wooden Pants", "95.16" },
                    { new Guid("e7b7bde1-e8aa-4a44-bb9e-3f71dd4de034"), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Unbranded Frozen Gloves", "316.39" },
                    { new Guid("e8fd5ec8-adcf-4126-bc3e-732d155c1b6f"), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Tasty Cotton Chair", "119.75" },
                    { new Guid("eabd4ad1-3e02-46fc-9c8e-d3f14fdf692a"), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Generic Soft Bacon", "217.31" },
                    { new Guid("ec4e3258-484a-4124-a341-35185bc3c06c"), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Intelligent Plastic Salad", "902.81" },
                    { new Guid("f6e7c7ba-6b77-4207-8789-6de2ff5b290f"), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Gorgeous Plastic Gloves", "446.65" }
                });
        }
    }
}
