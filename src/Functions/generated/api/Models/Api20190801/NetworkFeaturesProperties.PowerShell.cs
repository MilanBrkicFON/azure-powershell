namespace Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801
{
    using Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.PowerShell;

    /// <summary>NetworkFeatures resource specific properties</summary>
    [System.ComponentModel.TypeConverter(typeof(NetworkFeaturesPropertiesTypeConverter))]
    public partial class NetworkFeaturesProperties
    {

        /// <summary>
        /// <c>AfterDeserializeDictionary</c> will be called after the deserialization has finished, allowing customization of the
        /// object before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>

        partial void AfterDeserializeDictionary(global::System.Collections.IDictionary content);

        /// <summary>
        /// <c>AfterDeserializePSObject</c> will be called after the deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>

        partial void AfterDeserializePSObject(global::System.Management.Automation.PSObject content);

        /// <summary>
        /// <c>BeforeDeserializeDictionary</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.NetworkFeaturesProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.INetworkFeaturesProperties"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.INetworkFeaturesProperties DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new NetworkFeaturesProperties(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.NetworkFeaturesProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.INetworkFeaturesProperties"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.INetworkFeaturesProperties DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new NetworkFeaturesProperties(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="NetworkFeaturesProperties" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.INetworkFeaturesProperties FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.NetworkFeaturesProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal NetworkFeaturesProperties(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.INetworkFeaturesPropertiesInternal)this).VirtualNetworkConnection = (Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IVnetInfo) content.GetValueForProperty("VirtualNetworkConnection",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.INetworkFeaturesPropertiesInternal)this).VirtualNetworkConnection, Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.VnetInfoTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.INetworkFeaturesPropertiesInternal)this).VirtualNetworkName = (string) content.GetValueForProperty("VirtualNetworkName",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.INetworkFeaturesPropertiesInternal)this).VirtualNetworkName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.INetworkFeaturesPropertiesInternal)this).HybridConnection = (Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IRelayServiceConnectionEntity[]) content.GetValueForProperty("HybridConnection",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.INetworkFeaturesPropertiesInternal)this).HybridConnection, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IRelayServiceConnectionEntity>(__y, Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.RelayServiceConnectionEntityTypeConverter.ConvertFrom));
            ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.INetworkFeaturesPropertiesInternal)this).HybridConnectionsV2 = (Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IHybridConnection[]) content.GetValueForProperty("HybridConnectionsV2",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.INetworkFeaturesPropertiesInternal)this).HybridConnectionsV2, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IHybridConnection>(__y, Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.HybridConnectionTypeConverter.ConvertFrom));
            ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.INetworkFeaturesPropertiesInternal)this).VirtualNetworkConnectionId = (string) content.GetValueForProperty("VirtualNetworkConnectionId",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.INetworkFeaturesPropertiesInternal)this).VirtualNetworkConnectionId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.INetworkFeaturesPropertiesInternal)this).VirtualNetworkConnectionKind = (string) content.GetValueForProperty("VirtualNetworkConnectionKind",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.INetworkFeaturesPropertiesInternal)this).VirtualNetworkConnectionKind, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.INetworkFeaturesPropertiesInternal)this).VirtualNetworkConnectionType = (string) content.GetValueForProperty("VirtualNetworkConnectionType",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.INetworkFeaturesPropertiesInternal)this).VirtualNetworkConnectionType, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.INetworkFeaturesPropertiesInternal)this).VirtualNetworkConnectionProperty = (Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IVnetInfoProperties) content.GetValueForProperty("VirtualNetworkConnectionProperty",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.INetworkFeaturesPropertiesInternal)this).VirtualNetworkConnectionProperty, Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.VnetInfoPropertiesTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.INetworkFeaturesPropertiesInternal)this).VirtualNetworkConnectionName = (string) content.GetValueForProperty("VirtualNetworkConnectionName",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.INetworkFeaturesPropertiesInternal)this).VirtualNetworkConnectionName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.INetworkFeaturesPropertiesInternal)this).VnetResourceId = (string) content.GetValueForProperty("VnetResourceId",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.INetworkFeaturesPropertiesInternal)this).VnetResourceId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.INetworkFeaturesPropertiesInternal)this).IsSwift = (bool?) content.GetValueForProperty("IsSwift",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.INetworkFeaturesPropertiesInternal)this).IsSwift, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.INetworkFeaturesPropertiesInternal)this).CertBlob = (string) content.GetValueForProperty("CertBlob",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.INetworkFeaturesPropertiesInternal)this).CertBlob, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.INetworkFeaturesPropertiesInternal)this).Route = (Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IVnetRoute[]) content.GetValueForProperty("Route",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.INetworkFeaturesPropertiesInternal)this).Route, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IVnetRoute>(__y, Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.VnetRouteTypeConverter.ConvertFrom));
            ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.INetworkFeaturesPropertiesInternal)this).ResyncRequired = (bool?) content.GetValueForProperty("ResyncRequired",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.INetworkFeaturesPropertiesInternal)this).ResyncRequired, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.INetworkFeaturesPropertiesInternal)this).DnsServer = (string) content.GetValueForProperty("DnsServer",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.INetworkFeaturesPropertiesInternal)this).DnsServer, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.INetworkFeaturesPropertiesInternal)this).CertThumbprint = (string) content.GetValueForProperty("CertThumbprint",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.INetworkFeaturesPropertiesInternal)this).CertThumbprint, global::System.Convert.ToString);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.NetworkFeaturesProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal NetworkFeaturesProperties(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.INetworkFeaturesPropertiesInternal)this).VirtualNetworkConnection = (Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IVnetInfo) content.GetValueForProperty("VirtualNetworkConnection",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.INetworkFeaturesPropertiesInternal)this).VirtualNetworkConnection, Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.VnetInfoTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.INetworkFeaturesPropertiesInternal)this).VirtualNetworkName = (string) content.GetValueForProperty("VirtualNetworkName",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.INetworkFeaturesPropertiesInternal)this).VirtualNetworkName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.INetworkFeaturesPropertiesInternal)this).HybridConnection = (Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IRelayServiceConnectionEntity[]) content.GetValueForProperty("HybridConnection",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.INetworkFeaturesPropertiesInternal)this).HybridConnection, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IRelayServiceConnectionEntity>(__y, Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.RelayServiceConnectionEntityTypeConverter.ConvertFrom));
            ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.INetworkFeaturesPropertiesInternal)this).HybridConnectionsV2 = (Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IHybridConnection[]) content.GetValueForProperty("HybridConnectionsV2",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.INetworkFeaturesPropertiesInternal)this).HybridConnectionsV2, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IHybridConnection>(__y, Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.HybridConnectionTypeConverter.ConvertFrom));
            ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.INetworkFeaturesPropertiesInternal)this).VirtualNetworkConnectionId = (string) content.GetValueForProperty("VirtualNetworkConnectionId",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.INetworkFeaturesPropertiesInternal)this).VirtualNetworkConnectionId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.INetworkFeaturesPropertiesInternal)this).VirtualNetworkConnectionKind = (string) content.GetValueForProperty("VirtualNetworkConnectionKind",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.INetworkFeaturesPropertiesInternal)this).VirtualNetworkConnectionKind, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.INetworkFeaturesPropertiesInternal)this).VirtualNetworkConnectionType = (string) content.GetValueForProperty("VirtualNetworkConnectionType",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.INetworkFeaturesPropertiesInternal)this).VirtualNetworkConnectionType, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.INetworkFeaturesPropertiesInternal)this).VirtualNetworkConnectionProperty = (Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IVnetInfoProperties) content.GetValueForProperty("VirtualNetworkConnectionProperty",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.INetworkFeaturesPropertiesInternal)this).VirtualNetworkConnectionProperty, Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.VnetInfoPropertiesTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.INetworkFeaturesPropertiesInternal)this).VirtualNetworkConnectionName = (string) content.GetValueForProperty("VirtualNetworkConnectionName",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.INetworkFeaturesPropertiesInternal)this).VirtualNetworkConnectionName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.INetworkFeaturesPropertiesInternal)this).VnetResourceId = (string) content.GetValueForProperty("VnetResourceId",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.INetworkFeaturesPropertiesInternal)this).VnetResourceId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.INetworkFeaturesPropertiesInternal)this).IsSwift = (bool?) content.GetValueForProperty("IsSwift",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.INetworkFeaturesPropertiesInternal)this).IsSwift, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.INetworkFeaturesPropertiesInternal)this).CertBlob = (string) content.GetValueForProperty("CertBlob",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.INetworkFeaturesPropertiesInternal)this).CertBlob, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.INetworkFeaturesPropertiesInternal)this).Route = (Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IVnetRoute[]) content.GetValueForProperty("Route",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.INetworkFeaturesPropertiesInternal)this).Route, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IVnetRoute>(__y, Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.VnetRouteTypeConverter.ConvertFrom));
            ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.INetworkFeaturesPropertiesInternal)this).ResyncRequired = (bool?) content.GetValueForProperty("ResyncRequired",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.INetworkFeaturesPropertiesInternal)this).ResyncRequired, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.INetworkFeaturesPropertiesInternal)this).DnsServer = (string) content.GetValueForProperty("DnsServer",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.INetworkFeaturesPropertiesInternal)this).DnsServer, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.INetworkFeaturesPropertiesInternal)this).CertThumbprint = (string) content.GetValueForProperty("CertThumbprint",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.INetworkFeaturesPropertiesInternal)this).CertThumbprint, global::System.Convert.ToString);
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// NetworkFeatures resource specific properties
    [System.ComponentModel.TypeConverter(typeof(NetworkFeaturesPropertiesTypeConverter))]
    public partial interface INetworkFeaturesProperties

    {

    }
}