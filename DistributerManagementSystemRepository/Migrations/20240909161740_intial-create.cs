using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DistributerManagementSystemRepository.Migrations
{
    /// <inheritdoc />
    public partial class intialcreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DueDate",
                table: "Retailers");

            migrationBuilder.DropColumn(
                name: "Liters",
                table: "Products");

            migrationBuilder.RenameColumn(
                name: "MassWeight",
                table: "Products",
                newName: "Unit");

            migrationBuilder.AlterColumn<int>(
                name: "OnCredit",
                table: "Vendors",
                type: "int",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<string>(
                name: "GSTIN",
                table: "Vendors",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Vendors",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "ContactNumber",
                table: "Vendors",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Vendors",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "ContactNumber",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserType",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "OnCredit",
                table: "Retailers",
                type: "int",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Retailers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ContactNumber",
                table: "Retailers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "BuyingPrice",
                table: "Products",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "Price",
                table: "Products",
                type: "bigint",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ProductType",
                table: "Orderbooks",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "BalanceAmount",
                table: "Orderbooks",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "PaymentDueDate",
                table: "Orderbooks",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateTable(
                name: "ProductCategories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GSTPercentage = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TempId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductPurchaseOrderbook",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductCategory = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PurchasedByVendor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UnitValue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Unit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    BuyingPrice = table.Column<long>(type: "bigint", nullable: true),
                    TempId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductPurchaseOrderbook", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "ProductCategories",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "DeletedBy", "DeletedDate", "GSTPercentage", "IsActive", "Name", "TempId", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("5f9eea48-4f0b-41bf-a552-3be00362f473"), null, new DateTime(2024, 9, 9, 0, 0, 0, 0, DateTimeKind.Local), null, null, null, 12m, true, "Butter", new Guid("c52a99ef-0253-4d80-aa6e-41c8c59356ae"), null },
                    { new Guid("602a0944-b739-4c04-819f-7814d100d0be"), null, new DateTime(2024, 9, 9, 0, 0, 0, 0, DateTimeKind.Local), null, null, null, 12m, true, "Lahori Beverages", new Guid("3bcd45eb-9d6b-4cee-ae53-53b60b481ace"), null },
                    { new Guid("b0baf39f-97e9-47e0-8fdb-2b7c27369992"), null, new DateTime(2024, 9, 9, 0, 0, 0, 0, DateTimeKind.Local), null, null, null, 5m, true, "Spices", new Guid("5e5e7123-121b-47d9-a8fa-9a4c7e6419c2"), null },
                    { new Guid("b3a6650a-43e9-4077-9d73-9f152d41837f"), null, new DateTime(2024, 9, 9, 0, 0, 0, 0, DateTimeKind.Local), null, null, null, 0m, true, "General Items", new Guid("cf786134-c321-476f-a65f-2050cb0fa8b4"), null },
                    { new Guid("b6767123-9199-46fd-9415-63f6c2612f6b"), null, new DateTime(2024, 9, 9, 0, 0, 0, 0, DateTimeKind.Local), null, null, null, 18m, true, "Cakes", new Guid("1b5dbc22-55b8-433a-a793-6f48ed181cfb"), null },
                    { new Guid("dcc0f556-d268-4bd8-8e00-105e5dff9aa7"), null, new DateTime(2024, 9, 9, 0, 0, 0, 0, DateTimeKind.Local), null, null, null, 18m, true, "Beverages", new Guid("9d0fc52a-381d-478b-a5ae-87ccdfe98d44"), null },
                    { new Guid("dd7c47ee-73a3-45f2-aa91-08be964bb720"), null, new DateTime(2024, 9, 9, 0, 0, 0, 0, DateTimeKind.Local), null, null, null, 18m, true, "Biscuits", new Guid("db63b984-4eb6-4366-8483-e21dc9caa8fe"), null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductCategories");

            migrationBuilder.DropTable(
                name: "ProductPurchaseOrderbook");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "Vendors");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "UserType",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "Retailers");

            migrationBuilder.DropColumn(
                name: "ContactNumber",
                table: "Retailers");

            migrationBuilder.DropColumn(
                name: "BuyingPrice",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "BalanceAmount",
                table: "Orderbooks");

            migrationBuilder.DropColumn(
                name: "PaymentDueDate",
                table: "Orderbooks");

            migrationBuilder.RenameColumn(
                name: "Unit",
                table: "Products",
                newName: "MassWeight");

            migrationBuilder.AlterColumn<long>(
                name: "OnCredit",
                table: "Vendors",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "GSTIN",
                table: "Vendors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Vendors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ContactNumber",
                table: "Vendors",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ContactNumber",
                table: "Users",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<long>(
                name: "OnCredit",
                table: "Retailers",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<DateOnly>(
                name: "DueDate",
                table: "Retailers",
                type: "date",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1));

            migrationBuilder.AddColumn<int>(
                name: "Liters",
                table: "Products",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ProductType",
                table: "Orderbooks",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
