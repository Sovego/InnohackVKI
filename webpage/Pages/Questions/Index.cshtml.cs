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
    public class IndexModel : PageModel
    {
        private readonly NETRUSH.Data.NETRUSHContext _context;

        public IndexModel(NETRUSH.Data.NETRUSHContext context)
        {
            _context = context;
        }

        public IList<quest> Questions { get;set; }

        public async Task OnGetAsync()
        {
            Questions = await _context.Questions.ToListAsync();
        }
    }
}
