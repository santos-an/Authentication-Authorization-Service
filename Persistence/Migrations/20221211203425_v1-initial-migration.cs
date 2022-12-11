using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class v1initialmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
