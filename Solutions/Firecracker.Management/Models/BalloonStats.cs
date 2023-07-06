using Microsoft.Kiota.Abstractions.Serialization;

namespace Firecracker.Management.Models;

/// <summary>
/// Describes the balloon device statistics.
/// </summary>
public class BalloonStats : IAdditionalDataHolder, IParsable
{
    /// <summary>Actual amount of memory (in MiB) the device is holding.</summary>
    public int? ActualMib { get; set; }

    /// <summary>Actual number of pages the device is holding.</summary>
    public int? ActualPages { get; set; }

    /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
    public IDictionary<string, object> AdditionalData { get; set; }

    /// <summary>An estimate of how much memory is available (in bytes) for starting new applications, without pushing the system to swap.</summary>
    public long? AvailableMemory { get; set; }

    /// <summary>The amount of memory, in bytes, that can be quickly reclaimed without additional I/O. Typically these pages are used for caching files from disk.</summary>
    public long? DiskCaches { get; set; }

    /// <summary>The amount of memory not being used for any purpose (in bytes).</summary>
    public long? FreeMemory { get; set; }

    /// <summary>The number of successful hugetlb page allocations in the guest.</summary>
    public long? HugetlbAllocations { get; set; }

    /// <summary>The number of failed hugetlb page allocations in the guest.</summary>
    public long? HugetlbFailures { get; set; }

    /// <summary>The number of major page faults that have occurred.</summary>
    public long? MajorFaults { get; set; }

    /// <summary>The number of minor page faults that have occurred.</summary>
    public long? MinorFaults { get; set; }

    /// <summary>The amount of memory that has been swapped in (in bytes).</summary>
    public long? SwapIn { get; set; }

    /// <summary>The amount of memory that has been swapped out to disk (in bytes).</summary>
    public long? SwapOut { get; set; }

    /// <summary>Target amount of memory (in MiB) the device aims to hold.</summary>
    public int? TargetMib { get; set; }

    /// <summary>Target number of pages the device aims to hold.</summary>
    public int? TargetPages { get; set; }

    /// <summary>The total amount of memory available (in bytes).</summary>
    public long? TotalMemory { get; set; }

    /// <summary>
    /// Instantiates a new BalloonStats and sets the default values.
    /// </summary>
    public BalloonStats()
    {
        this.AdditionalData = new Dictionary<string, object>();
    }

    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static BalloonStats CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new BalloonStats();
    }

    /// <summary>
    /// The deserialization information for the current model
    /// </summary>
    public IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
    {
        return new Dictionary<string, Action<IParseNode>>
        {
            { "actual_mib", n => { this.ActualMib = n.GetIntValue(); } },
            { "actual_pages", n => { this.ActualPages = n.GetIntValue(); } },
            { "available_memory", n => { this.AvailableMemory = n.GetLongValue(); } },
            { "disk_caches", n => { this.DiskCaches = n.GetLongValue(); } },
            { "free_memory", n => { this.FreeMemory = n.GetLongValue(); } },
            { "hugetlb_allocations", n => { this.HugetlbAllocations = n.GetLongValue(); } },
            { "hugetlb_failures", n => { this.HugetlbFailures = n.GetLongValue(); } },
            { "major_faults", n => { this.MajorFaults = n.GetLongValue(); } },
            { "minor_faults", n => { this.MinorFaults = n.GetLongValue(); } },
            { "swap_in", n => { this.SwapIn = n.GetLongValue(); } },
            { "swap_out", n => { this.SwapOut = n.GetLongValue(); } },
            { "target_mib", n => { this.TargetMib = n.GetIntValue(); } },
            { "target_pages", n => { this.TargetPages = n.GetIntValue(); } },
            { "total_memory", n => { this.TotalMemory = n.GetLongValue(); } },
        };
    }

    /// <summary>
    /// Serializes information the current object
    /// </summary>
    /// <param name="writer">Serialization writer to use to serialize this model</param>
    public void Serialize(ISerializationWriter writer)
    {
        _ = writer ?? throw new ArgumentNullException(nameof(writer));
        writer.WriteIntValue("actual_mib", this.ActualMib);
        writer.WriteIntValue("actual_pages", this.ActualPages);
        writer.WriteLongValue("available_memory", this.AvailableMemory);
        writer.WriteLongValue("disk_caches", this.DiskCaches);
        writer.WriteLongValue("free_memory", this.FreeMemory);
        writer.WriteLongValue("hugetlb_allocations", this.HugetlbAllocations);
        writer.WriteLongValue("hugetlb_failures", this.HugetlbFailures);
        writer.WriteLongValue("major_faults", this.MajorFaults);
        writer.WriteLongValue("minor_faults", this.MinorFaults);
        writer.WriteLongValue("swap_in", this.SwapIn);
        writer.WriteLongValue("swap_out", this.SwapOut);
        writer.WriteIntValue("target_mib", this.TargetMib);
        writer.WriteIntValue("target_pages", this.TargetPages);
        writer.WriteLongValue("total_memory", this.TotalMemory);
        writer.WriteAdditionalData(this.AdditionalData);
    }
}