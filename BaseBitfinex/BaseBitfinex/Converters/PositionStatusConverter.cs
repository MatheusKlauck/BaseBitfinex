using System.Collections.Generic;
using BaseBitfinex.Objects;
using BaseExchange.Converters;

namespace BaseBitfinex.Converters
{
    public class PositionStatusConverter : BaseConverter<PositionStatus>
    {
        public PositionStatusConverter() : this(true) { }
        public PositionStatusConverter(bool quotes) : base(quotes) { }

        protected override Dictionary<PositionStatus, string> Mapping => new Dictionary<PositionStatus, string>
        {
            { PositionStatus.Closed, "CLOSED" },
            { PositionStatus.Active, "ACTIVE" }
        };
    }
}
