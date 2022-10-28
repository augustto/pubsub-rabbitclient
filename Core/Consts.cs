using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
    public static class Consts
    {
        public const string DockerSocksAddress = "npipe://./pipe/docker_engine";

        public const string ContainerLabel = "container-rabbitmq";

        public const string DockerImageName = "rabbitmq:3.8-management";

        public const string DockerContainerHostname = "container-rabbitmq";


        public const string RabbitMQEndpointHostname = "localhost";
        public const int RabbitMQEndpointAPIPort = 15672;
        public const int RabbitMQEndpointAMQPPort = 5672;
        public const string DockerContainerUsername = "guest";
        public const string DockerContainerPassword = "guest";
        public const string DockerContainerVirtualHost = "/";

    }
}
