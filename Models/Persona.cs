using System.ComponentModel.DataAnnotations;

namespace BerserkCodesGDVTSM.Models
{
    public class Persona
    {
        public int Id_Persona { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Ci { get; set; }
        [DataType(DataType.Date)]
        public DateOnly Fecha_Nacimiento { get; set; }
        public string Direccion { get; set; }

    }
}
