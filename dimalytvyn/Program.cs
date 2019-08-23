using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace dimalytvyn
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<MyDb>());
            CreateWebHostBuilder(args).Build().Run();
            InsertData();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();

        private static void InsertData()
        {
            var db = new MyDb();
            var dimaAdmin = new Admin()
            {
                Id = 1,
                Username= "dlytvyn",
                Password = "Blooturtle!"
            };

            db.Admins.Add(dimaAdmin);

            db.SaveChanges();
        }
    }
}
