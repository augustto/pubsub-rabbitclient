using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Core.AdminApi.Exchanges
{
    public class Arguments
    {
    }

    public class Exchange
    {

        [JsonProperty("arguments")]
        public Arguments Arguments { get; set; }

        [JsonProperty("auto_delete")]
        public bool AutoDelete { get; set; }

        [JsonProperty("durable")]
        [Category("Identity"), DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public bool Durable { get; set; }

        [JsonProperty("internal")]
        public bool Internal { get; set; }

        [JsonProperty("name")]
        [Category("Identity"), DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("user_who_performed_action")]
        public string UserWhoPerformedAction { get; set; }

        [JsonProperty("vhost")]
        [Category("Identity"), DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public string Vhost { get; set; }
    }


}
