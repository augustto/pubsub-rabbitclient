using RabbitMQ.Client;
using RabbitMQ.Client.Events;
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
    public partial class ConsumerFeedback : Form
    {
        private IModel channel;
        private BasicDeliverEventArgs deliverEvent;

        public ConsumerFeedback()
        {
            InitializeComponent();
        }

       
        public void ConsumeItem(RabbitMQ.Client.IModel channel, RabbitMQ.Client.Events.BasicDeliverEventArgs deliverEvent)
        {
            this.messageBodyTextBox.Text = System.Text.Encoding.UTF8.GetString(deliverEvent.Body.ToArray());
            this.propertyGridHeaders.SelectedObject = deliverEvent.BasicProperties.Headers;

            this.channel = channel;
            this.deliverEvent = deliverEvent;
            this.ShowDialog();
        }

        private void ConsumerFeedback_Load(object sender, EventArgs e)
        {

        }

        private void ConsumerFeedback_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = (this.DialogResult != DialogResult.OK);
        }


        private void ackButton_Click(object sender, EventArgs e)
        {
            this.channel.BasicAck(this.deliverEvent.DeliveryTag, false);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void nackButton_Click(object sender, EventArgs e)
        {
            this.channel.BasicNack(this.deliverEvent.DeliveryTag, false, this.requeueCheckBox.Checked);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void rejectButton_Click(object sender, EventArgs e)
        {
            this.channel.BasicReject(this.deliverEvent.DeliveryTag, this.requeueCheckBox.Checked);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
