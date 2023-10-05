using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace deploy_util
{
    public partial class InitialForm : Form
    {
        public InitialForm()
        {
            InitializeComponent();
            fillDropDowns();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            if (this.folderBrowserDialog.ShowDialog(this) == DialogResult.OK)
            {
                this.pathInput.Text = this.folderBrowserDialog.SelectedPath;
            }
        }
        private void fillDropDowns()
        {
            List<string> disks = new List<string>();
            foreach (DriveInfo d in DriveInfo.GetDrives())
            {
                disks.Add(d.Name);
            }
            this.diskSelect.DataSource = disks;
            this.technologySelect.DataSource = new object[] {"SPRING"};
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            this.jasyptKey.Enabled = this.jasyptCheckbox.Checked;
        }

        private void browseJar_Click(object sender, EventArgs e)
        {
            if (this.openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                this.jarPath.Text = openFileDialog.FileName;
            }
        }
    }
}
