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
    }
}
