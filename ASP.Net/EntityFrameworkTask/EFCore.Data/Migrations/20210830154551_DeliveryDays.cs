using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace EFCore.Data.Migrations
{
    public partial class DeliveryDays : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DeliveryTime",
                table: "Orders");

            migrationBuilder.AddColumn<int>(
                name: "DeliveryDays",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DeliveryDays",
                table: "Orders");

            migrationBuilder.AddColumn<DateTime>(
                name: "DeliveryTime",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}