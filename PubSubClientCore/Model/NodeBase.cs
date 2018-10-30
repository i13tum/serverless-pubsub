using System;
using Newtonsoft.Json;
using PubSubClientCore.Entities;

namespace PubSubClientCore.Model
{
    public abstract class NodeBase
    {
        protected NodeBase(ConfigurationFile configurationFile)
        {
            ConfigurationFile = configurationFile;
        }

        protected ConfigurationFile ConfigurationFile { get; private set; }

        public void Setup()
        {
            for (var i = 0; i < ConfigurationFile.NodesCount; i++)
                SetupNode(i);
        }

        public abstract void SetupNode(int nodeNumber);
    }
}