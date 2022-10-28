using Core.AdminApi.Queues;
using Microsoft.Extensions.DependencyInjection;
using RabbitMQ.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsEntryApp.UseCaseDemos.GenericForms
{
    public partial class ConsumeMessageForm : Form
    {
        private readonly IConnection connection;
        private readonly IServiceProvider serviceProvider;
        IModel channel;
        Queue queue;

        public ConsumeMessageForm(ConnectionFactory connectionFactory, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            this.connection = connectionFactory.CreateConnection();
            this.channel = connection.CreateModel();
            this.serviceProvider = serviceProvider;
           
        }

        internal void Consume(Queue queue)
        {
            this.queue = queue;
            
            this.Show();
        }

        private void consumeButton_Click(object sender, EventArgs e)
        {
            string consumerTag = null;
            var consumer = new RabbitMQ.Client.Events.EventingBasicConsumer(channel);
            consumer.Received += (ch, ea) =>
            {
                serviceProvider.GetRequiredService<ConsumerFeedback>().ConsumeItem(this.channel, ea);

                this.channel.BasicCancelNoWait(consumerTag);

            };

            consumerTag = channel.BasicConsume(this.queue.Name, false, consumer);
        }

        private void ConsumeMessageForm_Load(object sender, EventArgs e)
        {
            this.textBox1.DataBindings.Add("Text", this.queue, "Vhost");
            this.textBox2.DataBindings.Add("Text", this.queue, "Name");
        }

        private void ConsumeMessageForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.channel.Dispose();
            this.connection.Dispose();
        }
    }
}
