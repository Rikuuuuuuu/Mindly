using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Mindly.Data;
using Mindly.Models;

namespace Mindly.Pages.Users
{
    public class IndexModel : PageModel
    {
        private readonly Mindly.Data.MindlyContext _context;

        public IndexModel(Mindly.Data.MindlyContext context)
        {
            _context = context;
        }

        public IList<User> User { get;set; }

        public async Task OnGetAsync()
        {
            User = await _context.User.ToListAsync();
        }
    }
}
