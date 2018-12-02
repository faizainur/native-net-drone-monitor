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
            Syncfusion.Windows.Forms.Tools.TreeNavigator.HeaderCollection headerCollection2 = new Syncfusion.Windows.Forms.Tools.TreeNavigator.HeaderCollection();
            Syncfusion.Windows.Forms.Tools.ActiveStateCollection activeStateCollection3 = new Syncfusion.Windows.Forms.Tools.ActiveStateCollection();
            Syncfusion.Windows.Forms.Tools.InactiveStateCollection inactiveStateCollection3 = new Syncfusion.Windows.Forms.Tools.InactiveStateCollection();
            Syncfusion.Windows.Forms.Tools.ToggleButtonRenderer toggleButtonRenderer3 = new Syncfusion.Windows.Forms.Tools.ToggleButtonRenderer();
            Syncfusion.Windows.Forms.Tools.SliderCollection sliderCollection3 = new Syncfusion.Windows.Forms.Tools.SliderCollection();
            Syncfusion.Windows.Forms.Tools.ActiveStateCollection activeStateCollection4 = new Syncfusion.Windows.Forms.Tools.ActiveStateCollection();
            Syncfusion.Windows.Forms.Tools.InactiveStateCollection inactiveStateCollection4 = new Syncfusion.Windows.Forms.Tools.InactiveStateCollection();
            Syncfusion.Windows.Forms.Tools.ToggleButtonRenderer toggleButtonRenderer4 = new Syncfusion.Windows.Forms.Tools.ToggleButtonRenderer();
            Syncfusion.Windows.Forms.Tools.SliderCollection sliderCollection4 = new Syncfusion.Windows.Forms.Tools.SliderCollection();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treeNavigator1 = new Syncfusion.Windows.Forms.Tools.TreeNavigator();
            this.treeGeneral = new Syncfusion.Windows.Forms.Tools.TreeMenuItem();
            this.treeSocket = new Syncfusion.Windows.Forms.Tools.TreeMenuItem();
            this.treeMenuItem1 = new Syncfusion.Windows.Forms.Tools.TreeMenuItem();
            this.btnSaveData = new Syncfusion.Windows.Forms.Tools.TreeMenuItem();
            this.panelGeneral = new System.Windows.Forms.Panel();
            this.panelWebSocket = new System.Windows.Forms.Panel();
            this.panelMavLink = new System.Windows.Forms.Panel();
            this.cmbProtocol = new Syncfusion.WinForms.ListView.SfComboBox();
            this.panelTCP = new System.Windows.Forms.Panel();
            this.cmbBaudrate = new Syncfusion.WinForms.ListView.SfComboBox();
            this.cmbPortCOM = new Syncfusion.WinForms.ListView.SfComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblProtocol = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.toggleMavLink = new Syncfusion.Windows.Forms.Tools.ToggleButton();
            this.txtSocket = new System.Windows.Forms.TextBox();
            this.lblSocket = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.toggleWebSocket = new Syncfusion.Windows.Forms.Tools.ToggleButton();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbDroneType = new Syncfusion.WinForms.ListView.SfComboBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtIPAddress = new System.Windows.Forms.TextBox();
            this.txtProfileName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelHome = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panelGeneral.SuspendLayout();
            this.panelWebSocket.SuspendLayout();
            this.panelMavLink.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbProtocol)).BeginInit();
            this.panelTCP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbBaudrate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbPortCOM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toggleMavLink)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toggleWebSocket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbDroneType)).BeginInit();
            this.panelHome.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.treeNavigator1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panelHome);
            this.splitContainer1.Size = new System.Drawing.Size(647, 502);
            this.splitContainer1.SplitterDistance = 215;
            this.splitContainer1.TabIndex = 0;
            // 
            // treeNavigator1
            // 
            this.treeNavigator1.Dock = System.Windows.Forms.DockStyle.Fill;
            headerCollection2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            headerCollection2.HeaderText = "Setup Wizard";
            this.treeNavigator1.Header = headerCollection2;
            this.treeNavigator1.ItemBackColor = System.Drawing.SystemColors.Control;
            this.treeNavigator1.Items.Add(this.treeGeneral);
            this.treeNavigator1.Items.Add(this.treeSocket);
            this.treeNavigator1.Items.Add(this.treeMenuItem1);
            this.treeNavigator1.Items.Add(this.btnSaveData);
            this.treeNavigator1.Location = new System.Drawing.Point(0, 0);
            this.treeNavigator1.MinimumSize = new System.Drawing.Size(150, 150);
            this.treeNavigator1.Name = "treeNavigator1";
            this.treeNavigator1.Size = new System.Drawing.Size(215, 502);
            this.treeNavigator1.TabIndex = 0;
            this.treeNavigator1.Text = "Setup Wizard";
            this.treeNavigator1.SelectionChanged += new Syncfusion.Windows.Forms.Tools.SelectionStateChangedEventHandler(this.treeNavigator1_SelectionChanged);
            // 
            // treeGeneral
            // 
            this.treeGeneral.BackColor = System.Drawing.SystemColors.Control;
            this.treeGeneral.ItemBackColor = System.Drawing.SystemColors.Control;
            this.treeGeneral.Location = new System.Drawing.Point(0, 0);
            this.treeGeneral.Name = "treeGeneral";
            this.treeGeneral.Size = new System.Drawing.Size(211, 50);
            this.treeGeneral.TabIndex = 1;
            this.treeGeneral.Text = "General";
            // 
            // treeSocket
            // 
            this.treeSocket.BackColor = System.Drawing.SystemColors.Control;
            this.treeSocket.ItemBackColor = System.Drawing.SystemColors.Control;
            this.treeSocket.Location = new System.Drawing.Point(0, 52);
            this.treeSocket.Name = "treeSocket";
            this.treeSocket.Size = new System.Drawing.Size(211, 50);
            this.treeSocket.TabIndex = 1;
            this.treeSocket.Text = "WebSocket";
            // 
            // treeMenuItem1
            // 
            this.treeMenuItem1.BackColor = System.Drawing.SystemColors.Control;
            this.treeMenuItem1.ItemBackColor = System.Drawing.SystemColors.Control;
            this.treeMenuItem1.Location = new System.Drawing.Point(0, 104);
            this.treeMenuItem1.Name = "treeMenuItem1";
            this.treeMenuItem1.Size = new System.Drawing.Size(211, 50);
            this.treeMenuItem1.TabIndex = 1;
            this.treeMenuItem1.Text = "MAVLink";
            // 
            // btnSaveData
            // 
            this.btnSaveData.BackColor = System.Drawing.SystemColors.Control;
            this.btnSaveData.ItemBackColor = System.Drawing.SystemColors.Control;
            this.btnSaveData.Location = new System.Drawing.Point(0, 156);
            this.btnSaveData.Name = "btnSaveData";
            this.btnSaveData.Size = new System.Drawing.Size(211, 50);
            this.btnSaveData.TabIndex = 1;
            this.btnSaveData.Text = "Save Profile";
            this.btnSaveData.Click += new System.EventHandler(this.btnAddData_Click);
            // 
            // panelGeneral
            // 
            this.panelGeneral.Controls.Add(this.panelWebSocket);
            this.panelGeneral.Controls.Add(this.label5);
            this.panelGeneral.Controls.Add(this.cmbDroneType);
            this.panelGeneral.Controls.Add(this.txtPort);
            this.panelGeneral.Controls.Add(this.txtIPAddress);
            this.panelGeneral.Controls.Add(this.txtProfileName);
            this.panelGeneral.Controls.Add(this.label4);
            this.panelGeneral.Controls.Add(this.label3);
            this.panelGeneral.Controls.Add(this.label2);
            this.panelGeneral.Controls.Add(this.label1);
            this.panelGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGeneral.Location = new System.Drawing.Point(0, 0);
            this.panelGeneral.Name = "panelGeneral";
            this.panelGeneral.Size = new System.Drawing.Size(428, 502);
            this.panelGeneral.TabIndex = 0;
            this.panelGeneral.Visible = false;
            // 
            // panelWebSocket
            // 
            this.panelWebSocket.Controls.Add(this.panelMavLink);
            this.panelWebSocket.Controls.Add(this.txtSocket);
            this.panelWebSocket.Controls.Add(this.lblSocket);
            this.panelWebSocket.Controls.Add(this.label6);
            this.panelWebSocket.Controls.Add(this.toggleWebSocket);
            this.panelWebSocket.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelWebSocket.Location = new System.Drawing.Point(0, 0);
            this.panelWebSocket.Name = "panelWebSocket";
            this.panelWebSocket.Size = new System.Drawing.Size(428, 502);
            this.panelWebSocket.TabIndex = 10;
            this.panelWebSocket.Visible = false;
            // 
            // panelMavLink
            // 
            this.panelMavLink.Controls.Add(this.cmbProtocol);
            this.panelMavLink.Controls.Add(this.panelTCP);
            this.panelMavLink.Controls.Add(this.lblProtocol);
            this.panelMavLink.Controls.Add(this.label7);
            this.panelMavLink.Controls.Add(this.toggleMavLink);
            this.panelMavLink.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMavLink.Location = new System.Drawing.Point(0, 0);
            this.panelMavLink.Name = "panelMavLink";
            this.panelMavLink.Size = new System.Drawing.Size(428, 502);
            this.panelMavLink.TabIndex = 4;
            this.panelMavLink.Visible = false;
            // 
            // cmbProtocol
            // 
            this.cmbProtocol.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cmbProtocol.Enabled = false;
            this.cmbProtocol.Location = new System.Drawing.Point(243, 73);
            this.cmbProtocol.Name = "cmbProtocol";
            this.cmbProtocol.Size = new System.Drawing.Size(163, 28);
            this.cmbProtocol.TabIndex = 6;
            this.cmbProtocol.SelectedIndexChanged += new System.EventHandler(this.cmbProtocol_SelectedIndexChanged);
            // 
            // panelTCP
            // 
            this.panelTCP.Controls.Add(this.cmbBaudrate);
            this.panelTCP.Controls.Add(this.cmbPortCOM);
            this.panelTCP.Controls.Add(this.label9);
            this.panelTCP.Controls.Add(this.label8);
            this.panelTCP.Location = new System.Drawing.Point(3, 112);
            this.panelTCP.Name = "panelTCP";
            this.panelTCP.Size = new System.Drawing.Size(422, 387);
            this.panelTCP.TabIndex = 5;
            this.panelTCP.Visible = false;
            // 
            // cmbBaudrate
            // 
            this.cmbBaudrate.Location = new System.Drawing.Point(240, 75);
            this.cmbBaudrate.Name = "cmbBaudrate";
            this.cmbBaudrate.Size = new System.Drawing.Size(163, 28);
            this.cmbBaudrate.TabIndex = 3;
            // 
            // cmbPortCOM
            // 
            this.cmbPortCOM.Location = new System.Drawing.Point(240, 34);
            this.cmbPortCOM.Name = "cmbPortCOM";
            this.cmbPortCOM.Size = new System.Drawing.Size(163, 28);
            this.cmbPortCOM.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(31, 82);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 21);
            this.label9.TabIndex = 1;
            this.label9.Text = "Baudrate";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(32, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 21);
            this.label8.TabIndex = 0;
            this.label8.Text = "Port";
            // 
            // lblProtocol
            // 
            this.lblProtocol.AutoSize = true;
            this.lblProtocol.Enabled = false;
            this.lblProtocol.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProtocol.Location = new System.Drawing.Point(34, 75);
            this.lblProtocol.Name = "lblProtocol";
            this.lblProtocol.Size = new System.Drawing.Size(68, 21);
            this.lblProtocol.TabIndex = 4;
            this.lblProtocol.Text = "Protocol";
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
            this.toggleMavLink.ActiveState = activeStateCollection3;
            this.toggleMavLink.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toggleMavLink.ForeColor = System.Drawing.Color.Black;
            inactiveStateCollection3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(151)))), ((int)(((byte)(151)))));
            this.toggleMavLink.InactiveState = inactiveStateCollection3;
            this.toggleMavLink.Location = new System.Drawing.Point(316, 14);
            this.toggleMavLink.MinimumSize = new System.Drawing.Size(52, 20);
            this.toggleMavLink.Name = "toggleMavLink";
            this.toggleMavLink.Renderer = toggleButtonRenderer3;
            this.toggleMavLink.Size = new System.Drawing.Size(90, 40);
            this.toggleMavLink.Slider = sliderCollection3;
            this.toggleMavLink.TabIndex = 2;
            this.toggleMavLink.Text = "toggleButton1";
            this.toggleMavLink.VisualStyle = Syncfusion.Windows.Forms.Tools.ToggleButtonStyle.Default;
            this.toggleMavLink.ToggleStateChanged += new Syncfusion.Windows.Forms.Tools.ToggleStateChangedEventHandler(this.toggleMavLink_ToggleStateChanged);
            // 
            // txtSocket
            // 
            this.txtSocket.Enabled = false;
            this.txtSocket.Location = new System.Drawing.Point(142, 86);
            this.txtSocket.Name = "txtSocket";
            this.txtSocket.Size = new System.Drawing.Size(232, 20);
            this.txtSocket.TabIndex = 3;
            // 
            // lblSocket
            // 
            this.lblSocket.AutoSize = true;
            this.lblSocket.Enabled = false;
            this.lblSocket.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSocket.Location = new System.Drawing.Point(38, 86);
            this.lblSocket.Name = "lblSocket";
            this.lblSocket.Size = new System.Drawing.Size(59, 20);
            this.lblSocket.TabIndex = 2;
            this.lblSocket.Text = "Socket";
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
            this.toggleWebSocket.ActiveState = activeStateCollection4;
            this.toggleWebSocket.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toggleWebSocket.ForeColor = System.Drawing.Color.Black;
            inactiveStateCollection4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(151)))), ((int)(((byte)(151)))));
            this.toggleWebSocket.InactiveState = inactiveStateCollection4;
            this.toggleWebSocket.Location = new System.Drawing.Point(316, 14);
            this.toggleWebSocket.MinimumSize = new System.Drawing.Size(52, 20);
            this.toggleWebSocket.Name = "toggleWebSocket";
            this.toggleWebSocket.Renderer = toggleButtonRenderer4;
            this.toggleWebSocket.Size = new System.Drawing.Size(90, 40);
            this.toggleWebSocket.Slider = sliderCollection4;
            this.toggleWebSocket.TabIndex = 0;
            this.toggleWebSocket.Text = "toggleButton1";
            this.toggleWebSocket.VisualStyle = Syncfusion.Windows.Forms.Tools.ToggleButtonStyle.Default;
            this.toggleWebSocket.ToggleStateChanged += new Syncfusion.Windows.Forms.Tools.ToggleStateChangedEventHandler(this.toggleWebSocket_ToggleStateChanged);
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
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(142, 174);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(59, 20);
            this.txtPort.TabIndex = 7;
            // 
            // txtIPAddress
            // 
            this.txtIPAddress.Location = new System.Drawing.Point(142, 141);
            this.txtIPAddress.Name = "txtIPAddress";
            this.txtIPAddress.Size = new System.Drawing.Size(232, 20);
            this.txtIPAddress.TabIndex = 6;
            // 
            // txtProfileName
            // 
            this.txtProfileName.Location = new System.Drawing.Point(142, 75);
            this.txtProfileName.Name = "txtProfileName";
            this.txtProfileName.Size = new System.Drawing.Size(232, 20);
            this.txtProfileName.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Port";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "IP";
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
            this.panelGeneral.ResumeLayout(false);
            this.panelGeneral.PerformLayout();
            this.panelWebSocket.ResumeLayout(false);
            this.panelWebSocket.PerformLayout();
            this.panelMavLink.ResumeLayout(false);
            this.panelMavLink.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbProtocol)).EndInit();
            this.panelTCP.ResumeLayout(false);
            this.panelTCP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbBaudrate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbPortCOM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toggleMavLink)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toggleWebSocket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbDroneType)).EndInit();
            this.panelHome.ResumeLayout(false);
            this.panelHome.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private Syncfusion.Windows.Forms.Tools.TreeNavigator treeNavigator1;
        private Syncfusion.Windows.Forms.Tools.TreeMenuItem treeGeneral;
        private Syncfusion.Windows.Forms.Tools.TreeMenuItem treeSocket;
        private Syncfusion.Windows.Forms.Tools.TreeMenuItem treeMenuItem1;
        private System.Windows.Forms.Panel panelGeneral;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtIPAddress;
        private System.Windows.Forms.TextBox txtProfileName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Syncfusion.WinForms.ListView.SfComboBox cmbDroneType;
        private Syncfusion.Windows.Forms.Tools.TreeMenuItem btnSaveData;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panelWebSocket;
        private System.Windows.Forms.TextBox txtSocket;
        private System.Windows.Forms.Label lblSocket;
        private System.Windows.Forms.Label label6;
        private Syncfusion.Windows.Forms.Tools.ToggleButton toggleWebSocket;
        private System.Windows.Forms.Panel panelMavLink;
        private System.Windows.Forms.Label label7;
        private Syncfusion.Windows.Forms.Tools.ToggleButton toggleMavLink;
        private Syncfusion.WinForms.ListView.SfComboBox cmbProtocol;
        private System.Windows.Forms.Panel panelTCP;
        private System.Windows.Forms.Label lblProtocol;
        private Syncfusion.WinForms.ListView.SfComboBox cmbBaudrate;
        private Syncfusion.WinForms.ListView.SfComboBox cmbPortCOM;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panelHome;
        private System.Windows.Forms.Label label10;
    }
}