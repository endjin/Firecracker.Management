// <auto-generated/>
using Firecracker.Management.Snapshot.Create;
using Firecracker.Management.Snapshot.Load;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace Firecracker.Management.Snapshot {
    /// <summary>
    /// Builds and executes requests for operations under \snapshot
    /// </summary>
    public class SnapshotRequestBuilder : BaseRequestBuilder 
    {
        /// <summary>The create property</summary>
        public CreateRequestBuilder Create
        {
            get => new CreateRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The load property</summary>
        public LoadRequestBuilder Load
        {
            get => new LoadRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="SnapshotRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public SnapshotRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/snapshot", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="SnapshotRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public SnapshotRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/snapshot", rawUrl)
        {
        }
    }
}
