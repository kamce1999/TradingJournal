using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace TradingJournal.DataModel
{
    public class TradingContext : DbContext
    {
        public DbSet<Position> Positions { get; set; }
        public DbSet<Trade> Trades { get; set; }        
    }
}
