using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DentalClinic.DB.Migrations
{
    public partial class CorectNameFKDorktorsToUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Guns_Manufacturer",
                table: "Doctors");

            migrationBuilder.AddForeignKey(
                name: "FK_Doctors_Users",
                table: "Doctors",
                column: "Who",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Doctors_Users",
                table: "Doctors");

            migrationBuilder.AddForeignKey(
                name: "FK_Guns_Manufacturer",
                table: "Doctors",
                column: "Who",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
