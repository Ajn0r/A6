using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Assignment6
{
    internal class FileManager
    {
        #region //// Fields ////
        #endregion

        #region //// Properties ////
        #endregion

        #region //// Constructors ////
        #endregion

        #region //// Methods ////
        // Method to save the task list to a file
        public bool SaveTaskListToFile(string fileName, List<Task> tasks)
        {
            bool ok = false;
            // Declare a tab character to use as a separator
            string tab = "\t";

            // Create a new stream writer and using the "using" statement
            // to make sure that the stream writer is closed when it is no longer needed
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                foreach (Task task in tasks)
                {
                    // Write the task's info to the file
                    writer.WriteLine(task.DateAndTime + tab + task.Priority + tab + task.Description);
                }
                ok = true;
                writer.Close();
            }
            return ok;
        }

        // Method to read the task list from a file
        public bool ReadTaskListFromFile(string fileName, List<Task> tasks)
        {
            bool ok = false;
            // Declare a tab character to use as a separator
            string tab = "\t";

            // Create a new stream reader and using the "using" statement
            // to make sure that the stream reader is closed when it is no longer needed
            using (StreamReader reader = new StreamReader(fileName))
            {
                // Read the first line of the file
                string line = reader.ReadLine();
                // While the line is not null (there is still more to read)
                while (line != null)
                {
                    // Split the line into an array of strings
                    string[] taskInfo = line.Split(tab);

                    // Create a new task with the info from the file
                    Task task = new Task(Convert.ToDateTime(taskInfo[0]), taskInfo[2], (PriorityType)Enum.Parse(typeof(PriorityType), taskInfo[1]));
                    // Add the task to the list
                    tasks.Add(task);
                    // Read the next line
                    line = reader.ReadLine();
                }
                ok = true;
                reader.Close();
            }

            return ok;
        }
        #endregion
    }
}
