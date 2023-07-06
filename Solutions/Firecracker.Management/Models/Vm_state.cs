using System.Runtime.Serialization;

namespace Firecracker.Management.Models;

public enum Vm_state
{
    [EnumMember(Value = "Paused")] Paused,
    [EnumMember(Value = "Resumed")] Resumed,
}