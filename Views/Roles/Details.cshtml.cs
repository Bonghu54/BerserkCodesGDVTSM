using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BerserkCodesGDVTSM.Data;
using BerserkCodesGDVTSM.Models;

namespace BerserkCodesGDVTSM.Views.Roles
{
    public class DetailsModel : PageModel
    {
        private readonly BerserkCodesGDVTSM.Data.BerserkCodesGDVTSMContext _context;

        public DetailsModel(BerserkCodesGDVTSM.Data.BerserkCodesGDVTSMContext context)
        {
            _context = context;
        }

      public Rol Rol { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Rol == null)
            {
                return NotFound();
            }

            var rol = await _context.Rol.FirstOrDefaultAsync(m => m.Id_Rol == id);
            if (rol == null)
            {
                return NotFound();
            }
            else 
            {
                Rol = rol;
            }
            return Page();
        }
    }
}
