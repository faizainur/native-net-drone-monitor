#region Copyright Syncfusion Inc. 2001-2018.
// Copyright Syncfusion Inc. 2001-2018. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Vlc.DotNet.Forms;
using System.IO;
using System.Reflection;
using System.Xml;
using System.Data.SqlClient;
using System.Threading;
using System.Xml.Linq;

namespace native_net_drone_monitor
{
    public partial class frmMain : Syncfusion.Windows.Forms.MetroForm
    {
        public event EventHandler RefreshTriggered;
        private BindingList<Drone> droneList = new BindingList<Drone>();
        private BindingSource source = new BindingSource();
        private List<string> messages = new List<string>();
        private string FILENAME = "droneList.xml";
        public string path;
        public frmMain()
        {
            
            InitializeComponent();
            path = "D:/My Project/TRUI/AUAV/Programming/native-net-drone-monitor/native-net-drone-monitor/bin/Debug/1.mkv";


        }

        public void refresh()
        {
            if (!File.Exists(FILENAME))
            {
                var result = MessageBox.Show("Seems this your first time :), please add device first.", "No devices listed", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                switch (result)
                {
                    case DialogResult.Yes:
                        if (!createXmlFile())
                        {
                            MessageBox.Show("Error creating XML file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            var frmAdd = new frmAddDevices();
                            frmAdd.Show();
                            frmAdd.TopMost = true;
                        }
                        break;
                    case DialogResult.No:
                        break;
                    default:
                        MessageBox.Show("What did you press?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                        break;
                }
            } else
            {
                droneList.Clear();

                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(FILENAME);

                foreach (XmlNode node in xmlDoc.DocumentElement)
                {
                    var profileName = node.Attributes[0].InnerText;

                    Drone newDrone = new Drone();

                    var port = 0;
                    var socket = 0;
                    var ipAddress = node.SelectSingleNode("/drone-list/drone/ip-address").InnerText;
                    var connMethod = node.SelectSingleNode("/drone-list/drone/conn-method").InnerText;
                    var protocolConn = node.SelectSingleNode("/drone-list/drone/protocol").InnerText;
                    Int32.TryParse(node.SelectSingleNode("/drone-list/drone/socket").InnerText, out socket);
                    Int32.TryParse(node.SelectSingleNode("/drone-list/drone/port").InnerText, out port);

                    newDrone.profileName = profileName;
                    newDrone.ipAddress = ipAddress;
                    newDrone.protocolConn = protocolConn;
                    newDrone.connMethod = connMethod;
                    newDrone.port = port;
                    newDrone.socket = socket;

                    droneList.Add(newDrone);
                }
                source.DataSource = droneList;
                cmbConnect.DataSource = source;
                cmbConnect.DisplayMember = "profileName";
            }
          
        }
      
        public bool createXmlFile()
        {
            new XDocument(
                new XElement("drone-list")).Save(FILENAME);
            if (!File.Exists(FILENAME))
            {
                return false;
            }
            return true;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            refresh();
            statusConnection.Text = "DISCONNECTED";
            statusConnection.ForeColor = Color.Red;
            statusIP.Visible = false;
            statusLatency.Visible = false;
            statusLblIP.Visible = false;
            statusLblLatency.Visible = false;
            statusLblLatencyUnit.Visible = false;
        }

        private void addDeviceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var addDevices = new frmAddDevices();
            addDevices.Show();
            
        }

        private Boolean update()
        {
            var currentVersion = Application.ProductVersion;
            var currentName = Application.ProductName;
            return true;
        }

        private void checkForUpdatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (update())
            {
                MessageBox.Show(Application.
                    ProductVersion);
            }
        }

       

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        
        private void btnConnectDevices_Click(object sender, EventArgs e)
        {
            var idx = cmbConnect.SelectedIndex;
            Drone selectedDrone = new Drone();
            connect(selectedDrone);
        }

        private void cmbConnect_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure to disconnect?", "Really?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            switch (result)
            {
                case DialogResult.Yes:
                    disconnect();
                    break;
                case DialogResult.No:
                    break;
                default:
                    MessageBox.Show("What did you press?", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    break;
            }
        }

        public void connect(Drone drone)
        {
            streamPlayer.Play(new Uri("D:/My Project/TRUI/AUAV/Programming/native-net-drone-monitor/native-net-drone-monitor/bin/Debug/1.mkv"));
            btnConnectDevices.Visible = false;
            btnDisconnect.Visible = true;
            statusConnection.Text = "CONNECTED";
            statusIP.Visible = true;
            statusLatency.Visible = true;
            statusLblIP.Visible = true;
            statusLblLatency.Visible = true;
            statusLblLatencyUnit.Visible = true;
            statusConnection.ForeColor = Color.Green;
        }

        public void disconnect()
        {
            streamPlayer.Stop();
            btnConnectDevices.Visible = true;
            btnDisconnect.Visible = false;
            statusConnection.Text = "NOT CONNECTED";
            statusIP.Visible = false;
            statusLatency.Visible = false;
            statusLblIP.Visible = false;
            statusLblLatency.Visible = false;
            statusLblLatencyUnit.Visible = false;
            statusConnection.ForeColor = Color.Red;
        }

        private void editDevicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var editFrm = new frmEdit();
            editFrm.Show();
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void frmMain_VisibleChanged(object sender, EventArgs e)
        {
            refresh();
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            refresh();
        }

        
    }
}
