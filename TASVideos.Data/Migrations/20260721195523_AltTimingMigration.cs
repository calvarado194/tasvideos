using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TASVideos.Data.Migrations
{
    /// <inheritdoc />
    public partial class AltTimingMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "metric",
                table: "submissions",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "metric_value",
                table: "submissions",
                type: "citext",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "metric",
                table: "publications",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "metric_value",
                table: "publications",
                type: "citext",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "metric",
                table: "submissions");

            migrationBuilder.DropColumn(
                name: "metric_value",
                table: "submissions");

            migrationBuilder.DropColumn(
                name: "metric",
                table: "publications");

            migrationBuilder.DropColumn(
                name: "metric_value",
                table: "publications");
        }
    }
}
