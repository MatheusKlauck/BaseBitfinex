﻿using System.Collections.Generic;
using BaseBitfinex.Objects;
using BaseExchange.Converters;

namespace BaseBitfinex.Converters
{
    public class TimeFrameConverter : BaseConverter<TimeFrame>
    {
        public TimeFrameConverter() : this(true) { }
        public TimeFrameConverter(bool quotes) : base(quotes) { }

        protected override Dictionary<TimeFrame, string> Mapping => new Dictionary<TimeFrame, string>
        {
            { TimeFrame.OneMinute, "1m" },
            { TimeFrame.FiveMinute, "5m" },
            { TimeFrame.FiveteenMinute, "15m" },
            { TimeFrame.ThirtyMinute, "30m" },
            { TimeFrame.OneHour, "1h" },
            { TimeFrame.ThreeHour, "3h" },
            { TimeFrame.SixHour, "6h" },
            { TimeFrame.TwelveHour, "12h" },
            { TimeFrame.OneDay, "1D" },
            { TimeFrame.SevenDay, "7D" },
            { TimeFrame.FourteenDay, "14D" },
            { TimeFrame.OneMonth, "1M" },
        };
    }
}
