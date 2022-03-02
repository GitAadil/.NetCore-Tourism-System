using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Lab.Data;
using Lab.Models;

namespace Lab.Pages.Registrations
{
    public class DetailsModel : PageModel
    {
        private readonly Lab.Data.RegistrationContext _context;

        public DetailsModel(Lab.Data.RegistrationContext context)
        {
            _context = context;
        }

        public Registration Registration { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Registration = await _context.Registrations.FirstOrDefaultAsync(m => m.ID == id);

            if (Registration == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
