using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using NETRUSH.Data;
using NETRUSH.Models;

namespace NETRUSH.Pages.Questions
{
    public class CreateModel : PageModel
    {
        private readonly NETRUSH.Data.NETRUSHContext _context;

        public CreateModel(NETRUSH.Data.NETRUSHContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public quest Questions { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Questions.Add(Questions);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
