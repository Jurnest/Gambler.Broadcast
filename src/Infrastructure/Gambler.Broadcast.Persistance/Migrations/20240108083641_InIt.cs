using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gambler.Broadcast.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class InIt : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GameProducers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProducerName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GameProducers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Situations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartMoney = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CashIn = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CashOut = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Situations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GameName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GameProducerId = table.Column<int>(type: "int", nullable: false),
                    SelfMaxEarning = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SelfMaxMultiplier = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaxMultiplier = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Rtp = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Games_GameProducers_GameProducerId",
                        column: x => x.GameProducerId,
                        principalTable: "GameProducers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Games_GameProducerId",
                table: "Games",
                column: "GameProducerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Games");

            migrationBuilder.DropTable(
                name: "Situations");

            migrationBuilder.DropTable(
                name: "GameProducers");
        }
    }
}
