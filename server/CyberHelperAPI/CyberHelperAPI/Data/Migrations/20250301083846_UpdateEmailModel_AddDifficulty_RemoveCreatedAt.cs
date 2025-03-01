using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CyberHelperAPI.Migrations
{
    /// <inheritdoc />
    public partial class UpdateEmailModel_AddDifficulty_RemoveCreatedAt : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Emails");

            migrationBuilder.AddColumn<int>(
                name: "Difficulty",
                table: "Emails",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Difficulty",
                table: "Emails");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Emails",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
