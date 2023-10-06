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

        private void fillDropDowns()
        {
            List<string> data = new List<string>();
            foreach (DriveInfo d in DriveInfo.GetDrives())
            {
                data.Add(d.Name);
            }
            this.remoteDiskComboBox.DataSource = data;
            data.Clear();
            if (this.sideSelect.Text == "Backend")
            {
                this.technologyComboBox.DataSource = new object[] {"SPRING"};
            } else
            {
                this.technologyComboBox.DataSource = new object[] { "REACT" };
            }
        }

        private void browseDeployFolder_Click(object sender, EventArgs e)
        {
            if (this.folderBrowserDialog.ShowDialog(this) == DialogResult.OK)
            {
                this.pathForDeployTextBox.Text = this.folderBrowserDialog.SelectedPath;
            }
        }
    }
}
