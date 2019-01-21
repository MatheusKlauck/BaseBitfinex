using BaseBitfinex.Converters;
using BaseExchange.Converters;
using Newtonsoft.Json;

namespace BaseBitfinex.Objects
{
    [JsonConverter(typeof(ArrayConverter))]
    public class BitfinexPlatformStatus
    {
        [ArrayProperty(0), JsonConverter(typeof(PlatformStatusConverter))]
        public PlatformStatus Status { get; set; }
    }
}
