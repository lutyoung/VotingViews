using Microsoft.EntityFrameworkCore.Migrations;

namespace VotingViews.Migrations
{
    public partial class fer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ConestantVote",
                table: "Contestants",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ConestantVote",
                table: "Contestants");
        }
    }
}
