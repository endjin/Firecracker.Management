using Microsoft.Kiota.Abstractions.Serialization;

namespace Firecracker.Management.Models;

/// <summary>
/// Describes the number of vCPUs, memory size, SMT capabilities and the CPU template.
/// </summary>
public class MachineConfiguration : IAdditionalDataHolder, IParsable
{
    /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
    public IDictionary<string, object> AdditionalData { get; set; }

    /// <summary>The CPU Template defines a set of flags to be disabled from the microvm so that the features exposed to the guest are the same as in the selected instance type.</summary>
    public CpuTemplate? CpuTemplate { get; set; }

    /// <summary>Memory size of VM</summary>
    public int? MemSizeMib { get; set; }

    /// <summary>Flag for enabling/disabling simultaneous multithreading. Can be enabled only on x86.</summary>
    public bool? Smt { get; set; }

    /// <summary>Enable dirty page tracking. If this is enabled, then incremental guest memory snapshots can be created. These belong to diff snapshots, which contain, besides the microVM state, only the memory dirtied since a previous snapshot. Full snapshots each contain a full copy of the guest memory.</summary>
    public bool? TrackDirtyPages { get; set; }

    /// <summary>Number of vCPUs (either 1 or an even number)</summary>
    public int? VcpuCount { get; set; }

    /// <summary>
    /// Instantiates a new MachineConfiguration and sets the default values.
    /// </summary>
    public MachineConfiguration()
    {
        this.AdditionalData = new Dictionary<string, object>();
        this.CpuTemplate = Models.CpuTemplate.None;
    }

    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static MachineConfiguration CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new MachineConfiguration();
    }

    /// <summary>
    /// The deserialization information for the current model
    /// </summary>
    public IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
    {
        return new Dictionary<string, Action<IParseNode>>
        {
            { "cpu_template", n => { this.CpuTemplate = n.GetEnumValue<CpuTemplate>(); } },
            { "mem_size_mib", n => { this.MemSizeMib = n.GetIntValue(); } },
            { "smt", n => { this.Smt = n.GetBoolValue(); } },
            { "track_dirty_pages", n => { this.TrackDirtyPages = n.GetBoolValue(); } },
            { "vcpu_count", n => { this.VcpuCount = n.GetIntValue(); } },
        };
    }

    /// <summary>
    /// Serializes information the current object
    /// </summary>
    /// <param name="writer">Serialization writer to use to serialize this model</param>
    public void Serialize(ISerializationWriter writer)
    {
        _ = writer ?? throw new ArgumentNullException(nameof(writer));
        writer.WriteEnumValue<CpuTemplate>("cpu_template", this.CpuTemplate);
        writer.WriteIntValue("mem_size_mib", this.MemSizeMib);
        writer.WriteBoolValue("smt", this.Smt);
        writer.WriteBoolValue("track_dirty_pages", this.TrackDirtyPages);
        writer.WriteIntValue("vcpu_count", this.VcpuCount);
        writer.WriteAdditionalData(this.AdditionalData);
    }
}