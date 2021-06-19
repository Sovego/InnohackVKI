using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using NETRUSH.Data;
using NETRUSH.Models;

namespace NETRUSH.Pages.Questions
{
    public class DetailsModel : PageModel
    {
        private readonly NETRUSH.Data.NETRUSHContext _context;

        public DetailsModel(NETRUSH.Data.NETRUSHContext context)
        {
            _context = context;
        }

        public quest Questions { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Questions = await _context.Questions.FirstOrDefaultAsync(m => m.ID == id);

            if (Questions == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
