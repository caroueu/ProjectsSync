using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectsSync
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
            interval.Text = CodeToInterval(Properties.Settings.Default.interval);
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            if (backFolderPath.Text.Equals("") || serverFolderPath.Text.Equals(""))
            {
                DialogResult dialogResult = MessageBox.Show("There is no path selected for Backup folder/Server folder. Do whant to retry?", "Atention", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    return;
                }
                else if (dialogResult == DialogResult.No)
                {
                    Application.Exit();
                }
            }
            else
            {
                this.Close();
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            if (backFolderPath.Text.Equals("") || serverFolderPath.Text.Equals(""))
            {
                
                DialogResult dialogResult = MessageBox.Show("There is no path selected for Backup folder/Server folder. Do whant to retry?", "Atention", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    return;
                }
                else if (dialogResult == DialogResult.No)
                {
                    Application.Exit();
                }
            }
            else
            {
                Properties.Settings.Default.pathA = backFolderPath.Text;
                Properties.Settings.Default.pathB = serverFolderPath.Text;
                Properties.Settings.Default.interval = IntervalCode(interval.Text);
                Properties.Settings.Default.Save();
                this.Close();
            }
        }

        private void btnBkpPath_Click(object sender, EventArgs e)
        {
            if (backFolderDialog.ShowDialog() == DialogResult.OK)
            {
                backFolderPath.Text = backFolderDialog.SelectedPath;
            }
        }

        private void btnServerPath_Click(object sender, EventArgs e)
        {
            if (serverFolderDialog.ShowDialog() == DialogResult.OK)
            {
                serverFolderPath.Text = serverFolderDialog.SelectedPath;
            }
        }

        public static int IntervalCode(String _text)
        {
            int value = 0;
            switch (_text)
            {
                case "Each 5 Minutes":
                    value = 1;
                    break;
                case "Each 10 Minutes":
                    value = 2;
                    break;
                case "Each 30 Minutes":
                    value = 3;
                    break;
                case "Each 1 Hour":
                    value = 4;
                    break;
                default:
                    value = 1;
                    break;
            }
            return value;
        }

        public static String CodeToInterval(int _code)
        {
            String _output = "";

            switch (_code)
            {
                case 1:
                    _output = "Each 5 Minutes";
                    break;
                case 2:
                    _output = "Each 10 Minutes";
                    break;
                case 3:
                    _output = "Each 30 Minutes";
                    break;
                case 4:
                    _output = "Each 1 Hour";
                    break;
                default:
                    _output = "Each 5 Minutes";
                    break;
            }
            return _output;

        }

        private void resetDbFiles_Click(object sender, EventArgs e)
        {
            core.SQLite.NonQuery("DELETE * FROM files", "files.db");
        }
    }
}
