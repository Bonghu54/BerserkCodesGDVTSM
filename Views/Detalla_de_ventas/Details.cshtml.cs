using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BerserkCodesGDVTSM.Data;
using BerserkCodesGDVTSM.Models;

namespace BerserkCodesGDVTSM.Views.Detalla_de_ventas
{
    public class DetailsModel : PageModel
    {
        private readonly BerserkCodesGDVTSM.Data.BerserkCodesGDVTSMContext _context;

        public DetailsModel(BerserkCodesGDVTSM.Data.BerserkCodesGDVTSMContext context)
        {
            _context = context;
        }

      public Detalle_de_venta Detalle_de_venta { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Detalle_de_venta == null)
            {
                return NotFound();
            }

            var detalle_de_venta = await _context.Detalle_de_venta.FirstOrDefaultAsync(m => m.Id_Detalle == id);
            if (detalle_de_venta == null)
            {
                return NotFound();
            }
            else 
            {
                Detalle_de_venta = detalle_de_venta;
            }
            return Page();
        }
    }
}
