using MessagePack;

namespace Serilog.Sinks.AddLog.Payload;

[MessagePackObject]
public sealed class WebRequestProperties
{
    [Key(0)]
    public Url Url { get; set; }
    [Key(1)]
    public string UserAgent { get; set; } = null!;
    [Key(2)]
    public string HttpMethod { get; set; } = null!;
    [Key(3)]
    public string RemoteAddress { get; set; } = null!;
    [Key(4)]
    public string HttpReferer { get; set; } = null!;
    [Key(5)]
    public RequestProperties Request { get; set; }
    [Key(6)]
    public ResponseProperties Response { get; set; }

    public WebRequestProperties()
    {
        Url = new Url();
        Request = new RequestProperties();
        Response = new ResponseProperties();
    }
}