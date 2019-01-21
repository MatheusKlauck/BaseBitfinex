﻿using BaseExchange.Interfaces;
using BaseExchange.Sockets;
using System;
using System.Collections.Generic;

namespace BaseBitfinex.Objects.SocketObjects
{
    internal class BitfinexSocketSubscription : SocketSubscription
    {
        public bool MaintenanceMode { get; set; }
        public Dictionary<BitfinexEventType, Type> TypeMapping { get; set; }

        public BitfinexSocketSubscription(IWebsocket socket) : base(socket)
        {
            TypeMapping = new Dictionary<BitfinexEventType, Type>();
        }
    }
}
