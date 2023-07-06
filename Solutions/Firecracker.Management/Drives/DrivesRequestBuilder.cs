using Firecracker.Management.Drives.Item;
using Microsoft.Kiota.Abstractions;

namespace Firecracker.Management.Drives;

/// <summary>
/// Builds and executes requests for operations under \drives
/// </summary>
public class DrivesRequestBuilder : BaseRequestBuilder
{
    /// <summary>
    /// Instantiates a new DrivesRequestBuilder and sets the default values.
    /// </summary>
    /// <param name="pathParameters">Path parameters for the request</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public DrivesRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(
        requestAdapter, "{+baseurl}/drives", pathParameters)
    {
    }

    /// <summary>
    /// Instantiates a new DrivesRequestBuilder and sets the default values.
    /// </summary>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public DrivesRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter,
        "{+baseurl}/drives", rawUrl)
    {
    }

    /// <summary>Gets an item from the Firecracker.Client.drives.item collection</summary>
    public WithDrive_ItemRequestBuilder this[string position]
    {
        get
        {
            var urlTplParams = new Dictionary<string, object>(this.PathParameters);

            if (!string.IsNullOrWhiteSpace(position))
            {
                urlTplParams.Add("drive_id", position);
            }

            return new WithDrive_ItemRequestBuilder(urlTplParams, this.RequestAdapter);
        }
    }
}