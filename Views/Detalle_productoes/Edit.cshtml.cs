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

namespace BerserkCodesGDVTSM.Views.Detalle_productoes
{
    public class EditModel : PageModel
    {
        private readonly BerserkCodesGDVTSM.Data.BerserkCodesGDVTSMContext _context;

        public EditModel(BerserkCodesGDVTSM.Data.BerserkCodesGDVTSMContext context)
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

            var detalle_producto =  await _context.Detalle_Producto.FirstOrDefaultAsync(m => m.Id_Detalle_Producto == id);
            if (detalle_producto == null)
            {
                return NotFound();
            }
            Detalle_Producto = detalle_producto;
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

            _context.Attach(Detalle_Producto).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Detalle_ProductoExists(Detalle_Producto.Id_Detalle_Producto))
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

        private bool Detalle_ProductoExists(int id)
        {
          return (_context.Detalle_Producto?.Any(e => e.Id_Detalle_Producto == id)).GetValueOrDefault();
        }
    }
}
