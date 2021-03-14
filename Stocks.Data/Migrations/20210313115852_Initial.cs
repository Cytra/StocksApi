using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Stocks.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BalanceSheetEntities",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Created = table.Column<DateTimeOffset>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    Symbol = table.Column<string>(nullable: true),
                    FillingDate = table.Column<DateTime>(nullable: true),
                    AcceptedDate = table.Column<DateTime>(nullable: true),
                    Period = table.Column<string>(nullable: true),
                    CashAndCashEquivalents = table.Column<long>(nullable: true),
                    ShortTermInvestments = table.Column<long>(nullable: true),
                    CashAndShortTermInvestments = table.Column<long>(nullable: true),
                    NetReceivables = table.Column<long>(nullable: true),
                    Inventory = table.Column<long>(nullable: true),
                    OtherCurrentAssets = table.Column<long>(nullable: true),
                    TotalCurrentAssets = table.Column<long>(nullable: true),
                    PropertyPlantEquipmentNet = table.Column<long>(nullable: true),
                    Goodwill = table.Column<long>(nullable: true),
                    IntangibleAssets = table.Column<long>(nullable: true),
                    GoodwillAndIntangibleAssets = table.Column<long>(nullable: true),
                    LongTermInvestments = table.Column<long>(nullable: true),
                    TaxAssets = table.Column<long>(nullable: true),
                    OtherNonCurrentAssets = table.Column<long>(nullable: true),
                    TotalNonCurrentAssets = table.Column<long>(nullable: true),
                    OtherAssets = table.Column<long>(nullable: true),
                    TotalAssets = table.Column<long>(nullable: true),
                    AccountPayables = table.Column<long>(nullable: true),
                    ShortTermDebt = table.Column<long>(nullable: true),
                    TaxPayables = table.Column<long>(nullable: true),
                    DeferredRevenue = table.Column<long>(nullable: true),
                    OtherCurrentLiabilities = table.Column<long>(nullable: true),
                    TotalCurrentLiabilities = table.Column<long>(nullable: true),
                    LongTermDebt = table.Column<long>(nullable: true),
                    DeferredRevenueNonCurrent = table.Column<long>(nullable: true),
                    DeferredTaxLiabilitiesNonCurrent = table.Column<long>(nullable: true),
                    OtherNonCurrentLiabilities = table.Column<long>(nullable: true),
                    TotalNonCurrentLiabilities = table.Column<long>(nullable: true),
                    OtherLiabilities = table.Column<long>(nullable: true),
                    TotalLiabilities = table.Column<long>(nullable: true),
                    CommonStock = table.Column<long>(nullable: true),
                    RetainedEarnings = table.Column<long>(nullable: true),
                    AccumulatedOtherComprehensiveIncomeLoss = table.Column<long>(nullable: true),
                    OthertotalStockholdersEquity = table.Column<long>(nullable: true),
                    TotalStockholdersEquity = table.Column<long>(nullable: true),
                    TotalLiabilitiesAndStockholdersEquity = table.Column<long>(nullable: true),
                    TotalInvestments = table.Column<long>(nullable: true),
                    TotalDebt = table.Column<long>(nullable: true),
                    NetDebt = table.Column<long>(nullable: true),
                    Link = table.Column<string>(nullable: true),
                    FinalLink = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BalanceSheetEntities", x => x.Id);
                });

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

            migrationBuilder.CreateTable(
                name: "DividendCalendarEntities",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Created = table.Column<DateTimeOffset>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    Label = table.Column<string>(nullable: true),
                    AdjDividend = table.Column<decimal>(nullable: false),
                    Symbol = table.Column<string>(nullable: true),
                    Dividend = table.Column<decimal>(nullable: false),
                    RecordDate = table.Column<DateTime>(nullable: true),
                    PaymentDate = table.Column<DateTime>(nullable: true),
                    DeclarationDate = table.Column<DateTime>(nullable: true),
                    Price = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DividendCalendarEntities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DividendCalendarEntities2",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Created = table.Column<DateTimeOffset>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    Label = table.Column<string>(nullable: true),
                    AdjDividend = table.Column<decimal>(nullable: false),
                    Symbol = table.Column<string>(nullable: true),
                    Dividend = table.Column<decimal>(nullable: false),
                    RecordDate = table.Column<DateTime>(nullable: true),
                    PaymentDate = table.Column<DateTime>(nullable: true),
                    DeclarationDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DividendCalendarEntities2", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "IncomeStatementEntities",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Created = table.Column<DateTimeOffset>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    Symbol = table.Column<string>(nullable: true),
                    FillingDate = table.Column<DateTime>(nullable: true),
                    AcceptedDate = table.Column<DateTime>(nullable: true),
                    Period = table.Column<string>(nullable: true),
                    NetIncome = table.Column<long>(nullable: false),
                    DepreciationAndAmortization = table.Column<long>(nullable: false),
                    DeferredIncomeTax = table.Column<long>(nullable: false),
                    StockBasedCompensation = table.Column<long>(nullable: false),
                    ChangeInWorkingCapital = table.Column<long>(nullable: false),
                    AccountsReceivables = table.Column<long>(nullable: false),
                    Inventory = table.Column<long>(nullable: false),
                    AccountsPayables = table.Column<long>(nullable: false),
                    OtherWorkingCapital = table.Column<long>(nullable: false),
                    OtherNonCashItems = table.Column<long>(nullable: false),
                    NetCashProvidedByOperatingActivities = table.Column<long>(nullable: false),
                    InvestmentsInPropertyPlantAndEquipment = table.Column<long>(nullable: false),
                    AcquisitionsNet = table.Column<long>(nullable: false),
                    PurchasesOfInvestments = table.Column<long>(nullable: false),
                    SalesMaturitiesOfInvestments = table.Column<long>(nullable: false),
                    OtherInvestingActivites = table.Column<long>(nullable: false),
                    NetCashUsedForInvestingActivites = table.Column<long>(nullable: false),
                    DebtRepayment = table.Column<long>(nullable: false),
                    CommonStockIssued = table.Column<long>(nullable: false),
                    CommonStockRepurchased = table.Column<long>(nullable: false),
                    DividendsPaid = table.Column<long>(nullable: false),
                    OtherFinancingActivites = table.Column<long>(nullable: false),
                    NetCashUsedProvidedByFinancingActivities = table.Column<long>(nullable: false),
                    EffectOfForexChangesOnCash = table.Column<long>(nullable: false),
                    NetChangeInCash = table.Column<long>(nullable: false),
                    CashAtEndOfPeriod = table.Column<long>(nullable: false),
                    CashAtBeginningOfPeriod = table.Column<long>(nullable: false),
                    OperatingCashFlow = table.Column<long>(nullable: false),
                    CapitalExpenditure = table.Column<long>(nullable: false),
                    FreeCashFlow = table.Column<long>(nullable: false),
                    Link = table.Column<string>(nullable: true),
                    FinalLink = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IncomeStatementEntities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Portfolio",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Created = table.Column<DateTimeOffset>(nullable: false),
                    Ticker = table.Column<string>(maxLength: 10, nullable: true),
                    Amount = table.Column<decimal>(nullable: false),
                    BuyPrice = table.Column<decimal>(nullable: false),
                    StockId = table.Column<Guid>(nullable: false),
                    Deleted = table.Column<DateTimeOffset>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Portfolio", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RedditDdEntities",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Created = table.Column<DateTimeOffset>(nullable: false),
                    subreddit = table.Column<string>(nullable: true),
                    selftext = table.Column<string>(nullable: true),
                    author_fullname = table.Column<string>(nullable: true),
                    saved = table.Column<bool>(nullable: false),
                    gilded = table.Column<int>(nullable: false),
                    clicked = table.Column<bool>(nullable: false),
                    title = table.Column<string>(nullable: true),
                    subreddit_name_prefixed = table.Column<string>(nullable: true),
                    hidden = table.Column<bool>(nullable: false),
                    pwls = table.Column<int>(nullable: false),
                    link_flair_css_class = table.Column<string>(nullable: true),
                    downs = table.Column<int>(nullable: false),
                    thumbnail_height = table.Column<int>(nullable: true),
                    hide_score = table.Column<bool>(nullable: false),
                    name = table.Column<string>(nullable: true),
                    quarantine = table.Column<bool>(nullable: false),
                    link_flair_text_color = table.Column<string>(nullable: true),
                    upvote_ratio = table.Column<float>(nullable: false),
                    author_flair_background_color = table.Column<string>(nullable: true),
                    subreddit_type = table.Column<string>(nullable: true),
                    ups = table.Column<int>(nullable: false),
                    total_awards_received = table.Column<int>(nullable: false),
                    thumbnail_width = table.Column<int>(nullable: true),
                    author_flair_template_id = table.Column<string>(nullable: true),
                    is_original_content = table.Column<bool>(nullable: false),
                    is_reddit_media_domain = table.Column<bool>(nullable: false),
                    is_meta = table.Column<bool>(nullable: false),
                    link_flair_text = table.Column<string>(nullable: true),
                    can_mod_post = table.Column<bool>(nullable: false),
                    score = table.Column<int>(nullable: false),
                    author_premium = table.Column<bool>(nullable: false),
                    thumbnail = table.Column<string>(nullable: true),
                    is_self = table.Column<bool>(nullable: false),
                    link_flair_type = table.Column<string>(nullable: true),
                    wls = table.Column<int>(nullable: false),
                    author_flair_type = table.Column<string>(nullable: true),
                    domain = table.Column<string>(nullable: true),
                    allow_live_comments = table.Column<bool>(nullable: false),
                    selftext_html = table.Column<string>(nullable: true),
                    likes = table.Column<bool>(nullable: true),
                    suggested_sort = table.Column<string>(nullable: true),
                    archived = table.Column<bool>(nullable: false),
                    no_follow = table.Column<bool>(nullable: false),
                    is_crosspostable = table.Column<bool>(nullable: false),
                    pinned = table.Column<bool>(nullable: false),
                    over_18 = table.Column<bool>(nullable: false),
                    media_only = table.Column<bool>(nullable: false),
                    link_flair_template_id = table.Column<string>(nullable: true),
                    can_gild = table.Column<bool>(nullable: false),
                    spoiler = table.Column<bool>(nullable: false),
                    locked = table.Column<bool>(nullable: false),
                    author_flair_text = table.Column<string>(nullable: true),
                    visited = table.Column<bool>(nullable: false),
                    subreddit_id = table.Column<string>(nullable: true),
                    link_flair_background_color = table.Column<string>(nullable: true),
                    RedditId = table.Column<string>(nullable: true),
                    is_robot_indexable = table.Column<bool>(nullable: false),
                    author = table.Column<string>(nullable: true),
                    num_comments = table.Column<int>(nullable: false),
                    send_replies = table.Column<bool>(nullable: false),
                    whitelist_status = table.Column<string>(nullable: true),
                    contest_mode = table.Column<bool>(nullable: false),
                    author_patreon_flair = table.Column<bool>(nullable: false),
                    author_flair_text_color = table.Column<string>(nullable: true),
                    permalink = table.Column<string>(nullable: true),
                    parent_whitelist_status = table.Column<string>(nullable: true),
                    stickied = table.Column<bool>(nullable: false),
                    url = table.Column<string>(nullable: true),
                    subreddit_subscribers = table.Column<int>(nullable: false),
                    created_utc = table.Column<float>(nullable: false),
                    num_crossposts = table.Column<int>(nullable: false),
                    is_video = table.Column<bool>(nullable: false),
                    post_hint = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RedditDdEntities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SPYconstituentEntities",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Created = table.Column<DateTimeOffset>(nullable: false),
                    DateAdded = table.Column<string>(maxLength: 50, nullable: true),
                    AddedSecurity = table.Column<string>(maxLength: 50, nullable: true),
                    RemovedTicker = table.Column<string>(maxLength: 50, nullable: true),
                    RemovedSecurity = table.Column<string>(maxLength: 50, nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    Reason = table.Column<string>(maxLength: 200, nullable: true),
                    Symbol = table.Column<string>(maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SPYconstituentEntities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StockPriceEntities",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Symbol = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    Volume = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StockPriceEntities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StockPriceHistoricEntities",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Created = table.Column<DateTimeOffset>(nullable: false),
                    Symbol = table.Column<string>(maxLength: 30, nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    Open = table.Column<decimal>(nullable: false),
                    High = table.Column<decimal>(nullable: false),
                    Low = table.Column<decimal>(nullable: false),
                    Close = table.Column<decimal>(nullable: false),
                    AdjClose = table.Column<decimal>(nullable: false),
                    Volume = table.Column<long>(nullable: false),
                    UnadjustedVolume = table.Column<long>(nullable: false),
                    Change = table.Column<decimal>(nullable: false),
                    ChangePercent = table.Column<decimal>(nullable: false),
                    Vwap = table.Column<decimal>(nullable: false),
                    Label = table.Column<string>(nullable: true),
                    ChangeOverTime = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StockPriceHistoricEntities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StockProfileEntities",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Created = table.Column<DateTimeOffset>(nullable: false),
                    Symbol = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    Beta = table.Column<decimal>(nullable: true),
                    VolAvg = table.Column<long>(nullable: true),
                    MktCap = table.Column<long>(nullable: true),
                    LastDiv = table.Column<decimal>(nullable: true),
                    Range = table.Column<string>(nullable: true),
                    Changes = table.Column<decimal>(nullable: true),
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
                    FullTimeEmployees = table.Column<long>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    Zip = table.Column<string>(nullable: true),
                    DcfDiff = table.Column<decimal>(nullable: true),
                    Dcf = table.Column<decimal>(nullable: true),
                    Image = table.Column<string>(nullable: true),
                    IpoDate = table.Column<DateTime>(nullable: true),
                    DefaultImage = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StockProfileEntities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Link_Flair_Richtext",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RedditDdEntityId = table.Column<int>(nullable: false),
                    e = table.Column<string>(nullable: true),
                    t = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Link_Flair_Richtext", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Link_Flair_Richtext_RedditDdEntities_RedditDdEntityId",
                        column: x => x.RedditDdEntityId,
                        principalTable: "RedditDdEntities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Link_Flair_Richtext_RedditDdEntityId",
                table: "Link_Flair_Richtext",
                column: "RedditDdEntityId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BalanceSheetEntities");

            migrationBuilder.DropTable(
                name: "DCFs");

            migrationBuilder.DropTable(
                name: "DividendCalendarEntities");

            migrationBuilder.DropTable(
                name: "DividendCalendarEntities2");

            migrationBuilder.DropTable(
                name: "IncomeStatementEntities");

            migrationBuilder.DropTable(
                name: "Link_Flair_Richtext");

            migrationBuilder.DropTable(
                name: "Portfolio");

            migrationBuilder.DropTable(
                name: "SPYconstituentEntities");

            migrationBuilder.DropTable(
                name: "StockPriceEntities");

            migrationBuilder.DropTable(
                name: "StockPriceHistoricEntities");

            migrationBuilder.DropTable(
                name: "StockProfileEntities");

            migrationBuilder.DropTable(
                name: "RedditDdEntities");
        }
    }
}
