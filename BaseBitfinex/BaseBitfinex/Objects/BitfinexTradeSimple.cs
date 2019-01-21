using System;
using BaseExchange.Converters;
using Newtonsoft.Json;

namespace BaseBitfinex.Objects
{
    [JsonConverter(typeof(ArrayConverter))]
    public class BitfinexTradeSimple
    {
        [ArrayProperty(0)]
        public long Id { get; set; }
        [ArrayProperty(1), JsonConverter(typeof(TimestampConverter))]
        public DateTime Timestamp { get; set; }
        [ArrayProperty(2)]
        public decimal Amount { get; set; }
        [ArrayProperty(3)]
        public decimal Price { get; set; }

        [JsonIgnore]
        public BitfinexEventType UpdateType { get; set; } = BitfinexEventType.TradeSnapshot;
    }
}
