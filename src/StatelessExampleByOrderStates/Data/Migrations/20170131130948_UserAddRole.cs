using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using StatelessExampleByOrderStates.Models.Base;

namespace StatelessExampleByOrderStates.Data.Migrations
{
    public partial class UserAddRole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserRole",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: UserRole.RegionalUser);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserRole",
                table: "AspNetUsers");
        }
    }
}
