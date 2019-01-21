using System.Collections.Generic;
using BaseBitfinex.Objects;
using BaseExchange.Converters;

namespace BaseBitfinex.Converters
{
    public class OrderSideConverter : BaseConverter<OrderSide>
    {
        public OrderSideConverter() : this(true) { }
        public OrderSideConverter(bool quotes) : base(quotes) { }

        protected override Dictionary<OrderSide, string> Mapping => new Dictionary<OrderSide, string>
        {
            { OrderSide.Buy, "buy" },
            { OrderSide.Sell, "sell" }
        };
    }
}
