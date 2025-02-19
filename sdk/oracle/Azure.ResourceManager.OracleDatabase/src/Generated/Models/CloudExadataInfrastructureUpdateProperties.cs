// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.OracleDatabase.Models
{
    /// <summary>
    /// The updatable properties of the CloudExadataInfrastructure.
    /// Serialized Name: CloudExadataInfrastructureUpdateProperties
    /// </summary>
    public partial class CloudExadataInfrastructureUpdateProperties
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="CloudExadataInfrastructureUpdateProperties"/>. </summary>
        public CloudExadataInfrastructureUpdateProperties()
        {
            CustomerContacts = new ChangeTrackingList<CustomerContact>();
        }

        /// <summary> Initializes a new instance of <see cref="CloudExadataInfrastructureUpdateProperties"/>. </summary>
        /// <param name="computeCount">
        /// The number of compute servers for the cloud Exadata infrastructure.
        /// Serialized Name: CloudExadataInfrastructureUpdateProperties.computeCount
        /// </param>
        /// <param name="storageCount">
        /// The number of storage servers for the cloud Exadata infrastructure.
        /// Serialized Name: CloudExadataInfrastructureUpdateProperties.storageCount
        /// </param>
        /// <param name="maintenanceWindow">
        /// maintenanceWindow property
        /// Serialized Name: CloudExadataInfrastructureUpdateProperties.maintenanceWindow
        /// </param>
        /// <param name="customerContacts">
        /// The list of customer email addresses that receive information from Oracle about the specified OCI Database service resource. Oracle uses these email addresses to send notifications about planned and unplanned software maintenance updates, information about system hardware, and other information needed by administrators. Up to 10 email addresses can be added to the customer contacts for a cloud Exadata infrastructure instance.
        /// Serialized Name: CloudExadataInfrastructureUpdateProperties.customerContacts
        /// </param>
        /// <param name="displayName">
        /// The name for the Exadata infrastructure.
        /// Serialized Name: CloudExadataInfrastructureUpdateProperties.displayName
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal CloudExadataInfrastructureUpdateProperties(int? computeCount, int? storageCount, MaintenanceWindow maintenanceWindow, IList<CustomerContact> customerContacts, string displayName, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ComputeCount = computeCount;
            StorageCount = storageCount;
            MaintenanceWindow = maintenanceWindow;
            CustomerContacts = customerContacts;
            DisplayName = displayName;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary>
        /// The number of compute servers for the cloud Exadata infrastructure.
        /// Serialized Name: CloudExadataInfrastructureUpdateProperties.computeCount
        /// </summary>
        public int? ComputeCount { get; set; }
        /// <summary>
        /// The number of storage servers for the cloud Exadata infrastructure.
        /// Serialized Name: CloudExadataInfrastructureUpdateProperties.storageCount
        /// </summary>
        public int? StorageCount { get; set; }
        /// <summary>
        /// maintenanceWindow property
        /// Serialized Name: CloudExadataInfrastructureUpdateProperties.maintenanceWindow
        /// </summary>
        public MaintenanceWindow MaintenanceWindow { get; set; }
        /// <summary>
        /// The list of customer email addresses that receive information from Oracle about the specified OCI Database service resource. Oracle uses these email addresses to send notifications about planned and unplanned software maintenance updates, information about system hardware, and other information needed by administrators. Up to 10 email addresses can be added to the customer contacts for a cloud Exadata infrastructure instance.
        /// Serialized Name: CloudExadataInfrastructureUpdateProperties.customerContacts
        /// </summary>
        public IList<CustomerContact> CustomerContacts { get; }
        /// <summary>
        /// The name for the Exadata infrastructure.
        /// Serialized Name: CloudExadataInfrastructureUpdateProperties.displayName
        /// </summary>
        public string DisplayName { get; set; }
    }
}
