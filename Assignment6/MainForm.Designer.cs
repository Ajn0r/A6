namespace Assignment6
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            menuStrip1 = new MenuStrip();
            mnuFile = new ToolStripMenuItem();
            mnuFileNew = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            mnuFileOpen = new ToolStripMenuItem();
            mnuFileSave = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripSeparator();
            mnuFileExit = new ToolStripMenuItem();
            mnuHelp = new ToolStripMenuItem();
            mnuHelpAbout = new ToolStripMenuItem();
            lblDateTime = new Label();
            dateTimePicker = new DateTimePicker();
            lblPriority = new Label();
            comboBPriority = new ComboBox();
            lblToDo = new Label();
            txtToDo = new TextBox();
            btnAdd = new Button();
            grpBToDo = new GroupBox();
            lblListDescription = new Label();
            lblListPriority = new Label();
            lblListHour = new Label();
            lblListDate = new Label();
            listBToDo = new ListBox();
            lblTimer = new Label();
            timer = new System.Windows.Forms.Timer(components);
            openFileDialog = new OpenFileDialog();
            saveFileDialog = new SaveFileDialog();
            menuStrip1.SuspendLayout();
            grpBToDo.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnuFile, mnuHelp });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            mnuFile.DropDownItems.AddRange(new ToolStripItem[] { mnuFileNew, toolStripMenuItem1, mnuFileOpen, mnuFileSave, toolStripMenuItem2, mnuFileExit });
            mnuFile.Name = "mnuFile";
            mnuFile.Size = new Size(37, 20);
            mnuFile.Text = "File";
            // 
            // mnuFileNew
            // 
            mnuFileNew.Name = "mnuFileNew";
            mnuFileNew.ShortcutKeys = Keys.Control | Keys.N;
            mnuFileNew.Size = new Size(141, 22);
            mnuFileNew.Text = "New";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(138, 6);
            // 
            // mnuFileOpen
            // 
            mnuFileOpen.Name = "mnuFileOpen";
            mnuFileOpen.Size = new Size(141, 22);
            mnuFileOpen.Text = "Open file";
            // 
            // mnuFileSave
            // 
            mnuFileSave.Name = "mnuFileSave";
            mnuFileSave.Size = new Size(141, 22);
            mnuFileSave.Text = "Save file";
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(138, 6);
            // 
            // mnuFileExit
            // 
            mnuFileExit.Name = "mnuFileExit";
            mnuFileExit.ShortcutKeys = Keys.Alt | Keys.F4;
            mnuFileExit.Size = new Size(141, 22);
            mnuFileExit.Text = "Exit";
            mnuFileExit.Click += mnuFileExit_Click;
            // 
            // mnuHelp
            // 
            mnuHelp.DropDownItems.AddRange(new ToolStripItem[] { mnuHelpAbout });
            mnuHelp.Name = "mnuHelp";
            mnuHelp.Size = new Size(44, 20);
            mnuHelp.Text = "Help";
            // 
            // mnuHelpAbout
            // 
            mnuHelpAbout.Name = "mnuHelpAbout";
            mnuHelpAbout.Size = new Size(116, 22);
            mnuHelpAbout.Text = "About...";
            // 
            // lblDateTime
            // 
            lblDateTime.AutoSize = true;
            lblDateTime.Location = new Point(12, 46);
            lblDateTime.Name = "lblDateTime";
            lblDateTime.Size = new Size(81, 15);
            lblDateTime.TabIndex = 1;
            lblDateTime.Text = "Date and time";
            // 
            // dateTimePicker
            // 
            dateTimePicker.Location = new Point(109, 42);
            dateTimePicker.MinDate = new DateTime(2023, 11, 28, 11, 36, 52, 0);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(222, 23);
            dateTimePicker.TabIndex = 2;
            dateTimePicker.Value = new DateTime(2023, 11, 28, 11, 36, 52, 0);
            // 
            // lblPriority
            // 
            lblPriority.AutoSize = true;
            lblPriority.Location = new Point(384, 46);
            lblPriority.Name = "lblPriority";
            lblPriority.Size = new Size(45, 15);
            lblPriority.TabIndex = 3;
            lblPriority.Text = "Priority";
            // 
            // comboBPriority
            // 
            comboBPriority.FormattingEnabled = true;
            comboBPriority.Location = new Point(453, 42);
            comboBPriority.Name = "comboBPriority";
            comboBPriority.Size = new Size(145, 23);
            comboBPriority.TabIndex = 4;
            // 
            // lblToDo
            // 
            lblToDo.AutoSize = true;
            lblToDo.Location = new Point(12, 86);
            lblToDo.Name = "lblToDo";
            lblToDo.Size = new Size(36, 15);
            lblToDo.TabIndex = 5;
            lblToDo.Text = "To do";
            // 
            // txtToDo
            // 
            txtToDo.Location = new Point(97, 82);
            txtToDo.Name = "txtToDo";
            txtToDo.Size = new Size(501, 23);
            txtToDo.TabIndex = 6;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(310, 115);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // grpBToDo
            // 
            grpBToDo.Controls.Add(lblListDescription);
            grpBToDo.Controls.Add(lblListPriority);
            grpBToDo.Controls.Add(lblListHour);
            grpBToDo.Controls.Add(lblListDate);
            grpBToDo.Controls.Add(listBToDo);
            grpBToDo.Location = new Point(12, 158);
            grpBToDo.Name = "grpBToDo";
            grpBToDo.Size = new Size(776, 242);
            grpBToDo.TabIndex = 8;
            grpBToDo.TabStop = false;
            grpBToDo.Text = "To Do";
            // 
            // lblListDescription
            // 
            lblListDescription.AutoSize = true;
            lblListDescription.Location = new Point(423, 21);
            lblListDescription.Name = "lblListDescription";
            lblListDescription.Size = new Size(67, 15);
            lblListDescription.TabIndex = 4;
            lblListDescription.Text = "Description";
            // 
            // lblListPriority
            // 
            lblListPriority.AutoSize = true;
            lblListPriority.Location = new Point(231, 21);
            lblListPriority.Name = "lblListPriority";
            lblListPriority.Size = new Size(45, 15);
            lblListPriority.TabIndex = 3;
            lblListPriority.Text = "Priority";
            // 
            // lblListHour
            // 
            lblListHour.AutoSize = true;
            lblListHour.Location = new Point(153, 21);
            lblListHour.Name = "lblListHour";
            lblListHour.Size = new Size(34, 15);
            lblListHour.TabIndex = 2;
            lblListHour.Text = "Hour";
            // 
            // lblListDate
            // 
            lblListDate.AutoSize = true;
            lblListDate.Location = new Point(15, 21);
            lblListDate.Name = "lblListDate";
            lblListDate.Size = new Size(31, 15);
            lblListDate.TabIndex = 1;
            lblListDate.Text = "Date";
            // 
            // listBToDo
            // 
            listBToDo.FormattingEnabled = true;
            listBToDo.ItemHeight = 15;
            listBToDo.Location = new Point(6, 37);
            listBToDo.Name = "listBToDo";
            listBToDo.Size = new Size(764, 199);
            listBToDo.TabIndex = 0;
            // 
            // lblTimer
            // 
            lblTimer.AutoSize = true;
            lblTimer.BorderStyle = BorderStyle.FixedSingle;
            lblTimer.Location = new Point(713, 406);
            lblTimer.MinimumSize = new Size(75, 0);
            lblTimer.Name = "lblTimer";
            lblTimer.Size = new Size(75, 17);
            lblTimer.TabIndex = 9;
            // 
            // timer
            // 
            timer.Interval = 1000;
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog1";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 432);
            Controls.Add(lblTimer);
            Controls.Add(grpBToDo);
            Controls.Add(btnAdd);
            Controls.Add(txtToDo);
            Controls.Add(lblToDo);
            Controls.Add(comboBPriority);
            Controls.Add(lblPriority);
            Controls.Add(dateTimePicker);
            Controls.Add(lblDateTime);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            grpBToDo.ResumeLayout(false);
            grpBToDo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnuFile;
        private ToolStripMenuItem mnuFileNew;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem mnuFileOpen;
        private ToolStripMenuItem mnuFileSave;
        private ToolStripSeparator toolStripMenuItem2;
        private ToolStripMenuItem mnuFileExit;
        private ToolStripMenuItem mnuHelp;
        private ToolStripMenuItem mnuHelpAbout;
        private Label lblDateTime;
        private DateTimePicker dateTimePicker;
        private Label lblPriority;
        private ComboBox comboBPriority;
        private Label lblToDo;
        private TextBox txtToDo;
        private Button btnAdd;
        private GroupBox grpBToDo;
        private ListBox listBToDo;
        private Label lblListDescription;
        private Label lblListPriority;
        private Label lblListHour;
        private Label lblListDate;
        private Label lblTimer;
        private System.Windows.Forms.Timer timer;
        private OpenFileDialog openFileDialog;
        private SaveFileDialog saveFileDialog;
    }
}