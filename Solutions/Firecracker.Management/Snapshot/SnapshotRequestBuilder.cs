using Firecracker.Management.Snapshot.Create;
using Firecracker.Management.Snapshot.Load;
using Microsoft.Kiota.Abstractions;

namespace Firecracker.Management.Snapshot;

/// <summary>
/// Builds and executes requests for operations under \snapshot
/// </summary>
public class SnapshotRequestBuilder : BaseRequestBuilder
{
    /// <summary>The create property</summary>
    public CreateRequestBuilder Create
    {
        get => new(this.PathParameters, this.RequestAdapter);
    }

    /// <summary>The load property</summary>
    public LoadRequestBuilder Load
    {
        get => new(this.PathParameters, this.RequestAdapter);
    }

    /// <summary>
    /// Instantiates a new SnapshotRequestBuilder and sets the default values.
    /// </summary>
    /// <param name="pathParameters">Path parameters for the request</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public SnapshotRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(
        requestAdapter, "{+baseurl}/snapshot", pathParameters)
    {
    }

    /// <summary>
    /// Instantiates a new SnapshotRequestBuilder and sets the default values.
    /// </summary>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public SnapshotRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter,
        "{+baseurl}/snapshot", rawUrl)
    {
    }
}