using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.AdminApi.Exchanges
{

    public class ExchangeApi
    {
        private readonly RestClient client;

        public ExchangeApi(RestClient client)
        {
            this.client = client;
        }

        public Exchange[] GetExchanges(string virtualHost)
        {
            var request = new RestRequest("exchanges", DataFormat.Json)
                .AddQueryParameter("name", "")
                .AddQueryParameter("use_regex", "false")
                .AddQueryParameter("pagination", "false");
            var response = client.Get<Exchange[]>(request);
            return response.Data.Where(it => it.Vhost == virtualHost).ToArray();
        }
    }
}
