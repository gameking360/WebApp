using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AppWeb.Models;

namespace AppWeb.Data
{
    public class AppWebContext : DbContext
    {
        public AppWebContext (DbContextOptions<AppWebContext> options)
            : base(options)
        {
        }

        public DbSet<Models.Department> Department { get; set; }
        public DbSet<Models.Seller> Seller { get; set; }
        public DbSet<Models.SalesRecord> SalesRecord { get; set; }
    }
}
