using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace TradingJournal.DataModel
{
    public class Trade
    {
        [Key]
        public int TradeId { get; set; }
        public DateTime TransactionUtc { get; set; }
        public TradeSide Side { get; set; }
        public int Quantity { get; set; }
        public bool Closed { get; set; }
        public string Ticker { get; set; }
        public decimal Price { get; set; }
        public decimal MarkToMarket { get; set; }
        public string Expiry { get; set; }
        public decimal Strike { get; set; }
        public InstrumentType Instrument { get; set; }
    }
}
