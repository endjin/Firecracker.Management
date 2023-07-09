using Microsoft.Kiota.Abstractions.Serialization;

namespace Firecracker.Management.Models;

public class SnapshotCreateParams : IAdditionalDataHolder, IParsable
{
    /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
    public IDictionary<string, object> AdditionalData { get; set; }

    /// <summary>Path to the file that will contain the guest memory.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public string? MemFilePath { get; set; }
#nullable restore
#else
        public string MemFilePath { get; set; }
#endif
    /// <summary>Path to the file that will contain the microVM state.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public string? SnapshotPath { get; set; }
#nullable restore
#else
        public string SnapshotPath { get; set; }
#endif
    /// <summary>Type of snapshot to create. It is optional and by default, a full snapshot is created.</summary>
    public SnapshotCreateParams_snapshot_type? SnapshotType { get; set; }

    /// <summary>The microVM version for which we want to create the snapshot. It is optional and it defaults to the current version.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public string? Version { get; set; }
#nullable restore
#else
        public string Version { get; set; }
#endif
    /// <summary>
    /// Instantiates a new SnapshotCreateParams and sets the default values.
    /// </summary>
    public SnapshotCreateParams()
    {
        this.AdditionalData = new Dictionary<string, object>();
    }

    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static SnapshotCreateParams CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new SnapshotCreateParams();
    }

    /// <summary>
    /// The deserialization information for the current model
    /// </summary>
    public IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
    {
        return new Dictionary<string, Action<IParseNode>>
        {
            { "mem_file_path", n => { this.MemFilePath = n.GetStringValue(); } },
            { "snapshot_path", n => { this.SnapshotPath = n.GetStringValue(); } },
            { "snapshot_type", n => { this.SnapshotType = n.GetEnumValue<SnapshotCreateParams_snapshot_type>(); } },
            { "version", n => { this.Version = n.GetStringValue(); } },
        };
    }

    /// <summary>
    /// Serializes information the current object
    /// </summary>
    /// <param name="writer">Serialization writer to use to serialize this model</param>
    public void Serialize(ISerializationWriter writer)
    {
        _ = writer ?? throw new ArgumentNullException(nameof(writer));
        writer.WriteStringValue("mem_file_path", this.MemFilePath);
        writer.WriteStringValue("snapshot_path", this.SnapshotPath);
        writer.WriteEnumValue<SnapshotCreateParams_snapshot_type>("snapshot_type", this.SnapshotType);
        writer.WriteStringValue("version", this.Version);
        writer.WriteAdditionalData(this.AdditionalData);
    }
}