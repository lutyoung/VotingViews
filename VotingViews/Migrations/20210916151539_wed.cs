using Microsoft.EntityFrameworkCore.Migrations;

namespace VotingViews.Migrations
{
    public partial class wed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Positions_Elections_ElectionId",
                table: "Positions");

            migrationBuilder.AlterColumn<int>(
                name: "ElectionId",
                table: "Positions",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Positions_Elections_ElectionId",
                table: "Positions",
                column: "ElectionId",
                principalTable: "Elections",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Positions_Elections_ElectionId",
                table: "Positions");

            migrationBuilder.AlterColumn<int>(
                name: "ElectionId",
                table: "Positions",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Positions_Elections_ElectionId",
                table: "Positions",
                column: "ElectionId",
                principalTable: "Elections",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
