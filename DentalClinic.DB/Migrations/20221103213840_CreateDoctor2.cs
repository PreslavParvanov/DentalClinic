using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DentalClinic.DB.Migrations
{
    public partial class CreateDoctor2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("3332cc0c-2e9c-45ed-81fb-02cf36ea3ec4"));

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "IsActive", "MoreInfo", "Name", "Qualification", "UsersId", "When", "Who" },
                values: new object[] { new Guid("46f8c494-27fb-49c4-be57-70365de69e79"), (byte)1, "Doctor Valeva has 3 years of experience as a оrthodontist.", "Dr. Valeva", "Оrthodontist", null, new DateTime(2022, 11, 3, 23, 38, 39, 950, DateTimeKind.Local).AddTicks(321), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" });

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "IsActive", "MoreInfo", "Name", "Qualification", "UsersId", "When", "Who" },
                values: new object[] { new Guid("9700dc3a-690a-430c-9d7f-8eb982919ec7"), (byte)1, "Doctor Radeva has 5 years of experience as a dentist.", "Dr. Radeva", "orthodontist", null, new DateTime(2022, 11, 3, 23, 38, 39, 950, DateTimeKind.Local).AddTicks(280), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("46f8c494-27fb-49c4-be57-70365de69e79"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("9700dc3a-690a-430c-9d7f-8eb982919ec7"));

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "IsActive", "MoreInfo", "Name", "Qualification", "UsersId", "When", "Who" },
                values: new object[] { new Guid("3332cc0c-2e9c-45ed-81fb-02cf36ea3ec4"), (byte)1, "5 Year", "Dr. Radeva", "Dentist", null, new DateTime(2022, 11, 3, 23, 29, 29, 101, DateTimeKind.Local).AddTicks(9680), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" });
        }
    }
}
