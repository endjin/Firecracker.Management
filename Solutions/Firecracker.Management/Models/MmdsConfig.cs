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
    /// Defines the MMDS configuration.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class MmdsConfig : IAdditionalDataHolder, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>A valid IPv4 link-local address.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Ipv4Address { get; set; }
#nullable restore
#else
        public string Ipv4Address { get; set; }
#endif
        /// <summary>List of the network interface IDs capable of forwarding packets to the MMDS. Network interface IDs mentioned must be valid at the time of this request. The net device model will reply to HTTP GET requests sent to the MMDS address via the interfaces mentioned. In this case, both ARP requests and TCP segments heading to `ipv4_address` are intercepted by the device model, and do not reach the associated TAP device.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? NetworkInterfaces { get; set; }
#nullable restore
#else
        public List<string> NetworkInterfaces { get; set; }
#endif
        /// <summary>Enumeration indicating the MMDS version to be configured.</summary>
        public global::Firecracker.Management.Models.MmdsConfig_version? Version { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::Firecracker.Management.Models.MmdsConfig"/> and sets the default values.
        /// </summary>
        public MmdsConfig()
        {
            AdditionalData = new Dictionary<string, object>();
            Ipv4Address = "169.254.169.254";
            Version = global::Firecracker.Management.Models.MmdsConfig_version.V1;
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Firecracker.Management.Models.MmdsConfig"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Firecracker.Management.Models.MmdsConfig CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Firecracker.Management.Models.MmdsConfig();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "ipv4_address", n => { Ipv4Address = n.GetStringValue(); } },
                { "network_interfaces", n => { NetworkInterfaces = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "version", n => { Version = n.GetEnumValue<global::Firecracker.Management.Models.MmdsConfig_version>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("ipv4_address", Ipv4Address);
            writer.WriteCollectionOfPrimitiveValues<string>("network_interfaces", NetworkInterfaces);
            writer.WriteEnumValue<global::Firecracker.Management.Models.MmdsConfig_version>("version", Version);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
