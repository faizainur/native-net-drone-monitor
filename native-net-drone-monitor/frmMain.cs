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
using Vlc.DotNet.Core;
using Vlc.DotNet.Forms;

namespace native_net_drone_monitor
{
    public partial class frmMain : Syncfusion.Windows.Forms.MetroForm
    {

        public event EventHandler RefreshTriggered;
        private List<Drone> droneList = new List<Drone>();
        private List<string> messages = new List<string>();
        VlcControl recorder = new VlcControl();

        private string FILENAME = "droneList.xml";
        private string SETTINGS_FILENAME = "settings.conf";
        public string path;
        public frmMain()
        {

            InitializeComponent();
            path = "http://download.blender.org/peach/bigbuckbunny_movies/big_buck_bunny_480p_surround-fix.avi";
            //streamPlayer.Play(new Uri(path));
            


        }

        public void refresh()
        {
            /* TODO : ERROR WHILE REFRESHING */

            if (!File.Exists(FILENAME) || !File.Exists(SETTINGS_FILENAME))
            {
                if (!createXmlFile())
                {
                    MessageBox.Show("Error creating XML file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    var result = MessageBox.Show("Seems this is your first time :), please add device first.", "No devices listed", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    switch (result)
                    {
                        case DialogResult.Yes:
                            var frmAdd = new frmAddDevices();
                            frmAdd.Show();
                            frmAdd.TopMost = true;
                            break;
                        case DialogResult.No:
                            break;
                        default:
                            MessageBox.Show("What did you press?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                            break;
                    }
                }
            } else
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

                    var port = 0;
                    var socket = 0;
                    var baudrate = 0;
                    var ipAddress = node.SelectSingleNode("/drone-list/drone/ip-address").InnerText;
                    var connMethod = node.SelectSingleNode("/drone-list/drone/conn-method").InnerText;
                    var protocolConn = node.SelectSingleNode("/drone-list/drone/protocol").InnerText;
                    var droneType = node.SelectSingleNode("/drone-list/drone/drone-type").InnerText;
                    var portCOM = node.SelectSingleNode("/drone-list/drone/port-com").InnerText;

                    Int32.TryParse(node.SelectSingleNode("/drone-list/drone/baudrate").InnerText,out  baudrate);
                    Int32.TryParse(node.SelectSingleNode("/drone-list/drone/socket").InnerText, out socket);
                    Int32.TryParse(node.SelectSingleNode("/drone-list/drone/port").InnerText, out port);

                    newDrone.profileName = profileName;
                    newDrone.ipAddress = ipAddress;
                    newDrone.protocolConn = protocolConn;
                    newDrone.connMethod = connMethod;
                    newDrone.port = port;
                    newDrone.socket = socket;
                    newDrone.droneType = droneType;
                    newDrone.baudrate = baudrate;
                    newDrone.portCom = portCOM;

                    droneList.Add(newDrone);
                }
                var bindingList = new BindingList<Drone>(droneList);
                var source = new BindingSource(bindingList, null);
                cmbConnect.DataSource = source;
                cmbConnect.DisplayMember = "profileName";
            }
        }
      
        public bool createXmlFile()
        {
            new XDocument(
                new XElement("drone-list")).Save(FILENAME);
            new XDocument(
                new XElement("settings")).Save(SETTINGS_FILENAME);
            if (!File.Exists(FILENAME) && !File.Exists(SETTINGS_FILENAME))
            {
                return false;
            }
            return true;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            refresh();
            statusConnection.Text = "NOT CONNECTED";
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

        private void recorderInit()
        {
            recorder.BeginInit();
            recorder.VlcLibDirectory = streamPlayer.VlcLibDirectory;
            recorder.Visible = false;
            recorder.EndInit();
        }
        public void connect(Drone drone)
        {

            
            var currentDirectory = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
            var destination = Path.Combine(currentDirectory,"stream.mkv");
            var mediaOptions = new[]
                {
                    ":sout=#file{dst=" + destination + "}",
                    ":sout-keep"
                };
            recorderInit();
            this.Controls.Add(recorder);
            recorder.Play(new Uri("D:/My Project/TRUI/AUAV/Programming/native-net-drone-monitor/native-net-drone-monitor/bin/Debug/1.mkv"),
                    mediaOptions);
            streamPlayer.Video.AspectRatio = "4:3"; // set aspect ratio
            
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
            this.Controls.Remove(recorder);
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

        private void menuSettings_Click(object sender, EventArgs e)
        {
            var settingsFrm = new frmSettings();
            settingsFrm.Show();
            settingsFrm.TopMost = true;
        }

        private void streamPlayer_VlcLibDirectoryNeeded(object sender, VlcLibDirectoryNeededEventArgs e)
        {
            var currentAssembly = Assembly.GetEntryAssembly();
            var currentDirectory = new FileInfo(currentAssembly.Location).DirectoryName;
            // Default installation path of VideoLAN.LibVLC.Windows
            e.VlcLibDirectory = new DirectoryInfo(Path.Combine(currentDirectory, "libvlc", IntPtr.Size == 4 ? "win-x86" : "win-x64"));

            if (!e.VlcLibDirectory.Exists)
            {
                var folderBrowserDialog = new FolderBrowserDialog();
                folderBrowserDialog.Description = "Select Vlc libraries folder.";
                folderBrowserDialog.RootFolder = Environment.SpecialFolder.Desktop;
                folderBrowserDialog.ShowNewFolderButton = true;
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    e.VlcLibDirectory = new DirectoryInfo(folderBrowserDialog.SelectedPath);
                }
            }
        }
    }
}
