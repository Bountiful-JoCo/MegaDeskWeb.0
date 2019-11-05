using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using MegaDeskWeb._0.Models;

namespace MegaDeskWeb._0.DeskQuotes
{
    public class CreateModel : PageModel
    {
        private readonly MegaDeskWeb._0.Models.MegaDeskWeb_0Context _context;

        public CreateModel(MegaDeskWeb._0.Models.MegaDeskWeb_0Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["DeskID"] = new SelectList(_context.Set<Desk>(), "DeskID", "DeskID");
            return Page();
        }

        [BindProperty]
        public DeskQuote DeskQuote { get; set; }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.DeskQuote.Add(DeskQuote);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
