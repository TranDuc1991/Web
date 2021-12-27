using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopSolution.Data.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                nullable: false,
                defaultValue: new DateTime(2021, 12, 27, 11, 2, 46, 813, DateTimeKind.Local).AddTicks(7644),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 1, 29, 21, 20, 57, 232, DateTimeKind.Local).AddTicks(9768));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 29, 21, 20, 57, 232, DateTimeKind.Local).AddTicks(9768),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 12, 27, 11, 2, 46, 813, DateTimeKind.Local).AddTicks(7644));
        }
    }
}
