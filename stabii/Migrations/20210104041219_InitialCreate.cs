using Microsoft.EntityFrameworkCore.Migrations;

namespace stabii.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    CategoryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.CategoryID);
                });

            migrationBuilder.CreateTable(
                name: "Game",
                columns: table => new
                {
                    GameID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GameName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Game", x => x.GameID);
                });

            migrationBuilder.CreateTable(
                name: "Platform",
                columns: table => new
                {
                    PlatformID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlatformName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Platform", x => x.PlatformID);
                });

            migrationBuilder.CreateTable(
                name: "Referrer",
                columns: table => new
                {
                    ReferrerID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReferrerName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Referrer", x => x.ReferrerID);
                });

            migrationBuilder.CreateTable(
                name: "CategoryGame",
                columns: table => new
                {
                    CategoriesCategoryID = table.Column<int>(type: "int", nullable: false),
                    GamesGameID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryGame", x => new { x.CategoriesCategoryID, x.GamesGameID });
                    table.ForeignKey(
                        name: "FK_CategoryGame_Category_CategoriesCategoryID",
                        column: x => x.CategoriesCategoryID,
                        principalTable: "Category",
                        principalColumn: "CategoryID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategoryGame_Game_GamesGameID",
                        column: x => x.GamesGameID,
                        principalTable: "Game",
                        principalColumn: "GameID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GamePlatform",
                columns: table => new
                {
                    GamesGameID = table.Column<int>(type: "int", nullable: false),
                    PlatformsPlatformID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GamePlatform", x => new { x.GamesGameID, x.PlatformsPlatformID });
                    table.ForeignKey(
                        name: "FK_GamePlatform_Game_GamesGameID",
                        column: x => x.GamesGameID,
                        principalTable: "Game",
                        principalColumn: "GameID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GamePlatform_Platform_PlatformsPlatformID",
                        column: x => x.PlatformsPlatformID,
                        principalTable: "Platform",
                        principalColumn: "PlatformID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GameReferrer",
                columns: table => new
                {
                    GamesGameID = table.Column<int>(type: "int", nullable: false),
                    ReferrersReferrerID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GameReferrer", x => new { x.GamesGameID, x.ReferrersReferrerID });
                    table.ForeignKey(
                        name: "FK_GameReferrer_Game_GamesGameID",
                        column: x => x.GamesGameID,
                        principalTable: "Game",
                        principalColumn: "GameID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GameReferrer_Referrer_ReferrersReferrerID",
                        column: x => x.ReferrersReferrerID,
                        principalTable: "Referrer",
                        principalColumn: "ReferrerID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CategoryGame_GamesGameID",
                table: "CategoryGame",
                column: "GamesGameID");

            migrationBuilder.CreateIndex(
                name: "IX_GamePlatform_PlatformsPlatformID",
                table: "GamePlatform",
                column: "PlatformsPlatformID");

            migrationBuilder.CreateIndex(
                name: "IX_GameReferrer_ReferrersReferrerID",
                table: "GameReferrer",
                column: "ReferrersReferrerID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CategoryGame");

            migrationBuilder.DropTable(
                name: "GamePlatform");

            migrationBuilder.DropTable(
                name: "GameReferrer");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "Platform");

            migrationBuilder.DropTable(
                name: "Game");

            migrationBuilder.DropTable(
                name: "Referrer");
        }
    }
}
