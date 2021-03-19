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
    public class IndexModel : PageModel
    {
        private readonly UserRegistry.Data.UserContext _context;

        public IndexModel(UserRegistry.Data.UserContext context)
        {
            _context = context;
        }

        public IList<Register> Register { get;set; }

        public async Task OnGetAsync()
        {
            Register = await _context.Registers.ToListAsync();
        }
    }
}
