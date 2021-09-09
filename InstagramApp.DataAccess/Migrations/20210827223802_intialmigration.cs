using Microsoft.EntityFrameworkCore.Migrations;

namespace InstagramApp.DataAccess.Migrations
{
    public partial class intialmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tbl_User",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(125)", maxLength: 125, nullable: false),
                    Lastname = table.Column<string>(type: "nvarchar(125)", maxLength: 125, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(125)", maxLength: 125, nullable: false),
                    Telephone = table.Column<string>(type: "nvarchar(125)", maxLength: 125, nullable: false),
                    FcmToken = table.Column<string>(type: "nvarchar(125)", maxLength: 125, nullable: true),
                    WalletBalance = table.Column<decimal>(type: "decimal(18,2)", maxLength: 125, nullable: false),
                    ReferralCode = table.Column<string>(type: "nvarchar(125)", maxLength: 125, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_User", x => x.UserId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbl_User");
        }
    }
}
