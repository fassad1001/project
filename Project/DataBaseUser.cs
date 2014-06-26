using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Project
{
    class DataBaseUser : DbContext
    {
        public DbSet<Account> Accounts { get; set; }
        public DbSet<InfoBlock> InfoBlocks { get; set; }
        public DbSet<Rule> Rules { get; set; }
        public DbSet<HistoryItem> History { get; set; }
        public DbSet<Rating> Raitings { get; set; }
        public DbSet<HierarchyItem> Hierarchy { get; set; }

    }
}
