using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Core.AdminApi.Queues
{
    public class Arguments
    {

        [JsonProperty("x-queue-type")]
        public string XQueueType { get; set; }
    }

    public class BackingQueueStatus
    {

        [JsonProperty("avg_ack_egress_rate")]
        public double AvgAckEgressRate { get; set; }

        [JsonProperty("avg_ack_ingress_rate")]
        public double AvgAckIngressRate { get; set; }

        [JsonProperty("avg_egress_rate")]
        public double AvgEgressRate { get; set; }

        [JsonProperty("avg_ingress_rate")]
        public double AvgIngressRate { get; set; }

        [JsonProperty("delta")]
        public IList<object> Delta { get; set; }

        [JsonProperty("len")]
        public int Len { get; set; }

        [JsonProperty("mode")]
        public string Mode { get; set; }

        [JsonProperty("next_seq_id")]
        public int NextSeqId { get; set; }

        [JsonProperty("q1")]
        public int Q1 { get; set; }

        [JsonProperty("q2")]
        public int Q2 { get; set; }

        [JsonProperty("q3")]
        public int Q3 { get; set; }

        [JsonProperty("q4")]
        public int Q4 { get; set; }

        [JsonProperty("target_ram_count")]
        public string TargetRamCount { get; set; }
    }

    public class EffectivePolicyDefinition
    {
    }

    public class GarbageCollection
    {

        [JsonProperty("fullsweep_after")]
        public int FullsweepAfter { get; set; }

        [JsonProperty("max_heap_size")]
        public int MaxHeapSize { get; set; }

        [JsonProperty("min_bin_vheap_size")]
        public int MinBinVheapSize { get; set; }

        [JsonProperty("min_heap_size")]
        public int MinHeapSize { get; set; }

        [JsonProperty("minor_gcs")]
        public int MinorGcs { get; set; }
    }

    public class MessagesDetails
    {

        [JsonProperty("rate")]
        public double Rate { get; set; }
    }

    public class MessagesReadyDetails
    {

        [JsonProperty("rate")]
        public double Rate { get; set; }
    }

    public class MessagesUnacknowledgedDetails
    {

        [JsonProperty("rate")]
        public double Rate { get; set; }
    }

    public class ReductionsDetails
    {

        [JsonProperty("rate")]
        public double Rate { get; set; }
    }

    public class OpenFiles
    {

        [JsonProperty("rabbit@container-rabbitmq")]
        public int ContainerRabbitmq { get; set; }
    }

    public class Queue
    {

        [JsonProperty("arguments")]
        [Category("Details"), Description("Content"), DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public Arguments Arguments { get; set; }

        [JsonProperty("auto_delete")]
        [Category("Identity"), DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public bool AutoDelete { get; set; }

        [JsonProperty("backing_queue_status")]
        [Category("Details"), Description("Content"), DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]

        public BackingQueueStatus BackingQueueStatus { get; set; }

        [JsonProperty("consumer_utilisation")]
        public int? ConsumerUtilisation { get; set; }

        [JsonProperty("consumers")]
        public int Consumers { get; set; }

        [JsonProperty("durable")]
        [Category("Identity"), DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public bool Durable { get; set; }

        [JsonProperty("effective_policy_definition")]
        [Category("Details"), Description("Content"), DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public EffectivePolicyDefinition EffectivePolicyDefinition { get; set; }

        [JsonProperty("exclusive")]
        [Category("Identity"), DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public bool Exclusive { get; set; }

        [JsonProperty("exclusive_consumer_tag")]
        public object ExclusiveConsumerTag { get; set; }

        [JsonProperty("garbage_collection")]
        [Category("Details"), Description("Content"), DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public GarbageCollection GarbageCollection { get; set; }

        [JsonProperty("head_message_timestamp")]
        public object HeadMessageTimestamp { get; set; }

        [JsonProperty("idle_since")]
        public string IdleSince { get; set; }

        [JsonProperty("memory")]
        public int Memory { get; set; }

        [JsonProperty("message_bytes")]
        public int MessageBytes { get; set; }

        [JsonProperty("message_bytes_paged_out")]
        public int MessageBytesPagedOut { get; set; }

        [JsonProperty("message_bytes_persistent")]
        public int MessageBytesPersistent { get; set; }

        [JsonProperty("message_bytes_ram")]
        public int MessageBytesRam { get; set; }

        [JsonProperty("message_bytes_ready")]
        public int MessageBytesReady { get; set; }

        [JsonProperty("message_bytes_unacknowledged")]
        public int MessageBytesUnacknowledged { get; set; }

        [JsonProperty("messages")]
        public int Messages { get; set; }

        [JsonProperty("messages_details")]
        [Category("Details"), Description("Content"), DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public MessagesDetails MessagesDetails { get; set; }

        [JsonProperty("messages_paged_out")]
        public int MessagesPagedOut { get; set; }

        [JsonProperty("messages_persistent")]
        public int MessagesPersistent { get; set; }

        [JsonProperty("messages_ram")]
        public int MessagesRam { get; set; }

        [JsonProperty("messages_ready")]
        public int MessagesReady { get; set; }

        [JsonProperty("messages_ready_details")]
        [Category("Details"), Description("Content"), DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public MessagesReadyDetails MessagesReadyDetails { get; set; }

        [JsonProperty("messages_ready_ram")]
        public int MessagesReadyRam { get; set; }

        [JsonProperty("messages_unacknowledged")]
        public int MessagesUnacknowledged { get; set; }

        [JsonProperty("messages_unacknowledged_details")]
        [Category("Details"), Description("Content"), DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public MessagesUnacknowledgedDetails MessagesUnacknowledgedDetails { get; set; }

        [JsonProperty("messages_unacknowledged_ram")]
        public int MessagesUnacknowledgedRam { get; set; }

        [JsonProperty("name")]
        [Category("Identity"), DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public string Name { get; set; }

        [JsonProperty("node")]
        public string Node { get; set; }

        [JsonProperty("operator_policy")]
        public object OperatorPolicy { get; set; }

        [JsonProperty("policy")]
        public object Policy { get; set; }

        [JsonProperty("recoverable_slaves")]
        public object RecoverableSlaves { get; set; }

        [JsonProperty("reductions")]
        public int Reductions { get; set; }

        [JsonProperty("reductions_details")]
        public ReductionsDetails ReductionsDetails { get; set; }

        [JsonProperty("single_active_consumer_tag")]
        public object SingleActiveConsumerTag { get; set; }

        [JsonProperty("state")]
        [Category("Identity"), DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public string State { get; set; }

        [JsonProperty("type")]
        [Category("Identity"), DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public string Type { get; set; }

        [JsonProperty("vhost")]
        [Category("Identity"), DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public string Vhost { get; set; }

        [JsonProperty("leader")]
        public string Leader { get; set; }

        [JsonProperty("members")]
        public IList<string> Members { get; set; }

        [JsonProperty("online")]
        public IList<string> Online { get; set; }

        [JsonProperty("open_files")]
        public OpenFiles OpenFiles { get; set; }

        [JsonProperty("single_active_consumer_ctag")]
        public object SingleActiveConsumerCtag { get; set; }
    }


}
