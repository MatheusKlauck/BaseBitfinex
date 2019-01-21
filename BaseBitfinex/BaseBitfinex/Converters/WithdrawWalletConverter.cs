using BaseBitfinex.Objects;
using BaseExchange.Converters;
using System.Collections.Generic;

namespace BaseBitfinex.Converters
{
    public class WithdrawWalletConverter : BaseConverter<WithdrawWallet>
    {
        public WithdrawWalletConverter() : this(true) { }
        public WithdrawWalletConverter(bool quotes) : base(quotes) { }

        protected override Dictionary<WithdrawWallet, string> Mapping => new Dictionary<WithdrawWallet, string>
        {
            { WithdrawWallet.Deposit, "deposit" },
            { WithdrawWallet.Exchange, "exchange" },
            { WithdrawWallet.Trading, "trading" },
        };
    }
}
