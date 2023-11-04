﻿using System.ComponentModel.DataAnnotations;

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
    }
}
