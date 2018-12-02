#region Copyright Syncfusion Inc. 2001-2018.
// Copyright Syncfusion Inc. 2001-2018. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion

using System;
using System.IO;
using System.Reflection;


namespace native_net_drone_monitor
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            Syncfusion.Windows.Forms.Gauge.LinearRange linearRange1 = new Syncfusion.Windows.Forms.Gauge.LinearRange();
            Syncfusion.Windows.Forms.Gauge.LinearRange linearRange2 = new Syncfusion.Windows.Forms.Gauge.LinearRange();
            Syncfusion.Windows.Forms.CaptionImage captionImage1 = new Syncfusion.Windows.Forms.CaptionImage();
            Syncfusion.Windows.Forms.CaptionLabel captionLabel1 = new Syncfusion.Windows.Forms.CaptionLabel();
            Syncfusion.Windows.Forms.CaptionLabel captionLabel2 = new Syncfusion.Windows.Forms.CaptionLabel();
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addDeviceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editDevicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gettingStartedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutThisSoftwareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.checkForUpdatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.tabControlAdv3 = new Syncfusion.Windows.Forms.Tools.TabControlAdv();
            this.tabPageAdv4 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.streamPlayer = new Vlc.DotNet.Forms.VlcControl();
            this.tabPageAdv5 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.tabControlAdv1 = new Syncfusion.Windows.Forms.Tools.TabControlAdv();
            this.tabPageAdv1 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.cmbConnect = new Syncfusion.WinForms.ListView.SfComboBox();
            this.btnDisconnect = new Syncfusion.WinForms.Controls.SfButton();
            this.btnConnectDevices = new Syncfusion.WinForms.Controls.SfButton();
            this.tabControlAdv2 = new Syncfusion.Windows.Forms.Tools.TabControlAdv();
            this.tabPageAdv2 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.altIndicator = new Syncfusion.Windows.Forms.Gauge.LinearGauge();
            this.tabPageAdv3 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.statusStripPanelItem1 = new Syncfusion.Windows.Forms.Tools.StatusStripPanelItem();
            this.cmb = new System.Windows.Forms.ToolStripComboBox();
            this.btnConnect = new Syncfusion.Windows.Forms.Tools.ToolStripPanelItem();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripPanelItem1 = new Syncfusion.Windows.Forms.Tools.ToolStripPanelItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.statusStripPanelItem2 = new Syncfusion.Windows.Forms.Tools.StatusStripPanelItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusIP = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripPanelItem3 = new Syncfusion.Windows.Forms.Tools.ToolStripPanelItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusConnection = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel6 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripPanelItem2 = new Syncfusion.Windows.Forms.Tools.ToolStripPanelItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusLatency = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabControlAdv3)).BeginInit();
            this.tabControlAdv3.SuspendLayout();
            this.tabPageAdv4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.streamPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabControlAdv1)).BeginInit();
            this.tabControlAdv1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbConnect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabControlAdv2)).BeginInit();
            this.tabControlAdv2.SuspendLayout();
            this.tabPageAdv2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuMain
            // 
            this.menuMain.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Size = new System.Drawing.Size(1354, 24);
            this.menuMain.TabIndex = 0;
            this.menuMain.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addDeviceToolStripMenuItem,
            this.editDevicesToolStripMenuItem,
            this.toolStripSeparator2,
            this.refreshToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.toolStripSeparator6,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // addDeviceToolStripMenuItem
            // 
            this.addDeviceToolStripMenuItem.Name = "addDeviceToolStripMenuItem";
            this.addDeviceToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addDeviceToolStripMenuItem.Text = "Add device";
            this.addDeviceToolStripMenuItem.Click += new System.EventHandler(this.addDeviceToolStripMenuItem_Click);
            // 
            // editDevicesToolStripMenuItem
            // 
            this.editDevicesToolStripMenuItem.Name = "editDevicesToolStripMenuItem";
            this.editDevicesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editDevicesToolStripMenuItem.Text = "Edit Devices";
            this.editDevicesToolStripMenuItem.Click += new System.EventHandler(this.editDevicesToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(177, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gettingStartedToolStripMenuItem,
            this.aboutThisSoftwareToolStripMenuItem,
            this.toolStripSeparator1,
            this.checkForUpdatesToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // gettingStartedToolStripMenuItem
            // 
            this.gettingStartedToolStripMenuItem.Name = "gettingStartedToolStripMenuItem";
            this.gettingStartedToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.gettingStartedToolStripMenuItem.Text = "Getting Started";
            // 
            // aboutThisSoftwareToolStripMenuItem
            // 
            this.aboutThisSoftwareToolStripMenuItem.Name = "aboutThisSoftwareToolStripMenuItem";
            this.aboutThisSoftwareToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutThisSoftwareToolStripMenuItem.Text = "About this software";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // checkForUpdatesToolStripMenuItem
            // 
            this.checkForUpdatesToolStripMenuItem.Name = "checkForUpdatesToolStripMenuItem";
            this.checkForUpdatesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.checkForUpdatesToolStripMenuItem.Text = "Check for updates";
            this.checkForUpdatesToolStripMenuItem.Click += new System.EventHandler(this.checkForUpdatesToolStripMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer1.Size = new System.Drawing.Size(1354, 636);
            this.splitContainer1.SplitterDistance = 925;
            this.splitContainer1.TabIndex = 1;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.tabControlAdv3);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.tabControlAdv1);
            this.splitContainer2.Size = new System.Drawing.Size(925, 636);
            this.splitContainer2.SplitterDistance = 420;
            this.splitContainer2.TabIndex = 0;
            // 
            // tabControlAdv3
            // 
            this.tabControlAdv3.ActiveTabFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.tabControlAdv3.ActiveTabForeColor = System.Drawing.Color.Empty;
            this.tabControlAdv3.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControlAdv3.BeforeTouchSize = new System.Drawing.Size(925, 420);
            this.tabControlAdv3.CloseButtonForeColor = System.Drawing.Color.Empty;
            this.tabControlAdv3.CloseButtonHoverForeColor = System.Drawing.Color.Empty;
            this.tabControlAdv3.CloseButtonPressedForeColor = System.Drawing.Color.Empty;
            this.tabControlAdv3.Controls.Add(this.tabPageAdv4);
            this.tabControlAdv3.Controls.Add(this.tabPageAdv5);
            this.tabControlAdv3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlAdv3.InActiveTabForeColor = System.Drawing.Color.Empty;
            this.tabControlAdv3.Location = new System.Drawing.Point(0, 0);
            this.tabControlAdv3.Name = "tabControlAdv3";
            this.tabControlAdv3.SeparatorColor = System.Drawing.SystemColors.ControlDark;
            this.tabControlAdv3.ShowSeparator = false;
            this.tabControlAdv3.Size = new System.Drawing.Size(925, 420);
            this.tabControlAdv3.TabIndex = 0;
            this.tabControlAdv3.TabStyle = typeof(Syncfusion.Windows.Forms.Tools.TabRendererOffice2016White);
            // 
            // tabPageAdv4
            // 
            this.tabPageAdv4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tabPageAdv4.Controls.Add(this.streamPlayer);
            this.tabPageAdv4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.tabPageAdv4.Image = null;
            this.tabPageAdv4.ImageSize = new System.Drawing.Size(16, 16);
            this.tabPageAdv4.Location = new System.Drawing.Point(1, 2);
            this.tabPageAdv4.Name = "tabPageAdv4";
            this.tabPageAdv4.ShowCloseButton = true;
            this.tabPageAdv4.Size = new System.Drawing.Size(922, 396);
            this.tabPageAdv4.TabIndex = 1;
            this.tabPageAdv4.Text = "Video Stream";
            this.tabPageAdv4.ThemesEnabled = false;
            // 
            // streamPlayer
            // 
            this.streamPlayer.AccessibleName = "player";
            this.streamPlayer.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.streamPlayer.BackColor = System.Drawing.Color.Black;
            this.streamPlayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.streamPlayer.Location = new System.Drawing.Point(0, 0);
            this.streamPlayer.Name = "streamPlayer";
            this.streamPlayer.Size = new System.Drawing.Size(922, 396);
            this.streamPlayer.Spu = -1;
            this.streamPlayer.TabIndex = 0;
            this.streamPlayer.Text = "vlcControl1";
            this.streamPlayer.VlcLibDirectory = ((System.IO.DirectoryInfo)(resources.GetObject("streamPlayer.VlcLibDirectory")));
            this.streamPlayer.VlcMediaplayerOptions = null;
            // 
            // tabPageAdv5
            // 
            this.tabPageAdv5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tabPageAdv5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.tabPageAdv5.Image = null;
            this.tabPageAdv5.ImageSize = new System.Drawing.Size(16, 16);
            this.tabPageAdv5.Location = new System.Drawing.Point(1, 2);
            this.tabPageAdv5.Name = "tabPageAdv5";
            this.tabPageAdv5.ShowCloseButton = true;
            this.tabPageAdv5.Size = new System.Drawing.Size(922, 406);
            this.tabPageAdv5.TabIndex = 2;
            this.tabPageAdv5.Text = "GPS / MAPS";
            this.tabPageAdv5.ThemesEnabled = false;
            // 
            // tabControlAdv1
            // 
            this.tabControlAdv1.ActiveTabFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.tabControlAdv1.ActiveTabForeColor = System.Drawing.Color.Empty;
            this.tabControlAdv1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControlAdv1.BeforeTouchSize = new System.Drawing.Size(925, 212);
            this.tabControlAdv1.CloseButtonForeColor = System.Drawing.Color.Empty;
            this.tabControlAdv1.CloseButtonHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.tabControlAdv1.CloseButtonPressedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.tabControlAdv1.Controls.Add(this.tabPageAdv1);
            this.tabControlAdv1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlAdv1.InactiveCloseButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.tabControlAdv1.InActiveTabForeColor = System.Drawing.Color.Empty;
            this.tabControlAdv1.Location = new System.Drawing.Point(0, 0);
            this.tabControlAdv1.Name = "tabControlAdv1";
            this.tabControlAdv1.SeparatorColor = System.Drawing.SystemColors.ControlDark;
            this.tabControlAdv1.ShowCloseButtonForActiveTabOnly = true;
            this.tabControlAdv1.ShowCloseButtonHighLightBackColor = true;
            this.tabControlAdv1.ShowSeparator = false;
            this.tabControlAdv1.Size = new System.Drawing.Size(925, 212);
            this.tabControlAdv1.TabIndex = 0;
            this.tabControlAdv1.TabStyle = typeof(Syncfusion.Windows.Forms.Tools.TabRendererOffice2016Colorful);
            this.tabControlAdv1.VSLikeScrollButton = true;
            // 
            // tabPageAdv1
            // 
            this.tabPageAdv1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tabPageAdv1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.tabPageAdv1.Image = null;
            this.tabPageAdv1.ImageSize = new System.Drawing.Size(16, 16);
            this.tabPageAdv1.Location = new System.Drawing.Point(1, 2);
            this.tabPageAdv1.Name = "tabPageAdv1";
            this.tabPageAdv1.ShowCloseButton = true;
            this.tabPageAdv1.Size = new System.Drawing.Size(922, 188);
            this.tabPageAdv1.TabIndex = 1;
            this.tabPageAdv1.Text = "Messages";
            this.tabPageAdv1.ThemesEnabled = false;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.splitContainer4);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.tabControlAdv2);
            this.splitContainer3.Size = new System.Drawing.Size(425, 636);
            this.splitContainer3.SplitterDistance = 25;
            this.splitContainer3.TabIndex = 0;
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.IsSplitterFixed = true;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Name = "splitContainer4";
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.cmbConnect);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.btnDisconnect);
            this.splitContainer4.Panel2.Controls.Add(this.btnConnectDevices);
            this.splitContainer4.Size = new System.Drawing.Size(425, 25);
            this.splitContainer4.SplitterDistance = 300;
            this.splitContainer4.TabIndex = 0;
            // 
            // cmbConnect
            // 
            this.cmbConnect.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cmbConnect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbConnect.Location = new System.Drawing.Point(0, 0);
            this.cmbConnect.Name = "cmbConnect";
            this.cmbConnect.Size = new System.Drawing.Size(300, 25);
            this.cmbConnect.Style.EditorStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbConnect.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbConnect.TabIndex = 1;
            this.cmbConnect.Text = "Select drone";
            this.cmbConnect.SelectedIndexChanged += new System.EventHandler(this.cmbConnect_SelectedIndexChanged);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.AccessibleName = "Button";
            this.btnDisconnect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDisconnect.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnDisconnect.Location = new System.Drawing.Point(0, 0);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(121, 25);
            this.btnDisconnect.TabIndex = 1;
            this.btnDisconnect.Text = "DISCONNECT";
            this.btnDisconnect.Visible = false;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // btnConnectDevices
            // 
            this.btnConnectDevices.AccessibleName = "Button";
            this.btnConnectDevices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnConnectDevices.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnConnectDevices.Location = new System.Drawing.Point(0, 0);
            this.btnConnectDevices.Name = "btnConnectDevices";
            this.btnConnectDevices.Size = new System.Drawing.Size(121, 25);
            this.btnConnectDevices.TabIndex = 0;
            this.btnConnectDevices.Text = "CONNECT";
            this.btnConnectDevices.Click += new System.EventHandler(this.btnConnectDevices_Click);
            // 
            // tabControlAdv2
            // 
            this.tabControlAdv2.ActiveTabFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.tabControlAdv2.ActiveTabForeColor = System.Drawing.Color.Empty;
            this.tabControlAdv2.Alignment = System.Windows.Forms.TabAlignment.Right;
            this.tabControlAdv2.BeforeTouchSize = new System.Drawing.Size(425, 607);
            this.tabControlAdv2.CloseButtonForeColor = System.Drawing.Color.Empty;
            this.tabControlAdv2.CloseButtonHoverForeColor = System.Drawing.Color.Empty;
            this.tabControlAdv2.CloseButtonPressedForeColor = System.Drawing.Color.Empty;
            this.tabControlAdv2.Controls.Add(this.tabPageAdv2);
            this.tabControlAdv2.Controls.Add(this.tabPageAdv3);
            this.tabControlAdv2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlAdv2.InActiveTabForeColor = System.Drawing.Color.Empty;
            this.tabControlAdv2.Location = new System.Drawing.Point(0, 0);
            this.tabControlAdv2.Name = "tabControlAdv2";
            this.tabControlAdv2.SeparatorColor = System.Drawing.SystemColors.ControlDark;
            this.tabControlAdv2.ShowSeparator = false;
            this.tabControlAdv2.Size = new System.Drawing.Size(425, 607);
            this.tabControlAdv2.TabIndex = 0;
            this.tabControlAdv2.TabStyle = typeof(Syncfusion.Windows.Forms.Tools.TabRendererOffice2016White);
            // 
            // tabPageAdv2
            // 
            this.tabPageAdv2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tabPageAdv2.Controls.Add(this.tableLayoutPanel1);
            this.tabPageAdv2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.tabPageAdv2.Image = null;
            this.tabPageAdv2.ImageSize = new System.Drawing.Size(16, 16);
            this.tabPageAdv2.Location = new System.Drawing.Point(2, 1);
            this.tabPageAdv2.Name = "tabPageAdv2";
            this.tabPageAdv2.ShowCloseButton = true;
            this.tabPageAdv2.Size = new System.Drawing.Size(400, 604);
            this.tabPageAdv2.TabIndex = 1;
            this.tabPageAdv2.Text = "Stats";
            this.tabPageAdv2.ThemesEnabled = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.altIndicator, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.69565F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.30435F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(400, 604);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // altIndicator
            // 
            this.altIndicator.BackgroundGradientEndColor = System.Drawing.Color.White;
            this.altIndicator.BackgroundGradientStartColor = System.Drawing.Color.White;
            this.altIndicator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.altIndicator.ForeColor = System.Drawing.Color.Gray;
            this.altIndicator.GaugelabelFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.altIndicator.InnerFrameGradientEndColor = System.Drawing.Color.White;
            this.altIndicator.InnerFrameGradientStartColor = System.Drawing.Color.White;
            this.altIndicator.LinearFrameType = Syncfusion.Windows.Forms.Gauge.LinearFrameType.Vertical;
            this.altIndicator.Location = new System.Drawing.Point(3, 3);
            this.altIndicator.MajorDifference = 10;
            this.altIndicator.MajorTickMarkColor = System.Drawing.Color.Red;
            this.altIndicator.MajorTicksHeight = 15;
            this.altIndicator.MaximumValue = 50F;
            this.altIndicator.MinimumSize = new System.Drawing.Size(75, 125);
            this.altIndicator.MinorTickCount = 10;
            this.altIndicator.MinorTickHeight = 10;
            this.altIndicator.Name = "altIndicator";
            this.altIndicator.OuterFrameGradientEndColor = System.Drawing.Color.White;
            this.altIndicator.OuterFrameGradientStartColor = System.Drawing.Color.White;
            this.altIndicator.PointerPlacement = Syncfusion.Windows.Forms.Gauge.Placement.Center;
            linearRange1.Color = System.Drawing.Color.Lime;
            linearRange1.EndValue = 20F;
            linearRange1.Height = 5;
            linearRange1.InRange = true;
            linearRange1.Name = "GaugeRange1";
            linearRange1.RangePlacement = Syncfusion.Windows.Forms.Gauge.TickPlacement.Inside;
            linearRange1.StartValue = 0F;
            linearRange2.Color = System.Drawing.Color.Red;
            linearRange2.EndValue = 50F;
            linearRange2.Height = 5;
            linearRange2.InRange = false;
            linearRange2.Name = "GaugeRange2";
            linearRange2.RangePlacement = Syncfusion.Windows.Forms.Gauge.TickPlacement.Inside;
            linearRange2.StartValue = 30F;
            this.altIndicator.Ranges.Add(linearRange1);
            this.altIndicator.Ranges.Add(linearRange2);
            this.altIndicator.ScaleColor = System.Drawing.Color.Gray;
            this.altIndicator.Size = new System.Drawing.Size(194, 288);
            this.altIndicator.TabIndex = 0;
            this.altIndicator.Text = "linearGauge1";
            this.altIndicator.ValueIndicatorColor = System.Drawing.Color.MediumAquamarine;
            // 
            // tabPageAdv3
            // 
            this.tabPageAdv3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tabPageAdv3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.tabPageAdv3.Image = null;
            this.tabPageAdv3.ImageSize = new System.Drawing.Size(16, 16);
            this.tabPageAdv3.Location = new System.Drawing.Point(2, 1);
            this.tabPageAdv3.Name = "tabPageAdv3";
            this.tabPageAdv3.ShowCloseButton = true;
            this.tabPageAdv3.Size = new System.Drawing.Size(400, 619);
            this.tabPageAdv3.TabIndex = 2;
            this.tabPageAdv3.Text = "Tables";
            this.tabPageAdv3.ThemesEnabled = false;
            // 
            // statusStripPanelItem1
            // 
            this.statusStripPanelItem1.CausesValidation = false;
            this.statusStripPanelItem1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.statusStripPanelItem1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmb});
            this.statusStripPanelItem1.Margin = new System.Windows.Forms.Padding(0, 4, 0, 2);
            this.statusStripPanelItem1.Name = "statusStripPanelItem1";
            this.statusStripPanelItem1.Size = new System.Drawing.Size(127, 27);
            this.statusStripPanelItem1.Text = "statusStripPanelItem1";
            this.statusStripPanelItem1.Transparent = true;
            // 
            // cmb
            // 
            this.cmb.Items.AddRange(new object[] {
            "Profile 1",
            "Profile 2"});
            this.cmb.MaxDropDownItems = 10;
            this.cmb.Name = "cmb";
            this.cmb.Size = new System.Drawing.Size(121, 23);
            this.cmb.Text = "Select profile";
            // 
            // btnConnect
            // 
            this.btnConnect.CausesValidation = false;
            this.btnConnect.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnConnect.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(72, 33);
            this.btnConnect.Text = "toolStripPanelItem1";
            this.btnConnect.Transparent = true;
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(68, 23);
            this.toolStripButton1.Text = "Connect";
            // 
            // toolStripPanelItem1
            // 
            this.toolStripPanelItem1.CausesValidation = false;
            this.toolStripPanelItem1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.toolStripPanelItem1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator3});
            this.toolStripPanelItem1.Name = "toolStripPanelItem1";
            this.toolStripPanelItem1.Size = new System.Drawing.Size(8, 33);
            this.toolStripPanelItem1.Text = "toolStripPanelItem1";
            this.toolStripPanelItem1.Transparent = true;
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(4, 23);
            // 
            // statusStripPanelItem2
            // 
            this.statusStripPanelItem2.CausesValidation = false;
            this.statusStripPanelItem2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.statusStripPanelItem2.Margin = new System.Windows.Forms.Padding(0, 4, 0, 2);
            this.statusStripPanelItem2.Name = "statusStripPanelItem2";
            this.statusStripPanelItem2.Size = new System.Drawing.Size(23, 27);
            this.statusStripPanelItem2.Text = "statusStripPanelItem2";
            this.statusStripPanelItem2.Transparent = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.statusIP,
            this.toolStripPanelItem3,
            this.toolStripStatusLabel2,
            this.statusConnection,
            this.toolStripStatusLabel6,
            this.toolStripPanelItem2,
            this.toolStripStatusLabel4,
            this.statusLatency,
            this.toolStripStatusLabel3});
            this.statusStrip1.Location = new System.Drawing.Point(0, 660);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1354, 27);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BackColor = System.Drawing.Color.Transparent;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(23, 22);
            this.toolStripStatusLabel1.Text = "IP :";
            // 
            // statusIP
            // 
            this.statusIP.BackColor = System.Drawing.Color.Transparent;
            this.statusIP.Name = "statusIP";
            this.statusIP.Size = new System.Drawing.Size(52, 22);
            this.statusIP.Text = "192.0.0.1";
            // 
            // toolStripPanelItem3
            // 
            this.toolStripPanelItem3.CausesValidation = false;
            this.toolStripPanelItem3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.toolStripPanelItem3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator5});
            this.toolStripPanelItem3.Name = "toolStripPanelItem3";
            this.toolStripPanelItem3.Size = new System.Drawing.Size(8, 27);
            this.toolStripPanelItem3.Text = "toolStripPanelItem2";
            this.toolStripPanelItem3.Transparent = true;
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(4, 23);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.BackColor = System.Drawing.Color.Transparent;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(45, 22);
            this.toolStripStatusLabel2.Text = "Status :";
            // 
            // statusConnection
            // 
            this.statusConnection.BackColor = System.Drawing.Color.Transparent;
            this.statusConnection.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusConnection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.statusConnection.Name = "statusConnection";
            this.statusConnection.Size = new System.Drawing.Size(76, 22);
            this.statusConnection.Text = "CONNECTED";
            // 
            // toolStripStatusLabel6
            // 
            this.toolStripStatusLabel6.BackColor = System.Drawing.Color.Transparent;
            this.toolStripStatusLabel6.Name = "toolStripStatusLabel6";
            this.toolStripStatusLabel6.Size = new System.Drawing.Size(23, 22);
            this.toolStripStatusLabel6.Text = "ms";
            // 
            // toolStripPanelItem2
            // 
            this.toolStripPanelItem2.CausesValidation = false;
            this.toolStripPanelItem2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.toolStripPanelItem2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator4});
            this.toolStripPanelItem2.Name = "toolStripPanelItem2";
            this.toolStripPanelItem2.Size = new System.Drawing.Size(8, 27);
            this.toolStripPanelItem2.Text = "toolStripPanelItem2";
            this.toolStripPanelItem2.Transparent = true;
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(4, 23);
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.BackColor = System.Drawing.Color.Transparent;
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(54, 22);
            this.toolStripStatusLabel4.Text = "Latency :";
            // 
            // statusLatency
            // 
            this.statusLatency.BackColor = System.Drawing.Color.Transparent;
            this.statusLatency.Name = "statusLatency";
            this.statusLatency.Size = new System.Drawing.Size(13, 22);
            this.statusLatency.Text = "2";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.BackColor = System.Drawing.Color.Transparent;
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(23, 22);
            this.toolStripStatusLabel3.Text = "ms";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1354, 636);
            this.panel1.TabIndex = 3;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BorderColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.BorderThickness = 5;
            this.CaptionBarColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CaptionBarHeight = 75;
            this.CaptionButtonColor = System.Drawing.Color.White;
            this.CaptionButtonHoverColor = System.Drawing.Color.White;
            this.CaptionFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CaptionForeColor = System.Drawing.Color.Black;
            captionImage1.BackColor = System.Drawing.Color.Transparent;
            captionImage1.Image = ((System.Drawing.Image)(resources.GetObject("captionImage1.Image")));
            captionImage1.Location = new System.Drawing.Point(-10, 8);
            captionImage1.Name = "CaptionImage1";
            captionImage1.Size = new System.Drawing.Size(100, 60);
            this.CaptionImages.Add(captionImage1);
            captionLabel1.Font = new System.Drawing.Font("Century Gothic", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            captionLabel1.ForeColor = System.Drawing.Color.White;
            captionLabel1.Location = new System.Drawing.Point(100, 18);
            captionLabel1.Name = "lblProfileNameCapt";
            captionLabel1.Size = new System.Drawing.Size(500, 24);
            captionLabel1.Text = "Drone Monitor";
            captionLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            captionLabel2.ForeColor = System.Drawing.Color.White;
            captionLabel2.Location = new System.Drawing.Point(100, 23);
            captionLabel2.Name = "CaptionLabel1";
            captionLabel2.Size = new System.Drawing.Size(500, 50);
            captionLabel2.Text = "Monitoring Telemetry, Video, etc.";
            this.CaptionLabels.Add(captionLabel1);
            this.CaptionLabels.Add(captionLabel2);
            this.ClientSize = new System.Drawing.Size(1354, 687);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuMain;
            this.Name = "frmMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Drone Monitor";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.VisibleChanged += new System.EventHandler(this.frmMain_VisibleChanged);
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabControlAdv3)).EndInit();
            this.tabControlAdv3.ResumeLayout(false);
            this.tabPageAdv4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.streamPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabControlAdv1)).EndInit();
            this.tabControlAdv1.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmbConnect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabControlAdv2)).EndInit();
            this.tabControlAdv2.ResumeLayout(false);
            this.tabPageAdv2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gettingStartedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutThisSoftwareToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem checkForUpdatesToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private Syncfusion.Windows.Forms.Tools.TabControlAdv tabControlAdv1;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv tabPageAdv1;
        private Syncfusion.Windows.Forms.Tools.TabControlAdv tabControlAdv2;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv tabPageAdv2;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv tabPageAdv3;
        private Syncfusion.Windows.Forms.Tools.TabControlAdv tabControlAdv3;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv tabPageAdv4;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv tabPageAdv5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Syncfusion.Windows.Forms.Tools.StatusStripPanelItem statusStripPanelItem1;
        private System.Windows.Forms.ToolStripComboBox cmb;
        private Syncfusion.Windows.Forms.Tools.ToolStripPanelItem btnConnect;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private Syncfusion.Windows.Forms.Tools.ToolStripPanelItem toolStripPanelItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private Syncfusion.Windows.Forms.Tools.StatusStripPanelItem statusStripPanelItem2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel statusIP;
        private Syncfusion.Windows.Forms.Tools.ToolStripPanelItem toolStripPanelItem3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel statusLatency;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private Syncfusion.Windows.Forms.Tools.ToolStripPanelItem toolStripPanelItem2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem addDeviceToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripStatusLabel statusConnection;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel6;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.Panel panel1;
        private Vlc.DotNet.Forms.VlcControl streamPlayer;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private Syncfusion.WinForms.ListView.SfComboBox cmbConnect;
        private Syncfusion.WinForms.Controls.SfButton btnConnectDevices;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.ToolStripMenuItem editDevicesToolStripMenuItem;
        private Syncfusion.WinForms.Controls.SfButton btnDisconnect;
        private Syncfusion.Windows.Forms.Gauge.LinearGauge altIndicator;
        internal System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
    }
}