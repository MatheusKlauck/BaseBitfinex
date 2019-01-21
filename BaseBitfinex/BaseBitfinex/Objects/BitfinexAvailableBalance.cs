using BaseExchange.Converters;
using Newtonsoft.Json;

namespace BaseBitfinex.Objects
{
    [JsonConverter(typeof(ArrayConverter))]
    public class BitfinexAvailableBalance
    {
        [ArrayProperty(0)]
        public decimal AvailableBalance { get; set; }
    }
}
