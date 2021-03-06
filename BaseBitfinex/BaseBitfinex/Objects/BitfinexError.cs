﻿using BaseExchange.Converters;
using Newtonsoft.Json;

namespace BaseBitfinex.Objects
{
    [JsonConverter(typeof(ArrayConverter))]
    public class BitfinexError
    {
        [ArrayProperty(1)]
        public int ErrorCode { get; set; }
        [ArrayProperty(2)]
        public string ErrorMessage { get; set; }

        public BitfinexError(int errorCode, string errorMessage)
        {
            ErrorCode = errorCode;
            ErrorMessage = errorMessage;
        }

        public BitfinexError() { }
    }
}
