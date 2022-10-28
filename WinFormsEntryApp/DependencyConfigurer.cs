using Core;
using Core.AdminApi;
using Docker.DotNet;
using Docker.DotNet.Models;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using RabbitMQ.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsEntryApp.Model;
using WinFormsEntryApp.UseCaseDemos;
using WinFormsEntryApp.UseCaseDemos.Basic;
using WinFormsEntryApp.UseCaseDemos.GenericForms;

namespace WinFormsEntryApp
{
    public static class DependencyConfigurer
    {

        public static IServiceProvider Configure()
        {
            ServiceCollection services = new ServiceCollection();

            ConfigureForms(services);

            ConfigureServices(services);

            ConfigureUseCases(services);

            return services.BuildServiceProvider();
        }

        private static void ConfigureServices(ServiceCollection services)
        {

            services.AddSingleton<LogManager>();

            services.AddSingleton<EnvironmentManager>();

            services.AddSingleton(sp => new DockerClientConfiguration(new Uri(Consts.DockerSocksAddress)));

            services.AddSingleton(sp => sp.GetRequiredService<DockerClientConfiguration>().CreateClient());

            services.AddSingleton(sp => new ConnectionFactory()
            {
                HostName = Consts.RabbitMQEndpointHostname,
                Port = Consts.RabbitMQEndpointAMQPPort,
                UserName = Consts.DockerContainerUsername,
                Password = Consts.DockerContainerPassword,
                VirtualHost = Consts.DockerContainerVirtualHost,
            });

            services.AddSingleton(sp => new RabbitMQManagementApi(new ConnectionFactory()
            {
                HostName = Consts.RabbitMQEndpointHostname,
                Port = Consts.RabbitMQEndpointAPIPort,
                UserName = Consts.DockerContainerUsername,
                Password = Consts.DockerContainerPassword,
            }));

        }

        private static void ConfigureForms(ServiceCollection services)
        {
            services.AddTransient<ConsumerFeedback>();
            services.AddTransient<ConsumeMessageForm>();
            services.AddTransient<CreateVirtualHostForm>();
            services.AddTransient<RabbitMQBasicsDemo>();
            services.AddSingleton<Entrypoint>();
            services.AddSingleton<LogWindow>();
        }

        private static void ConfigureUseCases(ServiceCollection services)
        {
            services.AddSingleton(sp => UseCase.Build<RabbitMQBasicsDemo>("Fundamentos", Properties.Resources.RabbitMQBasics, sp));
            //services.AddSingleton(sp => new UseCase() { Name = "bbb", Description = "bbbb", Form = null });
            //services.AddSingleton(sp => new UseCase() { Name = "ccc", Description = "bbbb", Form = null });
            //services.AddSingleton(sp => new UseCase() { Name = "ddd", Description = "bbbb", Form = null });
            //services.AddSingleton(sp => new UseCase() { Name = "eee", Description = "bbbb", Form = null });
        }
    }
}
