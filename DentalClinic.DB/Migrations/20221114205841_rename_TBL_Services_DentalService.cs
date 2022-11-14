using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DentalClinic.DB.Migrations
{
    public partial class rename_TBL_Services_DentalService : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "DentalServices",
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
                    table.PrimaryKey("PK_DentalServices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DentalServices_AspNetUsers_UsersId",
                        column: x => x.UsersId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_DentalServices_UsersId",
                table: "DentalServices",
                column: "UsersId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DentalServices");

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("7b8e51ac-e88d-4349-bcf7-7ab0ea6dd5e3"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("cf0147ec-873d-44c0-ad8f-726043102e1b"));

            migrationBuilder.CreateTable(
                name: "Services",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UsersId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ServiceDescription = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    ServiceName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    When = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Who = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
    }
}
