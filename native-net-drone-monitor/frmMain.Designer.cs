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
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn1 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn2 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn3 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn4 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn5 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn6 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn7 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn8 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.Windows.Forms.CaptionImage captionImage1 = new Syncfusion.Windows.Forms.CaptionImage();
            Syncfusion.Windows.Forms.CaptionLabel captionLabel1 = new Syncfusion.Windows.Forms.CaptionLabel();
            Syncfusion.Windows.Forms.CaptionLabel captionLabel2 = new Syncfusion.Windows.Forms.CaptionLabel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.tabControlAdv3 = new Syncfusion.Windows.Forms.Tools.TabControlAdv();
            this.videoStreamTab = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.streamPlayer = new Vlc.DotNet.Forms.VlcControl();
            this.GPSTab = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.MessagesTab = new Syncfusion.Windows.Forms.Tools.TabControlAdv();
            this.tabPageAdv1 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.LogTab = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.sfDataGrid1 = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.GraphTab = new Syncfusion.Windows.Forms.Tools.TabControlAdv();
            this.tabPageAdv2 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.altIndicator = new Syncfusion.Windows.Forms.Gauge.LinearGauge();
            this.TablesTab = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.cmbConnect = new Syncfusion.WinForms.ListView.SfComboBox();
            this.btnDisconnect = new Syncfusion.WinForms.Controls.SfButton();
            this.btnConnectDevices = new Syncfusion.WinForms.Controls.SfButton();
            this.statusStripPanelItem1 = new Syncfusion.Windows.Forms.Tools.StatusStripPanelItem();
            this.cmb = new System.Windows.Forms.ToolStripComboBox();
            this.btnConnect = new Syncfusion.Windows.Forms.Tools.ToolStripPanelItem();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripPanelItem1 = new Syncfusion.Windows.Forms.Tools.ToolStripPanelItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.statusStripPanelItem2 = new Syncfusion.Windows.Forms.Tools.StatusStripPanelItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLblLatencyUnit = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusLatency = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusLblLatency = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripPanelItem3 = new Syncfusion.Windows.Forms.Tools.ToolStripPanelItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.statusConnection = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripPanelItem2 = new Syncfusion.Windows.Forms.Tools.ToolStripPanelItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.statusIP = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusLblIP = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.splitContainer5 = new System.Windows.Forms.SplitContainer();
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAddDevice = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditDevices = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOpenLogs = new System.Windows.Forms.ToolStripMenuItem();
            this.exportLogsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExPdf = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExExcel = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.menuFlightAnalyzer = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuGettingStarted = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuCheckUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
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
            this.videoStreamTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.streamPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MessagesTab)).BeginInit();
            this.MessagesTab.SuspendLayout();
            this.LogTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sfDataGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GraphTab)).BeginInit();
            this.GraphTab.SuspendLayout();
            this.tabPageAdv2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbConnect)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).BeginInit();
            this.splitContainer5.Panel1.SuspendLayout();
            this.splitContainer5.Panel2.SuspendLayout();
            this.splitContainer5.SuspendLayout();
            this.menuMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.GraphTab);
            this.splitContainer1.Size = new System.Drawing.Size(1354, 631);
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
            this.splitContainer2.Panel2.Controls.Add(this.MessagesTab);
            this.splitContainer2.Size = new System.Drawing.Size(925, 631);
            this.splitContainer2.SplitterDistance = 417;
            this.splitContainer2.TabIndex = 0;
            // 
            // tabControlAdv3
            // 
            this.tabControlAdv3.ActiveTabFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.tabControlAdv3.ActiveTabForeColor = System.Drawing.Color.Empty;
            this.tabControlAdv3.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControlAdv3.BeforeTouchSize = new System.Drawing.Size(925, 417);
            this.tabControlAdv3.CloseButtonForeColor = System.Drawing.Color.Empty;
            this.tabControlAdv3.CloseButtonHoverForeColor = System.Drawing.Color.Empty;
            this.tabControlAdv3.CloseButtonPressedForeColor = System.Drawing.Color.Empty;
            this.tabControlAdv3.Controls.Add(this.videoStreamTab);
            this.tabControlAdv3.Controls.Add(this.GPSTab);
            this.tabControlAdv3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlAdv3.InActiveTabForeColor = System.Drawing.Color.Empty;
            this.tabControlAdv3.Location = new System.Drawing.Point(0, 0);
            this.tabControlAdv3.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.tabControlAdv3.Name = "tabControlAdv3";
            this.tabControlAdv3.Padding = new System.Drawing.Point(6, 5);
            this.tabControlAdv3.SeparatorColor = System.Drawing.SystemColors.ControlDark;
            this.tabControlAdv3.ShowSeparator = false;
            this.tabControlAdv3.Size = new System.Drawing.Size(925, 417);
            this.tabControlAdv3.TabIndex = 0;
            this.tabControlAdv3.TabStyle = typeof(Syncfusion.Windows.Forms.Tools.TabRendererOffice2016White);
            // 
            // videoStreamTab
            // 
            this.videoStreamTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.videoStreamTab.Controls.Add(this.streamPlayer);
            this.videoStreamTab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.videoStreamTab.Image = null;
            this.videoStreamTab.ImageSize = new System.Drawing.Size(16, 16);
            this.videoStreamTab.Location = new System.Drawing.Point(1, 2);
            this.videoStreamTab.Name = "videoStreamTab";
            this.videoStreamTab.ShowCloseButton = true;
            this.videoStreamTab.Size = new System.Drawing.Size(922, 389);
            this.videoStreamTab.TabIndex = 1;
            this.videoStreamTab.Text = "Video Stream";
            this.videoStreamTab.ThemesEnabled = false;
            // 
            // streamPlayer
            // 
            this.streamPlayer.AccessibleName = "player";
            this.streamPlayer.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.streamPlayer.BackColor = System.Drawing.Color.Black;
            this.streamPlayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.streamPlayer.Location = new System.Drawing.Point(0, 0);
            this.streamPlayer.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.streamPlayer.Name = "streamPlayer";
            this.streamPlayer.Size = new System.Drawing.Size(922, 389);
            this.streamPlayer.Spu = -1;
            this.streamPlayer.TabIndex = 0;
            this.streamPlayer.Text = "vlcControl1";
            this.streamPlayer.VlcLibDirectory = ((System.IO.DirectoryInfo)(resources.GetObject("streamPlayer.VlcLibDirectory")));
            this.streamPlayer.VlcMediaplayerOptions = null;
            // 
            // GPSTab
            // 
            this.GPSTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GPSTab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.GPSTab.Image = null;
            this.GPSTab.ImageSize = new System.Drawing.Size(16, 16);
            this.GPSTab.Location = new System.Drawing.Point(1, 2);
            this.GPSTab.Name = "GPSTab";
            this.GPSTab.ShowCloseButton = true;
            this.GPSTab.Size = new System.Drawing.Size(922, 389);
            this.GPSTab.TabIndex = 2;
            this.GPSTab.Text = "GPS / MAPS";
            this.GPSTab.ThemesEnabled = false;
            // 
            // MessagesTab
            // 
            this.MessagesTab.ActiveTabFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.MessagesTab.ActiveTabForeColor = System.Drawing.Color.Empty;
            this.MessagesTab.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.MessagesTab.BeforeTouchSize = new System.Drawing.Size(925, 210);
            this.MessagesTab.CloseButtonForeColor = System.Drawing.Color.Empty;
            this.MessagesTab.CloseButtonHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.MessagesTab.CloseButtonPressedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.MessagesTab.Controls.Add(this.tabPageAdv1);
            this.MessagesTab.Controls.Add(this.LogTab);
            this.MessagesTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MessagesTab.InactiveCloseButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.MessagesTab.InActiveTabForeColor = System.Drawing.Color.Empty;
            this.MessagesTab.Location = new System.Drawing.Point(0, 0);
            this.MessagesTab.Name = "MessagesTab";
            this.MessagesTab.SeparatorColor = System.Drawing.SystemColors.ControlDark;
            this.MessagesTab.ShowCloseButtonForActiveTabOnly = true;
            this.MessagesTab.ShowCloseButtonHighLightBackColor = true;
            this.MessagesTab.ShowSeparator = false;
            this.MessagesTab.Size = new System.Drawing.Size(925, 210);
            this.MessagesTab.TabIndex = 0;
            this.MessagesTab.TabStyle = typeof(Syncfusion.Windows.Forms.Tools.TabRendererOffice2016Colorful);
            this.MessagesTab.VSLikeScrollButton = true;
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
            this.tabPageAdv1.Size = new System.Drawing.Size(922, 186);
            this.tabPageAdv1.TabIndex = 1;
            this.tabPageAdv1.Text = "Messages";
            this.tabPageAdv1.ThemesEnabled = false;
            // 
            // LogTab
            // 
            this.LogTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.LogTab.Controls.Add(this.sfDataGrid1);
            this.LogTab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.LogTab.Image = null;
            this.LogTab.ImageSize = new System.Drawing.Size(16, 16);
            this.LogTab.Location = new System.Drawing.Point(1, 2);
            this.LogTab.Name = "LogTab";
            this.LogTab.ShowCloseButton = true;
            this.LogTab.Size = new System.Drawing.Size(922, 186);
            this.LogTab.TabIndex = 2;
            this.LogTab.Text = "Logs";
            this.LogTab.ThemesEnabled = false;
            // 
            // sfDataGrid1
            // 
            this.sfDataGrid1.AccessibleName = "Table";
            gridTextColumn1.HeaderText = "Time";
            gridTextColumn1.MappingName = "Time";
            gridTextColumn2.HeaderText = "Alt";
            gridTextColumn2.MappingName = "Alt";
            gridTextColumn3.HeaderText = "Long";
            gridTextColumn3.MappingName = "Long";
            gridTextColumn4.HeaderText = "Lat";
            gridTextColumn4.MappingName = "Lat";
            gridTextColumn5.HeaderText = "Vx";
            gridTextColumn5.MappingName = "Vx";
            gridTextColumn6.HeaderText = "Vy";
            gridTextColumn6.MappingName = "Vy";
            gridTextColumn7.HeaderText = "GPS";
            gridTextColumn7.MappingName = "GPS";
            gridTextColumn8.HeaderText = "Camera";
            gridTextColumn8.MappingName = "Camera";
            this.sfDataGrid1.Columns.Add(gridTextColumn1);
            this.sfDataGrid1.Columns.Add(gridTextColumn2);
            this.sfDataGrid1.Columns.Add(gridTextColumn3);
            this.sfDataGrid1.Columns.Add(gridTextColumn4);
            this.sfDataGrid1.Columns.Add(gridTextColumn5);
            this.sfDataGrid1.Columns.Add(gridTextColumn6);
            this.sfDataGrid1.Columns.Add(gridTextColumn7);
            this.sfDataGrid1.Columns.Add(gridTextColumn8);
            this.sfDataGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sfDataGrid1.Location = new System.Drawing.Point(0, 0);
            this.sfDataGrid1.Name = "sfDataGrid1";
            this.sfDataGrid1.Size = new System.Drawing.Size(922, 186);
            this.sfDataGrid1.TabIndex = 0;
            this.sfDataGrid1.Text = "sfDataGrid1";
            // 
            // GraphTab
            // 
            this.GraphTab.ActiveTabFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.GraphTab.ActiveTabForeColor = System.Drawing.Color.Empty;
            this.GraphTab.Alignment = System.Windows.Forms.TabAlignment.Right;
            this.GraphTab.BeforeTouchSize = new System.Drawing.Size(425, 631);
            this.GraphTab.CloseButtonForeColor = System.Drawing.Color.Empty;
            this.GraphTab.CloseButtonHoverForeColor = System.Drawing.Color.Empty;
            this.GraphTab.CloseButtonPressedForeColor = System.Drawing.Color.Empty;
            this.GraphTab.Controls.Add(this.tabPageAdv2);
            this.GraphTab.Controls.Add(this.TablesTab);
            this.GraphTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GraphTab.InActiveTabForeColor = System.Drawing.Color.Empty;
            this.GraphTab.Location = new System.Drawing.Point(0, 0);
            this.GraphTab.Name = "GraphTab";
            this.GraphTab.SeparatorColor = System.Drawing.SystemColors.ControlDark;
            this.GraphTab.ShowSeparator = false;
            this.GraphTab.Size = new System.Drawing.Size(425, 631);
            this.GraphTab.TabIndex = 0;
            this.GraphTab.TabStyle = typeof(Syncfusion.Windows.Forms.Tools.TabRendererOffice2016White);
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
            this.tabPageAdv2.Size = new System.Drawing.Size(400, 628);
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(400, 628);
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
            this.altIndicator.MaximumSize = new System.Drawing.Size(281, 436);
            this.altIndicator.MaximumValue = 50F;
            this.altIndicator.MinimumSize = new System.Drawing.Size(75, 125);
            this.altIndicator.MinorTickCount = 10;
            this.altIndicator.MinorTickHeight = 10;
            this.altIndicator.Name = "altIndicator";
            this.altIndicator.NeedleColor = System.Drawing.SystemColors.Highlight;
            this.altIndicator.OuterFrameGradientEndColor = System.Drawing.Color.White;
            this.altIndicator.OuterFrameGradientStartColor = System.Drawing.Color.White;
            this.altIndicator.PointerPlacement = Syncfusion.Windows.Forms.Gauge.Placement.Center;
            this.altIndicator.ScaleColor = System.Drawing.Color.Transparent;
            this.altIndicator.Size = new System.Drawing.Size(194, 299);
            this.altIndicator.TabIndex = 0;
            this.altIndicator.Text = "linearGauge1";
            this.altIndicator.ValueIndicatorColor = System.Drawing.Color.MediumAquamarine;
            // 
            // TablesTab
            // 
            this.TablesTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TablesTab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.TablesTab.Image = null;
            this.TablesTab.ImageSize = new System.Drawing.Size(16, 16);
            this.TablesTab.Location = new System.Drawing.Point(2, 1);
            this.TablesTab.Name = "TablesTab";
            this.TablesTab.ShowCloseButton = true;
            this.TablesTab.Size = new System.Drawing.Size(400, 628);
            this.TablesTab.TabIndex = 2;
            this.TablesTab.Text = "Tables";
            this.TablesTab.ThemesEnabled = false;
            // 
            // cmbConnect
            // 
            this.cmbConnect.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cmbConnect.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cmbConnect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbConnect.Location = new System.Drawing.Point(0, 3);
            this.cmbConnect.Name = "cmbConnect";
            this.cmbConnect.Size = new System.Drawing.Size(285, 22);
            this.cmbConnect.Style.EditorStyle.BackColor = System.Drawing.SystemColors.ButtonHighlight;
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
            this.btnDisconnect.Location = new System.Drawing.Point(0, 3);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(129, 22);
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
            this.btnConnectDevices.Location = new System.Drawing.Point(0, 3);
            this.btnConnectDevices.Name = "btnConnectDevices";
            this.btnConnectDevices.Size = new System.Drawing.Size(129, 22);
            this.btnConnectDevices.TabIndex = 0;
            this.btnConnectDevices.Text = "CONNECT";
            this.btnConnectDevices.Click += new System.EventHandler(this.btnConnectDevices_Click);
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
            this.statusLblLatencyUnit,
            this.statusLatency,
            this.statusLblLatency,
            this.toolStripPanelItem3,
            this.statusConnection,
            this.toolStripStatusLabel2,
            this.toolStripPanelItem2,
            this.statusIP,
            this.statusLblIP});
            this.statusStrip1.Location = new System.Drawing.Point(0, 660);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusStrip1.Size = new System.Drawing.Size(1354, 27);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLblLatencyUnit
            // 
            this.statusLblLatencyUnit.BackColor = System.Drawing.Color.Transparent;
            this.statusLblLatencyUnit.Name = "statusLblLatencyUnit";
            this.statusLblLatencyUnit.Size = new System.Drawing.Size(23, 22);
            this.statusLblLatencyUnit.Text = "ms";
            // 
            // statusLatency
            // 
            this.statusLatency.BackColor = System.Drawing.Color.Transparent;
            this.statusLatency.Name = "statusLatency";
            this.statusLatency.Size = new System.Drawing.Size(13, 22);
            this.statusLatency.Text = "2";
            // 
            // statusLblLatency
            // 
            this.statusLblLatency.BackColor = System.Drawing.Color.Transparent;
            this.statusLblLatency.Name = "statusLblLatency";
            this.statusLblLatency.Size = new System.Drawing.Size(54, 22);
            this.statusLblLatency.Text = ": Latency";
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
            // statusConnection
            // 
            this.statusConnection.BackColor = System.Drawing.Color.Transparent;
            this.statusConnection.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusConnection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.statusConnection.Name = "statusConnection";
            this.statusConnection.Size = new System.Drawing.Size(76, 22);
            this.statusConnection.Text = "CONNECTED";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.BackColor = System.Drawing.Color.Transparent;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(45, 22);
            this.toolStripStatusLabel2.Text = ": Status";
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
            // statusIP
            // 
            this.statusIP.BackColor = System.Drawing.Color.Transparent;
            this.statusIP.Name = "statusIP";
            this.statusIP.Size = new System.Drawing.Size(52, 22);
            this.statusIP.Text = "192.0.0.1";
            // 
            // statusLblIP
            // 
            this.statusLblIP.BackColor = System.Drawing.Color.Transparent;
            this.statusLblIP.Name = "statusLblIP";
            this.statusLblIP.Size = new System.Drawing.Size(23, 22);
            this.statusLblIP.Text = ": IP";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.splitContainer3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1354, 660);
            this.panel1.TabIndex = 3;
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
            this.splitContainer3.Panel1.Controls.Add(this.splitContainer5);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.splitContainer1);
            this.splitContainer3.Size = new System.Drawing.Size(1354, 660);
            this.splitContainer3.SplitterDistance = 25;
            this.splitContainer3.TabIndex = 2;
            // 
            // splitContainer5
            // 
            this.splitContainer5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer5.Location = new System.Drawing.Point(0, 0);
            this.splitContainer5.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.splitContainer5.MinimumSize = new System.Drawing.Size(0, 25);
            this.splitContainer5.Name = "splitContainer5";
            // 
            // splitContainer5.Panel1
            // 
            this.splitContainer5.Panel1.Controls.Add(this.menuMain);
            // 
            // splitContainer5.Panel2
            // 
            this.splitContainer5.Panel2.Controls.Add(this.splitContainer4);
            this.splitContainer5.Size = new System.Drawing.Size(1354, 25);
            this.splitContainer5.SplitterDistance = 926;
            this.splitContainer5.TabIndex = 0;
            // 
            // menuMain
            // 
            this.menuMain.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.MaximumSize = new System.Drawing.Size(1354, 25);
            this.menuMain.Name = "menuMain";
            this.menuMain.Size = new System.Drawing.Size(926, 24);
            this.menuMain.TabIndex = 0;
            this.menuMain.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAddDevice,
            this.menuEditDevices,
            this.toolStripSeparator2,
            this.menuRefresh,
            this.menuSettings,
            this.toolStripSeparator6,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // menuAddDevice
            // 
            this.menuAddDevice.Name = "menuAddDevice";
            this.menuAddDevice.Size = new System.Drawing.Size(180, 22);
            this.menuAddDevice.Text = "Add device";
            this.menuAddDevice.Click += new System.EventHandler(this.addDeviceToolStripMenuItem_Click);
            // 
            // menuEditDevices
            // 
            this.menuEditDevices.Name = "menuEditDevices";
            this.menuEditDevices.Size = new System.Drawing.Size(180, 22);
            this.menuEditDevices.Text = "Edit Devices";
            this.menuEditDevices.Click += new System.EventHandler(this.editDevicesToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // menuRefresh
            // 
            this.menuRefresh.Name = "menuRefresh";
            this.menuRefresh.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.menuRefresh.Size = new System.Drawing.Size(180, 22);
            this.menuRefresh.Text = "Refresh";
            this.menuRefresh.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // menuSettings
            // 
            this.menuSettings.Name = "menuSettings";
            this.menuSettings.Size = new System.Drawing.Size(180, 22);
            this.menuSettings.Text = "Settings";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(177, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuOpenLogs,
            this.exportLogsToolStripMenuItem,
            this.toolStripSeparator7,
            this.menuFlightAnalyzer});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // menuOpenLogs
            // 
            this.menuOpenLogs.Name = "menuOpenLogs";
            this.menuOpenLogs.Size = new System.Drawing.Size(180, 22);
            this.menuOpenLogs.Text = "Open Logs";
            // 
            // exportLogsToolStripMenuItem
            // 
            this.exportLogsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuExPdf,
            this.menuExExcel});
            this.exportLogsToolStripMenuItem.Name = "exportLogsToolStripMenuItem";
            this.exportLogsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exportLogsToolStripMenuItem.Text = "Export Logs";
            // 
            // menuExPdf
            // 
            this.menuExPdf.Name = "menuExPdf";
            this.menuExPdf.Size = new System.Drawing.Size(180, 22);
            this.menuExPdf.Text = "PDF File (.pdf)";
            // 
            // menuExExcel
            // 
            this.menuExExcel.Name = "menuExExcel";
            this.menuExExcel.Size = new System.Drawing.Size(180, 22);
            this.menuExExcel.Text = "Excel File (.xlsx)";
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(177, 6);
            // 
            // menuFlightAnalyzer
            // 
            this.menuFlightAnalyzer.Name = "menuFlightAnalyzer";
            this.menuFlightAnalyzer.Size = new System.Drawing.Size(180, 22);
            this.menuFlightAnalyzer.Text = "Flight analyzer";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuGettingStarted,
            this.menuAbout,
            this.toolStripSeparator1,
            this.menuCheckUpdate});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // menuGettingStarted
            // 
            this.menuGettingStarted.Name = "menuGettingStarted";
            this.menuGettingStarted.Size = new System.Drawing.Size(180, 22);
            this.menuGettingStarted.Text = "Getting Started";
            // 
            // menuAbout
            // 
            this.menuAbout.Name = "menuAbout";
            this.menuAbout.Size = new System.Drawing.Size(180, 22);
            this.menuAbout.Text = "About this software";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // menuCheckUpdate
            // 
            this.menuCheckUpdate.Name = "menuCheckUpdate";
            this.menuCheckUpdate.Size = new System.Drawing.Size(180, 22);
            this.menuCheckUpdate.Text = "Check for updates";
            this.menuCheckUpdate.Click += new System.EventHandler(this.checkForUpdatesToolStripMenuItem_Click);
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.splitContainer4.Name = "splitContainer4";
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.cmbConnect);
            this.splitContainer4.Panel1.Margin = new System.Windows.Forms.Padding(0, 3, 3, 0);
            this.splitContainer4.Panel1.Padding = new System.Windows.Forms.Padding(0, 3, 3, 0);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.btnConnectDevices);
            this.splitContainer4.Panel2.Controls.Add(this.btnDisconnect);
            this.splitContainer4.Panel2.Margin = new System.Windows.Forms.Padding(0, 3, 3, 0);
            this.splitContainer4.Panel2.Padding = new System.Windows.Forms.Padding(0, 3, 3, 0);
            this.splitContainer4.Size = new System.Drawing.Size(424, 25);
            this.splitContainer4.SplitterDistance = 288;
            this.splitContainer4.TabIndex = 0;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BorderColor = System.Drawing.Color.Navy;
            this.BorderThickness = 5;
            this.CaptionBarColor = System.Drawing.Color.Navy;
            this.CaptionBarHeight = 75;
            this.CaptionButtonColor = System.Drawing.Color.White;
            this.CaptionButtonHoverColor = System.Drawing.Color.White;
            this.CaptionFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CaptionForeColor = System.Drawing.Color.Navy;
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
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuMain;
            this.Name = "frmMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Drone Monitor";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.VisibleChanged += new System.EventHandler(this.frmMain_VisibleChanged);
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
            this.videoStreamTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.streamPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MessagesTab)).EndInit();
            this.MessagesTab.ResumeLayout(false);
            this.LogTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sfDataGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GraphTab)).EndInit();
            this.GraphTab.ResumeLayout(false);
            this.tabPageAdv2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmbConnect)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.splitContainer5.Panel1.ResumeLayout(false);
            this.splitContainer5.Panel1.PerformLayout();
            this.splitContainer5.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).EndInit();
            this.splitContainer5.ResumeLayout(false);
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private Syncfusion.Windows.Forms.Tools.TabControlAdv MessagesTab;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv tabPageAdv1;
        private Syncfusion.Windows.Forms.Tools.TabControlAdv GraphTab;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv tabPageAdv2;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv TablesTab;
        private Syncfusion.Windows.Forms.Tools.TabControlAdv tabControlAdv3;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv videoStreamTab;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv GPSTab;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Syncfusion.Windows.Forms.Tools.StatusStripPanelItem statusStripPanelItem1;
        private System.Windows.Forms.ToolStripComboBox cmb;
        private Syncfusion.Windows.Forms.Tools.ToolStripPanelItem btnConnect;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private Syncfusion.Windows.Forms.Tools.ToolStripPanelItem toolStripPanelItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private Syncfusion.Windows.Forms.Tools.StatusStripPanelItem statusStripPanelItem2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusLblIP;
        private System.Windows.Forms.ToolStripStatusLabel statusIP;
        private Syncfusion.Windows.Forms.Tools.ToolStripPanelItem toolStripPanelItem3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel statusLatency;
        private Syncfusion.Windows.Forms.Tools.ToolStripPanelItem toolStripPanelItem2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripStatusLabel statusConnection;
        private System.Windows.Forms.ToolStripStatusLabel statusLblLatencyUnit;
        private System.Windows.Forms.ToolStripStatusLabel statusLblLatency;
        private System.Windows.Forms.Panel panel1;
        private Vlc.DotNet.Forms.VlcControl streamPlayer;
        private Syncfusion.WinForms.ListView.SfComboBox cmbConnect;
        private Syncfusion.WinForms.Controls.SfButton btnConnectDevices;
        private Syncfusion.WinForms.Controls.SfButton btnDisconnect;
        private Syncfusion.Windows.Forms.Gauge.LinearGauge altIndicator;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv LogTab;
        private Syncfusion.WinForms.DataGrid.SfDataGrid sfDataGrid1;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.SplitContainer splitContainer5;
        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuAddDevice;
        private System.Windows.Forms.ToolStripMenuItem menuEditDevices;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        internal System.Windows.Forms.ToolStripMenuItem menuRefresh;
        private System.Windows.Forms.ToolStripMenuItem menuSettings;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuOpenLogs;
        private System.Windows.Forms.ToolStripMenuItem exportLogsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuExPdf;
        private System.Windows.Forms.ToolStripMenuItem menuExExcel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem menuFlightAnalyzer;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuGettingStarted;
        private System.Windows.Forms.ToolStripMenuItem menuAbout;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menuCheckUpdate;
        private System.Windows.Forms.SplitContainer splitContainer4;
    }
}