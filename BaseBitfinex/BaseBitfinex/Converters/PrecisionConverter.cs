﻿using System.Collections.Generic;
using BaseBitfinex.Objects;
using BaseExchange.Converters;

namespace BaseBitfinex.Converters
{
    public class PrecisionConverter : BaseConverter<Precision>
    {
        public PrecisionConverter() : this(true) { }
        public PrecisionConverter(bool useQuotes) : base(useQuotes)
        {
        }

        protected override Dictionary<Precision, string> Mapping => new Dictionary<Precision, string>
        {
            {Precision.PrecisionLevel0, "P0"},
            {Precision.PrecisionLevel1, "P1"},
            {Precision.PrecisionLevel2, "P2"},
            {Precision.PrecisionLevel3, "P3"},
            {Precision.R0, "R0"}
        };
    }
}
