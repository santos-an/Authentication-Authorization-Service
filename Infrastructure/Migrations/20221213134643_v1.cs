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
                values: new object[] { "1dfa8ea5-00bd-4c51-80e6-33c5939eb0c0", null, "AppUser", "APPUSER" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "26069a3a-3166-4171-a5c3-e08b08a5304e", 0, "8bb2b67b-bab1-4e73-980c-b9aed5c9d003", "Micheal.Cummerata@gmail.com", true, false, null, "Micheal.Cummerata@gmail.com", "Micheal56", "AQAAAAIAAYagAAAAEG3owmf9lMz/cu9XC0QwK4hBT4EW6hcNEJTS6NYDbEBldZi8h5CvYbbiUNxMaltbJA==", "479.657.7580 x81811", false, "8e0209b4-45fd-45f3-bf4b-123e328d051a", false, "Micheal56" },
                    { "2cea71fe-a558-4469-8b1e-2220283f73e3", 0, "61752d5c-c652-4ed5-ab7c-aa4b42a358c8", "Perry.Swift@gmail.com", true, false, null, "Perry.Swift@gmail.com", "Perry_Swift", "AQAAAAIAAYagAAAAEBQ3yklru7RPX0NuW8yXzyVrtKFFlEaZUpkii6ZLtsIBfKqHP9vf1At9VbJOIHWjNQ==", "1-332-558-0541 x2418", false, "eb19254b-a0e8-4436-bf20-090156f4cd9b", false, "Perry_Swift" },
                    { "313ec344-9c75-414c-ada8-c97b011b4149", 0, "33d17488-a8ec-4584-bd63-c8a5387b21af", "Colleen.Hackett@yahoo.com", false, false, null, "Colleen.Hackett@yahoo.com", "Colleen44", "AQAAAAIAAYagAAAAEO2wXZMgKC5mB8i4Ow/dnhvqcT52c6mt5Lhc79EfmPtNLLdDkj6oR+GNc4M+qFP/jA==", "(618) 943-8185 x8472", false, "a9a8a8f5-9f09-4d5a-ba08-29aedad54a50", false, "Colleen44" },
                    { "3325a78e-0999-4105-b70c-b3212b79e5c0", 0, "417772d3-a958-4f3e-ac95-444bcf946468", "Fernando.Davis@hotmail.com", false, false, null, "Fernando.Davis@hotmail.com", "Fernando_Davis", "AQAAAAIAAYagAAAAEChozT8yu9N8rrZE9HoqTwF3cC+cpiK86/LwrTu7l3nZiaU932btGYF9bGtkjcfoew==", "713-431-9697 x75550", false, "b71a4935-7418-4d05-a024-8b8da6149f76", false, "Fernando_Davis" },
                    { "372c5467-5c5e-43ba-ab8f-4b0c74dfdc26", 0, "b79a876f-373b-4f7f-a547-b696bcb641c0", "Caleb72@gmail.com", false, false, null, "Caleb72@gmail.com", "Caleb38", "AQAAAAIAAYagAAAAEP0yZ0/tPVGDHDXdr5tL6Jtup8eiZoIGsiUFjL5cyTGPCyj5wINRBQgtK3YJN8t3bQ==", "313.668.4425 x435", false, "8edf2b75-a57f-499e-be9f-6d353b3b6306", false, "Caleb38" },
                    { "3908d316-226a-4529-90ab-81e8f10fd5f6", 0, "f7c4ec75-c044-4ec5-ac61-9f8655b7605b", "Verna39@hotmail.com", false, false, null, "Verna39@hotmail.com", "Verna_Hagenes", "AQAAAAIAAYagAAAAEM2dWXD9JzzngKAS/W7qmE8C8MkH+DkG2rF+DGgw2Onjibj/zymcBWoZbQ3mVjJoQA==", "547.368.4928 x7530", false, "44b89aaf-03b4-4590-a1a8-38ca4410fbdb", false, "Verna_Hagenes" },
                    { "39bfe2c5-3400-4449-9882-9073f01855c0", 0, "ff4423eb-6c9c-4b60-8014-05ba56a9c123", "Evelyn.Rowe34@hotmail.com", false, false, null, "Evelyn.Rowe34@hotmail.com", "Evelyn.Rowe38", "AQAAAAIAAYagAAAAEL5a44fWVeIxI1lWjt8zYojJLa+UHQ95fb2H1oexwis4MquQAqTEtcWgJRf5E4JWDQ==", "1-616-284-4213 x62187", false, "4deb3fb2-43b5-43ea-a575-25d63843cd4b", false, "Evelyn.Rowe38" },
                    { "3a340844-d9b8-4226-bdc6-a6912a670376", 0, "cc3548f6-beb4-412e-91d5-133b9e0f01c9", "Nathan80@hotmail.com", false, false, null, "Nathan80@hotmail.com", "Nathan_Hoppe37", "AQAAAAIAAYagAAAAEMM1LgzG3ohPIZ/zHa1iadVitsSMaDYrEGSwlWuyP0f8qRFwY2ahQWWpBP0LBMeTzQ==", "1-583-537-6781", false, "920d9aa1-1952-4e45-a2b8-5e4d3304b984", false, "Nathan_Hoppe37" },
                    { "3dc9cbd0-9de6-4eb4-b6d5-a3490d811b25", 0, "7a2bd871-09ef-48be-b320-2af8f38f1e4e", "Dolores.Trantow@hotmail.com", true, false, null, "Dolores.Trantow@hotmail.com", "Dolores_Trantow", "AQAAAAIAAYagAAAAENiddveQIJg/BH6e1YezXFELQutqonHFQ8KcLquiHBtbtMo+Wvkjaqv39piGP3NrLA==", "999.520.4637 x73295", false, "d826dd5e-163d-4895-8d9b-923622578f10", false, "Dolores_Trantow" },
                    { "46e06c94-d410-45c2-9638-5b4b507a8a8b", 0, "8169ae41-df35-49eb-9ae3-cb62136f62c9", "Ruben38@hotmail.com", false, false, null, "Ruben38@hotmail.com", "Ruben71", "AQAAAAIAAYagAAAAEAnggjluGGvxEhUz2ed27e7T7m1DFcK6O6tIFAQcQvCcJABxmSChORvMUq6ToeLCCQ==", "965-648-9529 x7627", false, "b80ff3e8-fad5-49d4-a47a-2791513a5045", false, "Ruben71" },
                    { "4ab00788-3a38-4b11-b05c-3555cd69ce69", 0, "4511a0d6-ae30-4037-ab3e-0f349d08e433", "Vivian.Lockman86@yahoo.com", true, false, null, "Vivian.Lockman86@yahoo.com", "Vivian_Lockman", "AQAAAAIAAYagAAAAEBkEh7TlNlRC5ogkYj+wc4Jj7vpIiIyC1RR7lTJdjxcSUfVlRcDrBJUN8crogDllIg==", "(928) 374-1151 x514", false, "a173cdb5-c827-437b-81c2-07195bb6f661", false, "Vivian_Lockman" },
                    { "4b18f5a2-b91b-41c8-8185-1b1f308bdc70", 0, "62361c0a-3faf-4160-97d2-458e703fe5aa", "Angel27@hotmail.com", false, false, null, "Angel27@hotmail.com", "Angel.Mohr", "AQAAAAIAAYagAAAAEBEwJb7ssh2TSeYYdGFa7iXb2CBZEIoINsmpd4q2J6cUBZDE8ZcD8Q4SLZcD5OnHVA==", "1-862-286-9988", false, "7c8224e2-960b-4cb1-a633-ac6393e3af17", false, "Angel.Mohr" },
                    { "51076398-d361-47f0-9e60-5cdf3083dbd7", 0, "ee1ba4ca-9231-409e-bf0b-e95ab75e5261", "Roy98@yahoo.com", true, false, null, "Roy98@yahoo.com", "Roy38", "AQAAAAIAAYagAAAAEF3MPFiA8KxmFPI+hhKsUaCNM9FXbGXx3vm9bR8zEPvtB/IqqWwd0dcGWY4jK7s5Tg==", "417-724-5537 x7866", false, "832454ca-0814-4cb8-a09e-2fbe48affe07", false, "Roy38" },
                    { "64e1ec7f-7a53-4485-8747-8ec2425fa96a", 0, "2c8531a5-4c8d-41c3-8c6c-a99d4a2b784c", "Santos_Wiza16@hotmail.com", false, false, null, "Santos_Wiza16@hotmail.com", "Santos_Wiza46", "AQAAAAIAAYagAAAAEEle8vD8Ktipw3GPwLus/EXbJMsWCSVXkxqaneyZbuGHESF1T++thHWaCHeWK5on9g==", "291.451.7769 x3991", false, "64a65d1c-8589-4415-91c0-8b910af30a43", false, "Santos_Wiza46" },
                    { "697d8864-b38b-4042-b28e-d481291a6191", 0, "a3122455-b82c-4382-bc88-00780a967a6b", "Brandon.Borer89@hotmail.com", true, false, null, "Brandon.Borer89@hotmail.com", "Brandon2", "AQAAAAIAAYagAAAAEBppVLNxIm+hRNB+AnDNxViuH26MmErL4H3+1Vorsffdvr8kiyOxqMYAoeaBT1+cGA==", "(741) 876-0206 x4709", false, "d8c0cff8-5ad4-4fb4-bcf1-fe72192a4e44", false, "Brandon2" },
                    { "69f59aa0-83d7-4a7c-ba65-482a7fad2dfa", 0, "2397461b-e1bc-4b4d-aae0-8c584964d8fa", "Wanda.Shanahan@hotmail.com", false, false, null, "Wanda.Shanahan@hotmail.com", "Wanda_Shanahan", "AQAAAAIAAYagAAAAEKU70zdpaiNw7f1gSSsfAS3OrdWl+HJYMF1tL2dyjQvDRVFi1U606HqSOg+nPCbaPw==", "416-949-2849 x6562", false, "38b6e65e-4c55-4859-9c9e-9dac89d885c1", false, "Wanda_Shanahan" },
                    { "6a19c4f4-7c63-4b21-8775-b93576d17385", 0, "6fddd754-57e1-4507-8a3b-40a123106e74", "Shaun19@hotmail.com", true, false, null, "Shaun19@hotmail.com", "Shaun.Mitchell", "AQAAAAIAAYagAAAAEOdgNhYBW9NbuQS9cTM2Sy32mbOGmfS2pHkpykYFmqHZEx8pfOEeKhm7MLjspJ2mqg==", "716.964.0007 x11857", false, "2672b18b-22e0-4c8d-abe0-d442708492cb", false, "Shaun.Mitchell" },
                    { "6cbd9239-ab04-43b8-8f5d-95fe8c7d6d79", 0, "dd02a375-9a0a-46c9-911b-a2c389f0df58", "Spencer_Hackett@gmail.com", true, false, null, "Spencer_Hackett@gmail.com", "Spencer63", "AQAAAAIAAYagAAAAEIjzogi++bJmtsqO9fL3ygtQUCDM8eH091MESo+FXsnIKY52hT1A13CuiCYdKgOWfg==", "386.317.4861", false, "e86a61ee-1604-44ee-bbee-a4e39d365e03", false, "Spencer63" },
                    { "7dcd769e-e801-4102-874e-82af2ea8b135", 0, "07556dc3-e947-466a-ad8e-58d9053eb14e", "Clay.Sawayn35@yahoo.com", false, false, null, "Clay.Sawayn35@yahoo.com", "Clay.Sawayn43", "AQAAAAIAAYagAAAAEMlNckoAA8cz+e9PjyWvBFzwtZ08TzN8427chc+4dRi0uE35mFBQZebC0aj7/ndB7g==", "1-489-617-9649", false, "5d1d28df-e0b5-4ae2-a509-c5d189d4fdf5", false, "Clay.Sawayn43" },
                    { "7f5122a7-b6d5-4cf8-82aa-479909361b9f", 0, "ee304598-8a54-41d9-81f6-2339fdb1e6ea", "Kirk.Christiansen@yahoo.com", true, false, null, "Kirk.Christiansen@yahoo.com", "Kirk_Christiansen", "AQAAAAIAAYagAAAAENAgViDchb7n/9fdQHX3fzZkVEmOci3JFmS7VkJs+rRoN6nhE0jdqAn4h22CAHZVyw==", "711-919-3645 x99335", false, "de43082c-ceed-4f4b-8a0c-14f2468b7601", false, "Kirk_Christiansen" },
                    { "80ecb32d-82f1-4e04-aaa5-adf65be98b38", 0, "fc817d57-74c2-4e62-abf4-fea3bd9e4ab6", "Ida14@yahoo.com", true, false, null, "Ida14@yahoo.com", "Ida.Heller88", "AQAAAAIAAYagAAAAEHqqbef27bP2NUSRb3IRvAcbndBs3xFhs4phHqjuHO7ts2JWk1Wz2QgUUhk8kJ6cNA==", "469-853-7045", false, "69c50aef-c201-42ec-9fc6-cbbc4bb5421e", false, "Ida.Heller88" },
                    { "88a099b8-2372-4081-9c45-663e8e7734c0", 0, "e1398205-0f0d-435a-b815-54492ac71655", "Charles87@hotmail.com", false, false, null, "Charles87@hotmail.com", "Charles86", "AQAAAAIAAYagAAAAELbRItMpZlo82jQslsNt7KYaoI1rNRYXTutRvB6iqGdhUlPbcVO2dBxyaA0e0F9yfA==", "(757) 912-4921 x228", false, "9474d9ed-9592-4574-b32c-8e39cce72eec", false, "Charles86" },
                    { "97f0db2f-7feb-40d0-aaa5-066bbe5b8e1c", 0, "d9c9439b-2ec3-4eb1-894a-4704cf4855b0", "Salvatore.Cassin@hotmail.com", true, false, null, "Salvatore.Cassin@hotmail.com", "Salvatore60", "AQAAAAIAAYagAAAAEDITUnmnCBWwci+PQ8aNLrjTV+HV+uf0IFJw3w/l3oNdd2BUNqd2jznAN7EZYy1flg==", "(940) 723-3069 x47771", false, "b3f03daa-573f-4224-92d6-e2dab8a15238", false, "Salvatore60" },
                    { "9c2acf9a-e247-448b-b861-4935f39585a7", 0, "fb5075dc-c09c-4a4e-947f-9d0e52e8a118", "Antoinette.Ebert17@hotmail.com", true, false, null, "Antoinette.Ebert17@hotmail.com", "Antoinette.Ebert89", "AQAAAAIAAYagAAAAEHixVSIjFzaGS01fQ5+KQh59yd55J82J0jTc2zYUOBRinwgwFZ0kUFLVgGPWXTBnAg==", "(380) 919-2589 x3994", false, "84aca733-5b9d-4c23-a2a3-6599f749551e", false, "Antoinette.Ebert89" },
                    { "a256b35e-315e-4aaf-be9e-abb6149f7b9d", 0, "7c27ee56-7549-4e2b-92ad-26ee08bff969", "Renee_Schmidt24@gmail.com", false, false, null, "Renee_Schmidt24@gmail.com", "Renee.Schmidt", "AQAAAAIAAYagAAAAEAlNHzCaicZXiWFlLDLJFOCeWW6MHsKAxU8Vob5r67vGyKm3HU1O3Ln8Y5ypYvINsQ==", "1-490-744-0669 x74142", false, "18357c6e-c903-47ae-b2b8-4d2fb412d7bf", false, "Renee.Schmidt" },
                    { "ad5368df-67cf-4a47-a1ae-a6eb809f43bf", 0, "a8b91972-541e-4db6-8bc8-13eb8f98abd3", "Alexander.Koss5@yahoo.com", true, false, null, "Alexander.Koss5@yahoo.com", "Alexander_Koss", "AQAAAAIAAYagAAAAEBduXng8TC4mzhUpNAlrRGHqSJL0wWwFMWNek6stUrPcwESZlHOYVvHARgSr13rLbg==", "(827) 951-2254 x612", false, "043ba3b8-c1e9-48ab-9f2e-a0e0de5c3882", false, "Alexander_Koss" },
                    { "c3d2b232-6caf-48e3-a7d3-1ffe773869f9", 0, "1d6b7649-4814-4cf2-b696-83c7f8fb4aab", "Vicky75@gmail.com", true, false, null, "Vicky75@gmail.com", "Vicky26", "AQAAAAIAAYagAAAAEOryBbq9VOGRzVwr1n2JgL6qtZXf3oLg3QFsbuyEXdE84zk2A1Pdq31MNzBY6hVQSA==", "(587) 760-9891", false, "3f7dc446-26f9-4570-8ace-cfe799c0d993", false, "Vicky26" },
                    { "ca23dad8-3332-404c-8c90-c55612f28c06", 0, "096116e6-627f-441d-a37d-56549dddddef", "Eileen_Cartwright56@gmail.com", true, false, null, "Eileen_Cartwright56@gmail.com", "Eileen.Cartwright", "AQAAAAIAAYagAAAAECfGGK2KssEmPTznPU6tVcQSo21W0jBn8EnbSQImILqMmH+omOZEnafEnqpeklkpqg==", "210.545.1298 x63459", false, "86a0dfda-ce4d-4e8a-a77a-5b03c4d558e5", false, "Eileen.Cartwright" },
                    { "ce638bdf-f926-4332-a4fa-36526269b046", 0, "c60264f4-0447-4de3-9ebf-eb824c0e79ac", "Anthony.Larson@gmail.com", true, false, null, "Anthony.Larson@gmail.com", "Anthony.Larson46", "AQAAAAIAAYagAAAAEAP6PK7n6D3dwz6IPXhUB0Ktd/vSIFiD8M/LXcRGeaoK8zcWcHGENrnaWxSszX56RQ==", "599-875-8193", false, "30c2edab-2e6e-45fc-acb7-9ccaa6acc614", false, "Anthony.Larson46" },
                    { "e61728ab-9772-4ef4-bcc6-0b9e21b9becd", 0, "38a8e8f6-5a8b-48f6-9cdf-34e517e50976", "Edwin.Bayer85@hotmail.com", false, false, null, "Edwin.Bayer85@hotmail.com", "Edwin.Bayer", "AQAAAAIAAYagAAAAEIIvKu7xsVtr05xOVxCs3W/Wa6RAN7d3pf/H1IkrB+jJZmn1Bey6SY8qw63kkiiksg==", "356-219-1601 x193", false, "c0d2e233-00c5-42ba-9eb9-edd52aa0b797", false, "Edwin.Bayer" },
                    { "f0971359-f0b4-443f-868d-db53019702ed", 0, "8d6efe62-c5ad-4a36-a083-b35f1d14b55e", "Steven80@hotmail.com", true, false, null, "Steven80@hotmail.com", "Steven.Hand6", "AQAAAAIAAYagAAAAEA/qG18z4qxXQBPrcH7tAraXqpKRRJzptiHwfnXqWq6W4uc9D1cy+zKWozooCFuJsw==", "640-835-7710 x169", false, "beb2a436-109d-4ebe-9845-e4609a1cbe44", false, "Steven.Hand6" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("058ff84d-6aec-4955-870a-f8bfc48696ba"), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Ergonomic Wooden Pants", "482.63" },
                    { new Guid("0f919c4f-b5d0-45f8-af04-6dea00d9772c"), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Licensed Steel Shirt", "443.20" },
                    { new Guid("10ab7474-ef2b-4f87-8d25-8d6bcec883f4"), "The Football Is Good For Training And Recreational Purposes", "Incredible Steel Salad", "356.11" },
                    { new Guid("13429971-f593-4e64-8149-ea255227121c"), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Awesome Granite Shoes", "959.40" },
                    { new Guid("13bb51dc-b7c6-4d2c-9f5f-dc2ddbc61907"), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Handcrafted Cotton Car", "777.27" },
                    { new Guid("1699dd04-9ab2-4978-8fe5-863d75bb9bd4"), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Practical Cotton Ball", "56.77" },
                    { new Guid("16b9fb13-8371-4464-90a5-c056e294f5f9"), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Handmade Metal Pants", "234.30" },
                    { new Guid("18d35dc7-a708-4880-a52b-5a54f204f009"), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Refined Wooden Keyboard", "765.46" },
                    { new Guid("25000a06-9ab0-4e38-8e71-3904544e12e5"), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Intelligent Steel Car", "693.63" },
                    { new Guid("2742ec91-658f-4a3c-a3fb-a42f89bbc630"), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Ergonomic Granite Tuna", "630.83" },
                    { new Guid("33e297a3-e7f2-4634-a4a0-e5aedc51e6e8"), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Fantastic Concrete Computer", "508.74" },
                    { new Guid("430cc64d-6620-4867-9071-9483e61673ab"), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Tasty Cotton Shirt", "882.88" },
                    { new Guid("46dcc3eb-14ed-4485-bd12-b18c7fb0c098"), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Practical Soft Ball", "317.37" },
                    { new Guid("4ad96fd9-4c0d-47e6-b86c-8b8639e41576"), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Sleek Cotton Cheese", "384.28" },
                    { new Guid("4f34667b-9cfb-43f7-bcf4-7460ddbe41e6"), "The Football Is Good For Training And Recreational Purposes", "Rustic Granite Salad", "180.47" },
                    { new Guid("59916e70-f767-437e-bc34-16e33478d917"), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Unbranded Rubber Pants", "625.52" },
                    { new Guid("5d37a9e4-65db-48f5-8d7d-37d6f4e52f38"), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Unbranded Soft Chicken", "401.46" },
                    { new Guid("6188f9bc-2272-4c3e-8d9c-2b873023f021"), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Refined Wooden Gloves", "48.02" },
                    { new Guid("766fd78f-2653-4943-9140-745c37bbc2b1"), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Refined Frozen Chair", "133.43" },
                    { new Guid("89884008-bdd6-4e8c-82fc-cccc6f0651e2"), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Small Soft Mouse", "723.44" },
                    { new Guid("90a184ec-c8a3-4eef-9b26-36337193bf78"), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Ergonomic Steel Pizza", "46.86" },
                    { new Guid("9bc271a2-022f-4335-b2f7-9a52939337ea"), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Intelligent Cotton Hat", "149.16" },
                    { new Guid("9cc7846b-a77a-4a19-8a86-e44f02506632"), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Generic Granite Car", "131.79" },
                    { new Guid("9e02bda5-bef0-43ca-ab30-3bef2639b5ae"), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Awesome Granite Shoes", "436.55" },
                    { new Guid("adcf013c-54e7-4472-89a4-6fc66113aafd"), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Handcrafted Concrete Towels", "599.72" },
                    { new Guid("ae0024e5-0bc8-40e5-b6c8-23dacd21a1c2"), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Ergonomic Steel Soap", "501.10" },
                    { new Guid("af10177f-3c87-44a6-b644-7dd6f6b5a2e5"), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Ergonomic Granite Chicken", "25.76" },
                    { new Guid("b053fabd-45a0-4880-b549-f6660e7811a0"), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Tasty Metal Salad", "296.37" },
                    { new Guid("b0873092-59b1-4964-8c42-091fae18e137"), "The Football Is Good For Training And Recreational Purposes", "Generic Steel Bacon", "796.99" },
                    { new Guid("b3d342bb-9153-4744-a807-73c9fb6b6b39"), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Gorgeous Plastic Mouse", "630.13" },
                    { new Guid("b46592f2-a6ed-4db7-8b27-bdbc0b54effc"), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Unbranded Cotton Keyboard", "174.50" },
                    { new Guid("c1c904c2-0bbf-43ef-bd7e-c123ebeddecd"), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Licensed Frozen Car", "861.20" },
                    { new Guid("c2b6163b-2c32-49f6-b079-714368fd6902"), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Rustic Steel Shoes", "942.14" },
                    { new Guid("c3d3259e-9680-40b7-a534-856923fe4987"), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Small Steel Towels", "598.36" },
                    { new Guid("c5375872-0682-4e2f-947d-ddc51343bb44"), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Tasty Rubber Hat", "929.91" },
                    { new Guid("cac6bc16-bc9e-4b24-83d0-cff2b563a332"), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Fantastic Fresh Mouse", "136.80" },
                    { new Guid("ce6d0623-04bc-448f-bc1f-9e33b9541e15"), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Incredible Frozen Sausages", "798.42" },
                    { new Guid("cef93130-c301-40d8-970b-8917978c717a"), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Handmade Metal Chicken", "407.42" },
                    { new Guid("cfff3d59-85e0-46bd-a7f9-68284f805f0e"), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Unbranded Concrete Tuna", "811.53" },
                    { new Guid("d1f8a0a3-a034-47e4-934b-203a14215448"), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Ergonomic Granite Fish", "477.28" },
                    { new Guid("d32a58f8-ec69-4657-a898-dba0ec3656a5"), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Sleek Granite Shirt", "240.78" },
                    { new Guid("d6eb08a8-e3ea-4508-aeb1-272c26c833d6"), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Licensed Cotton Tuna", "283.61" },
                    { new Guid("d89d8c15-f07b-49e2-b2a2-ae6faf252cfe"), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Incredible Cotton Pizza", "611.41" },
                    { new Guid("d9cb28fa-328c-4fda-82f6-ce4f6a2507fa"), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Rustic Frozen Table", "739.69" },
                    { new Guid("de80089c-45ba-4a4f-aa28-1061f163629c"), "The Football Is Good For Training And Recreational Purposes", "Licensed Granite Bacon", "389.31" },
                    { new Guid("e06d2328-9ce5-4db9-8ba4-ad3e187f9f42"), "The Football Is Good For Training And Recreational Purposes", "Refined Plastic Cheese", "300.25" },
                    { new Guid("e34ed00f-6c47-4adc-af70-bb67b43414b9"), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Handmade Granite Mouse", "76.65" },
                    { new Guid("ebde45d6-2fe6-4ce7-bdde-1e55bd2e6c23"), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Sleek Metal Pants", "199.25" },
                    { new Guid("ee0dccb2-ed54-4192-99ae-5c98ac04c86f"), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Rustic Concrete Bike", "776.30" },
                    { new Guid("f0ecca87-3df4-4300-97fc-c45ad0636e99"), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Fantastic Concrete Hat", "611.12" },
                    { new Guid("f59f135f-554a-4229-9066-a452185f2a60"), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Sleek Cotton Keyboard", "335.36" },
                    { new Guid("f846c7ba-da34-4605-bfab-1ed5bb62de34"), "The Football Is Good For Training And Recreational Purposes", "Rustic Cotton Ball", "4.58" },
                    { new Guid("faaf562a-2e87-47cd-8750-25ccaf02190a"), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Practical Cotton Ball", "102.89" }
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
