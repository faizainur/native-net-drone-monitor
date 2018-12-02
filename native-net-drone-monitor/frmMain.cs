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

namespace native_net_drone_monitor
{
    public partial class frmMain : Syncfusion.Windows.Forms.MetroForm
    {
        public event EventHandler RefreshTriggered;
        private BindingList<Drone> droneList = new BindingList<Drone>();
        private BindingSource source = new BindingSource();
        private List<string> messages = new List<string>();
        public string path;
        public frmMain()
        {
            
            InitializeComponent();
            path = "D:/My Project/TRUI/AUAV/Programming/native-net-drone-monitor/native-net-drone-monitor/bin/Debug/1.mkv";
            
            //vlcControl1.Play(new Uri("D:/My Project/TRUI/AUAV/Programming/native-net-drone-monitor/native-net-drone-monitor/bin/Debug/1.mkv"));
        }

        public void refresh()
        {
            droneList.Clear();
           
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("droneList.xml");

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
      

        private void frmMain_Load(object sender, EventArgs e)
        {
            refresh();
            cmbConnect.DropDownListView.Height = 100;
            cmbConnect.DropDownListView.Width = cmbConnect.Width;
            cmbConnect.DropDownListView.ItemHeight = 30;
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

        private void button1_Click(object sender, EventArgs e)
        {
            streamPlayer.Pause();
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
            streamPlayer.Play(new Uri("D:/My Project/TRUI/AUAV/Programming/native-net-drone-monitor/native-net-drone-monitor/bin/Debug/1.mkv"));
            btnConnectDevices.Visible = false;
            btnDisconnect.Visible = true;
            
        }

        private void cmbConnect_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!File.Exists("blbla.xml"))
            {
                MessageBox.Show("No file found");
            }
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            streamPlayer.Stop();
            btnConnectDevices.Visible = true;
            btnDisconnect.Visible = false;
        }
        

        private void label1_Click(object sender, EventArgs e)
        {

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
