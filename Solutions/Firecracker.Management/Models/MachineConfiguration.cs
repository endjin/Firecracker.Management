// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Firecracker.Management.Models
{
    /// <summary>
    /// Describes the number of vCPUs, memory size, SMT capabilities, huge page configuration and the CPU template.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class MachineConfiguration : IAdditionalDataHolder, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The CPU Template defines a set of flags to be disabled from the microvm so that the features exposed to the guest are the same as in the selected instance type. This parameter has been deprecated and it will be removed in future Firecracker release.</summary>
        public global::Firecracker.Management.Models.CpuTemplate? CpuTemplate { get; set; }
        /// <summary>Which huge pages configuration (if any) should be used to back guest memory.</summary>
        public global::Firecracker.Management.Models.MachineConfiguration_huge_pages? HugePages { get; set; }
        /// <summary>Memory size of VM</summary>
        public int? MemSizeMib { get; set; }
        /// <summary>Flag for enabling/disabling simultaneous multithreading. Can be enabled only on x86.</summary>
        public bool? Smt { get; set; }
        /// <summary>Enable dirty page tracking. If this is enabled, then incremental guest memory snapshots can be created. These belong to diff snapshots, which contain, besides the microVM state, only the memory dirtied since a previous snapshot. Full snapshots each contain a full copy of the guest memory.</summary>
        public bool? TrackDirtyPages { get; set; }
        /// <summary>Number of vCPUs (either 1 or an even number)</summary>
        public int? VcpuCount { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::Firecracker.Management.Models.MachineConfiguration"/> and sets the default values.
        /// </summary>
        public MachineConfiguration()
        {
            AdditionalData = new Dictionary<string, object>();
            CpuTemplate = global::Firecracker.Management.Models.CpuTemplate.None;
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Firecracker.Management.Models.MachineConfiguration"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Firecracker.Management.Models.MachineConfiguration CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Firecracker.Management.Models.MachineConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "cpu_template", n => { CpuTemplate = n.GetEnumValue<global::Firecracker.Management.Models.CpuTemplate>(); } },
                { "huge_pages", n => { HugePages = n.GetEnumValue<global::Firecracker.Management.Models.MachineConfiguration_huge_pages>(); } },
                { "mem_size_mib", n => { MemSizeMib = n.GetIntValue(); } },
                { "smt", n => { Smt = n.GetBoolValue(); } },
                { "track_dirty_pages", n => { TrackDirtyPages = n.GetBoolValue(); } },
                { "vcpu_count", n => { VcpuCount = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<global::Firecracker.Management.Models.CpuTemplate>("cpu_template", CpuTemplate);
            writer.WriteEnumValue<global::Firecracker.Management.Models.MachineConfiguration_huge_pages>("huge_pages", HugePages);
            writer.WriteIntValue("mem_size_mib", MemSizeMib);
            writer.WriteBoolValue("smt", Smt);
            writer.WriteBoolValue("track_dirty_pages", TrackDirtyPages);
            writer.WriteIntValue("vcpu_count", VcpuCount);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
