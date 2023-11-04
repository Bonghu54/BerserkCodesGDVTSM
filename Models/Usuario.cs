using System.ComponentModel.DataAnnotations;

namespace BerserkCodesGDVTSM.Models
{
    public class Usuario
    {
        [Key]
        public int Id_Usuario { get; set; }
        [Required]
        public string Nombre_Usuario { get; set; }
        [Required]
        [EmailAddress(ErrorMessage = "Por favor Ingrese un email correcto")]
        public string Correo_Electronico { get; set; }
        [Required]
        public string Contrasena { get; set; }
        public DateTime FechaHora_de_registro { get; set; }
        public int fk_Id_Rol { get; set; }
    }
}
