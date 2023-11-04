using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BerserkCodesGDVTSM.Models;

namespace BerserkCodesGDVTSM.Data
{
    public class BerserkCodesGDVTSMContext : DbContext
    {
        public BerserkCodesGDVTSMContext (DbContextOptions<BerserkCodesGDVTSMContext> options)
            : base(options)
        {
        }

        public DbSet<BerserkCodesGDVTSM.Models.Empleado> Empleado { get; set; } = default!;

        public DbSet<BerserkCodesGDVTSM.Models.Persona>? Persona { get; set; }

        public DbSet<BerserkCodesGDVTSM.Models.Rol>? Rol { get; set; }

        public DbSet<BerserkCodesGDVTSM.Models.Usuario>? Usuario { get; set; }

        public DbSet<BerserkCodesGDVTSM.Models.Cliente>? Cliente { get; set; }

        public DbSet<BerserkCodesGDVTSM.Models.Venta>? Venta { get; set; }

        public DbSet<BerserkCodesGDVTSM.Models.Detalle_de_venta>? Detalle_de_venta { get; set; }

        public DbSet<BerserkCodesGDVTSM.Models.Producto>? Producto { get; set; }

        public DbSet<BerserkCodesGDVTSM.Models.Detalle_Producto>? Detalle_Producto { get; set; }
    }
}
