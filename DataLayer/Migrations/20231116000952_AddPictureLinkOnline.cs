using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataLayer.Migrations
{
    /// <inheritdoc />
    public partial class AddPictureLinkOnline : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "Password", "Role", "Status", "Username" },
                values: new object[,]
                {
                    { new Guid("4829b40c-2e09-4ec5-b3db-e919b8884255"), "123456", 1, 0, "admin" },
                    { new Guid("56d28530-dace-436b-8fe4-c78f19398a6c"), "123456", 0, 0, "customer" },
                    { new Guid("bf82dbe4-d831-4acf-8239-8be7c5c7242d"), "123456", 2, 0, "staff" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Brand", "Catagories", "Color", "Name", "PictureLink", "Price", "Size" },
                values: new object[,]
                {
                    { new Guid("023e5750-3db4-4f05-8b8e-cc64b4af6e91"), "Converse", "Shoes", "Black", "Spider-Verse", "https://i.postimg.cc/908Y2JjG/Spider-Verse.png", 68m, 41.0 },
                    { new Guid("2a1695f8-9444-4515-bff8-511cfc395df1"), "Converse", "Shoes", "Black", "Arkham Knight", "https://i.postimg.cc/MHKmggg6/Arkham-Knight.png", 112m, 38.0 },
                    { new Guid("3517934e-4ac2-446a-8953-155b5b204596"), "Air Jordan", "Shoes", "Blue", "Enchanted Sponge Bob", "https://i.postimg.cc/fWBKYT0J/Enchanted-Sponge-Bob.png", 63m, 36.0 },
                    { new Guid("35c276ea-284b-4a6b-8716-2c9cd0f8b4ad"), "Air Jordan", "Shoes", "Blue", "Lighting Thread", "https://i.postimg.cc/vmfhnrWs/Lighting-Thread.png", 91m, 42.0 },
                    { new Guid("52992dd7-feed-4964-a374-47f30ff18bec"), "Nike", "Shoes", "Purple", "Uzui Tengen", "https://i.postimg.cc/B63gBjg1/Uzui-Tengen.jpg", 58m, 40.0 },
                    { new Guid("876d6729-d111-4ac0-b0eb-47dffed05f60"), "Autry", "Shoes", "Silver", "Silver Serpent", "https://i.postimg.cc/qRGGbpbD/Silver-Serpent.png", 49m, 39.0 },
                    { new Guid("8cf2c47f-d7ba-4515-85c4-188b2c985f83"), "Converse", "Shoes", "White", "Cute", "https://i.postimg.cc/7YZKRTy3/Cute.jpg", 55m, 40.0 },
                    { new Guid("aa922975-bbd3-493c-bebc-cce4bd0a99a4"), "Adidas", "Shoes", "Purple", "Nebula Burst", "https://i.postimg.cc/SxXDSFRj/Nebula-Burst.jpg", 58m, 38.0 },
                    { new Guid("ab0ed005-c854-473b-9a19-dc50618908b5"), "Nike", "Shoes", "Purple", "Airbrushed Sneakers", "https://i.postimg.cc/VsR74W2s/Airbrushed-Sneakers.png", 99m, 35.0 },
                    { new Guid("c5f92849-5360-4526-a3cf-dd33144a0964"), "Nike", "Shoes", "Red", "Electric Dream", "https://i.postimg.cc/m2pmW2b0/Electric-Dream.png", 78m, 43.0 },
                    { new Guid("f6edd556-1196-47ab-a607-f5a5f4a05300"), "Puma", "Shoes", "Purple", "Crimson Blaze", "https://i.postimg.cc/fR65k2SC/Crimson-Blaze.png", 46m, 45.0 }
                });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "Price", "Type" },
                values: new object[,]
                {
                    { new Guid("084072f5-a298-401b-8487-cfc388c3cb7e"), 30m, "Customize" },
                    { new Guid("4c35c2c3-5716-4d76-b219-e9b3076b9525"), 20m, "Repair" },
                    { new Guid("8214a5df-37ba-4640-a251-6ef7026a57f3"), 10m, "Clean" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("4829b40c-2e09-4ec5-b3db-e919b8884255"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("56d28530-dace-436b-8fe4-c78f19398a6c"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("bf82dbe4-d831-4acf-8239-8be7c5c7242d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("023e5750-3db4-4f05-8b8e-cc64b4af6e91"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2a1695f8-9444-4515-bff8-511cfc395df1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3517934e-4ac2-446a-8953-155b5b204596"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("35c276ea-284b-4a6b-8716-2c9cd0f8b4ad"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("52992dd7-feed-4964-a374-47f30ff18bec"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("876d6729-d111-4ac0-b0eb-47dffed05f60"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8cf2c47f-d7ba-4515-85c4-188b2c985f83"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("aa922975-bbd3-493c-bebc-cce4bd0a99a4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ab0ed005-c854-473b-9a19-dc50618908b5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c5f92849-5360-4526-a3cf-dd33144a0964"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f6edd556-1196-47ab-a607-f5a5f4a05300"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("084072f5-a298-401b-8487-cfc388c3cb7e"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("4c35c2c3-5716-4d76-b219-e9b3076b9525"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("8214a5df-37ba-4640-a251-6ef7026a57f3"));

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
    }
}
