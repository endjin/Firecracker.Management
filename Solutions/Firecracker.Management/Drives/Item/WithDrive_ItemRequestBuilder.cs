using Firecracker.Management.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;

namespace Firecracker.Management.Drives.Item;

/// <summary>
/// Builds and executes requests for operations under \drives\{drive_id}
/// </summary>
public class WithDrive_ItemRequestBuilder : BaseRequestBuilder
{
    /// <summary>
    /// Instantiates a new WithDrive_ItemRequestBuilder and sets the default values.
    /// </summary>
    /// <param name="pathParameters">Path parameters for the request</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public WithDrive_ItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter)
        : base(requestAdapter, "{+baseurl}/drives/{drive_id}", pathParameters)
    {
    }

    /// <summary>
    /// Instantiates a new WithDrive_ItemRequestBuilder and sets the default values.
    /// </summary>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public WithDrive_ItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter,
        "{+baseurl}/drives/{drive_id}", rawUrl)
    {
    }

    /// <summary>
    /// Updates the properties of the drive with the ID specified by drive_id path parameter. Will fail if update is not possible.
    /// </summary>
    /// <param name="body">The request body</param>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public async Task PatchAsync(PartialDrive body,
        Action<WithDrive_ItemRequestBuilderPatchRequestConfiguration>? requestConfiguration = default,
        CancellationToken cancellationToken = default)
    {
#nullable restore
#else
        public async Task PatchAsync(PartialDrive body, Action<WithDrive_ItemRequestBuilderPatchRequestConfiguration> requestConfiguration
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
    /// Creates new drive with ID specified by drive_id path parameter. If a drive with the specified ID already exists, updates its state based on new input. Will fail if update is not possible.
    /// </summary>
    /// <param name="body">The request body</param>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public async Task PutAsync(Drive body,
        Action<WithDrive_ItemRequestBuilderPutRequestConfiguration>? requestConfiguration = default,
        CancellationToken cancellationToken = default)
    {
#nullable restore
#else
        public async Task PutAsync(Drive body, Action<WithDrive_ItemRequestBuilderPutRequestConfiguration> requestConfiguration
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
    /// Updates the properties of the drive with the ID specified by drive_id path parameter. Will fail if update is not possible.
    /// </summary>
    /// <param name="body">The request body</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public RequestInformation ToPatchRequestInformation(PartialDrive body,
        Action<WithDrive_ItemRequestBuilderPatchRequestConfiguration>? requestConfiguration = default)
    {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(PartialDrive body, Action<WithDrive_ItemRequestBuilderPatchRequestConfiguration> requestConfiguration
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
            var requestConfig = new WithDrive_ItemRequestBuilderPatchRequestConfiguration();
            requestConfiguration.Invoke(requestConfig);
            requestInfo.AddRequestOptions(requestConfig.Options);
            requestInfo.AddHeaders(requestConfig.Headers);
        }

        return requestInfo;
    }

    /// <summary>
    /// Creates new drive with ID specified by drive_id path parameter. If a drive with the specified ID already exists, updates its state based on new input. Will fail if update is not possible.
    /// </summary>
    /// <param name="body">The request body</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public RequestInformation ToPutRequestInformation(Drive body,
        Action<WithDrive_ItemRequestBuilderPutRequestConfiguration>? requestConfiguration = default)
    {
#nullable restore
#else
        public RequestInformation ToPutRequestInformation(Drive body, Action<WithDrive_ItemRequestBuilderPutRequestConfiguration> requestConfiguration
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
            var requestConfig = new WithDrive_ItemRequestBuilderPutRequestConfiguration();
            requestConfiguration.Invoke(requestConfig);
            requestInfo.AddRequestOptions(requestConfig.Options);
            requestInfo.AddHeaders(requestConfig.Headers);
        }

        return requestInfo;
    }

    /// <summary>
    /// Configuration for the request such as headers, query parameters, and middleware options.
    /// </summary>
    public class WithDrive_ItemRequestBuilderPatchRequestConfiguration
    {
        /// <summary>Request headers</summary>
        public RequestHeaders Headers { get; set; }

        /// <summary>Request options</summary>
        public IList<IRequestOption> Options { get; set; }

        /// <summary>
        /// Instantiates a new WithDrive_ItemRequestBuilderPatchRequestConfiguration and sets the default values.
        /// </summary>
        public WithDrive_ItemRequestBuilderPatchRequestConfiguration()
        {
            this.Options = new List<IRequestOption>();
            this.Headers = new RequestHeaders();
        }
    }

    /// <summary>
    /// Configuration for the request such as headers, query parameters, and middleware options.
    /// </summary>
    public class WithDrive_ItemRequestBuilderPutRequestConfiguration
    {
        /// <summary>Request headers</summary>
        public RequestHeaders Headers { get; set; }

        /// <summary>Request options</summary>
        public IList<IRequestOption> Options { get; set; }

        /// <summary>
        /// Instantiates a new WithDrive_ItemRequestBuilderPutRequestConfiguration and sets the default values.
        /// </summary>
        public WithDrive_ItemRequestBuilderPutRequestConfiguration()
        {
            this.Options = new List<IRequestOption>();
            this.Headers = new RequestHeaders();
        }
    }
}