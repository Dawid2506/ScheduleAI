using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    eMail = table.Column<string>(type: "text", nullable: false),
                    login = table.Column<string>(type: "text", nullable: false),
                    password = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WeatherForecast",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Date = table.Column<DateOnly>(type: "date", nullable: false),
                    TemperatureC = table.Column<int>(type: "integer", nullable: false),
                    TemperatureF = table.Column<int>(type: "integer", nullable: true),
                    Summary = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeatherForecast", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "WeatherForecast",
                columns: new[] { "Id", "Date", "Summary", "TemperatureC", "TemperatureF" },
                values: new object[,]
                {
                    { 1, new DateOnly(2024, 9, 18), "Sunny", 69, null },
                    { 2, new DateOnly(2024, 9, 19), "Cloudy", 15, null },
                    { 3, new DateOnly(2024, 9, 20), "Rainy", 10, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "WeatherForecast");
        }
    }
}
