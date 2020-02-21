using Microsoft.EntityFrameworkCore.Migrations;

namespace Micro.Transfer.Data.Migrations
{
    public partial class addpaymentType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PaymentType",
                table: "AccountTransferLog",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PaymentType",
                table: "AccountTransferLog");
        }
    }
}