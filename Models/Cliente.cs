using System.ComponentModel.DataAnnotations;

namespace BerserkCodesGDVTSM.Models
{
    public class Cliente
    {
        [Key]
        public int Id_Persona { get; set; }
        public DateTime FechaHora_de_registro { get; set; }
        public string Tipo_Cliente { get; set; }

        public Cliente(int idPersona, DateTime fechaRegistro, string tipoCliente)
        {
            Id_Persona = idPersona;
            FechaHora_de_registro = fechaRegistro;
            Tipo_Cliente = tipoCliente;
        }
    }
}
