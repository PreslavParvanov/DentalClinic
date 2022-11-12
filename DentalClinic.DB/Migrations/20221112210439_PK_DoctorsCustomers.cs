using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DentalClinic.DB.Migrations
{
    public partial class PK_DoctorsCustomers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DoctorsCustomers_AspNetUsers_UsersId",
                table: "DoctorsCustomers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DoctorsCustomers",
                table: "DoctorsCustomers");

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("46f8c494-27fb-49c4-be57-70365de69e79"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("9700dc3a-690a-430c-9d7f-8eb982919ec7"));

            migrationBuilder.DropColumn(
                name: "IsBusy",
                table: "DoctorsCustomers");

            migrationBuilder.RenameColumn(
                name: "UsersId",
                table: "DoctorsCustomers",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_DoctorsCustomers_UsersId",
                table: "DoctorsCustomers",
                newName: "IX_DoctorsCustomers_UserId");

            migrationBuilder.AddColumn<DateTime>(
                name: "When",
                table: "DoctorsCustomers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddPrimaryKey(
                name: "PK_DoctorsCustomers",
                table: "DoctorsCustomers",
                columns: new[] { "DoctorId", "CustomerId", "DateTime" });

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "IsActive", "MoreInfo", "Name", "Qualification", "UsersId", "When", "Who" },
                values: new object[] { new Guid("0f294ea3-ce77-4fe3-8841-c618ee89466f"), (byte)1, "Doctor Radeva has 5 years of experience as a dentist.", "Dr. Radeva", "Dentist", null, new DateTime(2022, 11, 12, 23, 4, 39, 36, DateTimeKind.Local).AddTicks(9445), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" });

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "IsActive", "MoreInfo", "Name", "Qualification", "UsersId", "When", "Who" },
                values: new object[] { new Guid("d45a8e5a-8198-462e-8833-dbb32d336ba9"), (byte)1, "Doctor Valeva has 3 years of experience as a оrthodontist.", "Dr. Valeva", "Оrthodontist", null, new DateTime(2022, 11, 12, 23, 4, 39, 36, DateTimeKind.Local).AddTicks(9505), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" });

            migrationBuilder.AddForeignKey(
                name: "FK_DoctorsCustomers_AspNetUsers_UserId",
                table: "DoctorsCustomers",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DoctorsCustomers_AspNetUsers_UserId",
                table: "DoctorsCustomers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DoctorsCustomers",
                table: "DoctorsCustomers");

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("0f294ea3-ce77-4fe3-8841-c618ee89466f"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("d45a8e5a-8198-462e-8833-dbb32d336ba9"));

            migrationBuilder.DropColumn(
                name: "When",
                table: "DoctorsCustomers");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "DoctorsCustomers",
                newName: "UsersId");

            migrationBuilder.RenameIndex(
                name: "IX_DoctorsCustomers_UserId",
                table: "DoctorsCustomers",
                newName: "IX_DoctorsCustomers_UsersId");

            migrationBuilder.AddColumn<bool>(
                name: "IsBusy",
                table: "DoctorsCustomers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddPrimaryKey(
                name: "PK_DoctorsCustomers",
                table: "DoctorsCustomers",
                columns: new[] { "DoctorId", "CustomerId" });

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "IsActive", "MoreInfo", "Name", "Qualification", "UsersId", "When", "Who" },
                values: new object[] { new Guid("46f8c494-27fb-49c4-be57-70365de69e79"), (byte)1, "Doctor Valeva has 3 years of experience as a оrthodontist.", "Dr. Valeva", "Оrthodontist", null, new DateTime(2022, 11, 3, 23, 38, 39, 950, DateTimeKind.Local).AddTicks(321), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" });

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "IsActive", "MoreInfo", "Name", "Qualification", "UsersId", "When", "Who" },
                values: new object[] { new Guid("9700dc3a-690a-430c-9d7f-8eb982919ec7"), (byte)1, "Doctor Radeva has 5 years of experience as a dentist.", "Dr. Radeva", "orthodontist", null, new DateTime(2022, 11, 3, 23, 38, 39, 950, DateTimeKind.Local).AddTicks(280), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" });

            migrationBuilder.AddForeignKey(
                name: "FK_DoctorsCustomers_AspNetUsers_UsersId",
                table: "DoctorsCustomers",
                column: "UsersId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
