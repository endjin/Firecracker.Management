// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Firecracker.Management.Models
{
    /// <summary>
    /// Describes the configuration option for the logging capability.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class Logger : IAdditionalDataHolder, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Set the level. The possible values are case-insensitive.</summary>
        public global::Firecracker.Management.Models.Logger_level? Level { get; set; }
        /// <summary>Path to the named pipe or file for the human readable log output.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LogPath { get; set; }
#nullable restore
#else
        public string LogPath { get; set; }
#endif
        /// <summary>The module path to filter log messages by.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Module { get; set; }
#nullable restore
#else
        public string Module { get; set; }
#endif
        /// <summary>Whether or not to output the level in the logs.</summary>
        public bool? ShowLevel { get; set; }
        /// <summary>Whether or not to include the file path and line number of the log&apos;s origin.</summary>
        public bool? ShowLogOrigin { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::Firecracker.Management.Models.Logger"/> and sets the default values.
        /// </summary>
        public Logger()
        {
            AdditionalData = new Dictionary<string, object>();
            Level = global::Firecracker.Management.Models.Logger_level.Info;
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Firecracker.Management.Models.Logger"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Firecracker.Management.Models.Logger CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Firecracker.Management.Models.Logger();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "level", n => { Level = n.GetEnumValue<global::Firecracker.Management.Models.Logger_level>(); } },
                { "log_path", n => { LogPath = n.GetStringValue(); } },
                { "module", n => { Module = n.GetStringValue(); } },
                { "show_level", n => { ShowLevel = n.GetBoolValue(); } },
                { "show_log_origin", n => { ShowLogOrigin = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<global::Firecracker.Management.Models.Logger_level>("level", Level);
            writer.WriteStringValue("log_path", LogPath);
            writer.WriteStringValue("module", Module);
            writer.WriteBoolValue("show_level", ShowLevel);
            writer.WriteBoolValue("show_log_origin", ShowLogOrigin);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
