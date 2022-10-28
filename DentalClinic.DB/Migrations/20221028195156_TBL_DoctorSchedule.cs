using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DentalClinic.DB.Migrations
{
    public partial class TBL_DoctorSchedule : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DoctorsSchedules",
                columns: table => new
                {
                    DoctorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ScheduleDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsBusy = table.Column<bool>(type: "bit", nullable: false),
                    Who = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    When = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DoctorsSchedules", x => new { x.DoctorId, x.ScheduleDateTime });
                    table.ForeignKey(
                        name: "FK_DoctorSchedules_Doctors",
                        column: x => x.DoctorId,
                        principalTable: "Doctors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DoctorsSchedules_Who",
                table: "DoctorsSchedules",
                column: "Who");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DoctorsSchedules");
        }
    }
}
