namespace Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20190501Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Runtime.Extensions;

    /// <summary>
    /// Tags of the service which is a list of key value pairs that describe the resource.
    /// </summary>
    public partial class TrackedResourceTags :
        Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20190501Preview.ITrackedResourceTags,
        Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20190501Preview.ITrackedResourceTagsInternal
    {

        /// <summary>Creates an new <see cref="TrackedResourceTags" /> instance.</summary>
        public TrackedResourceTags()
        {

        }
    }
    /// Tags of the service which is a list of key value pairs that describe the resource.
    public partial interface ITrackedResourceTags :
        Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Runtime.IAssociativeArray<string>
    {

    }
    /// Tags of the service which is a list of key value pairs that describe the resource.
    public partial interface ITrackedResourceTagsInternal

    {

    }
}