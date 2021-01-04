using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using stabii.Data;
using stabii.Models;

namespace stabii.Pages.Games
{
    public class IndexModel : PageModel
    {
        private readonly stabii.Data.stabiiContext _context;

        public IndexModel(stabii.Data.stabiiContext context)
        {
            _context = context;
        }

        public IList<Game> Game { get;set; }

        public async Task OnGetAsync()
        {
            Game = await _context.Game.ToListAsync();
        }
    }
}
