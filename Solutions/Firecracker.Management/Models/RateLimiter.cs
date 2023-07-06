using Microsoft.Kiota.Abstractions.Serialization;

namespace Firecracker.Management.Models;

/// <summary>
/// Defines an IO rate limiter with independent bytes/s and ops/s limits. Limits are defined by configuring each of the _bandwidth_ and _ops_ token buckets.
/// </summary>
public class RateLimiter : IAdditionalDataHolder, IParsable
{
    /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
    public IDictionary<string, object> AdditionalData { get; set; }

    /// <summary>Defines a token bucket with a maximum capacity (size), an initial burst size (one_time_burst) and an interval for refilling purposes (refill_time). The refill-rate is derived from size and refill_time, and it is the constant rate at which the tokens replenish. The refill process only starts happening after the initial burst budget is consumed. Consumption from the token bucket is unbounded in speed which allows for bursts bound in size by the amount of tokens available. Once the token bucket is empty, consumption speed is bound by the refill_rate.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public TokenBucket? Bandwidth { get; set; }
#nullable restore
#else
        public TokenBucket Bandwidth { get; set; }
#endif
    /// <summary>Defines a token bucket with a maximum capacity (size), an initial burst size (one_time_burst) and an interval for refilling purposes (refill_time). The refill-rate is derived from size and refill_time, and it is the constant rate at which the tokens replenish. The refill process only starts happening after the initial burst budget is consumed. Consumption from the token bucket is unbounded in speed which allows for bursts bound in size by the amount of tokens available. Once the token bucket is empty, consumption speed is bound by the refill_rate.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public TokenBucket? Ops { get; set; }
#nullable restore
#else
        public TokenBucket Ops { get; set; }
#endif
    /// <summary>
    /// Instantiates a new RateLimiter and sets the default values.
    /// </summary>
    public RateLimiter()
    {
        this.AdditionalData = new Dictionary<string, object>();
    }

    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static RateLimiter CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new RateLimiter();
    }

    /// <summary>
    /// The deserialization information for the current model
    /// </summary>
    public IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
    {
        return new Dictionary<string, Action<IParseNode>>
        {
            {
                "bandwidth",
                n => { this.Bandwidth = n.GetObjectValue<TokenBucket>(TokenBucket.CreateFromDiscriminatorValue); }
            },
            { "ops", n => { this.Ops = n.GetObjectValue<TokenBucket>(TokenBucket.CreateFromDiscriminatorValue); } },
        };
    }

    /// <summary>
    /// Serializes information the current object
    /// </summary>
    /// <param name="writer">Serialization writer to use to serialize this model</param>
    public void Serialize(ISerializationWriter writer)
    {
        _ = writer ?? throw new ArgumentNullException(nameof(writer));
        writer.WriteObjectValue<TokenBucket>("bandwidth", this.Bandwidth);
        writer.WriteObjectValue<TokenBucket>("ops", this.Ops);
        writer.WriteAdditionalData(this.AdditionalData);
    }
}