using System;

namespace PubSubClientCore
{
    public static class Helpers
    {
        public static string RegisterSubscriberUrl(string baseUrl)
        {
            return baseUrl + "/Subscribe";
        }

        public static string SubscribeTopicUrl(string baseUrl)
        {
            return baseUrl + "/SubscribeTopic";
        }

        public static string SubscribeContentUrl(string baseUrl)
        {
            return baseUrl + "/SubscribeContent";
        }

        public static string SubscribeFunctionUrl(string baseUrl)
        {
            return baseUrl + "/SubscribeFunction";
        }

        public static string PublishTopicUrl(string baseUrl)
        {
            return baseUrl + "/PublishTopic";
        }

        public static string PublishContentUrl(string baseUrl)
        {
            return baseUrl + "/PublishContent";
        }

        public static string PublishFunctionUrl(string baseUrl)
        {
            return baseUrl + "/PublishFunction";
        }
    }
}