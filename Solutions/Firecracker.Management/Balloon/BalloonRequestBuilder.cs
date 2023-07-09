using Firecracker.Management.Balloon.Statistics;
using Firecracker.Management.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;

namespace Firecracker.Management.Balloon;

/// <summary>
/// Builds and executes requests for operations under \balloon
/// </summary>
public class BalloonRequestBuilder : BaseRequestBuilder
{
    /// <summary>The statistics property</summary>
    public StatisticsRequestBuilder Statistics
    {
        get => new(this.PathParameters, this.RequestAdapter);
    }

    /// <summary>
    /// Instantiates a new BalloonRequestBuilder and sets the default values.
    /// </summary>
    /// <param name="pathParameters">Path parameters for the request</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public BalloonRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter)
        : base(requestAdapter, "{+baseurl}/balloon", pathParameters)
    {
    }

    /// <summary>
    /// Instantiates a new BalloonRequestBuilder and sets the default values.
    /// </summary>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public BalloonRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter,
        "{+baseurl}/balloon", rawUrl)
    {
    }

    /// <summary>
    /// Returns the current balloon device configuration.
    /// </summary>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public async Task<Models.Balloon?> GetAsync(
        Action<BalloonRequestBuilderGetRequestConfiguration>? requestConfiguration = default,
        CancellationToken cancellationToken = default)
    {
#nullable restore
#else
        public async Task<Firecracker.Client.Models.Balloon> GetAsync(Action<BalloonRequestBuilderGetRequestConfiguration> requestConfiguration
 = default, CancellationToken cancellationToken = default) {
#endif
        var requestInfo = this.ToGetRequestInformation(requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", Error.CreateFromDiscriminatorValue },
        };
        return await this.RequestAdapter.SendAsync<Models.Balloon>(requestInfo,
            Models.Balloon.CreateFromDiscriminatorValue, errorMapping, cancellationToken);
    }

    /// <summary>
    /// Updates an existing balloon device, before or after machine startup. Will fail if update is not possible.
    /// </summary>
    /// <param name="body">Balloon device descriptor.</param>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public async Task PatchAsync(BalloonUpdate body,
        Action<BalloonRequestBuilderPatchRequestConfiguration>? requestConfiguration = default,
        CancellationToken cancellationToken = default)
    {
#nullable restore
#else
        public async Task PatchAsync(BalloonUpdate body, Action<BalloonRequestBuilderPatchRequestConfiguration> requestConfiguration
 = default, CancellationToken cancellationToken = default) {
#endif
        _ = body ?? throw new ArgumentNullException(nameof(body));
        var requestInfo = this.ToPatchRequestInformation(body, requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", Error.CreateFromDiscriminatorValue },
        };
        await this.RequestAdapter.SendNoContentAsync(requestInfo, errorMapping, cancellationToken);
    }

    /// <summary>
    /// Creates a new balloon device if one does not already exist, otherwise updates it, before machine startup. This will fail after machine startup. Will fail if update is not possible.
    /// </summary>
    /// <param name="body">Balloon device descriptor.</param>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public async Task PutAsync(Models.Balloon body,
        Action<BalloonRequestBuilderPutRequestConfiguration>? requestConfiguration = default,
        CancellationToken cancellationToken = default)
    {
#nullable restore
#else
        public async Task PutAsync(Firecracker.Client.Models.Balloon body, Action<BalloonRequestBuilderPutRequestConfiguration> requestConfiguration
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
    /// Returns the current balloon device configuration.
    /// </summary>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public RequestInformation ToGetRequestInformation(
        Action<BalloonRequestBuilderGetRequestConfiguration>? requestConfiguration = default)
    {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<BalloonRequestBuilderGetRequestConfiguration> requestConfiguration
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
            var requestConfig = new BalloonRequestBuilderGetRequestConfiguration();
            requestConfiguration.Invoke(requestConfig);
            requestInfo.AddRequestOptions(requestConfig.Options);
            requestInfo.AddHeaders(requestConfig.Headers);
        }

        return requestInfo;
    }

    /// <summary>
    /// Updates an existing balloon device, before or after machine startup. Will fail if update is not possible.
    /// </summary>
    /// <param name="body">Balloon device descriptor.</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public RequestInformation ToPatchRequestInformation(BalloonUpdate body,
        Action<BalloonRequestBuilderPatchRequestConfiguration>? requestConfiguration = default)
    {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(BalloonUpdate body, Action<BalloonRequestBuilderPatchRequestConfiguration> requestConfiguration
 = default) {
#endif
        _ = body ?? throw new ArgumentNullException(nameof(body));
        var requestInfo = new RequestInformation
        {
            HttpMethod = Method.PATCH,
            UrlTemplate = this.UrlTemplate,
            PathParameters = this.PathParameters,
        };
        requestInfo.SetContentFromParsable(this.RequestAdapter, "application/json", body);
        if (requestConfiguration != null)
        {
            var requestConfig = new BalloonRequestBuilderPatchRequestConfiguration();
            requestConfiguration.Invoke(requestConfig);
            requestInfo.AddRequestOptions(requestConfig.Options);
            requestInfo.AddHeaders(requestConfig.Headers);
        }

        return requestInfo;
    }

    /// <summary>
    /// Creates a new balloon device if one does not already exist, otherwise updates it, before machine startup. This will fail after machine startup. Will fail if update is not possible.
    /// </summary>
    /// <param name="body">Balloon device descriptor.</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public RequestInformation ToPutRequestInformation(Models.Balloon body,
        Action<BalloonRequestBuilderPutRequestConfiguration>? requestConfiguration = default)
    {
#nullable restore
#else
        public RequestInformation ToPutRequestInformation(Firecracker.Client.Models.Balloon body, Action<BalloonRequestBuilderPutRequestConfiguration> requestConfiguration
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
            var requestConfig = new BalloonRequestBuilderPutRequestConfiguration();
            requestConfiguration.Invoke(requestConfig);
            requestInfo.AddRequestOptions(requestConfig.Options);
            requestInfo.AddHeaders(requestConfig.Headers);
        }

        return requestInfo;
    }

    /// <summary>
    /// Configuration for the request such as headers, query parameters, and middleware options.
    /// </summary>
    public class BalloonRequestBuilderGetRequestConfiguration
    {
        /// <summary>Request headers</summary>
        public RequestHeaders Headers { get; set; }

        /// <summary>Request options</summary>
        public IList<IRequestOption> Options { get; set; }

        /// <summary>
        /// Instantiates a new balloonRequestBuilderGetRequestConfiguration and sets the default values.
        /// </summary>
        public BalloonRequestBuilderGetRequestConfiguration()
        {
            this.Options = new List<IRequestOption>();
            this.Headers = new RequestHeaders();
        }
    }

    /// <summary>
    /// Configuration for the request such as headers, query parameters, and middleware options.
    /// </summary>
    public class BalloonRequestBuilderPatchRequestConfiguration
    {
        /// <summary>Request headers</summary>
        public RequestHeaders Headers { get; set; }

        /// <summary>Request options</summary>
        public IList<IRequestOption> Options { get; set; }

        /// <summary>
        /// Instantiates a new balloonRequestBuilderPatchRequestConfiguration and sets the default values.
        /// </summary>
        public BalloonRequestBuilderPatchRequestConfiguration()
        {
            this.Options = new List<IRequestOption>();
            this.Headers = new RequestHeaders();
        }
    }

    /// <summary>
    /// Configuration for the request such as headers, query parameters, and middleware options.
    /// </summary>
    public class BalloonRequestBuilderPutRequestConfiguration
    {
        /// <summary>Request headers</summary>
        public RequestHeaders Headers { get; set; }

        /// <summary>Request options</summary>
        public IList<IRequestOption> Options { get; set; }

        /// <summary>
        /// Instantiates a new balloonRequestBuilderPutRequestConfiguration and sets the default values.
        /// </summary>
        public BalloonRequestBuilderPutRequestConfiguration()
        {
            this.Options = new List<IRequestOption>();
            this.Headers = new RequestHeaders();
        }
    }
}