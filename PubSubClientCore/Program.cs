using System;
using System.IO;
using System.Threading.Tasks;
using Newtonsoft.Json;
using PubSubClientCore.Entities;
using PubSubClientCore.Model;

namespace PubSubClientCore
{
    class Program
    {
        static SubscriberManager _subscriberManager;

        static PublisherManager _publisherManager;

        static void Main(string[] args)
        {
            // if (args.Length == 0)
            // {
            //     Console.WriteLine("Please provide configuration file in command line arguments,");
            //     return;
            // }
            //var fileName = args[0];
            var fileName = "CreatePublishers.json";
            var fileText = File.ReadAllText(fileName);
            var configurationFile = JsonConvert.DeserializeObject<ConfigurationFile>(fileText);
            Console.WriteLine($"Provider: {configurationFile.ProviderType}");
            Console.WriteLine($"Application Mode: {configurationFile.ApplicationMode}");

            MainAsync(configurationFile).GetAwaiter().GetResult();
        }

        static async Task MainAsync(ConfigurationFile configurationFile)
        {
            if (configurationFile.ApplicationMode == ApplicationMode.Publisher)
            {
                _publisherManager = new PublisherManager(configurationFile);
                _publisherManager.Setup();
            }
            else if (configurationFile.ApplicationMode == ApplicationMode.Subscriber)
            {
                _subscriberManager = new SubscriberManager(configurationFile);
                _subscriberManager.Setup();
            }
            Console.Read();
        }
    }
}
