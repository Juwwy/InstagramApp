using Microsoft.EntityFrameworkCore.Migrations;

namespace InstagramApp.DataAccess.Migrations
{
    public partial class v3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "tbl_User",
                type: "nvarchar(125)",
                maxLength: 125,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Password",
                table: "tbl_User");
        }
    }
}
