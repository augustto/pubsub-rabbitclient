using Core.AdminApi.Exchanges;
using Core.AdminApi.Queues;
using Core.AdminApi.VirtualHosts;
using RabbitMQ.Client;
using RestSharp;
using RestSharp.Authenticators;
using RestSharp.Serializers.NewtonsoftJson;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.AdminApi
{
    public class RabbitMQManagementApi
    {
        private readonly ConnectionFactory connectionFactory;

        public VirtualHostApi VirtualHost { get; }
        public QueueApi Queues { get; }
        public ExchangeApi Exchanges { get; }

        public RabbitMQManagementApi(ConnectionFactory connectionFactory)
        {
            this.connectionFactory = connectionFactory;

            RestClient restClient = this.BuildRestClient();

            this.VirtualHost = new VirtualHostApi(restClient);
            this.Queues = new QueueApi(restClient);
            this.Exchanges = new ExchangeApi(restClient);
        }

        private RestClient BuildRestClient()
        {
            var client = new RestClient($"http://{connectionFactory.HostName}:{connectionFactory.Port}/api/")
            {
                Authenticator = new HttpBasicAuthenticator(connectionFactory.UserName, connectionFactory.Password)
            };
            client.UseNewtonsoftJson();
            return client;
        }



    }
}
