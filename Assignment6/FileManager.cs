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
        private const string fileVersionToken = "ToDoReminder_23";
        private const double fileVersion = 1.0;
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
                // Write the file version token and version number to the file
                writer.WriteLine(fileVersionToken + tab + fileVersion);

                // Loop through the list of tasks
                foreach (Task task in tasks)
                {
                    // Write the task's info to the file with the tab character as a separator
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
                // if the first line contains the file version token and version number (the file is the correct version)
                // and the line is not null (then the file is empty)
                if (line != null && line.Contains(fileVersionToken + tab + fileVersion))
                {
                    // Read the next line to get the first task
                    line = reader.ReadLine();
                    // Check if the task list is empty (no tasks at least), so the user get some sort of feedback since the list
                    // box will not be filled with any tasks if the file is empty, so it looks like nothing is happening.
                    if (line == null)
                    {
                        // Let the user know that the file is empty and prompt them to start saving tasks :)
                        MessageBox.Show("The file is empty, start creating tasks now and don't forget to save your list!", "Open", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                } else
                {
                    // If the file version token and version number are not found, return false
                    return false;
                }

                // While the line is not null (there is still more to read)
                while (line != null)
                {
                    // Split the line into an array of strings using the tab character as a separator
                    string[] taskInfo = line.Split(tab);

                    // Create a new task with the info from the file, converting the date string to a DateTime object and the priority string to a PriorityType enum
                    // since they are stored as strings in the file but a Task cannot be created with a string for the date or priority
                    Task task = new Task(Convert.ToDateTime(taskInfo[0]), taskInfo[2], (PriorityType)Enum.Parse(typeof(PriorityType), taskInfo[1]));
                    // Add the task to the list
                    tasks.Add(task);
                    // Read the next line
                    line = reader.ReadLine();
                }
                ok = true;
                // Close the stream reader to be sure that the file is closed
                reader.Close();
            }
            // Return the value of ok
            return ok;
        }
        #endregion
    }
}
