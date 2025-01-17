// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.SqlVirtualMachine.Models
{
    /// <summary> The Schedule. </summary>
    public partial class Schedule
    {
        /// <summary> Initializes a new instance of Schedule. </summary>
        public Schedule()
        {
        }

        /// <summary> Initializes a new instance of Schedule. </summary>
        /// <param name="enable"> Enable or disable assessment schedule on SQL virtual machine. </param>
        /// <param name="weeklyInterval"> Number of weeks to schedule between 2 assessment runs. Takes value from 1-6. </param>
        /// <param name="monthlyOccurrence"> Occurrence of the DayOfWeek day within a month to schedule assessment. Takes values: 1,2,3,4 and -1. Use -1 for last DayOfWeek day of the month. </param>
        /// <param name="dayOfWeek"> Day of the week to run assessment. </param>
        /// <param name="startTime"> Time of the day in HH:mm format. Eg. 17:30. </param>
        internal Schedule(bool? enable, int? weeklyInterval, int? monthlyOccurrence, AssessmentDayOfWeek? dayOfWeek, string startTime)
        {
            Enable = enable;
            WeeklyInterval = weeklyInterval;
            MonthlyOccurrence = monthlyOccurrence;
            DayOfWeek = dayOfWeek;
            StartTime = startTime;
        }

        /// <summary> Enable or disable assessment schedule on SQL virtual machine. </summary>
        public bool? Enable { get; set; }
        /// <summary> Number of weeks to schedule between 2 assessment runs. Takes value from 1-6. </summary>
        public int? WeeklyInterval { get; set; }
        /// <summary> Occurrence of the DayOfWeek day within a month to schedule assessment. Takes values: 1,2,3,4 and -1. Use -1 for last DayOfWeek day of the month. </summary>
        public int? MonthlyOccurrence { get; set; }
        /// <summary> Day of the week to run assessment. </summary>
        public AssessmentDayOfWeek? DayOfWeek { get; set; }
        /// <summary> Time of the day in HH:mm format. Eg. 17:30. </summary>
        public string StartTime { get; set; }
    }
}
