using System.ComponentModel.DataAnnotations;

namespace BerserkCodesGDVTSM.Models
{
    public class Rol
    {
        [Key]
        public int Id_Rol { get; set; }
        public string Nombre_Rol { get; set; }
        public string Descripcion { get; set; }
        [DataType(DataType.Date)]
        public DateTime FechaHora_de_registro { get; set; }
    }
}
