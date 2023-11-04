using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BerserkCodesGDVTSM.Data;
using BerserkCodesGDVTSM.Models;

namespace BerserkCodesGDVTSM.Views.Detalle_productoes
{
    public class DeleteModel : PageModel
    {
        private readonly BerserkCodesGDVTSM.Data.BerserkCodesGDVTSMContext _context;

        public DeleteModel(BerserkCodesGDVTSM.Data.BerserkCodesGDVTSMContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Detalle_Producto Detalle_Producto { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Detalle_Producto == null)
            {
                return NotFound();
            }

            var detalle_producto = await _context.Detalle_Producto.FirstOrDefaultAsync(m => m.Id_Detalle_Producto == id);

            if (detalle_producto == null)
            {
                return NotFound();
            }
            else 
            {
                Detalle_Producto = detalle_producto;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Detalle_Producto == null)
            {
                return NotFound();
            }
            var detalle_producto = await _context.Detalle_Producto.FindAsync(id);

            if (detalle_producto != null)
            {
                Detalle_Producto = detalle_producto;
                _context.Detalle_Producto.Remove(Detalle_Producto);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
