using Microsoft.EntityFrameworkCore.Migrations;

namespace Micro.Transfer.Data.Migrations
{
    public partial class PaymentStatus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PaymentStatus",
                table: "AccountTransferLog",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PaymentStatus",
                table: "AccountTransferLog");
        }
    }
}