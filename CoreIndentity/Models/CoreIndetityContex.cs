using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CoreIndentity.Models
{
    public class CoreIndetityContex : DbContext
    {
        public CoreIndetityContex(DbContextOptions<CoreIndetityContex> options)
            : base(options) { }

        public DbSet<urusan> urusans { get; set; }
    }
}
