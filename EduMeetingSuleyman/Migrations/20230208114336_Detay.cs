using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EduMeetingSuleyman.Migrations
{
    /// <inheritdoc />
    public partial class Detay : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Detail",
                table: "Meeting",
                type: "Text",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Detail",
                table: "Meeting");
        }
    }
}
