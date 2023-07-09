using System.Runtime.Serialization;

namespace Firecracker.Management.Models;

/// <summary>Type of the IO engine used by the device. &quot;Async&quot; is supported on host kernels newer than 5.10.51.</summary>
public enum Drive_io_engine
{
    [EnumMember(Value = "Sync")] Sync,
    [EnumMember(Value = "Async")] Async,
}