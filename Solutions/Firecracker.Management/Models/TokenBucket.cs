using Microsoft.Kiota.Abstractions.Serialization;

namespace Firecracker.Management.Models;

/// <summary>
/// Defines a token bucket with a maximum capacity (size), an initial burst size (one_time_burst) and an interval for refilling purposes (refill_time). The refill-rate is derived from size and refill_time, and it is the constant rate at which the tokens replenish. The refill process only starts happening after the initial burst budget is consumed. Consumption from the token bucket is unbounded in speed which allows for bursts bound in size by the amount of tokens available. Once the token bucket is empty, consumption speed is bound by the refill_rate.
/// </summary>
public class TokenBucket : IAdditionalDataHolder, IParsable
{
    /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
    public IDictionary<string, object> AdditionalData { get; set; }

    /// <summary>The initial size of a token bucket.</summary>
    public long? OneTimeBurst { get; set; }

    /// <summary>The amount of milliseconds it takes for the bucket to refill.</summary>
    public long? RefillTime { get; set; }

    /// <summary>The total number of tokens this bucket can hold.</summary>
    public long? Size { get; set; }

    /// <summary>
    /// Instantiates a new TokenBucket and sets the default values.
    /// </summary>
    public TokenBucket()
    {
        this.AdditionalData = new Dictionary<string, object>();
    }

    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static TokenBucket CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new TokenBucket();
    }

    /// <summary>
    /// The deserialization information for the current model
    /// </summary>
    public IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
    {
        return new Dictionary<string, Action<IParseNode>>
        {
            { "one_time_burst", n => { this.OneTimeBurst = n.GetLongValue(); } },
            { "refill_time", n => { this.RefillTime = n.GetLongValue(); } },
            { "size", n => { this.Size = n.GetLongValue(); } },
        };
    }

    /// <summary>
    /// Serializes information the current object
    /// </summary>
    /// <param name="writer">Serialization writer to use to serialize this model</param>
    public void Serialize(ISerializationWriter writer)
    {
        _ = writer ?? throw new ArgumentNullException(nameof(writer));
        writer.WriteLongValue("one_time_burst", this.OneTimeBurst);
        writer.WriteLongValue("refill_time", this.RefillTime);
        writer.WriteLongValue("size", this.Size);
        writer.WriteAdditionalData(this.AdditionalData);
    }
}