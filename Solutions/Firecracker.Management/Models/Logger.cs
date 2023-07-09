using Microsoft.Kiota.Abstractions.Serialization;

namespace Firecracker.Management.Models;

/// <summary>
/// Describes the configuration option for the logging capability.
/// </summary>
public class Logger : IAdditionalDataHolder, IParsable
{
    /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
    public IDictionary<string, object> AdditionalData { get; set; }

    /// <summary>Set the level. The possible values are case-insensitive.</summary>
    public Logger_level? Level { get; set; }

    /// <summary>Path to the named pipe or file for the human readable log output.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public string? LogPath { get; set; }
#nullable restore
#else
        public string LogPath { get; set; }
#endif
    /// <summary>Whether or not to output the level in the logs.</summary>
    public bool? ShowLevel { get; set; }

    /// <summary>Whether or not to include the file path and line number of the log&apos;s origin.</summary>
    public bool? ShowLogOrigin { get; set; }

    /// <summary>
    /// Instantiates a new Logger and sets the default values.
    /// </summary>
    public Logger()
    {
        this.AdditionalData = new Dictionary<string, object>();
        this.Level = Logger_level.Warning;
    }

    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static Logger CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new Logger();
    }

    /// <summary>
    /// The deserialization information for the current model
    /// </summary>
    public IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
    {
        return new Dictionary<string, Action<IParseNode>>
        {
            { "level", n => { this.Level = n.GetEnumValue<Logger_level>(); } },
            { "log_path", n => { this.LogPath = n.GetStringValue(); } },
            { "show_level", n => { this.ShowLevel = n.GetBoolValue(); } },
            { "show_log_origin", n => { this.ShowLogOrigin = n.GetBoolValue(); } },
        };
    }

    /// <summary>
    /// Serializes information the current object
    /// </summary>
    /// <param name="writer">Serialization writer to use to serialize this model</param>
    public void Serialize(ISerializationWriter writer)
    {
        _ = writer ?? throw new ArgumentNullException(nameof(writer));
        writer.WriteEnumValue<Logger_level>("level", this.Level);
        writer.WriteStringValue("log_path", this.LogPath);
        writer.WriteBoolValue("show_level", this.ShowLevel);
        writer.WriteBoolValue("show_log_origin", this.ShowLogOrigin);
        writer.WriteAdditionalData(this.AdditionalData);
    }
}