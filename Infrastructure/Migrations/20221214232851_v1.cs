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
                    { "276af310-41ad-46ca-84b0-90fcfa1833fa", null, "Normal", "NORMAL" },
                    { "3b5ddb63-bdb1-448d-93ce-6f1475b8316f", null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "026fac15-1476-4b34-9b63-e75bb465f7b0", 0, "a50849d7-689f-4c57-8b36-a40776ce2ff0", "Admin_Rachael.Stamm8@hotmail.com", true, false, null, "rachael.stamm8@hotmail.com", "RACHAEL_STAMM8", "AQAAAAIAAYagAAAAEBdTw/+fKzUTk6TXzdrv9+opBNQyWNaf/BShdp01nz9RHrLYKZMlIwd2KO7B+6ACYg==", "1-891-486-2974", true, "e8a94b4e-5c95-46b7-9f88-32bf58c568de", true, "Rachael_Stamm8" },
                    { "07ceab4a-96e4-4a12-94c1-8ddc05efb1a6", 0, "6a0a8525-d17e-44b9-9fb9-8b6638c79bde", "Normal_Natalie22@yahoo.com", false, false, null, "natalie22@yahoo.com", "NATALIE.WARD93", "AQAAAAIAAYagAAAAEEQ5VMXfp6ZodsGmki4AZ1oD3yaiFp8CNwfMoS6B76WeqvIPJKN+QYbqf8VTPzD4ag==", "460.423.8641 x15144", false, "70fa813e-fca8-4c48-8446-f8310393dce4", false, "Natalie.Ward93" },
                    { "1d2bb238-c5a3-4966-83f9-4103153aa849", 0, "312fee71-b51a-4d6b-937d-565c3e1ba4bd", "Normal_Harriet_Mitchell18@gmail.com", false, false, null, "harriet_mitchell18@gmail.com", "HARRIET_MITCHELL", "AQAAAAIAAYagAAAAEBecDOoagV4eRpMkQ+14/8dCqYhBEIA3w/WU9CylZNK3iJ/ir0477f6qyesBeDdVPw==", "556.434.8767 x211", false, "3753d9f8-5f20-41ef-bf17-3e1885a7bf1c", false, "Harriet_Mitchell" },
                    { "20d9d315-549c-4e8f-8a37-bf0eee6d7796", 0, "e19b40fa-326b-4d77-b9e6-f78a9937447d", "Normal_Anthony9@yahoo.com", false, false, null, "anthony9@yahoo.com", "ANTHONY_PFANNERSTILL81", "AQAAAAIAAYagAAAAENhM4Uw2wwleVAtrbH2OcfBbUxaL0VR142D9CEZHRqzVA36erl5/HmdthfwnCbmfYg==", "(707) 770-0405 x275", false, "d88d0bad-e528-4e47-875f-317f6644183e", false, "Anthony_Pfannerstill81" },
                    { "2538d62c-7e4a-4682-9fa7-3559198d91a6", 0, "4c9283b3-ede0-4839-8065-b978741688f6", "Admin_Guillermo_Goodwin99@yahoo.com", false, false, null, "guillermo_goodwin99@yahoo.com", "GUILLERMO_GOODWIN71", "AQAAAAIAAYagAAAAEFXtePlCVKGamq4BXpbXlJ169GU7RXt94ufBTXMKQINfNkPmh70NR5Q0MkDJiUJs/Q==", "(563) 205-8011 x5682", true, "f05dee61-f189-4803-9be6-4424bf748b85", true, "Guillermo_Goodwin71" },
                    { "265bbb85-edfc-4c43-af1f-5e09164c732f", 0, "22fcd827-c3ed-4355-8f51-9c872be00622", "Normal_Norman.Carter@gmail.com", false, false, null, "norman.carter@gmail.com", "NORMAN_CARTER", "AQAAAAIAAYagAAAAEDv377AZVHuQQjv5uIJrLmV1aaxGoxho9LEB3NPLZGx7pM3sRxS0NM8UemsiEbE6vA==", "1-216-262-6871 x593", true, "8c11c02e-5fd7-450e-ba59-553950442b57", true, "Norman_Carter" },
                    { "2f16574a-e3e5-4783-a754-e0b222daf251", 0, "b29d303c-0d19-4a69-a6ad-d2f78c9a0f0b", "Normal_Jane3@yahoo.com", true, false, null, "jane3@yahoo.com", "JANE5", "AQAAAAIAAYagAAAAEIK94Z3dZ0dh/dyUFrkeYj++SUHuez7cV9nMLrmM76QF1jVb/x4cuhYGLPMQtNfqng==", "598-213-5690", false, "035145c6-bfbc-4a81-a758-9fa2c023a145", true, "Jane5" },
                    { "513f83a8-378e-44c8-9519-24dfa658f140", 0, "7bccff85-350e-42db-ac26-0442546e7167", "Admin_Lamar32@yahoo.com", false, false, null, "lamar32@yahoo.com", "LAMAR.MARVIN", "AQAAAAIAAYagAAAAECzLSLRrbtjs3oNHBNmC5ohORFnloe6dwOKHlSaopSV/Fvhd2Q9uCwHGa0xVi4zhzQ==", "333.450.6704 x384", false, "bbd2bf85-86cc-43c4-a696-b09043fc1e9c", true, "Lamar.Marvin" },
                    { "5760c2b7-4d08-4792-a168-933fa1c17a62", 0, "0bd1db5e-e787-44c5-beaf-a357c5c111b0", "Normal_Maggie18@hotmail.com", true, false, null, "maggie18@hotmail.com", "MAGGIE_PARISIAN43", "AQAAAAIAAYagAAAAENyGdspN/cVqRoUCCamtjHpCgIG5pTKcQm/3/DPvZ9V5pU3Y5swuFEAu8HISmaxysQ==", "433.345.6215 x823", true, "d96d0218-0b76-4a5c-86cb-3fdf32e91fb9", false, "Maggie_Parisian43" },
                    { "5d965f98-58de-4db8-b1b2-95bd11fc7869", 0, "b4b98dd7-d10d-46f7-bf03-0d7bf964f0b6", "Admin_Maggie.Daugherty15@yahoo.com", true, false, null, "maggie.daugherty15@yahoo.com", "MAGGIE_DAUGHERTY", "AQAAAAIAAYagAAAAEPZpu1WnMHMGn5kFaF+ozZep+5zP40WOENA5iMk6ZvqUdpyqzN+98GdLLIzzv9mZFg==", "1-545-332-6406", true, "16e8d832-0585-4ad6-82c9-a5ded0348fcb", false, "Maggie_Daugherty" },
                    { "67ef2581-1b4f-4abd-8b62-8e1a11849022", 0, "883a4c81-84a6-4157-8562-b8a703c70858", "Admin_Gretchen57@gmail.com", true, false, null, "gretchen57@gmail.com", "GRETCHEN.VOLKMAN", "AQAAAAIAAYagAAAAEIcMxtEveNb1E2rYI37n79OUGX5GH/aHZtJ/KJNV/OwihFaXxwPXcBZNfoxGULoqbg==", "(358) 399-4011 x769", false, "217e601c-ef96-463a-a209-7974c8a7adf3", false, "Gretchen.Volkman" },
                    { "70784095-2f30-4f1c-a756-bec5dee1e8fc", 0, "74f8c0a8-413c-4a65-8a75-91062b5179e0", "Normal_Amy.Feil80@yahoo.com", true, false, null, "amy.feil80@yahoo.com", "AMY29", "AQAAAAIAAYagAAAAEBiXQ4fXUBwEHLpK0BgTZqs0lINE/4CiCIlsMYCt3Zzwou/9g8k2RY/p1WzRJwz7aw==", "(783) 559-0706 x563", false, "b8b9b82d-0fdf-4530-991e-28e5ac900603", true, "Amy29" },
                    { "75f0ab6f-1706-492a-9c73-247a84822fb2", 0, "2cad90ba-173a-4777-ac78-26a53a0198e9", "Normal_Orville_Rogahn94@yahoo.com", false, false, null, "orville_rogahn94@yahoo.com", "ORVILLE_ROGAHN", "AQAAAAIAAYagAAAAEOs8URblW0NB2r6X6DcvQ/WrKYmD4Fhy+v3LJ3rjyTGG5PWinrcd350LS8NKNhuwRw==", "(678) 376-0073", false, "2a2d0034-cda5-454f-88fd-7a3fb75c0f3e", false, "Orville_Rogahn" },
                    { "79b2ebc7-9531-49f8-a6cd-4eb9c1c45812", 0, "3a0958e2-e9ec-4e11-93a3-85fdc5037fe4", "Admin_Gregory.Casper73@hotmail.com", false, false, null, "gregory.casper73@hotmail.com", "GREGORY56", "AQAAAAIAAYagAAAAEA3stlTjJRBv75/SkaFxM/Z0QhabagNXcbT3feb0GUH9JKdoHMrEzBjURUPQ8zXO6Q==", "1-943-600-3860 x9662", true, "dff6a9b4-af17-4e87-9a5d-7c1f7a9f9843", true, "Gregory56" },
                    { "7ae1c839-292e-4ac4-90fa-3f260007d657", 0, "5cbeede1-f96c-4e18-90ec-9cb6ffdca3d0", "Admin_Franklin_Konopelski42@yahoo.com", false, false, null, "franklin_konopelski42@yahoo.com", "FRANKLIN.KONOPELSKI67", "AQAAAAIAAYagAAAAEMpCfwAhuevmwjyVBXg9DYjSK1tuKXCRVtFXvmFhbzhnIRgTOV0cYDei5sIPG0rpog==", "(412) 535-2446", false, "49484cd1-b3f8-4ffe-8e82-f4d20eaa727c", false, "Franklin.Konopelski67" },
                    { "7d846a21-8b45-43e9-b481-3f374a4ea020", 0, "ff0a4aee-1bc3-4bcf-b01e-25b84215d822", "Normal_Jenny.Ebert@yahoo.com", false, false, null, "jenny.ebert@yahoo.com", "JENNY.EBERT76", "AQAAAAIAAYagAAAAEIU/S1et0W2SFPJ6m3ruAn+Kjkegd1y0DVDiGQhj/zSq0Z4TeV8Iw4jmOmuGkWNgqg==", "1-915-887-5076 x677", false, "d5a64594-266b-4bb0-b5cd-ea33afead20e", true, "Jenny.Ebert76" },
                    { "7dec286b-b6c5-415c-95c8-38e616b2e8ab", 0, "8e6ba492-1edd-4aa4-992d-42170194bac2", "Normal_Lois.Watsica@gmail.com", true, false, null, "lois.watsica@gmail.com", "LOIS_WATSICA", "AQAAAAIAAYagAAAAED305AJ40nul4C6dt8xIgLnW97p8anRqtTnuUnlTJS8N6fDEcdk6kJcy4MBvSdcX+w==", "(890) 498-8862", false, "0840cb91-a14b-4bc2-be39-68fddc74788c", false, "Lois_Watsica" },
                    { "7e67b05b-7915-4b5a-918d-8b991b0a755d", 0, "756e5edc-3b21-45dc-920e-78364dbc7ad2", "Normal_Eileen_Strosin@hotmail.com", false, false, null, "eileen_strosin@hotmail.com", "EILEEN37", "AQAAAAIAAYagAAAAEDggOiXYXcuxbRJwomScZqybb89HQxjt59FjIDKvNFBxs0ygD/WVwG7HkevTnsLOIg==", "961-297-2334 x43624", true, "65d40f03-58a5-4e33-890a-2b6a309faf59", false, "Eileen37" },
                    { "829e7bdf-5df1-4c3c-b4fd-bddfbfe52783", 0, "d011326f-9d6b-4398-9343-922e6815a401", "Admin_Rick.Ratke@yahoo.com", false, false, null, "rick.ratke@yahoo.com", "RICK.RATKE", "AQAAAAIAAYagAAAAEArFJAaSnP1HJ9fmB/KoA8q2ikUFIH5br8rMchl1TQTuxuZFr7Pcc0NnYLq7fJ82Fw==", "889-680-2591 x076", true, "8c5a1fae-dfc3-4e13-910a-e72b178f1dce", true, "Rick.Ratke" },
                    { "8829499e-b67e-425f-bda0-6b9964a759da", 0, "659cac61-6996-4369-802a-4f6f6f33b893", "Admin_Tammy.Barrows91@hotmail.com", true, false, null, "tammy.barrows91@hotmail.com", "TAMMY42", "AQAAAAIAAYagAAAAEBhQa6JaPbd39DBAaCm/2ApJ4aGtTu6+P+RordrjGGQUW1Id9hXY/kC6KWVH6U/DNg==", "643.552.6704 x613", true, "be7b9775-2b97-4e12-8b3e-30f45b61b35c", true, "Tammy42" },
                    { "8dd949fa-d27e-4b3e-be40-b284a6c33327", 0, "2a2a6ae1-3715-4297-99c6-22c7002452dd", "Normal_Horace_Lang@hotmail.com", true, false, null, "horace_lang@hotmail.com", "HORACE_LANG", "AQAAAAIAAYagAAAAEL338igNY+T44R8raVEM/3M6mKgKXuXDNAYlUzDkwIdqQ8VMKFc8f9IY0Ka2QqB4uQ==", "1-639-432-1970 x9040", true, "39dface7-6722-4a6f-8c8a-e02640760a44", false, "Horace_Lang" },
                    { "967760ee-6c1f-458e-a844-acb7b95fef4c", 0, "85743c8a-d0b2-4a39-a39a-c7b1c9adf2c3", "Admin_Tomas34@gmail.com", false, false, null, "tomas34@gmail.com", "TOMAS28", "AQAAAAIAAYagAAAAEASgnbU9l7VMBAuc1ftqNWHxJKXSKwWChFEvDKtKBxpon47wydg638a0r06YCrH0Aw==", "(701) 666-6012", true, "17d9d9b7-1ed6-46f3-8856-9c95c6e1ff52", false, "Tomas28" },
                    { "99cf6ee1-9d46-4bbf-8b8f-722b2b7e86d2", 0, "99aaf9eb-fb79-4db4-bc4d-026b3b19a397", "Admin_Earl_Kozey73@hotmail.com", true, false, null, "earl_kozey73@hotmail.com", "EARL_KOZEY75", "AQAAAAIAAYagAAAAEPjYdsvmDgqnEOXAZmspNIadAONvuFqQnfJsACmIO5nb22kCwmkC6EwGIitLaDf1BQ==", "1-774-241-9201 x9734", false, "12e619da-119f-4a17-9dc0-ee53696cb3fe", false, "Earl_Kozey75" },
                    { "9ed6063c-d969-4ee9-9c76-28f65c2636c9", 0, "7a306c00-6412-489f-b6be-e3e91f400d58", "Normal_Rudy57@yahoo.com", false, false, null, "rudy57@yahoo.com", "RUDY35", "AQAAAAIAAYagAAAAEE/4G0khSI4/XlKbY8aM8jTKVDUudORGOPlZPCFbhYfjlPtMQ1AONuuGaj2Aa9U/DQ==", "842.281.3964", false, "b0179c00-fb3d-4892-accc-43ae71c874ff", false, "Rudy35" },
                    { "a41a5699-ad31-48bf-8d8a-77967e1b58e9", 0, "10d61874-c608-4198-8174-7f42e15271f4", "Admin_Mario.Homenick@yahoo.com", false, false, null, "mario.homenick@yahoo.com", "MARIO21", "AQAAAAIAAYagAAAAED9FDeZ5N9AkpNSH202dF+ffapQenJn06cKBzYsZECU8PcY0VstsF/+Li8rwV2SXuw==", "1-530-357-2152", false, "08bdea7f-6f66-4eec-bda8-fda00bea8969", false, "Mario21" },
                    { "a4541f53-5110-4e82-b078-64e85fa47e39", 0, "59004633-0e22-4312-923c-b9e24116faab", "Admin_Kristopher_Ullrich72@gmail.com", false, false, null, "kristopher_ullrich72@gmail.com", "KRISTOPHER.ULLRICH93", "AQAAAAIAAYagAAAAEDVFUGyfxZsxyjr5al+Wpsea3Rv+YMdaZCqc1mb7CD7HrgZGJ9mlbU2J823Et56/Gg==", "351-535-7932", false, "ef2c775a-f4cf-4db7-aa16-27616c7e4b71", true, "Kristopher.Ullrich93" },
                    { "a966a3ce-37b1-47ac-84f0-38013fd770c7", 0, "0d85b82e-1fcd-4eea-bd2c-d6397e94b746", "Admin_Karl44@yahoo.com", true, false, null, "karl44@yahoo.com", "KARL23", "AQAAAAIAAYagAAAAEKLp3efxRl6fKTC54ZXSHqTQ9muvf+IU1E/dVbFBIn3WjNGQv0pKrbb4uf/2+QaquQ==", "(472) 359-2497", true, "9fe7a14b-9cfc-4cae-b3de-069ec438c19f", true, "Karl23" },
                    { "aa95bf73-9757-4c9b-8f3c-b758c2c38810", 0, "64ce7e99-7df3-4ad2-9d78-81628e6a4415", "Normal_Sherri66@yahoo.com", false, false, null, "sherri66@yahoo.com", "SHERRI70", "AQAAAAIAAYagAAAAEEAT0rb0v6fn1SsD3LRuzJCSJOTqJJ7YvDOpBHPTl6YsVWYNE7zjDzvhyCr24dX1jg==", "1-382-644-9025", false, "3758033d-431e-456d-9f5e-913010e92f01", true, "Sherri70" },
                    { "adda5085-1106-4429-b278-0da03f3f6f9d", 0, "2dfab87c-651f-4249-8f50-65c1015a872c", "Normal_Bryan3@gmail.com", false, false, null, "bryan3@gmail.com", "BRYAN31", "AQAAAAIAAYagAAAAEJlYT6gP9NAoL7shEoxRT0XGkkDHfzHidZZevu3C/+sYm1sw1JWmzA7RvqwEBGF5/w==", "(243) 427-5316", false, "2b207dcd-883c-4eb5-94fe-66fc65aa4c0f", true, "Bryan31" },
                    { "b264f183-8818-4e65-85b4-bc040204aa7b", 0, "76cc14e9-5fbe-4889-a9e2-55e7476a092a", "Normal_Josephine8@gmail.com", false, false, null, "josephine8@gmail.com", "JOSEPHINE_DAUGHERTY26", "AQAAAAIAAYagAAAAEMCO9zHvP7teckJVztWzR2dhiKlAWZkDj5Smehx/qFdiBJvWjVrjkLYSGdFbkYoQZQ==", "343.807.9756", true, "78aeccbe-ac17-48ea-83ba-5699d3353312", true, "Josephine_Daugherty26" },
                    { "b36129d2-ed4a-4b2b-b19a-20b65622c63a", 0, "bc85c77b-331d-4084-a1b6-d568f7772da7", "Normal_Jane_Homenick68@hotmail.com", false, false, null, "jane_homenick68@hotmail.com", "JANE95", "AQAAAAIAAYagAAAAEAnLnm9BT1x38K7n9MYtdwEdDCwgzofRq2EffXLmNVbpKn0TEs9/3hsXzI6cyg3NRg==", "(262) 476-2494 x3335", false, "2a704eb8-7770-4d05-93e8-c2650b9b876a", true, "Jane95" },
                    { "b57c4607-fe11-46ae-bce5-28abaaf49a7f", 0, "1f3e83e4-11b4-45c0-bf17-56c8f991dd07", "Admin_Marty_Dach49@gmail.com", true, false, null, "marty_dach49@gmail.com", "MARTY6", "AQAAAAIAAYagAAAAEEdlb1SFoLW252pFnzgX1MfkeFKc3aNwtze+r9FhmVUB3LBDRmh/BU2/giZ0IF7Tig==", "(452) 390-9670 x312", true, "b335a454-fe90-4f97-829d-932c24dc9c5d", true, "Marty6" },
                    { "cc57b37a-bb3a-4b2d-addd-817fbf526667", 0, "ad991d45-c8a1-49d1-93c2-ad549c6faa5a", "Normal_Saul_Carter@yahoo.com", true, false, null, "saul_carter@yahoo.com", "SAUL_CARTER", "AQAAAAIAAYagAAAAECC2bFBdjx/qDrij1QDI3AbR6AhTnDPSIJ1dRX1o9dmEkMht+GMykDsPvNoQum6tTQ==", "(813) 519-8288 x686", true, "2dc26a25-e97d-4ca6-864e-21f55a1e1a8f", true, "Saul_Carter" },
                    { "de20b6a4-38c3-416d-88fe-33816fa0c0c9", 0, "0c16b42d-16f5-480b-bbae-75f196d36a8f", "Admin_Lila91@gmail.com", true, false, null, "lila91@gmail.com", "LILA.BREITENBERG39", "AQAAAAIAAYagAAAAEHyZVX6C++31Uuzll0f7+qH7GSzY7snfODBqiFIpMcEeJ3D3h7sSLM/SDDxSPIisNQ==", "736.559.6685", false, "e8cc31a0-c7bd-402a-b74c-441dac46a356", true, "Lila.Breitenberg39" },
                    { "e15858e1-975c-4037-a834-191acb802e51", 0, "79bb9741-80c2-41e4-b22a-5601e827bb62", "Normal_Brandy.Stehr@gmail.com", false, false, null, "brandy.stehr@gmail.com", "BRANDY_STEHR", "AQAAAAIAAYagAAAAEAXAXUDQWTU5yFI1svFNRLa+B6MfG+4drHKzSwj7WbxFycd11C+qW50MJSCJ1ELY6g==", "(678) 755-9960 x220", false, "e728fdb7-4302-4673-9e11-b5b5bcf184d9", false, "Brandy_Stehr" },
                    { "e745a19a-2f31-4c60-b4fd-b87c8d212345", 0, "57167044-5ed7-4bcc-baed-bc1d19cc9bde", "Normal_Peter.Ferry@hotmail.com", false, false, null, "peter.ferry@hotmail.com", "PETER.FERRY53", "AQAAAAIAAYagAAAAEGtKOHRGjOJQ+hxaq/c+Ma7GYP5YUGQu4BPALkuQF+8MFlc2GOFN4DXoOvfFooNA6A==", "965.915.4715", false, "af2b193e-5c4e-4412-a933-5d680a8e23bf", false, "Peter.Ferry53" },
                    { "e827cf54-ae2a-4c7d-98ca-8de606576894", 0, "4361eb7e-975f-4e42-a952-5165dfb2655c", "Normal_Antoinette56@yahoo.com", true, false, null, "antoinette56@yahoo.com", "ANTOINETTE.DENESIK84", "AQAAAAIAAYagAAAAEN/LnPOz0OMAWc8fr0kx3Dkg9lVQdV3p6qfsEEd2xGaGttua/ILzQeAqgSpDlhTXDw==", "1-313-380-0769 x9755", true, "7431b097-f080-4fd6-b22e-cba167b5c093", true, "Antoinette.Denesik84" },
                    { "ecb4066f-59c7-41c9-99e6-32e354cd507f", 0, "fb8a1d45-7193-494e-a619-2be87388cac3", "Admin_Hannah.Barrows76@gmail.com", true, false, null, "hannah.barrows76@gmail.com", "HANNAH.BARROWS17", "AQAAAAIAAYagAAAAEHK/9rFaSfz+JRgijFBKsrskzscAEIdiirTSI38m40KMkX7B1dO79zaaaEKAbPA+rg==", "(911) 976-8672 x660", false, "acb680cb-7650-4ec0-93f6-ec34585329ab", false, "Hannah.Barrows17" },
                    { "fbd1a202-e0fe-4a4e-83e4-fd9b2cba7aea", 0, "b7fda479-c3e1-4fc6-b3ef-8be29ad700be", "Normal_Ernesto.Crooks31@hotmail.com", true, false, null, "ernesto.crooks31@hotmail.com", "ERNESTO.CROOKS50", "AQAAAAIAAYagAAAAEP+d3DAbyYtVvaPkv/hdBbvKKo7KZKUlRUzweh3I3Kc2FYzrsL7mRHRo20xTIyKScA==", "992-645-2475 x80297", true, "238b137c-72aa-47ce-86e5-aa3de1f87634", true, "Ernesto.Crooks50" }
                });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "Bs", "Name", "Suffix" },
                values: new object[,]
                {
                    { new Guid("06e41eee-01be-4e7e-b7eb-88971ac31e06"), "whiteboard 24/365 initiatives", "Nienow - Marks", "LLC" },
                    { new Guid("087322da-9ae2-40ee-bcf6-846982402e9b"), "matrix one-to-one synergies", "Breitenberg Inc", "LLC" },
                    { new Guid("08fa38a9-e2b1-48a2-a206-df2abf87de06"), "embrace holistic supply-chains", "Feest and Sons", "LLC" },
                    { new Guid("2b3ca992-c812-47f1-9995-d64bc0d0e1b6"), "productize holistic markets", "Cruickshank - Johnston", "Inc" },
                    { new Guid("367412fd-1074-4e9a-bf7b-4f8652f8e2cf"), "mesh next-generation convergence", "Klocko - Glover", "Group" },
                    { new Guid("464a71c3-5616-4129-a3aa-e24367684e9e"), "iterate seamless synergies", "Kessler - Hudson", "LLC" },
                    { new Guid("58ea8a9f-4ef7-45bb-bb91-f8a498f3ee80"), "e-enable extensible web services", "West, Cormier and Williamson", "and Sons" },
                    { new Guid("5b28118d-d58a-421e-bbdf-ef2ad0935b1c"), "innovate back-end synergies", "Stanton LLC", "and Sons" },
                    { new Guid("5e675178-d1cb-4c97-980b-5648389afe9e"), "evolve compelling platforms", "Gibson, Gutmann and Carter", "Group" },
                    { new Guid("67a084b0-9004-4343-8e15-05ddca6fab56"), "target collaborative initiatives", "Wehner Group", "and Sons" },
                    { new Guid("67cd1eb6-b79f-4a52-969c-c53e0efce9e0"), "evolve bleeding-edge architectures", "Feest - Pfeffer", "and Sons" },
                    { new Guid("6868e2ae-742b-4577-a2a2-8c2993cb6cec"), "drive innovative models", "Turcotte, Swift and Zboncak", "LLC" },
                    { new Guid("74a816b0-c060-4b75-a5be-317b6877cc85"), "harness bricks-and-clicks architectures", "Murray, Becker and Ankunding", "LLC" },
                    { new Guid("864981a9-6e34-4338-a66c-6c7aea051c02"), "orchestrate turn-key partnerships", "Parisian - Smith", "LLC" },
                    { new Guid("8b3c4621-2b27-47cf-8595-f678285d7e0d"), "mesh collaborative e-business", "Bosco, McCullough and Sanford", "Group" },
                    { new Guid("8d1fc1dd-60b2-4e6e-bb11-9f6cad24b0d0"), "extend revolutionary action-items", "Hettinger - Doyle", "Group" },
                    { new Guid("93443032-880e-4a5e-9e14-3677abaab5b9"), "mesh efficient e-markets", "Lind - Morar", "and Sons" },
                    { new Guid("974a14b3-f7c7-4490-b801-cc3f6454e415"), "expedite impactful bandwidth", "Ebert, Hauck and Schiller", "Inc" },
                    { new Guid("9e482ce9-ae77-483d-b126-724512acb9c1"), "disintermediate front-end infomediaries", "Marvin and Sons", "and Sons" },
                    { new Guid("a67b18e2-aa15-4868-a34c-c3ebbcd6461b"), "recontextualize best-of-breed applications", "Wilderman, Wolf and Homenick", "Group" },
                    { new Guid("aaf9c1f9-b607-4ddd-9cda-5d972c772240"), "productize global e-services", "Okuneva - Lockman", "Group" },
                    { new Guid("b84209a6-4cc0-4c06-b86e-1d86281efb73"), "e-enable interactive e-services", "Johnson, Pouros and Tremblay", "Inc" },
                    { new Guid("c0923acd-5973-4270-9e0c-e6c5f42f8748"), "exploit customized mindshare", "Rohan, Abernathy and Schmeler", "and Sons" },
                    { new Guid("c5feb13c-6578-4e2a-9fef-582f26aaf0eb"), "reinvent synergistic metrics", "Gislason LLC", "Inc" },
                    { new Guid("c792c15a-8ebb-4909-9e27-01908239db77"), "recontextualize end-to-end users", "Gleichner Group", "Group" },
                    { new Guid("d2f0eb69-1437-4015-8681-b2c54e4f78a5"), "reintermediate real-time models", "Wilkinson, Walter and Ward", "LLC" },
                    { new Guid("e5c539d3-714d-4e48-9950-66e026fa14cb"), "streamline front-end schemas", "Brakus Inc", "Inc" },
                    { new Guid("e85843e5-d235-49d8-b13a-8c477f77e5e1"), "productize sexy technologies", "Heaney, Koelpin and Mitchell", "Inc" },
                    { new Guid("eb4479e6-7f72-4a0a-8a53-6dc1f8d94acf"), "exploit vertical web-readiness", "Bergstrom and Sons", "Inc" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("00aab9ab-6dc0-4561-b856-a91679bda84e"), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Awesome Granite Chips", "389.18" },
                    { new Guid("0b57a5f5-3dd5-4123-b022-161569c11e7a"), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Refined Plastic Soap", "439.01" },
                    { new Guid("0e9e882d-3fc9-47f1-9c00-08bb53583643"), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Handmade Concrete Chips", "555.55" },
                    { new Guid("13b32678-884a-4563-a162-4078a2574e7b"), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Rustic Concrete Hat", "946.46" },
                    { new Guid("1744eb6d-657f-41d7-a960-5bf66d61fd64"), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Handcrafted Wooden Cheese", "398.52" },
                    { new Guid("1863203a-ff67-4f9b-98d2-a36f376058ff"), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Unbranded Wooden Bike", "368.22" },
                    { new Guid("18946e13-c6e0-4008-b63a-8e48581ce7e7"), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Handcrafted Granite Gloves", "208.01" },
                    { new Guid("19f659cc-8dd5-4248-9f8a-e334e3030dbe"), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Incredible Concrete Ball", "811.02" },
                    { new Guid("1db124f6-d1ef-42a0-9777-f695814d7556"), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Tasty Soft Ball", "792.25" },
                    { new Guid("223607a2-4169-4584-98d9-ac143778f2cc"), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Generic Soft Chips", "85.59" },
                    { new Guid("224ee556-e099-4538-887c-14abff70ac4d"), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Fantastic Rubber Shirt", "682.85" },
                    { new Guid("2396dd29-aed9-46b2-a7bf-ba3d202d2102"), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Sleek Frozen Chips", "655.69" },
                    { new Guid("290b870f-26a9-4625-a56a-94cdc3055ab5"), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Rustic Steel Table", "229.89" },
                    { new Guid("2b610a73-47b2-4758-ba81-de0388d88381"), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Unbranded Granite Tuna", "443.26" },
                    { new Guid("2fc52936-f7ee-4302-9b14-febdafc8e3b8"), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Incredible Granite Shirt", "204.46" },
                    { new Guid("357ee24f-6d01-4a9c-b9ad-49fccc046148"), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Small Cotton Car", "294.93" },
                    { new Guid("37e073fa-a9cd-4b05-a416-fb1e0e7e5864"), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Gorgeous Steel Sausages", "731.11" },
                    { new Guid("3939d97b-2cf8-41c3-8d15-18857ff6c05a"), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Handcrafted Fresh Chair", "342.63" },
                    { new Guid("3b25fc13-4dc3-4806-8405-f5a1333e3142"), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Fantastic Rubber Gloves", "778.25" },
                    { new Guid("4db104c7-eb7e-453d-af27-cb64d195a05e"), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Awesome Soft Pants", "970.97" },
                    { new Guid("4ddada47-032c-4e54-a3d9-17919fb59886"), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Sleek Cotton Chicken", "79.74" },
                    { new Guid("506a87a3-e28c-4d2e-9fe8-f0db8800b443"), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Ergonomic Concrete Mouse", "658.08" },
                    { new Guid("538ff381-fc46-4d8b-8102-cf29ef027c6e"), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Handcrafted Wooden Pants", "831.94" },
                    { new Guid("5ae9b679-8b22-4cdc-bb6d-e7762f69452b"), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Unbranded Rubber Soap", "358.21" },
                    { new Guid("606bd2e0-b979-4fc7-b77b-7b64d26d333a"), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Handmade Granite Soap", "6.76" },
                    { new Guid("6fbc05be-8292-4298-a729-df37ccaa8685"), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Licensed Fresh Shoes", "648.55" },
                    { new Guid("722d5f2e-fab2-4e92-91ac-c1a2dbf73fde"), "The Football Is Good For Training And Recreational Purposes", "Awesome Metal Sausages", "48.05" },
                    { new Guid("79a8cf25-ac4c-4a8a-97ec-99f331154194"), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Refined Concrete Soap", "377.40" },
                    { new Guid("7e5cf05a-dc4c-4b71-950a-844045a464c5"), "The Football Is Good For Training And Recreational Purposes", "Small Wooden Shirt", "846.20" },
                    { new Guid("7e5e9ee1-e4be-4f7f-af47-562a9ed9ad8c"), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Tasty Soft Gloves", "338.11" },
                    { new Guid("8490589a-e306-4f79-a70b-5dc966e11b11"), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Handmade Fresh Cheese", "469.91" },
                    { new Guid("88dc51d0-e6bf-49ca-91ef-ce2b71af2cf3"), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Licensed Rubber Fish", "569.82" },
                    { new Guid("8bd1fe4b-667a-4754-bb30-279f555a79a9"), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Handmade Granite Cheese", "88.30" },
                    { new Guid("8d1ff29d-fb0e-47da-9b54-5ca7a2d4e08d"), "The Football Is Good For Training And Recreational Purposes", "Tasty Soft Chicken", "153.19" },
                    { new Guid("8fb10ed6-179b-4936-98d5-4cb36d04e7f2"), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Gorgeous Frozen Towels", "585.34" },
                    { new Guid("92e427fd-a827-4a1a-a620-4efbab65de5f"), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Ergonomic Granite Ball", "734.71" },
                    { new Guid("93495421-e6be-4d04-8d90-adea0cc2130f"), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Awesome Plastic Bike", "680.21" },
                    { new Guid("a2517141-ccd4-4a85-b2ff-86f2629377cb"), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Handcrafted Frozen Shoes", "879.76" },
                    { new Guid("aad90b54-6a6e-48c2-beae-785ed37e3c43"), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Rustic Wooden Fish", "225.39" },
                    { new Guid("aca30ad4-cecb-4fa8-8ee0-ac3806382217"), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Generic Frozen Hat", "564.01" },
                    { new Guid("baa8e85f-1e68-4c5d-be2b-759a6b261c5c"), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Handmade Rubber Mouse", "612.84" },
                    { new Guid("ce41659c-a407-47a0-90b0-86277e88a2d5"), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Tasty Plastic Chicken", "321.87" },
                    { new Guid("cfa5f6fb-238d-4aa6-bd24-7f4b2cec924a"), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Ergonomic Cotton Soap", "563.57" },
                    { new Guid("d44a35d3-4a63-4d92-aeff-f8d619fc5298"), "The Football Is Good For Training And Recreational Purposes", "Intelligent Metal Sausages", "560.51" },
                    { new Guid("dc31a946-b67d-4b0e-bfdd-e2548bcc3280"), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Licensed Rubber Chicken", "771.04" },
                    { new Guid("e24ac1b7-3a7e-4369-b513-323c6ebae386"), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Practical Fresh Bacon", "388.90" },
                    { new Guid("e34d65da-39bb-4ba5-ae35-fb049edaff1c"), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Practical Soft Chips", "709.23" },
                    { new Guid("e37b035e-5593-404e-bac7-14140598ba30"), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Intelligent Cotton Chips", "67.77" },
                    { new Guid("e5725c22-c906-4c51-b524-42e9405b2b7b"), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Gorgeous Steel Salad", "182.94" },
                    { new Guid("e835dd17-a55b-4a67-bc2a-51f16faeb413"), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Handmade Concrete Towels", "413.94" },
                    { new Guid("e986ac6e-1157-4734-a602-afc671afb54e"), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Intelligent Fresh Shirt", "401.25" },
                    { new Guid("ecfd61c7-fe44-4e84-ab86-a131987f8cff"), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Ergonomic Granite Salad", "379.48" },
                    { new Guid("ef390618-799a-48e6-938a-deb08d7b4b39"), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Fantastic Rubber Bacon", "376.21" },
                    { new Guid("f8518778-883b-401a-a5c1-61541e26b198"), "The Football Is Good For Training And Recreational Purposes", "Incredible Wooden Bike", "876.40" },
                    { new Guid("f97108b5-3a20-4eed-9e1a-b1d4974288e0"), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Gorgeous Frozen Bacon", "462.57" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "3b5ddb63-bdb1-448d-93ce-6f1475b8316f", "026fac15-1476-4b34-9b63-e75bb465f7b0" },
                    { "276af310-41ad-46ca-84b0-90fcfa1833fa", "07ceab4a-96e4-4a12-94c1-8ddc05efb1a6" },
                    { "276af310-41ad-46ca-84b0-90fcfa1833fa", "1d2bb238-c5a3-4966-83f9-4103153aa849" },
                    { "276af310-41ad-46ca-84b0-90fcfa1833fa", "20d9d315-549c-4e8f-8a37-bf0eee6d7796" },
                    { "3b5ddb63-bdb1-448d-93ce-6f1475b8316f", "2538d62c-7e4a-4682-9fa7-3559198d91a6" },
                    { "276af310-41ad-46ca-84b0-90fcfa1833fa", "265bbb85-edfc-4c43-af1f-5e09164c732f" },
                    { "276af310-41ad-46ca-84b0-90fcfa1833fa", "2f16574a-e3e5-4783-a754-e0b222daf251" },
                    { "3b5ddb63-bdb1-448d-93ce-6f1475b8316f", "513f83a8-378e-44c8-9519-24dfa658f140" },
                    { "276af310-41ad-46ca-84b0-90fcfa1833fa", "5760c2b7-4d08-4792-a168-933fa1c17a62" },
                    { "3b5ddb63-bdb1-448d-93ce-6f1475b8316f", "5d965f98-58de-4db8-b1b2-95bd11fc7869" },
                    { "3b5ddb63-bdb1-448d-93ce-6f1475b8316f", "67ef2581-1b4f-4abd-8b62-8e1a11849022" },
                    { "276af310-41ad-46ca-84b0-90fcfa1833fa", "70784095-2f30-4f1c-a756-bec5dee1e8fc" },
                    { "276af310-41ad-46ca-84b0-90fcfa1833fa", "75f0ab6f-1706-492a-9c73-247a84822fb2" },
                    { "3b5ddb63-bdb1-448d-93ce-6f1475b8316f", "79b2ebc7-9531-49f8-a6cd-4eb9c1c45812" },
                    { "3b5ddb63-bdb1-448d-93ce-6f1475b8316f", "7ae1c839-292e-4ac4-90fa-3f260007d657" },
                    { "276af310-41ad-46ca-84b0-90fcfa1833fa", "7d846a21-8b45-43e9-b481-3f374a4ea020" },
                    { "276af310-41ad-46ca-84b0-90fcfa1833fa", "7dec286b-b6c5-415c-95c8-38e616b2e8ab" },
                    { "276af310-41ad-46ca-84b0-90fcfa1833fa", "7e67b05b-7915-4b5a-918d-8b991b0a755d" },
                    { "3b5ddb63-bdb1-448d-93ce-6f1475b8316f", "829e7bdf-5df1-4c3c-b4fd-bddfbfe52783" },
                    { "3b5ddb63-bdb1-448d-93ce-6f1475b8316f", "8829499e-b67e-425f-bda0-6b9964a759da" },
                    { "276af310-41ad-46ca-84b0-90fcfa1833fa", "8dd949fa-d27e-4b3e-be40-b284a6c33327" },
                    { "3b5ddb63-bdb1-448d-93ce-6f1475b8316f", "967760ee-6c1f-458e-a844-acb7b95fef4c" },
                    { "3b5ddb63-bdb1-448d-93ce-6f1475b8316f", "99cf6ee1-9d46-4bbf-8b8f-722b2b7e86d2" },
                    { "276af310-41ad-46ca-84b0-90fcfa1833fa", "9ed6063c-d969-4ee9-9c76-28f65c2636c9" },
                    { "3b5ddb63-bdb1-448d-93ce-6f1475b8316f", "a41a5699-ad31-48bf-8d8a-77967e1b58e9" },
                    { "3b5ddb63-bdb1-448d-93ce-6f1475b8316f", "a4541f53-5110-4e82-b078-64e85fa47e39" },
                    { "3b5ddb63-bdb1-448d-93ce-6f1475b8316f", "a966a3ce-37b1-47ac-84f0-38013fd770c7" },
                    { "276af310-41ad-46ca-84b0-90fcfa1833fa", "aa95bf73-9757-4c9b-8f3c-b758c2c38810" },
                    { "276af310-41ad-46ca-84b0-90fcfa1833fa", "adda5085-1106-4429-b278-0da03f3f6f9d" },
                    { "276af310-41ad-46ca-84b0-90fcfa1833fa", "b264f183-8818-4e65-85b4-bc040204aa7b" },
                    { "276af310-41ad-46ca-84b0-90fcfa1833fa", "b36129d2-ed4a-4b2b-b19a-20b65622c63a" },
                    { "3b5ddb63-bdb1-448d-93ce-6f1475b8316f", "b57c4607-fe11-46ae-bce5-28abaaf49a7f" },
                    { "276af310-41ad-46ca-84b0-90fcfa1833fa", "cc57b37a-bb3a-4b2d-addd-817fbf526667" },
                    { "3b5ddb63-bdb1-448d-93ce-6f1475b8316f", "de20b6a4-38c3-416d-88fe-33816fa0c0c9" },
                    { "276af310-41ad-46ca-84b0-90fcfa1833fa", "e15858e1-975c-4037-a834-191acb802e51" },
                    { "276af310-41ad-46ca-84b0-90fcfa1833fa", "e745a19a-2f31-4c60-b4fd-b87c8d212345" },
                    { "276af310-41ad-46ca-84b0-90fcfa1833fa", "e827cf54-ae2a-4c7d-98ca-8de606576894" },
                    { "3b5ddb63-bdb1-448d-93ce-6f1475b8316f", "ecb4066f-59c7-41c9-99e6-32e354cd507f" },
                    { "276af310-41ad-46ca-84b0-90fcfa1833fa", "fbd1a202-e0fe-4a4e-83e4-fd9b2cba7aea" }
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
