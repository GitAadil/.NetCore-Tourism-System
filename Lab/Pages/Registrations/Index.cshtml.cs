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
    public class IndexModel : PageModel
    {
        private readonly Lab.Data.RegistrationContext _context;

        public IndexModel(Lab.Data.RegistrationContext context)
        {
            _context = context;
        }

        public IList<Registration> Registration { get;set; }

        public async Task OnGetAsync()
        {
            Registration = await _context.Registrations.ToListAsync();
        }
    }
}
