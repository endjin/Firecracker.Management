using Microsoft.Kiota.Abstractions.Serialization;

namespace Firecracker.Management.Models;

/// <summary>
/// Defines a partial network interface structure, used to update the rate limiters for that interface, after microvm start.
/// </summary>
public class PartialNetworkInterface : IAdditionalDataHolder, IParsable
{
    /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
    public IDictionary<string, object> AdditionalData { get; set; }

    /// <summary>The iface_id property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public string? IfaceId { get; set; }
#nullable restore
#else
        public string IfaceId { get; set; }
#endif
    /// <summary>Defines an IO rate limiter with independent bytes/s and ops/s limits. Limits are defined by configuring each of the _bandwidth_ and _ops_ token buckets.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public RateLimiter? RxRateLimiter { get; set; }
#nullable restore
#else
        public RateLimiter RxRateLimiter { get; set; }
#endif
    /// <summary>Defines an IO rate limiter with independent bytes/s and ops/s limits. Limits are defined by configuring each of the _bandwidth_ and _ops_ token buckets.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public RateLimiter? TxRateLimiter { get; set; }
#nullable restore
#else
        public RateLimiter TxRateLimiter { get; set; }
#endif
    /// <summary>
    /// Instantiates a new PartialNetworkInterface and sets the default values.
    /// </summary>
    public PartialNetworkInterface()
    {
        this.AdditionalData = new Dictionary<string, object>();
    }

    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static PartialNetworkInterface CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new PartialNetworkInterface();
    }

    /// <summary>
    /// The deserialization information for the current model
    /// </summary>
    public IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
    {
        return new Dictionary<string, Action<IParseNode>>
        {
            { "iface_id", n => { this.IfaceId = n.GetStringValue(); } },
            {
                "rx_rate_limiter",
                n => { this.RxRateLimiter = n.GetObjectValue<RateLimiter>(RateLimiter.CreateFromDiscriminatorValue); }
            },
            {
                "tx_rate_limiter",
                n => { this.TxRateLimiter = n.GetObjectValue<RateLimiter>(RateLimiter.CreateFromDiscriminatorValue); }
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
        writer.WriteStringValue("iface_id", this.IfaceId);
        writer.WriteObjectValue<RateLimiter>("rx_rate_limiter", this.RxRateLimiter);
        writer.WriteObjectValue<RateLimiter>("tx_rate_limiter", this.TxRateLimiter);
        writer.WriteAdditionalData(this.AdditionalData);
    }
}