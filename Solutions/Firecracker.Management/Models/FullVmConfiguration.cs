using Microsoft.Kiota.Abstractions.Serialization;

namespace Firecracker.Management.Models;

public class FullVmConfiguration : IAdditionalDataHolder, IParsable
{
    /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
    public IDictionary<string, object> AdditionalData { get; set; }

    /// <summary>Balloon device descriptor.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public Balloon? Balloon { get; set; }
#nullable restore
#else
        public Firecracker.Client.Models.Balloon Balloon { get; set; }
#endif
    /// <summary>Boot source descriptor.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public BootSource? BootSource { get; set; }
#nullable restore
#else
        public Firecracker.Client.Models.BootSource BootSource { get; set; }
#endif
    /// <summary>Configurations for all block devices.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public List<Drive>? Drives { get; set; }
#nullable restore
#else
        public List<Drive> Drives { get; set; }
#endif
    /// <summary>Describes the configuration option for the logging capability.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public Logger? Logger { get; set; }
#nullable restore
#else
        public Firecracker.Client.Models.Logger Logger { get; set; }
#endif
    /// <summary>Describes the number of vCPUs, memory size, SMT capabilities and the CPU template.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public MachineConfiguration? MachineConfig { get; set; }
#nullable restore
#else
        public MachineConfiguration MachineConfig { get; set; }
#endif
    /// <summary>Describes the configuration option for the metrics capability.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public Metrics? Metrics { get; set; }
#nullable restore
#else
        public Firecracker.Client.Models.Metrics Metrics { get; set; }
#endif
    /// <summary>Defines the MMDS configuration.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public MmdsConfig? MmdsConfig { get; set; }
#nullable restore
#else
        public Firecracker.Client.Models.MmdsConfig MmdsConfig { get; set; }
#endif
    /// <summary>Configurations for all net devices.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public List<NetworkInterface>? NetworkInterfaces { get; set; }
#nullable restore
#else
        public List<NetworkInterface> NetworkInterfaces { get; set; }
#endif
    /// <summary>Defines a vsock device, backed by a set of Unix Domain Sockets, on the host side. For host-initiated connections, Firecracker will be listening on the Unix socket identified by the path `uds_path`. Firecracker will create this socket, bind and listen on it. Host-initiated connections will be performed by connection to this socket and issuing a connection forwarding request to the desired guest-side vsock port (i.e. `CONNECT 52\n`, to connect to port 52). For guest-initiated connections, Firecracker will expect host software to be bound and listening on Unix sockets at `uds_path_&lt;PORT&gt;`. E.g. &quot;/path/to/host_vsock.sock_52&quot; for port number 52.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public Vsock? Vsock { get; set; }
#nullable restore
#else
        public Firecracker.Client.Models.Vsock Vsock { get; set; }
#endif
    /// <summary>
    /// Instantiates a new FullVmConfiguration and sets the default values.
    /// </summary>
    public FullVmConfiguration()
    {
        this.AdditionalData = new Dictionary<string, object>();
    }

    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static FullVmConfiguration CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new FullVmConfiguration();
    }

    /// <summary>
    /// The deserialization information for the current model
    /// </summary>
    public IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
    {
        return new Dictionary<string, Action<IParseNode>>
        {
            { "balloon", n => { this.Balloon = n.GetObjectValue<Balloon>(Balloon.CreateFromDiscriminatorValue); } },
            {
                "boot-source",
                n => { this.BootSource = n.GetObjectValue<BootSource>(BootSource.CreateFromDiscriminatorValue); }
            },
            {
                "drives",
                n =>
                {
                    this.Drives = n.GetCollectionOfObjectValues<Drive>(Drive.CreateFromDiscriminatorValue)?.ToList();
                }
            },
            { "logger", n => { this.Logger = n.GetObjectValue<Logger>(Logger.CreateFromDiscriminatorValue); } },
            {
                "machine-config",
                n =>
                {
                    this.MachineConfig =
                        n.GetObjectValue<MachineConfiguration>(MachineConfiguration.CreateFromDiscriminatorValue);
                }
            },
            { "metrics", n => { this.Metrics = n.GetObjectValue<Metrics>(Metrics.CreateFromDiscriminatorValue); } },
            {
                "mmds-config",
                n => { this.MmdsConfig = n.GetObjectValue<MmdsConfig>(MmdsConfig.CreateFromDiscriminatorValue); }
            },
            {
                "network-interfaces",
                n =>
                {
                    this.NetworkInterfaces =
                        n.GetCollectionOfObjectValues<NetworkInterface>(NetworkInterface
                            .CreateFromDiscriminatorValue)?.ToList();
                }
            },
            { "vsock", n => { this.Vsock = n.GetObjectValue<Vsock>(Vsock.CreateFromDiscriminatorValue); } },
        };
    }

    /// <summary>
    /// Serializes information the current object
    /// </summary>
    /// <param name="writer">Serialization writer to use to serialize this model</param>
    public void Serialize(ISerializationWriter writer)
    {
        _ = writer ?? throw new ArgumentNullException(nameof(writer));
        writer.WriteObjectValue<Balloon>("balloon", this.Balloon);
        writer.WriteObjectValue<BootSource>("boot-source", this.BootSource);
        writer.WriteCollectionOfObjectValues<Drive>("drives", this.Drives);
        writer.WriteObjectValue<Logger>("logger", this.Logger);
        writer.WriteObjectValue<MachineConfiguration>("machine-config", this.MachineConfig);
        writer.WriteObjectValue<Metrics>("metrics", this.Metrics);
        writer.WriteObjectValue<MmdsConfig>("mmds-config", this.MmdsConfig);
        writer.WriteCollectionOfObjectValues<NetworkInterface>("network-interfaces", this.NetworkInterfaces);
        writer.WriteObjectValue<Vsock>("vsock", this.Vsock);
        writer.WriteAdditionalData(this.AdditionalData);
    }
}