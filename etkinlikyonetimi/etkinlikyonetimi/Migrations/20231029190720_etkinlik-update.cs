using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace etkinlikyonetimi.Migrations
{
    /// <inheritdoc />
    public partial class etkinlikupdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Aciklama",
                table: "Etkinlik",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "Zaman",
                table: "Etkinlik",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Aciklama",
                table: "Etkinlik");

            migrationBuilder.DropColumn(
                name: "Zaman",
                table: "Etkinlik");
        }
    }
}
