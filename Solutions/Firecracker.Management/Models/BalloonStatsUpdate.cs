using Microsoft.Kiota.Abstractions.Serialization;

namespace Firecracker.Management.Models;

/// <summary>
/// Update the statistics polling interval, with the first statistics update scheduled immediately. Statistics cannot be turned on/off after boot.
/// </summary>
public class BalloonStatsUpdate : IAdditionalDataHolder, IParsable
{
    /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
    public IDictionary<string, object> AdditionalData { get; set; }

    /// <summary>Interval in seconds between refreshing statistics.</summary>
    public int? StatsPollingIntervalS { get; set; }

    /// <summary>
    /// Instantiates a new BalloonStatsUpdate and sets the default values.
    /// </summary>
    public BalloonStatsUpdate()
    {
        this.AdditionalData = new Dictionary<string, object>();
    }

    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static BalloonStatsUpdate CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new BalloonStatsUpdate();
    }

    /// <summary>
    /// The deserialization information for the current model
    /// </summary>
    public IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
    {
        return new Dictionary<string, Action<IParseNode>>
        {
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
        writer.WriteIntValue("stats_polling_interval_s", this.StatsPollingIntervalS);
        writer.WriteAdditionalData(this.AdditionalData);
    }
}