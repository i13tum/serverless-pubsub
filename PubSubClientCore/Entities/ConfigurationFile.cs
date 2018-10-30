using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace PubSubClientCore.Entities
{
    public enum ProviderType
    {
        Azure,
        Aws
    }

    public enum ApplicationMode
    {
        Subscriber,
        Publisher,
        Mixed,
    }

    public class ConfigurationFile
    {
        [JsonProperty("baseUrl")]
        public string BaseUrl { get; set; }

        [JsonProperty("providerType")]
        public ProviderType ProviderType { get; set; }

        [JsonProperty("applicationMode")]
        public ApplicationMode ApplicationMode { get; set; }

        [JsonProperty("nodesCount")]
        public int NodesCount { get; set; }

        [JsonProperty("topicsMetadata")]
        public TopicsMetadata TopicsMetadata { get; set; }

        [JsonProperty("contentMetadata")]
        public ContentMetadata ContentMetadata { get; set; }

        [JsonProperty("FunctionsMetadata")]
        public FunctionsMetadata FunctionsMetadata { get; set; }
    }
}