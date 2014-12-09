using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManyToMany
{
    class MyContext : DbContext
    {
        public DbSet<Module> Modules { get; set; }
        public DbSet<Docent> Docenten { get; set; }
    }
}
