using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace PubSubClientCore.Entities
{
    public enum FunctionType
    {
        Url,
        String
    }

    public class FunctionsMetadata : MessageBase
    {
        [JsonProperty("functions")]
        public List<FunctionEndpoint> Functions { get; set; }
    }

    public class FunctionEndpoint : MessageBase
    {
        [JsonProperty("functionType")]
        public FunctionType FunctionType { get; set; }

        [JsonProperty("subscriptionTopic")]
        public string SubscriptionTopic { get; set; }

        [JsonProperty("matchingFunction")]
        public string MatchingFunction { get; set; }

        [JsonProperty("matchingInputs")]
        public string MatchingInputs { get; set; }
    }
}