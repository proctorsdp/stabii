using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using stabii.Models;

namespace stabii.Data
{
    public class stabiiContext : DbContext
    {
        public stabiiContext (DbContextOptions<stabiiContext> options)
            : base(options)
        {
        }

        public DbSet<stabii.Models.Game> Game { get; set; }
    }
}
