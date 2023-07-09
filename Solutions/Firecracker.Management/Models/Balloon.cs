using Microsoft.Kiota.Abstractions.Serialization;

namespace Firecracker.Management.Models;

/// <summary>
/// Balloon device descriptor.
/// </summary>
public class Balloon : IAdditionalDataHolder, IParsable
{
    /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
    public IDictionary<string, object> AdditionalData { get; set; }

    /// <summary>Target balloon size in MiB.</summary>
    public int? AmountMib { get; set; }

    /// <summary>Whether the balloon should deflate when the guest has memory pressure.</summary>
    public bool? DeflateOnOom { get; set; }

    /// <summary>Interval in seconds between refreshing statistics. A non-zero value will enable the statistics. Defaults to 0.</summary>
    public int? StatsPollingIntervalS { get; set; }

    /// <summary>
    /// Instantiates a new Balloon and sets the default values.
    /// </summary>
    public Balloon()
    {
        this.AdditionalData = new Dictionary<string, object>();
    }

    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static Balloon CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new Balloon();
    }

    /// <summary>
    /// The deserialization information for the current model
    /// </summary>
    public IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
    {
        return new Dictionary<string, Action<IParseNode>>
        {
            { "amount_mib", n => { this.AmountMib = n.GetIntValue(); } },
            { "deflate_on_oom", n => { this.DeflateOnOom = n.GetBoolValue(); } },
            { "stats_polling_interval_s", n => { this.StatsPollingIntervalS = n.GetIntValue(); } },
        };
    }

    /// <summary>
    /// Serializes information the current object
    /// </summary>
    /// <param name="writer">Serialization writer to use to serialize this model</param>
    public void Serialize(ISerializationWriter writer)
    {
        _ = writer ?? throw new ArgumentNullException(nameof(writer));
        writer.WriteIntValue("amount_mib", this.AmountMib);
        writer.WriteBoolValue("deflate_on_oom", this.DeflateOnOom);
        writer.WriteIntValue("stats_polling_interval_s", this.StatsPollingIntervalS);
        writer.WriteAdditionalData(this.AdditionalData);
    }
}