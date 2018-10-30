using Newtonsoft.Json;

namespace PubSubClientCore.Entities
{
    public class SubscriberMetadata : MessageBase
    {
        [JsonProperty("connectionString")]
        public string ConnectionString { get; set; }

        [JsonProperty("queueName")]
        public string QueueName { get; set; }

        [JsonProperty("QueueUrl")]
        public string QueueUrl { get; set; }
    }
}
