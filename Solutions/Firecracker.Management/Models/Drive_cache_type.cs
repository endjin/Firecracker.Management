using System.Runtime.Serialization;

namespace Firecracker.Management.Models;

/// <summary>Represents the caching strategy for the block device.</summary>
public enum Drive_cache_type
{
    [EnumMember(Value = "Unsafe")] Unsafe,
    [EnumMember(Value = "Writeback")] Writeback,
}