<<<<<<< HEAD
﻿using Microsoft.EntityFrameworkCore.Migrations;
using System;
=======
﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;
>>>>>>> Task4-APILayer

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
<<<<<<< HEAD
}
=======
}
>>>>>>> Task4-APILayer
