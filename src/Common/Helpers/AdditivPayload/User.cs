using MessagePack;

namespace Serilog.Sinks.AddLog.Payload;

[MessagePackObject]
public sealed class User
{
    [Key(0)]
    public string Name { get; set; } = null!;
    [Key(1)]
    public string EmailAddress { get; set; } = null!;
    [Key(2)]
    public string Avatar { get; set; } = null!;
}