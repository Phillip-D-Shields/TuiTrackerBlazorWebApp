using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TuiTrackerCMS.Models;

namespace TuiTrackerWebApp.Data
{
    public class TuiTrackerWebAppContext : DbContext
    {
        public TuiTrackerWebAppContext (DbContextOptions<TuiTrackerWebAppContext> options)
            : base(options)
        {
        }

        public DbSet<TuiTrackerCMS.Models.Business> Business { get; set; } = default!;
        public DbSet<TuiTrackerCMS.Models.Contact> Contact { get; set; } = default!;
    }
}
