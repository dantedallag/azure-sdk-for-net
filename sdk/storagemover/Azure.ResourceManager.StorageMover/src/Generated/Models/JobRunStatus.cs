// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.StorageMover.Models
{
    /// <summary> The current status of the Job Run in a non-terminal state, if exists. </summary>
    public readonly partial struct JobRunStatus : IEquatable<JobRunStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="JobRunStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public JobRunStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string QueuedValue = "Queued";
        private const string StartedValue = "Started";
        private const string RunningValue = "Running";
        private const string CancelRequestedValue = "CancelRequested";
        private const string CancelingValue = "Canceling";
        private const string CanceledValue = "Canceled";
        private const string FailedValue = "Failed";
        private const string SucceededValue = "Succeeded";

        /// <summary> Queued. </summary>
        public static JobRunStatus Queued { get; } = new JobRunStatus(QueuedValue);
        /// <summary> Started. </summary>
        public static JobRunStatus Started { get; } = new JobRunStatus(StartedValue);
        /// <summary> Running. </summary>
        public static JobRunStatus Running { get; } = new JobRunStatus(RunningValue);
        /// <summary> CancelRequested. </summary>
        public static JobRunStatus CancelRequested { get; } = new JobRunStatus(CancelRequestedValue);
        /// <summary> Canceling. </summary>
        public static JobRunStatus Canceling { get; } = new JobRunStatus(CancelingValue);
        /// <summary> Canceled. </summary>
        public static JobRunStatus Canceled { get; } = new JobRunStatus(CanceledValue);
        /// <summary> Failed. </summary>
        public static JobRunStatus Failed { get; } = new JobRunStatus(FailedValue);
        /// <summary> Succeeded. </summary>
        public static JobRunStatus Succeeded { get; } = new JobRunStatus(SucceededValue);
        /// <summary> Determines if two <see cref="JobRunStatus"/> values are the same. </summary>
        public static bool operator ==(JobRunStatus left, JobRunStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="JobRunStatus"/> values are not the same. </summary>
        public static bool operator !=(JobRunStatus left, JobRunStatus right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="JobRunStatus"/>. </summary>
        public static implicit operator JobRunStatus(string value) => new JobRunStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is JobRunStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(JobRunStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
