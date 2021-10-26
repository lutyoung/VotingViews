using Microsoft.EntityFrameworkCore.Migrations;
using MySql.Data.EntityFrameworkCore.Metadata;

namespace VotingViews.Migrations
{
    public partial class refactoring : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Votes");

            migrationBuilder.AddColumn<int>(
                name: "VoterId",
                table: "Contestants",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Contestants_VoterId",
                table: "Contestants",
                column: "VoterId");

            migrationBuilder.AddForeignKey(
                name: "FK_Contestants_Voters_VoterId",
                table: "Contestants",
                column: "VoterId",
                principalTable: "Voters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contestants_Voters_VoterId",
                table: "Contestants");

            migrationBuilder.DropIndex(
                name: "IX_Contestants_VoterId",
                table: "Contestants");

            migrationBuilder.DropColumn(
                name: "VoterId",
                table: "Contestants");

            migrationBuilder.CreateTable(
                name: "Votes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    ContestantId = table.Column<int>(type: "int", nullable: false),
                    ElectionId = table.Column<int>(type: "int", nullable: false),
                    PositionId = table.Column<int>(type: "int", nullable: false),
                    VoterId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Votes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Votes_Contestants_ContestantId",
                        column: x => x.ContestantId,
                        principalTable: "Contestants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Votes_Elections_ElectionId",
                        column: x => x.ElectionId,
                        principalTable: "Elections",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Votes_Positions_PositionId",
                        column: x => x.PositionId,
                        principalTable: "Positions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Votes_Voters_VoterId",
                        column: x => x.VoterId,
                        principalTable: "Voters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Votes_ContestantId",
                table: "Votes",
                column: "ContestantId");

            migrationBuilder.CreateIndex(
                name: "IX_Votes_ElectionId",
                table: "Votes",
                column: "ElectionId");

            migrationBuilder.CreateIndex(
                name: "IX_Votes_PositionId",
                table: "Votes",
                column: "PositionId");

            migrationBuilder.CreateIndex(
                name: "IX_Votes_VoterId",
                table: "Votes",
                column: "VoterId");
        }
    }
}
