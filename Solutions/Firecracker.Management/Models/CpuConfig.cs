using Microsoft.Kiota.Abstractions.Serialization;

namespace Firecracker.Management.Models;

/// <summary>
/// The CPU configuration template defines a set of bit maps as modifiers of flags accessed by register to be disabled/enabled for the microvm.
/// </summary>
public class CpuConfig : IAdditionalDataHolder, IParsable
{
    /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
    public IDictionary<string, object> AdditionalData { get; set; }

    /// <summary>A collection of CPUIDs to be modified. (x86_64)</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public CpuConfig_cpuid_modifiers? CpuidModifiers { get; set; }
#nullable restore
#else
        public CpuConfig_cpuid_modifiers CpuidModifiers { get; set; }
#endif
    /// <summary>A collection of model specific registers to be modified. (x86_64)</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public CpuConfig_msr_modifiers? MsrModifiers { get; set; }
#nullable restore
#else
        public CpuConfig_msr_modifiers MsrModifiers { get; set; }
#endif
    /// <summary>A collection of registers to be modified. (aarch64)</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public CpuConfig_reg_modifiers? RegModifiers { get; set; }
#nullable restore
#else
        public CpuConfig_reg_modifiers RegModifiers { get; set; }
#endif
    /// <summary>
    /// Instantiates a new CpuConfig and sets the default values.
    /// </summary>
    public CpuConfig()
    {
        this.AdditionalData = new Dictionary<string, object>();
    }

    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static CpuConfig CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new CpuConfig();
    }

    /// <summary>
    /// The deserialization information for the current model
    /// </summary>
    public IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
    {
        return new Dictionary<string, Action<IParseNode>>
        {
            {
                "cpuid_modifiers",
                n =>
                {
                    this.CpuidModifiers =
                        n.GetObjectValue<CpuConfig_cpuid_modifiers>(CpuConfig_cpuid_modifiers
                            .CreateFromDiscriminatorValue);
                }
            },
            {
                "msr_modifiers",
                n =>
                {
                    this.MsrModifiers =
                        n.GetObjectValue<CpuConfig_msr_modifiers>(CpuConfig_msr_modifiers
                            .CreateFromDiscriminatorValue);
                }
            },
            {
                "reg_modifiers",
                n =>
                {
                    this.RegModifiers =
                        n.GetObjectValue<CpuConfig_reg_modifiers>(CpuConfig_reg_modifiers
                            .CreateFromDiscriminatorValue);
                }
            },
        };
    }

    /// <summary>
    /// Serializes information the current object
    /// </summary>
    /// <param name="writer">Serialization writer to use to serialize this model</param>
    public void Serialize(ISerializationWriter writer)
    {
        _ = writer ?? throw new ArgumentNullException(nameof(writer));
        writer.WriteObjectValue<CpuConfig_cpuid_modifiers>("cpuid_modifiers", this.CpuidModifiers);
        writer.WriteObjectValue<CpuConfig_msr_modifiers>("msr_modifiers", this.MsrModifiers);
        writer.WriteObjectValue<CpuConfig_reg_modifiers>("reg_modifiers", this.RegModifiers);
        writer.WriteAdditionalData(this.AdditionalData);
    }
}