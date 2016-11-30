using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TradingJournal.DataModel;

namespace TestClient
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new TradingContext())
            {
                var trade = new Trade {
                    Instrument = InstrumentType.Common,
                    Price = 1,
                    Quantity = 200,
                    Side = TradeSide.Buy,
                    Ticker = "KMI",
                    MarkToMarket = 12,
                    TransactionUtc = new DateTime(2016, 11, 10).ToUniversalTime()
                };

                var position = new Position { Ticker = "KMI" };
                position.Trades.Add(trade);

                db.Positions.Add(position);

                db.SaveChanges();

                var query = from p in db.Positions
                            select p;

                foreach (var p in query)
                {
                    Console.WriteLine(JsonConvert.SerializeObject(p));
                    Console.WriteLine();
                }

                Console.ReadLine();
            }
        }
    }
}
