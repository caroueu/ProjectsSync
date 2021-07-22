using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;
using System.Threading;
using System.Timers;
using core;

namespace ProjectsSync
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
            // Check if the backup setting are given
            if (Properties.Settings.Default.pathA.Equals("") || Properties.Settings.Default.pathB.Equals(""))
            {
                Thread backupStart = new Thread(BackupFiles);
                backupStart.Abort();
                autoUpload.Stop();
                acction.Image = Properties.Resources.play_40px;
                pauseToolStripMenuItem.Text = "Resume";

                Settings settingsForm = new Settings();
                settingsForm.ShowDialog();
            }
            else
            {
                backFolderPath.Text = Properties.Settings.Default.pathA;
                serverFolderPath.Text = Properties.Settings.Default.pathB;
                autoUpload.Interval = IntervalTime(Properties.Settings.Default.interval);
            }
        }

        // Close Application
        private void sysTryMenuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Close Main Dashboard
        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            Hide();
            sysTry.Visible = true;
        }
        
        private void btnStart_Click(object sender, EventArgs e)
        {
            BackupThread();
        }
        // Backup files
        public void BackupFiles()
        {

            // Read uploaded files from local Database
            Invoke(new Action(() =>
            {
                uploadedFilesHistory.Rows.Clear();
                sysTry.Icon = Properties.Resources.sync;
                synchronizeToolStripMenuItem.Enabled = false;
                status.Text = "UPLOADING";
                btnStart.Enabled = false;
            }));
            
            DataTable filesDb = SQLite.QueryResult("SELECT * FROM files", "files.db");

            // Start backup process
            SQLite.NonQuery("INSERT INTO logs (date, acction_code) VALUES ('" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "','Upload start')", "files.db");
            string pathA = backFolderPath.Text;
            string pathB = serverFolderPath.Text;

            String destPath = "";
            String destFolder = "";

            // Read files from backup folder 
            string[] files = Directory.GetFiles(pathA, "*.*", SearchOption.AllDirectories);

            // Display all the files.
            foreach (string file in files)
            {
                var lastModified = System.IO.File.GetLastWriteTime(file);
                string fileName = Path.GetFileName(file);
                string updateDate = lastModified.ToString("yyyy-MM-dd HH:mm:ss");
                string uploadDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                // Check if file must be uploaded or not
                DataRow[] result = filesDb.Select("path = '" + file + "'");

                String dbFileUpdateDate = "";
                foreach (DataRow row in result)
                {
                    dbFileUpdateDate = row["update_date"].ToString();
                }

                if (!dbFileUpdateDate.Equals(updateDate))
                {
                    SQLite.NonQuery("INSERT INTO files (name, path, update_date, upload_date) VALUES ('" + fileName + "', '" + file + "', '" + updateDate + "', '" + uploadDate + "')", "files.db");
                    SQLite.NonQuery("INSERT INTO logs (date, acction_code) VALUES ('" + uploadDate + "','Upload file " + fileName + "')", "files.db");
                    FileInfo fileInfo = new FileInfo(file);
                    string directoryFullPath = fileInfo.DirectoryName;

                    destFolder = pathB + directoryFullPath.Replace(pathA, "");
                    destPath = pathB + file.Replace(pathA, "");

                    // Create directory on server
                    System.IO.Directory.CreateDirectory(destFolder);
                    File.Copy(file, destPath, true);
                }
            }

            // End backup process
            SQLite.NonQuery("INSERT INTO logs (date, acction_code) VALUES ('" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "','Upload finished')", "files.db");

            Invoke(new Action(() =>
            {
                status.Text = "UPDATED";
                btnStart.Enabled = true;
                sysTry.Icon = Properties.Resources.principal;
                synchronizeToolStripMenuItem.Enabled = true;
            }));

            filesDb = SQLite.QueryResult("SELECT * FROM files ORDER BY id DESC LIMIT 0, 10", "files.db");

            foreach (DataRow row in filesDb.Rows)
            {
                string fileName = row["name"].ToString();
                string fileDate = row["upload_date"].ToString();

                Invoke(new Action(() =>
                {
                    uploadedFilesHistory.Rows.Add(fileName, fileDate);
                }));
            }
        }
        
        public void BackupThread()
        {
            Thread backupStart = new Thread(BackupFiles);
            backupStart.Start();
        }
        
        private void autoUpload_Tick(object sender, EventArgs e)
        {
            BackupThread();
        }
        
        private void settings_Click(object sender, EventArgs e)
        {
            Settings settingsForm = new Settings();
            settingsForm.ShowDialog();
        }
        
        public int IntervalTime(int _code)
        {
            int interval = 0;
            switch (_code)
            {
                case 1:
                    interval = 1000 * 60 * 5;
                    break;
                case 2:
                    interval = 1000 * 60 * 10;
                    break;
                case 3:
                    interval = 1000 * 60 * 30;
                    break;
                case 4:
                    interval = 1000 * 60 * 60;
                    break;
                default:
                    interval = 1000 * 60 * 5;
                    break;
            }
            return interval;

        }

        private void synchronizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackupThread();
        }

        private void pauseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pauseToolStripMenuItem.Text.Equals("Pause"))
            {
                Thread backupStart = new Thread(BackupFiles);
                backupStart.Abort();
                autoUpload.Stop();
                acction.Image = Properties.Resources.play_40px;
                pauseToolStripMenuItem.Text = "Resume";
            }
            else
            {
                Thread backupStart = new Thread(BackupFiles);
                backupStart.Start();
                autoUpload.Start();
                acction.Image = Properties.Resources.pause_40px;
                pauseToolStripMenuItem.Text = "Pause";
            }

        }
        
        private void sysTry_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                History historyForm = new History();
                historyForm.ShowDialog();
            }
        }

        private void acction_Click(object sender, EventArgs e)
        {
            if (pauseToolStripMenuItem.Text.Equals("Pause"))
            {
                Thread backupStart = new Thread(BackupFiles);
                backupStart.Abort();
                autoUpload.Stop();
                acction.Image = Properties.Resources.play_40px;
                pauseToolStripMenuItem.Text = "Resume";
            }
            else
            {
                Thread backupStart = new Thread(BackupFiles);
                backupStart.Start();
                autoUpload.Start();
                acction.Image = Properties.Resources.pause_40px;
                pauseToolStripMenuItem.Text = "Pause";
            }
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Show();
            this.ShowInTaskbar = true;
            this.WindowState = FormWindowState.Normal;
            sysTry.Visible = false;
        }

        private void Start_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            Hide();
            this.ShowInTaskbar = false;
            sysTry.Visible = true;
        }
    }
}
