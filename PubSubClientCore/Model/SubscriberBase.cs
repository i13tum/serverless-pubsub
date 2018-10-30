using System;
using PubSubClientCore.Entities;

namespace PubSubClientCore.Model
{
    public abstract class SubscriberBase
    {
        public SubscriberBase(SubscriberMetadata subscriberMetadata)
        {
            SubscriberMetadata = subscriberMetadata;
        }

        public SubscriberMetadata SubscriberMetadata { get; private set; }

        public abstract void Setup();

        public async void SubscribeTopics(ConfigurationFile configurationFile)
        {
            var input = new TopicsMetadata { SubscriberId = SubscriberMetadata.SubscriberId, Topics = configurationFile.TopicsMetadata.Topics };
            var response = await HttpRestClient.Post(Helpers.SubscribeTopicUrl(configurationFile.BaseUrl), input);
            Console.WriteLine(response);
        }

        public async void SubscribeContent(ConfigurationFile configurationFile)
        {
            var input = new ContentMetadata { SubscriberId = SubscriberMetadata.SubscriberId, Topics = configurationFile.ContentMetadata.Topics };
            var response = await HttpRestClient.Post(Helpers.SubscribeContentUrl(configurationFile.BaseUrl), input);
            Console.WriteLine(response);
        }

        public async void SubscribeFunction(ConfigurationFile configurationFile)
        {
            foreach (var function in configurationFile.FunctionsMetadata.Functions)
            {
                var input = new FunctionEndpoint
                {
                    SubscriberId = SubscriberMetadata.SubscriberId,
                    FunctionType = function.FunctionType,
                    SubscriptionTopic = function.SubscriptionTopic,
                    MatchingFunction = function.MatchingFunction,
                    MatchingInputs = function.MatchingInputs
                };
                var response = await HttpRestClient.Post(Helpers.SubscribeFunctionUrl(configurationFile.BaseUrl), input);
                Console.WriteLine(response);
            }
        }
    }
}