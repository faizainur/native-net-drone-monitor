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
        BindingList<Drone> droneList = new BindingList<Drone>();
        private BindingSource source = new BindingSource();
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
            droneList.Clear();
            listAvailDevices.DataSource = null;
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
            listAvailDevices.DataSource = source;
            listAvailDevices.DisplayMember = "profileName";
        }
    }
}
