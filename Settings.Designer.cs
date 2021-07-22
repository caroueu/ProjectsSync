
namespace ProjectsSync
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.btnServerPath = new System.Windows.Forms.Button();
            this.btnBkpPath = new System.Windows.Forms.Button();
            this.serverLbl = new System.Windows.Forms.Label();
            this.serverFolderPath = new System.Windows.Forms.TextBox();
            this.bkpLbl = new System.Windows.Forms.Label();
            this.backFolderPath = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.exitBtn = new System.Windows.Forms.Label();
            this.save = new System.Windows.Forms.Button();
            this.interval = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.backFolderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.serverFolderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.resetDbFiles = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnServerPath
            // 
            this.btnServerPath.Location = new System.Drawing.Point(503, 87);
            this.btnServerPath.Name = "btnServerPath";
            this.btnServerPath.Size = new System.Drawing.Size(27, 23);
            this.btnServerPath.TabIndex = 12;
            this.btnServerPath.Text = "...";
            this.btnServerPath.UseVisualStyleBackColor = true;
            this.btnServerPath.Click += new System.EventHandler(this.btnServerPath_Click);
            // 
            // btnBkpPath
            // 
            this.btnBkpPath.Location = new System.Drawing.Point(503, 62);
            this.btnBkpPath.Name = "btnBkpPath";
            this.btnBkpPath.Size = new System.Drawing.Size(27, 23);
            this.btnBkpPath.TabIndex = 13;
            this.btnBkpPath.Text = "...";
            this.btnBkpPath.UseVisualStyleBackColor = true;
            this.btnBkpPath.Click += new System.EventHandler(this.btnBkpPath_Click);
            // 
            // serverLbl
            // 
            this.serverLbl.AutoSize = true;
            this.serverLbl.Location = new System.Drawing.Point(16, 92);
            this.serverLbl.Name = "serverLbl";
            this.serverLbl.Size = new System.Drawing.Size(94, 13);
            this.serverLbl.TabIndex = 10;
            this.serverLbl.Text = "Server Folder path";
            // 
            // serverFolderPath
            // 
            this.serverFolderPath.BackColor = System.Drawing.Color.Gainsboro;
            this.serverFolderPath.Location = new System.Drawing.Point(122, 89);
            this.serverFolderPath.Name = "serverFolderPath";
            this.serverFolderPath.Size = new System.Drawing.Size(375, 20);
            this.serverFolderPath.TabIndex = 8;
            // 
            // bkpLbl
            // 
            this.bkpLbl.AutoSize = true;
            this.bkpLbl.Location = new System.Drawing.Point(16, 67);
            this.bkpLbl.Name = "bkpLbl";
            this.bkpLbl.Size = new System.Drawing.Size(100, 13);
            this.bkpLbl.TabIndex = 11;
            this.bkpLbl.Text = "Backup Folder path";
            // 
            // backFolderPath
            // 
            this.backFolderPath.BackColor = System.Drawing.Color.Gainsboro;
            this.backFolderPath.Location = new System.Drawing.Point(122, 64);
            this.backFolderPath.Name = "backFolderPath";
            this.backFolderPath.Size = new System.Drawing.Size(375, 20);
            this.backFolderPath.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 45);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // exitBtn
            // 
            this.exitBtn.AutoSize = true;
            this.exitBtn.BackColor = System.Drawing.Color.Red;
            this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.ForeColor = System.Drawing.Color.White;
            this.exitBtn.Location = new System.Drawing.Point(510, 9);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(17, 17);
            this.exitBtn.TabIndex = 15;
            this.exitBtn.Text = "X";
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(452, 144);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 16;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // interval
            // 
            this.interval.BackColor = System.Drawing.Color.Gainsboro;
            this.interval.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.interval.FormattingEnabled = true;
            this.interval.Items.AddRange(new object[] {
            "Each 5 Minutes",
            "Each 10 Minutes",
            "Each 30 Minutes",
            "Each 1 Hour"});
            this.interval.Location = new System.Drawing.Point(122, 115);
            this.interval.Name = "interval";
            this.interval.Size = new System.Drawing.Size(121, 21);
            this.interval.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Check Interval";
            // 
            // resetDbFiles
            // 
            this.resetDbFiles.Location = new System.Drawing.Point(12, 145);
            this.resetDbFiles.Name = "resetDbFiles";
            this.resetDbFiles.Size = new System.Drawing.Size(112, 23);
            this.resetDbFiles.TabIndex = 18;
            this.resetDbFiles.Text = "Reset DB Files";
            this.resetDbFiles.UseVisualStyleBackColor = true;
            this.resetDbFiles.Click += new System.EventHandler(this.resetDbFiles_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(542, 180);
            this.Controls.Add(this.resetDbFiles);
            this.Controls.Add(this.interval);
            this.Controls.Add(this.save);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnServerPath);
            this.Controls.Add(this.btnBkpPath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.serverLbl);
            this.Controls.Add(this.serverFolderPath);
            this.Controls.Add(this.bkpLbl);
            this.Controls.Add(this.backFolderPath);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Settings";
            this.Text = "Settings";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnServerPath;
        private System.Windows.Forms.Button btnBkpPath;
        private System.Windows.Forms.Label serverLbl;
        private System.Windows.Forms.TextBox serverFolderPath;
        private System.Windows.Forms.Label bkpLbl;
        private System.Windows.Forms.TextBox backFolderPath;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label exitBtn;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.ComboBox interval;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FolderBrowserDialog backFolderDialog;
        private System.Windows.Forms.FolderBrowserDialog serverFolderDialog;
        private System.Windows.Forms.Button resetDbFiles;
    }
}