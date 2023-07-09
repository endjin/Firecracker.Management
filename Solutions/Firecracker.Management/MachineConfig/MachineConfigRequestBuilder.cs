using Firecracker.Management.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;

namespace Firecracker.Management.MachineConfig;

/// <summary>
/// Builds and executes requests for operations under \machine-config
/// </summary>
public class MachineConfigRequestBuilder : BaseRequestBuilder
{
    /// <summary>
    /// Instantiates a new MachineConfigRequestBuilder and sets the default values.
    /// </summary>
    /// <param name="pathParameters">Path parameters for the request</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public MachineConfigRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter)
        : base(requestAdapter, "{+baseurl}/machine-config", pathParameters)
    {
    }

    /// <summary>
    /// Instantiates a new MachineConfigRequestBuilder and sets the default values.
    /// </summary>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public MachineConfigRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter,
        "{+baseurl}/machine-config", rawUrl)
    {
    }

    /// <summary>
    /// Gets the machine configuration of the VM. When called before the PUT operation, it will return the default values for the vCPU count (=1), memory size (=128 MiB). By default SMT is disabled and there is no CPU Template.
    /// </summary>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public async Task<MachineConfiguration?> GetAsync(
        Action<MachineConfigRequestBuilderGetRequestConfiguration>? requestConfiguration = default,
        CancellationToken cancellationToken = default)
    {
#nullable restore
#else
        public async Task<MachineConfiguration> GetAsync(Action<MachineConfigRequestBuilderGetRequestConfiguration> requestConfiguration
 = default, CancellationToken cancellationToken = default) {
#endif
        var requestInfo = this.ToGetRequestInformation(requestConfiguration);
        return await this.RequestAdapter.SendAsync<MachineConfiguration>(requestInfo,
            MachineConfiguration.CreateFromDiscriminatorValue, default, cancellationToken);
    }

    /// <summary>
    /// Partially updates the Virtual Machine Configuration with the specified input. If any of the parameters has an incorrect value, the whole update fails.
    /// </summary>
    /// <param name="body">Describes the number of vCPUs, memory size, SMT capabilities and the CPU template.</param>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public async Task PatchAsync(MachineConfiguration body,
        Action<MachineConfigRequestBuilderPatchRequestConfiguration>? requestConfiguration = default,
        CancellationToken cancellationToken = default)
    {
#nullable restore
#else
        public async Task PatchAsync(MachineConfiguration body, Action<MachineConfigRequestBuilderPatchRequestConfiguration> requestConfiguration
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
    /// Updates the Virtual Machine Configuration with the specified input. Firecracker starts with default values for vCPU count (=1) and memory size (=128 MiB). The vCPU count is restricted to the [1, 32] range. With SMT enabled, the vCPU count is required to be either 1 or an even number in the range. otherwise there are no restrictions regarding the vCPU count. If any of the parameters has an incorrect value, the whole update fails. All parameters that are optional and are not specified are set to their default values (smt = false, track_dirty_pages = false, cpu_template = None).
    /// </summary>
    /// <param name="body">Describes the number of vCPUs, memory size, SMT capabilities and the CPU template.</param>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public async Task PutAsync(MachineConfiguration body,
        Action<MachineConfigRequestBuilderPutRequestConfiguration>? requestConfiguration = default,
        CancellationToken cancellationToken = default)
    {
#nullable restore
#else
        public async Task PutAsync(MachineConfiguration body, Action<MachineConfigRequestBuilderPutRequestConfiguration> requestConfiguration
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
    /// Gets the machine configuration of the VM. When called before the PUT operation, it will return the default values for the vCPU count (=1), memory size (=128 MiB). By default SMT is disabled and there is no CPU Template.
    /// </summary>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public RequestInformation ToGetRequestInformation(
        Action<MachineConfigRequestBuilderGetRequestConfiguration>? requestConfiguration = default)
    {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<MachineConfigRequestBuilderGetRequestConfiguration> requestConfiguration
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
            var requestConfig = new MachineConfigRequestBuilderGetRequestConfiguration();
            requestConfiguration.Invoke(requestConfig);
            requestInfo.AddRequestOptions(requestConfig.Options);
            requestInfo.AddHeaders(requestConfig.Headers);
        }

        return requestInfo;
    }

    /// <summary>
    /// Partially updates the Virtual Machine Configuration with the specified input. If any of the parameters has an incorrect value, the whole update fails.
    /// </summary>
    /// <param name="body">Describes the number of vCPUs, memory size, SMT capabilities and the CPU template.</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public RequestInformation ToPatchRequestInformation(MachineConfiguration body,
        Action<MachineConfigRequestBuilderPatchRequestConfiguration>? requestConfiguration = default)
    {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(MachineConfiguration body, Action<MachineConfigRequestBuilderPatchRequestConfiguration> requestConfiguration
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
            var requestConfig = new MachineConfigRequestBuilderPatchRequestConfiguration();
            requestConfiguration.Invoke(requestConfig);
            requestInfo.AddRequestOptions(requestConfig.Options);
            requestInfo.AddHeaders(requestConfig.Headers);
        }

        return requestInfo;
    }

    /// <summary>
    /// Updates the Virtual Machine Configuration with the specified input. Firecracker starts with default values for vCPU count (=1) and memory size (=128 MiB). The vCPU count is restricted to the [1, 32] range. With SMT enabled, the vCPU count is required to be either 1 or an even number in the range. otherwise there are no restrictions regarding the vCPU count. If any of the parameters has an incorrect value, the whole update fails. All parameters that are optional and are not specified are set to their default values (smt = false, track_dirty_pages = false, cpu_template = None).
    /// </summary>
    /// <param name="body">Describes the number of vCPUs, memory size, SMT capabilities and the CPU template.</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public RequestInformation ToPutRequestInformation(MachineConfiguration body,
        Action<MachineConfigRequestBuilderPutRequestConfiguration>? requestConfiguration = default)
    {
#nullable restore
#else
        public RequestInformation ToPutRequestInformation(MachineConfiguration body, Action<MachineConfigRequestBuilderPutRequestConfiguration> requestConfiguration
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
            var requestConfig = new MachineConfigRequestBuilderPutRequestConfiguration();
            requestConfiguration.Invoke(requestConfig);
            requestInfo.AddRequestOptions(requestConfig.Options);
            requestInfo.AddHeaders(requestConfig.Headers);
        }

        return requestInfo;
    }

    /// <summary>
    /// Configuration for the request such as headers, query parameters, and middleware options.
    /// </summary>
    public class MachineConfigRequestBuilderGetRequestConfiguration
    {
        /// <summary>Request headers</summary>
        public RequestHeaders Headers { get; set; }

        /// <summary>Request options</summary>
        public IList<IRequestOption> Options { get; set; }

        /// <summary>
        /// Instantiates a new machineConfigRequestBuilderGetRequestConfiguration and sets the default values.
        /// </summary>
        public MachineConfigRequestBuilderGetRequestConfiguration()
        {
            this.Options = new List<IRequestOption>();
            this.Headers = new RequestHeaders();
        }
    }

    /// <summary>
    /// Configuration for the request such as headers, query parameters, and middleware options.
    /// </summary>
    public class MachineConfigRequestBuilderPatchRequestConfiguration
    {
        /// <summary>Request headers</summary>
        public RequestHeaders Headers { get; set; }

        /// <summary>Request options</summary>
        public IList<IRequestOption> Options { get; set; }

        /// <summary>
        /// Instantiates a new machineConfigRequestBuilderPatchRequestConfiguration and sets the default values.
        /// </summary>
        public MachineConfigRequestBuilderPatchRequestConfiguration()
        {
            this.Options = new List<IRequestOption>();
            this.Headers = new RequestHeaders();
        }
    }

    /// <summary>
    /// Configuration for the request such as headers, query parameters, and middleware options.
    /// </summary>
    public class MachineConfigRequestBuilderPutRequestConfiguration
    {
        /// <summary>Request headers</summary>
        public RequestHeaders Headers { get; set; }

        /// <summary>Request options</summary>
        public IList<IRequestOption> Options { get; set; }

        /// <summary>
        /// Instantiates a new machineConfigRequestBuilderPutRequestConfiguration and sets the default values.
        /// </summary>
        public MachineConfigRequestBuilderPutRequestConfiguration()
        {
            this.Options = new List<IRequestOption>();
            this.Headers = new RequestHeaders();
        }
    }
}