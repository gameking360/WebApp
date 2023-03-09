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

        public DbSet<AppWeb.Models.Department> Department { get; set; }
    }
}
