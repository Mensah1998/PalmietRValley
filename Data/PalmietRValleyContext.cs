using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PalmietRValley.Models;

namespace PalmietRValley.Data
{
    public class PalmietRValleyContext : DbContext
    {
        public PalmietRValleyContext (DbContextOptions<PalmietRValleyContext> options)
            : base(options)
        {
        }

        public DbSet<PalmietRValley.Models.Author> Author { get; set; }

        public DbSet<PalmietRValley.Models.Post> Post { get; set; }
    }
}
