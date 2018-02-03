using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DFDS.Models
{
    public class DFDSContext : DbContext
    {
        public DFDSContext (DbContextOptions<DFDSContext> options)
            : base(options)
        {
        }

        public DbSet<DFDS.Models.Feedback> Feedback { get; set; }
    }
}
