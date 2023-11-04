using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BerserkCodesGDVTSM.Data;
using BerserkCodesGDVTSM.Models;

namespace BerserkCodesGDVTSM.Views.Usuarios
{
    public class DetailsModel : PageModel
    {
        private readonly BerserkCodesGDVTSM.Data.BerserkCodesGDVTSMContext _context;

        public DetailsModel(BerserkCodesGDVTSM.Data.BerserkCodesGDVTSMContext context)
        {
            _context = context;
        }

      public Usuario Usuario { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Usuario == null)
            {
                return NotFound();
            }

            var usuario = await _context.Usuario.FirstOrDefaultAsync(m => m.Id_Usuario == id);
            if (usuario == null)
            {
                return NotFound();
            }
            else 
            {
                Usuario = usuario;
            }
            return Page();
        }
    }
}
