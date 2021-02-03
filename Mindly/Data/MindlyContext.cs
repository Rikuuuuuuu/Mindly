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
        public DbSet<User> Users { get; set; }
        public MindlyContext (DbContextOptions<MindlyContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<User>().HasData(
       new
       {
           ID = Guid.NewGuid().ToString(),
           Email = "Testi@testimail.com",
           Password = "testi123",
       }, new
       {
           ID = Guid.NewGuid().ToString(),
           Email = "test@test.com",
           Password = "test3",
       }
       );

        }
        public DbSet<Mindly.Models.User> User { get; set; }
    }
}
