using Docker.DotNet;
using Docker.DotNet.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Core
{
    public class EnvironmentManager
    {
        private readonly DockerClient dockerClient;
        private readonly LogManager logManager;

        public EnvironmentManager(DockerClient dockerClient, LogManager logManager)
        {
            this.dockerClient = dockerClient;
            this.logManager = logManager;
        }

        public async Task Reset()
        {
            await RemoveContainer();

        }

        public async Task Initialize()
        {
            if (!await CheckImage())
            {
                await PullImage();
            }

            await CreateDemoContainer();

        }

        private async Task<IEnumerable<ContainerListResponse>> GetContainers()
        {
            var containers = (await this.dockerClient.Containers.ListContainersAsync(new ContainersListParameters() { All = true, }))
                .Where(it => it.Labels.ContainsKey(Consts.ContainerLabel))
                .ToArray();

            return containers;
        }

        private async Task RemoveContainer(IEnumerable<ContainerListResponse> containers = null)
        {
            if (containers == null)
            {
                containers = await this.GetContainers();
            }

            foreach (var container in containers)
            {
                logManager.Report($"Removendo container {container.ID} {container.Names}.");

                await dockerClient.Containers.RemoveContainerAsync(container.ID, new ContainerRemoveParameters() { Force = true });
            }
        }

        private async Task<bool> CheckImage()
        {
            var images = await this.dockerClient.Images.ListImagesAsync(new ImagesListParameters() { });

            logManager.Report($"Analisando se imagem está presente...");

            bool returnValue = images.Any(it => it.RepoTags.Contains(Consts.DockerImageName));

            if (returnValue)
                logManager.Report($"Imagem {Consts.DockerImageName} encontrada.");
            else
                logManager.Report($"Imagem {Consts.DockerImageName} não foi encontrada.");


            return returnValue;
        }

        private async Task PullImage()
        {
            logManager.Report($"Realizando Docker Pull da imagem {Consts.DockerImageName}.");
            await this.dockerClient.Images.CreateImageAsync(new ImagesCreateParameters() { FromImage = Consts.DockerImageName }, null, logManager);
        }

        private async Task CreateDemoContainer()
        {
            logManager.Report($"Criando container.");

            CreateContainerResponse response = await this.dockerClient.Containers.CreateContainerAsync(new CreateContainerParameters()
            {
                Image = Consts.DockerImageName,
                Hostname = Consts.DockerContainerHostname,
                Env = new List<string>() {
                    $"RABBITMQ_DEFAULT_USER={Consts.DockerContainerUsername}",
                    $"RABBITMQ_DEFAULT_PASS={Consts.DockerContainerPassword}",
                    $"RABBITMQ_DEFAULT_VHOST={Consts.DockerContainerVirtualHost}"
                },
                Labels = new Dictionary<string, string>() {
                    { Consts.ContainerLabel, Consts.ContainerLabel }
                },
                HostConfig = new HostConfig()
                {
                    PortBindings = new Dictionary<string, IList<PortBinding>>()
                    {
                        { Consts.RabbitMQEndpointAMQPPort.ToString(), new List<PortBinding>(){ new PortBinding() { HostIP = "0.0.0.0", HostPort = $"{Consts.RabbitMQEndpointAMQPPort}/tcp" }  } },
                        { Consts.RabbitMQEndpointAPIPort.ToString(), new List<PortBinding>(){ new PortBinding() { HostIP = "0.0.0.0", HostPort = $"{Consts.RabbitMQEndpointAPIPort}/tcp" }  } }
                    }
                },
                ExposedPorts = new Dictionary<string, EmptyStruct>() {
                    { Consts.RabbitMQEndpointAMQPPort.ToString(), default },
                    { Consts.RabbitMQEndpointAPIPort.ToString(), default }
                }
            });

            if (response.Warnings != null && response.Warnings.Any())
            {
                foreach (var warning in response.Warnings)
                    this.logManager.Report(warning);
            }

            logManager.Report($"Container Criado.");

            logManager.Report($"Inicializando container");
            if (await this.dockerClient.Containers.StartContainerAsync(response.ID, new ContainerStartParameters() { }))
            {
                var token = new CancellationToken();

                logManager.Report($"Avaliando log");
                await Task.Run(async () =>
                {
                    await this.dockerClient.Containers.GetContainerLogsAsync(response.ID, new ContainerLogsParameters() { Follow = true, ShowStderr = true, ShowStdout = true }, token, this.logManager);
                });

            }
            else
            {
                logManager.Report($"Container não foi criado");
            }



        }


    }
}
