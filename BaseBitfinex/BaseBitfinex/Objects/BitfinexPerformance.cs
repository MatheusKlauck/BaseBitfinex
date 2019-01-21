using System;
using BaseExchange.Converters;
using Newtonsoft.Json;

namespace BaseBitfinex.Objects
{
    [JsonConverter(typeof(ArrayConverter))]
    public class BitfinexPerformance
    {
        [ArrayProperty(0), JsonConverter(typeof(TimestampConverter))]
        public DateTime Timestamp { get; set; }

        [ArrayProperty(1)]
        public decimal Performance { get; set; }
    }
}
