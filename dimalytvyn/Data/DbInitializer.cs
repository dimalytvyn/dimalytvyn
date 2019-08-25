using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dimalytvyn.Data
{
    public class DbInitializer
    {
        public static void Initialize(MyDb context)
        {
            //if (!context.Database.EnsureCreated())
            //{
            //    // do nothing.
            //    return;
            //}

            var dimaAdmin = new Admin();
            dimaAdmin.Username = "dlytvyn";
            dimaAdmin.Password = "Blooturtle";

            context.Admins.Add(dimaAdmin);
            context.SaveChanges();
        }

    }
}
