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
    public class IndexModel : PageModel
    {
        private readonly BerserkCodesGDVTSM.Data.BerserkCodesGDVTSMContext _context;

        public IndexModel(BerserkCodesGDVTSM.Data.BerserkCodesGDVTSMContext context)
        {
            _context = context;
        }

        public IList<Empleado> Empleado { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Empleado != null)
            {
                Empleado = await _context.Empleado.ToListAsync();
            }
        }
    }
}
