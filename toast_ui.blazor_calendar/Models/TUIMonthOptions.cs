﻿namespace toast_ui.blazor_calendar.Models
{
    /// <summary>
    /// https://nhn.github.io/tui.calendar/latest/MonthOptions
    /// </summary>
    public class TUIMonthOptions
    {
        /// <summary>
        /// The day names in monthly. Default values are 'Sun', 'Mon', 'Tue', 'Wed', 'Thu', 'Fri', 'Sat'
        /// </summary>
        public string[] daynames { get; set; }

        /// <summary>
        /// The start day of week
        /// </summary>
        public int startDayOfWeek { get; set; } = 0;

        /// <summary>
        /// Make weekend column narrow(1/2 width)
        /// </summary>
        public bool narrowWeekend { get; set; } = false;

        /// <summary>
        /// The visible week count in monthly
        /// (0 or null are same with 6)
        /// </summary>
        public int visibleWeeksCount { get; set; } = 6;

        /// <summary>
        /// Always show 6 weeks.
        /// If false, show 5 weeks or 6 weeks based on the month.
        /// </summary>
        public bool isAlways6Week { get; set; } = true;

        /// <summary>
        /// Show only 5 days except for weekend
        /// </summary>
        public bool workweek { get; set; } = false;

        /// <summary>
        /// The visible schedule count in monthly grid
        /// </summary>
        public int visibleScheduleCount { get; set; }

        /// <summary>
        /// The more layer size
        /// </summary>
        public object moreLayerSize { get; set; } = null; //@Todo: What is this?

        /// <summary>
        /// The grid's header and footer information
        /// </summary>
        public object grid { get; set; } = null; //@Todo: What is this?

        /// <summary>
        /// The filter schedules on month view.
        /// A parameter is {Schedule} object.
        /// </summary>
        public string scheduleFilter { get; set; } = null; //@Todo: What is this?
    }
}