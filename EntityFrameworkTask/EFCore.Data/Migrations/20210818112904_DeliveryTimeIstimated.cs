using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace EFCore.Data.Migrations
{
    public partial class DeliveryTimeIstimated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DeliveryTimeEstimated",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DeliveryTimeEstimated",
                table: "Orders");
        }
    }
}