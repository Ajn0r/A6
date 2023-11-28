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
            taskManager = new TaskManager();

            // Set the timer label to the current time

        }

        private void mnuFileExit_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}