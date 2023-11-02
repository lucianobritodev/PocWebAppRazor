using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PocWebAppRazor.Models;

namespace PocWebAppRazor.Data
{
    public class PocWebAppRazorContext : DbContext
    {
        public PocWebAppRazorContext (DbContextOptions<PocWebAppRazorContext> options)
            : base(options)
        {
        }

        public DbSet<PocWebAppRazor.Models.Department> Department { get; set; } = default!;
    }
}
