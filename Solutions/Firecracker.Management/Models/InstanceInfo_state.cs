using System.Runtime.Serialization;

namespace Firecracker.Management.Models;

/// <summary>The current detailed state (Not started, Running, Paused) of the Firecracker instance. This value is read-only for the control-plane.</summary>
public enum InstanceInfo_state
{
    [EnumMember(Value = "Not started")] NotStarted,
    [EnumMember(Value = "Running")] Running,
    [EnumMember(Value = "Paused")] Paused,
}