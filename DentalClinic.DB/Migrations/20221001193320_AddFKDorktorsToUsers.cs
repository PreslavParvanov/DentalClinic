using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DentalClinic.DB.Migrations
{
    public partial class AddFKDorktorsToUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Doctors_Who",
                table: "Doctors",
                column: "Who");

            migrationBuilder.AddForeignKey(
                name: "FK_Guns_Manufacturer",
                table: "Doctors",
                column: "Who",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Guns_Manufacturer",
                table: "Doctors");

            migrationBuilder.DropIndex(
                name: "IX_Doctors_Who",
                table: "Doctors");
        }
    }
}
