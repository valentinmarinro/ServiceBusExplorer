using MessagePack;

namespace Serilog.Sinks.AddLog.Payload;

[MessagePackObject]
public sealed class CapturedException
{
    [Key(0)]
    public string ExceptionType { get; set; } = null!;
    [Key(1)]
    public string ExceptionMessage { get; set; } = null!;
}