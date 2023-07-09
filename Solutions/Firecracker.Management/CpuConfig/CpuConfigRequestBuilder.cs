using Firecracker.Management.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;

namespace Firecracker.Management.CpuConfig;

/// <summary>
/// Builds and executes requests for operations under \cpu-config
/// </summary>
public class CpuConfigRequestBuilder : BaseRequestBuilder
{
    /// <summary>
    /// Instantiates a new CpuConfigRequestBuilder and sets the default values.
    /// </summary>
    /// <param name="pathParameters">Path parameters for the request</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public CpuConfigRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter)
        : base(requestAdapter, "{+baseurl}/cpu-config", pathParameters)
    {
    }

    /// <summary>
    /// Instantiates a new CpuConfigRequestBuilder and sets the default values.
    /// </summary>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public CpuConfigRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter,
        "{+baseurl}/cpu-config", rawUrl)
    {
    }

    /// <summary>
    /// Provides configuration to the Firecracker process to specify vCPU resource configuration prior to launching the guest machine.
    /// </summary>
    /// <param name="body">The CPU configuration template defines a set of bit maps as modifiers of flags accessed by register to be disabled/enabled for the microvm.</param>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public async Task PutAsync(Models.CpuConfig body,
        Action<CpuConfigRequestBuilderPutRequestConfiguration>? requestConfiguration = default,
        CancellationToken cancellationToken = default)
    {
#nullable restore
#else
        public async Task PutAsync(Firecracker.Client.Models.CpuConfig body, Action<CpuConfigRequestBuilderPutRequestConfiguration> requestConfiguration
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
    /// Provides configuration to the Firecracker process to specify vCPU resource configuration prior to launching the guest machine.
    /// </summary>
    /// <param name="body">The CPU configuration template defines a set of bit maps as modifiers of flags accessed by register to be disabled/enabled for the microvm.</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public RequestInformation ToPutRequestInformation(Models.CpuConfig body,
        Action<CpuConfigRequestBuilderPutRequestConfiguration>? requestConfiguration = default)
    {
#nullable restore
#else
        public RequestInformation ToPutRequestInformation(Firecracker.Client.Models.CpuConfig body, Action<CpuConfigRequestBuilderPutRequestConfiguration> requestConfiguration
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
            var requestConfig = new CpuConfigRequestBuilderPutRequestConfiguration();
            requestConfiguration.Invoke(requestConfig);
            requestInfo.AddRequestOptions(requestConfig.Options);
            requestInfo.AddHeaders(requestConfig.Headers);
        }

        return requestInfo;
    }

    /// <summary>
    /// Configuration for the request such as headers, query parameters, and middleware options.
    /// </summary>
    public class CpuConfigRequestBuilderPutRequestConfiguration
    {
        /// <summary>Request headers</summary>
        public RequestHeaders Headers { get; set; }

        /// <summary>Request options</summary>
        public IList<IRequestOption> Options { get; set; }

        /// <summary>
        /// Instantiates a new cpuConfigRequestBuilderPutRequestConfiguration and sets the default values.
        /// </summary>
        public CpuConfigRequestBuilderPutRequestConfiguration()
        {
            this.Options = new List<IRequestOption>();
            this.Headers = new RequestHeaders();
        }
    }
}