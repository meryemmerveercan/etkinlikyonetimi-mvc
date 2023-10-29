using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace etkinlikyonetimi.Migrations
{
    /// <inheritdoc />
    public partial class etkinlik1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UcretTip",
                table: "Etkinlik",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UcretTip",
                table: "Etkinlik");
        }
    }
}
