// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.OracleDatabase.Models
{
    /// <summary>
    /// The list of scheduled operations.
    /// Serialized Name: ScheduledOperationsTypeUpdate
    /// </summary>
    public partial class ScheduledOperationsTypeUpdate
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

        /// <summary> Initializes a new instance of <see cref="ScheduledOperationsTypeUpdate"/>. </summary>
        public ScheduledOperationsTypeUpdate()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ScheduledOperationsTypeUpdate"/>. </summary>
        /// <param name="dayOfWeek">
        /// Day of week
        /// Serialized Name: ScheduledOperationsTypeUpdate.dayOfWeek
        /// </param>
        /// <param name="scheduledStartTime">
        /// auto start time. value must be of ISO-8601 format HH:mm
        /// Serialized Name: ScheduledOperationsTypeUpdate.scheduledStartTime
        /// </param>
        /// <param name="scheduledStopTime">
        /// auto stop time. value must be of ISO-8601 format HH:mm
        /// Serialized Name: ScheduledOperationsTypeUpdate.scheduledStopTime
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ScheduledOperationsTypeUpdate(DayOfWeekUpdate dayOfWeek, string scheduledStartTime, string scheduledStopTime, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            DayOfWeek = dayOfWeek;
            ScheduledStartTime = scheduledStartTime;
            ScheduledStopTime = scheduledStopTime;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary>
        /// Day of week
        /// Serialized Name: ScheduledOperationsTypeUpdate.dayOfWeek
        /// </summary>
        internal DayOfWeekUpdate DayOfWeek { get; set; }
        /// <summary>
        /// Name of the day of the week.
        /// Serialized Name: DayOfWeekUpdate.name
        /// </summary>
        public DayOfWeekName? DayOfWeekName
        {
            get => DayOfWeek is null ? default : DayOfWeek.Name;
            set
            {
                if (DayOfWeek is null)
                    DayOfWeek = new DayOfWeekUpdate();
                DayOfWeek.Name = value;
            }
        }

        /// <summary>
        /// auto start time. value must be of ISO-8601 format HH:mm
        /// Serialized Name: ScheduledOperationsTypeUpdate.scheduledStartTime
        /// </summary>
        public string ScheduledStartTime { get; set; }
        /// <summary>
        /// auto stop time. value must be of ISO-8601 format HH:mm
        /// Serialized Name: ScheduledOperationsTypeUpdate.scheduledStopTime
        /// </summary>
        public string ScheduledStopTime { get; set; }
    }
}
