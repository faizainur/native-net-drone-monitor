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
    public partial class frmConnect : Syncfusion.Windows.Forms.MetroForm
    {
        List<Drone> droneList = new List<Drone>();

        public frmConnect()
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
            if (!File.Exists("dronesList.xml"))
            {
                MessageBox.Show("Please add drone profile first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
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
                listAvailDevices.DataSource = droneList;
                listAvailDevices.DisplayMember = "profileName";
            }
            
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            //var idx = listAvailDevices.SelectedIndex;
            //Drone selectedDrone = droneList[idx];

            var main = new frmMain();

            this.Close();
            
        }
    }
}
