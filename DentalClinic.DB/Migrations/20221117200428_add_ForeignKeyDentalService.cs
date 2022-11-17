using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DentalClinic.DB.Migrations
{
    public partial class add_ForeignKeyDentalService : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DentalServices_AspNetUsers_UsersId",
                table: "DentalServices");

            migrationBuilder.DropIndex(
                name: "IX_DentalServices_UsersId",
                table: "DentalServices");

            migrationBuilder.DeleteData(
                table: "DentalServices",
                keyColumn: "Id",
                keyValue: new Guid("7332e0f4-ddf3-4503-9adc-19f9c68069fe"));

            migrationBuilder.DeleteData(
                table: "DentalServices",
                keyColumn: "Id",
                keyValue: new Guid("838c61b9-34e3-4144-8a4e-267e43a129af"));

            migrationBuilder.DeleteData(
                table: "DentalServices",
                keyColumn: "Id",
                keyValue: new Guid("904abf19-2c82-4219-8efa-dc2f7187ca2a"));

            migrationBuilder.DeleteData(
                table: "DentalServices",
                keyColumn: "Id",
                keyValue: new Guid("935d4813-1b12-4851-9e96-d38bc6fb6485"));

            migrationBuilder.DeleteData(
                table: "DentalServices",
                keyColumn: "Id",
                keyValue: new Guid("a9c1c0c9-8829-4ee4-96cd-c00aafff8c15"));

            migrationBuilder.DeleteData(
                table: "DentalServices",
                keyColumn: "Id",
                keyValue: new Guid("be40ed1a-1df9-4a81-b18a-c31575386aa4"));

            migrationBuilder.DeleteData(
                table: "DentalServices",
                keyColumn: "Id",
                keyValue: new Guid("c32463e5-baa8-41c7-9845-57cf64b2ac43"));

            migrationBuilder.DeleteData(
                table: "DentalServices",
                keyColumn: "Id",
                keyValue: new Guid("c47cf11f-2e5d-4c01-be9f-825540632bdc"));

            migrationBuilder.DeleteData(
                table: "DentalServices",
                keyColumn: "Id",
                keyValue: new Guid("d1a71a51-115e-45ff-920d-4bdcbace3808"));

            migrationBuilder.DeleteData(
                table: "DentalServices",
                keyColumn: "Id",
                keyValue: new Guid("d499a064-7b5d-4545-acd3-124931b49467"));

            migrationBuilder.DeleteData(
                table: "DentalServices",
                keyColumn: "Id",
                keyValue: new Guid("d7defb1a-61a4-4778-bd59-efd8c29b7480"));

            migrationBuilder.DeleteData(
                table: "DentalServices",
                keyColumn: "Id",
                keyValue: new Guid("eddcbac0-1294-4697-a3b9-f6e96e016d46"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("9c4a6ec7-afec-46b9-8d93-06642c86afb9"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("a83e5005-97e8-4250-97ff-d4682f269f86"));

            migrationBuilder.DropColumn(
                name: "UsersId",
                table: "DentalServices");

            migrationBuilder.AlterColumn<string>(
                name: "Who",
                table: "DentalServices",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "DentalServices",
                columns: new[] { "Id", "ServiceDescription", "ServiceName", "When", "Who" },
                values: new object[,]
                {
                    { new Guid("034d9d6b-b8d1-406b-9e74-f298c52b501d"), "", "Teeth whitening", new DateTime(2022, 11, 17, 22, 4, 27, 596, DateTimeKind.Local).AddTicks(5687), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" },
                    { new Guid("05af64a7-f3eb-4e54-adf6-c1e576fbd056"), "", "Ceramic inlays", new DateTime(2022, 11, 17, 22, 4, 27, 596, DateTimeKind.Local).AddTicks(5673), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" },
                    { new Guid("2b7ea6d0-30cc-4f13-b936-f6b7fbfad382"), "", "Tooth extraction", new DateTime(2022, 11, 17, 22, 4, 27, 596, DateTimeKind.Local).AddTicks(5678), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" },
                    { new Guid("58480d1c-ed96-407e-a965-f0a78810f438"), "", "Prosthesis", new DateTime(2022, 11, 17, 22, 4, 27, 596, DateTimeKind.Local).AddTicks(5681), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" },
                    { new Guid("7139732d-2462-41f7-8045-ed365317b43b"), "", "Orthodontic treatment/braces and splints", new DateTime(2022, 11, 17, 22, 4, 27, 596, DateTimeKind.Local).AddTicks(5685), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" },
                    { new Guid("7fda6066-d333-4c57-8238-72fe592f56e6"), "", "Dental implants", new DateTime(2022, 11, 17, 22, 4, 27, 596, DateTimeKind.Local).AddTicks(5647), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" },
                    { new Guid("8b3dd26c-c1d1-4a30-9a5a-edd46c4c19d2"), "", "Aesthetic fillings", new DateTime(2022, 11, 17, 22, 4, 27, 596, DateTimeKind.Local).AddTicks(5653), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" },
                    { new Guid("8ee484e6-ea0d-4365-a9da-fbdc443e8ad5"), "", "Glass supports", new DateTime(2022, 11, 17, 22, 4, 27, 596, DateTimeKind.Local).AddTicks(5690), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" },
                    { new Guid("9166ee86-1a32-443a-bf8a-95ed128d7257"), "", "Complete changeover", new DateTime(2022, 11, 17, 22, 4, 27, 596, DateTimeKind.Local).AddTicks(5651), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" },
                    { new Guid("a2b0db7d-27c5-4210-a472-c98f20e19f4a"), "", "Crowns and bridges", new DateTime(2022, 11, 17, 22, 4, 27, 596, DateTimeKind.Local).AddTicks(5676), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" },
                    { new Guid("d2c54f57-6de7-4a91-a2b7-4f43ba4efc70"), "", "Veneers", new DateTime(2022, 11, 17, 22, 4, 27, 596, DateTimeKind.Local).AddTicks(5668), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" },
                    { new Guid("feb7bb69-b393-4a00-9c59-99273fca711b"), "", "Surgical operations", new DateTime(2022, 11, 17, 22, 4, 27, 596, DateTimeKind.Local).AddTicks(5642), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" }
                });

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "IsActive", "MoreInfo", "Name", "Qualification", "UserId", "When", "Who" },
                values: new object[,]
                {
                    { new Guid("1befca4f-576d-431b-918e-c1bb448d3bce"), (byte)1, "Doctor Radeva has 5 years of experience as a dentist.", "Dr. Radeva", "Dentist", null, new DateTime(2022, 11, 17, 22, 4, 27, 596, DateTimeKind.Local).AddTicks(5514), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" },
                    { new Guid("1fe7bdb1-9ca1-4f5e-9cce-2680031ad627"), (byte)1, "Doctor Valeva has 3 years of experience as a оrthodontist.", "Dr. Valeva", "Оrthodontist", null, new DateTime(2022, 11, 17, 22, 4, 27, 596, DateTimeKind.Local).AddTicks(5552), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_DentalServices_Who",
                table: "DentalServices",
                column: "Who");

            migrationBuilder.AddForeignKey(
                name: "FK_DentalServices_AspNetUsers_Who",
                table: "DentalServices",
                column: "Who",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DentalServices_AspNetUsers_Who",
                table: "DentalServices");

            migrationBuilder.DropIndex(
                name: "IX_DentalServices_Who",
                table: "DentalServices");

            migrationBuilder.DeleteData(
                table: "DentalServices",
                keyColumn: "Id",
                keyValue: new Guid("034d9d6b-b8d1-406b-9e74-f298c52b501d"));

            migrationBuilder.DeleteData(
                table: "DentalServices",
                keyColumn: "Id",
                keyValue: new Guid("05af64a7-f3eb-4e54-adf6-c1e576fbd056"));

            migrationBuilder.DeleteData(
                table: "DentalServices",
                keyColumn: "Id",
                keyValue: new Guid("2b7ea6d0-30cc-4f13-b936-f6b7fbfad382"));

            migrationBuilder.DeleteData(
                table: "DentalServices",
                keyColumn: "Id",
                keyValue: new Guid("58480d1c-ed96-407e-a965-f0a78810f438"));

            migrationBuilder.DeleteData(
                table: "DentalServices",
                keyColumn: "Id",
                keyValue: new Guid("7139732d-2462-41f7-8045-ed365317b43b"));

            migrationBuilder.DeleteData(
                table: "DentalServices",
                keyColumn: "Id",
                keyValue: new Guid("7fda6066-d333-4c57-8238-72fe592f56e6"));

            migrationBuilder.DeleteData(
                table: "DentalServices",
                keyColumn: "Id",
                keyValue: new Guid("8b3dd26c-c1d1-4a30-9a5a-edd46c4c19d2"));

            migrationBuilder.DeleteData(
                table: "DentalServices",
                keyColumn: "Id",
                keyValue: new Guid("8ee484e6-ea0d-4365-a9da-fbdc443e8ad5"));

            migrationBuilder.DeleteData(
                table: "DentalServices",
                keyColumn: "Id",
                keyValue: new Guid("9166ee86-1a32-443a-bf8a-95ed128d7257"));

            migrationBuilder.DeleteData(
                table: "DentalServices",
                keyColumn: "Id",
                keyValue: new Guid("a2b0db7d-27c5-4210-a472-c98f20e19f4a"));

            migrationBuilder.DeleteData(
                table: "DentalServices",
                keyColumn: "Id",
                keyValue: new Guid("d2c54f57-6de7-4a91-a2b7-4f43ba4efc70"));

            migrationBuilder.DeleteData(
                table: "DentalServices",
                keyColumn: "Id",
                keyValue: new Guid("feb7bb69-b393-4a00-9c59-99273fca711b"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("1befca4f-576d-431b-918e-c1bb448d3bce"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("1fe7bdb1-9ca1-4f5e-9cce-2680031ad627"));

            migrationBuilder.AlterColumn<string>(
                name: "Who",
                table: "DentalServices",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<string>(
                name: "UsersId",
                table: "DentalServices",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "DentalServices",
                columns: new[] { "Id", "ServiceDescription", "ServiceName", "UsersId", "When", "Who" },
                values: new object[,]
                {
                    { new Guid("7332e0f4-ddf3-4503-9adc-19f9c68069fe"), "", "Veneers", null, new DateTime(2022, 11, 17, 22, 1, 36, 362, DateTimeKind.Local).AddTicks(2029), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" },
                    { new Guid("838c61b9-34e3-4144-8a4e-267e43a129af"), "", "Dental implants", null, new DateTime(2022, 11, 17, 22, 1, 36, 362, DateTimeKind.Local).AddTicks(2009), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" },
                    { new Guid("904abf19-2c82-4219-8efa-dc2f7187ca2a"), "", "Aesthetic fillings", null, new DateTime(2022, 11, 17, 22, 1, 36, 362, DateTimeKind.Local).AddTicks(2015), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" },
                    { new Guid("935d4813-1b12-4851-9e96-d38bc6fb6485"), "", "Surgical operations", null, new DateTime(2022, 11, 17, 22, 1, 36, 362, DateTimeKind.Local).AddTicks(2002), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" },
                    { new Guid("a9c1c0c9-8829-4ee4-96cd-c00aafff8c15"), "", "Tooth extraction", null, new DateTime(2022, 11, 17, 22, 1, 36, 362, DateTimeKind.Local).AddTicks(2039), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" },
                    { new Guid("be40ed1a-1df9-4a81-b18a-c31575386aa4"), "", "Ceramic inlays", null, new DateTime(2022, 11, 17, 22, 1, 36, 362, DateTimeKind.Local).AddTicks(2033), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" },
                    { new Guid("c32463e5-baa8-41c7-9845-57cf64b2ac43"), "", "Orthodontic treatment/braces and splints", null, new DateTime(2022, 11, 17, 22, 1, 36, 362, DateTimeKind.Local).AddTicks(2045), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" },
                    { new Guid("c47cf11f-2e5d-4c01-be9f-825540632bdc"), "", "Glass supports", null, new DateTime(2022, 11, 17, 22, 1, 36, 362, DateTimeKind.Local).AddTicks(2050), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" },
                    { new Guid("d1a71a51-115e-45ff-920d-4bdcbace3808"), "", "Complete changeover", null, new DateTime(2022, 11, 17, 22, 1, 36, 362, DateTimeKind.Local).AddTicks(2012), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" },
                    { new Guid("d499a064-7b5d-4545-acd3-124931b49467"), "", "Prosthesis", null, new DateTime(2022, 11, 17, 22, 1, 36, 362, DateTimeKind.Local).AddTicks(2041), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" },
                    { new Guid("d7defb1a-61a4-4778-bd59-efd8c29b7480"), "", "Crowns and bridges", null, new DateTime(2022, 11, 17, 22, 1, 36, 362, DateTimeKind.Local).AddTicks(2035), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" },
                    { new Guid("eddcbac0-1294-4697-a3b9-f6e96e016d46"), "", "Teeth whitening", null, new DateTime(2022, 11, 17, 22, 1, 36, 362, DateTimeKind.Local).AddTicks(2047), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" }
                });

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "IsActive", "MoreInfo", "Name", "Qualification", "UserId", "When", "Who" },
                values: new object[,]
                {
                    { new Guid("9c4a6ec7-afec-46b9-8d93-06642c86afb9"), (byte)1, "Doctor Radeva has 5 years of experience as a dentist.", "Dr. Radeva", "Dentist", null, new DateTime(2022, 11, 17, 22, 1, 36, 362, DateTimeKind.Local).AddTicks(1877), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" },
                    { new Guid("a83e5005-97e8-4250-97ff-d4682f269f86"), (byte)1, "Doctor Valeva has 3 years of experience as a оrthodontist.", "Dr. Valeva", "Оrthodontist", null, new DateTime(2022, 11, 17, 22, 1, 36, 362, DateTimeKind.Local).AddTicks(1916), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_DentalServices_UsersId",
                table: "DentalServices",
                column: "UsersId");

            migrationBuilder.AddForeignKey(
                name: "FK_DentalServices_AspNetUsers_UsersId",
                table: "DentalServices",
                column: "UsersId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
