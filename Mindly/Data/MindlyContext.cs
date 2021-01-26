using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Mindly.Models;

namespace Mindly.Data
{
    public class MindlyContext : DbContext
    {
        public MindlyContext (DbContextOptions<MindlyContext> options)
            : base(options)
        {
        }

        public DbSet<Mindly.Models.User> User { get; set; }
    }
}
