
namespace ProjectsSync
{
    partial class History
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
            this.uploadedFilesHistory = new System.Windows.Forms.DataGridView();
            this.path = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uploadDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fileDetails = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.uploadedFilesHistory)).BeginInit();
            this.fileDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // uploadedFilesHistory
            // 
            this.uploadedFilesHistory.AllowUserToAddRows = false;
            this.uploadedFilesHistory.AllowUserToResizeColumns = false;
            this.uploadedFilesHistory.AllowUserToResizeRows = false;
            this.uploadedFilesHistory.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.uploadedFilesHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uploadedFilesHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.path,
            this.fileName,
            this.uploadDate});
            this.uploadedFilesHistory.ContextMenuStrip = this.fileDetails;
            this.uploadedFilesHistory.Location = new System.Drawing.Point(12, 12);
            this.uploadedFilesHistory.MultiSelect = false;
            this.uploadedFilesHistory.Name = "uploadedFilesHistory";
            this.uploadedFilesHistory.ReadOnly = true;
            this.uploadedFilesHistory.RowHeadersVisible = false;
            this.uploadedFilesHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.uploadedFilesHistory.Size = new System.Drawing.Size(295, 322);
            this.uploadedFilesHistory.TabIndex = 7;
            this.uploadedFilesHistory.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.uploadedFilesHistory_MouseDoubleClick);
            // 
            // path
            // 
            this.path.HeaderText = "path";
            this.path.Name = "path";
            this.path.ReadOnly = true;
            this.path.Visible = false;
            // 
            // fileName
            // 
            this.fileName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fileName.HeaderText = "File";
            this.fileName.Name = "fileName";
            this.fileName.ReadOnly = true;
            this.fileName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // uploadDate
            // 
            this.uploadDate.HeaderText = "Uploaded on";
            this.uploadDate.Name = "uploadDate";
            this.uploadDate.ReadOnly = true;
            // 
            // fileDetails
            // 
            this.fileDetails.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileToolStripMenuItem,
            this.openFileFolderToolStripMenuItem});
            this.fileDetails.Name = "fileDetails";
            this.fileDetails.Size = new System.Drawing.Size(161, 48);
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.openFileToolStripMenuItem.Text = "Open File";
            this.openFileToolStripMenuItem.Click += new System.EventHandler(this.openFileToolStripMenuItem_Click);
            // 
            // openFileFolderToolStripMenuItem
            // 
            this.openFileFolderToolStripMenuItem.Name = "openFileFolderToolStripMenuItem";
            this.openFileFolderToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.openFileFolderToolStripMenuItem.Text = "Open File Folder";
            this.openFileFolderToolStripMenuItem.Click += new System.EventHandler(this.openFileFolderToolStripMenuItem_Click);
            // 
            // History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 346);
            this.Controls.Add(this.uploadedFilesHistory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "History";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "History";
            this.Deactivate += new System.EventHandler(this.History_Deactivate);
            this.Load += new System.EventHandler(this.History_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uploadedFilesHistory)).EndInit();
            this.fileDetails.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView uploadedFilesHistory;
        private System.Windows.Forms.ContextMenuStrip fileDetails;
        private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFileFolderToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn path;
        private System.Windows.Forms.DataGridViewTextBoxColumn fileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn uploadDate;
    }
}