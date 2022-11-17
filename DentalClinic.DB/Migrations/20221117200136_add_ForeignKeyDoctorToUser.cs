using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DentalClinic.DB.Migrations
{
    public partial class add_ForeignKeyDoctorToUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Doctors_AspNetUsers_UsersId",
                table: "Doctors");

            migrationBuilder.DeleteData(
                table: "DentalServices",
                keyColumn: "Id",
                keyValue: new Guid("17115c05-2580-483f-a19f-0b5a45c33472"));

            migrationBuilder.DeleteData(
                table: "DentalServices",
                keyColumn: "Id",
                keyValue: new Guid("1d15ef53-e1e3-4702-a83f-8f3b91622143"));

            migrationBuilder.DeleteData(
                table: "DentalServices",
                keyColumn: "Id",
                keyValue: new Guid("3e8a0b33-7fef-4d90-b845-d5d0ad47186d"));

            migrationBuilder.DeleteData(
                table: "DentalServices",
                keyColumn: "Id",
                keyValue: new Guid("4c636d97-c4a0-4728-a6f0-885633414d41"));

            migrationBuilder.DeleteData(
                table: "DentalServices",
                keyColumn: "Id",
                keyValue: new Guid("61647aac-aa97-44a3-873a-e06be215c175"));

            migrationBuilder.DeleteData(
                table: "DentalServices",
                keyColumn: "Id",
                keyValue: new Guid("6814ebd4-de66-4ab4-ad15-40b5f322be09"));

            migrationBuilder.DeleteData(
                table: "DentalServices",
                keyColumn: "Id",
                keyValue: new Guid("6b50eb83-55ca-4a8a-b267-9c27d19f6f88"));

            migrationBuilder.DeleteData(
                table: "DentalServices",
                keyColumn: "Id",
                keyValue: new Guid("8f7a4350-8676-4d71-8b5e-a9a9d07e1027"));

            migrationBuilder.DeleteData(
                table: "DentalServices",
                keyColumn: "Id",
                keyValue: new Guid("b845dc58-8fda-497b-b912-fc0413f0aa97"));

            migrationBuilder.DeleteData(
                table: "DentalServices",
                keyColumn: "Id",
                keyValue: new Guid("c386d6ef-4b35-4cca-b15d-84def33d658b"));

            migrationBuilder.DeleteData(
                table: "DentalServices",
                keyColumn: "Id",
                keyValue: new Guid("ce7cd604-626f-4812-bcb0-a5df7ef146d2"));

            migrationBuilder.DeleteData(
                table: "DentalServices",
                keyColumn: "Id",
                keyValue: new Guid("f09d7f1a-9164-4ab0-adf2-8965669e54a8"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("7b8e51ac-e88d-4349-bcf7-7ab0ea6dd5e3"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("cf0147ec-873d-44c0-ad8f-726043102e1b"));

            migrationBuilder.RenameColumn(
                name: "UsersId",
                table: "Doctors",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Doctors_UsersId",
                table: "Doctors",
                newName: "IX_Doctors_UserId");

            migrationBuilder.AlterColumn<string>(
                name: "Who",
                table: "Doctors",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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
                name: "IX_Doctors_Who",
                table: "Doctors",
                column: "Who");

            migrationBuilder.AddForeignKey(
                name: "FK_Doctors_AspNetUsers_UserId",
                table: "Doctors",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Doctors_AspNetUsers_Who",
                table: "Doctors",
                column: "Who",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Doctors_AspNetUsers_UserId",
                table: "Doctors");

            migrationBuilder.DropForeignKey(
                name: "FK_Doctors_AspNetUsers_Who",
                table: "Doctors");

            migrationBuilder.DropIndex(
                name: "IX_Doctors_Who",
                table: "Doctors");

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

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Doctors",
                newName: "UsersId");

            migrationBuilder.RenameIndex(
                name: "IX_Doctors_UserId",
                table: "Doctors",
                newName: "IX_Doctors_UsersId");

            migrationBuilder.AlterColumn<string>(
                name: "Who",
                table: "Doctors",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.InsertData(
                table: "DentalServices",
                columns: new[] { "Id", "ServiceDescription", "ServiceName", "UsersId", "When", "Who" },
                values: new object[,]
                {
                    { new Guid("17115c05-2580-483f-a19f-0b5a45c33472"), "", "Teeth whitening", null, new DateTime(2022, 11, 14, 22, 58, 41, 375, DateTimeKind.Local).AddTicks(5998), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" },
                    { new Guid("1d15ef53-e1e3-4702-a83f-8f3b91622143"), "", "Dental implants", null, new DateTime(2022, 11, 14, 22, 58, 41, 375, DateTimeKind.Local).AddTicks(5966), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" },
                    { new Guid("3e8a0b33-7fef-4d90-b845-d5d0ad47186d"), "", "Tooth extraction", null, new DateTime(2022, 11, 14, 22, 58, 41, 375, DateTimeKind.Local).AddTicks(5986), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" },
                    { new Guid("4c636d97-c4a0-4728-a6f0-885633414d41"), "", "Complete changeover", null, new DateTime(2022, 11, 14, 22, 58, 41, 375, DateTimeKind.Local).AddTicks(5970), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" },
                    { new Guid("61647aac-aa97-44a3-873a-e06be215c175"), "", "Orthodontic treatment/braces and splints", null, new DateTime(2022, 11, 14, 22, 58, 41, 375, DateTimeKind.Local).AddTicks(5995), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" },
                    { new Guid("6814ebd4-de66-4ab4-ad15-40b5f322be09"), "", "Veneers", null, new DateTime(2022, 11, 14, 22, 58, 41, 375, DateTimeKind.Local).AddTicks(5976), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" },
                    { new Guid("6b50eb83-55ca-4a8a-b267-9c27d19f6f88"), "", "Prosthesis", null, new DateTime(2022, 11, 14, 22, 58, 41, 375, DateTimeKind.Local).AddTicks(5989), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" },
                    { new Guid("8f7a4350-8676-4d71-8b5e-a9a9d07e1027"), "", "Crowns and bridges", null, new DateTime(2022, 11, 14, 22, 58, 41, 375, DateTimeKind.Local).AddTicks(5983), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" },
                    { new Guid("b845dc58-8fda-497b-b912-fc0413f0aa97"), "", "Ceramic inlays", null, new DateTime(2022, 11, 14, 22, 58, 41, 375, DateTimeKind.Local).AddTicks(5981), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" },
                    { new Guid("c386d6ef-4b35-4cca-b15d-84def33d658b"), "", "Surgical operations", null, new DateTime(2022, 11, 14, 22, 58, 41, 375, DateTimeKind.Local).AddTicks(5949), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" },
                    { new Guid("ce7cd604-626f-4812-bcb0-a5df7ef146d2"), "", "Glass supports", null, new DateTime(2022, 11, 14, 22, 58, 41, 375, DateTimeKind.Local).AddTicks(6001), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" },
                    { new Guid("f09d7f1a-9164-4ab0-adf2-8965669e54a8"), "", "Aesthetic fillings", null, new DateTime(2022, 11, 14, 22, 58, 41, 375, DateTimeKind.Local).AddTicks(5973), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" }
                });

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "IsActive", "MoreInfo", "Name", "Qualification", "UsersId", "When", "Who" },
                values: new object[,]
                {
                    { new Guid("7b8e51ac-e88d-4349-bcf7-7ab0ea6dd5e3"), (byte)1, "Doctor Radeva has 5 years of experience as a dentist.", "Dr. Radeva", "Dentist", null, new DateTime(2022, 11, 14, 22, 58, 41, 375, DateTimeKind.Local).AddTicks(5823), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" },
                    { new Guid("cf0147ec-873d-44c0-ad8f-726043102e1b"), (byte)1, "Doctor Valeva has 3 years of experience as a оrthodontist.", "Dr. Valeva", "Оrthodontist", null, new DateTime(2022, 11, 14, 22, 58, 41, 375, DateTimeKind.Local).AddTicks(5859), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Doctors_AspNetUsers_UsersId",
                table: "Doctors",
                column: "UsersId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
