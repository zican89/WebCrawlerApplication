using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebCrawlerApplication.Migrations
{
    public partial class WebCrawlerApplicationDataWebCrawlerApplicationContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CrawlerSearch",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Crawlername = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    URL = table.Column<string>(nullable: true),
                    Expression = table.Column<string>(nullable: true),
                    HitCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CrawlerSearch", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "ID", "Email", "Password" },
                values: new object[] { 1, "test@test", "test" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CrawlerSearch");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
