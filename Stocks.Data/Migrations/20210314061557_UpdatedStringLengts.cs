using Microsoft.EntityFrameworkCore.Migrations;

namespace Stocks.Data.Migrations
{
    public partial class UpdatedStringLengts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "pwls",
                table: "RedditDdEntities");

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "StockProfileEntities",
                type: "decimal(15,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Vwap",
                table: "StockPriceHistoricEntities",
                type: "decimal(15,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Open",
                table: "StockPriceHistoricEntities",
                type: "decimal(15,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Low",
                table: "StockPriceHistoricEntities",
                type: "decimal(15,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "High",
                table: "StockPriceHistoricEntities",
                type: "decimal(15,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Close",
                table: "StockPriceHistoricEntities",
                type: "decimal(15,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "ChangePercent",
                table: "StockPriceHistoricEntities",
                type: "decimal(15,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "ChangeOverTime",
                table: "StockPriceHistoricEntities",
                type: "decimal(15,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Change",
                table: "StockPriceHistoricEntities",
                type: "decimal(15,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "AdjClose",
                table: "StockPriceHistoricEntities",
                type: "decimal(15,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "StockPriceEntities",
                type: "decimal(15,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<string>(
                name: "whitelist_status",
                table: "RedditDdEntities",
                maxLength: 1032,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "url",
                table: "RedditDdEntities",
                maxLength: 1032,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "title",
                table: "RedditDdEntities",
                maxLength: 1032,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "thumbnail",
                table: "RedditDdEntities",
                maxLength: 1032,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "suggested_sort",
                table: "RedditDdEntities",
                maxLength: 1032,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "subreddit_type",
                table: "RedditDdEntities",
                maxLength: 1032,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "subreddit_name_prefixed",
                table: "RedditDdEntities",
                maxLength: 1032,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "subreddit_id",
                table: "RedditDdEntities",
                maxLength: 1032,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "subreddit",
                table: "RedditDdEntities",
                maxLength: 1032,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "post_hint",
                table: "RedditDdEntities",
                maxLength: 1032,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "parent_whitelist_status",
                table: "RedditDdEntities",
                maxLength: 1032,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "name",
                table: "RedditDdEntities",
                maxLength: 1032,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "link_flair_type",
                table: "RedditDdEntities",
                maxLength: 1032,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "link_flair_text_color",
                table: "RedditDdEntities",
                maxLength: 1032,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "link_flair_text",
                table: "RedditDdEntities",
                maxLength: 1032,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "link_flair_template_id",
                table: "RedditDdEntities",
                maxLength: 1032,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "link_flair_css_class",
                table: "RedditDdEntities",
                maxLength: 1032,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "domain",
                table: "RedditDdEntities",
                maxLength: 1032,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "author_fullname",
                table: "RedditDdEntities",
                maxLength: 1032,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "author_flair_type",
                table: "RedditDdEntities",
                maxLength: 1032,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "author_flair_text_color",
                table: "RedditDdEntities",
                maxLength: 1032,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "author_flair_text",
                table: "RedditDdEntities",
                maxLength: 1032,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "author_flair_template_id",
                table: "RedditDdEntities",
                maxLength: 1032,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "author_flair_background_color",
                table: "RedditDdEntities",
                maxLength: 1032,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "author",
                table: "RedditDdEntities",
                maxLength: 1032,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "RedditId",
                table: "RedditDdEntities",
                maxLength: 1032,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "BuyPrice",
                table: "Portfolio",
                type: "decimal(15,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Amount",
                table: "Portfolio",
                type: "decimal(15,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<string>(
                name: "e",
                table: "Link_Flair_Richtext",
                maxLength: 1032,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Dividend",
                table: "DividendCalendarEntities2",
                type: "decimal(15,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "AdjDividend",
                table: "DividendCalendarEntities2",
                type: "decimal(15,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "StockPrice",
                table: "DCFs",
                type: "decimal(15,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "DCF",
                table: "DCFs",
                type: "decimal(15,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "StockProfileEntities",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(15,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Vwap",
                table: "StockPriceHistoricEntities",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(15,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Open",
                table: "StockPriceHistoricEntities",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(15,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Low",
                table: "StockPriceHistoricEntities",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(15,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "High",
                table: "StockPriceHistoricEntities",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(15,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Close",
                table: "StockPriceHistoricEntities",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(15,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "ChangePercent",
                table: "StockPriceHistoricEntities",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(15,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "ChangeOverTime",
                table: "StockPriceHistoricEntities",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(15,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Change",
                table: "StockPriceHistoricEntities",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(15,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "AdjClose",
                table: "StockPriceHistoricEntities",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(15,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "StockPriceEntities",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(15,2)");

            migrationBuilder.AlterColumn<string>(
                name: "whitelist_status",
                table: "RedditDdEntities",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 1032,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "url",
                table: "RedditDdEntities",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 1032,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "title",
                table: "RedditDdEntities",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 1032,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "thumbnail",
                table: "RedditDdEntities",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 1032,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "suggested_sort",
                table: "RedditDdEntities",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 1032,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "subreddit_type",
                table: "RedditDdEntities",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 1032,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "subreddit_name_prefixed",
                table: "RedditDdEntities",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 1032,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "subreddit_id",
                table: "RedditDdEntities",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 1032,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "subreddit",
                table: "RedditDdEntities",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 1032,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "post_hint",
                table: "RedditDdEntities",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 1032,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "parent_whitelist_status",
                table: "RedditDdEntities",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 1032,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "name",
                table: "RedditDdEntities",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 1032,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "link_flair_type",
                table: "RedditDdEntities",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 1032,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "link_flair_text_color",
                table: "RedditDdEntities",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 1032,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "link_flair_text",
                table: "RedditDdEntities",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 1032,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "link_flair_template_id",
                table: "RedditDdEntities",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 1032,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "link_flair_css_class",
                table: "RedditDdEntities",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 1032,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "domain",
                table: "RedditDdEntities",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 1032,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "author_fullname",
                table: "RedditDdEntities",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 1032,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "author_flair_type",
                table: "RedditDdEntities",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 1032,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "author_flair_text_color",
                table: "RedditDdEntities",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 1032,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "author_flair_text",
                table: "RedditDdEntities",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 1032,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "author_flair_template_id",
                table: "RedditDdEntities",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 1032,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "author_flair_background_color",
                table: "RedditDdEntities",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 1032,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "author",
                table: "RedditDdEntities",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 1032,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "RedditId",
                table: "RedditDdEntities",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 1032,
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "pwls",
                table: "RedditDdEntities",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<decimal>(
                name: "BuyPrice",
                table: "Portfolio",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(15,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Amount",
                table: "Portfolio",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(15,2)");

            migrationBuilder.AlterColumn<string>(
                name: "e",
                table: "Link_Flair_Richtext",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 1032,
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Dividend",
                table: "DividendCalendarEntities2",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(15,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "AdjDividend",
                table: "DividendCalendarEntities2",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(15,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "StockPrice",
                table: "DCFs",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(15,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "DCF",
                table: "DCFs",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(15,2)");
        }
    }
}
