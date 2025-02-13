// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Firecracker.Management.Models
{
    /// <summary>The CPU Template defines a set of flags to be disabled from the microvm so that the features exposed to the guest are the same as in the selected instance type. This parameter has been deprecated and it will be removed in future Firecracker release.</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public enum CpuTemplate
    {
        [EnumMember(Value = "C3")]
        #pragma warning disable CS1591
        C3,
        #pragma warning restore CS1591
        [EnumMember(Value = "T2")]
        #pragma warning disable CS1591
        T2,
        #pragma warning restore CS1591
        [EnumMember(Value = "T2S")]
        #pragma warning disable CS1591
        T2S,
        #pragma warning restore CS1591
        [EnumMember(Value = "T2CL")]
        #pragma warning disable CS1591
        T2CL,
        #pragma warning restore CS1591
        [EnumMember(Value = "T2A")]
        #pragma warning disable CS1591
        T2A,
        #pragma warning restore CS1591
        [EnumMember(Value = "V1N1")]
        #pragma warning disable CS1591
        V1N1,
        #pragma warning restore CS1591
        [EnumMember(Value = "None")]
        #pragma warning disable CS1591
        None,
        #pragma warning restore CS1591
    }
}
