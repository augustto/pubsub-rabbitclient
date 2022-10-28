using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.AdminApi.VirtualHosts
{
    public class ClusterState
    {

        [JsonProperty("rabbit@container-rabbitmq")]
        public string ContainerRabbitmq { get; set; }
    }

    public class Metadata
    {

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("tags")]
        public IList<object> Tags { get; set; }
    }

    public class VirtualHost
    {

        [JsonProperty("cluster_state")]
        public ClusterState ClusterState { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("metadata")]
        public Metadata Metadata { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("tags")]
        public IList<object> Tags { get; set; }

        [JsonProperty("tracing")]
        public bool Tracing { get; set; }
    }

}
