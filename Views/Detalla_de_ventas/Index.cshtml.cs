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
    public class IndexModel : PageModel
    {
        private readonly BerserkCodesGDVTSM.Data.BerserkCodesGDVTSMContext _context;

        public IndexModel(BerserkCodesGDVTSM.Data.BerserkCodesGDVTSMContext context)
        {
            _context = context;
        }

        public IList<Detalle_de_venta> Detalle_de_venta { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Detalle_de_venta != null)
            {
                Detalle_de_venta = await _context.Detalle_de_venta.ToListAsync();
            }
        }
    }
}
