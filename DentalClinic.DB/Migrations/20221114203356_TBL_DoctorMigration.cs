using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DentalClinic.DB.Migrations
{
    public partial class TBL_DoctorMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("0f294ea3-ce77-4fe3-8841-c618ee89466f"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("d45a8e5a-8198-462e-8833-dbb32d336ba9"));

            migrationBuilder.CreateTable(
                name: "Services",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ServiceName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ServiceDescription = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    Who = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UsersId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    When = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Services", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Services_AspNetUsers_UsersId",
                        column: x => x.UsersId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "IsActive", "MoreInfo", "Name", "Qualification", "UsersId", "When", "Who" },
                values: new object[,]
                {
                    { new Guid("bdccca37-dd21-4260-80e5-8e5d91bca413"), (byte)1, "Doctor Radeva has 5 years of experience as a dentist.", "Dr. Radeva", "Dentist", null, new DateTime(2022, 11, 14, 22, 33, 55, 713, DateTimeKind.Local).AddTicks(2473), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" },
                    { new Guid("ea730c66-e2d1-4493-b649-8340b0f23fc8"), (byte)1, "Doctor Valeva has 3 years of experience as a оrthodontist.", "Dr. Valeva", "Оrthodontist", null, new DateTime(2022, 11, 14, 22, 33, 55, 713, DateTimeKind.Local).AddTicks(2511), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" }
                });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "ServiceDescription", "ServiceName", "UsersId", "When", "Who" },
                values: new object[,]
                {
                    { new Guid("05134afe-38a8-4c7a-98fe-09a7235eb0ab"), "", "Dental implants", null, new DateTime(2022, 11, 14, 22, 33, 55, 713, DateTimeKind.Local).AddTicks(2604), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" },
                    { new Guid("0a57c574-254a-4fc9-9d23-01a5c615b858"), "", "Prosthesis", null, new DateTime(2022, 11, 14, 22, 33, 55, 713, DateTimeKind.Local).AddTicks(2637), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" },
                    { new Guid("1e83fc08-467a-4e74-8726-8d575c602447"), "", "Crowns and bridges", null, new DateTime(2022, 11, 14, 22, 33, 55, 713, DateTimeKind.Local).AddTicks(2631), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" },
                    { new Guid("38e0af51-1899-465c-b1f8-7d3cc96f6168"), "", "Aesthetic fillings", null, new DateTime(2022, 11, 14, 22, 33, 55, 713, DateTimeKind.Local).AddTicks(2610), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" },
                    { new Guid("5426f105-a27a-450e-b2a8-bb8581f42eb7"), "", "Glass supports", null, new DateTime(2022, 11, 14, 22, 33, 55, 713, DateTimeKind.Local).AddTicks(2645), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" },
                    { new Guid("663555d5-c31c-40f5-8204-df8fa410dd6e"), "", "Tooth extraction", null, new DateTime(2022, 11, 14, 22, 33, 55, 713, DateTimeKind.Local).AddTicks(2634), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" },
                    { new Guid("66e67adc-80cc-48ce-bcda-fc86f9d9f662"), "", "Teeth whitening", null, new DateTime(2022, 11, 14, 22, 33, 55, 713, DateTimeKind.Local).AddTicks(2643), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" },
                    { new Guid("7f1eaf6e-6884-4937-b8bd-9078a84a6675"), "", "Veneers", null, new DateTime(2022, 11, 14, 22, 33, 55, 713, DateTimeKind.Local).AddTicks(2622), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" },
                    { new Guid("d02bdaa0-57cf-497a-97d1-81e7c9ae2e59"), "", "Orthodontic treatment/braces and splints", null, new DateTime(2022, 11, 14, 22, 33, 55, 713, DateTimeKind.Local).AddTicks(2640), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" },
                    { new Guid("d26809dc-d9de-466e-8f78-91dde69c34ec"), "", "Surgical operations", null, new DateTime(2022, 11, 14, 22, 33, 55, 713, DateTimeKind.Local).AddTicks(2597), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" },
                    { new Guid("e64ef0d7-d3ff-4614-bf20-c8665a7a01e3"), "", "Ceramic inlays", null, new DateTime(2022, 11, 14, 22, 33, 55, 713, DateTimeKind.Local).AddTicks(2628), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" },
                    { new Guid("e8f47c99-1b40-4390-bd1a-3351d3d8227b"), "", "Complete changeover", null, new DateTime(2022, 11, 14, 22, 33, 55, 713, DateTimeKind.Local).AddTicks(2607), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Services_UsersId",
                table: "Services",
                column: "UsersId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Services");

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("bdccca37-dd21-4260-80e5-8e5d91bca413"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("ea730c66-e2d1-4493-b649-8340b0f23fc8"));

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "IsActive", "MoreInfo", "Name", "Qualification", "UsersId", "When", "Who" },
                values: new object[] { new Guid("0f294ea3-ce77-4fe3-8841-c618ee89466f"), (byte)1, "Doctor Radeva has 5 years of experience as a dentist.", "Dr. Radeva", "Dentist", null, new DateTime(2022, 11, 12, 23, 4, 39, 36, DateTimeKind.Local).AddTicks(9445), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" });

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "IsActive", "MoreInfo", "Name", "Qualification", "UsersId", "When", "Who" },
                values: new object[] { new Guid("d45a8e5a-8198-462e-8833-dbb32d336ba9"), (byte)1, "Doctor Valeva has 3 years of experience as a оrthodontist.", "Dr. Valeva", "Оrthodontist", null, new DateTime(2022, 11, 12, 23, 4, 39, 36, DateTimeKind.Local).AddTicks(9505), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" });
        }
    }
}
