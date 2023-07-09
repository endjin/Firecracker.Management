using Firecracker.Management.Actions;
using Firecracker.Management.Balloon;
using Firecracker.Management.BootSource;
using Firecracker.Management.CpuConfig;
using Firecracker.Management.Drives;
using Firecracker.Management.Entropy;
using Firecracker.Management.Logger;
using Firecracker.Management.MachineConfig;
using Firecracker.Management.Metrics;
using Firecracker.Management.Mmds;
using Firecracker.Management.Models;
using Firecracker.Management.NetworkInterfaces;
using Firecracker.Management.Snapshot;
using Firecracker.Management.VersionNamespace;
using Firecracker.Management.Vm;
using Firecracker.Management.Vsock;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Serialization.Form;
using Microsoft.Kiota.Serialization.Json;
using Microsoft.Kiota.Serialization.Text;

namespace Firecracker.Management;

/// <summary>
/// The main entry point of the SDK, exposes the configuration and the fluent API.
/// </summary>
public class FirecrackerManagementClient : BaseRequestBuilder
{
    /// <summary>The actions property</summary>
    public ActionsRequestBuilder Actions
    {
        get => new(this.PathParameters, this.RequestAdapter);
    }

    /// <summary>The balloon property</summary>
    public BalloonRequestBuilder Balloon
    {
        get => new(this.PathParameters, this.RequestAdapter);
    }

    /// <summary>The bootSource property</summary>
    public BootSourceRequestBuilder BootSource
    {
        get => new(this.PathParameters, this.RequestAdapter);
    }

    /// <summary>The cpuConfig property</summary>
    public CpuConfigRequestBuilder CpuConfig
    {
        get => new(this.PathParameters, this.RequestAdapter);
    }

    /// <summary>The drives property</summary>
    public DrivesRequestBuilder Drives
    {
        get => new(this.PathParameters, this.RequestAdapter);
    }

    /// <summary>The entropy property</summary>
    public EntropyRequestBuilder Entropy
    {
        get => new(this.PathParameters, this.RequestAdapter);
    }

    /// <summary>The logger property</summary>
    public LoggerRequestBuilder Logger
    {
        get => new(this.PathParameters, this.RequestAdapter);
    }

    /// <summary>The machineConfig property</summary>
    public MachineConfigRequestBuilder MachineConfig
    {
        get => new(this.PathParameters, this.RequestAdapter);
    }

    /// <summary>The metrics property</summary>
    public MetricsRequestBuilder Metrics
    {
        get => new(this.PathParameters, this.RequestAdapter);
    }

    /// <summary>The mmds property</summary>
    public MmdsRequestBuilder Mmds
    {
        get => new(this.PathParameters, this.RequestAdapter);
    }

    /// <summary>The networkInterfaces property</summary>
    public NetworkInterfacesRequestBuilder NetworkInterfaces
    {
        get => new(this.PathParameters, this.RequestAdapter);
    }

    /// <summary>The snapshot property</summary>
    public SnapshotRequestBuilder Snapshot
    {
        get => new(this.PathParameters, this.RequestAdapter);
    }

    /// <summary>The version property</summary>
    public VersionRequestBuilder Version
    {
        get => new(this.PathParameters, this.RequestAdapter);
    }

    /// <summary>The vm property</summary>
    public VmRequestBuilder Vm
    {
        get => new(this.PathParameters, this.RequestAdapter);
    }

    /// <summary>The vsock property</summary>
    public VsockRequestBuilder Vsock
    {
        get => new(this.PathParameters, this.RequestAdapter);
    }

    /// <summary>
    /// Instantiates a new FirecrackerManagementClient and sets the default values.
    /// </summary>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public FirecrackerManagementClient(IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}",
        new Dictionary<string, object>())
    {
        ApiClientBuilder.RegisterDefaultSerializer<JsonSerializationWriterFactory>();
        ApiClientBuilder.RegisterDefaultSerializer<TextSerializationWriterFactory>();
        ApiClientBuilder.RegisterDefaultSerializer<FormSerializationWriterFactory>();
        ApiClientBuilder.RegisterDefaultDeserializer<JsonParseNodeFactory>();
        ApiClientBuilder.RegisterDefaultDeserializer<TextParseNodeFactory>();
        ApiClientBuilder.RegisterDefaultDeserializer<FormParseNodeFactory>();
        if (string.IsNullOrEmpty(this.RequestAdapter.BaseUrl))
        {
            this.RequestAdapter.BaseUrl = "http://localhost";
        }

        this.PathParameters.TryAdd("baseurl", this.RequestAdapter.BaseUrl);
    }

    /// <summary>
    /// Returns general information about an instance.
    /// </summary>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public async Task<InstanceInfo?> GetAsync(
        Action<FireClientGetRequestConfiguration>? requestConfiguration = default,
        CancellationToken cancellationToken = default)
    {
#nullable restore
#else
        public async Task<InstanceInfo> GetAsync(Action<FireClientGetRequestConfiguration> requestConfiguration =
 default, CancellationToken cancellationToken = default) {
#endif
        var requestInfo = this.ToGetRequestInformation(requestConfiguration);
        return await this.RequestAdapter.SendAsync<InstanceInfo>(requestInfo, InstanceInfo.CreateFromDiscriminatorValue,
            default, cancellationToken);
    }

    /// <summary>
    /// Returns general information about an instance.
    /// </summary>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public RequestInformation ToGetRequestInformation(
        Action<FireClientGetRequestConfiguration>? requestConfiguration = default)
    {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<FireClientGetRequestConfiguration> requestConfiguration
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
            var requestConfig = new FireClientGetRequestConfiguration();
            requestConfiguration.Invoke(requestConfig);
            requestInfo.AddRequestOptions(requestConfig.Options);
            requestInfo.AddHeaders(requestConfig.Headers);
        }

        return requestInfo;
    }

    /// <summary>
    /// Configuration for the request such as headers, query parameters, and middleware options.
    /// </summary>
    public class FireClientGetRequestConfiguration
    {
        /// <summary>Request headers</summary>
        public RequestHeaders Headers { get; set; }

        /// <summary>Request options</summary>
        public IList<IRequestOption> Options { get; set; }

        /// <summary>
        /// Instantiates a new FireClientGetRequestConfiguration and sets the default values.
        /// </summary>
        public FireClientGetRequestConfiguration()
        {
            this.Options = new List<IRequestOption>();
            this.Headers = new RequestHeaders();
        }
    }
}