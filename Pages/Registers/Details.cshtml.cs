using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using UserRegistry.Data;
using UserRegistry.Models;

namespace UserRegistry.Pages.Registers
{
    public class DetailsModel : PageModel
    {
        private readonly UserRegistry.Data.UserContext _context;

        public DetailsModel(UserRegistry.Data.UserContext context)
        {
            _context = context;
        }

        public Register Register { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Register = await _context.Registers.FirstOrDefaultAsync(m => m.ID == id);

            if (Register == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
