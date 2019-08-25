using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dimalytvyn
{
    public class MyDb : DbContext
    {
        public MyDb(DbContextOptions<MyDb> Options) : base(Options) { }
        public DbSet<Admin> Admins { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Admin>();
        }
    }
}
