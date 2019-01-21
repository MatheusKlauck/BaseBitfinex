using System.Collections.Generic;
using BaseBitfinex.Objects;
using BaseExchange.Converters;

namespace BaseBitfinex.Converters
{
    public class FundingTypeConverter : BaseConverter<FundingType>
    {
        public FundingTypeConverter() : this(true) { }
        public FundingTypeConverter(bool quotes) : base(quotes) { }

        protected override Dictionary<FundingType, string> Mapping => new Dictionary<FundingType, string>
        {
            { FundingType.Lend, "lend" },
            { FundingType.Loan, "loan" }
        };
    }
}
