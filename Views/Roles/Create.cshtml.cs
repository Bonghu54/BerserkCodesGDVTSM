using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using BerserkCodesGDVTSM.Data;
using BerserkCodesGDVTSM.Models;

namespace BerserkCodesGDVTSM.Views.Roles
{
    public class CreateModel : PageModel
    {
        private readonly BerserkCodesGDVTSM.Data.BerserkCodesGDVTSMContext _context;

        public CreateModel(BerserkCodesGDVTSM.Data.BerserkCodesGDVTSMContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Rol Rol { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Rol == null || Rol == null)
            {
                return Page();
            }

            _context.Rol.Add(Rol);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
