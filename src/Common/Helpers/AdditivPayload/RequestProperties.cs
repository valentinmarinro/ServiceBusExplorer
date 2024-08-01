using MessagePack;

namespace Serilog.Sinks.AddLog.Payload;

using System.Collections.Generic;

[MessagePackObject]
public sealed class RequestProperties
{
    [Key(0)]
    public IList<KeyValuePair<string, string>> Headers { get; set; }
    [Key(1)]
    public IList<KeyValuePair<string, string>> Cookies { get; set; }
    [Key(2)]
    public IList<KeyValuePair<string, string>> QueryString { get; set; }
    [Key(3)]
    public IList<KeyValuePair<string, string>> FormData { get; set; }
    [Key(4)]
    public IList<KeyValuePair<string, string>> ServerVariables { get; set; }
    [Key(5)]
    public IList<KeyValuePair<string, string>> Claims { get; set; }
    [Key(6)]
    public string InputStream { get; set; } = null!;

    public RequestProperties()
    {
        Headers = [];
        Cookies = [];
        QueryString = [];
        FormData = [];
        ServerVariables = [];
        Claims = [];
    }
}
