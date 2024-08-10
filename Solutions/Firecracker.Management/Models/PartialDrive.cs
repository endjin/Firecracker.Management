// <auto-generated/>
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Firecracker.Management.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.17.0")]
    #pragma warning disable CS1591
    public partial class PartialDrive : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The drive_id property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DriveId { get; set; }
#nullable restore
#else
        public string DriveId { get; set; }
#endif
        /// <summary>Host level path for the guest drive. This field is optional for virtio-block config and should be omitted for vhost-user-block configuration.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PathOnHost { get; set; }
#nullable restore
#else
        public string PathOnHost { get; set; }
#endif
        /// <summary>Defines an IO rate limiter with independent bytes/s and ops/s limits. Limits are defined by configuring each of the _bandwidth_ and _ops_ token buckets. This field is optional for virtio-block config and should be omitted for vhost-user-block configuration.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Firecracker.Management.Models.RateLimiter? RateLimiter { get; set; }
#nullable restore
#else
        public global::Firecracker.Management.Models.RateLimiter RateLimiter { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Firecracker.Management.Models.PartialDrive"/> and sets the default values.
        /// </summary>
        public PartialDrive()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Firecracker.Management.Models.PartialDrive"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Firecracker.Management.Models.PartialDrive CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Firecracker.Management.Models.PartialDrive();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "drive_id", n => { DriveId = n.GetStringValue(); } },
                { "path_on_host", n => { PathOnHost = n.GetStringValue(); } },
                { "rate_limiter", n => { RateLimiter = n.GetObjectValue<global::Firecracker.Management.Models.RateLimiter>(global::Firecracker.Management.Models.RateLimiter.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("drive_id", DriveId);
            writer.WriteStringValue("path_on_host", PathOnHost);
            writer.WriteObjectValue<global::Firecracker.Management.Models.RateLimiter>("rate_limiter", RateLimiter);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
