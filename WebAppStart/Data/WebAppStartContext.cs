#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebAppStart.Models;

namespace WebAppStart.Data
{
    public class WebAppStartContext : DbContext
    {
        public WebAppStartContext (DbContextOptions<WebAppStartContext> options)
            : base(options)
        {
        }

        public DbSet<WebAppStart.Models.Movie> Movie { get; set; }
    }
}
