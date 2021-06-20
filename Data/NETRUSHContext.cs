using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NETRUSH.Models;

namespace NETRUSH.Data
{
    public class NETRUSHContext : DbContext
    {
        public NETRUSHContext (DbContextOptions<NETRUSHContext> options)
            : base(options)
        {
        }

        public DbSet<NETRUSH.Models.quest> Questions { get; set; }
    }
}
