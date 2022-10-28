using RabbitMQ.Client;
using System;
using System.Collections.Generic;
using System.Text;
using RestSharp;
using RestSharp.Authenticators;

namespace Core.AdminApi.VirtualHosts
{
    public class VirtualHostApi
    {
        private readonly RestClient client;

        public VirtualHostApi(RestClient client)
        {
            this.client = client;
        }

        public VirtualHost[] GetVirtualHosts()
        {
            var request = new RestRequest("vhosts", DataFormat.Json);
            var response = client.Get<VirtualHost[]>(request);
            return response.Data;
        }

        public bool CreateVirtualHost(string name, string description, string tags)
        {
            var request = new RestRequest($"vhosts/{name}", DataFormat.Json)
                .AddJsonBody(new
                {
                    name,
                    description,
                    tags
                });

            var response = client.Put(request);
            return response.StatusCode == System.Net.HttpStatusCode.Created;
        }

    }
}
