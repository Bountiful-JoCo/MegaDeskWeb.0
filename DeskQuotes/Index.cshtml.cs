using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MegaDeskWeb._0.Models;

namespace MegaDeskWeb._0.DeskQuotes
{
    public class IndexModel : PageModel
    {
        private readonly MegaDeskWeb._0.Models.MegaDeskWeb_0Context _context;

        public IndexModel(MegaDeskWeb._0.Models.MegaDeskWeb_0Context context)
        {
            _context = context;
        }

        public IList<DeskQuote> DeskQuote { get;set; }

        public async Task OnGetAsync()
        {
            DeskQuote = await _context.DeskQuote
                .Include(d => d.Desk).ToListAsync();
        }
    }
}
