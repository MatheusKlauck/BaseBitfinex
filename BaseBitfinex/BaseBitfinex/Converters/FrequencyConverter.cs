using System.Collections.Generic;
using BaseBitfinex.Objects;
using BaseExchange.Converters;

namespace BaseBitfinex.Converters
{
    public class FrequencyConverter : BaseConverter<Frequency>
    {
        public FrequencyConverter() : this(true) { }
        public FrequencyConverter(bool quotes) : base(quotes) { }

        protected override Dictionary<Frequency, string> Mapping => new Dictionary<Frequency, string>
        {
            { Frequency.Realtime, "F0" },
            { Frequency.TwoSeconds, "F1" }
        };
    }
}
