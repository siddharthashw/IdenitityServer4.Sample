using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IdentityServerClient.Data.Migrations
{
    public partial class applicationuserproperty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SlackUserId",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<string>(
                name: "UserSlackId",
                table: "AspNetUsers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserSlackId",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<string>(
                name: "SlackUserId",
                table: "AspNetUsers",
                nullable: true);
        }
    }
}
