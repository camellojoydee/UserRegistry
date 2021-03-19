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
    public class DeleteModel : PageModel
    {
        private readonly UserRegistry.Data.UserContext _context;

        public DeleteModel(UserRegistry.Data.UserContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Register = await _context.Registers.FindAsync(id);

            if (Register != null)
            {
                _context.Registers.Remove(Register);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
