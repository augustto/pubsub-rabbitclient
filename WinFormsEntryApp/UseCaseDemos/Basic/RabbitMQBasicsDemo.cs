using Core.AdminApi;
using Core.AdminApi.VirtualHosts;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsEntryApp.UseCaseDemos.GenericForms;

namespace WinFormsEntryApp.UseCaseDemos.Basic
{
    public partial class RabbitMQBasicsDemo : Form
    {
        private readonly RabbitMQManagementApi rabbitMQManagementApi;
        private readonly IServiceProvider serviceProvider;

        public RabbitMQBasicsDemo(RabbitMQManagementApi rabbitMQManagementApi, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            this.rabbitMQManagementApi = rabbitMQManagementApi;
            this.serviceProvider = serviceProvider;
        }


        private void RabbitMQBasicsDemo_Load(object sender, EventArgs e)
        {
            virtualHostComboBox.DataSource = rabbitMQManagementApi.VirtualHost.GetVirtualHosts();
            virtualHostComboBox.DisplayMember = "Name";
            virtualHostComboBox.ValueMember = "Name";
        }




        private void RabbitMQBasicsDemo_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void virtualHostComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            exchangeInspectorControl.GetListFunc = () => rabbitMQManagementApi.Exchanges.GetExchanges(((VirtualHost)virtualHostComboBox.SelectedItem).Name);
            exchangeInspectorControl.ObjectInspectorControl_Load(sender, e);

            queueInspectorControl.GetListFunc = () => rabbitMQManagementApi.Queues.GetQueues(((VirtualHost)virtualHostComboBox.SelectedItem).Name);
            queueInspectorControl.ObjectInspectorControl_Load(sender, e);
        }

        private void createVirtualHostButton_Click(object sender, EventArgs e)
        {
            bool created = serviceProvider.GetRequiredService<CreateVirtualHostForm>().CreateVirtualHost(rabbitMQManagementApi);
            if (created)
                this.RabbitMQBasicsDemo_Load(this, e);
        }

        private void publishButton_Click(object sender, EventArgs e)
        {

        }

        private void consumeButton_Click(object sender, EventArgs e)
        {
            serviceProvider.GetRequiredService<ConsumeMessageForm>().Consume((Core.AdminApi.Queues.Queue)this.queueInspectorControl.SelectedItem);
            
        }
    }
}
