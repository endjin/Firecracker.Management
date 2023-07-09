using Firecracker.Management.NetworkInterfaces.Item;
using Microsoft.Kiota.Abstractions;

namespace Firecracker.Management.NetworkInterfaces;

/// <summary>
/// Builds and executes requests for operations under \network-interfaces
/// </summary>
public class NetworkInterfacesRequestBuilder : BaseRequestBuilder
{
    /// <summary>
    /// Instantiates a new NetworkInterfacesRequestBuilder and sets the default values.
    /// </summary>
    /// <param name="pathParameters">Path parameters for the request</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public NetworkInterfacesRequestBuilder(Dictionary<string, object> pathParameters,
        IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/network-interfaces", pathParameters)
    {
    }

    /// <summary>
    /// Instantiates a new NetworkInterfacesRequestBuilder and sets the default values.
    /// </summary>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public NetworkInterfacesRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter,
        "{+baseurl}/network-interfaces", rawUrl)
    {
    }

    /// <summary>Gets an item from the Firecracker.Client.networkInterfaces.item collection</summary>
    public WithIface_ItemRequestBuilder this[string position]
    {
        get
        {
            var urlTplParams = new Dictionary<string, object>(this.PathParameters);

            if (!string.IsNullOrWhiteSpace(position))
            {
                urlTplParams.Add("iface_id", position);
            }

            return new WithIface_ItemRequestBuilder(urlTplParams, this.RequestAdapter);
        }
    }
}