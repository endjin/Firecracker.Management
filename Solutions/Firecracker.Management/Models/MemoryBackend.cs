using Microsoft.Kiota.Abstractions.Serialization;

namespace Firecracker.Management.Models;

public class MemoryBackend : IAdditionalDataHolder, IParsable
{
    /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
    public IDictionary<string, object> AdditionalData { get; set; }

    /// <summary>Based on &apos;backend_type&apos; it is either 1) Path to the file that contains the guest memory to be loaded 2) Path to the UDS where a process is listening for a UFFD initialization control payload and open file descriptor that it can use to serve this process&apos;s guest memory page faults</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public string? BackendPath { get; set; }
#nullable restore
#else
        public string BackendPath { get; set; }
#endif
    /// <summary>The backend_type property</summary>
    public MemoryBackend_backend_type? BackendType { get; set; }

    /// <summary>
    /// Instantiates a new MemoryBackend and sets the default values.
    /// </summary>
    public MemoryBackend()
    {
        this.AdditionalData = new Dictionary<string, object>();
    }

    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static MemoryBackend CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new MemoryBackend();
    }

    /// <summary>
    /// The deserialization information for the current model
    /// </summary>
    public IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
    {
        return new Dictionary<string, Action<IParseNode>>
        {
            { "backend_path", n => { this.BackendPath = n.GetStringValue(); } },
            { "backend_type", n => { this.BackendType = n.GetEnumValue<MemoryBackend_backend_type>(); } },
        };
    }

    /// <summary>
    /// Serializes information the current object
    /// </summary>
    /// <param name="writer">Serialization writer to use to serialize this model</param>
    public void Serialize(ISerializationWriter writer)
    {
        _ = writer ?? throw new ArgumentNullException(nameof(writer));
        writer.WriteStringValue("backend_path", this.BackendPath);
        writer.WriteEnumValue<MemoryBackend_backend_type>("backend_type", this.BackendType);
        writer.WriteAdditionalData(this.AdditionalData);
    }
}