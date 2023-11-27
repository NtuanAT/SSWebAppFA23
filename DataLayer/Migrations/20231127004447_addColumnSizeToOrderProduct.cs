using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataLayer.Migrations
{
    /// <inheritdoc />
    public partial class addColumnSizeToOrderProduct : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                table: "ProductInStores",
                keyColumn: "Id",
                keyValue: new Guid("01ec8bdd-f18b-4737-bf0c-c136b3a31905"));

            migrationBuilder.DeleteData(
                table: "ProductInStores",
                keyColumn: "Id",
                keyValue: new Guid("03340edb-51d5-4493-841c-11f06bd86cbf"));

            migrationBuilder.DeleteData(
                table: "ProductInStores",
                keyColumn: "Id",
                keyValue: new Guid("033f00f8-543d-4bf0-9814-bd725fe3a238"));

            migrationBuilder.DeleteData(
                table: "ProductInStores",
                keyColumn: "Id",
                keyValue: new Guid("0c62ffae-37b1-4697-807f-2485379472c9"));

            migrationBuilder.DeleteData(
                table: "ProductInStores",
                keyColumn: "Id",
                keyValue: new Guid("113fb710-5c97-4f4b-9a4e-e3379607459a"));

            migrationBuilder.DeleteData(
                table: "ProductInStores",
                keyColumn: "Id",
                keyValue: new Guid("19ea6354-e92e-41dc-9d32-7414cd1e633f"));

            migrationBuilder.DeleteData(
                table: "ProductInStores",
                keyColumn: "Id",
                keyValue: new Guid("1c03198c-e4bd-4644-8977-ecff7afefb05"));

            migrationBuilder.DeleteData(
                table: "ProductInStores",
                keyColumn: "Id",
                keyValue: new Guid("1d948b83-a954-410f-9fb3-64e5b3659e9f"));

            migrationBuilder.DeleteData(
                table: "ProductInStores",
                keyColumn: "Id",
                keyValue: new Guid("1fe400f4-7209-4ed1-9e2c-a1e3b85ea130"));

            migrationBuilder.DeleteData(
                table: "ProductInStores",
                keyColumn: "Id",
                keyValue: new Guid("217073ab-ddcd-4ff9-83f0-561ff24340e2"));

            migrationBuilder.DeleteData(
                table: "ProductInStores",
                keyColumn: "Id",
                keyValue: new Guid("23403174-9995-457a-b721-d184a1ee60f9"));

            migrationBuilder.DeleteData(
                table: "ProductInStores",
                keyColumn: "Id",
                keyValue: new Guid("27b9e4f9-70f9-4e16-9a6e-39433f93dd80"));

            migrationBuilder.DeleteData(
                table: "ProductInStores",
                keyColumn: "Id",
                keyValue: new Guid("307b0aac-291f-4dac-884e-005d486d4b64"));

            migrationBuilder.DeleteData(
                table: "ProductInStores",
                keyColumn: "Id",
                keyValue: new Guid("31983281-ecba-4fa4-a164-9562270d6049"));

            migrationBuilder.DeleteData(
                table: "ProductInStores",
                keyColumn: "Id",
                keyValue: new Guid("38d1674c-38d7-4945-94d0-73c808ba61b3"));

            migrationBuilder.DeleteData(
                table: "ProductInStores",
                keyColumn: "Id",
                keyValue: new Guid("49eea858-cb8c-4d42-8e15-2c100d5f798b"));

            migrationBuilder.DeleteData(
                table: "ProductInStores",
                keyColumn: "Id",
                keyValue: new Guid("4b7449b7-5219-4cf2-98e5-5a34d3dd1e60"));

            migrationBuilder.DeleteData(
                table: "ProductInStores",
                keyColumn: "Id",
                keyValue: new Guid("500c6f5f-d265-4ee0-89a4-242c83362922"));

            migrationBuilder.DeleteData(
                table: "ProductInStores",
                keyColumn: "Id",
                keyValue: new Guid("503d40dd-82a5-4c1e-af09-a57975993ba0"));

            migrationBuilder.DeleteData(
                table: "ProductInStores",
                keyColumn: "Id",
                keyValue: new Guid("5a7e7dd8-1d0c-4e14-ae28-98ed9d57da9e"));

            migrationBuilder.DeleteData(
                table: "ProductInStores",
                keyColumn: "Id",
                keyValue: new Guid("62b7e69a-05f8-4fd1-afb2-3f16c2ed810c"));

            migrationBuilder.DeleteData(
                table: "ProductInStores",
                keyColumn: "Id",
                keyValue: new Guid("65248317-9a46-4b39-8be4-086df680d2e5"));

            migrationBuilder.DeleteData(
                table: "ProductInStores",
                keyColumn: "Id",
                keyValue: new Guid("66fcbe85-ff4e-47f1-8735-65c3298ab87b"));

            migrationBuilder.DeleteData(
                table: "ProductInStores",
                keyColumn: "Id",
                keyValue: new Guid("70f4116c-2615-4734-adea-4d95f4573779"));

            migrationBuilder.DeleteData(
                table: "ProductInStores",
                keyColumn: "Id",
                keyValue: new Guid("73a3d771-4d15-4a41-ae01-8cb784ba4fe0"));

            migrationBuilder.DeleteData(
                table: "ProductInStores",
                keyColumn: "Id",
                keyValue: new Guid("79b0fa32-1808-4add-aa9d-8fb2cafcb22f"));

            migrationBuilder.DeleteData(
                table: "ProductInStores",
                keyColumn: "Id",
                keyValue: new Guid("8bf9fcbb-32c1-482e-8343-cb1082469fae"));

            migrationBuilder.DeleteData(
                table: "ProductInStores",
                keyColumn: "Id",
                keyValue: new Guid("8fcc6567-59be-49df-98d6-df9a7c95f54e"));

            migrationBuilder.DeleteData(
                table: "ProductInStores",
                keyColumn: "Id",
                keyValue: new Guid("96498e32-7cfa-4646-8f49-27ca356fe45f"));

            migrationBuilder.DeleteData(
                table: "ProductInStores",
                keyColumn: "Id",
                keyValue: new Guid("a53a64e3-7b55-4ca7-89f4-c948e990e8bb"));

            migrationBuilder.DeleteData(
                table: "ProductInStores",
                keyColumn: "Id",
                keyValue: new Guid("a8804243-d1f5-41d4-845b-ce39a1e7adee"));

            migrationBuilder.DeleteData(
                table: "ProductInStores",
                keyColumn: "Id",
                keyValue: new Guid("ac74e045-5b2b-4625-a46f-0c4ea29193ba"));

            migrationBuilder.DeleteData(
                table: "ProductInStores",
                keyColumn: "Id",
                keyValue: new Guid("d5e9e49e-aef5-429b-9e1e-27f62d5e20d0"));

            migrationBuilder.DeleteData(
                table: "ProductInStores",
                keyColumn: "Id",
                keyValue: new Guid("d6c51133-b8a2-4fa2-90b3-a8d77f13f49a"));

            migrationBuilder.DeleteData(
                table: "ProductInStores",
                keyColumn: "Id",
                keyValue: new Guid("dcd00d53-e2b3-4aad-8013-8a02efd6165c"));

            migrationBuilder.DeleteData(
                table: "ProductInStores",
                keyColumn: "Id",
                keyValue: new Guid("e3876280-9507-4998-a58e-4c3f4d7feb6e"));

            migrationBuilder.DeleteData(
                table: "ProductInStores",
                keyColumn: "Id",
                keyValue: new Guid("f0230887-6747-4ec7-a68b-f6ca219bb5d8"));

            migrationBuilder.DeleteData(
                table: "ProductInStores",
                keyColumn: "Id",
                keyValue: new Guid("f0c042b9-d24a-418e-b926-0aa024a78069"));

            migrationBuilder.DeleteData(
                table: "ProductInStores",
                keyColumn: "Id",
                keyValue: new Guid("f3798d7d-5e7b-46e1-b835-39001d296df5"));

            migrationBuilder.DeleteData(
                table: "ProductInStores",
                keyColumn: "Id",
                keyValue: new Guid("f5898cf1-7c28-4a1e-ae35-bb13151b148c"));

            migrationBuilder.DeleteData(
                table: "ProductInStores",
                keyColumn: "Id",
                keyValue: new Guid("fb3c5d2f-f91a-4ce0-ac79-fff4b7fc510d"));

            migrationBuilder.DeleteData(
                table: "ProductInStores",
                keyColumn: "Id",
                keyValue: new Guid("fbe518f7-60bd-4c1e-b77e-23e02b9fdeba"));

            migrationBuilder.DeleteData(
                table: "ProductInStores",
                keyColumn: "Id",
                keyValue: new Guid("ff9fd3cf-d36b-4a72-bbe3-5e3fddd86a38"));

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

            migrationBuilder.AddColumn<int>(
                name: "Size",
                table: "OderProducts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "DetailId", "Password", "Role", "Status", "Username" },
                values: new object[,]
                {
                    { new Guid("117e2ca0-ac44-4aeb-b406-d3e4b24764f2"), null, "123456", 0, 0, "customer" },
                    { new Guid("1d906e11-843e-463f-a074-a69f88a6da3f"), null, "123456", 2, 0, "staff" },
                    { new Guid("a6eb62e2-3d04-4bcc-8c03-62528503ba59"), null, "123456", 1, 0, "admin" }
                });

            migrationBuilder.InsertData(
                table: "ProductInStores",
                columns: new[] { "Id", "ProductId", "Quantity", "Size" },
                values: new object[,]
                {
                    { new Guid("02a84c5d-5c54-4152-a984-c56d9e2add16"), new Guid("b1b0b0a0-0f0b-0b0b-0b0b-0b0b0b0b0b16"), 20, 42 },
                    { new Guid("03a75d63-8983-44c5-a754-3e3ff127f17e"), new Guid("b1b0b0a0-0b0b-0b0b-0b0b-0b0b0b0b0b0c"), 10, 43 },
                    { new Guid("14eb92b7-cf8c-4e8c-9689-53c15c0556a4"), new Guid("b1b0b0a0-0f0b-0b0b-0b0b-0b0b0b0b0b1d"), 50, 39 },
                    { new Guid("15fffc34-4395-47d8-86aa-db6c9fd8b433"), new Guid("b1b0b0a0-0f0b-0b0b-0b0b-0b0b0b0b0b14"), 100, 40 },
                    { new Guid("168220b2-a1ed-48ba-bb0f-20323e7a23e7"), new Guid("b1b0b0a0-0f0b-0b0b-0b0b-0b0b0b0b0b16"), 50, 41 },
                    { new Guid("1b0209d9-1a4e-4d9d-956b-0300318f8209"), new Guid("b1b0b0a0-0f0b-0b0b-0b0b-0b0b0b0b0b1a"), 100, 40 },
                    { new Guid("2e3c639e-853f-43a5-8f69-cbc3f3f2c509"), new Guid("b1b0b0a0-0f0b-0b0b-0b0b-0b0b0b0b0b15"), 50, 39 },
                    { new Guid("3075a4ab-0a3d-452e-92f6-fdf934a8b23f"), new Guid("b1b0b0a0-0b0b-0b0b-0b0b-0b0b0b0b0b0b"), 100, 40 },
                    { new Guid("31ff6022-72f1-42f9-b13c-eaba7cd3f720"), new Guid("b1b0b0a0-0b0b-0b0b-0b0b-0b0b0b0b0b0e"), 100, 40 },
                    { new Guid("32984a97-c983-4f32-a2cb-806b8471d164"), new Guid("b1b0b0a0-0f0b-0b0b-0b0b-0b0b0b0b0b1d"), 50, 41 },
                    { new Guid("3538c17a-7e34-4bd6-a4a4-5b90663c4d6f"), new Guid("b1b0b0a0-0f0b-0b0b-0b0b-0b0b0b0b0b15"), 50, 41 },
                    { new Guid("3adb4629-97cd-4aa4-a873-0d10c04ba432"), new Guid("b1b0b0a0-0f0b-0b0b-0b0b-0b0b0b0b0b14"), 50, 39 },
                    { new Guid("3def1da9-0ebb-430c-a8c4-0a5c6184d000"), new Guid("b1b0b0a0-0b0b-0b0b-0b0b-0b0b0b0b0b0e"), 20, 42 },
                    { new Guid("3f978159-0ca2-4d23-a961-765df2ced51b"), new Guid("b1b0b0a0-0f0b-0b0b-0b0b-0b0b0b0b0b14"), 50, 41 },
                    { new Guid("3fb8e59a-2104-4256-b79d-328904a3ec87"), new Guid("b1b0b0a0-0f0b-0b0b-0b0b-0b0b0b0b0b16"), 100, 40 },
                    { new Guid("40b6b7dd-fd6e-4d09-87c6-a8f445e73217"), new Guid("b1b0b0a0-0b0b-0b0b-0b0b-0b0b0b0b0b0b"), 50, 41 },
                    { new Guid("4207743a-2c3e-4731-bb7f-dbc128210f40"), new Guid("b1b0b0a0-0b0b-0b0b-0b0b-0b0b0b0b0b0d"), 100, 40 },
                    { new Guid("4ceddbbf-2347-4691-b33b-1d7e7b8b451d"), new Guid("b1b0b0a0-0f0b-0b0b-0b0b-0b0b0b0b0b1a"), 50, 39 },
                    { new Guid("50f54c91-6b12-4689-b8ea-7b297e4709e6"), new Guid("b1b0b0a0-0b0b-0b0b-0b0b-0b0b0b0b0b0f"), 100, 40 },
                    { new Guid("539afa7e-cc0b-4034-bc0d-84e0036cb376"), new Guid("b1b0b0a0-0f0b-0b0b-0b0b-0b0b0b0b0b1c"), 100, 40 },
                    { new Guid("55762b56-418b-4432-bb16-7510ea147c1c"), new Guid("b1b0b0a0-0b0b-0b0b-0b0b-0b0b0b0b0b0d"), 50, 41 },
                    { new Guid("60a1febf-9e02-4257-b141-114a15769810"), new Guid("b1b0b0a0-0b0b-0b0b-0b0b-0b0b0b0b0b0c"), 50, 41 },
                    { new Guid("62126987-002e-4231-a202-3463c0b6d0c7"), new Guid("b1b0b0a0-0b0b-0b0b-0b0b-0b0b0b0b0b0b"), 10, 43 },
                    { new Guid("698abb5e-16d1-4f7f-a346-1d0c7c1f54fc"), new Guid("b1b0b0a0-0b0b-0b0b-0b0b-0b0b0b0b0b0d"), 20, 42 },
                    { new Guid("763c7b5b-91ff-4002-ab8d-ad88c1b977f5"), new Guid("b1b0b0a0-0b0b-0b0b-0b0b-0b0b0b0b0b0e"), 50, 41 },
                    { new Guid("7a9d063f-ee9f-4312-806a-8f9ae8aff814"), new Guid("b1b0b0a0-0b0b-0b0b-0b0b-0b0b0b0b0b0f"), 50, 39 },
                    { new Guid("7cff2765-0c5d-4554-b253-ace77fc4e12c"), new Guid("b1b0b0a0-0f0b-0b0b-0b0b-0b0b0b0b0b1d"), 100, 40 },
                    { new Guid("7e09d769-b46e-4397-98f9-8fd8cdf2d067"), new Guid("b1b0b0a0-0b0b-0b0b-0b0b-0b0b0b0b0b0b"), 20, 42 },
                    { new Guid("8133167a-61b2-4126-a8e7-65a890e1e235"), new Guid("b1b0b0a0-0f0b-0b0b-0b0b-0b0b0b0b0b1a"), 50, 41 },
                    { new Guid("8445b3af-6aad-4ab2-89ef-c76ddb2b8a03"), new Guid("b1b0b0a0-0f0b-0b0b-0b0b-0b0b0b0b0b15"), 20, 42 },
                    { new Guid("8aa65e2b-0e35-458c-af53-bdf5bd2d850a"), new Guid("b1b0b0a0-0b0b-0b0b-0b0b-0b0b0b0b0b0d"), 10, 43 },
                    { new Guid("8d845883-8f05-4a7e-85d6-6ab4cc3c5f31"), new Guid("b1b0b0a0-0b0b-0b0b-0b0b-0b0b0b0b0b0f"), 20, 42 },
                    { new Guid("93447964-eb09-474f-93bc-6df5445a21fd"), new Guid("b1b0b0a0-0b0b-0b0b-0b0b-0b0b0b0b0b0f"), 50, 41 },
                    { new Guid("94e5bb88-b280-4af8-926a-0d861ff25afd"), new Guid("b1b0b0a0-0b0b-0b0b-0b0b-0b0b0b0b0b0c"), 20, 42 },
                    { new Guid("9f61b00d-c8c2-4c96-bd13-9e9d933d448f"), new Guid("b1b0b0a0-0f0b-0b0b-0b0b-0b0b0b0b0b1b"), 50, 39 },
                    { new Guid("a0ba14a8-e2b5-4b6d-9b58-c9e69f6fbfe3"), new Guid("b1b0b0a0-0b0b-0b0b-0b0b-0b0b0b0b0b0e"), 10, 43 },
                    { new Guid("ab1b34ad-33df-429e-b390-054c17d9c297"), new Guid("b1b0b0a0-0f0b-0b0b-0b0b-0b0b0b0b0b16"), 50, 39 },
                    { new Guid("ade5e87d-551d-4639-8159-2f78868de6b8"), new Guid("b1b0b0a0-0f0b-0b0b-0b0b-0b0b0b0b0b1c"), 20, 42 },
                    { new Guid("b8e03daa-bebe-40f4-a128-ca27da9c013f"), new Guid("b1b0b0a0-0f0b-0b0b-0b0b-0b0b0b0b0b1b"), 100, 40 },
                    { new Guid("bdfe324e-dd95-4177-a6db-dc16b06cfa17"), new Guid("b1b0b0a0-0f0b-0b0b-0b0b-0b0b0b0b0b15"), 100, 40 },
                    { new Guid("d4293eba-2b11-47ce-b520-7a1260d6ec1d"), new Guid("b1b0b0a0-0f0b-0b0b-0b0b-0b0b0b0b0b1c"), 50, 39 },
                    { new Guid("da665e8a-004a-4744-876c-a4bfd3efca66"), new Guid("b1b0b0a0-0b0b-0b0b-0b0b-0b0b0b0b0b0c"), 100, 40 },
                    { new Guid("e59ae021-63c5-43dd-bf7d-02b0ce9127a9"), new Guid("b1b0b0a0-0f0b-0b0b-0b0b-0b0b0b0b0b1c"), 50, 41 }
                });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "Price", "Type" },
                values: new object[,]
                {
                    { new Guid("2573361f-ffdc-4817-bc6c-1114369e31da"), 30m, "Customize" },
                    { new Guid("9a5b493d-7d0d-4cd7-bd23-f006636ee9a0"), 20m, "Repair" },
                    { new Guid("be04671b-3dc8-4198-8a6a-e35a4a56ff15"), 10m, "Clean" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("117e2ca0-ac44-4aeb-b406-d3e4b24764f2"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("1d906e11-843e-463f-a074-a69f88a6da3f"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("a6eb62e2-3d04-4bcc-8c03-62528503ba59"));

            migrationBuilder.DeleteData(
                table: "ProductInStores",
                keyColumn: "Id",
                keyValue: new Guid("02a84c5d-5c54-4152-a984-c56d9e2add16"));

            migrationBuilder.DeleteData(
                table: "ProductInStores",
                keyColumn: "Id",
                keyValue: new Guid("03a75d63-8983-44c5-a754-3e3ff127f17e"));

            migrationBuilder.DeleteData(
                table: "ProductInStores",
                keyColumn: "Id",
                keyValue: new Guid("14eb92b7-cf8c-4e8c-9689-53c15c0556a4"));

            migrationBuilder.DeleteData(
                table: "ProductInStores",
                keyColumn: "Id",
                keyValue: new Guid("15fffc34-4395-47d8-86aa-db6c9fd8b433"));

            migrationBuilder.DeleteData(
                table: "ProductInStores",
                keyColumn: "Id",
                keyValue: new Guid("168220b2-a1ed-48ba-bb0f-20323e7a23e7"));

            migrationBuilder.DeleteData(
                table: "ProductInStores",
                keyColumn: "Id",
                keyValue: new Guid("1b0209d9-1a4e-4d9d-956b-0300318f8209"));

            migrationBuilder.DeleteData(
                table: "ProductInStores",
                keyColumn: "Id",
                keyValue: new Guid("2e3c639e-853f-43a5-8f69-cbc3f3f2c509"));

            migrationBuilder.DeleteData(
                table: "ProductInStores",
                keyColumn: "Id",
                keyValue: new Guid("3075a4ab-0a3d-452e-92f6-fdf934a8b23f"));

            migrationBuilder.DeleteData(
                table: "ProductInStores",
                keyColumn: "Id",
                keyValue: new Guid("31ff6022-72f1-42f9-b13c-eaba7cd3f720"));

            migrationBuilder.DeleteData(
                table: "ProductInStores",
                keyColumn: "Id",
                keyValue: new Guid("32984a97-c983-4f32-a2cb-806b8471d164"));

            migrationBuilder.DeleteData(
                table: "ProductInStores",
                keyColumn: "Id",
                keyValue: new Guid("3538c17a-7e34-4bd6-a4a4-5b90663c4d6f"));

            migrationBuilder.DeleteData(
                table: "ProductInStores",
                keyColumn: "Id",
                keyValue: new Guid("3adb4629-97cd-4aa4-a873-0d10c04ba432"));

            migrationBuilder.DeleteData(
                table: "ProductInStores",
                keyColumn: "Id",
                keyValue: new Guid("3def1da9-0ebb-430c-a8c4-0a5c6184d000"));

            migrationBuilder.DeleteData(
                table: "ProductInStores",
                keyColumn: "Id",
                keyValue: new Guid("3f978159-0ca2-4d23-a961-765df2ced51b"));

            migrationBuilder.DeleteData(
                table: "ProductInStores",
                keyColumn: "Id",
                keyValue: new Guid("3fb8e59a-2104-4256-b79d-328904a3ec87"));

            migrationBuilder.DeleteData(
                table: "ProductInStores",
                keyColumn: "Id",
                keyValue: new Guid("40b6b7dd-fd6e-4d09-87c6-a8f445e73217"));

            migrationBuilder.DeleteData(
                table: "ProductInStores",
                keyColumn: "Id",
                keyValue: new Guid("4207743a-2c3e-4731-bb7f-dbc128210f40"));

            migrationBuilder.DeleteData(
                table: "ProductInStores",
                keyColumn: "Id",
                keyValue: new Guid("4ceddbbf-2347-4691-b33b-1d7e7b8b451d"));

            migrationBuilder.DeleteData(
                table: "ProductInStores",
                keyColumn: "Id",
                keyValue: new Guid("50f54c91-6b12-4689-b8ea-7b297e4709e6"));

            migrationBuilder.DeleteData(
                table: "ProductInStores",
                keyColumn: "Id",
                keyValue: new Guid("539afa7e-cc0b-4034-bc0d-84e0036cb376"));

            migrationBuilder.DeleteData(
                table: "ProductInStores",
                keyColumn: "Id",
                keyValue: new Guid("55762b56-418b-4432-bb16-7510ea147c1c"));

            migrationBuilder.DeleteData(
                table: "ProductInStores",
                keyColumn: "Id",
                keyValue: new Guid("60a1febf-9e02-4257-b141-114a15769810"));

            migrationBuilder.DeleteData(
                table: "ProductInStores",
                keyColumn: "Id",
                keyValue: new Guid("62126987-002e-4231-a202-3463c0b6d0c7"));

            migrationBuilder.DeleteData(
                table: "ProductInStores",
                keyColumn: "Id",
                keyValue: new Guid("698abb5e-16d1-4f7f-a346-1d0c7c1f54fc"));

            migrationBuilder.DeleteData(
                table: "ProductInStores",
                keyColumn: "Id",
                keyValue: new Guid("763c7b5b-91ff-4002-ab8d-ad88c1b977f5"));

            migrationBuilder.DeleteData(
                table: "ProductInStores",
                keyColumn: "Id",
                keyValue: new Guid("7a9d063f-ee9f-4312-806a-8f9ae8aff814"));

            migrationBuilder.DeleteData(
                table: "ProductInStores",
                keyColumn: "Id",
                keyValue: new Guid("7cff2765-0c5d-4554-b253-ace77fc4e12c"));

            migrationBuilder.DeleteData(
                table: "ProductInStores",
                keyColumn: "Id",
                keyValue: new Guid("7e09d769-b46e-4397-98f9-8fd8cdf2d067"));

            migrationBuilder.DeleteData(
                table: "ProductInStores",
                keyColumn: "Id",
                keyValue: new Guid("8133167a-61b2-4126-a8e7-65a890e1e235"));

            migrationBuilder.DeleteData(
                table: "ProductInStores",
                keyColumn: "Id",
                keyValue: new Guid("8445b3af-6aad-4ab2-89ef-c76ddb2b8a03"));

            migrationBuilder.DeleteData(
                table: "ProductInStores",
                keyColumn: "Id",
                keyValue: new Guid("8aa65e2b-0e35-458c-af53-bdf5bd2d850a"));

            migrationBuilder.DeleteData(
                table: "ProductInStores",
                keyColumn: "Id",
                keyValue: new Guid("8d845883-8f05-4a7e-85d6-6ab4cc3c5f31"));

            migrationBuilder.DeleteData(
                table: "ProductInStores",
                keyColumn: "Id",
                keyValue: new Guid("93447964-eb09-474f-93bc-6df5445a21fd"));

            migrationBuilder.DeleteData(
                table: "ProductInStores",
                keyColumn: "Id",
                keyValue: new Guid("94e5bb88-b280-4af8-926a-0d861ff25afd"));

            migrationBuilder.DeleteData(
                table: "ProductInStores",
                keyColumn: "Id",
                keyValue: new Guid("9f61b00d-c8c2-4c96-bd13-9e9d933d448f"));

            migrationBuilder.DeleteData(
                table: "ProductInStores",
                keyColumn: "Id",
                keyValue: new Guid("a0ba14a8-e2b5-4b6d-9b58-c9e69f6fbfe3"));

            migrationBuilder.DeleteData(
                table: "ProductInStores",
                keyColumn: "Id",
                keyValue: new Guid("ab1b34ad-33df-429e-b390-054c17d9c297"));

            migrationBuilder.DeleteData(
                table: "ProductInStores",
                keyColumn: "Id",
                keyValue: new Guid("ade5e87d-551d-4639-8159-2f78868de6b8"));

            migrationBuilder.DeleteData(
                table: "ProductInStores",
                keyColumn: "Id",
                keyValue: new Guid("b8e03daa-bebe-40f4-a128-ca27da9c013f"));

            migrationBuilder.DeleteData(
                table: "ProductInStores",
                keyColumn: "Id",
                keyValue: new Guid("bdfe324e-dd95-4177-a6db-dc16b06cfa17"));

            migrationBuilder.DeleteData(
                table: "ProductInStores",
                keyColumn: "Id",
                keyValue: new Guid("d4293eba-2b11-47ce-b520-7a1260d6ec1d"));

            migrationBuilder.DeleteData(
                table: "ProductInStores",
                keyColumn: "Id",
                keyValue: new Guid("da665e8a-004a-4744-876c-a4bfd3efca66"));

            migrationBuilder.DeleteData(
                table: "ProductInStores",
                keyColumn: "Id",
                keyValue: new Guid("e59ae021-63c5-43dd-bf7d-02b0ce9127a9"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("2573361f-ffdc-4817-bc6c-1114369e31da"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("9a5b493d-7d0d-4cd7-bd23-f006636ee9a0"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("be04671b-3dc8-4198-8a6a-e35a4a56ff15"));

            migrationBuilder.DropColumn(
                name: "Size",
                table: "OderProducts");

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

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "Price", "Type" },
                values: new object[,]
                {
                    { new Guid("1c4b8235-481d-4389-b78e-7d741344969e"), 10m, "Clean" },
                    { new Guid("b05c50b8-8cd9-48be-b5ca-4d1efe14dab2"), 20m, "Repair" },
                    { new Guid("b39fe7fa-a271-4ecd-816e-1c789efe6cd2"), 30m, "Customize" }
                });
        }
    }
}
