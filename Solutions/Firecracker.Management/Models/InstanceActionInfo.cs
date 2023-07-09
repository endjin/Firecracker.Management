using Microsoft.Kiota.Abstractions.Serialization;

namespace Firecracker.Management.Models;

/// <summary>
/// Variant wrapper containing the real action.
/// </summary>
public class InstanceActionInfo : IAdditionalDataHolder, IParsable
{
    /// <summary>Enumeration indicating what type of action is contained in the payload</summary>
    public InstanceActionInfo_action_type? ActionType { get; set; }

    /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
    public IDictionary<string, object> AdditionalData { get; set; }

    /// <summary>
    /// Instantiates a new InstanceActionInfo and sets the default values.
    /// </summary>
    public InstanceActionInfo()
    {
        this.AdditionalData = new Dictionary<string, object>();
    }

    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static InstanceActionInfo CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new InstanceActionInfo();
    }

    /// <summary>
    /// The deserialization information for the current model
    /// </summary>
    public IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
    {
        return new Dictionary<string, Action<IParseNode>>
        {
            { "action_type", n => { this.ActionType = n.GetEnumValue<InstanceActionInfo_action_type>(); } },
        };
    }

    /// <summary>
    /// Serializes information the current object
    /// </summary>
    /// <param name="writer">Serialization writer to use to serialize this model</param>
    public void Serialize(ISerializationWriter writer)
    {
        _ = writer ?? throw new ArgumentNullException(nameof(writer));
        writer.WriteEnumValue<InstanceActionInfo_action_type>("action_type", this.ActionType);
        writer.WriteAdditionalData(this.AdditionalData);
    }
}