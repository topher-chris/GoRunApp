using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GoRunApp.Models;

namespace GoRunApp.Data
{
    public class GoRunAppContext:DbContext
    {
        public GoRunAppContext(DbContextOptions<GoRunAppContext> options)
            : base(options)
        {
        }

        public DbSet<RunningSpot> RunningSpot { get; set; }
    }
}
