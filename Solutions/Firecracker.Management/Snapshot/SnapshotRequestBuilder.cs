// <auto-generated/>
using Firecracker.Management.Snapshot.Create;
using Firecracker.Management.Snapshot.Load;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace Firecracker.Management.Snapshot
{
    /// <summary>
    /// Builds and executes requests for operations under \snapshot
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.17.0")]
    public partial class SnapshotRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The create property</summary>
        public global::Firecracker.Management.Snapshot.Create.CreateRequestBuilder Create
        {
            get => new global::Firecracker.Management.Snapshot.Create.CreateRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The load property</summary>
        public global::Firecracker.Management.Snapshot.Load.LoadRequestBuilder Load
        {
            get => new global::Firecracker.Management.Snapshot.Load.LoadRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Firecracker.Management.Snapshot.SnapshotRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public SnapshotRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/snapshot", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Firecracker.Management.Snapshot.SnapshotRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public SnapshotRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/snapshot", rawUrl)
        {
        }
    }
}
