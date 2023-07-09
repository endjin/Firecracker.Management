using Firecracker.Management.Models;
using Microsoft.Kiota.Abstractions;

namespace Firecracker.Management.VersionNamespace;

/// <summary>
/// Builds and executes requests for operations under \version
/// </summary>
public class VersionRequestBuilder : BaseRequestBuilder
{
    /// <summary>
    /// Instantiates a new VersionRequestBuilder and sets the default values.
    /// </summary>
    /// <param name="pathParameters">Path parameters for the request</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public VersionRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(
        requestAdapter, "{+baseurl}/version", pathParameters)
    {
    }

    /// <summary>
    /// Instantiates a new VersionRequestBuilder and sets the default values.
    /// </summary>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public VersionRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter,
        "{+baseurl}/version", rawUrl)
    {
    }

    /// <summary>
    /// Gets the Firecracker version.
    /// </summary>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public async Task<FirecrackerVersion?> GetAsync(
        Action<VersionRequestBuilderGetRequestConfiguration>? requestConfiguration = default,
        CancellationToken cancellationToken = default)
    {
#nullable restore
#else
        public async Task<FirecrackerVersion> GetAsync(Action<VersionRequestBuilderGetRequestConfiguration> requestConfiguration
 = default, CancellationToken cancellationToken = default) {
#endif
        var requestInfo = this.ToGetRequestInformation(requestConfiguration);
        return await this.RequestAdapter.SendAsync<FirecrackerVersion>(requestInfo,
            FirecrackerVersion.CreateFromDiscriminatorValue, default, cancellationToken);
    }

    /// <summary>
    /// Gets the Firecracker version.
    /// </summary>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public RequestInformation ToGetRequestInformation(
        Action<VersionRequestBuilderGetRequestConfiguration>? requestConfiguration = default)
    {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<VersionRequestBuilderGetRequestConfiguration> requestConfiguration
 = default) {
#endif
        var requestInfo = new RequestInformation
        {
            HttpMethod = Method.GET,
            UrlTemplate = this.UrlTemplate,
            PathParameters = this.PathParameters,
        };
        requestInfo.Headers.Add("Accept", "application/json");
        if (requestConfiguration != null)
        {
            var requestConfig = new VersionRequestBuilderGetRequestConfiguration();
            requestConfiguration.Invoke(requestConfig);
            requestInfo.AddRequestOptions(requestConfig.Options);
            requestInfo.AddHeaders(requestConfig.Headers);
        }

        return requestInfo;
    }

    /// <summary>
    /// Configuration for the request such as headers, query parameters, and middleware options.
    /// </summary>
    public class VersionRequestBuilderGetRequestConfiguration
    {
        /// <summary>Request headers</summary>
        public RequestHeaders Headers { get; set; }

        /// <summary>Request options</summary>
        public IList<IRequestOption> Options { get; set; }

        /// <summary>
        /// Instantiates a new versionRequestBuilderGetRequestConfiguration and sets the default values.
        /// </summary>
        public VersionRequestBuilderGetRequestConfiguration()
        {
            this.Options = new List<IRequestOption>();
            this.Headers = new RequestHeaders();
        }
    }
}