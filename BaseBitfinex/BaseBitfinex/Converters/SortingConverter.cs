using System.Collections.Generic;
using BaseBitfinex.Objects;
using BaseExchange.Converters;

namespace BaseBitfinex.Converters
{
    public class SortingConverter : BaseConverter<Sorting>
    {
        public SortingConverter() : this(true) { }
        public SortingConverter(bool quotes) : base(quotes) { }

        protected override Dictionary<Sorting, string> Mapping => new Dictionary<Sorting, string>
        {
            { Sorting.NewFirst, "-1" },
            { Sorting.OldFirst, "1" }
        };
    }
}
