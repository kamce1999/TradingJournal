using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace TradingJournal
{
    public class Position
    {
        public string Ticker { get; set; }                        
        public bool Closed { get; set; }




    }

    public class Trade
    {
        public InstrumentType Instrument { get; set; }

    }

    public enum InstrumentType
    {
        Common,
        Call,
        Put,
        Future
    }
}
