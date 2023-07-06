using System.Runtime.Serialization;

namespace Firecracker.Management.Models;

/// <summary>Type of snapshot to create. It is optional and by default, a full snapshot is created.</summary>
public enum SnapshotCreateParams_snapshot_type
{
    [EnumMember(Value = "Full")] Full,
    [EnumMember(Value = "Diff")] Diff,
}