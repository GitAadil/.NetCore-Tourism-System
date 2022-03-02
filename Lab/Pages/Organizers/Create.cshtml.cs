using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Lab.Data;
using Lab.Models;

namespace Lab.Pages.Organizers
{
    public class CreateModel : PageModel
    {
        private readonly Lab.Data.OrganizerContext _context;

        public CreateModel(Lab.Data.OrganizerContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Organizer Organizer { get; set; }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Organizers.Add(Organizer);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
