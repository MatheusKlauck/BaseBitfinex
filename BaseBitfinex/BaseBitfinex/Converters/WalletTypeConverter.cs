﻿using System.Collections.Generic;
using BaseBitfinex.Objects;
using BaseExchange.Converters;

namespace BaseBitfinex.Converters
{
    public class WalletTypeConverter : BaseConverter<WalletType>
    {
        public WalletTypeConverter() : this(true) { }
        public WalletTypeConverter(bool quotes) : base(quotes) { }

        protected override Dictionary<WalletType, string> Mapping => new Dictionary<WalletType, string>
        {
            { WalletType.Exchange, "exchange" },
            { WalletType.Funding, "funding" },
            { WalletType.Margin, "margin" },
        };
    }
}
