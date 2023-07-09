using System.Runtime.Serialization;

namespace Firecracker.Management.Models;

/// <summary>Enumeration indicating the MMDS version to be configured.</summary>
public enum MmdsConfig_version
{
    [EnumMember(Value = "V1")] V1,
    [EnumMember(Value = "V2")] V2,
}