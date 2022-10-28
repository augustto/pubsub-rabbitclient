using Core;
using Docker.DotNet.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsEntryApp.Model;

namespace WinFormsEntryApp
{
    public partial class Entrypoint : Form
    {
        private readonly EnvironmentManager connectionManager;
        private readonly LogManager logManager;
        private readonly LogWindow logWindow;
        private readonly BindingSource bindingSource;

        public Entrypoint(EnvironmentManager connectionManager, LogManager logManager, LogWindow logWindow, IEnumerable<UseCase> useCases)
        {
            InitializeComponent();
            this.connectionManager = connectionManager;
            this.logManager = logManager;
            this.logWindow = logWindow;
            this.logManager.Log += this.WriteLogOnTextbox;


            this.bindingSource = new System.Windows.Forms.BindingSource()
            {
                DataSource = useCases.ToList()
            };
        }

        private void Entrypoint_Load(object sender, EventArgs e)
        {
            useCasesDataGridView.DataSource = bindingSource;
        }


        delegate void SafeCallDelegate(string message);
        private void WriteLogOnTextbox(string message)
        {
            if (this.log.InvokeRequired)
            {
                var safeCallDelegate = new SafeCallDelegate(WriteLogOnTextbox);
                log.Invoke(safeCallDelegate, new object[] { message });
            }
            else
            {
                this.log.Text += message + Environment.NewLine;
                this.log.SelectionStart = this.log.TextLength;
                this.log.ScrollToCaret();
            }
        }

        private async void Reset_ClickAsync(object sender, EventArgs e)
        {
            await connectionManager.Reset();
            await connectionManager.Initialize();
        }

        private void OpenLogButtom_Click(object sender, EventArgs e)
        {
            logWindow.Show();
        }



        private void UseCasesDataGridView_DoubleClick(object sender, EventArgs e)
        {

        }

        private void UseCasesDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = this.useCasesDataGridView.Rows[e.RowIndex];
            var useCase = (UseCase)row.DataBoundItem;
            useCase.Show();
        }
    }
}
