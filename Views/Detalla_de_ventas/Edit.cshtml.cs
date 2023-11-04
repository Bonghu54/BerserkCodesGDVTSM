using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BerserkCodesGDVTSM.Data;
using BerserkCodesGDVTSM.Models;

namespace BerserkCodesGDVTSM.Views.Detalla_de_ventas
{
    public class EditModel : PageModel
    {
        private readonly BerserkCodesGDVTSM.Data.BerserkCodesGDVTSMContext _context;

        public EditModel(BerserkCodesGDVTSM.Data.BerserkCodesGDVTSMContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Detalle_de_venta Detalle_de_venta { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Detalle_de_venta == null)
            {
                return NotFound();
            }

            var detalle_de_venta =  await _context.Detalle_de_venta.FirstOrDefaultAsync(m => m.Id_Detalle == id);
            if (detalle_de_venta == null)
            {
                return NotFound();
            }
            Detalle_de_venta = detalle_de_venta;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Detalle_de_venta).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Detalle_de_ventaExists(Detalle_de_venta.Id_Detalle))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool Detalle_de_ventaExists(int id)
        {
          return (_context.Detalle_de_venta?.Any(e => e.Id_Detalle == id)).GetValueOrDefault();
        }
    }
}
