using System.Runtime.Serialization;

namespace Firecracker.Management.Models;

/// <summary>Set the level. The possible values are case-insensitive.</summary>
public enum Logger_level
{
    [EnumMember(Value = "Error")] Error,
    [EnumMember(Value = "Warning")] Warning,
    [EnumMember(Value = "Info")] Info,
    [EnumMember(Value = "Debug")] Debug,
}