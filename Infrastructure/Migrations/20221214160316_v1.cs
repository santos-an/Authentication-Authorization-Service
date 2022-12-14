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
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "98483377-3d9a-473a-bfaa-b930dcce1485", null, "Normal", "NORMAL" },
                    { "f2039480-8d48-4a8b-b285-82dc21d05afd", null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "03af4b0b-d274-463f-af0e-29c388cba752", 0, "eb401067-5b4b-4949-afa0-f4327cfa1357", "Rufus_Rolfson12@yahoo.com", false, false, null, "Rufus_Rolfson12@yahoo.com", "Rufus2", "AQAAAAIAAYagAAAAEO9zU90cfQXmU80rMQU1TM5ooamD6scq5u4Ca6458VvCeUPmfFMI0/nML+H0IhQ7Fw==", "780-218-6374", false, "9aec3e23-f011-4d1b-8b75-1d4965f94930", false, "Rufus2" },
                    { "13f3f2f3-f94b-4da7-871a-2f23aecfa049", 0, "e4431ad4-e9e9-435a-adb3-d44a5bb6cc93", "Vicki_Oberbrunner@yahoo.com", false, false, null, "Vicki_Oberbrunner@yahoo.com", "Vicki61", "AQAAAAIAAYagAAAAEMjaakbv3ACrggRmZmUrQiVTPzdia6JejG8Wt+ZgGOidKhkBC0OjfxJpMtjOHWctzA==", "576-591-5550 x2045", false, "07d76d1c-08a4-4814-9a27-d8c926eb9f02", false, "Vicki61" },
                    { "157466a3-3b0d-4ef6-87b9-ad177a1c2553", 0, "39f7da35-f246-4abe-add2-182ec18ab7f1", "Danielle_Batz@yahoo.com", true, false, null, "Danielle_Batz@yahoo.com", "Danielle.Batz33", "AQAAAAIAAYagAAAAEFi3mY3xgPFOEa0PHTYucPQ6Yi0pdan7rwXaWozJi1haFNelXYSJERQd6M/nZVFLSw==", "747-214-0442", false, "d3a0b84a-bf06-46e6-b30d-09c38c570d22", false, "Danielle.Batz33" },
                    { "1b18f38a-132c-4f71-a9ea-caa9d74527f6", 0, "93fe6af3-7bea-4341-8c22-80b3d4c169b8", "Rita98@yahoo.com", true, false, null, "Rita98@yahoo.com", "Rita.Zemlak", "AQAAAAIAAYagAAAAENMXAhaOL+KVr54J8Lv4KaF6Hn/Qu+vpxnKrz6fwUwIRf8OpPb/i5GkqCIfPTigA1w==", "605.216.7053 x2141", false, "4879883b-08ea-4f08-829e-baabb9ab4da4", false, "Rita.Zemlak" },
                    { "2338290f-6fc5-4290-80b3-3ec3d88f980c", 0, "a571ee12-d50d-4da3-83d3-e59d38036568", "Lorraine_Haley@hotmail.com", false, false, null, "Lorraine_Haley@hotmail.com", "Lorraine_Haley", "AQAAAAIAAYagAAAAEIVJidIYEvLL0EAHbdpdFrGDf85XLnCRHYPlSEkkH8k1RA5dG1UL7n24W+dpRfJryw==", "778-505-6008", false, "8245e79a-e587-4618-9456-6cf23e7510ac", false, "Lorraine_Haley" },
                    { "251ff7b7-36b3-47f1-a3c2-bc12579c36eb", 0, "dda96ff5-9727-4e1b-bc8a-695389e7eeac", "Mark_Murray@gmail.com", false, false, null, "Mark_Murray@gmail.com", "Mark.Murray", "AQAAAAIAAYagAAAAEOO7EeA//n41H3ra06leC+/juuyjH0roI+AaiS8VwPrlkSOpp+dkh5szbsgbDx06hw==", "694.487.2778 x76421", false, "7d27e4d4-2e61-457c-8b1b-003ac1e1d379", false, "Mark.Murray" },
                    { "29aae9f3-48c4-4f68-8158-f5abff186b2d", 0, "95b83a1f-271a-49b9-9e39-f4b39a3420e9", "Brooke.Okuneva@hotmail.com", false, false, null, "Brooke.Okuneva@hotmail.com", "Brooke2", "AQAAAAIAAYagAAAAEElGGXwjp+xnFGxuCOnt2snd2EaKmGu0Ghcin4VlexAwpJLW6rfhYhQt4a5eEr5+QA==", "293-477-1188 x357", false, "0782db7b-4871-40a2-b18d-b646c7133b1b", false, "Brooke2" },
                    { "2c2d4fa6-850a-4d51-bc66-5523fef76ea7", 0, "20d85dce-bffc-448d-b666-badecbc34212", "Vera.Considine@yahoo.com", true, false, null, "Vera.Considine@yahoo.com", "Vera53", "AQAAAAIAAYagAAAAEMHFB6Znj1MzQfnLwl8QfO5rNe1VwmaK/Co3S+NByRrFCS1i53CAHE5dgcOyU2GwmQ==", "1-315-561-0114 x27762", false, "6185ebb2-cf1f-4f9a-abf1-0fba23ac447a", false, "Vera53" },
                    { "2ebf2ded-7a1f-4025-b6e1-47b262dba3e1", 0, "d671fd19-315e-477f-abeb-f1295bd53581", "Melody_Spinka73@yahoo.com", false, false, null, "Melody_Spinka73@yahoo.com", "Melody.Spinka", "AQAAAAIAAYagAAAAEGb0uKd+nNJG7v6zN+bibFgghIjdHjkZXqzJIEy7X4pty99gu4ojShSr1eJ2yh4Epw==", "334.603.7379 x76176", false, "a8ad1459-be71-42de-9644-804a25ce4727", false, "Melody.Spinka" },
                    { "33654742-d30d-40aa-ba66-f5ac850af53b", 0, "04841e51-3838-4519-849b-857b2190e78c", "Sandra.Kassulke78@hotmail.com", false, false, null, "Sandra.Kassulke78@hotmail.com", "Sandra.Kassulke60", "AQAAAAIAAYagAAAAEA7Fonfyh77HMDoLgSYspUQlu28mSfF1ezVHf/d6fwCCD9DUyFrv2RwTdV2zqH4t+Q==", "(259) 218-5008", false, "030b0dfc-c33d-4c3d-a6be-a716d8cb2492", false, "Sandra.Kassulke60" },
                    { "36137695-fef0-4980-b1bf-aac525d02552", 0, "c27622d0-cd48-4431-9c2f-4bc697331293", "Leticia.Wisozk89@yahoo.com", true, false, null, "Leticia.Wisozk89@yahoo.com", "Leticia.Wisozk", "AQAAAAIAAYagAAAAEGS9D62bN3GQ1UY3O7f95tc41vARvpjKFovC+69PrR7gFxev52Rl2RTqrQBZQ57pmw==", "448.689.4643 x68963", false, "f6d8580a-8c12-47d4-83ed-fcc8a365f074", false, "Leticia.Wisozk" },
                    { "3c54393d-c022-4e4b-ad29-607d2e6440e5", 0, "5a59d221-e2b8-48ba-b4b5-ea536aef1d12", "Mack_Bayer66@hotmail.com", false, false, null, "Mack_Bayer66@hotmail.com", "Mack1", "AQAAAAIAAYagAAAAEN77RkD/P8wHCyfH1IaZkS9uwZXd6MsKTo0xvTs4ERHs/njen7fESzlhKyyjzlOpfg==", "(556) 858-4772", false, "56aa0d0f-367e-4cc1-a391-139844dca64c", false, "Mack1" },
                    { "44bc0339-1ab4-49d0-8bf5-8b53b428fa41", 0, "77eec498-7149-48e4-a068-b24dfa902e2a", "Alyssa_Spencer4@yahoo.com", true, false, null, "Alyssa_Spencer4@yahoo.com", "Alyssa75", "AQAAAAIAAYagAAAAEDK6jd1WJCsMkdJK2RBNr+xkZmO8arjhM+y0rqZiZclQpIRzXUWHrlRD50m+8z/I3Q==", "1-455-831-3850", false, "96089f09-17f0-489b-b20a-de71d13cf37c", false, "Alyssa75" },
                    { "45d59834-ca32-47f2-a34b-38e9cbff636f", 0, "078421e9-4d04-4009-9fc9-c77189d19c21", "Wesley_Fisher91@hotmail.com", true, false, null, "Wesley_Fisher91@hotmail.com", "Wesley_Fisher49", "AQAAAAIAAYagAAAAEPxqEQCNFXa5ABsPn9GZczOA6Qx7hFBvZDcTFpccOBo3U1nCaqIy+Xitc4hjrupMkA==", "720.825.8943 x99547", false, "bf284a05-056f-43b2-9c60-ea8acbc7d660", false, "Wesley_Fisher49" },
                    { "482f9857-d50f-4b8a-8317-4b7a8dfea6e7", 0, "7b8f865f-dd9a-47a3-94d1-d04a3ccabfd2", "Isaac72@hotmail.com", true, false, null, "Isaac72@hotmail.com", "Isaac_Grant70", "AQAAAAIAAYagAAAAEJEp0wA8lmyTpWJJFYeKSFOR4U691Xav6TCxgVDgds/5lhl7YSZgFP2NZEj6P6agMg==", "306-812-1475", false, "5b84b66c-f5a3-406d-8b1e-49661668b573", false, "Isaac_Grant70" },
                    { "4b414ac5-1a72-400d-94dc-4d844ae494e2", 0, "99b142c4-d461-46ba-a87d-624e52025d56", "Fredrick_Walter@hotmail.com", false, false, null, "Fredrick_Walter@hotmail.com", "Fredrick.Walter", "AQAAAAIAAYagAAAAEP7nOogolzZ5vs+OeOi6X3Q6Xx4IvCPu02fT4K26828IPvlNMHB+PO5OcVyK6NKHWQ==", "292-659-3806", false, "7375e0d5-38e0-4716-bf5b-df3460471a09", false, "Fredrick.Walter" },
                    { "4b814b0e-4209-43c6-ba54-8c7b1f3bb5b2", 0, "d4739ec0-328b-402b-b7e2-f88221a55bab", "Brian42@gmail.com", true, false, null, "Brian42@gmail.com", "Brian35", "AQAAAAIAAYagAAAAEGbRxN+SLKEOE98ZlMlOSXOb+9AeYYrT4QWBgZRcs+l7Y+BQM3/tvGQVCvGp+cKKyw==", "352.212.3729", false, "00e09efb-4350-4b04-b6b9-598c53d40d0b", false, "Brian35" },
                    { "50919c4b-b718-4c01-93ad-adae4fbd2829", 0, "d829b6da-1128-4aa4-b063-b076b0324abb", "Corey_Metz78@yahoo.com", true, false, null, "Corey_Metz78@yahoo.com", "Corey.Metz49", "AQAAAAIAAYagAAAAEHp+droVGOeg1peI8EV3xBBp6a+fkd1KtXOGESESY096mD9xfMe/6m6hAv3jvrQOyQ==", "1-237-545-8855", false, "45bce110-a005-431b-b28b-1908cad5f014", false, "Corey.Metz49" },
                    { "53bc5d35-16bd-42f3-976d-f16a812efcd6", 0, "5343b1c4-b390-471e-8854-f1d5827a3041", "Valerie89@gmail.com", true, false, null, "Valerie89@gmail.com", "Valerie_Terry30", "AQAAAAIAAYagAAAAEBn0rMhG/FAQbEEs5xtUmZrxc2GJsJm9zBdgvnjdEJyN6aNAZw2uM8LB5zgsVf7OEA==", "1-207-955-1048", false, "aa6047ad-1257-4170-84d5-c563853ca470", false, "Valerie_Terry30" },
                    { "5c029293-77d7-417c-80e3-49214b66613a", 0, "a9976206-302b-42c4-aaf3-8bb02bc0b933", "Mona_Crona33@yahoo.com", false, false, null, "Mona_Crona33@yahoo.com", "Mona47", "AQAAAAIAAYagAAAAEL7r4auvS+ghjYQNOWjEpDWQYD0XjCcr0G6ZUMWxBXaMMaHbpmBpZw/HJT4o8zk57A==", "(875) 760-7116 x0402", false, "08e340cf-939e-47b6-99ae-900f90a505ca", false, "Mona47" },
                    { "5d4b280a-b92a-41a2-b175-926841d514e3", 0, "aab3d3b9-fd16-432a-8f03-6c23a30ef396", "Ben40@gmail.com", true, false, null, "Ben40@gmail.com", "Ben_Mayer", "AQAAAAIAAYagAAAAEGnn4OFrgqseZoG+wvEPShJfVxMDBHIja0Mwkbn+q3uU3L7X/z0XfeLh3FDFPv42iQ==", "570.268.4564", false, "f70f7705-318f-42da-8a65-5e3bc86d7580", false, "Ben_Mayer" },
                    { "66f723da-2bb3-4cf7-aaa1-ae4c551c2510", 0, "8714190f-17a2-4c31-bf8d-6b7508359852", "Roland_Wilderman@gmail.com", true, false, null, "Roland_Wilderman@gmail.com", "Roland51", "AQAAAAIAAYagAAAAEHsZf6MZlvY/QHx9BI9sKttpvd364kmfHSbgoR1ltdVTl/SQXur8ayB7Zis4FlFq7A==", "824-715-0658", false, "2431f472-8a2b-4545-9a25-f4fc1c7bee22", false, "Roland51" },
                    { "729c0c07-16b6-430f-bda0-00bdaa2d66dd", 0, "13de5a1d-a873-4565-a67a-e70ac82022a0", "Marilyn.Shanahan64@yahoo.com", true, false, null, "Marilyn.Shanahan64@yahoo.com", "Marilyn.Shanahan6", "AQAAAAIAAYagAAAAELS8o6gxyhGwsVjBmCrGL2KEEit5B8kY6qAJ+ZbSNVx7GWf7o7tTB6tFJfqCENQ3LQ==", "285.832.9221 x51063", false, "cf1014cd-8045-48f2-b960-e0178bce65a4", false, "Marilyn.Shanahan6" },
                    { "749ed646-fc54-4967-91b7-b7d5f7ced326", 0, "d701f856-fa73-45ad-8a12-8b80e934beed", "Emmett_Abshire67@hotmail.com", true, false, null, "Emmett_Abshire67@hotmail.com", "Emmett_Abshire27", "AQAAAAIAAYagAAAAEHmMp4V30EcOtyIKbLHxbWMWSukjkHftU77el1xoJcxUnDg4SRClAM3FngNkmbgMwQ==", "(469) 823-7896", false, "0ddcc2b0-cac3-4010-98dc-e58c4e806558", false, "Emmett_Abshire27" },
                    { "771fec70-c684-48fa-b01a-af0df12bb499", 0, "f99d3c43-7435-4888-b0cd-1ff996990f70", "Jenna88@yahoo.com", false, false, null, "Jenna88@yahoo.com", "Jenna_Weissnat", "AQAAAAIAAYagAAAAEGN/D+mHgvF4VEG3FXGTEOMP1YtA+4Sn2qEwpiolunbCSvTsWbmIeT3cN5m2ulYokw==", "1-491-314-4288 x1636", false, "b38e97a1-d5f5-410a-92c2-310c549ec121", false, "Jenna_Weissnat" },
                    { "7d4e1e1f-2508-4b8b-917e-de2f9f711bd6", 0, "99302083-ac7c-4efd-856f-59b20710a156", "Mona_MacGyver17@gmail.com", true, false, null, "Mona_MacGyver17@gmail.com", "Mona_MacGyver80", "AQAAAAIAAYagAAAAEAEfrSy5agCVCy9npy7dAI2ZvppJfyKXBGxIKQbOXG4trqtwUq6aJuypzZpzggGjUg==", "1-638-980-0147 x2598", false, "3b88d7f3-922f-4319-be90-656a77e42d61", false, "Mona_MacGyver80" },
                    { "7e491d2c-83b9-4f2f-a1b6-7c2b6638347c", 0, "f1f2f778-427b-42c0-8ce6-9f2632b1944e", "Christie0@hotmail.com", false, false, null, "Christie0@hotmail.com", "Christie57", "AQAAAAIAAYagAAAAEJksFoUFVFoh5+ELOh1lIaFOXXaa2vdwnlhv+nWG7h54GXEX1HmhqJuKIujSwBf9AA==", "303.762.8759", false, "6311e9ba-90da-4ebc-898e-9ab49080fa26", false, "Christie57" },
                    { "80067026-ddb0-4af9-8d1d-e7518b886f0e", 0, "ba3a9e90-2c0c-417d-986e-b4732dea868d", "Stuart4@gmail.com", false, false, null, "Stuart4@gmail.com", "Stuart_Goodwin", "AQAAAAIAAYagAAAAEA7QCyRdLZQuNdQ2GUhqi4x1ukczirMHTZXn22SnDupo7FZxTlhWgNtyOJcgCPQ++g==", "(243) 247-9001", false, "1f7d430f-676f-4d6a-b3e7-6960fc0ad0ec", false, "Stuart_Goodwin" },
                    { "869bee7d-7939-4714-9ece-0cf19ab61e55", 0, "f51f44a7-6966-4724-8e6e-36839cb16eac", "Patrick.Hegmann9@gmail.com", true, false, null, "Patrick.Hegmann9@gmail.com", "Patrick_Hegmann38", "AQAAAAIAAYagAAAAEMG0Tm2i1E/UUaYDqJQmiGsCxDcp22IEaeGp847X2wuz3gznNmc9G0R6yD29b9tUpQ==", "385.421.4709", false, "f96cacf9-6d6d-48b9-87ec-3b44c03e1f3f", false, "Patrick_Hegmann38" },
                    { "8db492f2-41e2-4c4a-bf16-1ec6914a9f31", 0, "de1eded0-1117-4bc7-a76a-7240b943c083", "Mindy_Reichel91@yahoo.com", false, false, null, "Mindy_Reichel91@yahoo.com", "Mindy_Reichel80", "AQAAAAIAAYagAAAAEMqE/+fKD9V1QCfJHrZqrcQ4+DpB1pAeo2r93NXqD2R9XcguhTrZOK1cw6dVAzj9qw==", "1-822-564-1961 x364", false, "2fbd01ea-653c-4ebd-b4bc-ba6865761c88", false, "Mindy_Reichel80" },
                    { "9661a0b7-521a-4a37-ac29-a815622bba7e", 0, "2fef3390-f35d-4039-8b75-060003a1e37c", "Lucy.Roob@gmail.com", true, false, null, "Lucy.Roob@gmail.com", "Lucy.Roob25", "AQAAAAIAAYagAAAAEFC2o81S5742YNu9QJrgFK5UMQKlWCV2gM9SBsqf2zW8SdFfd4eQL+FCB117o86U1A==", "1-557-592-4600", false, "90bf41c3-402d-4847-a431-ffa32403ec5b", false, "Lucy.Roob25" },
                    { "98a49c2f-7f00-4ffe-b662-4aa5478edf4e", 0, "96c3cb46-0a97-4ebe-82f0-82319279a583", "Rickey.Hahn@hotmail.com", false, false, null, "Rickey.Hahn@hotmail.com", "Rickey.Hahn", "AQAAAAIAAYagAAAAEEivTgiqq0w5jDxjTuSxBa6NL5diCPtLYGSDYGFbC3WWG1iT/XpnEPDdAx3wnGnbIw==", "738-364-5742 x924", false, "4cf3fe4f-f092-4a5c-8390-e5124884b43b", false, "Rickey.Hahn" },
                    { "99c235cb-ad9a-42bc-9cd3-5de45cec9e0a", 0, "03fb33b2-361e-4ce4-af24-f9497d440ec0", "Cassandra.Wintheiser@hotmail.com", false, false, null, "Cassandra.Wintheiser@hotmail.com", "Cassandra4", "AQAAAAIAAYagAAAAEF0hOSno2KbC0gn29+2F/lufnA+Saf60Hw5psxc2whfPgqHQ9b4JFXRSHdZc7mcFNA==", "(826) 378-4893", false, "7dafeefa-c14e-4362-b9ee-8be09b48240d", false, "Cassandra4" },
                    { "9c29891c-e778-456b-8170-f6a766703cce", 0, "fa88661f-7947-437a-8e27-0bb2737002a2", "Lowell_OReilly21@hotmail.com", false, false, null, "Lowell_OReilly21@hotmail.com", "Lowell.OReilly39", "AQAAAAIAAYagAAAAEFUESPB/ODlkNAjDHhTbyxXTIB5Vtcvzno1kVGnSeLiyShTJ9PnRJHMzObR9XahnzA==", "1-702-450-0273", false, "6373f2bf-f900-480e-84ff-3176265b5f4e", false, "Lowell.OReilly39" },
                    { "a034348a-53a5-4984-b67f-931ed176b6be", 0, "827d4605-c94f-42bc-b8dd-f419944b74a0", "Neal_Kutch7@gmail.com", true, false, null, "Neal_Kutch7@gmail.com", "Neal_Kutch15", "AQAAAAIAAYagAAAAEOUYcRWI79Rrdg478zTnqF9Qfh6y8WJjgoUTQhafXOpOROCcR9rJaDxehLFLYWR/TQ==", "861-795-9617 x1971", false, "87f106ce-234e-40eb-9bd4-2592d0ccd716", false, "Neal_Kutch15" },
                    { "a8ac468b-a5c5-473e-8870-a47d38ec96ba", 0, "56e78512-b0de-4555-a1ac-879ee8ec0a65", "Gerard.Flatley@hotmail.com", false, false, null, "Gerard.Flatley@hotmail.com", "Gerard.Flatley81", "AQAAAAIAAYagAAAAEPZjkFaT41+NVJ7/eb2iMW55/EMbTDLxv3NtQWP784II6sZkyATWCXq8cKemfERDYg==", "374.411.3378", false, "ca7c3ded-6ec1-4af5-b947-79c431dfb27d", false, "Gerard.Flatley81" },
                    { "afa245c3-f641-473b-9679-68c13fe0d673", 0, "cd298eaa-36fe-43b2-bfa9-d413c4a5773f", "Amber_Ledner26@yahoo.com", false, false, null, "Amber_Ledner26@yahoo.com", "Amber84", "AQAAAAIAAYagAAAAEGAgbwqLjS7diWQZQE5fhnMbTi5nRWZDLKXZOkj5JHtZLRxV5WUoJIOlJcI6jI/BLA==", "847.960.8658", false, "8f434eae-51ae-443c-8951-3858e4e5c154", false, "Amber84" },
                    { "b0c399b6-2cec-405b-bb0c-a4c1545b405f", 0, "2aa646e0-c4b0-4135-80b2-5f4230f3b238", "Constance73@gmail.com", false, false, null, "Constance73@gmail.com", "Constance_Oberbrunner", "AQAAAAIAAYagAAAAENMZ9bbgYh1B9yS8kqSOO8Hu4a8CvVdmVycv0TkM6mvFxSoNiAmtofa6QmgZcIneAg==", "971.690.0419 x599", false, "c4bdf826-1c56-423e-a85b-d409fd6c2a99", false, "Constance_Oberbrunner" },
                    { "b47ad753-b548-4443-82af-74e181d1a435", 0, "8a327046-d28b-4eb7-8401-164762b68908", "Gwendolyn.Ziemann@gmail.com", false, false, null, "Gwendolyn.Ziemann@gmail.com", "Gwendolyn.Ziemann", "AQAAAAIAAYagAAAAEIPEvP3YaNBLSn/pQKyx2a3uzKneky059lLTouqP17YXGhAbMQupPIZIg36LhoAToA==", "948.605.7727 x8321", false, "5735ba27-9044-4b6e-b5dc-1ca25a75c7e8", false, "Gwendolyn.Ziemann" },
                    { "c82746fb-d59a-4a7e-9359-1a1055fda027", 0, "3c781692-24bd-48bd-b90b-92d8b661bbeb", "Louis.Koepp@yahoo.com", false, false, null, "Louis.Koepp@yahoo.com", "Louis5", "AQAAAAIAAYagAAAAELy9OOO/bUlSxPqybFUMiUatwmQSyHLGCGDBpwdgpIiErMnNuBJwgBITZplwE0n7uw==", "518-872-9131 x6696", false, "12f4343f-f9b0-421a-b2b7-11be2ee86532", false, "Louis5" },
                    { "cb5c6f2d-f682-40a6-9a65-0988384ad0fa", 0, "30da6c5e-40d8-48ab-850a-7ef6f6ac2e68", "Willis57@hotmail.com", false, false, null, "Willis57@hotmail.com", "Willis_Franecki65", "AQAAAAIAAYagAAAAEAONlJO+GgoWvTJVCXPSDPlBHFxe1ajYcLGuKs5gq+kt10P70fJ707zaSmp6kSqtRQ==", "(910) 509-9886", false, "2c91951d-c3f9-4fa2-b959-c70affbc4e87", false, "Willis_Franecki65" },
                    { "ce3a7404-4c2d-4ce6-980e-7bdef390804c", 0, "e64814de-3577-4d51-bd53-3b39a9d6a484", "Otis.McCullough52@gmail.com", false, false, null, "Otis.McCullough52@gmail.com", "Otis35", "AQAAAAIAAYagAAAAENCKr5jtZ+PakDUlsoSQoadi1OhyWRxte3/F9UWSV3envjg+z08n3T5B02RQqBxK5Q==", "1-250-964-8929 x215", false, "f24600fb-53ea-4336-ba55-ef722acffdc6", false, "Otis35" },
                    { "da770414-f54d-4607-8eae-f86d7db0ab1f", 0, "23ecb868-6690-4ea9-86cc-a0c73e9fe90b", "Lucille.Brown@yahoo.com", true, false, null, "Lucille.Brown@yahoo.com", "Lucille75", "AQAAAAIAAYagAAAAEP4y3DMjqh9qpyUC5OBaE41UqudJTqkJyG06HI1jgYy6JgY0iIPk6QITUK6CZQfa9A==", "(309) 689-1657 x483", false, "6039fcfb-e858-4b6a-8c6b-1009e062956c", false, "Lucille75" },
                    { "ed79435a-d803-485e-b356-00d688b05711", 0, "fe76588d-5715-48f7-b999-e35a3704d8a3", "Alma_Ondricka@hotmail.com", true, false, null, "Alma_Ondricka@hotmail.com", "Alma_Ondricka", "AQAAAAIAAYagAAAAEIQbyJjZemj4Fg/DYK/am/AnpOjPdiJPXQI2uOWyYfpkSISqoLpWJurBdqVZKG/oFA==", "(990) 885-8222 x25367", false, "b0a73872-30a0-4eaa-84d3-f2f791dfb68f", false, "Alma_Ondricka" },
                    { "fa586caa-f01d-4a97-a615-f261b14315ab", 0, "ff232099-d63d-41b4-a269-efd0bd7dbe0e", "Linda86@gmail.com", false, false, null, "Linda86@gmail.com", "Linda.Zboncak", "AQAAAAIAAYagAAAAEEGeYgUdws9nspZ7ZWJTiBPtF2noekd5QY4LfGc4MRqrp5ptVBSnA0mz99i9tW93Dw==", "553.203.5959", false, "0b7c78ec-572a-4682-91a7-3f9e7ac4c54f", false, "Linda.Zboncak" },
                    { "ff2f9e32-01e7-4320-96f2-ef79b3cd4e64", 0, "8c56d190-db3e-4615-ae76-2fd791007f8d", "Lora_Kub57@gmail.com", true, false, null, "Lora_Kub57@gmail.com", "Lora29", "AQAAAAIAAYagAAAAEGw34KtHpNmmUzE2sO+HFKj9AxOKoFiBygFvrkTFsCjDE4TTaRvqq4jPs5oNVD90Kg==", "(626) 563-3612", false, "d4b6ac9e-e985-4eaa-be5d-ee6902e63261", false, "Lora29" }
                });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "Bs", "Name", "Suffix" },
                values: new object[,]
                {
                    { new Guid("0005ac62-ec76-4c6c-a7a5-20d6c4af1264"), "reinvent dot-com initiatives", "King Group", "Group" },
                    { new Guid("06363b88-eb35-444a-946e-4007c0141075"), "expedite user-centric channels", "Schinner Group", "Inc" },
                    { new Guid("0c52669c-a778-43bf-a40f-5698d9327712"), "syndicate robust e-commerce", "Legros - Spinka", "Inc" },
                    { new Guid("10cb65ba-6039-4aee-b099-ae799780c000"), "synergize front-end action-items", "Hansen Group", "and Sons" },
                    { new Guid("13cd6ac6-cce2-418a-9181-2227ecb607b6"), "leverage turn-key communities", "Gerhold, Blanda and Ullrich", "Inc" },
                    { new Guid("2c109327-8695-4233-b2ce-aad48fa428e9"), "seize real-time convergence", "Herzog - Gleason", "and Sons" },
                    { new Guid("37562fb7-1d1c-44f8-bdbe-044133cae10c"), "reintermediate integrated niches", "Maggio, Bailey and Douglas", "Inc" },
                    { new Guid("4bab129c-e7fd-4214-adfa-0bb549aa09ca"), "engineer extensible e-tailers", "Denesik, Oberbrunner and Parisian", "Group" },
                    { new Guid("742a09b2-f254-44fc-bf4e-b6b464308e94"), "grow rich e-business", "Rolfson - Labadie", "and Sons" },
                    { new Guid("7dd707df-fcd6-4c50-8116-c22a666f04eb"), "visualize magnetic convergence", "Weimann - Denesik", "Inc" },
                    { new Guid("89e00611-4aae-4689-8ee4-9dd58059b636"), "aggregate extensible technologies", "Ryan and Sons", "LLC" },
                    { new Guid("8ee441ae-d336-482a-9d4c-5e0bfb0038f3"), "scale bleeding-edge e-commerce", "Farrell and Sons", "LLC" },
                    { new Guid("9b295390-cc66-47cb-a0f0-dcc7a391f14b"), "expedite B2B web-readiness", "Purdy LLC", "Group" },
                    { new Guid("a7ed86d8-b32c-42a1-9225-d5caf72c3477"), "unleash bleeding-edge platforms", "Wiza - Wilkinson", "Group" },
                    { new Guid("af89f838-610b-4587-9561-653360051516"), "syndicate strategic technologies", "Mohr - Hermiston", "Group" },
                    { new Guid("c2e7066b-bd14-4488-8e3b-f3e46d34eb6b"), "orchestrate 24/365 mindshare", "Howe - Bosco", "Group" },
                    { new Guid("db54eec3-bc25-4263-ab40-d37a824a5406"), "morph sticky e-tailers", "Schmeler Inc", "and Sons" },
                    { new Guid("def6488a-8079-4932-8ecc-f538d88eb525"), "productize bricks-and-clicks e-tailers", "Effertz - Crooks", "Group" },
                    { new Guid("e8bb66b0-8399-45a3-a9af-9b17b15326a6"), "harness cross-platform architectures", "Mosciski, Heidenreich and Nitzsche", "Group" },
                    { new Guid("e9396b22-6fae-44ed-b0c4-061556b4dca7"), "aggregate best-of-breed methodologies", "Hettinger, Rau and Balistreri", "LLC" },
                    { new Guid("fd27ae5b-c296-4105-b234-8922f914352a"), "deploy B2B experiences", "Trantow Group", "LLC" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("00fbd02a-4fbb-497d-bf22-1866a6001571"), "The Football Is Good For Training And Recreational Purposes", "Incredible Rubber Pants", "71.79" },
                    { new Guid("054e3bd6-1188-43e1-a310-b04ed2eeaffa"), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Small Cotton Ball", "695.47" },
                    { new Guid("065989c2-2c83-44c6-bc9c-8ce323ff6305"), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Unbranded Granite Soap", "139.25" },
                    { new Guid("0922dc50-5685-42d3-9be3-7418bdb0d305"), "The Football Is Good For Training And Recreational Purposes", "Practical Concrete Pants", "445.14" },
                    { new Guid("0c5a7620-c074-430c-8aad-79c7cd1316ff"), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Ergonomic Frozen Gloves", "302.46" },
                    { new Guid("13715d71-e752-4a1d-b3ef-c841da245c82"), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Awesome Metal Pants", "522.29" },
                    { new Guid("14316a8d-5b82-4a9a-ba53-10035de9d6da"), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Fantastic Steel Soap", "715.94" },
                    { new Guid("16c605af-d9b3-4dac-8d48-e9d11708832e"), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Tasty Cotton Bike", "324.00" },
                    { new Guid("1dd89a96-5095-4ad1-8ee7-b11fa2b6f8bf"), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Rustic Steel Tuna", "228.92" },
                    { new Guid("2021e627-a5df-45e7-9581-cc50794b418b"), "The Football Is Good For Training And Recreational Purposes", "Licensed Granite Soap", "5.63" },
                    { new Guid("213955d2-5226-437c-af62-6a924daec254"), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Ergonomic Plastic Table", "230.15" },
                    { new Guid("2c7fcdfe-6798-4e14-a1ae-9f4afe0d7f8d"), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Incredible Plastic Shirt", "718.71" },
                    { new Guid("2d96c767-f493-4823-86eb-d3f5a884b027"), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Sleek Steel Fish", "735.23" },
                    { new Guid("2e380a94-f475-426e-a7ba-f0115f7ad169"), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Practical Granite Keyboard", "910.42" },
                    { new Guid("346327f7-74ab-467a-8ec8-9a0f5c06b79e"), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Practical Metal Soap", "914.93" },
                    { new Guid("34a91772-6178-4a4b-8e09-631b4640c42c"), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Gorgeous Wooden Pizza", "826.23" },
                    { new Guid("3537d4e6-41b7-49a9-bf32-f4303f375899"), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Fantastic Granite Table", "145.12" },
                    { new Guid("38197929-95a2-4330-8eae-d0be55db8674"), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Small Plastic Tuna", "550.91" },
                    { new Guid("39ebdac8-6ec2-4513-bc8e-594902a6376c"), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Gorgeous Metal Tuna", "431.87" },
                    { new Guid("3a1ee551-4d6d-40da-9804-e71d8d6145f3"), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Rustic Rubber Gloves", "129.62" },
                    { new Guid("3c47997e-b3cf-4315-ba6d-4ef1b94ebbf2"), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Handmade Cotton Towels", "137.00" },
                    { new Guid("420dc1ef-791d-4343-9384-795bb5e57716"), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Ergonomic Soft Computer", "559.86" },
                    { new Guid("42594479-a253-4938-8e52-b41c7dc0aee3"), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Practical Metal Chicken", "902.10" },
                    { new Guid("5143326f-fd59-44ee-950f-b8165cf3b20d"), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Refined Cotton Shirt", "798.29" },
                    { new Guid("5568712a-b84c-4770-aebe-d542d3564d9c"), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Licensed Steel Pants", "888.95" },
                    { new Guid("5a8a04f1-305a-4794-ba78-f98045e1dd79"), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Small Fresh Ball", "915.36" },
                    { new Guid("5cbe5565-364e-4d14-ba07-1cdcb652c599"), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Practical Fresh Pants", "534.22" },
                    { new Guid("6207352a-b6c5-4cf9-a806-887ba72757f3"), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Ergonomic Wooden Bike", "737.17" },
                    { new Guid("65a66fa1-3095-4953-a828-91a231f01cdc"), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Tasty Concrete Fish", "903.40" },
                    { new Guid("692680e0-56d3-48c4-910d-464750f5258e"), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Licensed Plastic Cheese", "891.02" },
                    { new Guid("6e6661e8-b288-47ce-a68d-385b5b02d3ad"), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Generic Cotton Table", "103.05" },
                    { new Guid("7783edd9-032d-457f-93c9-466e95ac833f"), "The Football Is Good For Training And Recreational Purposes", "Gorgeous Rubber Sausages", "144.14" },
                    { new Guid("7df2ef32-ac05-494d-94a3-a041d492fbd5"), "The Football Is Good For Training And Recreational Purposes", "Sleek Frozen Computer", "862.57" },
                    { new Guid("7ff711a9-c4eb-4e9d-9033-a1232d4bf229"), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Unbranded Concrete Tuna", "639.21" },
                    { new Guid("8824caf9-4069-406b-af3e-654987b84592"), "The Football Is Good For Training And Recreational Purposes", "Handmade Metal Soap", "952.53" },
                    { new Guid("8c66e32b-ca19-458d-89ca-c7bb181f742d"), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Awesome Steel Chicken", "512.24" },
                    { new Guid("8d101a7c-73ba-46e3-9b37-0df065bb46fc"), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Small Granite Salad", "779.75" },
                    { new Guid("8f7161ae-b5c9-42d6-a47f-e927464cb09b"), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Small Granite Cheese", "962.08" },
                    { new Guid("91397497-4fd9-45ba-9678-a263c56602a0"), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Incredible Soft Table", "240.11" },
                    { new Guid("9c38cc7e-ece2-4984-9899-c595c7f36c0d"), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Tasty Granite Shoes", "944.28" },
                    { new Guid("a262d790-435f-411d-85b9-5b55e32c3166"), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Unbranded Cotton Salad", "799.94" },
                    { new Guid("a7be2b9d-13c8-4ba2-8a50-03bd9c4ad79c"), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Unbranded Frozen Gloves", "127.67" },
                    { new Guid("b0e2d64f-e8d4-47db-bb56-64e023bc9abe"), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Practical Frozen Keyboard", "977.47" },
                    { new Guid("b52d919b-6989-478a-b0a6-4539d3f3e3aa"), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Ergonomic Metal Pants", "780.08" },
                    { new Guid("b69a103b-7aeb-46d5-992b-8a4ae53ff28c"), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Gorgeous Plastic Shoes", "468.97" },
                    { new Guid("bd3dd525-e7af-4212-9670-c1a426715f90"), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Unbranded Soft Chips", "796.69" },
                    { new Guid("c45d1142-c080-4ecb-a585-514a11012ed9"), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Awesome Soft Table", "799.25" },
                    { new Guid("c4a3fb45-f73f-4193-9af8-af0a8dba64e0"), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Handcrafted Plastic Computer", "235.86" },
                    { new Guid("c9e57ef2-180b-4a1c-b27d-9fce130bdbe5"), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Incredible Plastic Chips", "298.22" },
                    { new Guid("ca3bbc11-d28c-450e-aea9-413196a599d3"), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Small Wooden Mouse", "788.18" },
                    { new Guid("cf559f04-f1ef-4b90-bd80-2553662bb976"), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Sleek Concrete Bike", "825.59" },
                    { new Guid("d77dc33a-96d3-4b86-86b8-2652243d20b3"), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Refined Concrete Shirt", "681.50" },
                    { new Guid("da65d446-338a-49fd-a671-1eb49fb27935"), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Tasty Plastic Pants", "115.92" },
                    { new Guid("dce1d608-d7c4-437a-aea8-cdb47e47754d"), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Licensed Concrete Sausages", "787.00" },
                    { new Guid("df3f76b4-47d6-489b-898f-47b1850bc7ac"), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Practical Metal Ball", "661.92" },
                    { new Guid("e3dc79f4-8b50-4fa8-981c-05115801dfb5"), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Fantastic Concrete Pizza", "39.01" },
                    { new Guid("e49185a5-2636-4a47-9cfa-4e88a879f25b"), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Incredible Soft Bike", "724.72" },
                    { new Guid("e86ac9a9-b04f-4d66-a94b-2aa8f0eb3895"), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Licensed Frozen Mouse", "531.75" },
                    { new Guid("e93a4f0d-d637-46a4-9078-720d694bc3d0"), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Unbranded Frozen Towels", "164.67" },
                    { new Guid("ea09e31b-2c55-4387-a7e6-1d510b253795"), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Awesome Plastic Fish", "423.70" },
                    { new Guid("f39da67c-2f56-4c14-9122-e6f3a96683f3"), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Gorgeous Wooden Keyboard", "120.69" },
                    { new Guid("f41e3bb8-d2b4-477d-9464-7fc1ce042383"), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Unbranded Wooden Keyboard", "798.83" },
                    { new Guid("f5c6debd-bce7-438c-89a4-12865fd27fb6"), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Handcrafted Steel Soap", "838.92" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "f2039480-8d48-4a8b-b285-82dc21d05afd", "03af4b0b-d274-463f-af0e-29c388cba752" },
                    { "f2039480-8d48-4a8b-b285-82dc21d05afd", "13f3f2f3-f94b-4da7-871a-2f23aecfa049" },
                    { "f2039480-8d48-4a8b-b285-82dc21d05afd", "157466a3-3b0d-4ef6-87b9-ad177a1c2553" },
                    { "f2039480-8d48-4a8b-b285-82dc21d05afd", "1b18f38a-132c-4f71-a9ea-caa9d74527f6" },
                    { "98483377-3d9a-473a-bfaa-b930dcce1485", "2338290f-6fc5-4290-80b3-3ec3d88f980c" },
                    { "f2039480-8d48-4a8b-b285-82dc21d05afd", "251ff7b7-36b3-47f1-a3c2-bc12579c36eb" },
                    { "f2039480-8d48-4a8b-b285-82dc21d05afd", "29aae9f3-48c4-4f68-8158-f5abff186b2d" },
                    { "98483377-3d9a-473a-bfaa-b930dcce1485", "2c2d4fa6-850a-4d51-bc66-5523fef76ea7" },
                    { "f2039480-8d48-4a8b-b285-82dc21d05afd", "2ebf2ded-7a1f-4025-b6e1-47b262dba3e1" },
                    { "f2039480-8d48-4a8b-b285-82dc21d05afd", "33654742-d30d-40aa-ba66-f5ac850af53b" },
                    { "98483377-3d9a-473a-bfaa-b930dcce1485", "36137695-fef0-4980-b1bf-aac525d02552" },
                    { "98483377-3d9a-473a-bfaa-b930dcce1485", "3c54393d-c022-4e4b-ad29-607d2e6440e5" },
                    { "98483377-3d9a-473a-bfaa-b930dcce1485", "44bc0339-1ab4-49d0-8bf5-8b53b428fa41" },
                    { "f2039480-8d48-4a8b-b285-82dc21d05afd", "45d59834-ca32-47f2-a34b-38e9cbff636f" },
                    { "98483377-3d9a-473a-bfaa-b930dcce1485", "482f9857-d50f-4b8a-8317-4b7a8dfea6e7" },
                    { "98483377-3d9a-473a-bfaa-b930dcce1485", "4b414ac5-1a72-400d-94dc-4d844ae494e2" },
                    { "98483377-3d9a-473a-bfaa-b930dcce1485", "4b814b0e-4209-43c6-ba54-8c7b1f3bb5b2" },
                    { "98483377-3d9a-473a-bfaa-b930dcce1485", "50919c4b-b718-4c01-93ad-adae4fbd2829" },
                    { "f2039480-8d48-4a8b-b285-82dc21d05afd", "53bc5d35-16bd-42f3-976d-f16a812efcd6" },
                    { "98483377-3d9a-473a-bfaa-b930dcce1485", "5c029293-77d7-417c-80e3-49214b66613a" },
                    { "f2039480-8d48-4a8b-b285-82dc21d05afd", "5d4b280a-b92a-41a2-b175-926841d514e3" },
                    { "f2039480-8d48-4a8b-b285-82dc21d05afd", "66f723da-2bb3-4cf7-aaa1-ae4c551c2510" },
                    { "f2039480-8d48-4a8b-b285-82dc21d05afd", "729c0c07-16b6-430f-bda0-00bdaa2d66dd" },
                    { "98483377-3d9a-473a-bfaa-b930dcce1485", "749ed646-fc54-4967-91b7-b7d5f7ced326" },
                    { "98483377-3d9a-473a-bfaa-b930dcce1485", "771fec70-c684-48fa-b01a-af0df12bb499" },
                    { "f2039480-8d48-4a8b-b285-82dc21d05afd", "7d4e1e1f-2508-4b8b-917e-de2f9f711bd6" },
                    { "98483377-3d9a-473a-bfaa-b930dcce1485", "7e491d2c-83b9-4f2f-a1b6-7c2b6638347c" },
                    { "f2039480-8d48-4a8b-b285-82dc21d05afd", "80067026-ddb0-4af9-8d1d-e7518b886f0e" },
                    { "98483377-3d9a-473a-bfaa-b930dcce1485", "869bee7d-7939-4714-9ece-0cf19ab61e55" },
                    { "98483377-3d9a-473a-bfaa-b930dcce1485", "8db492f2-41e2-4c4a-bf16-1ec6914a9f31" },
                    { "f2039480-8d48-4a8b-b285-82dc21d05afd", "9661a0b7-521a-4a37-ac29-a815622bba7e" },
                    { "f2039480-8d48-4a8b-b285-82dc21d05afd", "98a49c2f-7f00-4ffe-b662-4aa5478edf4e" },
                    { "f2039480-8d48-4a8b-b285-82dc21d05afd", "99c235cb-ad9a-42bc-9cd3-5de45cec9e0a" },
                    { "98483377-3d9a-473a-bfaa-b930dcce1485", "9c29891c-e778-456b-8170-f6a766703cce" },
                    { "98483377-3d9a-473a-bfaa-b930dcce1485", "a034348a-53a5-4984-b67f-931ed176b6be" },
                    { "f2039480-8d48-4a8b-b285-82dc21d05afd", "a8ac468b-a5c5-473e-8870-a47d38ec96ba" },
                    { "98483377-3d9a-473a-bfaa-b930dcce1485", "afa245c3-f641-473b-9679-68c13fe0d673" },
                    { "98483377-3d9a-473a-bfaa-b930dcce1485", "b0c399b6-2cec-405b-bb0c-a4c1545b405f" },
                    { "98483377-3d9a-473a-bfaa-b930dcce1485", "b47ad753-b548-4443-82af-74e181d1a435" },
                    { "f2039480-8d48-4a8b-b285-82dc21d05afd", "c82746fb-d59a-4a7e-9359-1a1055fda027" },
                    { "98483377-3d9a-473a-bfaa-b930dcce1485", "cb5c6f2d-f682-40a6-9a65-0988384ad0fa" },
                    { "98483377-3d9a-473a-bfaa-b930dcce1485", "ce3a7404-4c2d-4ce6-980e-7bdef390804c" },
                    { "98483377-3d9a-473a-bfaa-b930dcce1485", "da770414-f54d-4607-8eae-f86d7db0ab1f" },
                    { "98483377-3d9a-473a-bfaa-b930dcce1485", "ed79435a-d803-485e-b356-00d688b05711" },
                    { "98483377-3d9a-473a-bfaa-b930dcce1485", "fa586caa-f01d-4a97-a615-f261b14315ab" },
                    { "98483377-3d9a-473a-bfaa-b930dcce1485", "ff2f9e32-01e7-4320-96f2-ef79b3cd4e64" }
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
