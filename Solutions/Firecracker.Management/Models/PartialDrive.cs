using Microsoft.Kiota.Abstractions.Serialization;

namespace Firecracker.Management.Models;

public class PartialDrive : IAdditionalDataHolder, IParsable
{
    /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
    public IDictionary<string, object> AdditionalData { get; set; }

    /// <summary>The drive_id property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public string? DriveId { get; set; }
#nullable restore
#else
        public string DriveId { get; set; }
#endif
    /// <summary>Host level path for the guest drive</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public string? PathOnHost { get; set; }
#nullable restore
#else
        public string PathOnHost { get; set; }
#endif
    /// <summary>Defines an IO rate limiter with independent bytes/s and ops/s limits. Limits are defined by configuring each of the _bandwidth_ and _ops_ token buckets.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public RateLimiter? RateLimiter { get; set; }
#nullable restore
#else
        public Firecracker.Client.Models.RateLimiter RateLimiter { get; set; }
#endif
    /// <summary>
    /// Instantiates a new PartialDrive and sets the default values.
    /// </summary>
    public PartialDrive()
    {
        this.AdditionalData = new Dictionary<string, object>();
    }

    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static PartialDrive CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new PartialDrive();
    }

    /// <summary>
    /// The deserialization information for the current model
    /// </summary>
    public IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
    {
        return new Dictionary<string, Action<IParseNode>>
        {
            { "drive_id", n => { this.DriveId = n.GetStringValue(); } },
            { "path_on_host", n => { this.PathOnHost = n.GetStringValue(); } },
            {
                "rate_limiter",
                n => { this.RateLimiter = n.GetObjectValue<RateLimiter>(RateLimiter.CreateFromDiscriminatorValue); }
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
        writer.WriteStringValue("drive_id", this.DriveId);
        writer.WriteStringValue("path_on_host", this.PathOnHost);
        writer.WriteObjectValue<RateLimiter>("rate_limiter", this.RateLimiter);
        writer.WriteAdditionalData(this.AdditionalData);
    }
}