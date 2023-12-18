using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    Sku = table.Column<string>(type: "text", nullable: false),
                    SkuAlias = table.Column<string>(type: "text", nullable: true),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Quantity = table.Column<int>(type: "integer", nullable: false),
                    Type = table.Column<string>(type: "text", nullable: false),
                    Vendor = table.Column<string>(type: "text", nullable: true),
                    Link = table.Column<string>(type: "text", nullable: true),
                    Material = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.Sku);
                });

            migrationBuilder.CreateTable(
                name: "Bearings",
                columns: table => new
                {
                    Sku = table.Column<string>(type: "text", nullable: false),
                    Flange = table.Column<bool>(type: "boolean", nullable: false),
                    Metric = table.Column<bool>(type: "boolean", nullable: false),
                    OuterDiameter = table.Column<double>(type: "double precision", nullable: false),
                    InnerDiameter = table.Column<double>(type: "double precision", nullable: false),
                    Width = table.Column<double>(type: "double precision", nullable: false),
                    BoreType = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bearings", x => x.Sku);
                    table.ForeignKey(
                        name: "FK_Bearings_Items_Sku",
                        column: x => x.Sku,
                        principalTable: "Items",
                        principalColumn: "Sku",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CustomItems",
                columns: table => new
                {
                    Sku = table.Column<string>(type: "text", nullable: false),
                    Custom = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomItems", x => x.Sku);
                    table.ForeignKey(
                        name: "FK_CustomItems_Items_Sku",
                        column: x => x.Sku,
                        principalTable: "Items",
                        principalColumn: "Sku",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bearings");

            migrationBuilder.DropTable(
                name: "CustomItems");

            migrationBuilder.DropTable(
                name: "Items");
        }
    }
}
