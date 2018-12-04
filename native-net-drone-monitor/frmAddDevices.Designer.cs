#region Copyright Syncfusion Inc. 2001-2018.
// Copyright Syncfusion Inc. 2001-2018. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
namespace native_net_drone_monitor
{
    partial class frmAddDevices
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
            Syncfusion.Windows.Forms.Tools.TreeNavigator.HeaderCollection headerCollection4 = new Syncfusion.Windows.Forms.Tools.TreeNavigator.HeaderCollection();
            Syncfusion.Windows.Forms.Tools.ActiveStateCollection activeStateCollection7 = new Syncfusion.Windows.Forms.Tools.ActiveStateCollection();
            Syncfusion.Windows.Forms.Tools.InactiveStateCollection inactiveStateCollection7 = new Syncfusion.Windows.Forms.Tools.InactiveStateCollection();
            Syncfusion.Windows.Forms.Tools.ToggleButtonRenderer toggleButtonRenderer7 = new Syncfusion.Windows.Forms.Tools.ToggleButtonRenderer();
            Syncfusion.Windows.Forms.Tools.SliderCollection sliderCollection7 = new Syncfusion.Windows.Forms.Tools.SliderCollection();
            Syncfusion.Windows.Forms.Tools.ActiveStateCollection activeStateCollection8 = new Syncfusion.Windows.Forms.Tools.ActiveStateCollection();
            Syncfusion.Windows.Forms.Tools.InactiveStateCollection inactiveStateCollection8 = new Syncfusion.Windows.Forms.Tools.InactiveStateCollection();
            Syncfusion.Windows.Forms.Tools.ToggleButtonRenderer toggleButtonRenderer8 = new Syncfusion.Windows.Forms.Tools.ToggleButtonRenderer();
            Syncfusion.Windows.Forms.Tools.SliderCollection sliderCollection8 = new Syncfusion.Windows.Forms.Tools.SliderCollection();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.navSetupWizard = new Syncfusion.Windows.Forms.Tools.TreeNavigator();
            this.treeGeneral = new Syncfusion.Windows.Forms.Tools.TreeMenuItem();
            this.treeVideoStream = new Syncfusion.Windows.Forms.Tools.TreeMenuItem();
            this.treeTelemetry = new Syncfusion.Windows.Forms.Tools.TreeMenuItem();
            this.panelHome = new System.Windows.Forms.Panel();
            this.panelGeneral = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbDroneType = new Syncfusion.WinForms.ListView.SfComboBox();
            this.txtProfileName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.treeMenuItem2 = new Syncfusion.Windows.Forms.Tools.TreeMenuItem();
            this.treeMenuItem1 = new Syncfusion.Windows.Forms.Tools.TreeMenuItem();
            this.treeWebSocket = new Syncfusion.Windows.Forms.Tools.TreeMenuItem();
            this.treeMavLink = new Syncfusion.Windows.Forms.Tools.TreeMenuItem();
            this.panelVideoStream = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.txtPortRtsp = new System.Windows.Forms.TextBox();
            this.txtRtspServer = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panelWebSocket = new System.Windows.Forms.Panel();
            this.txtSocket = new System.Windows.Forms.TextBox();
            this.lblSocket = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.toggleWebSocket = new Syncfusion.Windows.Forms.Tools.ToggleButton();
            this.panelMavLink = new System.Windows.Forms.Panel();
            this.panelTcp = new System.Windows.Forms.Panel();
            this.txtTcpPort = new System.Windows.Forms.TextBox();
            this.txtTcpHost = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panelUdp = new System.Windows.Forms.Panel();
            this.txtUdpPort = new System.Windows.Forms.TextBox();
            this.txtUdpHost = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.cmbProtocol = new Syncfusion.WinForms.ListView.SfComboBox();
            this.panelSerial = new System.Windows.Forms.Panel();
            this.cmbBaudrate = new Syncfusion.WinForms.ListView.SfComboBox();
            this.cmbPortCOM = new Syncfusion.WinForms.ListView.SfComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblProtocol = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.toggleMavLink = new Syncfusion.Windows.Forms.Tools.ToggleButton();
            this.btnSaveData = new Syncfusion.Windows.Forms.Tools.TreeMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panelHome.SuspendLayout();
            this.panelGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbDroneType)).BeginInit();
            this.panelVideoStream.SuspendLayout();
            this.panelWebSocket.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toggleWebSocket)).BeginInit();
            this.panelMavLink.SuspendLayout();
            this.panelTcp.SuspendLayout();
            this.panelUdp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbProtocol)).BeginInit();
            this.panelSerial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbBaudrate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbPortCOM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toggleMavLink)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.navSetupWizard);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panelHome);
            this.splitContainer1.Size = new System.Drawing.Size(647, 502);
            this.splitContainer1.SplitterDistance = 215;
            this.splitContainer1.TabIndex = 0;
            // 
            // navSetupWizard
            // 
            this.navSetupWizard.Dock = System.Windows.Forms.DockStyle.Fill;
            headerCollection4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            headerCollection4.HeaderText = "Setup Wizard";
            this.navSetupWizard.Header = headerCollection4;
            this.navSetupWizard.ItemBackColor = System.Drawing.SystemColors.Control;
            this.navSetupWizard.Items.Add(this.treeGeneral);
            this.navSetupWizard.Items.Add(this.treeVideoStream);
            this.navSetupWizard.Items.Add(this.treeTelemetry);
            this.navSetupWizard.Items.Add(this.btnSaveData);
            this.navSetupWizard.Location = new System.Drawing.Point(0, 0);
            this.navSetupWizard.MinimumSize = new System.Drawing.Size(150, 150);
            this.navSetupWizard.Name = "navSetupWizard";
            this.navSetupWizard.Size = new System.Drawing.Size(215, 502);
            this.navSetupWizard.TabIndex = 0;
            this.navSetupWizard.Text = "Setup Wizard";
            this.navSetupWizard.SelectionChanged += new Syncfusion.Windows.Forms.Tools.SelectionStateChangedEventHandler(this.treeNavigator1_SelectionChanged);
            // 
            // treeGeneral
            // 
            this.treeGeneral.BackColor = System.Drawing.SystemColors.Control;
            this.treeGeneral.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeGeneral.ItemBackColor = System.Drawing.SystemColors.Control;
            this.treeGeneral.Location = new System.Drawing.Point(0, 0);
            this.treeGeneral.Name = "treeGeneral";
            this.treeGeneral.Size = new System.Drawing.Size(211, 50);
            this.treeGeneral.TabIndex = 1;
            this.treeGeneral.Text = "General";
            // 
            // treeVideoStream
            // 
            this.treeVideoStream.BackColor = System.Drawing.SystemColors.Control;
            this.treeVideoStream.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeVideoStream.ItemBackColor = System.Drawing.SystemColors.Control;
            this.treeVideoStream.Location = new System.Drawing.Point(0, 52);
            this.treeVideoStream.Name = "treeVideoStream";
            this.treeVideoStream.Size = new System.Drawing.Size(211, 50);
            this.treeVideoStream.TabIndex = 1;
            this.treeVideoStream.Text = "Video Stream";
            // 
            // treeTelemetry
            // 
            this.treeTelemetry.BackColor = System.Drawing.SystemColors.Control;
            this.treeTelemetry.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeTelemetry.ItemBackColor = System.Drawing.SystemColors.Control;
            this.treeTelemetry.Items.Add(this.treeWebSocket);
            this.treeTelemetry.Items.Add(this.treeMavLink);
            this.treeTelemetry.Location = new System.Drawing.Point(0, 104);
            this.treeTelemetry.Name = "treeTelemetry";
            this.treeTelemetry.Size = new System.Drawing.Size(211, 50);
            this.treeTelemetry.TabIndex = 1;
            this.treeTelemetry.Text = "Telemetry";
            this.treeTelemetry.Click += new System.EventHandler(this.btnSaveData_Click);
            // 
            // panelHome
            // 
            this.panelHome.Controls.Add(this.panelGeneral);
            this.panelHome.Controls.Add(this.label10);
            this.panelHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHome.Location = new System.Drawing.Point(0, 0);
            this.panelHome.Name = "panelHome";
            this.panelHome.Size = new System.Drawing.Size(428, 502);
            this.panelHome.TabIndex = 1;
            // 
            // panelGeneral
            // 
            this.panelGeneral.Controls.Add(this.panelVideoStream);
            this.panelGeneral.Controls.Add(this.label5);
            this.panelGeneral.Controls.Add(this.cmbDroneType);
            this.panelGeneral.Controls.Add(this.txtProfileName);
            this.panelGeneral.Controls.Add(this.label2);
            this.panelGeneral.Controls.Add(this.label1);
            this.panelGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGeneral.Location = new System.Drawing.Point(0, 0);
            this.panelGeneral.Name = "panelGeneral";
            this.panelGeneral.Size = new System.Drawing.Size(428, 502);
            this.panelGeneral.TabIndex = 0;
            this.panelGeneral.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(415, 46);
            this.label5.TabIndex = 9;
            this.label5.Text = "Please named the profile to save the drone data, \r\nplease make a good name so you" +
    " easily remember it.\r\n";
            // 
            // cmbDroneType
            // 
            this.cmbDroneType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cmbDroneType.Location = new System.Drawing.Point(142, 107);
            this.cmbDroneType.Name = "cmbDroneType";
            this.cmbDroneType.Size = new System.Drawing.Size(232, 20);
            this.cmbDroneType.TabIndex = 8;
            // 
            // txtProfileName
            // 
            this.txtProfileName.Location = new System.Drawing.Point(142, 75);
            this.txtProfileName.Name = "txtProfileName";
            this.txtProfileName.Size = new System.Drawing.Size(232, 20);
            this.txtProfileName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Drone type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Profile name";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(27, 68);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(389, 42);
            this.label10.TabIndex = 0;
            this.label10.Text = "Setup your drone and save the configuration for future\r\nuse.";
            // 
            // treeMenuItem2
            // 
            this.treeMenuItem2.ItemBackColor = System.Drawing.SystemColors.Control;
            this.treeMenuItem2.Location = new System.Drawing.Point(0, 0);
            this.treeMenuItem2.Name = "treeMenuItem2";
            this.treeMenuItem2.Size = new System.Drawing.Size(0, 0);
            this.treeMenuItem2.TabIndex = 0;
            this.treeMenuItem2.Text = "MAVLink";
            // 
            // treeMenuItem1
            // 
            this.treeMenuItem1.ItemBackColor = System.Drawing.SystemColors.Control;
            this.treeMenuItem1.Location = new System.Drawing.Point(0, 0);
            this.treeMenuItem1.Name = "treeMenuItem1";
            this.treeMenuItem1.Size = new System.Drawing.Size(0, 0);
            this.treeMenuItem1.TabIndex = 1;
            this.treeMenuItem1.Text = "WebSocket";
            // 
            // treeWebSocket
            // 
            this.treeWebSocket.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeWebSocket.ItemBackColor = System.Drawing.SystemColors.Control;
            this.treeWebSocket.Location = new System.Drawing.Point(0, 0);
            this.treeWebSocket.Name = "treeWebSocket";
            this.treeWebSocket.Size = new System.Drawing.Size(0, 0);
            this.treeWebSocket.TabIndex = 1;
            this.treeWebSocket.Text = "WebSocket";
            // 
            // treeMavLink
            // 
            this.treeMavLink.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeMavLink.ItemBackColor = System.Drawing.SystemColors.Control;
            this.treeMavLink.Location = new System.Drawing.Point(0, 0);
            this.treeMavLink.Name = "treeMavLink";
            this.treeMavLink.Size = new System.Drawing.Size(0, 0);
            this.treeMavLink.TabIndex = 1;
            this.treeMavLink.Text = "MAVLink";
            // 
            // panelVideoStream
            // 
            this.panelVideoStream.BackColor = System.Drawing.Color.White;
            this.panelVideoStream.Controls.Add(this.panelWebSocket);
            this.panelVideoStream.Controls.Add(this.label15);
            this.panelVideoStream.Controls.Add(this.txtPortRtsp);
            this.panelVideoStream.Controls.Add(this.txtRtspServer);
            this.panelVideoStream.Controls.Add(this.label4);
            this.panelVideoStream.Controls.Add(this.label3);
            this.panelVideoStream.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelVideoStream.Location = new System.Drawing.Point(0, 0);
            this.panelVideoStream.Name = "panelVideoStream";
            this.panelVideoStream.Size = new System.Drawing.Size(428, 502);
            this.panelVideoStream.TabIndex = 10;
            this.panelVideoStream.Visible = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(11, 20);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(282, 25);
            this.label15.TabIndex = 17;
            this.label15.Text = "Set video streaming preferences";
            // 
            // txtPortRtsp
            // 
            this.txtPortRtsp.Location = new System.Drawing.Point(130, 104);
            this.txtPortRtsp.Name = "txtPortRtsp";
            this.txtPortRtsp.Size = new System.Drawing.Size(59, 20);
            this.txtPortRtsp.TabIndex = 16;
            // 
            // txtRtspServer
            // 
            this.txtRtspServer.Location = new System.Drawing.Point(130, 71);
            this.txtRtspServer.Name = "txtRtspServer";
            this.txtRtspServer.Size = new System.Drawing.Size(232, 20);
            this.txtRtspServer.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Port";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "IP RTSP";
            // 
            // panelWebSocket
            // 
            this.panelWebSocket.BackColor = System.Drawing.Color.White;
            this.panelWebSocket.Controls.Add(this.panelMavLink);
            this.panelWebSocket.Controls.Add(this.txtSocket);
            this.panelWebSocket.Controls.Add(this.lblSocket);
            this.panelWebSocket.Controls.Add(this.label6);
            this.panelWebSocket.Controls.Add(this.toggleWebSocket);
            this.panelWebSocket.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelWebSocket.Location = new System.Drawing.Point(0, 0);
            this.panelWebSocket.Name = "panelWebSocket";
            this.panelWebSocket.Size = new System.Drawing.Size(428, 502);
            this.panelWebSocket.TabIndex = 18;
            this.panelWebSocket.Visible = false;
            // 
            // txtSocket
            // 
            this.txtSocket.Location = new System.Drawing.Point(142, 86);
            this.txtSocket.Name = "txtSocket";
            this.txtSocket.Size = new System.Drawing.Size(232, 20);
            this.txtSocket.TabIndex = 3;
            this.txtSocket.Visible = false;
            // 
            // lblSocket
            // 
            this.lblSocket.AutoSize = true;
            this.lblSocket.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSocket.Location = new System.Drawing.Point(38, 86);
            this.lblSocket.Name = "lblSocket";
            this.lblSocket.Size = new System.Drawing.Size(59, 20);
            this.lblSocket.TabIndex = 2;
            this.lblSocket.Text = "Socket";
            this.lblSocket.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(34, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Turn WebSocket";
            // 
            // toggleWebSocket
            // 
            this.toggleWebSocket.ActiveState = activeStateCollection7;
            this.toggleWebSocket.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toggleWebSocket.ForeColor = System.Drawing.Color.Black;
            inactiveStateCollection7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(151)))), ((int)(((byte)(151)))));
            this.toggleWebSocket.InactiveState = inactiveStateCollection7;
            this.toggleWebSocket.Location = new System.Drawing.Point(316, 14);
            this.toggleWebSocket.MinimumSize = new System.Drawing.Size(52, 20);
            this.toggleWebSocket.Name = "toggleWebSocket";
            this.toggleWebSocket.Renderer = toggleButtonRenderer7;
            this.toggleWebSocket.Size = new System.Drawing.Size(90, 40);
            this.toggleWebSocket.Slider = sliderCollection7;
            this.toggleWebSocket.TabIndex = 0;
            this.toggleWebSocket.Text = "toggleButton1";
            this.toggleWebSocket.VisualStyle = Syncfusion.Windows.Forms.Tools.ToggleButtonStyle.Default;
            this.toggleWebSocket.ToggleStateChanged += new Syncfusion.Windows.Forms.Tools.ToggleStateChangedEventHandler(this.toggleWebSocket_ToggleStateChanged);
            // 
            // panelMavLink
            // 
            this.panelMavLink.BackColor = System.Drawing.Color.White;
            this.panelMavLink.Controls.Add(this.panelTcp);
            this.panelMavLink.Controls.Add(this.panelUdp);
            this.panelMavLink.Controls.Add(this.cmbProtocol);
            this.panelMavLink.Controls.Add(this.panelSerial);
            this.panelMavLink.Controls.Add(this.lblProtocol);
            this.panelMavLink.Controls.Add(this.label7);
            this.panelMavLink.Controls.Add(this.toggleMavLink);
            this.panelMavLink.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMavLink.Location = new System.Drawing.Point(0, 0);
            this.panelMavLink.Name = "panelMavLink";
            this.panelMavLink.Size = new System.Drawing.Size(428, 502);
            this.panelMavLink.TabIndex = 5;
            this.panelMavLink.Visible = false;
            // 
            // panelTcp
            // 
            this.panelTcp.Controls.Add(this.txtTcpPort);
            this.panelTcp.Controls.Add(this.txtTcpHost);
            this.panelTcp.Controls.Add(this.label11);
            this.panelTcp.Controls.Add(this.label12);
            this.panelTcp.Location = new System.Drawing.Point(6, 133);
            this.panelTcp.Name = "panelTcp";
            this.panelTcp.Size = new System.Drawing.Size(410, 142);
            this.panelTcp.TabIndex = 7;
            this.panelTcp.Visible = false;
            // 
            // txtTcpPort
            // 
            this.txtTcpPort.Location = new System.Drawing.Point(195, 85);
            this.txtTcpPort.Name = "txtTcpPort";
            this.txtTcpPort.Size = new System.Drawing.Size(54, 20);
            this.txtTcpPort.TabIndex = 7;
            // 
            // txtTcpHost
            // 
            this.txtTcpHost.Location = new System.Drawing.Point(195, 42);
            this.txtTcpHost.Name = "txtTcpHost";
            this.txtTcpHost.Size = new System.Drawing.Size(208, 20);
            this.txtTcpHost.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(28, 84);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 21);
            this.label11.TabIndex = 5;
            this.label11.Text = "Server Port";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(28, 39);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(91, 21);
            this.label12.TabIndex = 4;
            this.label12.Text = "Server Host";
            // 
            // panelUdp
            // 
            this.panelUdp.Controls.Add(this.txtUdpPort);
            this.panelUdp.Controls.Add(this.txtUdpHost);
            this.panelUdp.Controls.Add(this.label13);
            this.panelUdp.Controls.Add(this.label14);
            this.panelUdp.Location = new System.Drawing.Point(2, 134);
            this.panelUdp.Name = "panelUdp";
            this.panelUdp.Size = new System.Drawing.Size(422, 142);
            this.panelUdp.TabIndex = 8;
            this.panelUdp.Visible = false;
            // 
            // txtUdpPort
            // 
            this.txtUdpPort.Location = new System.Drawing.Point(195, 85);
            this.txtUdpPort.Name = "txtUdpPort";
            this.txtUdpPort.Size = new System.Drawing.Size(54, 20);
            this.txtUdpPort.TabIndex = 7;
            // 
            // txtUdpHost
            // 
            this.txtUdpHost.Location = new System.Drawing.Point(195, 42);
            this.txtUdpHost.Name = "txtUdpHost";
            this.txtUdpHost.Size = new System.Drawing.Size(208, 20);
            this.txtUdpHost.TabIndex = 6;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(25, 85);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 21);
            this.label13.TabIndex = 5;
            this.label13.Text = "Bind Port";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(26, 37);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(77, 21);
            this.label14.TabIndex = 4;
            this.label14.Text = "Bind Host";
            // 
            // cmbProtocol
            // 
            this.cmbProtocol.AllowDropDownResize = false;
            this.cmbProtocol.AllowNull = true;
            this.cmbProtocol.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cmbProtocol.Location = new System.Drawing.Point(243, 73);
            this.cmbProtocol.Name = "cmbProtocol";
            this.cmbProtocol.Size = new System.Drawing.Size(163, 28);
            this.cmbProtocol.TabIndex = 6;
            this.cmbProtocol.Text = "None";
            this.cmbProtocol.Visible = false;
            this.cmbProtocol.SelectedIndexChanged += new System.EventHandler(this.cmbProtocol_SelectedIndexChanged);
            // 
            // panelSerial
            // 
            this.panelSerial.Controls.Add(this.cmbBaudrate);
            this.panelSerial.Controls.Add(this.cmbPortCOM);
            this.panelSerial.Controls.Add(this.label9);
            this.panelSerial.Controls.Add(this.label8);
            this.panelSerial.Location = new System.Drawing.Point(14, 130);
            this.panelSerial.Name = "panelSerial";
            this.panelSerial.Size = new System.Drawing.Size(392, 146);
            this.panelSerial.TabIndex = 5;
            this.panelSerial.Visible = false;
            // 
            // cmbBaudrate
            // 
            this.cmbBaudrate.Location = new System.Drawing.Point(229, 75);
            this.cmbBaudrate.Name = "cmbBaudrate";
            this.cmbBaudrate.Size = new System.Drawing.Size(163, 28);
            this.cmbBaudrate.TabIndex = 3;
            // 
            // cmbPortCOM
            // 
            this.cmbPortCOM.Location = new System.Drawing.Point(229, 34);
            this.cmbPortCOM.Name = "cmbPortCOM";
            this.cmbPortCOM.Size = new System.Drawing.Size(163, 28);
            this.cmbPortCOM.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(20, 83);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 21);
            this.label9.TabIndex = 1;
            this.label9.Text = "Baudrate";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(20, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 21);
            this.label8.TabIndex = 0;
            this.label8.Text = "Port COM";
            // 
            // lblProtocol
            // 
            this.lblProtocol.AutoSize = true;
            this.lblProtocol.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProtocol.Location = new System.Drawing.Point(34, 75);
            this.lblProtocol.Name = "lblProtocol";
            this.lblProtocol.Size = new System.Drawing.Size(68, 21);
            this.lblProtocol.TabIndex = 4;
            this.lblProtocol.Text = "Protocol";
            this.lblProtocol.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(34, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "Turn MAVLink";
            // 
            // toggleMavLink
            // 
            this.toggleMavLink.ActiveState = activeStateCollection8;
            this.toggleMavLink.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toggleMavLink.ForeColor = System.Drawing.Color.Black;
            inactiveStateCollection8.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(151)))), ((int)(((byte)(151)))));
            this.toggleMavLink.InactiveState = inactiveStateCollection8;
            this.toggleMavLink.Location = new System.Drawing.Point(316, 14);
            this.toggleMavLink.MinimumSize = new System.Drawing.Size(52, 20);
            this.toggleMavLink.Name = "toggleMavLink";
            this.toggleMavLink.Renderer = toggleButtonRenderer8;
            this.toggleMavLink.Size = new System.Drawing.Size(90, 40);
            this.toggleMavLink.Slider = sliderCollection8;
            this.toggleMavLink.TabIndex = 2;
            this.toggleMavLink.Text = "toggleButton1";
            this.toggleMavLink.VisualStyle = Syncfusion.Windows.Forms.Tools.ToggleButtonStyle.Default;
            this.toggleMavLink.ToggleStateChanged += new Syncfusion.Windows.Forms.Tools.ToggleStateChangedEventHandler(this.toggleMavLink_ToggleStateChanged);
            // 
            // btnSaveData
            // 
            this.btnSaveData.BackColor = System.Drawing.SystemColors.Control;
            this.btnSaveData.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSaveData.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveData.ItemBackColor = System.Drawing.SystemColors.Control;
            this.btnSaveData.Location = new System.Drawing.Point(0, 401);
            this.btnSaveData.Name = "btnSaveData";
            this.btnSaveData.Size = new System.Drawing.Size(213, 50);
            this.btnSaveData.TabIndex = 1;
            this.btnSaveData.Text = "Save";
            this.btnSaveData.Click += new System.EventHandler(this.btnSaveData_Click);
            // 
            // frmAddDevices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.CaptionBarHeight = 15;
            this.CaptionForeColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(647, 502);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmAddDevices";
            this.ShowIcon = false;
            this.ShowMaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Setup Wizard";
            this.Load += new System.EventHandler(this.frmAddDevices_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panelHome.ResumeLayout(false);
            this.panelHome.PerformLayout();
            this.panelGeneral.ResumeLayout(false);
            this.panelGeneral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbDroneType)).EndInit();
            this.panelVideoStream.ResumeLayout(false);
            this.panelVideoStream.PerformLayout();
            this.panelWebSocket.ResumeLayout(false);
            this.panelWebSocket.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toggleWebSocket)).EndInit();
            this.panelMavLink.ResumeLayout(false);
            this.panelMavLink.PerformLayout();
            this.panelTcp.ResumeLayout(false);
            this.panelTcp.PerformLayout();
            this.panelUdp.ResumeLayout(false);
            this.panelUdp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbProtocol)).EndInit();
            this.panelSerial.ResumeLayout(false);
            this.panelSerial.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbBaudrate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbPortCOM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toggleMavLink)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private Syncfusion.Windows.Forms.Tools.TreeNavigator navSetupWizard;
        private Syncfusion.Windows.Forms.Tools.TreeMenuItem treeGeneral;
        private System.Windows.Forms.Panel panelGeneral;
        private System.Windows.Forms.TextBox txtProfileName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Syncfusion.WinForms.ListView.SfComboBox cmbDroneType;
        private Syncfusion.Windows.Forms.Tools.TreeMenuItem treeVideoStream;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panelHome;
        private System.Windows.Forms.Label label10;
        private Syncfusion.Windows.Forms.Tools.TreeMenuItem treeTelemetry;
        private Syncfusion.Windows.Forms.Tools.TreeMenuItem treeMenuItem2;
        private Syncfusion.Windows.Forms.Tools.TreeMenuItem treeMenuItem1;
        private Syncfusion.Windows.Forms.Tools.TreeMenuItem treeWebSocket;
        private Syncfusion.Windows.Forms.Tools.TreeMenuItem treeMavLink;
        private System.Windows.Forms.Panel panelVideoStream;
        private System.Windows.Forms.Panel panelWebSocket;
        private System.Windows.Forms.Panel panelMavLink;
        private System.Windows.Forms.Panel panelTcp;
        private System.Windows.Forms.TextBox txtTcpPort;
        private System.Windows.Forms.TextBox txtTcpHost;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panelUdp;
        private System.Windows.Forms.TextBox txtUdpPort;
        private System.Windows.Forms.TextBox txtUdpHost;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private Syncfusion.WinForms.ListView.SfComboBox cmbProtocol;
        private System.Windows.Forms.Panel panelSerial;
        private Syncfusion.WinForms.ListView.SfComboBox cmbBaudrate;
        private Syncfusion.WinForms.ListView.SfComboBox cmbPortCOM;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblProtocol;
        private System.Windows.Forms.Label label7;
        private Syncfusion.Windows.Forms.Tools.ToggleButton toggleMavLink;
        private System.Windows.Forms.TextBox txtSocket;
        private System.Windows.Forms.Label lblSocket;
        private System.Windows.Forms.Label label6;
        private Syncfusion.Windows.Forms.Tools.ToggleButton toggleWebSocket;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtPortRtsp;
        private System.Windows.Forms.TextBox txtRtspServer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Syncfusion.Windows.Forms.Tools.TreeMenuItem btnSaveData;
    }
}