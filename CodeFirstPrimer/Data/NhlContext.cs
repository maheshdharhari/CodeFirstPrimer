using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using CodeFirstPrimer.Models.NHL;

namespace CodeFirstPrimer.Data
{
    public class NhlContext : DbContext

    {
        public NhlContext()
        {

        }

        public DbSet<Team> Teams { get; set; }
        public DbSet<Player> Players { get; set; }

    }
}