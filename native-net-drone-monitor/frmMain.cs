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
        private List<Drone> droneList = new List<Drone>();
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
            vlcControl1.Play(new Uri(path));
        }
        private void tabStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("dronesList.xml");

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
            cmbConnect.DataSource = droneList;
            cmbConnect.DisplayMember = "profileName";

            
        }


        private void vlcControl1_Click(object sender, EventArgs e)
        {
            
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
            vlcControl1.Pause();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
        public void AddToMyListBox()
        {
            // Stop the ListBox from drawing while items are added.
            listBox1.BeginUpdate();

            // Loop through and add five thousand new items.
            int x = 0;
            while (true)
            {
                listBox1.Items.Add("Item " + x.ToString());
                x++;
            }

            // End the update process and force a repaint of the ListBox.
            listBox1.EndUpdate();
        }

        private void btnConnectDevices_Click(object sender, EventArgs e)
        {
            var idx = cmbConnect.SelectedIndex;
            vlcControl1.Play(new Uri("D:/My Project/TRUI/AUAV/Programming/native-net-drone-monitor/native-net-drone-monitor/bin/Debug/1.mkv"));
            AddToMyListBox();
            btnConnect.Visible = false;
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
            vlcControl1.Stop();
            btnConnect.Visible = true;
            btnDisconnect.Visible = false;
        }

        private void vlcControl1_Playing(object sender, Vlc.DotNet.Core.VlcMediaPlayerPlayingEventArgs e)
        {
           // AddToMyListBox();
        }
    }
}
