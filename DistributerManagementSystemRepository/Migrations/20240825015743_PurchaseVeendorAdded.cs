using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DistributerManagementSystemRepository.Migrations
{
    /// <inheritdoc />
    public partial class PurchaseVeendorAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PurchasedByVendor",
                table: "ProductPurchaseOrderbook",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PurchasedByVendor",
                table: "ProductPurchaseOrderbook");
        }
    }
}
