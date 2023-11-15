using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataLayer.Migrations
{
    /// <inheritdoc />
    public partial class AddOrderServiceQuantity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("133223f6-7263-494e-91b6-863597baba12"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("61598744-b25d-4df5-901c-6816a90fc7c1"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("a3e05bd6-c5e6-498b-b262-6fd2b432e574"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("04ac8c24-df2c-4280-b98e-ba3a793993da"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("10823813-50f0-4a99-997e-4c3f2bc87db9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("431880b3-b71b-4e25-98cf-37b8fe70db0d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("507ccc0d-a014-467b-be5f-d31be35bfbd9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6e181048-f40d-4d99-b4c5-5ebcd9573282"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8ecbeb04-a84d-4692-b442-d558cd91b0de"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9b736c8a-34f8-4eb5-814e-a993ed5c4b7d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c66f26e7-1d04-42ca-a9f6-cfff1f96ee0a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c73acb7d-236f-47e7-9ad5-dfdbace55fd5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("db6535f8-d5c9-416e-a203-e16e7eed297b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f2d8f3b7-7527-4bf6-9321-aaeef0e3f410"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("19bc013e-72eb-44f0-8ebb-ca302dfe25ed"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("7c4794b7-7558-4872-96fb-18f5ae4c1865"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("c546400f-61a3-47ef-9ba2-b99c5647ae15"));

            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "OrderServices",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "Password", "Role", "Status", "Username" },
                values: new object[,]
                {
                    { new Guid("1527e96c-5cfd-4883-a475-4feb357014e3"), "123456", 0, 0, "customer" },
                    { new Guid("4b224db4-473b-4740-9a16-38ae436dad82"), "123456", 2, 0, "staff" },
                    { new Guid("d2376e25-52f2-431d-85ed-0d453f1e9570"), "123456", 1, 0, "admin" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Brand", "Catagories", "Color", "Name", "PictureLink", "Price", "Size" },
                values: new object[,]
                {
                    { new Guid("1883c618-b0d1-46aa-a27a-d891a6bba4de"), "Air Jordan", "Shoes", "Blue", "Enchanted Sponge Bob", "", 63m, 36.0 },
                    { new Guid("1a2aac64-40c0-4bc6-950c-a8f21197a313"), "Nike", "Shoes", "Red", "Electric Dream", "", 78m, 43.0 },
                    { new Guid("2e42e077-1e74-4ea3-8320-e0a18900d8af"), "Nike", "Shoes", "Purple", "Airbrushed Sneakers", "", 99m, 35.0 },
                    { new Guid("31b97292-19b4-48d9-aaf4-6f55d4ca2a30"), "Nike", "Shoes", "Purple", "Uzui Tengen", "", 58m, 40.0 },
                    { new Guid("40628a83-cd4c-4a75-8152-36c863005ce7"), "Converse", "Shoes", "White", "Cute", "", 55m, 40.0 },
                    { new Guid("46b1ec3e-65b1-40a1-bcd8-4fa79b80dd74"), "Air Jordan", "Shoes", "Blue", "Lighting Thread", "", 91m, 42.0 },
                    { new Guid("6175e609-a360-44a6-ac91-5a0752737d03"), "Adidas", "Shoes", "Purple", "Nebula Burst", "", 58m, 38.0 },
                    { new Guid("62ff70e7-af58-47ee-b4a6-6c4cdf91f81a"), "Autry", "Shoes", "Silver", "Silver Serpent", "", 49m, 39.0 },
                    { new Guid("68a4fdce-40fb-4c59-9c87-ac66466dd824"), "Puma", "Shoes", "Purple", "Crimson Blaze", "", 46m, 45.0 },
                    { new Guid("a5165b79-b50b-4440-a1ab-cf8fa248efc4"), "Converse", "Shoes", "Black", "Spider-Verse", "", 68m, 41.0 },
                    { new Guid("bbdb608a-ead9-48ba-913d-e2ce24b4d371"), "Converse", "Shoes", "Black", "Arkham Knight", "", 112m, 38.0 }
                });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "Price", "Type" },
                values: new object[,]
                {
                    { new Guid("7ff262de-d146-46f8-bc30-92bb2f4faa7c"), 10m, "Clean" },
                    { new Guid("c4b0323d-9241-4bf5-9ec4-89e88ff92fc0"), 30m, "Customize" },
                    { new Guid("fc4a485e-2c43-4d0d-9395-8cb2b368fcde"), 20m, "Repair" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("1527e96c-5cfd-4883-a475-4feb357014e3"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("4b224db4-473b-4740-9a16-38ae436dad82"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("d2376e25-52f2-431d-85ed-0d453f1e9570"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1883c618-b0d1-46aa-a27a-d891a6bba4de"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1a2aac64-40c0-4bc6-950c-a8f21197a313"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2e42e077-1e74-4ea3-8320-e0a18900d8af"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("31b97292-19b4-48d9-aaf4-6f55d4ca2a30"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("40628a83-cd4c-4a75-8152-36c863005ce7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("46b1ec3e-65b1-40a1-bcd8-4fa79b80dd74"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6175e609-a360-44a6-ac91-5a0752737d03"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("62ff70e7-af58-47ee-b4a6-6c4cdf91f81a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("68a4fdce-40fb-4c59-9c87-ac66466dd824"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a5165b79-b50b-4440-a1ab-cf8fa248efc4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bbdb608a-ead9-48ba-913d-e2ce24b4d371"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("7ff262de-d146-46f8-bc30-92bb2f4faa7c"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("c4b0323d-9241-4bf5-9ec4-89e88ff92fc0"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("fc4a485e-2c43-4d0d-9395-8cb2b368fcde"));

            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "OrderServices");

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "Password", "Role", "Status", "Username" },
                values: new object[,]
                {
                    { new Guid("133223f6-7263-494e-91b6-863597baba12"), "123456", 1, 0, "admin" },
                    { new Guid("61598744-b25d-4df5-901c-6816a90fc7c1"), "123456", 2, 0, "staff" },
                    { new Guid("a3e05bd6-c5e6-498b-b262-6fd2b432e574"), "123456", 0, 0, "customer" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Brand", "Catagories", "Color", "Name", "PictureLink", "Price", "Size" },
                values: new object[,]
                {
                    { new Guid("04ac8c24-df2c-4280-b98e-ba3a793993da"), "Nike", "Shoes", "Purple", "Uzui Tengen", "", 58m, 40.0 },
                    { new Guid("10823813-50f0-4a99-997e-4c3f2bc87db9"), "Nike", "Shoes", "Purple", "Airbrushed Sneakers", "", 99m, 35.0 },
                    { new Guid("431880b3-b71b-4e25-98cf-37b8fe70db0d"), "Converse", "Shoes", "Black", "Spider-Verse", "", 68m, 41.0 },
                    { new Guid("507ccc0d-a014-467b-be5f-d31be35bfbd9"), "Air Jordan", "Shoes", "Blue", "Enchanted Sponge Bob", "", 63m, 36.0 },
                    { new Guid("6e181048-f40d-4d99-b4c5-5ebcd9573282"), "Nike", "Shoes", "Red", "Electric Dream", "", 78m, 43.0 },
                    { new Guid("8ecbeb04-a84d-4692-b442-d558cd91b0de"), "Converse", "Shoes", "Black", "Arkham Knight", "", 112m, 38.0 },
                    { new Guid("9b736c8a-34f8-4eb5-814e-a993ed5c4b7d"), "Puma", "Shoes", "Purple", "Crimson Blaze", "", 46m, 45.0 },
                    { new Guid("c66f26e7-1d04-42ca-a9f6-cfff1f96ee0a"), "Autry", "Shoes", "Silver", "Silver Serpent", "", 49m, 39.0 },
                    { new Guid("c73acb7d-236f-47e7-9ad5-dfdbace55fd5"), "Converse", "Shoes", "White", "Cute", "", 55m, 40.0 },
                    { new Guid("db6535f8-d5c9-416e-a203-e16e7eed297b"), "Adidas", "Shoes", "Purple", "Nebula Burst", "", 58m, 38.0 },
                    { new Guid("f2d8f3b7-7527-4bf6-9321-aaeef0e3f410"), "Air Jordan", "Shoes", "Blue", "Lighting Thread", "", 91m, 42.0 }
                });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "Price", "Type" },
                values: new object[,]
                {
                    { new Guid("19bc013e-72eb-44f0-8ebb-ca302dfe25ed"), 20m, "Repair" },
                    { new Guid("7c4794b7-7558-4872-96fb-18f5ae4c1865"), 30m, "Customize" },
                    { new Guid("c546400f-61a3-47ef-9ba2-b99c5647ae15"), 10m, "Clean" }
                });
        }
    }
}
