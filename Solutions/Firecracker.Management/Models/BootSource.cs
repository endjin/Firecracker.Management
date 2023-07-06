using Microsoft.Kiota.Abstractions.Serialization;

namespace Firecracker.Management.Models;

/// <summary>
/// Boot source descriptor.
/// </summary>
public class BootSource : IAdditionalDataHolder, IParsable
{
    /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
    public IDictionary<string, object> AdditionalData { get; set; }

    /// <summary>Kernel boot arguments</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public string? BootArgs { get; set; }
#nullable restore
#else
        public string BootArgs { get; set; }
#endif
    /// <summary>Host level path to the initrd image used to boot the guest</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public string? InitrdPath { get; set; }
#nullable restore
#else
        public string InitrdPath { get; set; }
#endif
    /// <summary>Host level path to the kernel image used to boot the guest</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public string? KernelImagePath { get; set; }
#nullable restore
#else
        public string KernelImagePath { get; set; }
#endif
    /// <summary>
    /// Instantiates a new BootSource and sets the default values.
    /// </summary>
    public BootSource()
    {
        this.AdditionalData = new Dictionary<string, object>();
    }

    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static BootSource CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new BootSource();
    }

    /// <summary>
    /// The deserialization information for the current model
    /// </summary>
    public IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
    {
        return new Dictionary<string, Action<IParseNode>>
        {
            { "boot_args", n => { this.BootArgs = n.GetStringValue(); } },
            { "initrd_path", n => { this.InitrdPath = n.GetStringValue(); } },
            { "kernel_image_path", n => { this.KernelImagePath = n.GetStringValue(); } },
        };
    }

    /// <summary>
    /// Serializes information the current object
    /// </summary>
    /// <param name="writer">Serialization writer to use to serialize this model</param>
    public void Serialize(ISerializationWriter writer)
    {
        _ = writer ?? throw new ArgumentNullException(nameof(writer));
        writer.WriteStringValue("boot_args", this.BootArgs);
        writer.WriteStringValue("initrd_path", this.InitrdPath);
        writer.WriteStringValue("kernel_image_path", this.KernelImagePath);
        writer.WriteAdditionalData(this.AdditionalData);
    }
}