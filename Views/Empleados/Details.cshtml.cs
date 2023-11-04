using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BerserkCodesGDVTSM.Data;
using BerserkCodesGDVTSM.Models;

namespace BerserkCodesGDVTSM.Views.Empleados
{
    public class DetailsModel : PageModel
    {
        private readonly BerserkCodesGDVTSM.Data.BerserkCodesGDVTSMContext _context;

        public DetailsModel(BerserkCodesGDVTSM.Data.BerserkCodesGDVTSMContext context)
        {
            _context = context;
        }

      public Empleado Empleado { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Empleado == null)
            {
                return NotFound();
            }

            var empleado = await _context.Empleado.FirstOrDefaultAsync(m => m.pk_fk_Id_Persona == id);
            if (empleado == null)
            {
                return NotFound();
            }
            else 
            {
                Empleado = empleado;
            }
            return Page();
        }
    }
}
