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
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace native_net_drone_monitor
{
    public partial class frmEdit : Syncfusion.Windows.Forms.MetroForm
    {

        private const string FILENAME = "droneList.xml";
        List<Drone> droneList = new List<Drone>();
        XmlDocument xmlDoc = new XmlDocument();

        public frmEdit()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            var frm = new frmMain();
            this.Close();

            frm.Visible = true;
            frm.Show();
            
        }

        private void frmConnect_Load(object sender, EventArgs e)
        {
            if (!File.Exists(FILENAME))
            {
                MessageBox.Show("Please add drone profile first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                refreshList();
            }
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var idx = listAvailDevices.SelectedIndex;
            Drone selectedDrone = droneList[idx];
            var name = selectedDrone.profileName;
            deleteData(name);
            frmMain main = (frmMain)Application.OpenForms["frmMain"];
            main.menuRefresh.PerformClick();
        }

        private void deleteData(string attrName)
        {
            xmlDoc.Load(FILENAME);

            XmlNode root = xmlDoc.SelectSingleNode("/drone-list");

            foreach (XmlNode child in root.ChildNodes)
            {
                string name = child.Attributes[0].InnerText;

                if (name == attrName)
                {
                    root.RemoveChild(child);
                    break;
                }
            }

            xmlDoc.Save(FILENAME);
            refreshList();

        }

        private void refreshList()
        {
            listAvailDevices.DataSource = null;
            readXmlFile();
            var bindingList = new BindingList<Drone>(droneList);
            var source = new BindingSource(bindingList, null);
            listAvailDevices.DataSource = source;
            listAvailDevices.DisplayMember = "profileName";
        }

        private void readXmlFile()
        {
            if (droneList.Count > 0)
            {
                droneList.Clear();
            }
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(FILENAME);

            foreach (XmlNode node in xmlDoc.DocumentElement)
            {
                var profileName = node.Attributes[0].InnerText;

                Drone newDrone = new Drone();

                var rtspPort = 0;
                var socket = 0;
                var baudrate = 0;
                var tcpPort = 0;
                var udpPort = 0;
                var rtspServer = node.SelectSingleNode("/drone-list/drone/rtsp-server").InnerText;
                var connMethod = node.SelectSingleNode("/drone-list/drone/conn-method").InnerText;
                var protocolConn = node.SelectSingleNode("/drone-list/drone/protocol").InnerText;
                var droneType = node.SelectSingleNode("/drone-list/drone/drone-type").InnerText;
                var portCOM = node.SelectSingleNode("/drone-list/drone/port-com").InnerText;
                var tcpHost = node.SelectSingleNode("/drone-list/drone/tcp-host").InnerText;
                var udpHost = node.SelectSingleNode("/drone-list/drone/udp-host").InnerText;

                Int32.TryParse(node.SelectSingleNode("/drone-list/drone/baudrate").InnerText, out baudrate);
                Int32.TryParse(node.SelectSingleNode("/drone-list/drone/socket").InnerText, out socket);
                Int32.TryParse(node.SelectSingleNode("/drone-list/drone/rtsp-port").InnerText, out rtspPort);
                Int32.TryParse(node.SelectSingleNode("/drone-list/drone/tcp-port").InnerText, out tcpPort);
                Int32.TryParse(node.SelectSingleNode("/drone-list/drone/udp-port").InnerText, out udpPort);

                newDrone.profileName = profileName;
                newDrone.rtspServer = rtspServer;
                newDrone.protocolConn = protocolConn;
                newDrone.connMethod = connMethod;
                newDrone.rtspPort = rtspPort;
                newDrone.socket = socket;
                newDrone.droneType = droneType;
                newDrone.baudrate = baudrate;
                newDrone.portCom = portCOM;
                newDrone.tcpPort = tcpPort;
                newDrone.tcpHost = tcpHost;
                newDrone.udpPort = udpPort;
                newDrone.udpHost = udpHost;

                droneList.Add(newDrone);
            }
        }
    }
}
