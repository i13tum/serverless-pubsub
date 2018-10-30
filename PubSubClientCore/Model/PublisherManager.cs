using System;
using System.Threading.Tasks;
using PubSubClientCore.Entities;

namespace PubSubClientCore.Model
{
    public class PublisherManager : NodeBase
    {
        public PublisherManager(ConfigurationFile configurationFile) : base(configurationFile)
        {
        }

        public override async void SetupNode(int nodeNumber)
        {
            if (nodeNumber < ConfigurationFile.TopicsMetadata.NodesCount)
                PublishTopics(nodeNumber);
            if (nodeNumber < ConfigurationFile.ContentMetadata.NodesCount)
                PublishContent(nodeNumber);
            if (nodeNumber < ConfigurationFile.FunctionsMetadata.NodesCount)
                PublishFunctions(nodeNumber);
        }

        private async void PublishTopics(int nodeNumber)
        {
            var input = new TopicsMetadata { Message = $"Message from Publisher {nodeNumber},", Topics = ConfigurationFile.TopicsMetadata.Topics };
            var response = await HttpRestClient.Post(Helpers.PublishTopicUrl(ConfigurationFile.BaseUrl), input);
            Console.WriteLine(response);
        }

        private async void PublishContent(int nodeNumber)
        {
            var input = new ContentMetadata { Message = $"Message from Publisher {nodeNumber},", Topics = ConfigurationFile.ContentMetadata.Topics };
            var response = await HttpRestClient.Post(Helpers.PublishTopicUrl(ConfigurationFile.BaseUrl), input);
            Console.WriteLine(response);
        }

        private async void PublishFunctions(int nodeNumber)
        {
            foreach (var function in ConfigurationFile.FunctionsMetadata.Functions)
            {
                var input = new FunctionEndpoint
                {
                    Message = $"Message from Publisher {nodeNumber},",
                    FunctionType = function.FunctionType,
                    SubscriptionTopic = function.SubscriptionTopic,
                    MatchingFunction = function.MatchingFunction,
                    MatchingInputs = function.MatchingInputs
                };
                var response = await HttpRestClient.Post(Helpers.PublishFunctionUrl(ConfigurationFile.BaseUrl), input);
                Console.WriteLine(response);
            }
        }
    }
}