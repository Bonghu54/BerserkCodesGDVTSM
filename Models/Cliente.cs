using System.ComponentModel.DataAnnotations;

namespace BerserkCodesGDVTSM.Models
{
    public class Cliente
    {
        [Key]
        public int Id_Persona { get; set; }
        public DateTime FechaHora_de_registro { get; set; }
        public string Tipo_Cliente { get; set; }
    }
}
