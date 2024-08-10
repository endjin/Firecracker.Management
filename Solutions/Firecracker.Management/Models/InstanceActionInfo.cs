// <auto-generated/>
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Firecracker.Management.Models
{
    /// <summary>
    /// Variant wrapper containing the real action.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.17.0")]
    public partial class InstanceActionInfo : IAdditionalDataHolder, IParsable
    {
        /// <summary>Enumeration indicating what type of action is contained in the payload</summary>
        public global::Firecracker.Management.Models.InstanceActionInfo_action_type? ActionType { get; set; }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::Firecracker.Management.Models.InstanceActionInfo"/> and sets the default values.
        /// </summary>
        public InstanceActionInfo()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Firecracker.Management.Models.InstanceActionInfo"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Firecracker.Management.Models.InstanceActionInfo CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Firecracker.Management.Models.InstanceActionInfo();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "action_type", n => { ActionType = n.GetEnumValue<global::Firecracker.Management.Models.InstanceActionInfo_action_type>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<global::Firecracker.Management.Models.InstanceActionInfo_action_type>("action_type", ActionType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
