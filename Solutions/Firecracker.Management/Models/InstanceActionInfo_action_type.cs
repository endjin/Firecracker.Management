// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Firecracker.Management.Models {
    /// <summary>Enumeration indicating what type of action is contained in the payload</summary>
    public enum InstanceActionInfo_action_type
    {
        [EnumMember(Value = "FlushMetrics")]
        #pragma warning disable CS1591
        FlushMetrics,
        #pragma warning restore CS1591
        [EnumMember(Value = "InstanceStart")]
        #pragma warning disable CS1591
        InstanceStart,
        #pragma warning restore CS1591
        [EnumMember(Value = "SendCtrlAltDel")]
        #pragma warning disable CS1591
        SendCtrlAltDel,
        #pragma warning restore CS1591
    }
}
