using Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsEntryApp
{
    public partial class LogWindow : Form
    {
        private readonly LogManager logManager;

        public LogWindow(LogManager logManager)
        {
            InitializeComponent();
            this.logManager = logManager;

            this.logManager.Log += this.WriteLogOnTextbox;
        }

        private void LogWindow_Load(object sender, EventArgs e) => WriteLogOnTextbox(this.logManager.ToString());

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

        private void LogWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                this.Hide();
            }
        }
    }
}
