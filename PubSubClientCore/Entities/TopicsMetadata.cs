using System.Collections.Generic;
using Newtonsoft.Json;

namespace PubSubClientCore.Entities
{
    public class TopicsMetadata : MessageBase
    {
        [JsonProperty("topics")]
        public List<string> Topics { get; set; }
    }
}