using System.ComponentModel.DataAnnotations;

namespace BerserkCodesGDVTSM.Models
{
    public class Detalle_de_venta
    {
        [Key]
        public int Id_Detalle { get; set; }
        //public int FkIdProducto { get; set; }
        //public int FkIdVenta { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio_Producto { get; set; }

        public Detalle_de_venta(int id_Detalle, int fkIdProducto, int fkIdVenta, int cantidad, decimal precio_Producto)
        {
            Id_Detalle = id_Detalle;
            //FkIdProducto = fkIdProducto;
            //FkIdVenta = fkIdVenta;
            Cantidad = cantidad;
            Precio_Producto = precio_Producto;
        }
    }
}
