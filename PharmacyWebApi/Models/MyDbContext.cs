using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PharmacyWebApi.Models
{
    public class MyDbContext : DbContext
    {
        public DbSet<Pharmacy> Pharmacies { get; set; }
        public DbSet<Medicine> Medicines { get; set; }
        public DbSet<MyLog> Logs { get; set; }

        public MyDbContext() : base("DefaultConnection")
        {

        }
    }
}