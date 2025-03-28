using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace server.Migrations
{
    /// <inheritdoc />
    public partial class EmailModelIconUrlAndWebsiteLink : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Footer",
                table: "Emails",
                newName: "WebsiteLink");

            migrationBuilder.AddColumn<string>(
                name: "IconUrl",
                table: "Emails",
                type: "TEXT",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IconUrl",
                table: "Emails");

            migrationBuilder.RenameColumn(
                name: "WebsiteLink",
                table: "Emails",
                newName: "Footer");
        }
    }
}
