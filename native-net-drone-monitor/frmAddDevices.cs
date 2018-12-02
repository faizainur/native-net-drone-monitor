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

namespace native_net_drone_monitor
{
    public partial class frmAddDevices : Syncfusion.Windows.Forms.MetroForm
    {
        public const string FILENAME = "droneList.xml";
        public frmAddDevices()
        {
            InitializeComponent();
        }

        private void radioSocket_CheckedChanged(object sender, EventArgs e)
        {
            if (radioSocket.Checked == true)
            {
                txtSocket.Enabled = true;
            }
            else
            {
                txtSocket.Enabled = false;
            }
        }

        private Boolean validateForm()
        {
            // TODO : Error validating radioButtons status
            if (txtIPDevices.Text == null)
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

        private void btnAddDevices_Click(object sender, EventArgs e)
        {
            var main = (frmMain)Application.OpenForms["frmMain"];
            addData();
            main.refreshToolStripMenuItem.PerformClick();
            this.Close();
        }

        private void addData()
        {
            var xmlDoc = XDocument.Load(FILENAME);
            var newElement = new XElement("drone",
                new XAttribute("name", txtProfileName.Text),
                new XElement("ip-address", txtIPDevices.Text),
                new XElement("socket", txtSocket.Text));
            xmlDoc.Element("drone-list").Add(newElement);
            xmlDoc.Save(FILENAME);
            
            // TODO Check if file exist
        }
        
    }
}
