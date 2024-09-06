using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DistributerManagementSystemRepository.Migrations
{
    /// <inheritdoc />
    public partial class AddedPaymentDueInOrderbook : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BalanceAmount",
                table: "Orderbooks",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BalanceAmount",
                table: "Orderbooks");
        }
    }
}
