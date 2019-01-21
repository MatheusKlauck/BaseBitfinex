using BaseExchange.Converters;
using Newtonsoft.Json;

namespace BaseBitfinex.Objects
{
    [JsonConverter(typeof(ArrayConverter))]
    public class BitfinexSuccessResult
    {
        [ArrayProperty(0)]
        public bool Success { get; set; }
    }
}
