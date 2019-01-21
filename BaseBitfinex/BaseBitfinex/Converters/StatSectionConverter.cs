using System.Collections.Generic;
using BaseBitfinex.Objects;
using BaseExchange.Converters;

namespace BaseBitfinex.Converters
{
    public class StatSectionConverter : BaseConverter<StatSection>
    {
        public StatSectionConverter() : this(true) { }
        public StatSectionConverter(bool quotes) : base(quotes) { }

        protected override Dictionary<StatSection, string> Mapping => new Dictionary<StatSection, string>
        {
            { StatSection.History, "hist" },
            { StatSection.Last, "last" }
        };
    }
}
