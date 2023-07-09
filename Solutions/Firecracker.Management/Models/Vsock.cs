using Microsoft.Kiota.Abstractions.Serialization;

namespace Firecracker.Management.Models;

/// <summary>
/// Defines a vsock device, backed by a set of Unix Domain Sockets, on the host side. For host-initiated connections, Firecracker will be listening on the Unix socket identified by the path `uds_path`. Firecracker will create this socket, bind and listen on it. Host-initiated connections will be performed by connection to this socket and issuing a connection forwarding request to the desired guest-side vsock port (i.e. `CONNECT 52\n`, to connect to port 52). For guest-initiated connections, Firecracker will expect host software to be bound and listening on Unix sockets at `uds_path_&lt;PORT&gt;`. E.g. &quot;/path/to/host_vsock.sock_52&quot; for port number 52.
/// </summary>
public class Vsock : IAdditionalDataHolder, IParsable
{
    /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
    public IDictionary<string, object> AdditionalData { get; set; }

    /// <summary>Guest Vsock CID</summary>
    public int? GuestCid { get; set; }

    /// <summary>Path to UNIX domain socket, used to proxy vsock connections.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public string? UdsPath { get; set; }
#nullable restore
#else
        public string UdsPath { get; set; }
#endif
    /// <summary>This parameter has been deprecated since v1.0.0.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public string? VsockId { get; set; }
#nullable restore
#else
        public string VsockId { get; set; }
#endif
    /// <summary>
    /// Instantiates a new Vsock and sets the default values.
    /// </summary>
    public Vsock()
    {
        this.AdditionalData = new Dictionary<string, object>();
    }

    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static Vsock CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new Vsock();
    }

    /// <summary>
    /// The deserialization information for the current model
    /// </summary>
    public IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
    {
        return new Dictionary<string, Action<IParseNode>>
        {
            { "guest_cid", n => { this.GuestCid = n.GetIntValue(); } },
            { "uds_path", n => { this.UdsPath = n.GetStringValue(); } },
            { "vsock_id", n => { this.VsockId = n.GetStringValue(); } },
        };
    }

    /// <summary>
    /// Serializes information the current object
    /// </summary>
    /// <param name="writer">Serialization writer to use to serialize this model</param>
    public void Serialize(ISerializationWriter writer)
    {
        _ = writer ?? throw new ArgumentNullException(nameof(writer));
        writer.WriteIntValue("guest_cid", this.GuestCid);
        writer.WriteStringValue("uds_path", this.UdsPath);
        writer.WriteStringValue("vsock_id", this.VsockId);
        writer.WriteAdditionalData(this.AdditionalData);
    }
}