using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace deploy_util
{
    partial class InitialForm
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
            System.Windows.Forms.Label domainLabel;
            System.Windows.Forms.Label hostIPLabel;
            System.Windows.Forms.Label pathForDeployLabel;
            System.Windows.Forms.Label pathToJarLabel;
            System.Windows.Forms.Label portLabel;
            System.Windows.Forms.Label remoteDiskLabel;
            System.Windows.Forms.Label technologyLabel;
            System.Windows.Forms.Label usernameLabel;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.browseJarFile = new System.Windows.Forms.Button();
            this.browseDeployFolder = new System.Windows.Forms.Button();
            this.configureJasyptKeyCheckBox = new System.Windows.Forms.CheckBox();
            this.backendEntityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.configureNginxCheckBox = new System.Windows.Forms.CheckBox();
            this.configureSSLCheckBox = new System.Windows.Forms.CheckBox();
            this.domainTextBox = new System.Windows.Forms.TextBox();
            this.hostIPTextBox = new System.Windows.Forms.TextBox();
            this.jasyptKeyTextBox = new System.Windows.Forms.TextBox();
            this.pathForDeployTextBox = new System.Windows.Forms.TextBox();
            this.pathToJarTextBox = new System.Windows.Forms.TextBox();
            this.portTextBox = new System.Windows.Forms.TextBox();
            this.remoteDiskComboBox = new System.Windows.Forms.ComboBox();
            this.technologyComboBox = new System.Windows.Forms.ComboBox();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.sideSelect = new System.Windows.Forms.ComboBox();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            domainLabel = new System.Windows.Forms.Label();
            hostIPLabel = new System.Windows.Forms.Label();
            pathForDeployLabel = new System.Windows.Forms.Label();
            pathToJarLabel = new System.Windows.Forms.Label();
            portLabel = new System.Windows.Forms.Label();
            remoteDiskLabel = new System.Windows.Forms.Label();
            technologyLabel = new System.Windows.Forms.Label();
            usernameLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backendEntityBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // domainLabel
            // 
            domainLabel.AutoSize = true;
            domainLabel.Location = new System.Drawing.Point(17, 174);
            domainLabel.Name = "domainLabel";
            domainLabel.Size = new System.Drawing.Size(57, 16);
            domainLabel.TabIndex = 6;
            domainLabel.Text = "Domain:";
            // 
            // hostIPLabel
            // 
            hostIPLabel.AutoSize = true;
            hostIPLabel.Location = new System.Drawing.Point(17, 262);
            hostIPLabel.Name = "hostIPLabel";
            hostIPLabel.Size = new System.Drawing.Size(53, 16);
            hostIPLabel.TabIndex = 8;
            hostIPLabel.Text = "Host IP:";
            // 
            // pathForDeployLabel
            // 
            pathForDeployLabel.AutoSize = true;
            pathForDeployLabel.Location = new System.Drawing.Point(17, 90);
            pathForDeployLabel.Name = "pathForDeployLabel";
            pathForDeployLabel.Size = new System.Drawing.Size(107, 16);
            pathForDeployLabel.TabIndex = 12;
            pathForDeployLabel.Text = "Path For Deploy:";
            // 
            // pathToJarLabel
            // 
            pathToJarLabel.AutoSize = true;
            pathToJarLabel.Location = new System.Drawing.Point(17, 118);
            pathToJarLabel.Name = "pathToJarLabel";
            pathToJarLabel.Size = new System.Drawing.Size(79, 16);
            pathToJarLabel.TabIndex = 14;
            pathToJarLabel.Text = "Path To Jar:";
            // 
            // portLabel
            // 
            portLabel.AutoSize = true;
            portLabel.Location = new System.Drawing.Point(17, 146);
            portLabel.Name = "portLabel";
            portLabel.Size = new System.Drawing.Size(34, 16);
            portLabel.TabIndex = 16;
            portLabel.Text = "Port:";
            // 
            // remoteDiskLabel
            // 
            remoteDiskLabel.AutoSize = true;
            remoteDiskLabel.Location = new System.Drawing.Point(17, 61);
            remoteDiskLabel.Name = "remoteDiskLabel";
            remoteDiskLabel.Size = new System.Drawing.Size(88, 16);
            remoteDiskLabel.TabIndex = 18;
            remoteDiskLabel.Text = "Remote Disk:";
            // 
            // technologyLabel
            // 
            technologyLabel.AutoSize = true;
            technologyLabel.Location = new System.Drawing.Point(17, 31);
            technologyLabel.Name = "technologyLabel";
            technologyLabel.Size = new System.Drawing.Size(82, 16);
            technologyLabel.TabIndex = 20;
            technologyLabel.Text = "Technology:";
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Location = new System.Drawing.Point(17, 290);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new System.Drawing.Size(73, 16);
            usernameLabel.TabIndex = 22;
            usernameLabel.Text = "Username:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.browseJarFile);
            this.groupBox1.Controls.Add(this.browseDeployFolder);
            this.groupBox1.Controls.Add(this.configureJasyptKeyCheckBox);
            this.groupBox1.Controls.Add(this.configureNginxCheckBox);
            this.groupBox1.Controls.Add(this.configureSSLCheckBox);
            this.groupBox1.Controls.Add(domainLabel);
            this.groupBox1.Controls.Add(this.domainTextBox);
            this.groupBox1.Controls.Add(hostIPLabel);
            this.groupBox1.Controls.Add(this.hostIPTextBox);
            this.groupBox1.Controls.Add(this.jasyptKeyTextBox);
            this.groupBox1.Controls.Add(pathForDeployLabel);
            this.groupBox1.Controls.Add(this.pathForDeployTextBox);
            this.groupBox1.Controls.Add(pathToJarLabel);
            this.groupBox1.Controls.Add(this.pathToJarTextBox);
            this.groupBox1.Controls.Add(portLabel);
            this.groupBox1.Controls.Add(this.portTextBox);
            this.groupBox1.Controls.Add(remoteDiskLabel);
            this.groupBox1.Controls.Add(this.remoteDiskComboBox);
            this.groupBox1.Controls.Add(technologyLabel);
            this.groupBox1.Controls.Add(this.technologyComboBox);
            this.groupBox1.Controls.Add(usernameLabel);
            this.groupBox1.Controls.Add(this.usernameTextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(596, 324);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Backend";
            // 
            // browseJarFile
            // 
            this.browseJarFile.Location = new System.Drawing.Point(511, 115);
            this.browseJarFile.Name = "browseJarFile";
            this.browseJarFile.Size = new System.Drawing.Size(75, 23);
            this.browseJarFile.TabIndex = 25;
            this.browseJarFile.Text = "Browse...";
            this.browseJarFile.UseVisualStyleBackColor = true;
            // 
            // browseDeployFolder
            // 
            this.browseDeployFolder.Location = new System.Drawing.Point(511, 87);
            this.browseDeployFolder.Name = "browseDeployFolder";
            this.browseDeployFolder.Size = new System.Drawing.Size(75, 23);
            this.browseDeployFolder.TabIndex = 24;
            this.browseDeployFolder.Text = "Browse...";
            this.browseDeployFolder.UseVisualStyleBackColor = true;
            this.browseDeployFolder.Click += new System.EventHandler(this.browseDeployFolder_Click);
            // 
            // configureJasyptKeyCheckBox
            // 
            this.configureJasyptKeyCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.backendEntityBindingSource, "ConfigureJasyptKey", true));
            this.configureJasyptKeyCheckBox.Location = new System.Drawing.Point(20, 199);
            this.configureJasyptKeyCheckBox.Name = "configureJasyptKeyCheckBox";
            this.configureJasyptKeyCheckBox.Size = new System.Drawing.Size(161, 24);
            this.configureJasyptKeyCheckBox.TabIndex = 1;
            this.configureJasyptKeyCheckBox.Text = "Configure Jasypt Key";
            this.configureJasyptKeyCheckBox.UseVisualStyleBackColor = true;
            // 
            // backendEntityBindingSource
            // 
            this.backendEntityBindingSource.DataSource = typeof(deploy_util.BackendEntity);
            // 
            // configureNginxCheckBox
            // 
            this.configureNginxCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.backendEntityBindingSource, "ConfigureNginx", true));
            this.configureNginxCheckBox.Location = new System.Drawing.Point(20, 229);
            this.configureNginxCheckBox.Name = "configureNginxCheckBox";
            this.configureNginxCheckBox.Size = new System.Drawing.Size(131, 24);
            this.configureNginxCheckBox.TabIndex = 3;
            this.configureNginxCheckBox.Text = "Configure Nginx";
            this.configureNginxCheckBox.UseVisualStyleBackColor = true;
            // 
            // configureSSLCheckBox
            // 
            this.configureSSLCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.backendEntityBindingSource, "ConfigureSSL", true));
            this.configureSSLCheckBox.Location = new System.Drawing.Point(157, 229);
            this.configureSSLCheckBox.Name = "configureSSLCheckBox";
            this.configureSSLCheckBox.Size = new System.Drawing.Size(121, 24);
            this.configureSSLCheckBox.TabIndex = 5;
            this.configureSSLCheckBox.Text = "Configure SSL";
            this.configureSSLCheckBox.UseVisualStyleBackColor = true;
            // 
            // domainTextBox
            // 
            this.domainTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.backendEntityBindingSource, "Domain", true));
            this.domainTextBox.Location = new System.Drawing.Point(159, 171);
            this.domainTextBox.Name = "domainTextBox";
            this.domainTextBox.Size = new System.Drawing.Size(242, 22);
            this.domainTextBox.TabIndex = 7;
            // 
            // hostIPTextBox
            // 
            this.hostIPTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.backendEntityBindingSource, "HostIP", true));
            this.hostIPTextBox.Location = new System.Drawing.Point(159, 259);
            this.hostIPTextBox.Name = "hostIPTextBox";
            this.hostIPTextBox.Size = new System.Drawing.Size(121, 22);
            this.hostIPTextBox.TabIndex = 9;
            // 
            // jasyptKeyTextBox
            // 
            this.jasyptKeyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.backendEntityBindingSource, "JasyptKey", true));
            this.jasyptKeyTextBox.Location = new System.Drawing.Point(187, 199);
            this.jasyptKeyTextBox.Name = "jasyptKeyTextBox";
            this.jasyptKeyTextBox.Size = new System.Drawing.Size(214, 22);
            this.jasyptKeyTextBox.TabIndex = 11;
            // 
            // pathForDeployTextBox
            // 
            this.pathForDeployTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.backendEntityBindingSource, "PathForDeploy", true));
            this.pathForDeployTextBox.Location = new System.Drawing.Point(159, 87);
            this.pathForDeployTextBox.Name = "pathForDeployTextBox";
            this.pathForDeployTextBox.Size = new System.Drawing.Size(346, 22);
            this.pathForDeployTextBox.TabIndex = 13;
            // 
            // pathToJarTextBox
            // 
            this.pathToJarTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.backendEntityBindingSource, "PathToJar", true));
            this.pathToJarTextBox.Location = new System.Drawing.Point(159, 115);
            this.pathToJarTextBox.Name = "pathToJarTextBox";
            this.pathToJarTextBox.Size = new System.Drawing.Size(346, 22);
            this.pathToJarTextBox.TabIndex = 15;
            // 
            // portTextBox
            // 
            this.portTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.backendEntityBindingSource, "Port", true));
            this.portTextBox.Location = new System.Drawing.Point(159, 143);
            this.portTextBox.Name = "portTextBox";
            this.portTextBox.Size = new System.Drawing.Size(121, 22);
            this.portTextBox.TabIndex = 17;
            // 
            // remoteDiskComboBox
            // 
            this.remoteDiskComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.backendEntityBindingSource, "RemoteDisk", true));
            this.remoteDiskComboBox.FormattingEnabled = true;
            this.remoteDiskComboBox.Location = new System.Drawing.Point(159, 58);
            this.remoteDiskComboBox.Name = "remoteDiskComboBox";
            this.remoteDiskComboBox.Size = new System.Drawing.Size(121, 24);
            this.remoteDiskComboBox.TabIndex = 19;
            // 
            // technologyComboBox
            // 
            this.technologyComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.backendEntityBindingSource, "Technology", true));
            this.technologyComboBox.FormattingEnabled = true;
            this.technologyComboBox.Location = new System.Drawing.Point(159, 28);
            this.technologyComboBox.Name = "technologyComboBox";
            this.technologyComboBox.Size = new System.Drawing.Size(121, 24);
            this.technologyComboBox.TabIndex = 21;
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.backendEntityBindingSource, "Username", true));
            this.usernameTextBox.Location = new System.Drawing.Point(159, 287);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(121, 22);
            this.usernameTextBox.TabIndex = 23;
            // 
            // sideSelect
            // 
            this.sideSelect.FormattingEnabled = true;
            this.sideSelect.Location = new System.Drawing.Point(12, 12);
            this.sideSelect.Name = "sideSelect";
            this.sideSelect.Size = new System.Drawing.Size(162, 24);
            this.sideSelect.TabIndex = 1;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // InitialForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 384);
            this.Controls.Add(this.sideSelect);
            this.Controls.Add(this.groupBox1);
            this.Name = "InitialForm";
            this.Text = "Deploy Util";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backendEntityBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private GroupBox groupBox1;
        private ComboBox sideSelect;
        private CheckBox configureJasyptKeyCheckBox;
        private BindingSource backendEntityBindingSource;
        private CheckBox configureNginxCheckBox;
        private CheckBox configureSSLCheckBox;
        private TextBox domainTextBox;
        private TextBox hostIPTextBox;
        private TextBox jasyptKeyTextBox;
        private TextBox pathForDeployTextBox;
        private TextBox pathToJarTextBox;
        private TextBox portTextBox;
        private ComboBox remoteDiskComboBox;
        private ComboBox technologyComboBox;
        private TextBox usernameTextBox;
        private Button browseJarFile;
        private Button browseDeployFolder;
        private FolderBrowserDialog folderBrowserDialog;
        private OpenFileDialog openFileDialog;
    }
}

