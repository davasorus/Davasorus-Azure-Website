using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAPI.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppPub",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    App_Name = table.Column<string>(maxLength: 50, nullable: true),
                    App_Version = table.Column<string>(maxLength: 50, nullable: true),
                    Release_Notes = table.Column<string>(nullable: true),
                    Tansaction_DateTime = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppPub", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    RoleId = table.Column<string>(maxLength: 450, nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 450, nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    UserId = table.Column<string>(maxLength: 450, nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(maxLength: 450, nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(maxLength: 450, nullable: false),
                    RoleId = table.Column<string>(maxLength: 450, nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 450, nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(maxLength: 450, nullable: false),
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "ChannelAnalytics",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false),
                    Date = table.Column<DateTime>(type: "date", nullable: true),
                    Ad_Breaks_Minutes = table.Column<int>(nullable: true),
                    Ad_Time_Seconds_Per_Hour = table.Column<int>(nullable: true),
                    Average_Viewers = table.Column<int>(nullable: true),
                    Chat_Messages = table.Column<int>(nullable: true),
                    Chatters = table.Column<int>(nullable: true),
                    Clip_Views = table.Column<int>(nullable: true),
                    Clips_Created = table.Column<int>(nullable: true),
                    Follows = table.Column<int>(nullable: true),
                    Hosts_and_Raids_Viewers = table.Column<int>(nullable: true),
                    Live_Views = table.Column<int>(nullable: true),
                    Max_Viewers = table.Column<int>(nullable: true),
                    Minutes_Watched = table.Column<int>(nullable: true),
                    Minutes_Streamed = table.Column<int>(nullable: true),
                    Unique_Viewers = table.Column<int>(nullable: true),
                    Sub_Revenue = table.Column<int>(nullable: true),
                    Prime_Revenue = table.Column<int>(nullable: true),
                    Gifted_Subs_Revenue = table.Column<int>(nullable: true),
                    Bits_Revenue = table.Column<int>(nullable: true),
                    Ad_Revenue = table.Column<int>(nullable: true),
                    Game_Sales_Revenue = table.Column<int>(nullable: true),
                    Extensions_Revenue = table.Column<int>(nullable: true),
                    Bounties_Revenue = table.Column<int>(nullable: true),
                    Prime_Subs = table.Column<int>(nullable: true),
                    Total_Paid_Subs = table.Column<int>(nullable: true),
                    Tier_1_subs = table.Column<int>(nullable: true),
                    Total_Gifted_Subs = table.Column<int>(nullable: true),
                    Gifted_Tier_1_subs = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChannelAnalytics", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "GameType",
                columns: table => new
                {
                    GameTypeID = table.Column<int>(nullable: false),
                    GameTypeName = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GameType", x => x.GameTypeID);
                });

            migrationBuilder.CreateTable(
                name: "UserMessage",
                columns: table => new
                {
                    UserMessageID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserMessage = table.Column<string>(nullable: true),
                    TransactionDateTime = table.Column<DateTime>(name: "Transaction DateTime", type: "datetime", nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserMessage", x => x.UserMessageID);
                });

            migrationBuilder.CreateTable(
                name: "UserName",
                columns: table => new
                {
                    UserNameID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(maxLength: 50, nullable: false),
                    Is_Subscribed = table.Column<string>(maxLength: 50, nullable: true),
                    Sub_Length = table.Column<int>(nullable: true),
                    Is_Moderator = table.Column<string>(maxLength: 50, nullable: true),
                    Is_VIP = table.Column<string>(maxLength: 50, nullable: true),
                    Given_Bits = table.Column<string>(maxLength: 50, nullable: true),
                    Bit_Amount = table.Column<int>(nullable: true),
                    Founder = table.Column<string>(maxLength: 50, nullable: true),
                    TansactionDateTime = table.Column<DateTime>(name: "Tansaction DateTime", type: "datetime", nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserName", x => x.UserNameID);
                });

            migrationBuilder.CreateTable(
                name: "UserNameandMessage",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(maxLength: 50, nullable: true),
                    UserMessage = table.Column<string>(nullable: true),
                    TransactionDateTime = table.Column<DateTime>(name: "Transaction DateTime", type: "datetime", nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserNameandMessage", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GameName",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GameName = table.Column<string>(fixedLength: true, maxLength: 50, nullable: true),
                    GameTypeName = table.Column<string>(fixedLength: true, maxLength: 50, nullable: true),
                    GameTypeID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GameName", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GameName_GameType",
                        column: x => x.GameTypeID,
                        principalTable: "GameType",
                        principalColumn: "GameTypeID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GameName_GameTypeID",
                table: "GameName",
                column: "GameTypeID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppPub");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "ChannelAnalytics");

            migrationBuilder.DropTable(
                name: "GameName");

            migrationBuilder.DropTable(
                name: "UserMessage");

            migrationBuilder.DropTable(
                name: "UserName");

            migrationBuilder.DropTable(
                name: "UserNameandMessage");

            migrationBuilder.DropTable(
                name: "GameType");
        }
    }
}