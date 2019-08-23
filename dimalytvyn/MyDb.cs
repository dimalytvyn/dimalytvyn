using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace dimalytvyn
{
    public class MyDb : DbContext
    {
        public DbSet Admins { get; set; }
    }
}
