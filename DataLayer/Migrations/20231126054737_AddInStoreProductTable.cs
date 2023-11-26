using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataLayer.Migrations
{
    /// <inheritdoc />
    public partial class AddInStoreProductTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Order_Feedback",
                table: "FeedBacks");

            migrationBuilder.DropIndex(
                name: "IX_FeedBacks_OrderId",
                table: "FeedBacks");

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
                name: "Size",
                table: "Products");

            migrationBuilder.AddColumn<Guid>(
                name: "FeedBackId",
                table: "Orders",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ProductInStores",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Size = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductInStores", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Product_InStoreProduct",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "DetailId", "Password", "Role", "Status", "Username" },
                values: new object[,]
                {
                    { new Guid("31e5e9a8-f0a5-48e5-b937-3c5393daf306"), null, "123456", 2, 0, "staff" },
                    { new Guid("e9c24bff-dfec-4485-97cd-ea1c1de850dc"), null, "123456", 1, 0, "admin" },
                    { new Guid("f86570a1-dc93-445b-899c-eb376d6f7ab5"), null, "123456", 0, 0, "customer" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Brand", "Catagories", "Color", "Name", "PictureLink", "Price" },
                values: new object[,]
                {
                    { new Guid("b1b0b0a0-0b0b-0b0b-0b0b-0b0b0b0b0b0b"), "Nike", "Shoes", "Purple", "Uzui Tengen", "https://i.postimg.cc/B63gBjg1/Uzui-Tengen.jpg", 58m },
                    { new Guid("b1b0b0a0-0b0b-0b0b-0b0b-0b0b0b0b0b0c"), "Converse", "Shoes", "Black", "Spider-Verse", "https://i.postimg.cc/908Y2JjG/Spider-Verse.png", 68m },
                    { new Guid("b1b0b0a0-0b0b-0b0b-0b0b-0b0b0b0b0b0d"), "Autry", "Shoes", "Silver", "Silver Serpent", "https://i.postimg.cc/qRGGbpbD/Silver-Serpent.png", 49m },
                    { new Guid("b1b0b0a0-0b0b-0b0b-0b0b-0b0b0b0b0b0e"), "Nike", "Shoes", "Pink", "Sakura Blossom", "https://i.postimg.cc/3wZQJYQg/Sakura-Blossom.jpg", 58m },
                    { new Guid("b1b0b0a0-0b0b-0b0b-0b0b-0b0b0b0b0b0f"), "Adidas", "Shoes", "Purple", "Nebula Burst", "https://i.postimg.cc/SxXDSFRj/Nebula-Burst.jpg", 58m },
                    { new Guid("b1b0b0a0-0f0b-0b0b-0b0b-0b0b0b0b0b14"), "Nike", "Shoes", "Purple", "Airbrushed Sneakers", "https://i.postimg.cc/VsR74W2s/Airbrushed-Sneakers.png", 99m },
                    { new Guid("b1b0b0a0-0f0b-0b0b-0b0b-0b0b0b0b0b15"), "Converse", "Shoes", "Black", "Arkham Knight", "https://i.postimg.cc/MHKmggg6/Arkham-Knight.png", 112m },
                    { new Guid("b1b0b0a0-0f0b-0b0b-0b0b-0b0b0b0b0b16"), "Converse", "Shoes", "White", "Cute", "https://i.postimg.cc/7YZKRTy3/Cute.jpg", 55m },
                    { new Guid("b1b0b0a0-0f0b-0b0b-0b0b-0b0b0b0b0b1a"), "Air Jordan", "Shoes", "Blue", "Lighting Thread", "https://i.postimg.cc/vmfhnrWs/Lighting-Thread.png", 91m },
                    { new Guid("b1b0b0a0-0f0b-0b0b-0b0b-0b0b0b0b0b1b"), "Air Jordan", "Shoes", "Blue", "Enchanted Sponge Bob", "https://i.postimg.cc/fWBKYT0J/Enchanted-Sponge-Bob.png", 63m },
                    { new Guid("b1b0b0a0-0f0b-0b0b-0b0b-0b0b0b0b0b1c"), "Nike", "Shoes", "Red", "Electric Dream", "https://i.postimg.cc/m2pmW2b0/Electric-Dream.png", 78m },
                    { new Guid("b1b0b0a0-0f0b-0b0b-0b0b-0b0b0b0b0b1d"), "Puma", "Shoes", "Purple", "Crimson Blaze", "https://i.postimg.cc/fR65k2SC/Crimson-Blaze.png", 46m }
                });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "Price", "Type" },
                values: new object[,]
                {
                    { new Guid("1c4b8235-481d-4389-b78e-7d741344969e"), 10m, "Clean" },
                    { new Guid("b05c50b8-8cd9-48be-b5ca-4d1efe14dab2"), 20m, "Repair" },
                    { new Guid("b39fe7fa-a271-4ecd-816e-1c789efe6cd2"), 30m, "Customize" }
                });

            migrationBuilder.InsertData(
                table: "ProductInStores",
                columns: new[] { "Id", "ProductId", "Quantity", "Size" },
                values: new object[,]
                {
                    { new Guid("01ec8bdd-f18b-4737-bf0c-c136b3a31905"), new Guid("b1b0b0a0-0b0b-0b0b-0b0b-0b0b0b0b0b0d"), 50, 41 },
                    { new Guid("03340edb-51d5-4493-841c-11f06bd86cbf"), new Guid("b1b0b0a0-0b0b-0b0b-0b0b-0b0b0b0b0b0f"), 50, 41 },
                    { new Guid("033f00f8-543d-4bf0-9814-bd725fe3a238"), new Guid("b1b0b0a0-0f0b-0b0b-0b0b-0b0b0b0b0b1a"), 50, 41 },
                    { new Guid("0c62ffae-37b1-4697-807f-2485379472c9"), new Guid("b1b0b0a0-0f0b-0b0b-0b0b-0b0b0b0b0b16"), 50, 39 },
                    { new Guid("113fb710-5c97-4f4b-9a4e-e3379607459a"), new Guid("b1b0b0a0-0f0b-0b0b-0b0b-0b0b0b0b0b1c"), 50, 39 },
                    { new Guid("19ea6354-e92e-41dc-9d32-7414cd1e633f"), new Guid("b1b0b0a0-0f0b-0b0b-0b0b-0b0b0b0b0b16"), 100, 40 },
                    { new Guid("1c03198c-e4bd-4644-8977-ecff7afefb05"), new Guid("b1b0b0a0-0b0b-0b0b-0b0b-0b0b0b0b0b0e"), 10, 43 },
                    { new Guid("1d948b83-a954-410f-9fb3-64e5b3659e9f"), new Guid("b1b0b0a0-0f0b-0b0b-0b0b-0b0b0b0b0b14"), 100, 40 },
                    { new Guid("1fe400f4-7209-4ed1-9e2c-a1e3b85ea130"), new Guid("b1b0b0a0-0f0b-0b0b-0b0b-0b0b0b0b0b1c"), 100, 40 },
                    { new Guid("217073ab-ddcd-4ff9-83f0-561ff24340e2"), new Guid("b1b0b0a0-0b0b-0b0b-0b0b-0b0b0b0b0b0b"), 10, 43 },
                    { new Guid("23403174-9995-457a-b721-d184a1ee60f9"), new Guid("b1b0b0a0-0b0b-0b0b-0b0b-0b0b0b0b0b0f"), 50, 39 },
                    { new Guid("27b9e4f9-70f9-4e16-9a6e-39433f93dd80"), new Guid("b1b0b0a0-0f0b-0b0b-0b0b-0b0b0b0b0b14"), 50, 41 },
                    { new Guid("307b0aac-291f-4dac-884e-005d486d4b64"), new Guid("b1b0b0a0-0b0b-0b0b-0b0b-0b0b0b0b0b0e"), 100, 40 },
                    { new Guid("31983281-ecba-4fa4-a164-9562270d6049"), new Guid("b1b0b0a0-0b0b-0b0b-0b0b-0b0b0b0b0b0e"), 20, 42 },
                    { new Guid("38d1674c-38d7-4945-94d0-73c808ba61b3"), new Guid("b1b0b0a0-0b0b-0b0b-0b0b-0b0b0b0b0b0f"), 20, 42 },
                    { new Guid("49eea858-cb8c-4d42-8e15-2c100d5f798b"), new Guid("b1b0b0a0-0f0b-0b0b-0b0b-0b0b0b0b0b15"), 50, 39 },
                    { new Guid("4b7449b7-5219-4cf2-98e5-5a34d3dd1e60"), new Guid("b1b0b0a0-0b0b-0b0b-0b0b-0b0b0b0b0b0b"), 20, 42 },
                    { new Guid("500c6f5f-d265-4ee0-89a4-242c83362922"), new Guid("b1b0b0a0-0f0b-0b0b-0b0b-0b0b0b0b0b1d"), 50, 39 },
                    { new Guid("503d40dd-82a5-4c1e-af09-a57975993ba0"), new Guid("b1b0b0a0-0f0b-0b0b-0b0b-0b0b0b0b0b16"), 20, 42 },
                    { new Guid("5a7e7dd8-1d0c-4e14-ae28-98ed9d57da9e"), new Guid("b1b0b0a0-0f0b-0b0b-0b0b-0b0b0b0b0b1a"), 50, 39 },
                    { new Guid("62b7e69a-05f8-4fd1-afb2-3f16c2ed810c"), new Guid("b1b0b0a0-0b0b-0b0b-0b0b-0b0b0b0b0b0c"), 20, 42 },
                    { new Guid("65248317-9a46-4b39-8be4-086df680d2e5"), new Guid("b1b0b0a0-0b0b-0b0b-0b0b-0b0b0b0b0b0c"), 100, 40 },
                    { new Guid("66fcbe85-ff4e-47f1-8735-65c3298ab87b"), new Guid("b1b0b0a0-0f0b-0b0b-0b0b-0b0b0b0b0b16"), 50, 41 },
                    { new Guid("70f4116c-2615-4734-adea-4d95f4573779"), new Guid("b1b0b0a0-0f0b-0b0b-0b0b-0b0b0b0b0b15"), 20, 42 },
                    { new Guid("73a3d771-4d15-4a41-ae01-8cb784ba4fe0"), new Guid("b1b0b0a0-0f0b-0b0b-0b0b-0b0b0b0b0b1b"), 50, 39 },
                    { new Guid("79b0fa32-1808-4add-aa9d-8fb2cafcb22f"), new Guid("b1b0b0a0-0f0b-0b0b-0b0b-0b0b0b0b0b15"), 100, 40 },
                    { new Guid("8bf9fcbb-32c1-482e-8343-cb1082469fae"), new Guid("b1b0b0a0-0f0b-0b0b-0b0b-0b0b0b0b0b1c"), 50, 41 },
                    { new Guid("8fcc6567-59be-49df-98d6-df9a7c95f54e"), new Guid("b1b0b0a0-0b0b-0b0b-0b0b-0b0b0b0b0b0b"), 50, 41 },
                    { new Guid("96498e32-7cfa-4646-8f49-27ca356fe45f"), new Guid("b1b0b0a0-0f0b-0b0b-0b0b-0b0b0b0b0b1d"), 100, 40 },
                    { new Guid("a53a64e3-7b55-4ca7-89f4-c948e990e8bb"), new Guid("b1b0b0a0-0b0b-0b0b-0b0b-0b0b0b0b0b0c"), 10, 43 },
                    { new Guid("a8804243-d1f5-41d4-845b-ce39a1e7adee"), new Guid("b1b0b0a0-0f0b-0b0b-0b0b-0b0b0b0b0b1b"), 100, 40 },
                    { new Guid("ac74e045-5b2b-4625-a46f-0c4ea29193ba"), new Guid("b1b0b0a0-0b0b-0b0b-0b0b-0b0b0b0b0b0d"), 20, 42 },
                    { new Guid("d5e9e49e-aef5-429b-9e1e-27f62d5e20d0"), new Guid("b1b0b0a0-0b0b-0b0b-0b0b-0b0b0b0b0b0b"), 100, 40 },
                    { new Guid("d6c51133-b8a2-4fa2-90b3-a8d77f13f49a"), new Guid("b1b0b0a0-0b0b-0b0b-0b0b-0b0b0b0b0b0e"), 50, 41 },
                    { new Guid("dcd00d53-e2b3-4aad-8013-8a02efd6165c"), new Guid("b1b0b0a0-0b0b-0b0b-0b0b-0b0b0b0b0b0c"), 50, 41 },
                    { new Guid("e3876280-9507-4998-a58e-4c3f4d7feb6e"), new Guid("b1b0b0a0-0b0b-0b0b-0b0b-0b0b0b0b0b0d"), 10, 43 },
                    { new Guid("f0230887-6747-4ec7-a68b-f6ca219bb5d8"), new Guid("b1b0b0a0-0f0b-0b0b-0b0b-0b0b0b0b0b1a"), 100, 40 },
                    { new Guid("f0c042b9-d24a-418e-b926-0aa024a78069"), new Guid("b1b0b0a0-0f0b-0b0b-0b0b-0b0b0b0b0b15"), 50, 41 },
                    { new Guid("f3798d7d-5e7b-46e1-b835-39001d296df5"), new Guid("b1b0b0a0-0f0b-0b0b-0b0b-0b0b0b0b0b1c"), 20, 42 },
                    { new Guid("f5898cf1-7c28-4a1e-ae35-bb13151b148c"), new Guid("b1b0b0a0-0b0b-0b0b-0b0b-0b0b0b0b0b0d"), 100, 40 },
                    { new Guid("fb3c5d2f-f91a-4ce0-ac79-fff4b7fc510d"), new Guid("b1b0b0a0-0b0b-0b0b-0b0b-0b0b0b0b0b0f"), 100, 40 },
                    { new Guid("fbe518f7-60bd-4c1e-b77e-23e02b9fdeba"), new Guid("b1b0b0a0-0f0b-0b0b-0b0b-0b0b0b0b0b14"), 50, 39 },
                    { new Guid("ff9fd3cf-d36b-4a72-bbe3-5e3fddd86a38"), new Guid("b1b0b0a0-0f0b-0b0b-0b0b-0b0b0b0b0b1d"), 50, 41 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_FeedBackId",
                table: "Orders",
                column: "FeedBackId",
                unique: true,
                filter: "[FeedBackId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_ProductInStores_ProductId",
                table: "ProductInStores",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Feedback",
                table: "Orders",
                column: "FeedBackId",
                principalTable: "FeedBacks",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Order_Feedback",
                table: "Orders");

            migrationBuilder.DropTable(
                name: "ProductInStores");

            migrationBuilder.DropIndex(
                name: "IX_Orders_FeedBackId",
                table: "Orders");

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("31e5e9a8-f0a5-48e5-b937-3c5393daf306"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("e9c24bff-dfec-4485-97cd-ea1c1de850dc"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("f86570a1-dc93-445b-899c-eb376d6f7ab5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b1b0b0a0-0b0b-0b0b-0b0b-0b0b0b0b0b0b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b1b0b0a0-0b0b-0b0b-0b0b-0b0b0b0b0b0c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b1b0b0a0-0b0b-0b0b-0b0b-0b0b0b0b0b0d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b1b0b0a0-0b0b-0b0b-0b0b-0b0b0b0b0b0e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b1b0b0a0-0b0b-0b0b-0b0b-0b0b0b0b0b0f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b1b0b0a0-0f0b-0b0b-0b0b-0b0b0b0b0b14"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b1b0b0a0-0f0b-0b0b-0b0b-0b0b0b0b0b15"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b1b0b0a0-0f0b-0b0b-0b0b-0b0b0b0b0b16"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b1b0b0a0-0f0b-0b0b-0b0b-0b0b0b0b0b1a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b1b0b0a0-0f0b-0b0b-0b0b-0b0b0b0b0b1b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b1b0b0a0-0f0b-0b0b-0b0b-0b0b0b0b0b1c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b1b0b0a0-0f0b-0b0b-0b0b-0b0b0b0b0b1d"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("1c4b8235-481d-4389-b78e-7d741344969e"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("b05c50b8-8cd9-48be-b5ca-4d1efe14dab2"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("b39fe7fa-a271-4ecd-816e-1c789efe6cd2"));

            migrationBuilder.DropColumn(
                name: "FeedBackId",
                table: "Orders");

            migrationBuilder.AddColumn<double>(
                name: "Size",
                table: "Products",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

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

            migrationBuilder.CreateIndex(
                name: "IX_FeedBacks_OrderId",
                table: "FeedBacks",
                column: "OrderId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Feedback",
                table: "FeedBacks",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
