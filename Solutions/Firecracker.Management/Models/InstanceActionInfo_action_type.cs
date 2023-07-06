using System.Runtime.Serialization;

namespace Firecracker.Management.Models;

/// <summary>Enumeration indicating what type of action is contained in the payload</summary>
public enum InstanceActionInfo_action_type
{
    [EnumMember(Value = "FlushMetrics")] FlushMetrics,
    [EnumMember(Value = "InstanceStart")] InstanceStart,
    [EnumMember(Value = "SendCtrlAltDel")] SendCtrlAltDel,
}