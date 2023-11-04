using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BerserkCodesGDVTSM.Migrations
{
    /// <inheritdoc />
    public partial class Producto_DetalleProducto : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Id_Producto",
                table: "Detalle_Producto",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Detalle_Producto_Id_Producto",
                table: "Detalle_Producto",
                column: "Id_Producto");

            migrationBuilder.AddForeignKey(
                name: "FK_Detalle_Producto_Producto_Id_Producto",
                table: "Detalle_Producto",
                column: "Id_Producto",
                principalTable: "Producto",
                principalColumn: "Id_Producto",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Detalle_Producto_Producto_Id_Producto",
                table: "Detalle_Producto");

            migrationBuilder.DropIndex(
                name: "IX_Detalle_Producto_Id_Producto",
                table: "Detalle_Producto");

            migrationBuilder.DropColumn(
                name: "Id_Producto",
                table: "Detalle_Producto");
        }
    }
}
