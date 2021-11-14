using Microsoft.EntityFrameworkCore.Migrations;

namespace Northwind.Products.Domain.Migrations
{
    public partial class InitialProductModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProductCategories",
                columns: table => new
                {
                    ProductCategoryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCategories", x => x.ProductCategoryID);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductSupplierID = table.Column<int>(type: "int", nullable: false),
                    ProductCategoryID = table.Column<int>(type: "int", nullable: false),
                    AmountPerUnit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UnitPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    UnitsOnOrder = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductID);
                });

            migrationBuilder.CreateTable(
                name: "ProductSuppliers",
                columns: table => new
                {
                    ProductSupplerID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductSuppliers", x => x.ProductSupplerID);
                });

            migrationBuilder.InsertData(
                table: "ProductCategories",
                column: "ProductCategoryID",
                value: 1);

            migrationBuilder.InsertData(
                table: "ProductSuppliers",
                column: "ProductSupplerID",
                value: 1);

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductID", "AmountPerUnit", "ProductCategoryID", "ProductName", "ProductSupplierID", "UnitPrice", "UnitsOnOrder" },
                values: new object[] { 1, null, 1, "Seiko Gold Watch", 1, 44.99m, 0m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductCategories");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "ProductSuppliers");
        }
    }
}
