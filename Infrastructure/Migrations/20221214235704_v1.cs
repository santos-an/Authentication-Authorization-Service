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
                name: "Companies",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Suffix = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Bs = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.Id);
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
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
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
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
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
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "03027802-038f-42a7-8309-5246571c1fb2", null, "Admin", "ADMIN" },
                    { "6a1fa3c0-2895-4574-a23c-e2aab793b25b", null, "Normal", "NORMAL" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "008bb752-920a-4ea8-baa6-ffb3bb4c7454", 0, "bcc97b78-3f80-4eed-82e6-5e7bb8a0deae", "Admin_Roland.Mueller@gmail.com", false, false, null, "roland.mueller@gmail.com", "ROLAND_MUELLER13", "AQAAAAIAAYagAAAAEBi+WXhXOdFey5YJ0tbCIc4qpMgUP4UpZbBBymZxVrr6dgDcIif5oXww9FjM/Ea3BQ==", "997-668-4590 x080", true, "4e3e47e7-201f-4991-a222-9f9a12abe809", true, "Roland_Mueller13" },
                    { "0c4c5d25-86e7-445b-a793-a58012e0b3cb", 0, "596fb4ee-d097-4392-b45a-8dd819e59624", "Normal_Carl_Kohler@yahoo.com", true, false, null, "carl_kohler@yahoo.com", "CARL_KOHLER86", "AQAAAAIAAYagAAAAEKIi+vyw/kScOGOQCzvoR0kslmbijhJZCJnwTrtggm3QAGEuWMnP8JtIMNfoXwqpyg==", "718.345.7467 x7315", true, "00f59089-c8a8-482c-9439-41fbb20a696b", false, "Carl_Kohler86" },
                    { "0d4a1135-ad71-4f8f-a6db-e5781e526bbe", 0, "f3983c31-b1f4-459d-aa0b-2bdbd03adcef", "Admin_Kristine_Littel@gmail.com", true, false, null, "kristine_littel@gmail.com", "KRISTINE_LITTEL25", "AQAAAAIAAYagAAAAECkfViHOopkMltTYLI+TDs+yrBRxK9NK9UWWIxfg3pWQNhN8fag2xlYpY6EhRZPN1g==", "944-865-7328 x225", true, "7b4fb0fe-13c6-4525-9c02-82b6dc1cdb96", true, "Kristine_Littel25" },
                    { "1e32bc6c-4956-4b25-897a-b2ef95bd59e5", 0, "c8d44ae6-f0e5-44f7-916e-6a5cef07d733", "Admin_Wm_Heller92@hotmail.com", false, false, null, "wm_heller92@hotmail.com", "WM_HELLER", "AQAAAAIAAYagAAAAEO05qmQSNo1zKTU/JSD1M4RGvKU5AWeR+dgwLxDHRkWkytHGEQsHXte+i9EBFg1sIw==", "(868) 981-1647 x3927", false, "2d199d86-072d-41bf-a253-dfffcdb59a4f", false, "Wm_Heller" },
                    { "1eb8d837-9b0f-46b1-95e1-ae0c601a5e93", 0, "d56ad3ee-3a51-4dec-b5d5-9e58dd186870", "Admin_Guillermo31@yahoo.com", false, false, null, "guillermo31@yahoo.com", "GUILLERMO83", "AQAAAAIAAYagAAAAEDwkJM82gYILRIwQlEaZ9zwIBldng++QsByayayt3CoRzc64zdwjYTmysiLSUWbbrg==", "(347) 578-9277 x99367", false, "b9cb466b-9d4b-46a0-a3bd-ea52630dc7d2", true, "Guillermo83" },
                    { "21da110d-ff16-4f8c-a0ec-26bf33e50ea5", 0, "8805df80-1afe-42c7-a102-d308f7b8c237", "Normal_Eddie_Ledner92@hotmail.com", false, false, null, "eddie_ledner92@hotmail.com", "EDDIE_LEDNER", "AQAAAAIAAYagAAAAEK2cZJ/TwoTOYeKE0E4VJYFMuZoi79N67gRydCkVdVriFuN4Jd4wEtHnwulsdeNefg==", "1-244-331-6640 x1767", false, "9c8177db-dea1-4dc0-a1bf-006ec9af422d", true, "Eddie_Ledner" },
                    { "399755cd-5641-475e-8471-87f26d7a65f0", 0, "33534b31-3d2e-49ae-946d-3934d78f6245", "Admin_Tracey.Smith98@hotmail.com", false, false, null, "tracey.smith98@hotmail.com", "TRACEY_SMITH39", "AQAAAAIAAYagAAAAEFMevVpGU61CkAr/7ZRctG0D8NKUo5bl5G2Zb85zuNl8n88J4nTw72RHv5EsT+5MhQ==", "557.920.1047 x77270", false, "46181b1e-affa-4b15-b0b4-61abf322b281", true, "Tracey_Smith39" },
                    { "3c678a34-ff53-4f91-8bcc-b31f39209abc", 0, "33958dab-b909-4501-9247-422d0e99f779", "Normal_Lauren_Rowe@yahoo.com", false, false, null, "lauren_rowe@yahoo.com", "LAUREN_ROWE50", "AQAAAAIAAYagAAAAEKPEYOLKQedvaInN18+7PfCnujggjX9gA6zIUyQ23oF19bokqkPUspc4oQ0az08rCw==", "530-489-1114 x733", true, "d81b3cc7-c276-4de2-a4fc-d188428e1cc3", true, "Lauren_Rowe50" },
                    { "3d8dfd45-bd20-4157-afe3-f4d3ae121783", 0, "916dc8fc-548e-464a-b87f-544edb3497b2", "Normal_Roman_Balistreri@yahoo.com", true, false, null, "roman_balistreri@yahoo.com", "ROMAN_BALISTRERI6", "AQAAAAIAAYagAAAAEHma4S0EQhHDlmiRdCRDrb6yGHdx0kW+7z+cf+Euhr7E8rVFG1csVCZ9FolPPmy6qQ==", "876.554.8350", false, "82446f73-8e74-4c2f-aa30-99abf383e246", true, "Roman_Balistreri6" },
                    { "3f9c0597-d6e2-42dc-9f90-937fcd19b473", 0, "3777ea0e-ed76-42a2-923c-d1c1c6e50514", "Admin_Gertrude.Emard@gmail.com", false, false, null, "gertrude.emard@gmail.com", "GERTRUDE34", "AQAAAAIAAYagAAAAEMI/3lbrji1o3ateEYTff4cECfmqRS+bY81MelQn494QeFrTOAXRGIOqZI5Ru28QJg==", "(343) 763-4746 x87937", true, "31f30ad9-6a85-4236-ad4b-556749135a5b", false, "Gertrude34" },
                    { "42a62f99-f8fc-41ca-867b-82234f261c5e", 0, "08522a25-24f5-4d2a-ac44-dea7b3704a77", "Admin_Angelina_Johnston@gmail.com", true, false, null, "angelina_johnston@gmail.com", "ANGELINA51", "AQAAAAIAAYagAAAAECpBqf9OOl+VR2x2Hs729BG1Y2w3gTfjOxLZ+5VtIS0gepfvxJGT10pOWG4aDvgdrQ==", "479.351.0683", true, "52604431-b65b-4cff-bb11-8d9178051e50", false, "Angelina51" },
                    { "43b0f940-504b-4ea0-96b6-44ddd3991f85", 0, "b27ab4fd-8184-4a4a-879d-8ff35354b2d6", "Admin_Yolanda12@yahoo.com", false, false, null, "yolanda12@yahoo.com", "YOLANDA_SHANAHAN", "AQAAAAIAAYagAAAAEJS+C+1mAdFGOXzw2ztmPNyAkfPagbOVQWiaNukIncihhWlo+34qQ0r587WvyLEN6A==", "1-767-229-2324 x99867", false, "e848b32c-bcb0-4043-8b83-eee90c0198c5", false, "Yolanda_Shanahan" },
                    { "44b77798-2ac7-43d8-9507-3f5bafdb9e85", 0, "25cad561-1b13-43d9-90c5-35f83e3431e1", "Normal_Marco_Barton18@hotmail.com", false, false, null, "marco_barton18@hotmail.com", "MARCO.BARTON", "AQAAAAIAAYagAAAAEJR4YQK0Ox/fj3sZWppdPOVapl3fzW+6tC7slrAmUAEBFhVfnO3v0uQ+SffOldYdaw==", "846-580-9559 x1777", false, "7936cec5-fcd5-42ab-83c0-b98a329df4ae", false, "Marco.Barton" },
                    { "51c316c7-cb07-469b-b2d4-b64a0d730344", 0, "958723dc-eb08-4bb8-b6cd-237d86d67b64", "Normal_Clifton_Wyman@gmail.com", false, false, null, "clifton_wyman@gmail.com", "CLIFTON88", "AQAAAAIAAYagAAAAEPZmDBdCOzk/FOkw2A7OpppwJxhYiufrctNeisJelP3TdAnGshL6xkWUyNVxpGOgMA==", "464-466-0841", true, "354fbd95-9de8-49a0-bb93-58bd4ca85a5b", false, "Clifton88" },
                    { "55bb12b4-5f2f-400d-82bf-59faa6961904", 0, "bdcf1052-83f6-40f1-8bd6-8006f07b2be7", "Admin_Dawn.Runolfsdottir28@gmail.com", true, false, null, "dawn.runolfsdottir28@gmail.com", "DAWN.RUNOLFSDOTTIR", "AQAAAAIAAYagAAAAEOlmDMwl04wZ5q7PVs0LxzEeh/B3h87gl3XH9Is4WGl7KpI6GDdEqaPAiLsyFTivqg==", "(721) 649-8308 x882", true, "453b4103-26e8-46e1-b384-59294d753a1d", false, "Dawn.Runolfsdottir" },
                    { "6916ead1-9297-4c83-971a-f1e4929c6958", 0, "3957daf7-19e1-4ee7-8b6b-9a65fc1aefb6", "Normal_Georgia32@hotmail.com", true, false, null, "georgia32@hotmail.com", "GEORGIA_OCONNELL", "AQAAAAIAAYagAAAAEHVSIOb/24HouRFpcqbrJUH0k1PRcOFQ7wCKvSv0wc2BluB995O4k1I0BN/DAT94kw==", "(212) 540-8593", true, "2bed34fa-1f73-45e5-a6c6-07fa4569d8dd", false, "Georgia_OConnell" },
                    { "6ef28203-b396-491c-8b7a-30836e16a22f", 0, "33916bcc-a622-4957-a095-f4f4d8d9cb80", "Admin_Lauren.Funk@gmail.com", false, false, null, "lauren.funk@gmail.com", "LAUREN.FUNK", "AQAAAAIAAYagAAAAEMLDnMD8qcHfFbRI4FsRuj5/oWaSM7+oec/qUpMEh7jjyqUOQWzqkixDvjzG30wXzQ==", "712.496.9084", true, "5c10193f-c9f7-4c0b-9b8f-f4ca93990da5", true, "Lauren.Funk" },
                    { "7c778652-d0ca-4591-8429-f296a5975f49", 0, "24bbee2b-c22a-473d-9ae8-b9dc4b823819", "Normal_Marcos32@yahoo.com", false, false, null, "marcos32@yahoo.com", "MARCOS_OKON", "AQAAAAIAAYagAAAAEFamPrRZzQP+0u/J3k7PM+rauyGhqzoEpUKpfz9V7Ay/WZWsyD7GWBVELEjMSpRtnQ==", "565.790.7351 x973", false, "fbb3191e-65f4-46cc-8845-e3e7da9cf91e", true, "Marcos_OKon" },
                    { "7cdf0295-ccb6-4cf8-a1f8-86a8ea94efb9", 0, "6c3377b5-33b5-4598-841a-9dd99aef0ae4", "Admin_Marco15@hotmail.com", true, false, null, "marco15@hotmail.com", "MARCO.PARKER32", "AQAAAAIAAYagAAAAENR1stTljDs529VlDoJSABO3H+nnqa+o3K/b4IwfCikRN5YHxgyuqZQxUMxGGzhgeQ==", "256.307.3958 x848", true, "e76be636-1d53-49b2-affa-046afadbfe80", false, "Marco.Parker32" },
                    { "8afafe15-9786-4a97-9104-834ae933c2f8", 0, "a230d1f6-310f-4016-9a73-df16dc86ccf9", "Admin_Ernestine_Kuphal96@gmail.com", true, false, null, "ernestine_kuphal96@gmail.com", "ERNESTINE_KUPHAL", "AQAAAAIAAYagAAAAEPPlezQp5N0JBZLEIE2cn0PeuBMzbwtI9zZCoc2typ3CdAPdYipf3YsanutnwSLhug==", "1-938-272-1406 x8386", false, "180e73a3-77ca-4d09-819b-00f2d416a363", true, "Ernestine_Kuphal" },
                    { "9339430f-4994-4ba4-8a37-fc32ae7995e5", 0, "65a9332d-d2cf-493d-9a42-437ab4331431", "Admin_Velma.Greenholt@yahoo.com", true, false, null, "velma.greenholt@yahoo.com", "VELMA_GREENHOLT6", "AQAAAAIAAYagAAAAEIITl9gCX/g0VQ8Afo6VNTHpQ0IZO0lN8RwboMRE3SEzM+Kj3isnIxIpxoy1EMEDjw==", "(223) 726-0329 x60292", true, "30408772-646b-4157-8f6b-5ec964eb84e3", false, "Velma_Greenholt6" },
                    { "9a4ac0d4-c8ad-43fd-85e2-c575e98dcd10", 0, "8e3ed79a-29d2-4743-b178-996170a008a2", "Normal_Nelson_Kihn@gmail.com", false, false, null, "nelson_kihn@gmail.com", "NELSON4", "AQAAAAIAAYagAAAAEE4huPVZOuUp3Qj8g+6O7nir1rEPoaTzDRBSHw7/uTWfTtb+IgsDNdE8iuc6oqFwBQ==", "542.710.4713 x14118", true, "4344f4a1-4b45-42b6-83b5-b0426030911a", false, "Nelson4" },
                    { "a579e973-4a23-4931-bbd1-964edae820ec", 0, "24e13a53-253f-4655-a1f3-80c2f50a2760", "Normal_Micheal84@hotmail.com", true, false, null, "micheal84@hotmail.com", "MICHEAL.DOUGLAS78", "AQAAAAIAAYagAAAAEDe4HeXQL7EENOtYl7gblJbFvllyhVecYjvzOw3yMuUuakK/opv/FBS1tV2NLnaF7g==", "968.445.6629 x650", false, "6ee16633-49ea-4c0c-a140-98a053d144d7", false, "Micheal.Douglas78" },
                    { "b64f5f7d-23b3-41fe-bcda-d1b82218f1ef", 0, "34b0034b-544a-455b-9e10-c57ef4b5f2fc", "Normal_Charles45@yahoo.com", true, false, null, "charles45@yahoo.com", "CHARLES.CASSIN", "AQAAAAIAAYagAAAAEPl3XiX1TaKF6Qpzm+L12wIw8nADYzNIOXUtLWAct0J3DXJ0e6JzmV4d44oktGIXXw==", "730-330-3057 x63076", true, "0671ed89-d36b-407e-b8ff-3910f957beaf", true, "Charles.Cassin" },
                    { "b69a04da-68ab-46d8-aa89-ee5701745cef", 0, "bd412eec-8b41-4a07-9a5b-08e2624bdbba", "Normal_Irma88@yahoo.com", true, false, null, "irma88@yahoo.com", "IRMA_PROSACCO68", "AQAAAAIAAYagAAAAENmelZiYkdi8tFFosPSKW0PVwB5TjKM//qbz98y9e3xanK9eHmlesH5wSxatPw4knA==", "877-458-9229 x87281", false, "5fc70d4a-96bc-439d-94a2-209eccd029a8", true, "Irma_Prosacco68" },
                    { "b71ef91f-92b7-4dd2-a54c-24a3285ee0a1", 0, "144901a9-a4da-485e-81f5-56bc1cfac382", "Normal_Tara_Nicolas54@gmail.com", false, false, null, "tara_nicolas54@gmail.com", "TARA_NICOLAS6", "AQAAAAIAAYagAAAAEFHLbiJANyT+kKd6B5FUhJrZPNc+0GW+hqpNDQOc1RM94rq3qC0aF4nghyjYOTgazw==", "346-474-1926", false, "9d650d49-db2c-4c9b-9649-9361e4919338", true, "Tara_Nicolas6" },
                    { "bf49cb3e-c4cd-4574-83f0-650f6d80830d", 0, "c5c483bc-1726-4c95-9ad7-f83cce03934c", "Admin_Sammy_Klein69@hotmail.com", false, false, null, "sammy_klein69@hotmail.com", "SAMMY_KLEIN67", "AQAAAAIAAYagAAAAEBnPiF5cAvjDcCASjrab1mcGibYmsKEXZgipgUmdobEPAKvm+D44KuWi707hTh81Cw==", "460-714-1935 x18268", false, "89fba5fb-384c-4dcb-98c3-0291606ad58d", false, "Sammy_Klein67" },
                    { "c11c5c77-5766-4538-8638-7d9445cc2e60", 0, "143fb8ed-f69d-4efa-9915-89b580ad9860", "Admin_Dominic76@gmail.com", true, false, null, "dominic76@gmail.com", "DOMINIC80", "AQAAAAIAAYagAAAAEEUwlNK3AwXhs484HXKLA1v5irYNXnW0my/ehedtXKr/UCMxPQDnWniLbRGG7wQzFw==", "438.939.2803 x099", true, "b75bde32-e49d-44ad-954b-50db65f35feb", false, "Dominic80" },
                    { "c2f56315-f7cc-4a03-a67b-40b0a7c74c8b", 0, "3a5e759b-4ee9-4094-a56d-122dc5bdf9cc", "Normal_Dianna.Lindgren@yahoo.com", false, false, null, "dianna.lindgren@yahoo.com", "DIANNA64", "AQAAAAIAAYagAAAAEM14mcouMMj4s59KqIhHD2Vhc0c634qW7cL5b2FikMDjLJHIWR4q5ly+ADiReSm1gw==", "(569) 871-5594 x1845", false, "1fcb2f18-9f72-4ac6-96f3-ea9d6da5dc19", true, "Dianna64" },
                    { "cb5b8b5f-2479-4ff3-804d-e02a98a8a9e5", 0, "086ba473-b55a-40f2-a995-d97d794e7f8b", "Normal_Elijah92@hotmail.com", true, false, null, "elijah92@hotmail.com", "ELIJAH.SCHUMM", "AQAAAAIAAYagAAAAEJRIGWyJuufR7rKraFjjAq72CcDJj7S6ratzJxA17bGttwulRVMIfm8vFaSJ7+uRQQ==", "(492) 916-4757", false, "d7c5f520-4627-4d19-9007-3fd1546fdcc0", true, "Elijah.Schumm" },
                    { "cbec3323-c784-4c84-846a-08ce9ae8ab74", 0, "12c90974-3edf-4a59-8c70-135b034486e2", "Normal_Raquel67@yahoo.com", true, false, null, "raquel67@yahoo.com", "RAQUEL_OKEEFE", "AQAAAAIAAYagAAAAEM7qHWbhtzpaiGcTsZP1tq29SnTAMoAal0w1n02Kt1j6OQT4P/FisJVEUTFyH/AOdQ==", "1-562-218-3200", false, "26470e7f-202d-42f7-9116-440f01aa5e9d", true, "Raquel_OKeefe" },
                    { "ce11c11f-150b-4e1a-ba97-56dba1bf65dc", 0, "0857b87f-ef23-44e4-acdc-fbec23163afd", "Normal_Otis55@hotmail.com", true, false, null, "otis55@hotmail.com", "OTIS.DIBBERT56", "AQAAAAIAAYagAAAAECnepprsldkcZwwhtF6SXh+Dq/lBBnpgL/jMKcQ9f4+FPATe/sGbFPc/Fac/8duWIw==", "1-209-393-1506 x6401", false, "f58e004d-979e-4847-8761-eaa51164123e", true, "Otis.Dibbert56" },
                    { "d5db8ba0-6e63-403b-97e5-ffbe7255eb10", 0, "99d21c94-b819-4013-9321-2ac99578977b", "Normal_Lorena_Lesch@hotmail.com", true, false, null, "lorena_lesch@hotmail.com", "LORENA_LESCH28", "AQAAAAIAAYagAAAAEH3dzdfZWt5uLCsH8qS5btVoxdLf5aQNYgTGH9F/01PYPodPL2IYgsykDmyPVJHXhQ==", "(677) 566-9002", true, "a4e8c733-d5a5-4ed0-9c63-fef214fef14d", false, "Lorena_Lesch28" },
                    { "da05e935-55b1-4f41-be58-dcda024601a5", 0, "5693737b-af4d-45bf-9b8e-8dc1de04418a", "Normal_Mack41@gmail.com", false, false, null, "mack41@gmail.com", "MACK.LITTEL", "AQAAAAIAAYagAAAAED32RXFCEVUzszpINr/LqqCWG9nos3EveDAaFPK1T0URM+utZIcpD0XleFqrKa8N3Q==", "1-270-714-3363 x373", true, "cf406461-34e0-4a07-b388-13c772d6ff98", true, "Mack.Littel" },
                    { "dcff2b39-3625-45c0-8c9d-8c28f2de9688", 0, "aeaadda3-9e76-4b1f-b4a3-b8a83f3ae933", "Admin_Sheri25@yahoo.com", false, false, null, "sheri25@yahoo.com", "SHERI.TROMP43", "AQAAAAIAAYagAAAAEKQnrtudJoD9BaJudEQK8TnLBX3FYZpWp/15IGDBw3CiisvLInVKv3GzBumKZrvYHA==", "422.870.4227 x45166", true, "ece11747-6293-4418-921e-879dda9beeed", true, "Sheri.Tromp43" },
                    { "dfc1ac8b-4c23-47c8-91c4-6f11f466e852", 0, "8578eb62-81c3-4d3a-bcbc-5f74c27cf370", "Admin_Jasmine_Schamberger@yahoo.com", false, false, null, "jasmine_schamberger@yahoo.com", "JASMINE13", "AQAAAAIAAYagAAAAECGUezuUNwKeGooRE1Wn9ndsL0GQ+k/eK+SsLm/zn93T1R9nWYbJaMgYrf+sd6eimQ==", "1-727-842-7365", true, "aa6ca9e9-5594-4009-8b93-06b5d58ecba2", true, "Jasmine13" },
                    { "e7f66327-3a79-4e49-91aa-f3b744baa9f6", 0, "c6fc9fa2-2210-4742-81e7-bdab3680fe3e", "Admin_Elsa30@yahoo.com", false, false, null, "elsa30@yahoo.com", "ELSA.GAYLORD30", "AQAAAAIAAYagAAAAECk977b79N/zU1RHFg7PecZSpyHTFXGs3ViOAfl4e+4Tdd/k0ERmZ4nQNeInRMBD2w==", "923.498.5779", false, "c2319bfc-57af-4344-870a-f58324e19dcd", true, "Elsa.Gaylord30" },
                    { "ea766fbb-c46e-4863-b7ad-9192553aaaaf", 0, "e8d23398-0286-4c61-9764-ca33cff33210", "Admin_Marcus.Grant@gmail.com", true, false, null, "marcus.grant@gmail.com", "MARCUS_GRANT", "AQAAAAIAAYagAAAAEFCzmVrTiMPNNOd/fn5m9mHap3/2xIwfVSy98y4zoAWqN7fBYaDcuTs8x6StcDuOUg==", "565.682.7305", true, "cdcdeb8b-d23f-4b18-a3ce-68ef33697400", false, "Marcus_Grant" },
                    { "f939be2b-8f4e-463b-85f3-ebc6fba084da", 0, "eb593491-d722-40bc-85bc-fa1a8e3fc5e0", "Admin_Pat56@yahoo.com", false, false, null, "pat56@yahoo.com", "PAT11", "AQAAAAIAAYagAAAAEMwOPWlxQMtDraoOMEYID5Sp/xTs8+rt0kTIcJ332TJIbEq9z73zGeHqZM3ERKODHQ==", "(869) 421-1908 x526", false, "981117af-a574-4b9b-aca4-133efba24257", false, "Pat11" },
                    { "fc284c83-f8c1-4138-a945-df8dde5a681e", 0, "99b7dea9-e007-40bb-9dfb-b0c345669047", "Normal_Benny.Walker@gmail.com", true, false, null, "benny.walker@gmail.com", "BENNY_WALKER49", "AQAAAAIAAYagAAAAEKp0vK2qt0rNc/CyHZV8o3MKZxSAnpgGnW3lWhlCMZL8sH097xCMKcrVTj9SFykBFw==", "(457) 499-2860", false, "05cce709-3594-4dd7-aae4-02dfa8620262", false, "Benny_Walker49" },
                    { "fde8dd10-e75e-4723-89e1-bb525ab01b14", 0, "93594ab8-2aad-4078-973e-195aa1ee74ef", "Normal_Melody.Bosco87@hotmail.com", true, false, null, "melody.bosco87@hotmail.com", "MELODY25", "AQAAAAIAAYagAAAAEN8mX4xHJIfjuIp02Xm4464gmb8Y6yP8NapQWjEhsESBSKs6t21zCs/9iNnKItYHbw==", "1-367-785-4909 x5624", true, "dc872fee-62b1-4ac2-8327-d95d9ace4ee4", true, "Melody25" }
                });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "Bs", "Name", "Suffix" },
                values: new object[,]
                {
                    { new Guid("00d98747-7861-41ef-92ea-a80613e5c1a9"), "morph impactful schemas", "Schoen LLC", "and Sons" },
                    { new Guid("049e2802-01ce-45f3-ac2d-7362656a8e5a"), "implement user-centric networks", "Yundt LLC", "LLC" },
                    { new Guid("04c197c0-f750-42d8-852a-916bd4081cc8"), "deliver front-end schemas", "Kuphal, West and Marquardt", "LLC" },
                    { new Guid("06d72782-8714-47db-a6fc-61c29f4a6f93"), "empower enterprise bandwidth", "Senger - Miller", "Inc" },
                    { new Guid("07fb8fd7-7817-4b0b-a350-0f7073d0c618"), "matrix impactful infomediaries", "Waters, Farrell and Green", "Inc" },
                    { new Guid("0fc8417b-299d-434f-b87e-bd25ebdbcf36"), "implement clicks-and-mortar markets", "Littel, Olson and Simonis", "Group" },
                    { new Guid("1dbc8312-2e10-46f4-a929-f10af8e782e4"), "disintermediate real-time content", "Hintz, Volkman and Nikolaus", "LLC" },
                    { new Guid("2151226e-866f-40f1-9ecd-62fd2940b02a"), "architect distributed mindshare", "Kertzmann - Howe", "Inc" },
                    { new Guid("3b66a3c2-00ea-4e22-98b0-eb37862b2971"), "repurpose revolutionary architectures", "Pfeffer - Hickle", "Group" },
                    { new Guid("48f1262e-fd92-43cf-9d8d-394da69e0d23"), "integrate bricks-and-clicks models", "Willms, Reinger and Ziemann", "LLC" },
                    { new Guid("4920bc75-6e46-461a-ad46-1c8100d56f69"), "orchestrate intuitive e-tailers", "Langworth - Dibbert", "Group" },
                    { new Guid("4ee541e9-5fca-4585-85fa-874b0ac114ce"), "cultivate dynamic synergies", "Considine - Ziemann", "and Sons" },
                    { new Guid("56c23dc1-6ce1-4926-9530-5cba535f2679"), "maximize interactive convergence", "Bogisich, Casper and Macejkovic", "Group" },
                    { new Guid("58716325-0383-448e-88f6-bef077e1e08a"), "grow ubiquitous partnerships", "Bednar LLC", "LLC" },
                    { new Guid("59ad1007-6d73-470e-9544-5867113670b9"), "implement B2C functionalities", "Konopelski - Mohr", "Group" },
                    { new Guid("59b9563b-b4a5-4865-940d-de996ea25805"), "synthesize global solutions", "Kunze Group", "Group" },
                    { new Guid("5b593175-75f8-44ef-baa8-778161221f1c"), "extend vertical portals", "Koch - Hansen", "LLC" },
                    { new Guid("6254de98-f0d1-4cd4-8157-b3a872808985"), "extend leading-edge blockchains", "Feest, Torp and Gutmann", "and Sons" },
                    { new Guid("633ea24f-aa60-4af5-a620-1ed7caee6826"), "visualize scalable supply-chains", "Waters - Jacobson", "and Sons" },
                    { new Guid("634dcede-4350-49ca-b061-34510f7881eb"), "integrate granular vortals", "Rutherford - Morissette", "and Sons" },
                    { new Guid("6459c241-d70a-4ac1-a450-7d3b9e8225ba"), "synthesize revolutionary synergies", "Crist - Gutkowski", "and Sons" },
                    { new Guid("6624512e-e537-4d2a-8e7b-4b127439e828"), "drive vertical e-business", "Heller, Lueilwitz and Strosin", "Inc" },
                    { new Guid("6ac10459-93d8-439c-afcb-1ae9a8a778dc"), "maximize magnetic channels", "Schultz Inc", "Inc" },
                    { new Guid("6cc34e56-6404-4a9b-b4c6-fdaa9cd61ff6"), "productize front-end e-commerce", "Jast Inc", "Group" },
                    { new Guid("8c219bcf-eba3-4e8d-b84d-4d828bf56da3"), "integrate scalable portals", "Smitham LLC", "Inc" },
                    { new Guid("b323ac8c-4f0d-472f-8a31-8657d197f045"), "deliver impactful solutions", "Lowe - Bergstrom", "LLC" },
                    { new Guid("c72b7578-bbb8-4df0-947b-c154acdbaf3f"), "streamline wireless supply-chains", "Kuphal - Deckow", "Group" },
                    { new Guid("c7b56e33-a371-40b2-9285-b50802788150"), "redefine collaborative initiatives", "Mitchell LLC", "Group" },
                    { new Guid("cfa77865-26d5-4f05-91b7-2a707de06b04"), "cultivate efficient channels", "Price, Yost and Hudson", "Inc" },
                    { new Guid("d2401012-fd36-455c-a827-6ee28617cfb8"), "seize best-of-breed relationships", "White, Renner and Stracke", "LLC" },
                    { new Guid("d4ce6510-0157-4059-af12-eb8e171eae8f"), "visualize B2C metrics", "Stehr, Ortiz and Sawayn", "Group" },
                    { new Guid("def8704c-dbc7-47e8-8784-7aee494b1deb"), "seize granular technologies", "Rath - Abbott", "and Sons" },
                    { new Guid("e630af93-0559-4bf1-94b4-978c752e8d44"), "streamline proactive infomediaries", "Price - Koelpin", "Group" },
                    { new Guid("ec65c71b-b316-4044-97fd-ece8b56d8574"), "recontextualize end-to-end e-services", "Prohaska and Sons", "and Sons" },
                    { new Guid("efeb9a0e-1496-421e-b411-13c0593247a2"), "exploit front-end convergence", "Brekke, Gottlieb and Russel", "LLC" },
                    { new Guid("f09d88c5-6c83-4909-b88b-0894539bc1d8"), "implement cross-platform paradigms", "Auer - Cormier", "LLC" },
                    { new Guid("fcbfff63-7f7c-4e98-bcba-8a4bb82f7767"), "innovate interactive blockchains", "Bauch Inc", "Group" },
                    { new Guid("fef9992f-116b-45ea-b67e-ec66466f23ff"), "reinvent B2C channels", "Schinner - Dickinson", "Inc" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("0060ddde-2379-47aa-a8be-9aa3b4b09824"), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Handcrafted Steel Chicken", "152.38" },
                    { new Guid("02ac953c-38d7-4bb8-8547-888a8036606c"), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Fantastic Plastic Shirt", "192.31" },
                    { new Guid("03380bd3-3585-4f0e-8af7-a5341d27223a"), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Sleek Frozen Towels", "402.89" },
                    { new Guid("04a693e2-e1b4-4c83-92c8-8f84db44b954"), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Small Fresh Pizza", "217.89" },
                    { new Guid("04c730ea-361b-4d71-816a-59f7c4431b84"), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Refined Frozen Bike", "530.52" },
                    { new Guid("0783d20b-7ddd-4f16-ba6c-7ae651a1b2d6"), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Ergonomic Plastic Ball", "49.49" },
                    { new Guid("085fb83d-7216-4b69-af9c-1d1338c6a169"), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Practical Plastic Shirt", "391.84" },
                    { new Guid("0a764522-2cf9-414c-acb9-260f50abd115"), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Small Rubber Pants", "575.16" },
                    { new Guid("0f03bbde-384a-4150-a4b7-4ea2cec53bd7"), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Small Fresh Computer", "609.90" },
                    { new Guid("0f35a48f-d1a4-4d4e-ab79-d88c21383a41"), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Intelligent Plastic Fish", "93.67" },
                    { new Guid("14cbff37-aad5-4843-9710-c0cca41cfd35"), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Sleek Metal Soap", "563.64" },
                    { new Guid("18375b13-f14e-45d2-9642-34a932d36359"), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Small Rubber Towels", "583.35" },
                    { new Guid("191ae482-25dd-48b5-8e7e-f85745010219"), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Refined Concrete Salad", "707.05" },
                    { new Guid("19cbbf5c-4cd0-4973-8db0-8a9ee4ae2ab7"), "The Football Is Good For Training And Recreational Purposes", "Incredible Rubber Soap", "651.32" },
                    { new Guid("1d625de6-0084-42cc-8a82-4e46d840899e"), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Practical Fresh Chicken", "289.03" },
                    { new Guid("1fa5f234-bbbf-4c2e-ae25-7d11f05e285d"), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Rustic Fresh Tuna", "198.21" },
                    { new Guid("216a1f14-acb0-4c58-8dd7-a99084442008"), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Intelligent Granite Table", "621.92" },
                    { new Guid("24202b31-5289-40d3-8293-7df4283e8236"), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Handmade Soft Chair", "729.00" },
                    { new Guid("24b12c2c-ae68-4d5c-b105-648d2703a9a2"), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Handmade Soft Soap", "317.66" },
                    { new Guid("2d99f9c3-52aa-40bc-9104-47ea6b3b3548"), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Handmade Steel Tuna", "471.95" },
                    { new Guid("303ffca6-180c-46fc-a4b9-decb479a3efd"), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Tasty Soft Fish", "714.78" },
                    { new Guid("3126749d-07d6-42e2-887a-e0fb4ebdf433"), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Handmade Granite Chicken", "921.99" },
                    { new Guid("3c9775a5-49b0-405c-9ab3-8f00bcb9568e"), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Refined Frozen Salad", "794.96" },
                    { new Guid("3d24f711-6a06-4fbe-81f8-f100e236639b"), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Small Granite Hat", "709.90" },
                    { new Guid("400eae56-332d-491d-b9e7-3802a7d3cae1"), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Incredible Wooden Computer", "834.12" },
                    { new Guid("4475fac1-4749-49cf-9002-79262ce94e1d"), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Licensed Cotton Salad", "776.69" },
                    { new Guid("44b229ca-0c34-4a27-92bf-3b70685d8df0"), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Gorgeous Cotton Fish", "544.48" },
                    { new Guid("47649985-5d81-47c8-ae28-b26df79645cf"), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Ergonomic Granite Bacon", "617.97" },
                    { new Guid("48cb1fbe-8e12-40fe-b3f7-7015a7f25955"), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Unbranded Rubber Tuna", "634.79" },
                    { new Guid("49fb9b82-376d-415b-b1be-0ddb3e6b4a59"), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Generic Frozen Fish", "821.85" },
                    { new Guid("4fa77f53-e156-4023-8fff-4f851bf57847"), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Ergonomic Cotton Computer", "861.28" },
                    { new Guid("4fc027e5-56b4-49e8-8538-d59efcd6281b"), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Handmade Metal Fish", "958.20" },
                    { new Guid("5812c376-284e-420c-b737-52888ec42110"), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Practical Concrete Ball", "10.34" },
                    { new Guid("58a3f8b2-acc2-4cfb-b8e2-581bcb159ea8"), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Handcrafted Steel Car", "7.87" },
                    { new Guid("5c38ddac-cafc-4820-8d9a-6bcd038e301a"), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Sleek Soft Table", "438.53" },
                    { new Guid("5db7c9d7-18fd-455b-aa7e-cce08143d34c"), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Generic Plastic Ball", "703.49" },
                    { new Guid("60cc539b-051e-4d47-9d64-41daf3c8bc30"), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Fantastic Soft Tuna", "192.04" },
                    { new Guid("6243fdf9-2f91-4197-821c-d1104be80ec8"), "The Football Is Good For Training And Recreational Purposes", "Small Rubber Soap", "940.90" },
                    { new Guid("68b1c9be-926f-410f-aff9-f29a4882b67f"), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Fantastic Granite Bike", "496.63" },
                    { new Guid("69c26d40-bd9c-4045-8186-ca4fd25216b7"), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Handmade Plastic Bacon", "228.13" },
                    { new Guid("6be70c22-013f-4fed-a532-dbd969e65dc0"), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Generic Frozen Tuna", "509.82" },
                    { new Guid("6e3d8904-2c00-41a7-9da9-b509227e6e76"), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Incredible Plastic Mouse", "658.60" },
                    { new Guid("7b7b1153-9f68-470f-8b86-47adbbc9efd0"), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Ergonomic Wooden Chips", "623.40" },
                    { new Guid("80ce7142-376a-4bac-8e2c-b97a2fd6a3ff"), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Gorgeous Cotton Shoes", "285.27" },
                    { new Guid("81a169a2-0712-4cef-ab38-a57494144b95"), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Small Wooden Table", "918.33" },
                    { new Guid("85a036a5-1607-4e52-8c2a-7b9e52cd3a7f"), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Rustic Cotton Soap", "87.72" },
                    { new Guid("862713d3-4b00-4c48-acc2-a0b7a6b84992"), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Practical Concrete Chair", "993.28" },
                    { new Guid("86a8aa2a-d864-42f5-8537-eb8682416a8c"), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Small Rubber Pizza", "182.20" },
                    { new Guid("874093ce-fb8d-4e60-abff-38fbdca1461d"), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Handcrafted Wooden Cheese", "80.66" },
                    { new Guid("87586031-a34e-45e6-81df-63487d9c25e0"), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Tasty Wooden Pants", "527.86" },
                    { new Guid("94b94aca-ecdd-4c87-b35a-292888558925"), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Licensed Plastic Bike", "341.45" },
                    { new Guid("97dcb82f-dc5d-4793-8f6a-3accb349f7d8"), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Incredible Rubber Towels", "119.38" },
                    { new Guid("995a2702-835e-4bb5-992f-d1575971eb3f"), "The Football Is Good For Training And Recreational Purposes", "Intelligent Granite Ball", "751.88" },
                    { new Guid("9acb8254-6558-4dec-81c5-ff79f56047bd"), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Rustic Rubber Mouse", "668.97" },
                    { new Guid("9c030eba-a977-4793-b325-5537b248dd20"), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Tasty Plastic Hat", "587.22" },
                    { new Guid("a05ddb43-3dbb-4dad-b468-741efc17b4f9"), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Intelligent Fresh Chicken", "168.55" },
                    { new Guid("a276c73e-c925-4eeb-bace-96c9b1618cb4"), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Handmade Rubber Table", "196.68" },
                    { new Guid("ae15ee65-53b6-45b7-a4d7-2ccd67300ac2"), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Tasty Metal Mouse", "29.26" },
                    { new Guid("b00820a6-8abe-4e9b-a1e0-fd28a20a9c96"), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Sleek Wooden Hat", "949.60" },
                    { new Guid("b094ea11-f394-4212-868b-036f0563aa91"), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Rustic Plastic Chair", "557.95" },
                    { new Guid("b219f599-4560-4f24-bb94-ed81d7cf6ea8"), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Handcrafted Wooden Chips", "233.27" },
                    { new Guid("b5f31a9b-f837-4582-8c94-7d85c1c9f798"), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Small Steel Salad", "679.53" },
                    { new Guid("b5f703b9-c088-49ce-b3f1-e8f06f093e88"), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Practical Fresh Salad", "858.31" },
                    { new Guid("b617602e-9afc-47ca-9c50-46584060e7b2"), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Small Rubber Soap", "946.68" },
                    { new Guid("b6371f5b-84cf-4fc0-878c-2e0f34a75e96"), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Rustic Soft Shirt", "701.79" },
                    { new Guid("b8a4c82a-9721-4991-8553-c0555a57d98e"), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Awesome Cotton Ball", "428.82" },
                    { new Guid("c2a6edc8-27f4-4793-bd3c-d2de8e78a6b0"), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Licensed Plastic Gloves", "505.86" },
                    { new Guid("c3cefe04-9ad1-4a49-8c88-82118e330155"), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Ergonomic Granite Pizza", "803.49" },
                    { new Guid("c4d54699-b63d-4bbd-8253-e5219dd9a711"), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Handmade Cotton Shoes", "608.14" },
                    { new Guid("cccdd1f4-4e62-424c-98a1-0fe9fecd2d6a"), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Fantastic Soft Bacon", "330.08" },
                    { new Guid("cce2885a-59ce-4811-8fad-43e8bac1df50"), "The Football Is Good For Training And Recreational Purposes", "Incredible Plastic Car", "718.95" },
                    { new Guid("cee56c32-a6db-47e1-9f72-a99838dc8221"), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Unbranded Wooden Chair", "621.85" },
                    { new Guid("d02a4c8b-2ee5-4f64-b99e-67234890a17e"), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Handmade Fresh Car", "872.80" },
                    { new Guid("d37c09f8-937c-4bde-93a5-61550edee5cf"), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Tasty Metal Gloves", "959.87" },
                    { new Guid("d3e89144-1394-4b8c-b4ca-3b074800927f"), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Sleek Steel Gloves", "399.04" },
                    { new Guid("d4fbd7e5-1582-492a-a8b4-d633ed53fe0b"), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Handmade Frozen Gloves", "292.39" },
                    { new Guid("da933e1e-35a6-4681-ac46-d0ae463c4279"), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Licensed Frozen Bacon", "73.33" },
                    { new Guid("de9b51a8-a713-4997-bfc2-ac0602d52a9e"), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Unbranded Soft Shoes", "681.34" },
                    { new Guid("def6e59f-384c-4abd-b2b9-6f7905b0d0ad"), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Tasty Fresh Soap", "451.20" },
                    { new Guid("e0d609d0-ca87-4abe-8ca1-9f844c371b44"), "The Football Is Good For Training And Recreational Purposes", "Ergonomic Concrete Soap", "887.82" },
                    { new Guid("e410d73a-df9f-44e9-ba97-a67488a48089"), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Intelligent Steel Cheese", "955.53" },
                    { new Guid("e62d5399-2f99-475a-93f5-0c4b5e912ad2"), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Gorgeous Plastic Pizza", "651.53" },
                    { new Guid("e8a6ce3c-995d-40b0-9dfa-5b837b062d2e"), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Sleek Frozen Pants", "188.68" },
                    { new Guid("ec4647fa-229c-472f-89ed-f77b69493c8b"), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Refined Metal Table", "32.91" },
                    { new Guid("eca386be-636e-4abb-ad3f-59e7a6359c66"), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Practical Concrete Pants", "433.34" },
                    { new Guid("ed8b1b35-dc5d-4b5d-8542-fb4e1410ac64"), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Gorgeous Cotton Shoes", "646.11" },
                    { new Guid("fa19f8c3-9274-4348-8ddb-bd5c6e7116e4"), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Awesome Fresh Cheese", "709.84" },
                    { new Guid("fe716469-b9a0-4ff5-8649-7150806f368b"), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Refined Metal Bacon", "175.30" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "03027802-038f-42a7-8309-5246571c1fb2", "008bb752-920a-4ea8-baa6-ffb3bb4c7454" },
                    { "6a1fa3c0-2895-4574-a23c-e2aab793b25b", "0c4c5d25-86e7-445b-a793-a58012e0b3cb" },
                    { "03027802-038f-42a7-8309-5246571c1fb2", "0d4a1135-ad71-4f8f-a6db-e5781e526bbe" },
                    { "03027802-038f-42a7-8309-5246571c1fb2", "1e32bc6c-4956-4b25-897a-b2ef95bd59e5" },
                    { "03027802-038f-42a7-8309-5246571c1fb2", "1eb8d837-9b0f-46b1-95e1-ae0c601a5e93" },
                    { "6a1fa3c0-2895-4574-a23c-e2aab793b25b", "21da110d-ff16-4f8c-a0ec-26bf33e50ea5" },
                    { "03027802-038f-42a7-8309-5246571c1fb2", "399755cd-5641-475e-8471-87f26d7a65f0" },
                    { "6a1fa3c0-2895-4574-a23c-e2aab793b25b", "3c678a34-ff53-4f91-8bcc-b31f39209abc" },
                    { "6a1fa3c0-2895-4574-a23c-e2aab793b25b", "3d8dfd45-bd20-4157-afe3-f4d3ae121783" },
                    { "03027802-038f-42a7-8309-5246571c1fb2", "3f9c0597-d6e2-42dc-9f90-937fcd19b473" },
                    { "03027802-038f-42a7-8309-5246571c1fb2", "42a62f99-f8fc-41ca-867b-82234f261c5e" },
                    { "03027802-038f-42a7-8309-5246571c1fb2", "43b0f940-504b-4ea0-96b6-44ddd3991f85" },
                    { "6a1fa3c0-2895-4574-a23c-e2aab793b25b", "44b77798-2ac7-43d8-9507-3f5bafdb9e85" },
                    { "6a1fa3c0-2895-4574-a23c-e2aab793b25b", "51c316c7-cb07-469b-b2d4-b64a0d730344" },
                    { "03027802-038f-42a7-8309-5246571c1fb2", "55bb12b4-5f2f-400d-82bf-59faa6961904" },
                    { "6a1fa3c0-2895-4574-a23c-e2aab793b25b", "6916ead1-9297-4c83-971a-f1e4929c6958" },
                    { "03027802-038f-42a7-8309-5246571c1fb2", "6ef28203-b396-491c-8b7a-30836e16a22f" },
                    { "6a1fa3c0-2895-4574-a23c-e2aab793b25b", "7c778652-d0ca-4591-8429-f296a5975f49" },
                    { "03027802-038f-42a7-8309-5246571c1fb2", "7cdf0295-ccb6-4cf8-a1f8-86a8ea94efb9" },
                    { "03027802-038f-42a7-8309-5246571c1fb2", "8afafe15-9786-4a97-9104-834ae933c2f8" },
                    { "03027802-038f-42a7-8309-5246571c1fb2", "9339430f-4994-4ba4-8a37-fc32ae7995e5" },
                    { "6a1fa3c0-2895-4574-a23c-e2aab793b25b", "9a4ac0d4-c8ad-43fd-85e2-c575e98dcd10" },
                    { "6a1fa3c0-2895-4574-a23c-e2aab793b25b", "a579e973-4a23-4931-bbd1-964edae820ec" },
                    { "6a1fa3c0-2895-4574-a23c-e2aab793b25b", "b64f5f7d-23b3-41fe-bcda-d1b82218f1ef" },
                    { "6a1fa3c0-2895-4574-a23c-e2aab793b25b", "b69a04da-68ab-46d8-aa89-ee5701745cef" },
                    { "6a1fa3c0-2895-4574-a23c-e2aab793b25b", "b71ef91f-92b7-4dd2-a54c-24a3285ee0a1" },
                    { "03027802-038f-42a7-8309-5246571c1fb2", "bf49cb3e-c4cd-4574-83f0-650f6d80830d" },
                    { "03027802-038f-42a7-8309-5246571c1fb2", "c11c5c77-5766-4538-8638-7d9445cc2e60" },
                    { "6a1fa3c0-2895-4574-a23c-e2aab793b25b", "c2f56315-f7cc-4a03-a67b-40b0a7c74c8b" },
                    { "6a1fa3c0-2895-4574-a23c-e2aab793b25b", "cb5b8b5f-2479-4ff3-804d-e02a98a8a9e5" },
                    { "6a1fa3c0-2895-4574-a23c-e2aab793b25b", "cbec3323-c784-4c84-846a-08ce9ae8ab74" },
                    { "6a1fa3c0-2895-4574-a23c-e2aab793b25b", "ce11c11f-150b-4e1a-ba97-56dba1bf65dc" },
                    { "6a1fa3c0-2895-4574-a23c-e2aab793b25b", "d5db8ba0-6e63-403b-97e5-ffbe7255eb10" },
                    { "6a1fa3c0-2895-4574-a23c-e2aab793b25b", "da05e935-55b1-4f41-be58-dcda024601a5" },
                    { "03027802-038f-42a7-8309-5246571c1fb2", "dcff2b39-3625-45c0-8c9d-8c28f2de9688" },
                    { "03027802-038f-42a7-8309-5246571c1fb2", "dfc1ac8b-4c23-47c8-91c4-6f11f466e852" },
                    { "03027802-038f-42a7-8309-5246571c1fb2", "e7f66327-3a79-4e49-91aa-f3b744baa9f6" },
                    { "03027802-038f-42a7-8309-5246571c1fb2", "ea766fbb-c46e-4863-b7ad-9192553aaaaf" },
                    { "03027802-038f-42a7-8309-5246571c1fb2", "f939be2b-8f4e-463b-85f3-ebc6fba084da" },
                    { "6a1fa3c0-2895-4574-a23c-e2aab793b25b", "fc284c83-f8c1-4138-a945-df8dde5a681e" },
                    { "6a1fa3c0-2895-4574-a23c-e2aab793b25b", "fde8dd10-e75e-4723-89e1-bb525ab01b14" }
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
                name: "Companies");

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
