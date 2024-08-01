using System.Text.Json.Serialization;

using MessagePack;

namespace Serilog.Sinks.AddLog.Payload;

using System;
using System.Collections.Generic;

[MessagePackObject]
public sealed class CreateServiceBusRequestLogRequest
{
    [IgnoreMember]
    [JsonIgnore]
    public bool IsExcluded { get; set; } = false;
    [IgnoreMember]
    [JsonIgnore]
    public double? Duration { get; set; }
    [Key(0)]
    public string ResponseStream { get; set; } = null!;
    [Key(1)]
    public string SdkName { get; set; } = null!;
    [Key(2)]
    public string SdkVersion { get; set; } = null!;
    [Key(3)]
    public string DeliveryChannel { get; set; } = null!;
    [Key(4)]
    public string ClientId { get; set; } = null!;
    [Key(5)]
    public string OrganizationId { get; set; } = null!;
    [Key(6)]
    public string ApplicationId { get; set; } = null!;
    [Key(7)]
    public DateTime StartDateTime { get; set; }
    [Key(8)]
    public double DurationInMilliseconds { get; set; }
    [Key(9)]
    public bool IsNewSession { get; set; }
    [Key(10)]
    public string? SessionId { get; set; }
    [Key(11)]
    public string MachineName { get; set; } = null!;
    [Key(12)]
    public bool IsAuthenticated { get; set; }
    [Key(13)]
    public User User { get; set; }
    [Key(14)]
    public WebRequestProperties WebRequest { get; set; }
    [Key(15)]
    public IList<LogMessage> LogMessages { get; set; }
    [Key(16)]
    public IList<CapturedException> Exceptions { get; set; }
    [Key(17)]
    public IList<string> Keywords { get; set; }
    [Key(18)]
    public IList<KeyValuePair<string, string>> CustomProperties { get; set; }

    public CreateServiceBusRequestLogRequest()
    {
        User = new User();
        WebRequest = new WebRequestProperties();
        ClientId = Guid.NewGuid().ToString();
        LogMessages = [];
        Exceptions = [];
        Keywords = [];
        CustomProperties = [];
    }
}
