namespace Assignment6
{
    public partial class MainForm : Form
    {
        private TaskManager taskManager;
        private string fileName = Application.StartupPath + "\\tasks.txt";

        public MainForm()
        {
            InitializeComponent();
            InitializeGUI();
        }

        private void InitializeGUI()
        {
            // Set the title of the form
            this.Text = "ToDo Reminder by Ronja Sjögren";

            // Create a new task manager
            taskManager = new TaskManager();

            // Start the timer
            timer.Start();

            // Clear the listbox
            listBToDo.Items.Clear();

            // Set the default date and time to the current date and time
            dateTimePicker.Value = DateTime.Now;

            // Check if the combo box is empty to prevent it from being filled multiple times
            // if the user clicks on the new option in the menu bar.
            if (comboBPriority.Items.Count == 0)
            {
                // If it is empty, copy the enums to a string array and
                // get rid of the underscores in the names and populte the combo box
                string[] priorityTypes = Enum.GetNames(typeof(PriorityType));
                foreach (string priority in priorityTypes)
                {
                    comboBPriority.Items.Add(priority.Replace("_", " "));
                }
            }
            // Set the default selected item to Normal
            comboBPriority.SelectedIndex = 2;

            // Format the date time picker
            dateTimePicker.Format = DateTimePickerFormat.Custom;
            dateTimePicker.CustomFormat = "yyyy-MM-dd HH:mm";

            // Set the change and delete buttons to disabled
            btnChange.Enabled = false;
            btnDelete.Enabled = false;

            // Set the tool tip for the date time picker
            toolTip.SetToolTip(dateTimePicker, "Click to open the calender for date, write in time here");
            // Set tool tip for the priority combo box
            toolTip.SetToolTip(comboBPriority, "Choose the priority for the task");
        }

        private void UpdateGUI()
        {
            // Clear the listbox
            listBToDo.Items.Clear();

            // Add the tasks to the listbox
            string[] infoTasks = taskManager.GetTaskInfo();
            if (infoTasks != null)
            {
                listBToDo.Items.AddRange(infoTasks);
            }
            // Clear the text box
            txtToDo.Clear();

            // Set the change and delete buttons to disabled
            btnChange.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void mnuFileExit_Click(object sender, EventArgs e)
        {
            // If the user clicks on the exit button, ask if they are sure they want to exit with a yes/no MeesaageBox dialog
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            // If the user clicks on yes, close the form
            if (result == DialogResult.Yes)
            {
                this.Close();
            }

        }

        // Method that updates the time in the timer label every second (every tick which is 1000ms)
        private void clock_Tick(object sender, EventArgs e)
        {
            // Update the timer label with the current time
            lblTimer.Text = DateTime.Now.ToLongTimeString();
        }

        private void mnuFileNew_Click(object sender, EventArgs e)
        {
            InitializeGUI();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // add a new task to the list
            Task task = new Task(dateTimePicker.Value, txtToDo.Text, (PriorityType)comboBPriority.SelectedIndex);
            taskManager.AddTask(task);
            // Update the listbox
            UpdateGUI();
        }

        private void mnuFileSave_Click(object sender, EventArgs e)
        {
            // Save the task list to a file
            bool ok = taskManager.SaveTasksToFile(fileName);
            if (ok)
            {
                MessageBox.Show("Tasks saved successfully!", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Could not save tasks!", "Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mnuFileOpen_Click(object sender, EventArgs e)
        {
            // Check if the file exists before trying to open it
            if (!File.Exists(fileName))
            {
                // If the file does not exist, the user has not saved a file yet and the program will crash if it tries to open the file
                // If it is the case, notify the user with a message box and return
                MessageBox.Show("Could not find a saved file, try saving a ToDo list first or please try again", "Open", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // open the task list from the file and update the listbox if it was successful
            bool ok = taskManager.ReadTasksFromFile(fileName);
            // If the was not successful, display an error message
            if (!ok)
            {
                MessageBox.Show("Could not load tasks!", "Open", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            UpdateGUI();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Check that the user has selected a task to delete
            // The button should be disabled if the user hasn't selected a task, but this is just in case
            if (listBToDo.SelectedIndex >= 0)
            {
                // Ask the user if they are sure they want to delete the task with a yes/no MeesaageBox dialog
                DialogResult result = MessageBox.Show("Are you sure you want to delete this task?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                // If the user clicks on yes, delete the task
                if (result == DialogResult.Yes)
                {
                    // Delete the task, and check if it was successful
                    if (taskManager.RemoveTask(listBToDo.SelectedIndex))
                        // Update the listbox if the task was deleted successfully
                        UpdateGUI();
                    // else, display an error message
                    else
                        MessageBox.Show("Could not delete task, please try again", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a task to delete!", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            // Check that the user has selected a task to change
            // The button should be disabled if the user hasn't selected a task, but this is just in case
            if (listBToDo.SelectedIndex >= 0)
            {
                // Create a new task with the info from the text box and the combo box
                Task task = new Task(dateTimePicker.Value, txtToDo.Text, (PriorityType)comboBPriority.SelectedIndex);
                // Change the task, and check if it was successful
                if (taskManager.ChangeTask(listBToDo.SelectedIndex, task))
                    // Update the listbox if the task was changed successfully
                    UpdateGUI();
                // else, display an error message
                else
                    MessageBox.Show("Could not change task, please try again", "Change", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Please select a task to change!", "Change", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listBToDo_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Check that the user has selected a valid index
            if (listBToDo.SelectedIndex >= 0)
            {
                // Set the change and delete buttons to enabled when the user selects a task
                btnChange.Enabled = true;
                btnDelete.Enabled = true;

                // Get the task at the selected index
                Task task = taskManager.GetTask(listBToDo.SelectedIndex);
                // Check that the GetTask method did not return null
                if (task != null)
                {
                    // Set the date time picker to the date and time of the task
                    dateTimePicker.Value = task.DateAndTime;
                    // Set the text box to the description of the task
                    txtToDo.Text = task.Description;
                    // Set the combo box to the priority of the task
                    comboBPriority.SelectedIndex = (int)task.Priority;
                }
            }
        }

    }
}