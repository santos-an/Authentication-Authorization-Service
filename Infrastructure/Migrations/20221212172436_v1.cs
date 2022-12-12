using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class v1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
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

            migrationBuilder.CreateTable(
                name: "RefreshTokens",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Token = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JwtId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsUsed = table.Column<bool>(type: "bit", nullable: false),
                    IsRevoked = table.Column<bool>(type: "bit", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExpiryDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RefreshTokens", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RefreshTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "03a1bfc6-bd7b-4823-9117-9caec23cba6b", 0, "ef16d9b7-4a42-4db5-a312-66e3eecaab88", "Blake_Weimann61@gmail.com", true, false, null, "Blake_Weimann61@gmail.com", "Blake13", "AQAAAAIAAYagAAAAEDm3ruTSeZEho6HUy2WU3VTOwEMPBBkp32FFGgDjd/f/c/Fbwm4j0PUVBJbiAvEBHw==", "1-415-344-4434", false, "77a7056a-65d5-4501-a787-28f4717f4ec5", false, "Blake13" },
                    { "05f06db7-c3ad-484c-9b42-3a1bdf50260d", 0, "d847b5bb-52ce-43fb-a3f4-564a75a6ae31", "Ismael_Gusikowski@gmail.com", false, false, null, "Ismael_Gusikowski@gmail.com", "Ismael_Gusikowski", "AQAAAAIAAYagAAAAELEob31WCdD/mcoNk6FnwfXYne/g7qRgbxeHrvtVPcKAo7PFEWfZe8F5QFp7nTMABg==", "995.352.6888", false, "5c105aa5-c321-42c0-9782-d7a549f74752", false, "Ismael_Gusikowski" },
                    { "05ffd985-95e1-4232-b3ca-60465abf8fdc", 0, "2b8756ef-728f-4f7c-853b-50dc4a694abd", "Kelvin.VonRueden@hotmail.com", true, false, null, "Kelvin.VonRueden@hotmail.com", "Kelvin_VonRueden61", "AQAAAAIAAYagAAAAEH2M+DYDRxHbxU2jiPAed/naGF0n0ac7na7V18WnUUXpRQBB0MhUkAZBZ2e8+e2ezg==", "514.537.5226 x079", false, "3a84549d-617a-4e03-a28a-d27a984bc886", false, "Kelvin_VonRueden61" },
                    { "0c0f5b42-fcf1-4345-aafe-b424cc45b6c6", 0, "bdb16ca9-d4db-4c6b-8a08-934d8bc9efd7", "Terrence.Fay54@hotmail.com", false, false, null, "Terrence.Fay54@hotmail.com", "Terrence80", "AQAAAAIAAYagAAAAEL5T+wT4Jj7bihNBod8rVOvfG/6elfQErn6rpCzJDO22L2BcApKgPSNkvYD7jHFrjQ==", "296-710-1184", false, "b9d45c42-de56-4801-9bc5-9f87efd095a7", false, "Terrence80" },
                    { "10a31915-4406-4dc5-b21f-0e9cf4c9b852", 0, "4f408abe-fca6-422f-9795-71ee9673e715", "Ella_Kshlerin75@hotmail.com", false, false, null, "Ella_Kshlerin75@hotmail.com", "Ella54", "AQAAAAIAAYagAAAAEItEB9TM1Cn2/5eS/jCiOs39Mm4ZqwX6sEEMcQQ1NsGunuHWcvdGvTXYlLaBSGUfgw==", "687.608.0934", false, "f72378b9-3dba-411d-a528-97b9ea93111c", false, "Ella54" },
                    { "14339328-0695-41ea-8fda-d31f4e855ccd", 0, "58e11ef2-530f-4bf7-bd23-5244de13e759", "Margie97@hotmail.com", false, false, null, "Margie97@hotmail.com", "Margie.Carter", "AQAAAAIAAYagAAAAEC8wZiaynLPjD+3Of+klfCpbLc/q09+6pv5jHF5xw8WKSrVgqURpSqlQ5bN11dSX/Q==", "308-526-7833 x209", false, "49aa9959-989c-4820-955d-c276d9f6c1b9", false, "Margie.Carter" },
                    { "2207a3ac-0b55-4103-a730-33869ff0f6f9", 0, "707ae143-96f7-43a3-9c0b-09a3e62c28a6", "Wm83@hotmail.com", false, false, null, "Wm83@hotmail.com", "Wm53", "AQAAAAIAAYagAAAAENlaOgmcPvuBcWoVd8HYmJ8AjivL4jYwMgcPr5wAb6qaN3x1TZsbdaIFlXuB7cW+nw==", "(482) 729-7418", false, "0418e067-5bfc-4f8a-90f0-d662f3cb3d2f", false, "Wm53" },
                    { "23b71de2-bb4b-4df1-b014-859ade2cf2f0", 0, "f16f26b8-3f24-4fc0-871d-efde63e09f00", "Chad.Schoen@yahoo.com", true, false, null, "Chad.Schoen@yahoo.com", "Chad70", "AQAAAAIAAYagAAAAED6KLfGezu/Yuq4vN1pYiibXsopZvu3ECYB53aOLlrsymKU92pZgPQvGWf8arvBP0g==", "(344) 482-9858 x91193", false, "89dc30c6-5179-4128-8756-a47909bec042", false, "Chad70" },
                    { "23ed0761-991b-4fde-b183-07ac51f2ca4f", 0, "af1534a0-9f97-43e6-81c6-c62529a49439", "Jeremy.Schultz5@gmail.com", false, false, null, "Jeremy.Schultz5@gmail.com", "Jeremy_Schultz81", "AQAAAAIAAYagAAAAEM0wESOQvTKuG40NPLh6KLrUNNCloLLuw2ilGky2/BYhuEIuFWlA/uk4Ur0MAjS+CA==", "(273) 453-2679", false, "d2058b63-c54d-4648-9f50-64631787e355", false, "Jeremy_Schultz81" },
                    { "27d733b4-f21c-4bad-9d37-47c5a6f87f24", 0, "680f503b-78bb-4912-be10-aee69c83c4cf", "Dianne43@hotmail.com", true, false, null, "Dianne43@hotmail.com", "Dianne.Hayes87", "AQAAAAIAAYagAAAAEBNLnWkKwD0Ka0DSzlqXiAbb1kNnWm7r1s7PLUGzLdd02Cq/qrixwdggU6Hfu6hDhw==", "747-425-1033 x364", false, "f064c666-a8b4-4efd-9a64-3b4709e74677", false, "Dianne.Hayes87" },
                    { "2f95c2a8-f440-4b3c-9112-88493f4cee49", 0, "090562d1-c4ab-4fba-92a7-349d16ad0496", "Mildred71@hotmail.com", false, false, null, "Mildred71@hotmail.com", "Mildred_Bailey93", "AQAAAAIAAYagAAAAEF0B8CyeHnYsmOd50wIVYRwGzoTdMZ/JhhbbdfzxPMzF/eQG5vxJKBSxadFjWqw/hg==", "1-557-260-8962", false, "fac8a84b-28da-412b-b815-254d918cb50e", false, "Mildred_Bailey93" },
                    { "39bc388a-16a4-410f-b301-fa97b91b304e", 0, "73530a09-d630-401c-b94b-89ec55229d08", "Elaine_OReilly57@gmail.com", false, false, null, "Elaine_OReilly57@gmail.com", "Elaine28", "AQAAAAIAAYagAAAAEO8mvwSBkTtSIxm0gwQIIqNF8hqqRjEiFdUnj/4zcUXRSWcoFEKx0w85DknROoA1XQ==", "762.677.3476", false, "52f7757b-73c2-4673-a5b5-e865c48fb6e8", false, "Elaine28" },
                    { "3fb1f548-ff98-42ce-a05e-40e219334544", 0, "a24fa89d-4f36-48a9-826f-ff4da4f2d605", "Rogelio.Lynch@yahoo.com", true, false, null, "Rogelio.Lynch@yahoo.com", "Rogelio.Lynch17", "AQAAAAIAAYagAAAAEAn91pAxwInHX45Tfo1mvd8hlAPQTAZJzYMYc26Bj2v5iMptsqGTn5Hk3xY8KBRTHg==", "781.364.0493 x77307", false, "8d5d9b27-18be-4081-ade3-6451ac43c2e1", false, "Rogelio.Lynch17" },
                    { "42d4da42-9ba3-4113-bcfd-f3f5d8d26798", 0, "cf7a3a99-36cd-4f74-9598-e53bd301dd79", "Betsy22@yahoo.com", false, false, null, "Betsy22@yahoo.com", "Betsy_Bartoletti97", "AQAAAAIAAYagAAAAEOMK0yGvI3rdIlQJqNB/khQR0GwRn7HMWr1+KyFBqye+/t8AHCMiFHocg1puWp8RmA==", "1-911-366-1177", false, "2b20e3a5-ffca-426c-afc0-9f60aa55f4ba", false, "Betsy_Bartoletti97" },
                    { "4a98b5d5-14a5-44e4-ac2c-d772b7a79d4f", 0, "b92ebbd3-5594-4fcc-a35a-a13681ca8f5d", "Clyde70@hotmail.com", false, false, null, "Clyde70@hotmail.com", "Clyde31", "AQAAAAIAAYagAAAAEBvW7ftANl6ywFehKEnIBzYBvnGjIa7/WgHMDxKd27FmQbIvzfa7vUfVyt+B1WZdDw==", "463-424-9921 x673", false, "81ea02ad-efbb-4b5f-822b-15a82bcf7829", false, "Clyde31" },
                    { "5183f5dc-e970-439c-abc7-2296b6a38f48", 0, "f68e4760-ebc9-4c7c-bc3c-fd8147045d11", "Sophia.Ebert42@gmail.com", true, false, null, "Sophia.Ebert42@gmail.com", "Sophia.Ebert56", "AQAAAAIAAYagAAAAEK9Ham7tUVNL1N6PZnruv19YvAV2dCy18N8TQIyT749uCUXqfNad5U/gvccXOd+FaA==", "777-258-5989 x919", false, "383b534d-f9f6-4085-8718-7485a3c466a3", false, "Sophia.Ebert56" },
                    { "5f91adb2-fc19-42ba-8b7d-c3a1ec3a4130", 0, "41698ed7-45c1-4425-b9dc-d89db4661c0d", "Bridget_Wisozk@yahoo.com", false, false, null, "Bridget_Wisozk@yahoo.com", "Bridget.Wisozk16", "AQAAAAIAAYagAAAAEEpYntgLI0xCMZMN0aO6bMZeVQ0YkHLvSeZareWU91lAfD7gnwIgAgmssWlhuZcrOg==", "361.942.7069 x47993", false, "411e7506-256f-4afb-a60b-654a3c7ce3f5", false, "Bridget.Wisozk16" },
                    { "611636f8-add1-4133-92b0-e4bc35f6ccfd", 0, "72fe023d-a551-4e59-b0ec-c86be53e44f1", "Betty.King@yahoo.com", true, false, null, "Betty.King@yahoo.com", "Betty6", "AQAAAAIAAYagAAAAEHT86xciAKEO0TZxsoYJuypQkfAuZNOCUAjotTaH89yIQdMyTLOvYuASKx03IZ9qvg==", "(832) 762-2620", false, "d5489c64-1ac8-4b12-ac68-ed7a0b2327ee", false, "Betty6" },
                    { "6d60a968-6907-4d6a-b7de-9c963c740253", 0, "074fbac8-6345-4aa6-b031-bbedd02bbee4", "Greg_Wintheiser35@gmail.com", false, false, null, "Greg_Wintheiser35@gmail.com", "Greg_Wintheiser", "AQAAAAIAAYagAAAAEBU+iiZt3kIjBcsNFLZjYRJ1R5kcZO0odjkZOQoAD20Z0e1vYRFWXPqFW7VMrn/e/w==", "1-284-512-0623 x4462", false, "972ddfcf-ebfb-4d50-877a-aec6a5f9666c", false, "Greg_Wintheiser" },
                    { "72ab5ed5-d3d8-48cf-8428-b32cab3d4f66", 0, "604dcb0f-7303-4d84-a27b-29bf2ea959c2", "Derek7@hotmail.com", false, false, null, "Derek7@hotmail.com", "Derek56", "AQAAAAIAAYagAAAAEH0CYk2AXCpRHJ+HDuAU5GC9b3UcTWybna0R1BzFSC/3Ua/Gdw/xf/6IYlSI0he29w==", "720.527.9708", false, "becdd5f9-3f9e-459b-bac2-01fc5003099c", false, "Derek56" },
                    { "89a2ad18-0054-47c0-aefa-089481dcadd9", 0, "932f9231-2e24-4e58-93b1-c3212e76f386", "Patty_Parisian@gmail.com", false, false, null, "Patty_Parisian@gmail.com", "Patty_Parisian30", "AQAAAAIAAYagAAAAEDG6kcfN9MmQtBVr4ra/GiUK1UAWdsQnv7N5CsJWto3L9gzJrcO/DRl8Dzy2W2VnYQ==", "454.597.3834", false, "c29bec3e-bb9e-4072-9b2f-2f28d436d283", false, "Patty_Parisian30" },
                    { "8d9a61ca-a345-483b-a7f8-e767e483ac86", 0, "ba8cb1ea-1484-477a-ab37-c38ab38a211c", "Susan_Lindgren10@gmail.com", true, false, null, "Susan_Lindgren10@gmail.com", "Susan.Lindgren81", "AQAAAAIAAYagAAAAEE4b5tXtHVg5cizvzRmUWlYgPj/v28gTjeksSjtuxSED8oCOwO7joi/NDZ6PfAvqKQ==", "1-588-497-8158", false, "38ddb257-6084-410d-938a-5e668bd1099d", false, "Susan.Lindgren81" },
                    { "908092d2-860d-42b7-937b-7a74941d6555", 0, "b64d1f2b-7163-4a68-9f4b-a1f6eb464659", "Ronald.Mitchell69@hotmail.com", true, false, null, "Ronald.Mitchell69@hotmail.com", "Ronald.Mitchell", "AQAAAAIAAYagAAAAEJytj/PWVi/k5phcR0jo5AgYQp491+Hf4vhmpZl5B9GhxEVlkXrBkz7f2QfSeAakAg==", "658-611-5975", false, "d241c830-e119-48f1-9b06-2941f8f54c95", false, "Ronald.Mitchell" },
                    { "950594c8-e233-4c7a-aea5-533a6be5e40e", 0, "fcf8f83a-b5b5-4dca-a319-1c5bd9faad9a", "Caroline.Prosacco@yahoo.com", false, false, null, "Caroline.Prosacco@yahoo.com", "Caroline.Prosacco27", "AQAAAAIAAYagAAAAEEoWJry1GHDXZjTRb4fbfl+oHqYzkUl3IndX+Ia85nwKU1p4kUeBO6vGfZ4qBGtNGw==", "709-429-5131", false, "38118647-69d0-4c0b-9274-c0eb970d4f46", false, "Caroline.Prosacco27" },
                    { "999cd408-64bc-4904-b581-392b4ff83d5c", 0, "c675ef19-35a1-4419-9125-2e73a8394bf4", "Rose.Anderson97@gmail.com", true, false, null, "Rose.Anderson97@gmail.com", "Rose.Anderson", "AQAAAAIAAYagAAAAEABgAkTMO0lnM6H5FHr3pXvQL7C7mY8tOp5ukgoPUmwxIdv3PikbKcgbTJ+/YhH7SQ==", "922-596-5238 x1251", false, "3b355937-076a-404b-bba9-545f86dc372c", false, "Rose.Anderson" },
                    { "a345a4d0-11eb-4f8e-b683-d9e447953baa", 0, "3fd71b49-d90b-49f4-8f42-8ae15063030b", "Scott_Roob29@yahoo.com", false, false, null, "Scott_Roob29@yahoo.com", "Scott.Roob77", "AQAAAAIAAYagAAAAECH5ROybdXgOV3b9QR4HMQmB4jPXQjZ0KmbxZOsmBZMVpvNdn+JdFW8yFBhnveFtww==", "(712) 480-1725 x64900", false, "4435bf8e-04c4-423d-923c-e9f7ffc5c62f", false, "Scott.Roob77" },
                    { "aab58fcc-3f3b-4c93-91f3-d9cc5ec96d68", 0, "888ea8f3-8cf0-45ba-af9d-da855878888e", "Olivia_Volkman82@gmail.com", true, false, null, "Olivia_Volkman82@gmail.com", "Olivia_Volkman", "AQAAAAIAAYagAAAAEIiw+QFfCfusRPFI7IaefFW+E34bq5BIb9XxmZP3s/4M1ZxbEqpoS9QA9s2AvkxIXw==", "1-301-368-8417 x7631", false, "c5f7fc44-23c5-41cf-98c8-f514a7e12a61", false, "Olivia_Volkman" },
                    { "b03ef1cb-25e8-44a6-b942-ece889e02dc8", 0, "d86437dd-4a65-493f-906a-1b241bac7d80", "Toby66@yahoo.com", true, false, null, "Toby66@yahoo.com", "Toby.Marks69", "AQAAAAIAAYagAAAAEEcl64Z9VfbKXp7lLqsnhNOvctIEzEXNaPVKi0XhKPac0zSl8/QaKcWBo9mhslFBAQ==", "788.720.1382 x1502", false, "55e40843-5e26-4365-80e4-c7437fca3d25", false, "Toby.Marks69" },
                    { "c6ca2d95-6b5d-45ff-97b5-cf7ca5b2ff86", 0, "983b141a-e3df-4c96-89e3-eaa86f08fab2", "Frances.Schumm44@hotmail.com", true, false, null, "Frances.Schumm44@hotmail.com", "Frances93", "AQAAAAIAAYagAAAAEPsSv2OEbtRXYVpMJOmbYUO65U16NBegHK1Hw8HDFqcWOVMrEobcS9s0X1rp6ugS3Q==", "246.763.7101", false, "67dad906-3717-498d-ba2d-2df4b7ed3510", false, "Frances93" },
                    { "cf32871a-8423-49f6-93d4-67a2067a9e62", 0, "7adb504e-2c0e-4d01-8445-b7d71147c7fb", "Marsha_Macejkovic48@hotmail.com", true, false, null, "Marsha_Macejkovic48@hotmail.com", "Marsha82", "AQAAAAIAAYagAAAAEPIX7ICW5MmA5NHLP4z6uVc6RsN7syi8FVuQoDrLf8v43kNSVxdvccVJnurN8y+D3g==", "1-365-813-9048", false, "f60b3982-9bc6-4ea9-898b-099d59cb1ee9", false, "Marsha82" },
                    { "d146992f-82be-446d-95af-6d46332855ac", 0, "4ca31e64-5612-4ead-96d0-0a6310907d44", "Faith.Schmeler48@hotmail.com", true, false, null, "Faith.Schmeler48@hotmail.com", "Faith_Schmeler", "AQAAAAIAAYagAAAAEF9kQltzrYQXpG0LduHVpEDJk2pF5WZTnKkNral7NxRnNkBJJ24smmDcoAeIDPpchQ==", "(908) 496-8330", false, "112a7757-8543-4b46-9e79-24f36531bd97", false, "Faith_Schmeler" },
                    { "d2927b69-2815-4c0f-bb78-bf07c9507895", 0, "28cc2c1a-1dc5-4c7c-8890-86943e96a15d", "Erica87@gmail.com", false, false, null, "Erica87@gmail.com", "Erica31", "AQAAAAIAAYagAAAAEKyUpnmSqzZXaWRiogWynxpTEu6qylIGEcOTvhuU1XRf6pFmDwLI4rwZAojZg2JhUw==", "1-836-887-2464", false, "c69c0fde-f8a6-471f-ae55-7e70d85bc537", false, "Erica31" },
                    { "d886862a-aba2-43ae-908d-9bce3be4e1f7", 0, "4605690d-9a0c-430b-a5c3-279a4816e9a0", "Vernon_Buckridge78@gmail.com", true, false, null, "Vernon_Buckridge78@gmail.com", "Vernon18", "AQAAAAIAAYagAAAAEOeT7X3biKkh4/uywMonkL6zJl8hgh+oHpiudoyWF9MHwScWi4K8AEOKch0ouTIywA==", "909.373.2191", false, "0aa995d3-f9b5-4113-8633-7d0bdfdf3b95", false, "Vernon18" },
                    { "e4528b8b-97e0-4cb9-b268-5bdabfff4804", 0, "69e13cf6-7d39-42a9-89b7-0e9be4c33092", "Maurice_Cartwright@yahoo.com", true, false, null, "Maurice_Cartwright@yahoo.com", "Maurice13", "AQAAAAIAAYagAAAAEGkZ5pLJ38QeXFx51nr2I9vP49jteB2mjBAGU84t9zSF7Tn/JtZNT4lC1VAnRq4LvQ==", "236.216.4782 x78080", false, "20f95873-c6ee-457d-87f6-f91cecc31a7f", false, "Maurice13" },
                    { "e7cb9626-ad36-4753-a881-d1852ff5edcd", 0, "96ce86bb-bf7a-4776-85f6-71bdb20921dc", "Ruben.Cartwright@yahoo.com", false, false, null, "Ruben.Cartwright@yahoo.com", "Ruben_Cartwright", "AQAAAAIAAYagAAAAEBNQDfAw1f/AOIUQijqhHd9CyhJB3tzYCssc8o90BUAVjxHfP9n1Sw3KjJyxQjXKfw==", "1-714-524-0391", false, "82e6ac06-bc13-4158-90ff-c57c54042bbc", false, "Ruben_Cartwright" },
                    { "e9ee14ce-026b-4510-bcfa-040553eb1740", 0, "43520950-baa6-4720-b2ab-413c0835aafa", "Nichole80@hotmail.com", true, false, null, "Nichole80@hotmail.com", "Nichole.Marquardt57", "AQAAAAIAAYagAAAAEH1ZO+GYll71aqV2WtCVow6L3S5QCXm/tmDgs2UhUDAn1fPxl4nsO1Dp0dB5vNi1IA==", "(341) 692-8382 x5342", false, "d1540d9a-586f-4ba1-b7c8-e062623c6f7f", false, "Nichole.Marquardt57" },
                    { "ecfe73c6-2e9b-433e-a7a8-323d83b67380", 0, "1916be38-684d-4a27-b396-a2d0ee545bac", "Dwight_Paucek23@gmail.com", false, false, null, "Dwight_Paucek23@gmail.com", "Dwight.Paucek", "AQAAAAIAAYagAAAAEIZ3r0lmWD9C+chypFb/D0VRhEuH+2qCnG0LPFJuFkJrwh+XGy71UmOqx+VjIVCG2g==", "1-933-725-3050 x438", false, "e76a2503-f038-4af4-95f2-fc159326897f", false, "Dwight.Paucek" },
                    { "f11d8862-6aff-4903-b577-a9f5d0a131eb", 0, "27ae9273-e975-47f7-b3c3-cbf03e4ce4b2", "Angie.Senger15@hotmail.com", true, false, null, "Angie.Senger15@hotmail.com", "Angie50", "AQAAAAIAAYagAAAAEOTFpCfCncZzCvvun+5D+uOSSyaXdLeKKC6mYppt3qg9UfWTIssuZvWQPDTHHhextg==", "(611) 382-2234", false, "ac91dfec-d374-443d-baf5-266076c7b9ad", false, "Angie50" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("00288689-8dcc-47e7-a8c2-f17109875b80"), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Awesome Cotton Salad", "775.21" },
                    { new Guid("0136faaf-fb0f-4ae0-ba5b-08d92b912b29"), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Gorgeous Plastic Chair", "217.05" },
                    { new Guid("0239803c-36be-4762-9b5f-846804e6649a"), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Refined Soft Ball", "945.29" },
                    { new Guid("07d984da-9e9b-4c90-8177-27709cdd7a27"), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Licensed Soft Chicken", "363.79" },
                    { new Guid("11cb5fdc-f2b4-45d6-83e8-86e1e0336ef8"), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Small Frozen Chair", "228.21" },
                    { new Guid("137bcfa8-d198-42a1-80ee-d8e6082dcd12"), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Generic Fresh Chips", "655.63" },
                    { new Guid("17f833e8-bab6-428e-8dec-7ae5c92db61d"), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Handcrafted Granite Cheese", "495.39" },
                    { new Guid("1e2540e6-c911-4767-ae3b-1d06c8d2bd96"), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Awesome Concrete Ball", "245.04" },
                    { new Guid("209e6e98-7f48-4cd3-b2b0-62b26e8fb744"), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Small Steel Chips", "609.42" },
                    { new Guid("2477ced6-d2ff-44d4-b925-c743016d3950"), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Small Cotton Pants", "5.87" },
                    { new Guid("254caab5-1251-428d-9a0b-58b4f3109b27"), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Intelligent Metal Bacon", "250.93" },
                    { new Guid("2940255a-bc75-469f-847b-a242d8e6520c"), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Incredible Cotton Shirt", "916.10" },
                    { new Guid("29f27ff1-7ab7-4496-8567-7aa0eade9a3b"), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Intelligent Frozen Sausages", "840.27" },
                    { new Guid("2babd95e-94f7-4e49-b8d1-9a229543f8e8"), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Awesome Steel Fish", "570.29" },
                    { new Guid("2c8d10a4-6fab-4d51-b20a-a902f0582536"), "The Football Is Good For Training And Recreational Purposes", "Sleek Plastic Bike", "890.78" },
                    { new Guid("2d93381e-3a26-425f-9cf8-e076f691f3ba"), "The Football Is Good For Training And Recreational Purposes", "Incredible Steel Shirt", "61.42" },
                    { new Guid("30379c44-af1e-4f99-8c30-3c9dcb287bde"), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Handcrafted Metal Chips", "856.82" },
                    { new Guid("31000e82-a919-4baa-b999-d23801c4c1bc"), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Handcrafted Plastic Fish", "715.45" },
                    { new Guid("32329b47-d873-4aa6-88d1-904f0b7e8006"), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Ergonomic Steel Computer", "731.07" },
                    { new Guid("3320c00d-5c2d-4862-b89d-60ae0a0dabf2"), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Incredible Steel Ball", "569.96" },
                    { new Guid("3384cf42-22d2-4341-8751-1eb07d624364"), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Ergonomic Fresh Sausages", "621.12" },
                    { new Guid("3868afe1-27d2-4048-9f37-6afe88826059"), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Fantastic Fresh Salad", "182.67" },
                    { new Guid("3a209c4d-bb6b-4756-8add-f61ca3a80c24"), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Tasty Wooden Salad", "559.15" },
                    { new Guid("3e664a6b-d907-4542-9864-5fd54d79421f"), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Refined Concrete Table", "356.83" },
                    { new Guid("41f5b6ae-1ed1-4d7f-b120-6d0ba35f3362"), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Ergonomic Granite Computer", "357.06" },
                    { new Guid("426c06e3-0e7b-4c68-b344-4358ad7ddc7c"), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Handcrafted Plastic Ball", "17.59" },
                    { new Guid("431c496d-7af3-4490-bc64-75b3367e921b"), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Unbranded Granite Shoes", "597.43" },
                    { new Guid("4a7c1335-32b3-44ee-9de4-4f13b79a92c4"), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Fantastic Metal Bacon", "237.41" },
                    { new Guid("5008e6c4-08fe-4105-ad6c-380b7b109352"), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Small Concrete Gloves", "42.59" },
                    { new Guid("58176b2d-8609-4183-a816-42f99a4267b7"), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Incredible Rubber Chair", "237.65" },
                    { new Guid("5a8497cc-59f5-4b3c-bfa0-a318ea753868"), "The Football Is Good For Training And Recreational Purposes", "Practical Cotton Bike", "403.82" },
                    { new Guid("5ba53bba-c9d8-40b3-93f2-f9e0caa7da58"), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Fantastic Plastic Pizza", "262.51" },
                    { new Guid("675736ea-6bd4-4195-b2db-1467ac734ccf"), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Practical Granite Shoes", "678.17" },
                    { new Guid("67fe225d-2c49-40fd-8ca0-d59a4058398b"), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Small Steel Towels", "179.42" },
                    { new Guid("6e66e59d-8776-427d-a7c0-2c73bec2e85a"), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Intelligent Soft Tuna", "981.70" },
                    { new Guid("7a040d62-fd72-42bc-8a24-486b0008c448"), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Unbranded Frozen Pants", "639.69" },
                    { new Guid("905ba7d1-f34a-457b-ad95-f2e445c29cb2"), "The Football Is Good For Training And Recreational Purposes", "Unbranded Wooden Car", "785.76" },
                    { new Guid("90793e79-0025-473b-9731-78e0771cd8b5"), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Tasty Fresh Pizza", "922.90" },
                    { new Guid("91f08a4c-cbb5-4955-a58a-6bacd98c8b5c"), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Intelligent Steel Bacon", "265.41" },
                    { new Guid("98987ba0-e989-46fc-840a-b7618176000e"), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Generic Granite Pants", "843.60" },
                    { new Guid("99dbbb4f-6f7c-4e2b-8917-c033c47dbb52"), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Unbranded Cotton Chicken", "593.10" },
                    { new Guid("9e34a7ee-ed4b-4bd0-b9fe-d179bcd9205d"), "The Football Is Good For Training And Recreational Purposes", "Ergonomic Rubber Soap", "343.87" },
                    { new Guid("9efec2df-e4b2-4d41-9354-b4459092e3ae"), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Practical Plastic Car", "158.98" },
                    { new Guid("9f6c72c9-e00d-4651-bcdb-34d09ce4c580"), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Gorgeous Cotton Ball", "22.42" },
                    { new Guid("aacb5499-7f95-4904-b6de-668489951bac"), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Rustic Plastic Gloves", "795.25" },
                    { new Guid("adbc8905-90d0-4603-9269-f1df87942ef0"), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Small Concrete Table", "888.53" },
                    { new Guid("b5387356-d2b3-423b-8e31-a31d58c47dfb"), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Rustic Soft Gloves", "43.46" },
                    { new Guid("b7d7dead-f3b8-473e-9807-aaa4cc796689"), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Awesome Concrete Mouse", "482.45" },
                    { new Guid("b8af4e29-1134-4675-84b9-56d14942a536"), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Generic Concrete Hat", "257.16" },
                    { new Guid("bb6725be-2875-4b2d-b795-f0cdb9fe2b02"), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Handcrafted Fresh Hat", "277.24" },
                    { new Guid("c177f10b-f46b-47d9-ae1c-8fd8df8f2013"), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Incredible Metal Sausages", "864.62" },
                    { new Guid("c3040eb4-6b15-4e7a-ba0b-311592f1e3ea"), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Sleek Rubber Pizza", "960.37" },
                    { new Guid("c87d2f64-8dba-44dd-8bf6-b814b4c79fbc"), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Fantastic Soft Chicken", "378.33" },
                    { new Guid("c8ef7f21-b998-4942-8ee7-f1a8cbeaa6b7"), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Tasty Cotton Fish", "175.15" },
                    { new Guid("ccfc72e6-f2a3-47e3-affb-d8a59c02892e"), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Incredible Frozen Chicken", "255.66" },
                    { new Guid("d17b3e02-c1ff-43fd-972d-11bbcea746ae"), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Handmade Granite Fish", "942.19" },
                    { new Guid("d29ca191-83a4-4dbd-b26f-a1696e388b72"), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Handcrafted Plastic Sausages", "691.38" },
                    { new Guid("d4ec0a6c-1c76-4369-bd4b-26547f1fa3db"), "The Football Is Good For Training And Recreational Purposes", "Generic Granite Soap", "613.30" },
                    { new Guid("da753bb9-4ae5-471b-858b-78ee603f1f19"), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Handmade Frozen Fish", "21.59" },
                    { new Guid("db65688b-ed18-4307-8cf9-b831ffe368f7"), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Licensed Metal Sausages", "525.82" },
                    { new Guid("dda4e4de-c2df-4f25-b53f-0abc283f4df9"), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Awesome Steel Shoes", "167.00" },
                    { new Guid("e281ebcc-53f3-46f7-8efd-896c57ad3b2e"), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Licensed Concrete Soap", "113.02" },
                    { new Guid("e2bf7cf5-565f-4bf8-8104-d41ffee99165"), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Intelligent Concrete Soap", "385.96" },
                    { new Guid("ed80289b-7f7e-4108-8904-7a1e07deb4ff"), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Fantastic Soft Soap", "887.15" },
                    { new Guid("f0820faa-93fc-4971-b017-8aed0afedb2c"), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Ergonomic Granite Bacon", "602.41" },
                    { new Guid("f22bf298-5c22-4d85-8b00-1025931a7e9b"), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Intelligent Cotton Bike", "609.48" },
                    { new Guid("f2b696ef-a9ba-4ff6-914a-f1d32d753f88"), "The Football Is Good For Training And Recreational Purposes", "Gorgeous Rubber Pants", "686.93" },
                    { new Guid("fcd467ad-e57f-4cf5-9f68-c70c3301d20e"), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Practical Steel Chips", "235.16" }
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

            migrationBuilder.CreateIndex(
                name: "IX_RefreshTokens_UserId",
                table: "RefreshTokens",
                column: "UserId");
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
                name: "Products");

            migrationBuilder.DropTable(
                name: "RefreshTokens");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
