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

        public frmEdit(List<Drone> drones)
        {
            InitializeComponent();

            droneList = drones;
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
            var sele = listAvailDevices.SelectedItem;
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
            var bindingList = new BindingList<Drone>(droneList);
            var source = new BindingSource(bindingList, null);
            listAvailDevices.DataSource = source;
            listAvailDevices.DisplayMember = "profileName";
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int idx = listAvailDevices.SelectedIndex;
            Drone sel = droneList[idx];
            var editForm = new frmAddDevices(sel, droneList);
            editForm.Show();
        }
    }
}
