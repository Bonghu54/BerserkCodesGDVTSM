using System.ComponentModel.DataAnnotations;

namespace BerserkCodesGDVTSM.Models
{
    public class Detalle_Producto
    {
        [Key]
        public int Id_Detalle_Producto { get; set; }
        //public int FkProducto { get; set; }
        public string Color { get; set; }
        public string Tipo_De_Uso { get; set; }
        public string Durabilidad { get; set; }
        public string Material { get; set; }
        public string Estampado { get; set; }

        public Detalle_Producto(int id_Detalle_Producto, int fkProducto, string color, string tipo_De_Uso, string durabilidad, string material, string estampado)
        {
            Id_Detalle_Producto = id_Detalle_Producto;
            //FkProducto = fkProducto;
            Color = color;
            Tipo_De_Uso = tipo_De_Uso;
            Durabilidad = durabilidad;
            Material = material;
            Estampado = estampado;
        }
    }
}
