using Microsoft.Kiota.Abstractions.Serialization;

namespace Firecracker.Management.Models;

public class Drive : IAdditionalDataHolder, IParsable
{
    /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
    public IDictionary<string, object> AdditionalData { get; set; }

    /// <summary>Represents the caching strategy for the block device.</summary>
    public Drive_cache_type? CacheType { get; set; }

    /// <summary>The drive_id property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public string? DriveId { get; set; }
#nullable restore
#else
        public string DriveId { get; set; }
#endif
    /// <summary>Type of the IO engine used by the device. &quot;Async&quot; is supported on host kernels newer than 5.10.51.</summary>
    public Drive_io_engine? IoEngine { get; set; }

    /// <summary>The is_read_only property</summary>
    public bool? IsReadOnly { get; set; }

    /// <summary>The is_root_device property</summary>
    public bool? IsRootDevice { get; set; }

    /// <summary>Represents the unique id of the boot partition of this device. It is optional and it will be taken into account only if the is_root_device field is true.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public string? Partuuid { get; set; }
#nullable restore
#else
        public string Partuuid { get; set; }
#endif
    /// <summary>Host level path for the guest drive</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public string? PathOnHost { get; set; }
#nullable restore
#else
        public string PathOnHost { get; set; }
#endif
    /// <summary>Defines an IO rate limiter with independent bytes/s and ops/s limits. Limits are defined by configuring each of the _bandwidth_ and _ops_ token buckets.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public RateLimiter? RateLimiter { get; set; }
#nullable restore
#else
        public Firecracker.Client.Models.RateLimiter RateLimiter { get; set; }
#endif
    /// <summary>
    /// Instantiates a new Drive and sets the default values.
    /// </summary>
    public Drive()
    {
        this.AdditionalData = new Dictionary<string, object>();
        this.CacheType = Drive_cache_type.Unsafe;
        this.IoEngine = Drive_io_engine.Sync;
    }

    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static Drive CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new Drive();
    }

    /// <summary>
    /// The deserialization information for the current model
    /// </summary>
    public IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
    {
        return new Dictionary<string, Action<IParseNode>>
        {
            { "cache_type", n => { this.CacheType = n.GetEnumValue<Drive_cache_type>(); } },
            { "drive_id", n => { this.DriveId = n.GetStringValue(); } },
            { "io_engine", n => { this.IoEngine = n.GetEnumValue<Drive_io_engine>(); } },
            { "is_read_only", n => { this.IsReadOnly = n.GetBoolValue(); } },
            { "is_root_device", n => { this.IsRootDevice = n.GetBoolValue(); } },
            { "partuuid", n => { this.Partuuid = n.GetStringValue(); } },
            { "path_on_host", n => { this.PathOnHost = n.GetStringValue(); } },
            {
                "rate_limiter",
                n => { this.RateLimiter = n.GetObjectValue<RateLimiter>(RateLimiter.CreateFromDiscriminatorValue); }
            },
        };
    }

    /// <summary>
    /// Serializes information the current object
    /// </summary>
    /// <param name="writer">Serialization writer to use to serialize this model</param>
    public void Serialize(ISerializationWriter writer)
    {
        _ = writer ?? throw new ArgumentNullException(nameof(writer));
        writer.WriteEnumValue<Drive_cache_type>("cache_type", this.CacheType);
        writer.WriteStringValue("drive_id", this.DriveId);
        writer.WriteEnumValue<Drive_io_engine>("io_engine", this.IoEngine);
        writer.WriteBoolValue("is_read_only", this.IsReadOnly);
        writer.WriteBoolValue("is_root_device", this.IsRootDevice);
        writer.WriteStringValue("partuuid", this.Partuuid);
        writer.WriteStringValue("path_on_host", this.PathOnHost);
        writer.WriteObjectValue<RateLimiter>("rate_limiter", this.RateLimiter);
        writer.WriteAdditionalData(this.AdditionalData);
    }
}