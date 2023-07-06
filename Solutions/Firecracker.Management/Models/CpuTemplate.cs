using System.Runtime.Serialization;

namespace Firecracker.Management.Models;

/// <summary>The CPU Template defines a set of flags to be disabled from the microvm so that the features exposed to the guest are the same as in the selected instance type.</summary>
public enum CpuTemplate
{
    [EnumMember(Value = "C3")] C3,
    [EnumMember(Value = "T2")] T2,
    [EnumMember(Value = "T2S")] T2S,
    [EnumMember(Value = "T2CL")] T2CL,
    [EnumMember(Value = "T2A")] T2A,
    [EnumMember(Value = "V1N1")] V1N1,
    [EnumMember(Value = "None")] None,
}