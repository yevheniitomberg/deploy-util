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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.browseJar = new System.Windows.Forms.Button();
            this.jarPath = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.jasyptCheckbox = new System.Windows.Forms.CheckBox();
            this.jasyptKey = new System.Windows.Forms.TextBox();
            this.deployButton = new System.Windows.Forms.Button();
            this.nginxCheckbox = new System.Windows.Forms.CheckBox();
            this.sslCheckbox = new System.Windows.Forms.CheckBox();
            this.hostIp = new System.Windows.Forms.TextBox();
            this.usernameInput = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.portInput = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.diskSelect = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.browseButton = new System.Windows.Forms.Button();
            this.domainInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pathInput = new System.Windows.Forms.TextBox();
            this.technologySelect = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.browseJar);
            this.groupBox1.Controls.Add(this.jarPath);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.jasyptCheckbox);
            this.groupBox1.Controls.Add(this.jasyptKey);
            this.groupBox1.Controls.Add(this.deployButton);
            this.groupBox1.Controls.Add(this.nginxCheckbox);
            this.groupBox1.Controls.Add(this.sslCheckbox);
            this.groupBox1.Controls.Add(this.hostIp);
            this.groupBox1.Controls.Add(this.usernameInput);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.portInput);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.diskSelect);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.browseButton);
            this.groupBox1.Controls.Add(this.domainInput);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.pathInput);
            this.groupBox1.Controls.Add(this.technologySelect);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 216);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Backend";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // browseJar
            // 
            this.browseJar.Location = new System.Drawing.Point(695, 55);
            this.browseJar.Name = "browseJar";
            this.browseJar.Size = new System.Drawing.Size(75, 23);
            this.browseJar.TabIndex = 24;
            this.browseJar.Text = "Browse...";
            this.browseJar.UseVisualStyleBackColor = true;
            this.browseJar.Click += new System.EventHandler(this.browseJar_Click);
            // 
            // jarPath
            // 
            this.jarPath.Enabled = false;
            this.jarPath.Location = new System.Drawing.Point(78, 55);
            this.jarPath.Name = "jarPath";
            this.jarPath.Size = new System.Drawing.Size(611, 22);
            this.jarPath.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 16);
            this.label6.TabIndex = 22;
            this.label6.Text = "Path to jar";
            // 
            // jasyptCheckbox
            // 
            this.jasyptCheckbox.AutoSize = true;
            this.jasyptCheckbox.Location = new System.Drawing.Point(443, 122);
            this.jasyptCheckbox.Name = "jasyptCheckbox";
            this.jasyptCheckbox.Size = new System.Drawing.Size(94, 20);
            this.jasyptCheckbox.TabIndex = 1;
            this.jasyptCheckbox.Text = "Jasypt key";
            this.jasyptCheckbox.UseVisualStyleBackColor = true;
            this.jasyptCheckbox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // jasyptKey
            // 
            this.jasyptKey.Enabled = false;
            this.jasyptKey.Location = new System.Drawing.Point(543, 122);
            this.jasyptKey.Name = "jasyptKey";
            this.jasyptKey.Size = new System.Drawing.Size(225, 22);
            this.jasyptKey.TabIndex = 21;
            // 
            // deployButton
            // 
            this.deployButton.Location = new System.Drawing.Point(671, 162);
            this.deployButton.Name = "deployButton";
            this.deployButton.Size = new System.Drawing.Size(84, 31);
            this.deployButton.TabIndex = 19;
            this.deployButton.Text = "Deploy";
            this.deployButton.UseVisualStyleBackColor = true;
            // 
            // nginxCheckbox
            // 
            this.nginxCheckbox.AutoSize = true;
            this.nginxCheckbox.Location = new System.Drawing.Point(266, 122);
            this.nginxCheckbox.Name = "nginxCheckbox";
            this.nginxCheckbox.Size = new System.Drawing.Size(130, 20);
            this.nginxCheckbox.TabIndex = 18;
            this.nginxCheckbox.Text = "Configure NGINX";
            this.nginxCheckbox.UseVisualStyleBackColor = true;
            // 
            // sslCheckbox
            // 
            this.sslCheckbox.AutoSize = true;
            this.sslCheckbox.Location = new System.Drawing.Point(146, 125);
            this.sslCheckbox.Name = "sslCheckbox";
            this.sslCheckbox.Size = new System.Drawing.Size(114, 20);
            this.sslCheckbox.TabIndex = 17;
            this.sslCheckbox.Text = "Configure SSL";
            this.sslCheckbox.UseVisualStyleBackColor = true;
            // 
            // hostIp
            // 
            this.hostIp.Location = new System.Drawing.Point(402, 159);
            this.hostIp.Name = "hostIp";
            this.hostIp.Size = new System.Drawing.Size(243, 22);
            this.hostIp.TabIndex = 16;
            // 
            // usernameInput
            // 
            this.usernameInput.Location = new System.Drawing.Point(87, 159);
            this.usernameInput.Name = "usernameInput";
            this.usernameInput.Size = new System.Drawing.Size(223, 22);
            this.usernameInput.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(346, 162);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 16);
            this.label9.TabIndex = 14;
            this.label9.Text = "Host IP";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 162);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 16);
            this.label8.TabIndex = 13;
            this.label8.Text = "Username";
            // 
            // portInput
            // 
            this.portInput.Location = new System.Drawing.Point(44, 122);
            this.portInput.Name = "portInput";
            this.portInput.Size = new System.Drawing.Size(80, 22);
            this.portInput.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Port";
            // 
            // diskSelect
            // 
            this.diskSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.diskSelect.FormattingEnabled = true;
            this.diskSelect.Location = new System.Drawing.Point(686, 17);
            this.diskSelect.Name = "diskSelect";
            this.diskSelect.Size = new System.Drawing.Size(82, 24);
            this.diskSelect.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(597, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Remote disk";
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(695, 87);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(75, 23);
            this.browseButton.TabIndex = 6;
            this.browseButton.Text = "Browse...";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // domainInput
            // 
            this.domainInput.Location = new System.Drawing.Point(342, 22);
            this.domainInput.Name = "domainInput";
            this.domainInput.Size = new System.Drawing.Size(146, 22);
            this.domainInput.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(282, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Domain";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Path for deploy";
            // 
            // pathInput
            // 
            this.pathInput.Enabled = false;
            this.pathInput.Location = new System.Drawing.Point(109, 87);
            this.pathInput.Name = "pathInput";
            this.pathInput.Size = new System.Drawing.Size(580, 22);
            this.pathInput.TabIndex = 2;
            // 
            // technologySelect
            // 
            this.technologySelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.technologySelect.FormattingEnabled = true;
            this.technologySelect.Location = new System.Drawing.Point(92, 19);
            this.technologySelect.Name = "technologySelect";
            this.technologySelect.Size = new System.Drawing.Size(121, 24);
            this.technologySelect.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Technology";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // InitialForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 286);
            this.Controls.Add(this.groupBox1);
            this.Name = "InitialForm";
            this.Text = "Deploy Util";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox technologySelect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox domainInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox pathInput;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.TextBox portInput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox diskSelect;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button deployButton;
        private System.Windows.Forms.CheckBox nginxCheckbox;
        private System.Windows.Forms.CheckBox sslCheckbox;
        private System.Windows.Forms.TextBox hostIp;
        private System.Windows.Forms.TextBox usernameInput;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private TextBox jasyptKey;
        private CheckBox jasyptCheckbox;
        private Button browseJar;
        private TextBox jarPath;
        private Label label6;
        private OpenFileDialog openFileDialog;
    }
}

