using Microsoft.EntityFrameworkCore;
using Barbie_Dolls.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Barbie_Dolls.Data
{
    public class Barbie_DollsContext : DbContext
    {
        public Barbie_DollsContext (DbContextOptions<Barbie_DollsContext> options)
            : base(options) 
        { 
        }

        public DbSet<Doll> Doll { get; set;  }
    }
}
