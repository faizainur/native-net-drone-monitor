#region Copyright Syncfusion Inc. 2001-2018.
// Copyright Syncfusion Inc. 2001-2018. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
namespace native_net_drone_monitor
{
    partial class frmSettings
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
            Syncfusion.Windows.Forms.Tools.TreeNavigator.HeaderCollection headerCollection2 = new Syncfusion.Windows.Forms.Tools.TreeNavigator.HeaderCollection();
            Syncfusion.Windows.Forms.Tools.ActiveStateCollection activeStateCollection2 = new Syncfusion.Windows.Forms.Tools.ActiveStateCollection();
            Syncfusion.Windows.Forms.Tools.InactiveStateCollection inactiveStateCollection2 = new Syncfusion.Windows.Forms.Tools.InactiveStateCollection();
            Syncfusion.Windows.Forms.Tools.ToggleButtonRenderer toggleButtonRenderer2 = new Syncfusion.Windows.Forms.Tools.ToggleButtonRenderer();
            Syncfusion.Windows.Forms.Tools.SliderCollection sliderCollection2 = new Syncfusion.Windows.Forms.Tools.SliderCollection();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.navSettings = new Syncfusion.Windows.Forms.Tools.TreeNavigator();
            this.treeVideoSettings = new Syncfusion.Windows.Forms.Tools.TreeMenuItem();
            this.treeMapsSettings = new Syncfusion.Windows.Forms.Tools.TreeMenuItem();
            this.btnApply = new Syncfusion.Windows.Forms.Tools.TreeMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelVideoSettings = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.toggleSaveVideo = new Syncfusion.Windows.Forms.Tools.ToggleButton();
            this.panelSaveVideo = new System.Windows.Forms.Panel();
            this.cbUseDefault = new System.Windows.Forms.CheckBox();
            this.btnBrowsePath = new Syncfusion.WinForms.Controls.SfButton();
            this.txtPathFolder = new System.Windows.Forms.TextBox();
            this.cmbVIdeoFormat = new Syncfusion.WinForms.ListView.SfComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbAspectRatio = new Syncfusion.WinForms.ListView.SfComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuApparances = new Syncfusion.Windows.Forms.Tools.TreeMenuItem();
            this.treeGeneralSettings = new Syncfusion.Windows.Forms.Tools.TreeMenuItem();
            this.folderBrowserSave = new System.Windows.Forms.FolderBrowserDialog();
            this.panelMapsSettings = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbMapMode = new Syncfusion.WinForms.ListView.SfComboBox();
            this.txtCacheLocation = new System.Windows.Forms.TextBox();
            this.btnBrowseCacheLoc = new Syncfusion.WinForms.Controls.SfButton();
            this.label7 = new System.Windows.Forms.Label();
            this.cbUseDefaultCacheLoc = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelVideoSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toggleSaveVideo)).BeginInit();
            this.panelSaveVideo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbVIdeoFormat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbAspectRatio)).BeginInit();
            this.panelMapsSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbMapMode)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.navSettings);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(637, 528);
            this.splitContainer1.SplitterDistance = 212;
            this.splitContainer1.TabIndex = 0;
            // 
            // navSettings
            // 
            this.navSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            headerCollection2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            headerCollection2.HeaderText = "Settings";
            this.navSettings.Header = headerCollection2;
            this.navSettings.ItemBackColor = System.Drawing.SystemColors.Control;
            this.navSettings.Items.Add(this.treeVideoSettings);
            this.navSettings.Items.Add(this.treeMapsSettings);
            this.navSettings.Items.Add(this.btnApply);
            this.navSettings.Location = new System.Drawing.Point(0, 0);
            this.navSettings.MinimumSize = new System.Drawing.Size(150, 150);
            this.navSettings.Name = "navSettings";
            this.navSettings.Size = new System.Drawing.Size(212, 528);
            this.navSettings.TabIndex = 0;
            this.navSettings.Text = "treeNavigator1";
            this.navSettings.SelectionChanged += new Syncfusion.Windows.Forms.Tools.SelectionStateChangedEventHandler(this.navSettings_SelectionChanged);
            // 
            // treeVideoSettings
            // 
            this.treeVideoSettings.BackColor = System.Drawing.SystemColors.Control;
            this.treeVideoSettings.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeVideoSettings.ItemBackColor = System.Drawing.SystemColors.Control;
            this.treeVideoSettings.Location = new System.Drawing.Point(0, 0);
            this.treeVideoSettings.Name = "treeVideoSettings";
            this.treeVideoSettings.Size = new System.Drawing.Size(208, 50);
            this.treeVideoSettings.TabIndex = 1;
            this.treeVideoSettings.Text = "Video";
            // 
            // treeMapsSettings
            // 
            this.treeMapsSettings.BackColor = System.Drawing.SystemColors.Control;
            this.treeMapsSettings.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeMapsSettings.ItemBackColor = System.Drawing.SystemColors.Control;
            this.treeMapsSettings.Location = new System.Drawing.Point(0, 52);
            this.treeMapsSettings.Name = "treeMapsSettings";
            this.treeMapsSettings.Size = new System.Drawing.Size(208, 50);
            this.treeMapsSettings.TabIndex = 1;
            this.treeMapsSettings.Text = "Maps";
            // 
            // btnApply
            // 
            this.btnApply.BackColor = System.Drawing.SystemColors.Control;
            this.btnApply.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnApply.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApply.ItemBackColor = System.Drawing.SystemColors.Control;
            this.btnApply.Location = new System.Drawing.Point(0, 427);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(210, 50);
            this.btnApply.TabIndex = 1;
            this.btnApply.Text = "Apply";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panelVideoSettings);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(421, 528);
            this.panel1.TabIndex = 0;
            // 
            // panelVideoSettings
            // 
            this.panelVideoSettings.Controls.Add(this.panelMapsSettings);
            this.panelVideoSettings.Controls.Add(this.label5);
            this.panelVideoSettings.Controls.Add(this.toggleSaveVideo);
            this.panelVideoSettings.Controls.Add(this.panelSaveVideo);
            this.panelVideoSettings.Controls.Add(this.cmbAspectRatio);
            this.panelVideoSettings.Controls.Add(this.label2);
            this.panelVideoSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelVideoSettings.Location = new System.Drawing.Point(0, 0);
            this.panelVideoSettings.Name = "panelVideoSettings";
            this.panelVideoSettings.Size = new System.Drawing.Size(421, 528);
            this.panelVideoSettings.TabIndex = 1;
            this.panelVideoSettings.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(31, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 21);
            this.label5.TabIndex = 6;
            this.label5.Text = "Save Video";
            // 
            // toggleSaveVideo
            // 
            this.toggleSaveVideo.ActiveState = activeStateCollection2;
            this.toggleSaveVideo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toggleSaveVideo.ForeColor = System.Drawing.Color.Black;
            inactiveStateCollection2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(151)))), ((int)(((byte)(151)))));
            this.toggleSaveVideo.InactiveState = inactiveStateCollection2;
            this.toggleSaveVideo.Location = new System.Drawing.Point(283, 102);
            this.toggleSaveVideo.MinimumSize = new System.Drawing.Size(52, 20);
            this.toggleSaveVideo.Name = "toggleSaveVideo";
            this.toggleSaveVideo.Renderer = toggleButtonRenderer2;
            this.toggleSaveVideo.Size = new System.Drawing.Size(90, 40);
            this.toggleSaveVideo.Slider = sliderCollection2;
            this.toggleSaveVideo.TabIndex = 5;
            this.toggleSaveVideo.Text = "toggleButton1";
            this.toggleSaveVideo.VisualStyle = Syncfusion.Windows.Forms.Tools.ToggleButtonStyle.Default;
            this.toggleSaveVideo.ToggleStateChanged += new Syncfusion.Windows.Forms.Tools.ToggleStateChangedEventHandler(this.toggleSaveVideo_ToggleStateChanged);
            // 
            // panelSaveVideo
            // 
            this.panelSaveVideo.Controls.Add(this.cbUseDefault);
            this.panelSaveVideo.Controls.Add(this.btnBrowsePath);
            this.panelSaveVideo.Controls.Add(this.txtPathFolder);
            this.panelSaveVideo.Controls.Add(this.cmbVIdeoFormat);
            this.panelSaveVideo.Controls.Add(this.label4);
            this.panelSaveVideo.Controls.Add(this.label3);
            this.panelSaveVideo.Location = new System.Drawing.Point(35, 157);
            this.panelSaveVideo.Name = "panelSaveVideo";
            this.panelSaveVideo.Size = new System.Drawing.Size(349, 163);
            this.panelSaveVideo.TabIndex = 4;
            this.panelSaveVideo.Visible = false;
            // 
            // cbUseDefault
            // 
            this.cbUseDefault.AutoSize = true;
            this.cbUseDefault.Location = new System.Drawing.Point(7, 132);
            this.cbUseDefault.Name = "cbUseDefault";
            this.cbUseDefault.Size = new System.Drawing.Size(101, 17);
            this.cbUseDefault.TabIndex = 13;
            this.cbUseDefault.Text = "Reset to default";
            this.cbUseDefault.UseVisualStyleBackColor = true;
            this.cbUseDefault.CheckedChanged += new System.EventHandler(this.cbUseDefault_CheckedChanged);
            // 
            // btnBrowsePath
            // 
            this.btnBrowsePath.AccessibleName = "Button";
            this.btnBrowsePath.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnBrowsePath.Location = new System.Drawing.Point(312, 98);
            this.btnBrowsePath.Name = "btnBrowsePath";
            this.btnBrowsePath.Size = new System.Drawing.Size(26, 20);
            this.btnBrowsePath.TabIndex = 12;
            this.btnBrowsePath.Text = "...";
            this.btnBrowsePath.Click += new System.EventHandler(this.btnBrowsePath_Click);
            // 
            // txtPathFolder
            // 
            this.txtPathFolder.Location = new System.Drawing.Point(7, 98);
            this.txtPathFolder.Name = "txtPathFolder";
            this.txtPathFolder.ReadOnly = true;
            this.txtPathFolder.Size = new System.Drawing.Size(299, 20);
            this.txtPathFolder.TabIndex = 11;
            // 
            // cmbVIdeoFormat
            // 
            this.cmbVIdeoFormat.Location = new System.Drawing.Point(217, 8);
            this.cmbVIdeoFormat.Name = "cmbVIdeoFormat";
            this.cmbVIdeoFormat.Size = new System.Drawing.Size(121, 28);
            this.cmbVIdeoFormat.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 21);
            this.label4.TabIndex = 9;
            this.label4.Text = "Save video to";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "Video Format";
            // 
            // cmbAspectRatio
            // 
            this.cmbAspectRatio.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cmbAspectRatio.Location = new System.Drawing.Point(252, 37);
            this.cmbAspectRatio.Name = "cmbAspectRatio";
            this.cmbAspectRatio.Size = new System.Drawing.Size(121, 28);
            this.cmbAspectRatio.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Aspect Ratio";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Personalize your settings";
            // 
            // menuApparances
            // 
            this.menuApparances.BackColor = System.Drawing.SystemColors.Control;
            this.menuApparances.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuApparances.ItemBackColor = System.Drawing.SystemColors.Control;
            this.menuApparances.Location = new System.Drawing.Point(0, 52);
            this.menuApparances.Name = "menuApparances";
            this.menuApparances.Size = new System.Drawing.Size(208, 50);
            this.menuApparances.TabIndex = 1;
            this.menuApparances.Text = "Apparances";
            // 
            // treeGeneralSettings
            // 
            this.treeGeneralSettings.BackColor = System.Drawing.SystemColors.Control;
            this.treeGeneralSettings.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeGeneralSettings.ItemBackColor = System.Drawing.SystemColors.Control;
            this.treeGeneralSettings.Location = new System.Drawing.Point(0, 0);
            this.treeGeneralSettings.Name = "treeGeneralSettings";
            this.treeGeneralSettings.Size = new System.Drawing.Size(210, 50);
            this.treeGeneralSettings.TabIndex = 1;
            this.treeGeneralSettings.Text = "General";
            // 
            // panelMapsSettings
            // 
            this.panelMapsSettings.Controls.Add(this.cbUseDefaultCacheLoc);
            this.panelMapsSettings.Controls.Add(this.label7);
            this.panelMapsSettings.Controls.Add(this.btnBrowseCacheLoc);
            this.panelMapsSettings.Controls.Add(this.txtCacheLocation);
            this.panelMapsSettings.Controls.Add(this.cmbMapMode);
            this.panelMapsSettings.Controls.Add(this.label6);
            this.panelMapsSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMapsSettings.Location = new System.Drawing.Point(0, 0);
            this.panelMapsSettings.Name = "panelMapsSettings";
            this.panelMapsSettings.Size = new System.Drawing.Size(421, 528);
            this.panelMapsSettings.TabIndex = 7;
            this.panelMapsSettings.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(38, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 21);
            this.label6.TabIndex = 0;
            this.label6.Text = "Maps Mode";
            // 
            // cmbMapMode
            // 
            this.cmbMapMode.Location = new System.Drawing.Point(252, 29);
            this.cmbMapMode.Name = "cmbMapMode";
            this.cmbMapMode.Size = new System.Drawing.Size(121, 28);
            this.cmbMapMode.TabIndex = 1;
            // 
            // txtCacheLocation
            // 
            this.txtCacheLocation.Location = new System.Drawing.Point(42, 122);
            this.txtCacheLocation.Name = "txtCacheLocation";
            this.txtCacheLocation.ReadOnly = true;
            this.txtCacheLocation.Size = new System.Drawing.Size(298, 20);
            this.txtCacheLocation.TabIndex = 2;
            // 
            // btnBrowseCacheLoc
            // 
            this.btnBrowseCacheLoc.AccessibleName = "Button";
            this.btnBrowseCacheLoc.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnBrowseCacheLoc.Location = new System.Drawing.Point(346, 122);
            this.btnBrowseCacheLoc.Name = "btnBrowseCacheLoc";
            this.btnBrowseCacheLoc.Size = new System.Drawing.Size(31, 20);
            this.btnBrowseCacheLoc.TabIndex = 3;
            this.btnBrowseCacheLoc.Text = "...";
            this.btnBrowseCacheLoc.Click += new System.EventHandler(this.btnBrowseCacheLoc_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(37, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 21);
            this.label7.TabIndex = 4;
            this.label7.Text = "Saved Cache Location";
            // 
            // cbUseDefaultCacheLoc
            // 
            this.cbUseDefaultCacheLoc.AutoSize = true;
            this.cbUseDefaultCacheLoc.Location = new System.Drawing.Point(42, 149);
            this.cbUseDefaultCacheLoc.Name = "cbUseDefaultCacheLoc";
            this.cbUseDefaultCacheLoc.Size = new System.Drawing.Size(80, 17);
            this.cbUseDefaultCacheLoc.TabIndex = 5;
            this.cbUseDefaultCacheLoc.Text = "Use default";
            this.cbUseDefaultCacheLoc.UseVisualStyleBackColor = true;
            this.cbUseDefaultCacheLoc.CheckedChanged += new System.EventHandler(this.cbUseDefaultCacheLoc_CheckedChanged);
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CaptionForeColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(637, 528);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmSettings";
            this.ShowIcon = false;
            this.ShowMaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmSettings_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelVideoSettings.ResumeLayout(false);
            this.panelVideoSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toggleSaveVideo)).EndInit();
            this.panelSaveVideo.ResumeLayout(false);
            this.panelSaveVideo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbVIdeoFormat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbAspectRatio)).EndInit();
            this.panelMapsSettings.ResumeLayout(false);
            this.panelMapsSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbMapMode)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private Syncfusion.Windows.Forms.Tools.TreeNavigator navSettings;
        private Syncfusion.Windows.Forms.Tools.TreeMenuItem treeVideoSettings;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Syncfusion.Windows.Forms.Tools.TreeMenuItem treeMapsSettings;
        private Syncfusion.Windows.Forms.Tools.TreeMenuItem menuApparances;
        private Syncfusion.Windows.Forms.Tools.TreeMenuItem btnApply;
        private System.Windows.Forms.Panel panelVideoSettings;
        private System.Windows.Forms.Label label5;
        private Syncfusion.Windows.Forms.Tools.ToggleButton toggleSaveVideo;
        private System.Windows.Forms.Panel panelSaveVideo;
        private System.Windows.Forms.CheckBox cbUseDefault;
        private Syncfusion.WinForms.Controls.SfButton btnBrowsePath;
        private System.Windows.Forms.TextBox txtPathFolder;
        private Syncfusion.WinForms.ListView.SfComboBox cmbVIdeoFormat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Syncfusion.WinForms.ListView.SfComboBox cmbAspectRatio;
        private System.Windows.Forms.Label label2;
        private Syncfusion.Windows.Forms.Tools.TreeMenuItem treeGeneralSettings;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserSave;
        private System.Windows.Forms.Panel panelMapsSettings;
        private System.Windows.Forms.CheckBox cbUseDefaultCacheLoc;
        private System.Windows.Forms.Label label7;
        private Syncfusion.WinForms.Controls.SfButton btnBrowseCacheLoc;
        private System.Windows.Forms.TextBox txtCacheLocation;
        private Syncfusion.WinForms.ListView.SfComboBox cmbMapMode;
        private System.Windows.Forms.Label label6;
    }
}