
namespace ProjectsSync
{
    partial class Start
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Start));
            this.sysTry = new System.Windows.Forms.NotifyIcon(this.components);
            this.sysTryMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.synchronizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pauseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sysTryMenuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.backFolderPath = new System.Windows.Forms.TextBox();
            this.bkpLbl = new System.Windows.Forms.Label();
            this.serverFolderPath = new System.Windows.Forms.TextBox();
            this.serverLbl = new System.Windows.Forms.Label();
            this.exitBtn = new System.Windows.Forms.Label();
            this.acction = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.uploadedFilesHistory = new System.Windows.Forms.DataGridView();
            this.fileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uploadDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.Label();
            this.autoUpload = new System.Windows.Forms.Timer(this.components);
            this.settings = new System.Windows.Forms.Button();
            this.sysTryMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uploadedFilesHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // sysTry
            // 
            this.sysTry.ContextMenuStrip = this.sysTryMenu;
            this.sysTry.Icon = ((System.Drawing.Icon)(resources.GetObject("sysTry.Icon")));
            this.sysTry.Text = "ProjectSync";
            this.sysTry.MouseClick += new System.Windows.Forms.MouseEventHandler(this.sysTry_MouseClick);
            // 
            // sysTryMenu
            // 
            this.sysTryMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showToolStripMenuItem,
            this.synchronizeToolStripMenuItem,
            this.pauseToolStripMenuItem,
            this.sysTryMenuExit});
            this.sysTryMenu.Name = "sysTryMenu";
            this.sysTryMenu.Size = new System.Drawing.Size(139, 92);
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.showToolStripMenuItem.Text = "Show";
            this.showToolStripMenuItem.Click += new System.EventHandler(this.showToolStripMenuItem_Click);
            // 
            // synchronizeToolStripMenuItem
            // 
            this.synchronizeToolStripMenuItem.Name = "synchronizeToolStripMenuItem";
            this.synchronizeToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.synchronizeToolStripMenuItem.Text = "Synchronize";
            this.synchronizeToolStripMenuItem.Click += new System.EventHandler(this.synchronizeToolStripMenuItem_Click);
            // 
            // pauseToolStripMenuItem
            // 
            this.pauseToolStripMenuItem.Name = "pauseToolStripMenuItem";
            this.pauseToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.pauseToolStripMenuItem.Text = "Pause";
            this.pauseToolStripMenuItem.Click += new System.EventHandler(this.pauseToolStripMenuItem_Click);
            // 
            // sysTryMenuExit
            // 
            this.sysTryMenuExit.Name = "sysTryMenuExit";
            this.sysTryMenuExit.Size = new System.Drawing.Size(138, 22);
            this.sysTryMenuExit.Text = "Exit";
            this.sysTryMenuExit.Click += new System.EventHandler(this.sysTryMenuExit_Click);
            // 
            // backFolderPath
            // 
            this.backFolderPath.BackColor = System.Drawing.Color.Gainsboro;
            this.backFolderPath.Enabled = false;
            this.backFolderPath.Location = new System.Drawing.Point(118, 82);
            this.backFolderPath.Name = "backFolderPath";
            this.backFolderPath.Size = new System.Drawing.Size(375, 20);
            this.backFolderPath.TabIndex = 0;
            // 
            // bkpLbl
            // 
            this.bkpLbl.AutoSize = true;
            this.bkpLbl.Location = new System.Drawing.Point(12, 85);
            this.bkpLbl.Name = "bkpLbl";
            this.bkpLbl.Size = new System.Drawing.Size(100, 13);
            this.bkpLbl.TabIndex = 1;
            this.bkpLbl.Text = "Backup Folder path";
            // 
            // serverFolderPath
            // 
            this.serverFolderPath.BackColor = System.Drawing.Color.Gainsboro;
            this.serverFolderPath.Enabled = false;
            this.serverFolderPath.Location = new System.Drawing.Point(118, 107);
            this.serverFolderPath.Name = "serverFolderPath";
            this.serverFolderPath.Size = new System.Drawing.Size(375, 20);
            this.serverFolderPath.TabIndex = 0;
            // 
            // serverLbl
            // 
            this.serverLbl.AutoSize = true;
            this.serverLbl.Location = new System.Drawing.Point(12, 110);
            this.serverLbl.Name = "serverLbl";
            this.serverLbl.Size = new System.Drawing.Size(94, 13);
            this.serverLbl.TabIndex = 1;
            this.serverLbl.Text = "Server Folder path";
            // 
            // exitBtn
            // 
            this.exitBtn.AutoSize = true;
            this.exitBtn.BackColor = System.Drawing.Color.Red;
            this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.ForeColor = System.Drawing.Color.White;
            this.exitBtn.Location = new System.Drawing.Point(509, 9);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(17, 17);
            this.exitBtn.TabIndex = 3;
            this.exitBtn.Text = "X";
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // acction
            // 
            this.acction.FlatAppearance.BorderSize = 0;
            this.acction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.acction.Image = global::ProjectsSync.Properties.Resources.pause_40px;
            this.acction.Location = new System.Drawing.Point(228, 319);
            this.acction.Name = "acction";
            this.acction.Size = new System.Drawing.Size(47, 46);
            this.acction.TabIndex = 4;
            this.acction.UseVisualStyleBackColor = true;
            this.acction.Click += new System.EventHandler(this.acction_Click);
            // 
            // btnStart
            // 
            this.btnStart.FlatAppearance.BorderSize = 0;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Image = ((System.Drawing.Image)(resources.GetObject("btnStart.Image")));
            this.btnStart.Location = new System.Drawing.Point(474, 319);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(52, 46);
            this.btnStart.TabIndex = 5;
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // uploadedFilesHistory
            // 
            this.uploadedFilesHistory.AllowUserToAddRows = false;
            this.uploadedFilesHistory.AllowUserToResizeColumns = false;
            this.uploadedFilesHistory.AllowUserToResizeRows = false;
            this.uploadedFilesHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uploadedFilesHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fileName,
            this.uploadDate});
            this.uploadedFilesHistory.Location = new System.Drawing.Point(12, 157);
            this.uploadedFilesHistory.Name = "uploadedFilesHistory";
            this.uploadedFilesHistory.RowHeadersVisible = false;
            this.uploadedFilesHistory.Size = new System.Drawing.Size(514, 156);
            this.uploadedFilesHistory.TabIndex = 6;
            // 
            // fileName
            // 
            this.fileName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fileName.HeaderText = "File";
            this.fileName.Name = "fileName";
            // 
            // uploadDate
            // 
            this.uploadDate.HeaderText = "Uploaded on";
            this.uploadDate.Name = "uploadDate";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Activity History";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Status";
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Location = new System.Drawing.Point(52, 13);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(48, 13);
            this.status.TabIndex = 9;
            this.status.Text = "Updated";
            // 
            // autoUpload
            // 
            this.autoUpload.Enabled = true;
            this.autoUpload.Interval = 60000;
            this.autoUpload.Tick += new System.EventHandler(this.autoUpload_Tick);
            // 
            // settings
            // 
            this.settings.AutoSize = true;
            this.settings.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.settings.BackColor = System.Drawing.Color.Transparent;
            this.settings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.settings.FlatAppearance.BorderSize = 0;
            this.settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settings.Image = ((System.Drawing.Image)(resources.GetObject("settings.Image")));
            this.settings.Location = new System.Drawing.Point(12, 319);
            this.settings.Name = "settings";
            this.settings.Size = new System.Drawing.Size(46, 46);
            this.settings.TabIndex = 10;
            this.settings.UseVisualStyleBackColor = false;
            this.settings.Click += new System.EventHandler(this.settings_Click);
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(538, 377);
            this.Controls.Add(this.settings);
            this.Controls.Add(this.status);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uploadedFilesHistory);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.acction);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.serverLbl);
            this.Controls.Add(this.serverFolderPath);
            this.Controls.Add(this.bkpLbl);
            this.Controls.Add(this.backFolderPath);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Start";
            this.Text = "Projects Backup";
            this.Load += new System.EventHandler(this.Start_Load);
            this.sysTryMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uploadedFilesHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon sysTry;
        private System.Windows.Forms.TextBox backFolderPath;
        private System.Windows.Forms.Label bkpLbl;
        private System.Windows.Forms.TextBox serverFolderPath;
        private System.Windows.Forms.Label serverLbl;
        private System.Windows.Forms.Label exitBtn;
        private System.Windows.Forms.ToolStripMenuItem sysTryMenuExit;
        public System.Windows.Forms.ContextMenuStrip sysTryMenu;
        private System.Windows.Forms.Button acction;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.DataGridView uploadedFilesHistory;
        private System.Windows.Forms.ToolStripMenuItem pauseToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn uploadDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.Timer autoUpload;
        private System.Windows.Forms.Button settings;
        private System.Windows.Forms.ToolStripMenuItem synchronizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
    }
}

