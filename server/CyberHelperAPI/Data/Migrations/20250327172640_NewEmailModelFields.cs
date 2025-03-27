using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace server.Migrations
{
    /// <inheritdoc />
    public partial class NewEmailModelFields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ContactNumber",
                table: "Emails",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DisplayLink",
                table: "Emails",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Footer",
                table: "Emails",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Signature",
                table: "Emails",
                type: "TEXT",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ContactNumber",
                table: "Emails");

            migrationBuilder.DropColumn(
                name: "DisplayLink",
                table: "Emails");

            migrationBuilder.DropColumn(
                name: "Footer",
                table: "Emails");

            migrationBuilder.DropColumn(
                name: "Signature",
                table: "Emails");
        }
    }
}
