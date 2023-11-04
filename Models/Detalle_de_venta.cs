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
        public decimal Precio_Producto { get; set; }}
    }
}
