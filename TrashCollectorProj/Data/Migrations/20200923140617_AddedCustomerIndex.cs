using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollectorProj.Data.Migrations
{
    public partial class AddedCustomerIndex : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "05b5d1de-9a9d-4462-8794-a04e21755bcb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3d8052f8-116f-43a1-af59-6f4c3e9086e3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9f37ea41-c263-4299-bd6c-067006235eb9");

            migrationBuilder.AlterColumn<string>(
                name: "WeeklyPickUpDate",
                table: "Customer",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5c3d87e5-8beb-4cb7-adda-23dc1364b191", "d3b60334-e214-4e31-95de-bd0f87a9340b", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b085f89c-308f-41e8-886c-493e2ea5f411", "f5fc8c45-8844-4637-9c1c-9edfddf8ad43", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4c3bd984-3768-41ba-a113-11e40b303531", "066306b2-ad2d-4466-87b6-ece1ce07ebc7", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4c3bd984-3768-41ba-a113-11e40b303531");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5c3d87e5-8beb-4cb7-adda-23dc1364b191");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b085f89c-308f-41e8-886c-493e2ea5f411");

            migrationBuilder.AlterColumn<DateTime>(
                name: "WeeklyPickUpDate",
                table: "Customer",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3d8052f8-116f-43a1-af59-6f4c3e9086e3", "59f246d7-e78c-448a-a452-fb127335b2f7", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9f37ea41-c263-4299-bd6c-067006235eb9", "b99399fb-dc03-4a28-a9dd-523bc12030e6", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "05b5d1de-9a9d-4462-8794-a04e21755bcb", "7e52202d-3257-4af4-9e56-27d49c64f32b", "Employee", "EMPLOYEE" });
        }
    }
}
