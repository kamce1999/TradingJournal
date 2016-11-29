using System;
using System.Collections.Generic;
using System.Linq;

namespace TradingJournal
{
    public class Position
    {
        public string Ticker { get; set; }                        
        public bool Closed { get; set; }
        public List<Trade> Trades { get; set; }
    }

    public class Trade
    {
        public string Ticker { get; set; }
        public InstrumentType Instrument { get; set; }
        public bool Short { get; set; }
        public bool Close { get; set; }
        public DateTime TransactionUtc { get; set; }
        public int Shares { get; set; }
    }

    public enum InstrumentType
    {
        Common,
        Call,
        Put,
        Future
    }
}
