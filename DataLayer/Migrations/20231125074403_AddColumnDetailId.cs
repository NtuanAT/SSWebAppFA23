using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataLayer.Migrations
{
    /// <inheritdoc />
    public partial class AddColumnDetailId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<Guid>(
                name: "DetailId",
                table: "Accounts",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "DetailId", "Password", "Role", "Status", "Username" },
                values: new object[,]
                {
                    { new Guid("07a0fc21-f6bd-4501-8eb3-67ab79dde6ae"), null, "123456", 2, 0, "staff" },
                    { new Guid("5b939815-302a-4da3-826b-6fb9d5cb2f7e"), null, "123456", 0, 0, "customer" },
                    { new Guid("bdcc8ef2-f6b4-42e9-8302-4d3b4bbd582c"), null, "123456", 1, 0, "admin" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Brand", "Catagories", "Color", "Name", "PictureLink", "Price", "Size" },
                values: new object[,]
                {
                    { new Guid("13d92877-feda-4dfa-9138-3939c5b7f99a"), "Air Jordan", "Shoes", "Blue", "Enchanted Sponge Bob", "https://i.postimg.cc/fWBKYT0J/Enchanted-Sponge-Bob.png", 63m, 36.0 },
                    { new Guid("4e902198-21fb-4e5c-8484-7360fcafda8b"), "Converse", "Shoes", "White", "Cute", "https://i.postimg.cc/7YZKRTy3/Cute.jpg", 55m, 40.0 },
                    { new Guid("52190f3e-9b17-4c86-8357-bccc37e4ea1a"), "Adidas", "Shoes", "Purple", "Nebula Burst", "https://i.postimg.cc/SxXDSFRj/Nebula-Burst.jpg", 58m, 38.0 },
                    { new Guid("9d305c18-98ae-45c3-99f5-26245d8aea7b"), "Autry", "Shoes", "Silver", "Silver Serpent", "https://i.postimg.cc/qRGGbpbD/Silver-Serpent.png", 49m, 39.0 },
                    { new Guid("9d7bb671-cf9a-4b36-b9e2-4cefeda3a1d9"), "Nike", "Shoes", "Purple", "Airbrushed Sneakers", "https://i.postimg.cc/VsR74W2s/Airbrushed-Sneakers.png", 99m, 35.0 },
                    { new Guid("b234aca6-40b1-42e9-9c57-8b1a6c30d620"), "Puma", "Shoes", "Purple", "Crimson Blaze", "https://i.postimg.cc/fR65k2SC/Crimson-Blaze.png", 46m, 45.0 },
                    { new Guid("b8115ff4-4e79-48a6-aae9-7e465c4c14ce"), "Converse", "Shoes", "Black", "Spider-Verse", "https://i.postimg.cc/908Y2JjG/Spider-Verse.png", 68m, 41.0 },
                    { new Guid("b99cd9da-c037-4739-b9f6-e8e04a9c400f"), "Converse", "Shoes", "Black", "Arkham Knight", "https://i.postimg.cc/MHKmggg6/Arkham-Knight.png", 112m, 38.0 },
                    { new Guid("c64ad7fd-a3ed-4ed0-a129-c5d54860f553"), "Air Jordan", "Shoes", "Blue", "Lighting Thread", "https://i.postimg.cc/vmfhnrWs/Lighting-Thread.png", 91m, 42.0 },
                    { new Guid("cc5defbc-65df-4ec2-9d23-1566a8f325b0"), "Nike", "Shoes", "Purple", "Uzui Tengen", "https://i.postimg.cc/B63gBjg1/Uzui-Tengen.jpg", 58m, 40.0 },
                    { new Guid("e45ad433-d44e-4430-a388-3e062f67a54b"), "Nike", "Shoes", "Red", "Electric Dream", "https://i.postimg.cc/m2pmW2b0/Electric-Dream.png", 78m, 43.0 }
                });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "Price", "Type" },
                values: new object[,]
                {
                    { new Guid("30170c96-7a43-49e1-b839-3a7f50b00d97"), 30m, "Customize" },
                    { new Guid("60c24cc2-75b8-4fee-bfc6-8f84c9e1595e"), 10m, "Clean" },
                    { new Guid("ead83624-297c-4644-bb1c-c5be04ff343c"), 20m, "Repair" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("07a0fc21-f6bd-4501-8eb3-67ab79dde6ae"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("5b939815-302a-4da3-826b-6fb9d5cb2f7e"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("bdcc8ef2-f6b4-42e9-8302-4d3b4bbd582c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("13d92877-feda-4dfa-9138-3939c5b7f99a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4e902198-21fb-4e5c-8484-7360fcafda8b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("52190f3e-9b17-4c86-8357-bccc37e4ea1a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9d305c18-98ae-45c3-99f5-26245d8aea7b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9d7bb671-cf9a-4b36-b9e2-4cefeda3a1d9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b234aca6-40b1-42e9-9c57-8b1a6c30d620"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b8115ff4-4e79-48a6-aae9-7e465c4c14ce"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b99cd9da-c037-4739-b9f6-e8e04a9c400f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c64ad7fd-a3ed-4ed0-a129-c5d54860f553"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cc5defbc-65df-4ec2-9d23-1566a8f325b0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e45ad433-d44e-4430-a388-3e062f67a54b"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("30170c96-7a43-49e1-b839-3a7f50b00d97"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("60c24cc2-75b8-4fee-bfc6-8f84c9e1595e"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("ead83624-297c-4644-bb1c-c5be04ff343c"));

            migrationBuilder.DropColumn(
                name: "Message",
                table: "OrderServices");

            migrationBuilder.DropColumn(
                name: "DetailId",
                table: "Accounts");

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
    }
}
