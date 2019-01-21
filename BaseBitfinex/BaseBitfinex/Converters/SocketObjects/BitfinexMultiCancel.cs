﻿using BaseBitfinex.Converters;
using Newtonsoft.Json;

namespace BaseBitfinex.Objects.SocketObjects
{
    public class BitfinexMultiCancel
    {
        [JsonProperty("all"), JsonConverter(typeof(BoolToIntConverter), new[] { false, true })]
        public bool? All { get; set; }
        [JsonProperty("id")]
        public long[] OrderIds { get; set; }
        [JsonProperty("cid")]
        public object[][] ClientIds { get; set; }
        [JsonProperty("gid")]
        public long[][] GroupIds { get; set; }
    }
}
