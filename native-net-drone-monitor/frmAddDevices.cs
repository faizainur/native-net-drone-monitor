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
using System.Xml.Linq;
using System.Xml;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;

namespace native_net_drone_monitor
{
    public partial class frmAddDevices : Syncfusion.Windows.Forms.MetroForm
    {
        private List<string> droneType = new List<string>();
        private List<string> protocol = new List<string>();
        private List<string> baudrateList = new List<string>();
        private List<string> listCOM = new List<string>();
        private List<Drone> droneList = new List<Drone>();

        private Drone oldDrone = new Drone();

        string selectedConnMethod;
        bool telemetryTabIsOpened = false;
        public const string FILENAME = "droneList.xml";


        public frmAddDevices(Drone drone, List<Drone> drones)
        {
            InitializeComponent();
            droneType.Add("Quad Copter");
            droneType.Add("Hexa Copter");
            droneType.Add("Octa Copter");
            droneType.Add("Other Multi Copter");
            droneType.Add("Plane");
            cmbDroneType.DataSource = droneType;

            protocol.Add("UDP");
            protocol.Add("TCP");
            protocol.Add("Serial");
            cmbProtocol.DataSource = protocol;

            baudrateList.Add("1200");
            baudrateList.Add("2400");
            baudrateList.Add("4800");
            baudrateList.Add("9600");
            baudrateList.Add("19200");
            baudrateList.Add("38400");
            baudrateList.Add("57600");
            baudrateList.Add("111100");
            baudrateList.Add("115200");
            baudrateList.Add("500000");
            baudrateList.Add("625000");
            baudrateList.Add("921000");
            baudrateList.Add("1500000");
            cmbBaudrate.DataSource = baudrateList;

            listCOM.Add("COM3");
            listCOM.Add("COM5");
            cmbPortCOM.DataSource = listCOM;

            if (drone != null)
            {
                editData(drone);
                oldDrone = drone;
            }
        }

        private void frmAddDevices_Load(object sender, EventArgs e)
        {
            toggleWebSocket.VisualStyle = Syncfusion.Windows.Forms.Tools.ToggleButtonStyle.Office2016Colorful;
            toggleMavLink.VisualStyle = Syncfusion.Windows.Forms.Tools.ToggleButtonStyle.Office2016Colorful;
        }

        private bool validateForm()
        {
            
            // TODO : Error validating radioButtons status
            if (txtRtspServer.Text == null)
            {
                return false;
            }
            if (txtProfileName.Text == null)
            {
                return false;
            }
            if (cmbDroneType.SelectedItem == null)
            {
                return false;
            }
            if (toggleMavLink.ToggleState == ToggleButtonState.Active)
            {
                if (cmbProtocol.SelectedItem == null)
                {
                    return false;
                }
                else 
                {
                    switch (cmbProtocol.SelectedIndex)
                    {
                        case 0:
                            if (txtUdpPort.Text == null)
                            {
                                return false;
                            }
                            if (txtUdpHost.Text == null)
                            {
                                return false;
                            }
                            break;
                        case 1:
                            if (txtTcpHost.Text == null)
                            {
                                return false;
                            }
                            if (txtTcpPort.Text == null)
                            {
                                return false;
                            }
                            break;
                        case 2:
                            if (cmbPortCOM.SelectedItem == null)
                            {
                                return false;
                            }
                            if (cmbBaudrate.SelectedItem == null)
                            {
                                return false;
                            }
                            break;
                    }
                }
                
                if (droneList != null)
                {
                    
                }
            }
            if (toggleWebSocket.ToggleState == ToggleButtonState.Active)
            {
                if (txtSocket.Text == null)
                {
                    return false;
                }
            }
            return true;
        }

        private void btnCancelAdd_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool addData()
        {

            /* TODO Validating data form */

            string baudrate, selectedProtocol, selectedCOM;

            if (oldDrone != null)
            {
                deleteData(oldDrone.profileName);
            }
            if (!validateForm())
            {
                MessageBox.Show("Please fill the form", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            } else
            {
                if (toggleMavLink.ToggleState == ToggleButtonState.Active)
                {
                    switch (cmbProtocol.SelectedIndex)
                    {
                        case 0:
                            selectedConnMethod = "MAVLink | UDP";
                            break;
                        case 1:
                            selectedConnMethod = "MAVLink | TCP";
                            break;
                        case 2:
                            selectedConnMethod = "MAVLink | Serial";
                            break;
                    }
                }
                else if (toggleWebSocket.ToggleState == ToggleButtonState.Active)
                {
                    selectedConnMethod = "WebSocket";
                }
                if (cmbBaudrate.SelectedItem != null)
                {
                    baudrate = baudrateList[cmbBaudrate.SelectedIndex];
                }
                else { baudrate = ""; }

                string seletedType = droneType[cmbDroneType.SelectedIndex];

                if (cmbPortCOM.SelectedItem != null)
                {
                    selectedCOM = listCOM[cmbPortCOM.SelectedIndex];
                }
                else { selectedCOM = ""; }

                if (droneList != null)
                {
                    for (int j = 0; j < droneList.Count; ++j)
                    {
                        if (txtProfileName.Text == droneList[j].profileName)
                        {
                            MessageBox.Show("Profile name already used, please choose other profile name");
                            return false;
                        }
                    }
                }

                if (toggleWebSocket.ToggleState == ToggleButtonState.Active && toggleMavLink.ToggleState == ToggleButtonState.Active)
                {
                    var result = MessageBox.Show("Please only choose one connection method", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    switch (result)
                    {
                        case DialogResult.OK:
                            return false;
                        default:
                            break;
                    }
                }
                else
                {
                    var xmlDoc = XDocument.Load(FILENAME);
                    var newElement = new XElement("drone",
                        new XAttribute("name", txtProfileName.Text),
                        new XElement("drone-type", seletedType),
                        new XElement("rtsp-server", txtRtspServer.Text),
                        new XElement("conn-method", selectedConnMethod),
                        new XElement("rtsp-port", txtPortRtsp.Text),
                        new XElement("socket", txtSocket.Text),
                        new XElement("port-com", selectedCOM),
                        new XElement("baudrate", baudrate),
                        new XElement("tcp-host", txtTcpHost.Text),
                        new XElement("tcp-port", txtTcpPort.Text),
                        new XElement("udp-host", txtUdpHost.Text),
                        new XElement("udp-port", txtUdpPort.Text));
                    xmlDoc.Element("drone-list").Add(newElement);
                    xmlDoc.Save(FILENAME);
                }
            }
            return true;
            // TODO Check if file exist
        }

        
        private void toggleWebSocket_ToggleStateChanged(object sender, Syncfusion.Windows.Forms.Tools.ToggleStateChangedEventArgs e)
        {
            if (e.ToggleState == ToggleButtonState.Active)
            {
                lblSocket.Visible = true;
                txtSocket.Visible = true;
            }if (e.ToggleState == ToggleButtonState.Inactive)
            {
                lblSocket.Visible = false;
                txtSocket.Visible = false;
                txtSocket.Clear();
            }
        }

        private void treeNavigator1_SelectionChanged(Syncfusion.Windows.Forms.Tools.TreeNavigator sender, Syncfusion.Windows.Forms.Tools.SelectionStateChangedEventArgs e)
        {
            TreeMenuItem tm = e.SelectedItem;
            switch (tm.Text)
            {
                case "General":
                    panelGeneral.Visible = true;
                    panelVideoStream.Visible = false;
                    break;
                case "WebSocket":
                    panelGeneral.Visible = true;
                    panelVideoStream.Visible = true;
                    panelWebSocket.Visible = true;
                    panelMavLink.Visible = false;
                    break;
                case "MAVLink":
                    panelGeneral.Visible = true;
                    panelVideoStream.Visible = true;
                    panelWebSocket.Visible = true;
                    panelMavLink.Visible = true;
                    break;
                case "Video Stream":
                    panelGeneral.Visible = true;
                    panelVideoStream.Visible = true;
                    panelWebSocket.Visible = false;
                    panelMavLink.Visible = false;
                    break;
                case "Telemetry":
                    if (telemetryTabIsOpened)
                    {
                        panelGeneral.Visible = false;
                    } else
                    {
                        panelVideoStream.Visible = true;
                        telemetryTabIsOpened = true;
                    }
                    break;
            }
        }

        private void toggleMavLink_ToggleStateChanged(object sender, ToggleStateChangedEventArgs e)
        {
            if (e.ToggleState == ToggleButtonState.Active)
            {
                lblProtocol.Visible = true;
                cmbProtocol.Visible = true;
            }
            if (e.ToggleState == ToggleButtonState.Inactive)
            {
                lblProtocol.Visible = false;
                cmbProtocol.Visible = false;
                cmbProtocol.SelectedItem = null;
                panelTcp.Visible = false;
                panelUdp.Visible = false;
                panelSerial.Visible = false;
                cmbBaudrate.SelectedItem = null;
                cmbPortCOM.SelectedItem = null;
                txtTcpHost.Clear();
                txtTcpPort.Clear();
                txtUdpHost.Clear();
                txtUdpPort.Clear();
            }
        }

        private void cmbProtocol_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbProtocol.SelectedIndex)
            {
                case 0:
                    panelUdp.Visible = true;
                    panelTcp.Visible = false;
                    panelSerial.Visible = false;
                    break;
                case 1:
                    panelUdp.Visible = false;
                    panelTcp.Visible = true;
                    panelSerial.Visible = false;
                    break;
                case 2:
                    panelUdp.Visible = false;
                    panelTcp.Visible = false;
                    panelSerial.Visible = true;
                    break;
            }
        }

        private void btnSaveData_Click(object sender, EventArgs e)
        {
            var main = (frmMain)Application.OpenForms["frmMain"];
            if (addData())
            {
                main.menuRefresh.PerformClick();
                if (main.Enabled == false)
                {
                    main.Enabled = true;
                }
                this.Close();
            }
        }

        private void editData(Drone drone)
        {
            txtSocket.Text = drone.socket.ToString();
            txtRtspServer.Text = drone.rtspServer.ToString();
            txtProfileName.Text = drone.profileName;
            txtPortRtsp.Text = drone.rtspPort.ToString();
            txtTcpHost.Text = drone.tcpHost;
            txtTcpPort.Text = drone.tcpPort.ToString();
            txtUdpHost.Text = drone.udpHost;
            txtUdpPort.Text = drone.udpPort.ToString();

            switch (drone.connMethod)
            {
                case "WebSocket":
                    toggleWebSocket.ToggleState = ToggleButtonState.Active;
                    break;
                case "MAVLink | UDP":
                    toggleMavLink.ToggleState = ToggleButtonState.Active;
                    cmbProtocol.SelectedIndex = 0;
                    break;
                case "MAVLink | TCP":
                    toggleMavLink.ToggleState = ToggleButtonState.Active;
                    cmbProtocol.SelectedIndex = 1;
                    break;
                case "MAVLink | Serial":
                    toggleMavLink.ToggleState = ToggleButtonState.Active;
                    cmbProtocol.SelectedIndex = 2;
                    break;
            }

            switch (drone.portCom)
            {
                case "COM3":
                    cmbPortCOM.SelectedIndex = 0;
                    break;
                case "COM5":
                    cmbPortCOM.SelectedIndex = 1;
                    break;
            }

            for (int i = 0; i < 13; ++i)
            {
                if (drone.baudrate.ToString() == baudrateList[i])
                {
                    cmbBaudrate.SelectedIndex = i;
                    break;
                }
            }

            for (int i = 0; i < 5; ++i)
            {
                if (drone.droneType == droneType[i])
                {
                    cmbDroneType.SelectedIndex = i;
                    break;
                }
            }
        }

        private void deleteData(string attrName)
        {
            XmlDocument xmlDoc = new XmlDocument();
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

        }
    }
}
