using Firecracker.Management.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;

namespace Firecracker.Management.Metrics;

/// <summary>
/// Builds and executes requests for operations under \metrics
/// </summary>
public class MetricsRequestBuilder : BaseRequestBuilder
{
    /// <summary>
    /// Instantiates a new MetricsRequestBuilder and sets the default values.
    /// </summary>
    /// <param name="pathParameters">Path parameters for the request</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public MetricsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(
        requestAdapter, "{+baseurl}/metrics", pathParameters)
    {
    }

    /// <summary>
    /// Instantiates a new MetricsRequestBuilder and sets the default values.
    /// </summary>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public MetricsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter,
        "{+baseurl}/metrics", rawUrl)
    {
    }

    /// <summary>
    /// Initializes the metrics system by specifying a named pipe or a file for the metrics output.
    /// </summary>
    /// <param name="body">Describes the configuration option for the metrics capability.</param>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public async Task PutAsync(Models.Metrics body,
        Action<MetricsRequestBuilderPutRequestConfiguration>? requestConfiguration = default,
        CancellationToken cancellationToken = default)
    {
#nullable restore
#else
        public async Task PutAsync(Firecracker.Client.Models.Metrics body, Action<MetricsRequestBuilderPutRequestConfiguration> requestConfiguration
 = default, CancellationToken cancellationToken = default) {
#endif
        _ = body ?? throw new ArgumentNullException(nameof(body));
        var requestInfo = this.ToPutRequestInformation(body, requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", Error.CreateFromDiscriminatorValue },
        };
        await this.RequestAdapter.SendNoContentAsync(requestInfo, errorMapping, cancellationToken);
    }

    /// <summary>
    /// Initializes the metrics system by specifying a named pipe or a file for the metrics output.
    /// </summary>
    /// <param name="body">Describes the configuration option for the metrics capability.</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public RequestInformation ToPutRequestInformation(Models.Metrics body,
        Action<MetricsRequestBuilderPutRequestConfiguration>? requestConfiguration = default)
    {
#nullable restore
#else
        public RequestInformation ToPutRequestInformation(Firecracker.Client.Models.Metrics body, Action<MetricsRequestBuilderPutRequestConfiguration> requestConfiguration
 = default) {
#endif
        _ = body ?? throw new ArgumentNullException(nameof(body));
        var requestInfo = new RequestInformation
        {
            HttpMethod = Method.PUT,
            UrlTemplate = this.UrlTemplate,
            PathParameters = this.PathParameters,
        };
        requestInfo.SetContentFromParsable(this.RequestAdapter, "application/json", body);
        if (requestConfiguration != null)
        {
            var requestConfig = new MetricsRequestBuilderPutRequestConfiguration();
            requestConfiguration.Invoke(requestConfig);
            requestInfo.AddRequestOptions(requestConfig.Options);
            requestInfo.AddHeaders(requestConfig.Headers);
        }

        return requestInfo;
    }

    /// <summary>
    /// Configuration for the request such as headers, query parameters, and middleware options.
    /// </summary>
    public class MetricsRequestBuilderPutRequestConfiguration
    {
        /// <summary>Request headers</summary>
        public RequestHeaders Headers { get; set; }

        /// <summary>Request options</summary>
        public IList<IRequestOption> Options { get; set; }

        /// <summary>
        /// Instantiates a new metricsRequestBuilderPutRequestConfiguration and sets the default values.
        /// </summary>
        public MetricsRequestBuilderPutRequestConfiguration()
        {
            this.Options = new List<IRequestOption>();
            this.Headers = new RequestHeaders();
        }
    }
}