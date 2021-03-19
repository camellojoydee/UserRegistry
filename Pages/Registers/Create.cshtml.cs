using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using UserRegistry.Data;
using UserRegistry.Models;

namespace UserRegistry.Pages.Registers
{
    public class CreateModel : PageModel
    {
        private readonly UserRegistry.Data.UserContext _context;

        public CreateModel(UserRegistry.Data.UserContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Register Register { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Registers.Add(Register);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
