using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Stocks.Data.Migrations
{
    public partial class AddedprofileEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "StockProfileEntities",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Created = table.Column<DateTimeOffset>(nullable: false),
                    Symbol = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    Beta = table.Column<decimal>(nullable: false),
                    VolAvg = table.Column<long>(nullable: false),
                    MktCap = table.Column<long>(nullable: false),
                    LastDiv = table.Column<decimal>(nullable: false),
                    Range = table.Column<string>(nullable: true),
                    Changes = table.Column<decimal>(nullable: false),
                    CompanyName = table.Column<string>(nullable: true),
                    Currency = table.Column<string>(nullable: true),
                    Cik = table.Column<string>(nullable: true),
                    Isin = table.Column<string>(nullable: true),
                    Cusip = table.Column<string>(nullable: true),
                    Exchange = table.Column<string>(nullable: true),
                    ExchangeShortName = table.Column<string>(nullable: true),
                    Industry = table.Column<string>(nullable: true),
                    Website = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Ceo = table.Column<string>(nullable: true),
                    Sector = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true),
                    FullTimeEmployees = table.Column<long>(nullable: false),
                    Phone = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    Zip = table.Column<string>(nullable: true),
                    DcfDiff = table.Column<decimal>(nullable: false),
                    Dcf = table.Column<decimal>(nullable: false),
                    Image = table.Column<string>(nullable: true),
                    IpoDate = table.Column<DateTime>(nullable: false),
                    DefaultImage = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StockProfileEntities", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StockProfileEntities");
        }
    }
}
