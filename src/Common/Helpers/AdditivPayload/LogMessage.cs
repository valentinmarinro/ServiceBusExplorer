using MessagePack;

namespace Serilog.Sinks.AddLog.Payload;

[MessagePackObject]
public sealed class LogMessage
{
    [Key(0)]
    public string CategoryName { get; set; } = null!;
    [Key(1)]
    public string LogLevel { get; set; } = null!;
    [Key(2)]
    public string Message { get; set; } = null!;
    [Key(3)]
    public double MillisecondsSinceStartRequest { get; set; }
    [Key(4)]
    public string MemberType { get; set; } = null!;
    [Key(5)]
    public string MemberName { get; set; } = null!;
    [Key(6)]
    public int LineNumber { get; set; }
}