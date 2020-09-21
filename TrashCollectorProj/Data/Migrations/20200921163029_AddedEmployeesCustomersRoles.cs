using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollectorProj.Data.Migrations
{
    public partial class AddedEmployeesCustomersRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "51dea14d-fa82-4d74-b76e-fc13c5725e83");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "51dea14d-fa82-4d74-b76e-fc13c5725e83", "01ed687a-3ea1-4726-b674-3e18a11506aa", "Admin", "ADMIN" });
        }
    }
}
