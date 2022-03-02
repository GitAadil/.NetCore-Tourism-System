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
    public class IndexModel : PageModel
    {
        private readonly Lab.Data.OrganizerContext _context;

        public IndexModel(Lab.Data.OrganizerContext context)
        {
            _context = context;
        }

        public IList<Organizer> Organizer { get;set; }

        public async Task OnGetAsync()
        {
            Organizer = await _context.Organizers.ToListAsync();
        }
    }
}
