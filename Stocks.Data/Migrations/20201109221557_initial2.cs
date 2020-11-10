using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Stocks.Data.Migrations
{
    public partial class initial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DCFs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Created = table.Column<DateTimeOffset>(nullable: false),
                    Symbol = table.Column<string>(maxLength: 10, nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    StockPrice = table.Column<decimal>(nullable: false),
                    DCF = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DCFs", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DCFs");
        }
    }
}
