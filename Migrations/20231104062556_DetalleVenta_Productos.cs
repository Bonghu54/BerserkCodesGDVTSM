using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BerserkCodesGDVTSM.Migrations
{
    /// <inheritdoc />
    public partial class DetalleVenta_Productos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Detalle_de_venta_Venta_VentaId_Venta",
                table: "Detalle_de_venta");

            migrationBuilder.RenameColumn(
                name: "VentaId_Venta",
                table: "Detalle_de_venta",
                newName: "Id_Producto");

            migrationBuilder.RenameIndex(
                name: "IX_Detalle_de_venta_VentaId_Venta",
                table: "Detalle_de_venta",
                newName: "IX_Detalle_de_venta_Id_Producto");

            migrationBuilder.CreateIndex(
                name: "IX_Detalle_de_venta_Id_Venta",
                table: "Detalle_de_venta",
                column: "Id_Venta");

            migrationBuilder.AddForeignKey(
                name: "FK_Detalle_de_venta_Producto_Id_Producto",
                table: "Detalle_de_venta",
                column: "Id_Producto",
                principalTable: "Producto",
                principalColumn: "Id_Producto",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Detalle_de_venta_Venta_Id_Venta",
                table: "Detalle_de_venta",
                column: "Id_Venta",
                principalTable: "Venta",
                principalColumn: "Id_Venta",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Detalle_de_venta_Producto_Id_Producto",
                table: "Detalle_de_venta");

            migrationBuilder.DropForeignKey(
                name: "FK_Detalle_de_venta_Venta_Id_Venta",
                table: "Detalle_de_venta");

            migrationBuilder.DropIndex(
                name: "IX_Detalle_de_venta_Id_Venta",
                table: "Detalle_de_venta");

            migrationBuilder.RenameColumn(
                name: "Id_Producto",
                table: "Detalle_de_venta",
                newName: "VentaId_Venta");

            migrationBuilder.RenameIndex(
                name: "IX_Detalle_de_venta_Id_Producto",
                table: "Detalle_de_venta",
                newName: "IX_Detalle_de_venta_VentaId_Venta");

            migrationBuilder.AddForeignKey(
                name: "FK_Detalle_de_venta_Venta_VentaId_Venta",
                table: "Detalle_de_venta",
                column: "VentaId_Venta",
                principalTable: "Venta",
                principalColumn: "Id_Venta",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
