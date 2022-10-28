using Docker.DotNet.Models;
using Newtonsoft.Json;
using RabbitMQ.Client;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
    public delegate void Log(string message);

    public class LogManager : IProgress<JSONMessage>, IProgress<string>
    {
        public event Log Log;
        private readonly StringBuilder logHistory;

        public LogManager()
        {
            this.logHistory = new StringBuilder();
            this.Log += this.LogHandler;
        }

        private void LogHandler(string message)
        {
            this.logHistory.AppendLine(message);
        }

        public void Report(string text) => this.Log?.Invoke(text);

        public void Report(JSONMessage value)
        {
            string text = JsonConvert.SerializeObject(value);

            this.Report(text);
        }

        public override string ToString()
        {
            return this.logHistory.ToString();
        }

    }
}
