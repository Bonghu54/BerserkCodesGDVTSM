using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BerserkCodesGDVTSM.Models
{
    public class Empleado
    {
        [Key]
        public int pk_fk_Id_Persona { get; set; }
        public int fk_Id_Usuario { get; set; }
        public DateTime FechaHora_de_Registro { get; set; }
        public string Puesto { get; set; }
        public string Departamento { get; set; }
        public DateTime Fecha_Contratacion { get; set; }
    }
}
