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
            migrationBuilder.DropColumn(
                name: "optimized_target_value",
                table: "submissions");

            migrationBuilder.DropColumn(
                name: "optimized_target_value",
                table: "publications");

            migrationBuilder.RenameColumn(
                name: "criteria",
                table: "submissions",
                newName: "metric");

            migrationBuilder.RenameColumn(
                name: "criteria",
                table: "publications",
                newName: "metric");

            migrationBuilder.AddColumn<string>(
                name: "metric_value",
                table: "submissions",
                type: "citext",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "metric_value",
                table: "publications",
                type: "citext",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "metric_value",
                table: "submissions");

            migrationBuilder.DropColumn(
                name: "metric_value",
                table: "publications");

            migrationBuilder.RenameColumn(
                name: "metric",
                table: "submissions",
                newName: "criteria");

            migrationBuilder.RenameColumn(
                name: "metric",
                table: "publications",
                newName: "criteria");

            migrationBuilder.AddColumn<decimal>(
                name: "optimized_target_value",
                table: "submissions",
                type: "numeric",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "optimized_target_value",
                table: "publications",
                type: "numeric",
                nullable: false,
                defaultValue: 0m);
        }
    }
}
