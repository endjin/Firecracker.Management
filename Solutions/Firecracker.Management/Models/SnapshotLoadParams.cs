using Microsoft.Kiota.Abstractions.Serialization;

namespace Firecracker.Management.Models;

/// <summary>
/// Defines the configuration used for handling snapshot resume. Exactly one of the two `mem_*` fields must be present in the body of the request.
/// </summary>
public class SnapshotLoadParams : IAdditionalDataHolder, IParsable
{
    /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
    public IDictionary<string, object> AdditionalData { get; set; }

    /// <summary>Enable support for incremental (diff) snapshots by tracking dirty guest pages.</summary>
    public bool? EnableDiffSnapshots { get; set; }

    /// <summary>The mem_backend property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public MemoryBackend? MemBackend { get; set; }
#nullable restore
#else
        public MemoryBackend MemBackend { get; set; }
#endif
    /// <summary>Path to the file that contains the guest memory to be loaded. This parameter has been deprecated and is only allowed if `mem_backend` is not present.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public string? MemFilePath { get; set; }
#nullable restore
#else
        public string MemFilePath { get; set; }
#endif
    /// <summary>When set to true, the vm is also resumed if the snapshot load is successful.</summary>
    public bool? ResumeVm { get; set; }

    /// <summary>Path to the file that contains the microVM state to be loaded.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public string? SnapshotPath { get; set; }
#nullable restore
#else
        public string SnapshotPath { get; set; }
#endif
    /// <summary>
    /// Instantiates a new SnapshotLoadParams and sets the default values.
    /// </summary>
    public SnapshotLoadParams()
    {
        this.AdditionalData = new Dictionary<string, object>();
    }

    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static SnapshotLoadParams CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new SnapshotLoadParams();
    }

    /// <summary>
    /// The deserialization information for the current model
    /// </summary>
    public IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
    {
        return new Dictionary<string, Action<IParseNode>>
        {
            { "enable_diff_snapshots", n => { this.EnableDiffSnapshots = n.GetBoolValue(); } },
            {
                "mem_backend",
                n => { this.MemBackend = n.GetObjectValue<MemoryBackend>(MemoryBackend.CreateFromDiscriminatorValue); }
            },
            { "mem_file_path", n => { this.MemFilePath = n.GetStringValue(); } },
            { "resume_vm", n => { this.ResumeVm = n.GetBoolValue(); } },
            { "snapshot_path", n => { this.SnapshotPath = n.GetStringValue(); } },
        };
    }

    /// <summary>
    /// Serializes information the current object
    /// </summary>
    /// <param name="writer">Serialization writer to use to serialize this model</param>
    public void Serialize(ISerializationWriter writer)
    {
        _ = writer ?? throw new ArgumentNullException(nameof(writer));
        writer.WriteBoolValue("enable_diff_snapshots", this.EnableDiffSnapshots);
        writer.WriteObjectValue<MemoryBackend>("mem_backend", this.MemBackend);
        writer.WriteStringValue("mem_file_path", this.MemFilePath);
        writer.WriteBoolValue("resume_vm", this.ResumeVm);
        writer.WriteStringValue("snapshot_path", this.SnapshotPath);
        writer.WriteAdditionalData(this.AdditionalData);
    }
}