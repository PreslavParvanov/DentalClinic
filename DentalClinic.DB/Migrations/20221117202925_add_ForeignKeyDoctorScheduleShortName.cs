using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DentalClinic.DB.Migrations
{
    public partial class add_ForeignKeyDoctorScheduleShortName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DentalServices",
                keyColumn: "Id",
                keyValue: new Guid("0825f630-372b-4933-906e-22d592571b8e"));

            migrationBuilder.DeleteData(
                table: "DentalServices",
                keyColumn: "Id",
                keyValue: new Guid("19d94e5d-3613-47f8-b4c1-89c986d3bb62"));

            migrationBuilder.DeleteData(
                table: "DentalServices",
                keyColumn: "Id",
                keyValue: new Guid("6f8bf8ff-ea6e-4f77-997d-3a946ff1d408"));

            migrationBuilder.DeleteData(
                table: "DentalServices",
                keyColumn: "Id",
                keyValue: new Guid("7bd616c8-eccc-4442-a111-5f2939cb8bb1"));

            migrationBuilder.DeleteData(
                table: "DentalServices",
                keyColumn: "Id",
                keyValue: new Guid("a790b759-69b6-442a-887c-0122145dc51d"));

            migrationBuilder.DeleteData(
                table: "DentalServices",
                keyColumn: "Id",
                keyValue: new Guid("ba53bc1c-dbe9-43bf-ac59-fa4b71690e95"));

            migrationBuilder.DeleteData(
                table: "DentalServices",
                keyColumn: "Id",
                keyValue: new Guid("c2a0c2eb-a527-4795-9c5f-ffade8d45555"));

            migrationBuilder.DeleteData(
                table: "DentalServices",
                keyColumn: "Id",
                keyValue: new Guid("cda81e3e-183a-4b28-8510-d6f9db4f67b3"));

            migrationBuilder.DeleteData(
                table: "DentalServices",
                keyColumn: "Id",
                keyValue: new Guid("ec61412a-b2ec-4c68-b40a-c7f2bea3e697"));

            migrationBuilder.DeleteData(
                table: "DentalServices",
                keyColumn: "Id",
                keyValue: new Guid("ee7b16d5-a616-4879-9c35-21e7786b1320"));

            migrationBuilder.DeleteData(
                table: "DentalServices",
                keyColumn: "Id",
                keyValue: new Guid("f135db6f-58fa-4e83-abc1-754e05b4e9db"));

            migrationBuilder.DeleteData(
                table: "DentalServices",
                keyColumn: "Id",
                keyValue: new Guid("feb2dd07-f867-4e6c-add6-8e87a0337f55"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("74d0e165-8623-4d76-a42c-880d55472412"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("9912f6ae-19e4-4125-8f64-8d7a6d7e68b9"));

            migrationBuilder.InsertData(
                table: "DentalServices",
                columns: new[] { "Id", "ServiceDescription", "ServiceName", "When", "Who" },
                values: new object[,]
                {
                    { new Guid("06f4fe0a-c6e0-4649-9826-db2e81257b3f"), "", "Glass supports", new DateTime(2022, 11, 17, 22, 29, 25, 610, DateTimeKind.Local).AddTicks(1433), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" },
                    { new Guid("07837fb0-ac4a-48a4-bb1b-857e390b30bd"), "", "Complete changeover", new DateTime(2022, 11, 17, 22, 29, 25, 610, DateTimeKind.Local).AddTicks(1390), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" },
                    { new Guid("2a5a54b7-8d97-402a-809d-cfae854217fd"), "", "Tooth extraction", new DateTime(2022, 11, 17, 22, 29, 25, 610, DateTimeKind.Local).AddTicks(1421), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" },
                    { new Guid("37160c96-7047-4bba-bd61-4fc189770d7f"), "", "Veneers", new DateTime(2022, 11, 17, 22, 29, 25, 610, DateTimeKind.Local).AddTicks(1409), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" },
                    { new Guid("3e88462c-97c6-4723-bbdb-96c85bece989"), "", "Crowns and bridges", new DateTime(2022, 11, 17, 22, 29, 25, 610, DateTimeKind.Local).AddTicks(1419), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" },
                    { new Guid("633a5ae3-c7bb-4ced-972e-00d6fe247174"), "", "Orthodontic treatment/braces and splints", new DateTime(2022, 11, 17, 22, 29, 25, 610, DateTimeKind.Local).AddTicks(1428), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" },
                    { new Guid("7389048f-1a85-44dc-ae12-a3b32fad6f2e"), "", "Prosthesis", new DateTime(2022, 11, 17, 22, 29, 25, 610, DateTimeKind.Local).AddTicks(1424), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" },
                    { new Guid("787c210c-a80e-4f72-9a27-110afc64cb50"), "", "Dental implants", new DateTime(2022, 11, 17, 22, 29, 25, 610, DateTimeKind.Local).AddTicks(1387), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" },
                    { new Guid("7fa78735-5b9b-4dc9-a63e-ba7f97a3eb75"), "", "Aesthetic fillings", new DateTime(2022, 11, 17, 22, 29, 25, 610, DateTimeKind.Local).AddTicks(1393), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" },
                    { new Guid("bf298c31-8da2-4f41-84cc-84f51e73d659"), "", "Ceramic inlays", new DateTime(2022, 11, 17, 22, 29, 25, 610, DateTimeKind.Local).AddTicks(1416), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" },
                    { new Guid("ce4ee6d1-4107-40e5-8c37-b7b5cde90b57"), "", "Surgical operations", new DateTime(2022, 11, 17, 22, 29, 25, 610, DateTimeKind.Local).AddTicks(1381), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" },
                    { new Guid("f2ba2d00-619a-437c-a349-40c4d45b797a"), "", "Teeth whitening", new DateTime(2022, 11, 17, 22, 29, 25, 610, DateTimeKind.Local).AddTicks(1430), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" }
                });

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "IsActive", "MoreInfo", "Name", "Qualification", "When", "Who" },
                values: new object[,]
                {
                    { new Guid("19cb11d5-b3ba-45a7-9759-0267acb5dacc"), (byte)1, "Doctor Valeva has 3 years of experience as a оrthodontist.", "Dr. Valeva", "Оrthodontist", new DateTime(2022, 11, 17, 22, 29, 25, 610, DateTimeKind.Local).AddTicks(1260), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" },
                    { new Guid("3a0b7851-e0c3-434d-997f-cb89532fc815"), (byte)1, "Doctor Radeva has 5 years of experience as a dentist.", "Dr. Radeva", "Dentist", new DateTime(2022, 11, 17, 22, 29, 25, 610, DateTimeKind.Local).AddTicks(1224), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DentalServices",
                keyColumn: "Id",
                keyValue: new Guid("06f4fe0a-c6e0-4649-9826-db2e81257b3f"));

            migrationBuilder.DeleteData(
                table: "DentalServices",
                keyColumn: "Id",
                keyValue: new Guid("07837fb0-ac4a-48a4-bb1b-857e390b30bd"));

            migrationBuilder.DeleteData(
                table: "DentalServices",
                keyColumn: "Id",
                keyValue: new Guid("2a5a54b7-8d97-402a-809d-cfae854217fd"));

            migrationBuilder.DeleteData(
                table: "DentalServices",
                keyColumn: "Id",
                keyValue: new Guid("37160c96-7047-4bba-bd61-4fc189770d7f"));

            migrationBuilder.DeleteData(
                table: "DentalServices",
                keyColumn: "Id",
                keyValue: new Guid("3e88462c-97c6-4723-bbdb-96c85bece989"));

            migrationBuilder.DeleteData(
                table: "DentalServices",
                keyColumn: "Id",
                keyValue: new Guid("633a5ae3-c7bb-4ced-972e-00d6fe247174"));

            migrationBuilder.DeleteData(
                table: "DentalServices",
                keyColumn: "Id",
                keyValue: new Guid("7389048f-1a85-44dc-ae12-a3b32fad6f2e"));

            migrationBuilder.DeleteData(
                table: "DentalServices",
                keyColumn: "Id",
                keyValue: new Guid("787c210c-a80e-4f72-9a27-110afc64cb50"));

            migrationBuilder.DeleteData(
                table: "DentalServices",
                keyColumn: "Id",
                keyValue: new Guid("7fa78735-5b9b-4dc9-a63e-ba7f97a3eb75"));

            migrationBuilder.DeleteData(
                table: "DentalServices",
                keyColumn: "Id",
                keyValue: new Guid("bf298c31-8da2-4f41-84cc-84f51e73d659"));

            migrationBuilder.DeleteData(
                table: "DentalServices",
                keyColumn: "Id",
                keyValue: new Guid("ce4ee6d1-4107-40e5-8c37-b7b5cde90b57"));

            migrationBuilder.DeleteData(
                table: "DentalServices",
                keyColumn: "Id",
                keyValue: new Guid("f2ba2d00-619a-437c-a349-40c4d45b797a"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("19cb11d5-b3ba-45a7-9759-0267acb5dacc"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("3a0b7851-e0c3-434d-997f-cb89532fc815"));

            migrationBuilder.InsertData(
                table: "DentalServices",
                columns: new[] { "Id", "ServiceDescription", "ServiceName", "When", "Who" },
                values: new object[,]
                {
                    { new Guid("0825f630-372b-4933-906e-22d592571b8e"), "", "Veneers", new DateTime(2022, 11, 17, 22, 25, 53, 345, DateTimeKind.Local).AddTicks(7208), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" },
                    { new Guid("19d94e5d-3613-47f8-b4c1-89c986d3bb62"), "", "Orthodontic treatment/braces and splints", new DateTime(2022, 11, 17, 22, 25, 53, 345, DateTimeKind.Local).AddTicks(7227), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" },
                    { new Guid("6f8bf8ff-ea6e-4f77-997d-3a946ff1d408"), "", "Surgical operations", new DateTime(2022, 11, 17, 22, 25, 53, 345, DateTimeKind.Local).AddTicks(7175), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" },
                    { new Guid("7bd616c8-eccc-4442-a111-5f2939cb8bb1"), "", "Tooth extraction", new DateTime(2022, 11, 17, 22, 25, 53, 345, DateTimeKind.Local).AddTicks(7220), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" },
                    { new Guid("a790b759-69b6-442a-887c-0122145dc51d"), "", "Dental implants", new DateTime(2022, 11, 17, 22, 25, 53, 345, DateTimeKind.Local).AddTicks(7182), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" },
                    { new Guid("ba53bc1c-dbe9-43bf-ac59-fa4b71690e95"), "", "Ceramic inlays", new DateTime(2022, 11, 17, 22, 25, 53, 345, DateTimeKind.Local).AddTicks(7214), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" },
                    { new Guid("c2a0c2eb-a527-4795-9c5f-ffade8d45555"), "", "Aesthetic fillings", new DateTime(2022, 11, 17, 22, 25, 53, 345, DateTimeKind.Local).AddTicks(7204), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" },
                    { new Guid("cda81e3e-183a-4b28-8510-d6f9db4f67b3"), "", "Complete changeover", new DateTime(2022, 11, 17, 22, 25, 53, 345, DateTimeKind.Local).AddTicks(7201), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" },
                    { new Guid("ec61412a-b2ec-4c68-b40a-c7f2bea3e697"), "", "Teeth whitening", new DateTime(2022, 11, 17, 22, 25, 53, 345, DateTimeKind.Local).AddTicks(7232), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" },
                    { new Guid("ee7b16d5-a616-4879-9c35-21e7786b1320"), "", "Glass supports", new DateTime(2022, 11, 17, 22, 25, 53, 345, DateTimeKind.Local).AddTicks(7235), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" },
                    { new Guid("f135db6f-58fa-4e83-abc1-754e05b4e9db"), "", "Prosthesis", new DateTime(2022, 11, 17, 22, 25, 53, 345, DateTimeKind.Local).AddTicks(7223), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" },
                    { new Guid("feb2dd07-f867-4e6c-add6-8e87a0337f55"), "", "Crowns and bridges", new DateTime(2022, 11, 17, 22, 25, 53, 345, DateTimeKind.Local).AddTicks(7217), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" }
                });

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "IsActive", "MoreInfo", "Name", "Qualification", "When", "Who" },
                values: new object[,]
                {
                    { new Guid("74d0e165-8623-4d76-a42c-880d55472412"), (byte)1, "Doctor Valeva has 3 years of experience as a оrthodontist.", "Dr. Valeva", "Оrthodontist", new DateTime(2022, 11, 17, 22, 25, 53, 345, DateTimeKind.Local).AddTicks(7056), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" },
                    { new Guid("9912f6ae-19e4-4125-8f64-8d7a6d7e68b9"), (byte)1, "Doctor Radeva has 5 years of experience as a dentist.", "Dr. Radeva", "Dentist", new DateTime(2022, 11, 17, 22, 25, 53, 345, DateTimeKind.Local).AddTicks(7011), "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa" }
                });
        }
    }
}
