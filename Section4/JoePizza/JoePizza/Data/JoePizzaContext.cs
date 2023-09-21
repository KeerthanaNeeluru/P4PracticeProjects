using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using JoePizza.Models;

namespace JoePizza.Data
{
    public class JoePizzaContext : DbContext
    {
        public JoePizzaContext (DbContextOptions<JoePizzaContext> options)
            : base(options)
        {
        }

        public DbSet<JoePizza.Models.MenuItem> MenuItem { get; set; } = default!;
    }
}
