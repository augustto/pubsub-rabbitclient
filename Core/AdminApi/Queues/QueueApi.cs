using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.AdminApi.Queues
{
    public class QueueApi
    {
        private readonly RestClient client;

        public QueueApi(RestClient client)
        {
            this.client = client;
        }

        public Queue[] GetQueues(string virtualHost)
        {
            var request = new RestRequest("queues", DataFormat.Json)
                .AddQueryParameter("name", "")
                .AddQueryParameter("use_regex", "false")
                .AddQueryParameter("pagination", "false");
            var response = client.Get<Queue[]>(request);
            return response.Data.Where(it => it.Vhost == virtualHost).ToArray();
        }
    }
}
