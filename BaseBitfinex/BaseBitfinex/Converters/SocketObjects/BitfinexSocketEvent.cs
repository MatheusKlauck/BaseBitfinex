﻿using BaseExchange.Converters;
using Newtonsoft.Json;

namespace BaseBitfinex.Objects.SocketObjects
{
    [JsonConverter(typeof(ArrayConverter))]
    public class BitfinexSocketEvent<T>
    {
        [ArrayProperty(0)]
        private int ChannelId { get; set; }
        public BitfinexEventType EventType { get; set; }
        [ArrayProperty(2), JsonConverter(typeof(ArrayConverter))]
        public T Data { get; set; }

        public BitfinexSocketEvent() { }

        public BitfinexSocketEvent(BitfinexEventType type, T data)
        {
            EventType = type;
            Data = data;
        }
    }
}
