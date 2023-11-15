using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataLayer.Migrations
{
    /// <inheritdoc />
    public partial class AddOrderServiceMessage : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "Message",
                table: "OrderServices",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "Password", "Role", "Status", "Username" },
                values: new object[,]
                {
                    { new Guid("24a8167b-d203-45ab-ac13-7d8dc20d218a"), "123456", 2, 0, "staff" },
                    { new Guid("7cbddc11-8ada-4f77-a1c4-15a9b2cdd4e7"), "123456", 1, 0, "admin" },
                    { new Guid("c0280d04-78fc-4494-b4fb-236bf19a9fb1"), "123456", 0, 0, "customer" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Brand", "Catagories", "Color", "Name", "PictureLink", "Price", "Size" },
                values: new object[,]
                {
                    { new Guid("0a8efb32-d30f-43cb-88be-2e6f0c7364bf"), "Nike", "Shoes", "Purple", "Uzui Tengen", "", 58m, 40.0 },
                    { new Guid("19d4c64d-431b-462c-8015-9378504c6233"), "Puma", "Shoes", "Purple", "Crimson Blaze", "", 46m, 45.0 },
                    { new Guid("33ec152d-d48d-4f1f-8982-97567a2c6f45"), "Adidas", "Shoes", "Purple", "Nebula Burst", "", 58m, 38.0 },
                    { new Guid("48d32d4f-6cec-430f-a293-ec87a4af00fa"), "Converse", "Shoes", "Black", "Arkham Knight", "", 112m, 38.0 },
                    { new Guid("64c6ef64-f052-4196-ac39-a9e224e69044"), "Converse", "Shoes", "White", "Cute", "", 55m, 40.0 },
                    { new Guid("66412cd7-d61d-4cf0-8a49-bb5f5d5ec5f7"), "Air Jordan", "Shoes", "Blue", "Enchanted Sponge Bob", "", 63m, 36.0 },
                    { new Guid("c371d6e4-06a7-40ed-9dc4-d5f1cdd9ce4c"), "Converse", "Shoes", "Black", "Spider-Verse", "", 68m, 41.0 },
                    { new Guid("c79eb95e-485a-4139-bd22-157a7facd2e5"), "Nike", "Shoes", "Red", "Electric Dream", "", 78m, 43.0 },
                    { new Guid("cc75bd69-8c51-4041-a6de-3c184605a76c"), "Nike", "Shoes", "Purple", "Airbrushed Sneakers", "", 99m, 35.0 },
                    { new Guid("eff48829-57c8-470b-9f6e-ef7ed2891092"), "Autry", "Shoes", "Silver", "Silver Serpent", "", 49m, 39.0 },
                    { new Guid("ff57f8c7-b7c6-4dbb-86f0-7f3d1e36f5d2"), "Air Jordan", "Shoes", "Blue", "Lighting Thread", "", 91m, 42.0 }
                });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "Price", "Type" },
                values: new object[,]
                {
                    { new Guid("207c5b14-28a3-4c82-906c-3fb51d9f2d5d"), 10m, "Clean" },
                    { new Guid("4d0fcd67-cdc7-4e78-bc06-c4aab30ca996"), 20m, "Repair" },
                    { new Guid("5e6cd7b7-8991-4eae-82e9-349b6306f121"), 30m, "Customize" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("24a8167b-d203-45ab-ac13-7d8dc20d218a"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("7cbddc11-8ada-4f77-a1c4-15a9b2cdd4e7"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("c0280d04-78fc-4494-b4fb-236bf19a9fb1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0a8efb32-d30f-43cb-88be-2e6f0c7364bf"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("19d4c64d-431b-462c-8015-9378504c6233"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("33ec152d-d48d-4f1f-8982-97567a2c6f45"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("48d32d4f-6cec-430f-a293-ec87a4af00fa"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("64c6ef64-f052-4196-ac39-a9e224e69044"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("66412cd7-d61d-4cf0-8a49-bb5f5d5ec5f7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c371d6e4-06a7-40ed-9dc4-d5f1cdd9ce4c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c79eb95e-485a-4139-bd22-157a7facd2e5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cc75bd69-8c51-4041-a6de-3c184605a76c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("eff48829-57c8-470b-9f6e-ef7ed2891092"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ff57f8c7-b7c6-4dbb-86f0-7f3d1e36f5d2"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("207c5b14-28a3-4c82-906c-3fb51d9f2d5d"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("4d0fcd67-cdc7-4e78-bc06-c4aab30ca996"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("5e6cd7b7-8991-4eae-82e9-349b6306f121"));

            migrationBuilder.DropColumn(
                name: "Message",
                table: "OrderServices");

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
    }
}
