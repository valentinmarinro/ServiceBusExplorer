using MessagePack;

namespace Serilog.Sinks.AddLog.Payload;

[MessagePackObject]
public sealed class Url
{
    [Key(0)]
    public string Path { get; set; } = null!;
    [Key(1)]
    public string PathAndQuery { get; set; } = null!;
    [Key(2)]
    public string AbsoluteUri { get; set; } = null!;
}