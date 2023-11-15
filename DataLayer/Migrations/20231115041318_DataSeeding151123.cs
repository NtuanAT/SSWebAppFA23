using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataLayer.Migrations
{
    /// <inheritdoc />
    public partial class DataSeeding151123 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
