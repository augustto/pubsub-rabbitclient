using Core.AdminApi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsEntryApp.UseCaseDemos
{
    public partial class CreateVirtualHostForm : Form
    {
        RabbitMQManagementApi rabbitMQManagementApi;

        public CreateVirtualHostForm()
        {
            InitializeComponent();
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            if (this.rabbitMQManagementApi.VirtualHost.CreateVirtualHost(this.nameTextBox.Text, this.descriptionTextBox.Text, string.Empty))
            {
                DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                DialogResult = DialogResult.Abort;
                this.Close();
            }
        }

        private void CreateVirtualHostForm_Load(object sender, EventArgs e)
        {

        }


        internal bool CreateVirtualHost(RabbitMQManagementApi rabbitMQManagementApi)
        {
            this.rabbitMQManagementApi = rabbitMQManagementApi;
            return (this.ShowDialog() == DialogResult.OK);
        }
    }
}
