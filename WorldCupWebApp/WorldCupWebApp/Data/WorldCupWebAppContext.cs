using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WorldCupWebApp.Models;

namespace WorldCupWebApp.Data
{
    public class WorldCupWebAppContext : DbContext
    {
        public WorldCupWebAppContext (DbContextOptions<WorldCupWebAppContext> options)
            : base(options)
        {
        }

        public DbSet<WorldCupWebApp.Models.Player> Player { get; set; } = default!;
    }
}
