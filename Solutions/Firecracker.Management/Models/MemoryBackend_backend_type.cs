using System.Runtime.Serialization;

namespace Firecracker.Management.Models;

public enum MemoryBackend_backend_type
{
    [EnumMember(Value = "File")] File,
    [EnumMember(Value = "Uffd")] Uffd,
}