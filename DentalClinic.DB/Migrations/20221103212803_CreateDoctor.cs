using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DentalClinic.DB.Migrations
{
    public partial class CreateDoctor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Doctors_Users",
                table: "Doctors");

            migrationBuilder.DropIndex(
                name: "IX_Doctors_Who",
                table: "Doctors");

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("459f3ad6-551f-482f-9b2f-e1ed0be8646c"));

            migrationBuilder.AlterColumn<string>(
                name: "Who",
                table: "Doctors",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<string>(
                name: "UsersId",
                table: "Doctors",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "IsActive", "MoreInfo", "Name", "Qualification", "UsersId", "When", "Who" },
                values: new object[] { new Guid("b944e0bf-5b91-4447-960f-2a32c3ab1073"), (byte)1, "5 Year", "Dr. Radeva", "Dentist", null, new DateTime(2022, 11, 3, 23, 28, 3, 487, DateTimeKind.Local).AddTicks(3253), "" });

            migrationBuilder.CreateIndex(
                name: "IX_Doctors_UsersId",
                table: "Doctors",
                column: "UsersId");

            migrationBuilder.AddForeignKey(
                name: "FK_Doctors_AspNetUsers_UsersId",
                table: "Doctors",
                column: "UsersId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Doctors_AspNetUsers_UsersId",
                table: "Doctors");

            migrationBuilder.DropIndex(
                name: "IX_Doctors_UsersId",
                table: "Doctors");

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("b944e0bf-5b91-4447-960f-2a32c3ab1073"));

            migrationBuilder.DropColumn(
                name: "UsersId",
                table: "Doctors");

            migrationBuilder.AlterColumn<string>(
                name: "Who",
                table: "Doctors",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "IsActive", "MoreInfo", "Name", "Qualification", "When", "Who" },
                values: new object[] { new Guid("459f3ad6-551f-482f-9b2f-e1ed0be8646c"), (byte)0, "5 Year", "Dr. Radeva", "Dentist", new DateTime(2022, 11, 3, 23, 23, 1, 114, DateTimeKind.Local).AddTicks(8219), "" });

            migrationBuilder.CreateIndex(
                name: "IX_Doctors_Who",
                table: "Doctors",
                column: "Who");

            migrationBuilder.AddForeignKey(
                name: "FK_Doctors_Users",
                table: "Doctors",
                column: "Who",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
