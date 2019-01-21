using System.Collections.Generic;
using BaseBitfinex.Objects;
using BaseExchange.Converters;

namespace BaseBitfinex.Converters
{
    public class StatSideConverter : BaseConverter<StatSide>
    {
        public StatSideConverter() : this(true) { }
        public StatSideConverter(bool quotes) : base(quotes) { }

        protected override Dictionary<StatSide, string> Mapping => new Dictionary<StatSide, string>
        {
            { StatSide.Long, "long" },
            { StatSide.Short, "short" }
        };
    }
}
