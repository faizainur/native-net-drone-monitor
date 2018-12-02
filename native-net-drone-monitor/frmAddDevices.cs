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
        string selectedConnMethod;

        public const string FILENAME = "droneList.xml";
        public frmAddDevices()
        {
            InitializeComponent();
            droneType.Add("Quad Copter");
            droneType.Add("Hexa Copter");
            droneType.Add("Octa Copter");
            droneType.Add("Other Multi Copter");
            droneType.Add("Plane");
            cmbDroneType.DataSource = droneType;

            protocol.Add("TCP");
            protocol.Add("UDP");
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
        }

        private Boolean validateForm()
        {
            // TODO : Error validating radioButtons status
            if (txtIPAddress.Text == null)
            {
                return false;
            }
            if (txtProfileName.Text == null)
            {
                return false;
            }
            return true;
        }

        private void btnCancelAdd_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddData_Click(object sender, EventArgs e)
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

        private bool addData()
        {

            /* TODO Validating data form */

            string baudrate, selectedProtocol, selectedCOM;
            if (toggleMavLink.ToggleState == ToggleButtonState.Active)
            {
                selectedConnMethod = "MAVLink";
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

            if (cmbProtocol.SelectedItem != null)
            {
                selectedProtocol = protocol[cmbProtocol.SelectedIndex];
            }
            else { selectedProtocol = ""; }

            if (cmbPortCOM.SelectedItem != null)
            {
                selectedCOM = listCOM[cmbPortCOM.SelectedIndex];
            }
            else { selectedCOM = ""; }

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
                    new XElement("ip-address", txtIPAddress.Text),
                    new XElement("conn-method", selectedConnMethod),
                    new XElement("port", txtPort.Text),
                    new XElement("protocol", selectedProtocol),
                    new XElement("socket", txtSocket.Text),
                    new XElement("port-com", selectedCOM),
                    new XElement("baudrate", baudrate));
                xmlDoc.Element("drone-list").Add(newElement);
                xmlDoc.Save(FILENAME);

            }
            return true;


            // TODO Check if file exist
        }

        private void frmAddDevices_Load(object sender, EventArgs e)
        {
            toggleWebSocket.VisualStyle = Syncfusion.Windows.Forms.Tools.ToggleButtonStyle.Office2016Colorful;
            toggleMavLink.VisualStyle = Syncfusion.Windows.Forms.Tools.ToggleButtonStyle.Office2016Colorful;

            
        }

        private void toggleWebSocket_ToggleStateChanged(object sender, Syncfusion.Windows.Forms.Tools.ToggleStateChangedEventArgs e)
        {
            if (e.ToggleState == ToggleButtonState.Active)
            {
                lblSocket.Enabled = true;
                txtSocket.Enabled = true;
            }if (e.ToggleState == ToggleButtonState.Inactive)
            {
                lblSocket.Enabled = false;
                txtSocket.Enabled = false;
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
                    panelWebSocket.Visible = false;
                    break;
                case "WebSocket":
                    panelWebSocket.Visible = true;
                    panelMavLink.Visible = false;
                    break;
                case "MAVLink":
                    panelMavLink.Visible = true;
                    break;
            }
        }

        private void toggleMavLink_ToggleStateChanged(object sender, ToggleStateChangedEventArgs e)
        {
            if (e.ToggleState == ToggleButtonState.Active)
            {
                lblProtocol.Enabled = true;
                cmbProtocol.Enabled = true;
            }
            if (e.ToggleState == ToggleButtonState.Inactive)
            {
                lblProtocol.Enabled = false;
                cmbProtocol.Enabled = false;
                cmbProtocol.SelectedItem = null;
            }
        }

        private void cmbProtocol_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProtocol.SelectedIndex == 2)
            {
                panelTCP.Visible = true;
            } else
            {
                panelTCP.Visible = false;
            }
        }
    }
}
