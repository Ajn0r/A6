using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    internal class TaskManager
    {
        #region //// Fields ////
        private List<Task> tasks;
        #endregion

        #region //// Properties ////
        // Property to return the number of tasks
        public int Count
        {
            get { return tasks.Count; }
        }
        // Property to return the list of tasks, but as a copy
        public List<Task> Tasks
        {
            get {
                List<Task> copyList = new List<Task>();
                foreach (Task task in tasks)
                {
                    copyList.Add(task);
                }
                return copyList;
            }
        }
        #endregion

        #region //// Constructors ////
        public TaskManager()
        {
            tasks = new List<Task>();
        }
        #endregion

        #region //// Methods ////
        // Method to add a task to the list
        public bool AddTask(Task task)
        {
            // Check if the task is null
            if (task != null)
            {
                // If task is not null, add the task to the list and return true
                tasks.Add(task);
                return true;
            }
            // else, return false
            return false;
        }
        
        // Overloaded method to add a task to the list by passing in the task's info
        public bool AddTask(DateTime date, string description, PriorityType priority)
        {
            // Create a new task with the info passed in
            Task task = new Task(date, description, priority);
            tasks.Add(task);
            return true;
        }

        // Method to remove a task from the list by the task's index    
        public bool RemoveTask(int index)
        {
            // Check if the index is valid
            if (ValidateIndex(index))
            {
                // If index is valid, remove the task at the index and return true
                tasks.RemoveAt(index);
                return true;
            }
            // If index is not valid, return false
            return false;
        }

        // Method to get the task at a specific index, return a copy of the task
        public Task GetTask(int index)
        {
            // Validate the index
            if (ValidateIndex(index))
            {
                // If index is valid, call the copy constructor of Task and return the copy
                return new Task(tasks[index]);
            }
            // if index is not valid, return null
            return null;
        }

        // Method to validate the index
        private bool ValidateIndex(int index)
        {
            if (index >= 0 && index < tasks.Count)
                return true;
            else
                return false;
        }

        // Method to get the task info
        public string[] GetTaskInfo()
        {
            // String array to hold the task info
            string[] taskInfo = new string[tasks.Count];

            // a foreach loop to get the task info
            int i = 0;
            foreach (Task task in tasks)
            {
                taskInfo[i] = task.ToString();
                i++;
            }
            // return the task info
            return taskInfo;
        }

        #endregion
        #region //// Methods to save and open files////
        // Method to save the tasks in the list to a file  
        public bool SaveTasksToFile(string fileName)
        {
            FileManager fileManager = new FileManager();
            return fileManager.SaveTaskListToFile(fileName, tasks);
        }

        // Method to read the tasks from a file
        public bool ReadTasksFromFile(string fileName)
        {
            tasks.Clear();
            FileManager fileManager = new FileManager();
            return fileManager.ReadTaskListFromFile(fileName, tasks);
        }
        #endregion
    }
}
