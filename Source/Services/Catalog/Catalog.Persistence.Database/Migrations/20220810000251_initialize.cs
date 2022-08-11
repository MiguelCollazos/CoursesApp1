using Microsoft.EntityFrameworkCore.Migrations;

namespace Catalog.Persistence.Database.Migrations
{
    public partial class initialize : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Catalog");

            migrationBuilder.CreateTable(
                name: "Products",
                schema: "Catalog",
                columns: table => new
                {
                    ProductId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    Description = table.Column<string>(maxLength: 500, nullable: false),
                    Price = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "Stocks",
                schema: "Catalog",
                columns: table => new
                {
                    ProductInStockId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(nullable: false),
                    Stock = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stocks", x => x.ProductInStockId);
                    table.ForeignKey(
                        name: "FK_Stocks_Products_ProductId",
                        column: x => x.ProductId,
                        principalSchema: "Catalog",
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                schema: "Catalog",
                table: "Products",
                columns: new[] { "ProductId", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Description for product 1", "Product1", 176m },
                    { 73, "Description for product 73", "Product73", 143m },
                    { 72, "Description for product 72", "Product72", 734m },
                    { 71, "Description for product 71", "Product71", 668m },
                    { 70, "Description for product 70", "Product70", 466m },
                    { 69, "Description for product 69", "Product69", 396m },
                    { 68, "Description for product 68", "Product68", 559m },
                    { 67, "Description for product 67", "Product67", 731m },
                    { 66, "Description for product 66", "Product66", 300m },
                    { 65, "Description for product 65", "Product65", 952m },
                    { 64, "Description for product 64", "Product64", 149m },
                    { 63, "Description for product 63", "Product63", 282m },
                    { 62, "Description for product 62", "Product62", 581m },
                    { 61, "Description for product 61", "Product61", 494m },
                    { 60, "Description for product 60", "Product60", 275m },
                    { 59, "Description for product 59", "Product59", 707m },
                    { 58, "Description for product 58", "Product58", 969m },
                    { 57, "Description for product 57", "Product57", 120m },
                    { 56, "Description for product 56", "Product56", 892m },
                    { 55, "Description for product 55", "Product55", 711m },
                    { 54, "Description for product 54", "Product54", 166m },
                    { 53, "Description for product 53", "Product53", 449m },
                    { 74, "Description for product 74", "Product74", 101m },
                    { 52, "Description for product 52", "Product52", 672m },
                    { 75, "Description for product 75", "Product75", 638m },
                    { 77, "Description for product 77", "Product77", 744m },
                    { 98, "Description for product 98", "Product98", 489m },
                    { 97, "Description for product 97", "Product97", 107m },
                    { 96, "Description for product 96", "Product96", 637m },
                    { 95, "Description for product 95", "Product95", 294m },
                    { 94, "Description for product 94", "Product94", 415m },
                    { 93, "Description for product 93", "Product93", 161m },
                    { 92, "Description for product 92", "Product92", 390m },
                    { 91, "Description for product 91", "Product91", 830m },
                    { 90, "Description for product 90", "Product90", 236m },
                    { 89, "Description for product 89", "Product89", 116m },
                    { 88, "Description for product 88", "Product88", 461m },
                    { 87, "Description for product 87", "Product87", 483m },
                    { 86, "Description for product 86", "Product86", 935m },
                    { 85, "Description for product 85", "Product85", 516m },
                    { 84, "Description for product 84", "Product84", 871m },
                    { 83, "Description for product 83", "Product83", 130m },
                    { 82, "Description for product 82", "Product82", 563m },
                    { 81, "Description for product 81", "Product81", 396m },
                    { 80, "Description for product 80", "Product80", 361m },
                    { 79, "Description for product 79", "Product79", 708m },
                    { 78, "Description for product 78", "Product78", 661m },
                    { 76, "Description for product 76", "Product76", 706m },
                    { 51, "Description for product 51", "Product51", 107m },
                    { 50, "Description for product 50", "Product50", 807m },
                    { 49, "Description for product 49", "Product49", 509m },
                    { 22, "Description for product 22", "Product22", 283m },
                    { 21, "Description for product 21", "Product21", 896m },
                    { 20, "Description for product 20", "Product20", 757m },
                    { 19, "Description for product 19", "Product19", 690m },
                    { 18, "Description for product 18", "Product18", 634m },
                    { 17, "Description for product 17", "Product17", 503m },
                    { 16, "Description for product 16", "Product16", 928m },
                    { 15, "Description for product 15", "Product15", 317m },
                    { 14, "Description for product 14", "Product14", 425m },
                    { 13, "Description for product 13", "Product13", 287m },
                    { 12, "Description for product 12", "Product12", 258m },
                    { 11, "Description for product 11", "Product11", 133m },
                    { 10, "Description for product 10", "Product10", 560m },
                    { 9, "Description for product 9", "Product9", 573m },
                    { 8, "Description for product 8", "Product8", 861m },
                    { 7, "Description for product 7", "Product7", 120m },
                    { 6, "Description for product 6", "Product6", 151m },
                    { 5, "Description for product 5", "Product5", 897m },
                    { 4, "Description for product 4", "Product4", 486m },
                    { 3, "Description for product 3", "Product3", 497m },
                    { 2, "Description for product 2", "Product2", 994m },
                    { 23, "Description for product 23", "Product23", 973m },
                    { 24, "Description for product 24", "Product24", 528m },
                    { 25, "Description for product 25", "Product25", 779m },
                    { 26, "Description for product 26", "Product26", 722m },
                    { 48, "Description for product 48", "Product48", 194m },
                    { 47, "Description for product 47", "Product47", 425m },
                    { 46, "Description for product 46", "Product46", 517m },
                    { 45, "Description for product 45", "Product45", 819m },
                    { 44, "Description for product 44", "Product44", 412m },
                    { 43, "Description for product 43", "Product43", 538m },
                    { 42, "Description for product 42", "Product42", 289m },
                    { 41, "Description for product 41", "Product41", 218m },
                    { 40, "Description for product 40", "Product40", 688m },
                    { 39, "Description for product 39", "Product39", 590m },
                    { 99, "Description for product 99", "Product99", 459m },
                    { 38, "Description for product 38", "Product38", 768m },
                    { 36, "Description for product 36", "Product36", 851m },
                    { 35, "Description for product 35", "Product35", 128m },
                    { 34, "Description for product 34", "Product34", 728m },
                    { 33, "Description for product 33", "Product33", 527m },
                    { 32, "Description for product 32", "Product32", 833m },
                    { 31, "Description for product 31", "Product31", 607m },
                    { 30, "Description for product 30", "Product30", 524m },
                    { 29, "Description for product 29", "Product29", 678m },
                    { 28, "Description for product 28", "Product28", 539m },
                    { 27, "Description for product 27", "Product27", 657m },
                    { 37, "Description for product 37", "Product37", 360m },
                    { 100, "Description for product 100", "Product100", 618m }
                });

            migrationBuilder.InsertData(
                schema: "Catalog",
                table: "Stocks",
                columns: new[] { "ProductInStockId", "ProductId", "Stock" },
                values: new object[,]
                {
                    { 1, 1, 15 },
                    { 73, 73, 13 },
                    { 72, 72, 5 },
                    { 71, 71, 9 },
                    { 70, 70, 12 },
                    { 69, 69, 16 },
                    { 68, 68, 2 },
                    { 67, 67, 3 },
                    { 66, 66, 8 },
                    { 65, 65, 15 },
                    { 64, 64, 11 },
                    { 63, 63, 3 },
                    { 62, 62, 14 },
                    { 61, 61, 9 },
                    { 60, 60, 6 },
                    { 59, 59, 10 },
                    { 58, 58, 15 },
                    { 57, 57, 13 },
                    { 56, 56, 12 },
                    { 55, 55, 15 },
                    { 54, 54, 15 },
                    { 53, 53, 9 },
                    { 74, 74, 5 },
                    { 52, 52, 15 },
                    { 75, 75, 5 },
                    { 77, 77, 6 },
                    { 98, 98, 5 },
                    { 97, 97, 9 },
                    { 96, 96, 4 },
                    { 95, 95, 1 },
                    { 94, 94, 17 },
                    { 93, 93, 1 },
                    { 92, 92, 2 },
                    { 91, 91, 2 },
                    { 90, 90, 16 },
                    { 89, 89, 17 },
                    { 88, 88, 11 },
                    { 87, 87, 1 },
                    { 86, 86, 10 },
                    { 85, 85, 6 },
                    { 84, 84, 3 },
                    { 83, 83, 13 },
                    { 82, 82, 9 },
                    { 81, 81, 8 },
                    { 80, 80, 4 },
                    { 79, 79, 10 },
                    { 78, 78, 14 },
                    { 76, 76, 3 },
                    { 51, 51, 19 },
                    { 50, 50, 13 },
                    { 49, 49, 8 },
                    { 22, 22, 2 },
                    { 21, 21, 17 },
                    { 20, 20, 4 },
                    { 19, 19, 16 },
                    { 18, 18, 17 },
                    { 17, 17, 16 },
                    { 16, 16, 7 },
                    { 15, 15, 7 },
                    { 14, 14, 5 },
                    { 13, 13, 16 },
                    { 12, 12, 10 },
                    { 11, 11, 0 },
                    { 10, 10, 1 },
                    { 9, 9, 17 },
                    { 8, 8, 1 },
                    { 7, 7, 16 },
                    { 6, 6, 7 },
                    { 5, 5, 10 },
                    { 4, 4, 0 },
                    { 3, 3, 1 },
                    { 2, 2, 14 },
                    { 23, 23, 1 },
                    { 24, 24, 6 },
                    { 25, 25, 10 },
                    { 26, 26, 4 },
                    { 48, 48, 8 },
                    { 47, 47, 16 },
                    { 46, 46, 5 },
                    { 45, 45, 15 },
                    { 44, 44, 6 },
                    { 43, 43, 16 },
                    { 42, 42, 13 },
                    { 41, 41, 19 },
                    { 40, 40, 10 },
                    { 39, 39, 3 },
                    { 99, 99, 10 },
                    { 38, 38, 11 },
                    { 36, 36, 15 },
                    { 35, 35, 9 },
                    { 34, 34, 13 },
                    { 33, 33, 6 },
                    { 32, 32, 11 },
                    { 31, 31, 5 },
                    { 30, 30, 6 },
                    { 29, 29, 17 },
                    { 28, 28, 1 },
                    { 27, 27, 17 },
                    { 37, 37, 17 },
                    { 100, 100, 6 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductId",
                schema: "Catalog",
                table: "Products",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Stocks_ProductId",
                schema: "Catalog",
                table: "Stocks",
                column: "ProductId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Stocks",
                schema: "Catalog");

            migrationBuilder.DropTable(
                name: "Products",
                schema: "Catalog");
        }
    }
}
