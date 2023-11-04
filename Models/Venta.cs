using System.ComponentModel.DataAnnotations;

namespace BerserkCodesGDVTSM.Models
{
    public class Venta
    {
        [Key]
        public int Id_Venta { get; set; }
        public DateTime FechaHora_Venta { get; set; }
        public DateTime FechaHora_Entrega { get; set; }
        public string Estado_Seguimiento { get; set; }
        public decimal Total_Venta { get; set; }
        //public int FkIdCliente { get; set; }
        //public int FkIdEmpleado { get; set; }
    }
}
