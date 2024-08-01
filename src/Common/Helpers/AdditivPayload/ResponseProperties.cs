using MessagePack;

namespace Serilog.Sinks.AddLog.Payload;

using System.Collections.Generic;

[MessagePackObject]
public sealed class ResponseProperties
{
    [Key(0)]
    public string HttpStatusCodeText { get; set; } = null!;
    [Key(1)]
    public int HttpStatusCode { get; set; }
    [Key(2)]
    public IList<KeyValuePair<string, string>> Headers { get; set; }
    [Key(3)]
    public long ContentLength { get; set; }

    public ResponseProperties()
    {
        Headers = [];
    }
}
