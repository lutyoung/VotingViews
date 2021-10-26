using Microsoft.EntityFrameworkCore.Migrations;

namespace VotingViews.Migrations
{
    public partial class addingGenderProptoContestantModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "Contestants",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Contestants");
        }
    }
}
