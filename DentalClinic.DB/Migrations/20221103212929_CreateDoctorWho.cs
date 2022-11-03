using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DentalClinic.DB.Migrations
{
    public partial class CreateDoctorWho : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("b944e0bf-5b91-4447-960f-2a32c3ab1073"));

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "IsActive", "MoreInfo", "Name", "Qualification", "UsersId", "When", "Who" },
                values: new object[] { new Guid("3332cc0c-2e9c-45ed-81fb-02cf36ea3ec4"), (byte)1, "5 Year", "Dr. Radeva", "Dentist", null, new DateTime(2022, 11, 3, 23, 29, 29, 101, DateTimeKind.Local).AddTicks(9680), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("3332cc0c-2e9c-45ed-81fb-02cf36ea3ec4"));

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "IsActive", "MoreInfo", "Name", "Qualification", "UsersId", "When", "Who" },
                values: new object[] { new Guid("b944e0bf-5b91-4447-960f-2a32c3ab1073"), (byte)1, "5 Year", "Dr. Radeva", "Dentist", null, new DateTime(2022, 11, 3, 23, 28, 3, 487, DateTimeKind.Local).AddTicks(3253), "" });
        }
    }
}
