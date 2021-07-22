using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using core;

namespace ProjectsSync
{
    public partial class History : Form
    {
        public History()
        {
            InitializeComponent();
            DataTable filesDb = SQLite.QueryResult("SELECT * FROM files ORDER BY id DESC LIMIT 0, 20", "files.db");

            foreach (DataRow row in filesDb.Rows)
            {
                string filePath = row["path"].ToString();
                string fileName = row["name"].ToString();
                string fileDate = row["upload_date"].ToString();
                //DataGridViewLinkCell link = new DataGridViewLinkCell();
                //link.Value = "mamaliga";
                uploadedFilesHistory.Rows.Add(filePath, fileName, fileDate);
                //uploadedFilesHistory.Rows.Add(filePath, link, fileDate);
            }
            
        }

        private void History_Load(object sender, EventArgs e)
        {
            const int margin = 10;
            int x = Screen.PrimaryScreen.WorkingArea.Right -
                this.Width - margin;
            int y = Screen.PrimaryScreen.WorkingArea.Bottom -
                this.Height - margin;
            this.Location = new Point(x, y);
        }

        private void History_Deactivate(object sender, EventArgs e)
        {
            this.Hide();
        }
                
        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (uploadedFilesHistory.SelectedCells.Count > 0)
            {
                int selectedrowindex = uploadedFilesHistory.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = uploadedFilesHistory.Rows[selectedrowindex];

                String filePath = Convert.ToString(selectedRow.Cells["path"].Value);

                FileInfo fileInfo = new FileInfo(filePath);
                string directoryFullPath = fileInfo.DirectoryName;

                System.Diagnostics.Process.Start("explorer.exe", filePath);
                //System.Diagnostics.Process.Start("explorer.exe", directoryFullPath);

                //Console.WriteLine(filePath);
            }
        }

        private void openFileFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (uploadedFilesHistory.SelectedCells.Count > 0)
            {
                int selectedrowindex = uploadedFilesHistory.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = uploadedFilesHistory.Rows[selectedrowindex];

                String filePath = Convert.ToString(selectedRow.Cells["path"].Value);

                FileInfo fileInfo = new FileInfo(filePath);
                string directoryFullPath = fileInfo.DirectoryName;

                //System.Diagnostics.Process.Start("explorer.exe", filePath);
                System.Diagnostics.Process.Start("explorer.exe", directoryFullPath);

                //Console.WriteLine(filePath);
            }
        }
                
        private void uploadedFilesHistory_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (uploadedFilesHistory.SelectedCells.Count > 0)
            {
                int selectedrowindex = uploadedFilesHistory.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = uploadedFilesHistory.Rows[selectedrowindex];

                String filePath = Convert.ToString(selectedRow.Cells["path"].Value);

                FileInfo fileInfo = new FileInfo(filePath);
                string directoryFullPath = fileInfo.DirectoryName;

                //System.Diagnostics.Process.Start("explorer.exe", filePath);
                System.Diagnostics.Process.Start("explorer.exe", directoryFullPath);

                //Console.WriteLine(filePath);
            }
        }
    }
}
