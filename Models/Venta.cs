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

        public Venta(int id_Venta, DateTime fechaHora_Venta, DateTime fechaHora_Entrega, string estado_Seguimiento, decimal total_Venta, int fkIdCliente, int fkIdEmpleado)
        {
            Id_Venta = id_Venta;
            FechaHora_Venta = fechaHora_Venta;
            FechaHora_Entrega = fechaHora_Entrega;
            Estado_Seguimiento = estado_Seguimiento;
            Total_Venta = total_Venta;
            //FkIdCliente = fkIdCliente;
            //FkIdEmpleado = fkIdEmpleado;
        }
    }
}
