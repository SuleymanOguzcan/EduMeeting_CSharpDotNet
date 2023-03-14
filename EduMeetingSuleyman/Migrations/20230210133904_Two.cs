using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EduMeetingSuleyman.Migrations
{
    /// <inheritdoc />
    public partial class Two : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Meeting_Category_CategoryId",
                table: "Meeting");

            migrationBuilder.InsertData(
                table: "Service",
                columns: new[] { "Id", "Decription", "DisplayIndex", "Icon", "Name" },
                values: new object[,]
                {
                    { 4, "Acikla", null, "images/service-icon-01.png", "elma" },
                    { 5, "Acikla", null, "images/service-icon-03.png", "armut" },
                    { 6, "Acikla", null, "images/service-icon-01.png", "ayva" },
                    { 7, "Acikla", null, "images/service-icon-02.png", "karpuz" },
                    { 8, "Acikla", null, "images/service-icon-01.png", "erik" },
                    { 9, "Acikla", null, "images/service-icon-03.png", "muz" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Meeting_Category_CategoryId",
                table: "Meeting",
                column: "CategoryId",
                principalTable: "Category",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Meeting_Category_CategoryId",
                table: "Meeting");

            migrationBuilder.DeleteData(
                table: "Service",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Service",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Service",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Service",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Service",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Service",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.AddForeignKey(
                name: "FK_Meeting_Category_CategoryId",
                table: "Meeting",
                column: "CategoryId",
                principalTable: "Category",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }
    }
}
