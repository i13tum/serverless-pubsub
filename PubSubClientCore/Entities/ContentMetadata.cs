using System.Collections.Generic;
using Newtonsoft.Json;

namespace PubSubClientCore.Entities
{
    public class ContentMetadata : MessageBase
    {
        [JsonProperty("content")]
        public List<KeyValueContent> Topics { get; set; }
    }

    public class KeyValueContent
    {
        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("condition")]
        public string Condition { get; set; }
    }
}