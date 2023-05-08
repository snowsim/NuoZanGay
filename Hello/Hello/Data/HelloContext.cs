using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Hello.Models;

namespace Hello.Data
{
    public class HelloContext : DbContext
    {
        public HelloContext (DbContextOptions<HelloContext> options)
            : base(options)
        {
        }

        public DbSet<Hello.Models.Movie> Movie { get; set; } = default!;
    }
}
