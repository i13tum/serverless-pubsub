using Newtonsoft.Json;

namespace PubSubClientCore.Entities
{
    public class MessageBase
    {
        [JsonProperty("subscriberId")]
        public string SubscriberId { get; set; }

        [JsonProperty("message")] public string Message { get; set; } = "Some Message;";

        [JsonProperty("nodesCount")]
        public int NodesCount { get; set; }

        public override string ToString()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
    }
}
