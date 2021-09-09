using Microsoft.EntityFrameworkCore.Migrations;

namespace InstagramApp.DataAccess.Migrations
{
    public partial class v2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tbl_Referral",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", maxLength: 50, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Referrer = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Referee = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    point = table.Column<decimal>(type: "decimal(18,2)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Referral", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbl_Referral");
        }
    }
}
