using RabbitMQ.Client;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
    public class DemoEnvironment
    {
        public string Name { get; set; }

        public string ContainerID { get; set; }

        public ConnectionFactory ConnectionFactory { get; set; }
    }
}
