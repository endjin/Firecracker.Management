// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Firecracker.Management.Models {
    /// <summary>
    /// Defines a network interface.
    /// </summary>
    public class NetworkInterface : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The guest_mac property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? GuestMac { get; set; }
#nullable restore
#else
        public string GuestMac { get; set; }
#endif
        /// <summary>Host level path for the guest network interface</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? HostDevName { get; set; }
#nullable restore
#else
        public string HostDevName { get; set; }
#endif
        /// <summary>The iface_id property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? IfaceId { get; set; }
#nullable restore
#else
        public string IfaceId { get; set; }
#endif
        /// <summary>Defines an IO rate limiter with independent bytes/s and ops/s limits. Limits are defined by configuring each of the _bandwidth_ and _ops_ token buckets. This field is optional for virtio-block config and should be omitted for vhost-user-block configuration.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RateLimiter? RxRateLimiter { get; set; }
#nullable restore
#else
        public RateLimiter RxRateLimiter { get; set; }
#endif
        /// <summary>Defines an IO rate limiter with independent bytes/s and ops/s limits. Limits are defined by configuring each of the _bandwidth_ and _ops_ token buckets. This field is optional for virtio-block config and should be omitted for vhost-user-block configuration.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RateLimiter? TxRateLimiter { get; set; }
#nullable restore
#else
        public RateLimiter TxRateLimiter { get; set; }
#endif
        /// <summary>
        /// Instantiates a new NetworkInterface and sets the default values.
        /// </summary>
        public NetworkInterface() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static NetworkInterface CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new NetworkInterface();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"guest_mac", n => { GuestMac = n.GetStringValue(); } },
                {"host_dev_name", n => { HostDevName = n.GetStringValue(); } },
                {"iface_id", n => { IfaceId = n.GetStringValue(); } },
                {"rx_rate_limiter", n => { RxRateLimiter = n.GetObjectValue<RateLimiter>(RateLimiter.CreateFromDiscriminatorValue); } },
                {"tx_rate_limiter", n => { TxRateLimiter = n.GetObjectValue<RateLimiter>(RateLimiter.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("guest_mac", GuestMac);
            writer.WriteStringValue("host_dev_name", HostDevName);
            writer.WriteStringValue("iface_id", IfaceId);
            writer.WriteObjectValue<RateLimiter>("rx_rate_limiter", RxRateLimiter);
            writer.WriteObjectValue<RateLimiter>("tx_rate_limiter", TxRateLimiter);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
