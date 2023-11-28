using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    internal class Task
    {
        #region //// Fields ////
        private DateTime date;
        private string description;
        private PriorityType priority;

        #endregion

        #region //// Properties ////
        public DateTime DateAndTime
        {
            get { return date; }
            set { date = value; }
        }
        public string Description
        {
            get { return description; }
            set { 
                // Only set the description if it is not null or empty
                if (!string.IsNullOrEmpty(value))
                    description = value; 
            }
        }
        public PriorityType Priority
        {
            get { return priority; }
            set { priority = value; }
        }
        public DateTime TaskDate
        {
            get { return date.Date; }
            set { date = value.Date; }
        }
        #endregion

        #region //// Constructors ////
        public Task(DateTime date, string description, PriorityType priority)
        {
            this.date = date;
            this.description = description;
            this.priority = priority;
        }
        // Chained constructor with default priority that calls the constructor above
        public Task(DateTime date, string description) : this(date, description, PriorityType.Normal)
        {
        }
        // Default constructor
        public Task()
        {
            priority = PriorityType.Normal;
        }

        // Copy constructor
        public Task(Task task)
        {
            date = task.date;
            description = task.description;
            priority = task.priority;
        }
        #endregion

        #region //// Methods ////

        // Method to get the task as a string formatted to fit in the listbox
        public override string ToString()
        {
            return string.Format(
                "{0, -20} {1, 10} {2, -46}, {3, -20}",
                date.ToLongDateString(),
                GetTimeString(),
                GetPriorityString(),
                description);
        }

        // Method to get the time as a string
        private string GetTimeString()
        {
            // Return the time as a short time string
            return date.ToShortTimeString();
        }

        // Method to get the priority as a string with spaces instead of underscores
        private string GetPriorityString()
        {
            // Replace the underscores with spaces and save the result in a string
            string priorityStr = priority.ToString().Replace('_', ' ');
            // Return the string.
            return priorityStr;
        }
        #endregion
    }
}
