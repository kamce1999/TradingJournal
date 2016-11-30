using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace TradingJournal.DataModel
{
    public class Position
    {
        public Position()
        {
            Trades = new List<Trade>();
        }

        [Key]
        public int PositionId { get; set; }
        public string Ticker { get; set; }                        
        public bool Closed { get; set; }
        public List<Trade> Trades { get; set; }
    }
}
