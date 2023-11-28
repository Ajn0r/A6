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
    }
}