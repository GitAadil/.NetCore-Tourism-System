using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Lab.Data;
using Lab.Models;

namespace Lab.Pages.Organizers
{
    public class DetailsModel : PageModel
    {
        private readonly Lab.Data.OrganizerContext _context;

        public DetailsModel(Lab.Data.OrganizerContext context)
        {
            _context = context;
        }

        public Organizer Organizer { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Organizer = await _context.Organizers.FirstOrDefaultAsync(m => m.OrganizerID == id);

            if (Organizer == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
