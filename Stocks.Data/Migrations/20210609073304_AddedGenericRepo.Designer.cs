﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Stocks.Data.Contexts;

namespace Stocks.Data.Migrations
{
    [DbContext(typeof(StocksContext))]
    [Migration("20210609073304_AddedGenericRepo")]
    partial class AddedGenericRepo
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Stocks.Data.Entities.DCF.Historical_discounted_cash_flow_Entity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTimeOffset>("Created")
                        .HasColumnType("datetimeoffset");

                    b.Property<decimal>("DCF")
                        .HasColumnType("decimal(15,2)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("StockPrice")
                        .HasColumnType("decimal(15,2)");

                    b.Property<string>("Symbol")
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.HasKey("Id");

                    b.ToTable("DCFs");
                });

            modelBuilder.Entity("Stocks.Data.Entities.Dividend.DividendCalendarEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("AdjDividend")
                        .HasColumnType("decimal(15,2)");

                    b.Property<DateTimeOffset>("Created")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeclarationDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Dividend")
                        .HasColumnType("decimal(15,2)");

                    b.Property<string>("Label")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("PaymentDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(15,2)");

                    b.Property<DateTime?>("RecordDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Symbol")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("DividendCalendarEntities");
                });

            modelBuilder.Entity("Stocks.Data.Entities.Dividend.DividendCalendarEntity2", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("AdjDividend")
                        .HasColumnType("decimal(15,2)");

                    b.Property<DateTimeOffset>("Created")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeclarationDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Dividend")
                        .HasColumnType("decimal(15,2)");

                    b.Property<string>("Label")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("PaymentDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("RecordDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Symbol")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("DividendCalendarEntities2");
                });

            modelBuilder.Entity("Stocks.Data.Entities.FinancialStatements.BalanceSheetEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("AcceptedDate")
                        .HasColumnType("datetime2");

                    b.Property<long?>("AccountPayables")
                        .HasColumnType("bigint");

                    b.Property<long?>("AccumulatedOtherComprehensiveIncomeLoss")
                        .HasColumnType("bigint");

                    b.Property<long?>("CashAndCashEquivalents")
                        .HasColumnType("bigint");

                    b.Property<long?>("CashAndShortTermInvestments")
                        .HasColumnType("bigint");

                    b.Property<long?>("CommonStock")
                        .HasColumnType("bigint");

                    b.Property<DateTimeOffset>("Created")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<long?>("DeferredRevenue")
                        .HasColumnType("bigint");

                    b.Property<long?>("DeferredRevenueNonCurrent")
                        .HasColumnType("bigint");

                    b.Property<long?>("DeferredTaxLiabilitiesNonCurrent")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("FillingDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FinalLink")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("Goodwill")
                        .HasColumnType("bigint");

                    b.Property<long?>("GoodwillAndIntangibleAssets")
                        .HasColumnType("bigint");

                    b.Property<long?>("IntangibleAssets")
                        .HasColumnType("bigint");

                    b.Property<long?>("Inventory")
                        .HasColumnType("bigint");

                    b.Property<string>("Link")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("LongTermDebt")
                        .HasColumnType("bigint");

                    b.Property<long?>("LongTermInvestments")
                        .HasColumnType("bigint");

                    b.Property<long?>("NetDebt")
                        .HasColumnType("bigint");

                    b.Property<long?>("NetReceivables")
                        .HasColumnType("bigint");

                    b.Property<long?>("OtherAssets")
                        .HasColumnType("bigint");

                    b.Property<long?>("OtherCurrentAssets")
                        .HasColumnType("bigint");

                    b.Property<long?>("OtherCurrentLiabilities")
                        .HasColumnType("bigint");

                    b.Property<long?>("OtherLiabilities")
                        .HasColumnType("bigint");

                    b.Property<long?>("OtherNonCurrentAssets")
                        .HasColumnType("bigint");

                    b.Property<long?>("OtherNonCurrentLiabilities")
                        .HasColumnType("bigint");

                    b.Property<long?>("OthertotalStockholdersEquity")
                        .HasColumnType("bigint");

                    b.Property<string>("Period")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("PropertyPlantEquipmentNet")
                        .HasColumnType("bigint");

                    b.Property<long?>("RetainedEarnings")
                        .HasColumnType("bigint");

                    b.Property<long?>("ShortTermDebt")
                        .HasColumnType("bigint");

                    b.Property<long?>("ShortTermInvestments")
                        .HasColumnType("bigint");

                    b.Property<string>("Symbol")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("TaxAssets")
                        .HasColumnType("bigint");

                    b.Property<long?>("TaxPayables")
                        .HasColumnType("bigint");

                    b.Property<long?>("TotalAssets")
                        .HasColumnType("bigint");

                    b.Property<long?>("TotalCurrentAssets")
                        .HasColumnType("bigint");

                    b.Property<long?>("TotalCurrentLiabilities")
                        .HasColumnType("bigint");

                    b.Property<long?>("TotalDebt")
                        .HasColumnType("bigint");

                    b.Property<long?>("TotalInvestments")
                        .HasColumnType("bigint");

                    b.Property<long?>("TotalLiabilities")
                        .HasColumnType("bigint");

                    b.Property<long?>("TotalLiabilitiesAndStockholdersEquity")
                        .HasColumnType("bigint");

                    b.Property<long?>("TotalNonCurrentAssets")
                        .HasColumnType("bigint");

                    b.Property<long?>("TotalNonCurrentLiabilities")
                        .HasColumnType("bigint");

                    b.Property<long?>("TotalStockholdersEquity")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.ToTable("BalanceSheetEntities");
                });

            modelBuilder.Entity("Stocks.Data.Entities.FinancialStatements.IncomeStatementEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("AcceptedDate")
                        .HasColumnType("datetime2");

                    b.Property<long>("AccountsPayables")
                        .HasColumnType("bigint");

                    b.Property<long>("AccountsReceivables")
                        .HasColumnType("bigint");

                    b.Property<long>("AcquisitionsNet")
                        .HasColumnType("bigint");

                    b.Property<long>("CapitalExpenditure")
                        .HasColumnType("bigint");

                    b.Property<long>("CashAtBeginningOfPeriod")
                        .HasColumnType("bigint");

                    b.Property<long>("CashAtEndOfPeriod")
                        .HasColumnType("bigint");

                    b.Property<long>("ChangeInWorkingCapital")
                        .HasColumnType("bigint");

                    b.Property<long>("CommonStockIssued")
                        .HasColumnType("bigint");

                    b.Property<long>("CommonStockRepurchased")
                        .HasColumnType("bigint");

                    b.Property<DateTimeOffset>("Created")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<long>("DebtRepayment")
                        .HasColumnType("bigint");

                    b.Property<long>("DeferredIncomeTax")
                        .HasColumnType("bigint");

                    b.Property<long>("DepreciationAndAmortization")
                        .HasColumnType("bigint");

                    b.Property<long>("DividendsPaid")
                        .HasColumnType("bigint");

                    b.Property<long>("EffectOfForexChangesOnCash")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("FillingDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FinalLink")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("FreeCashFlow")
                        .HasColumnType("bigint");

                    b.Property<long>("Inventory")
                        .HasColumnType("bigint");

                    b.Property<long>("InvestmentsInPropertyPlantAndEquipment")
                        .HasColumnType("bigint");

                    b.Property<string>("Link")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("NetCashProvidedByOperatingActivities")
                        .HasColumnType("bigint");

                    b.Property<long>("NetCashUsedForInvestingActivites")
                        .HasColumnType("bigint");

                    b.Property<long>("NetCashUsedProvidedByFinancingActivities")
                        .HasColumnType("bigint");

                    b.Property<long>("NetChangeInCash")
                        .HasColumnType("bigint");

                    b.Property<long>("NetIncome")
                        .HasColumnType("bigint");

                    b.Property<long>("OperatingCashFlow")
                        .HasColumnType("bigint");

                    b.Property<long>("OtherFinancingActivites")
                        .HasColumnType("bigint");

                    b.Property<long>("OtherInvestingActivites")
                        .HasColumnType("bigint");

                    b.Property<long>("OtherNonCashItems")
                        .HasColumnType("bigint");

                    b.Property<long>("OtherWorkingCapital")
                        .HasColumnType("bigint");

                    b.Property<string>("Period")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("PurchasesOfInvestments")
                        .HasColumnType("bigint");

                    b.Property<long>("SalesMaturitiesOfInvestments")
                        .HasColumnType("bigint");

                    b.Property<long>("StockBasedCompensation")
                        .HasColumnType("bigint");

                    b.Property<string>("Symbol")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("IncomeStatementEntities");
                });

            modelBuilder.Entity("Stocks.Data.Entities.Index.SPYconstituentEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AddedSecurity")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<DateTimeOffset>("Created")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("DateAdded")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Reason")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("RemovedSecurity")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("RemovedTicker")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Symbol")
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.HasKey("Id");

                    b.ToTable("SPYconstituentEntities");
                });

            modelBuilder.Entity("Stocks.Data.Entities.Portfolio.PortfolioEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(15,2)");

                    b.Property<decimal>("BuyPrice")
                        .HasColumnType("decimal(15,2)");

                    b.Property<DateTimeOffset>("Created")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset?>("Deleted")
                        .HasColumnType("datetimeoffset");

                    b.Property<Guid>("StockId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Ticker")
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.HasKey("Id");

                    b.ToTable("Portfolio");
                });

            modelBuilder.Entity("Stocks.Data.Entities.Profile.StockProfileEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("Beta")
                        .HasColumnType("decimal(15,2)");

                    b.Property<string>("Ceo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("Changes")
                        .HasColumnType("decimal(15,2)");

                    b.Property<string>("Cik")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("Created")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Currency")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cusip")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("Dcf")
                        .HasColumnType("decimal(15,2)");

                    b.Property<decimal?>("DcfDiff")
                        .HasColumnType("decimal(15,2)");

                    b.Property<bool?>("DefaultImage")
                        .HasColumnType("bit");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Exchange")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExchangeShortName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("FullTimeEmployees")
                        .HasColumnType("bigint");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Industry")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("IpoDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Isin")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("LastDiv")
                        .HasColumnType("decimal(15,2)");

                    b.Property<long?>("MktCap")
                        .HasColumnType("bigint");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(15,2)");

                    b.Property<string>("Range")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sector")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Symbol")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("VolAvg")
                        .HasColumnType("bigint");

                    b.Property<string>("Website")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Zip")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("StockProfileEntities");
                });

            modelBuilder.Entity("Stocks.Data.Entities.Reddit.Link_Flair_Richtext", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("RedditDdEntityId")
                        .HasColumnType("int");

                    b.Property<string>("e")
                        .HasColumnType("nvarchar(1032)")
                        .HasMaxLength(1032);

                    b.Property<string>("t")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("RedditDdEntityId");

                    b.ToTable("Link_Flair_Richtext");
                });

            modelBuilder.Entity("Stocks.Data.Entities.Reddit.RedditDdEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTimeOffset>("Created")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("RedditId")
                        .HasColumnType("nvarchar(1032)")
                        .HasMaxLength(1032);

                    b.Property<bool>("allow_live_comments")
                        .HasColumnType("bit");

                    b.Property<bool>("archived")
                        .HasColumnType("bit");

                    b.Property<string>("author")
                        .HasColumnType("nvarchar(1032)")
                        .HasMaxLength(1032);

                    b.Property<string>("author_flair_background_color")
                        .HasColumnType("nvarchar(1032)")
                        .HasMaxLength(1032);

                    b.Property<string>("author_flair_template_id")
                        .HasColumnType("nvarchar(1032)")
                        .HasMaxLength(1032);

                    b.Property<string>("author_flair_text")
                        .HasColumnType("nvarchar(1032)")
                        .HasMaxLength(1032);

                    b.Property<string>("author_flair_text_color")
                        .HasColumnType("nvarchar(1032)")
                        .HasMaxLength(1032);

                    b.Property<string>("author_flair_type")
                        .HasColumnType("nvarchar(1032)")
                        .HasMaxLength(1032);

                    b.Property<string>("author_fullname")
                        .HasColumnType("nvarchar(1032)")
                        .HasMaxLength(1032);

                    b.Property<bool>("author_patreon_flair")
                        .HasColumnType("bit");

                    b.Property<bool>("author_premium")
                        .HasColumnType("bit");

                    b.Property<bool>("can_gild")
                        .HasColumnType("bit");

                    b.Property<bool>("can_mod_post")
                        .HasColumnType("bit");

                    b.Property<bool>("clicked")
                        .HasColumnType("bit");

                    b.Property<bool>("contest_mode")
                        .HasColumnType("bit");

                    b.Property<float>("created_utc")
                        .HasColumnType("real");

                    b.Property<string>("domain")
                        .HasColumnType("nvarchar(1032)")
                        .HasMaxLength(1032);

                    b.Property<int>("downs")
                        .HasColumnType("int");

                    b.Property<int>("gilded")
                        .HasColumnType("int");

                    b.Property<bool>("hidden")
                        .HasColumnType("bit");

                    b.Property<bool>("hide_score")
                        .HasColumnType("bit");

                    b.Property<bool>("is_crosspostable")
                        .HasColumnType("bit");

                    b.Property<bool>("is_meta")
                        .HasColumnType("bit");

                    b.Property<bool>("is_original_content")
                        .HasColumnType("bit");

                    b.Property<bool>("is_reddit_media_domain")
                        .HasColumnType("bit");

                    b.Property<bool>("is_robot_indexable")
                        .HasColumnType("bit");

                    b.Property<bool>("is_self")
                        .HasColumnType("bit");

                    b.Property<bool>("is_video")
                        .HasColumnType("bit");

                    b.Property<bool?>("likes")
                        .HasColumnType("bit");

                    b.Property<string>("link_flair_background_color")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("link_flair_css_class")
                        .HasColumnType("nvarchar(1032)")
                        .HasMaxLength(1032);

                    b.Property<string>("link_flair_template_id")
                        .HasColumnType("nvarchar(1032)")
                        .HasMaxLength(1032);

                    b.Property<string>("link_flair_text")
                        .HasColumnType("nvarchar(1032)")
                        .HasMaxLength(1032);

                    b.Property<string>("link_flair_text_color")
                        .HasColumnType("nvarchar(1032)")
                        .HasMaxLength(1032);

                    b.Property<string>("link_flair_type")
                        .HasColumnType("nvarchar(1032)")
                        .HasMaxLength(1032);

                    b.Property<bool>("locked")
                        .HasColumnType("bit");

                    b.Property<bool>("media_only")
                        .HasColumnType("bit");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(1032)")
                        .HasMaxLength(1032);

                    b.Property<bool>("no_follow")
                        .HasColumnType("bit");

                    b.Property<int>("num_comments")
                        .HasColumnType("int");

                    b.Property<int>("num_crossposts")
                        .HasColumnType("int");

                    b.Property<bool>("over_18")
                        .HasColumnType("bit");

                    b.Property<string>("parent_whitelist_status")
                        .HasColumnType("nvarchar(1032)")
                        .HasMaxLength(1032);

                    b.Property<string>("permalink")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("pinned")
                        .HasColumnType("bit");

                    b.Property<string>("post_hint")
                        .HasColumnType("nvarchar(1032)")
                        .HasMaxLength(1032);

                    b.Property<bool>("quarantine")
                        .HasColumnType("bit");

                    b.Property<bool>("saved")
                        .HasColumnType("bit");

                    b.Property<int>("score")
                        .HasColumnType("int");

                    b.Property<string>("selftext")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("selftext_html")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("send_replies")
                        .HasColumnType("bit");

                    b.Property<bool>("spoiler")
                        .HasColumnType("bit");

                    b.Property<bool>("stickied")
                        .HasColumnType("bit");

                    b.Property<string>("subreddit")
                        .HasColumnType("nvarchar(1032)")
                        .HasMaxLength(1032);

                    b.Property<string>("subreddit_id")
                        .HasColumnType("nvarchar(1032)")
                        .HasMaxLength(1032);

                    b.Property<string>("subreddit_name_prefixed")
                        .HasColumnType("nvarchar(1032)")
                        .HasMaxLength(1032);

                    b.Property<int>("subreddit_subscribers")
                        .HasColumnType("int");

                    b.Property<string>("subreddit_type")
                        .HasColumnType("nvarchar(1032)")
                        .HasMaxLength(1032);

                    b.Property<string>("suggested_sort")
                        .HasColumnType("nvarchar(1032)")
                        .HasMaxLength(1032);

                    b.Property<string>("thumbnail")
                        .HasColumnType("nvarchar(1032)")
                        .HasMaxLength(1032);

                    b.Property<int?>("thumbnail_height")
                        .HasColumnType("int");

                    b.Property<int?>("thumbnail_width")
                        .HasColumnType("int");

                    b.Property<string>("title")
                        .HasColumnType("nvarchar(1032)")
                        .HasMaxLength(1032);

                    b.Property<int>("total_awards_received")
                        .HasColumnType("int");

                    b.Property<int>("ups")
                        .HasColumnType("int");

                    b.Property<float>("upvote_ratio")
                        .HasColumnType("real");

                    b.Property<string>("url")
                        .HasColumnType("nvarchar(1032)")
                        .HasMaxLength(1032);

                    b.Property<bool>("visited")
                        .HasColumnType("bit");

                    b.Property<string>("whitelist_status")
                        .HasColumnType("nvarchar(1032)")
                        .HasMaxLength(1032);

                    b.Property<int?>("wls")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("RedditDdEntities");
                });

            modelBuilder.Entity("Stocks.Data.Entities.ShortSqueezeNotifications", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTimeOffset>("Created")
                        .HasColumnType("datetimeoffset");

                    b.Property<int>("Limit")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset>("Notified")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Symbol")
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.HasKey("Id");

                    b.ToTable("ShortSqueezeNotifications");
                });

            modelBuilder.Entity("Stocks.Data.Entities.StockPrice.StockPriceEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(15,2)");

                    b.Property<string>("Symbol")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Volume")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("StockPriceEntities");
                });

            modelBuilder.Entity("Stocks.Data.Entities.StockPrice.StockPriceHistoricEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("AdjClose")
                        .HasColumnType("decimal(15,2)");

                    b.Property<decimal>("Change")
                        .HasColumnType("decimal(15,2)");

                    b.Property<decimal>("ChangeOverTime")
                        .HasColumnType("decimal(15,2)");

                    b.Property<decimal>("ChangePercent")
                        .HasColumnType("decimal(15,2)");

                    b.Property<decimal>("Close")
                        .HasColumnType("decimal(15,2)");

                    b.Property<DateTimeOffset>("Created")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("High")
                        .HasColumnType("decimal(15,2)");

                    b.Property<string>("Label")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Low")
                        .HasColumnType("decimal(15,2)");

                    b.Property<decimal>("Open")
                        .HasColumnType("decimal(15,2)");

                    b.Property<string>("Symbol")
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<long>("UnadjustedVolume")
                        .HasColumnType("bigint");

                    b.Property<long>("Volume")
                        .HasColumnType("bigint");

                    b.Property<decimal>("Vwap")
                        .HasColumnType("decimal(15,2)");

                    b.HasKey("Id");

                    b.ToTable("StockPriceHistoricEntities");
                });

            modelBuilder.Entity("Stocks.Data.Entities.YahooFinance.YahooFinanceOptionEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTimeOffset>("Created")
                        .HasColumnType("datetimeoffset");

                    b.Property<int>("OpenInterest")
                        .HasColumnType("int");

                    b.Property<string>("OptionName")
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<decimal>("StrikePrice")
                        .HasColumnType("decimal(15,2)");

                    b.Property<string>("Ticker")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<byte>("Type")
                        .HasColumnType("tinyint");

                    b.HasKey("Id");

                    b.ToTable("YahooFinanceOptionEntities");
                });

            modelBuilder.Entity("Stocks.Data.Entities.Reddit.Link_Flair_Richtext", b =>
                {
                    b.HasOne("Stocks.Data.Entities.Reddit.RedditDdEntity", null)
                        .WithMany("link_flair_richtext")
                        .HasForeignKey("RedditDdEntityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
