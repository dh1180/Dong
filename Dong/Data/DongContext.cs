using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Dong.Models;

namespace Dong.Data
{
    public class DongContext : DbContext
    {
        public DongContext (DbContextOptions<DongContext> options)
            : base(options)
        {
        }

        public DbSet<Dong.Models.Blog> Blog { get; set; } = default!;
    }
}
