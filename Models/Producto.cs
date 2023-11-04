using System.ComponentModel.DataAnnotations;

namespace BerserkCodesGDVTSM.Models
{
    public class Producto
    {
        [Key]
        public int Id_Producto { get; set; }
        public string Nombre_Producto { get; set; }
        public string Descripcion { get; set; }
        public string Unidad_De_Venta { get; set; }
        public string Tipo_Producto { get; set; }
        public decimal Precio_Unitario { get; set; }
        public int Cantidad_En_Stock { get; set; }

        public Producto(int id_Producto, string nombre_Producto, string descripcion, string unidad_De_Venta, string tipo_Producto, decimal precio_Unitario, int cantidad_En_Stock)
        {
            Id_Producto = id_Producto;
            Nombre_Producto = nombre_Producto;
            Descripcion = descripcion;
            Unidad_De_Venta = unidad_De_Venta;
            Tipo_Producto = tipo_Producto;
            Precio_Unitario = precio_Unitario;
            Cantidad_En_Stock = cantidad_En_Stock;
        }
    }
}
