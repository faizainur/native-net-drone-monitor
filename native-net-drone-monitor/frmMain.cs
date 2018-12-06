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
using System.Threading;
using System.Xml.Linq;
using GMap.NET.MapProviders;
using GMap.NET;
using GMap.NET.WindowsForms;
using System.Diagnostics;
using System.Configuration;
using System.Configuration.Assemblies;
using System.Net.NetworkInformation;
using System.Net;

namespace native_net_drone_monitor
{
    public partial class frmMain : Syncfusion.Windows.Forms.MetroForm
    {

        public event EventHandler RefreshTriggered;
        List<Drone> droneList = new List<Drone>();
        List<string> messages = new List<string>();
        AppSettingsVal settingsVal = new AppSettingsVal();

        private string FILENAME = "droneList.xml";
        public string path;


        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            refresh();
            if (!mapBGWorker.IsBusy)
            {
                mapBGWorker.RunWorkerAsync();
            }

            statusConnection.Text = "NOT CONNECTED";
            statusConnection.ForeColor = Color.Red;
            statusIP.Visible = false;
            statusLatency.Visible = false;
            statusLblIP.Visible = false;
            statusLblLatency.Visible = false;
            statusLblLatencyUnit.Visible = false;

            // Initialize Maps
            mapView.DragButton = MouseButtons.Left;
            mapView.ShowCenter = false;
            mapView.MinZoom = 0;
            mapView.MaxZoom = 24;
            mapView.Zoom = 9;
            mapView.SetPositionByKeywords(settingsVal.mapLocation);
        }

        public void refresh()
        {
            settingsVal = readSettings();
            
            if (!File.Exists(FILENAME))
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
                readXmlFile();
                var bindingList = new BindingList<Drone>(droneList);
                var source = new BindingSource(bindingList, null);
                cmbConnect.DataSource = source;
                cmbConnect.DisplayMember = "profileName";
            }
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
                var rtspPort = 0;
                var socket = 0;
                var baudrate = 0;
                var tcpPort = 0;
                var udpPort = 0;

                Drone newDrone = new Drone();
                
                Int32.TryParse(node["baudrate"].InnerText, out baudrate);
                Int32.TryParse(node["tcp-port"].InnerText, out tcpPort);
                Int32.TryParse(node["socket"].InnerText, out socket);
                Int32.TryParse(node["udp-port"].InnerText, out udpPort);
                Int32.TryParse(node["rtsp-port"].InnerText, out rtspPort);

                newDrone.profileName = node.Attributes[0].InnerText;
                newDrone.rtspServer = node["rtsp-server"].InnerText;
                newDrone.connMethod = node["conn-method"].InnerText;
                newDrone.droneType = node["drone-type"].InnerText;
                newDrone.portCom = node["port-com"].InnerText;
                newDrone.tcpHost = node["tcp-host"].InnerText;
                newDrone.udpHost = node["udp-host"].InnerText;
                newDrone.rtspPort = rtspPort;
                newDrone.socket = socket;
                newDrone.udpPort = udpPort;
                newDrone.baudrate = baudrate;
                newDrone.tcpPort = tcpPort;

                droneList.Add(newDrone);
            }
        }

        public bool createXmlFile()
        {
            new XDocument(
                new XElement("drone-list")).Save(FILENAME);
            if (!File.Exists(FILENAME))
            {
                return false;
            }
            return true;
        }


        public void applyMapSettings()
        {
            mapView.MapProvider = GMapProviders.OpenStreetMap;
            GMaps.Instance.OptimizeMapDb(null);
            switch (settingsVal.mapsMode)
            {
                case "Offline":
                    GMaps.Instance.Mode = AccessMode.CacheOnly;
                    break;
                case "Online":
                    if (isInternetConnectionAvailable())
                    {
                        GMaps.Instance.Mode = AccessMode.ServerOnly;
                    }
                    else
                    {
                        MessageBox.Show("No internet connection, we will move to offline mode", "No internet", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        GMaps.Instance.Mode = AccessMode.ServerOnly;
                    }
                    break;
                case "Download":
                    GMaps.Instance.Mode = AccessMode.ServerAndCache;
                    break;
            }
            mapView.CacheLocation = settingsVal.cacheLocation;

        }

        public static bool isInternetConnectionAvailable()
        {
            try
            {
                using (var client = new WebClient())
                using (client.OpenRead("http://clients3.google.com/generate_204"))
                {
                    return true;
                }
            }
            catch
            {
                return false;
            }
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
        
        private void btnConnectDevices_Click(object sender, EventArgs e)
        {
            if (cmbConnect.SelectedItem == null)
            {
                MessageBox.Show("Please select profile first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            } else
            {
                var idx = cmbConnect.SelectedIndex;
                Drone selectedDrone = droneList[idx];
                connect(selectedDrone);
            }
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

        #region Connection Method
        public void connect(Drone drone)
        {
            string time = DateTime.Now.ToString("HH-mm-ss");
            var currentDirectory = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
            string filename = drone.profileName + time + settingsVal.videoFormat;
            var destination = Path.Combine(settingsVal.savePath, filename);
            string url;

            var mediaOptions = new[]
                {
                    ":sout=#file{dst=" + destination + "}",
                    ":sout-keep"
                };

            // connect based on choice
            switch (drone.connMethod)
            {
                case "WebSocket":
                    // Connect via WebSocket
                    break;
                case "MAVLink | UDP":
                    // Connect via UDP
                    break;
                case "MAVLink | TCP":
                    // Connect via TCP
                    break;
                case "MAVLink | Serial":
                    // Connect via Serial
                    break;
            }
            if (settingsVal.saveVideoState)
            {
                recorder.Play(new Uri("D:/My Project/TRUI/AUAV/Programming/native-net-drone-monitor/native-net-drone-monitor/bin/Debug/1.mkv"),
                    mediaOptions);
            }

            streamPlayer.Play(new Uri("D:/My Project/TRUI/AUAV/Programming/native-net-drone-monitor/native-net-drone-monitor/bin/Debug/1.mkv"));

            streamPlayer.Video.AspectRatio = settingsVal.aspectRatio; // set aspect ratio
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

        private void connectMavTCP(string ipHost, int port)
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while connecting to drone\n" + ex.Message, "Error Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void connectMavUDP(string ipHost, int port)
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while connecting to drone\n" + ex.Message, "Error Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void connectMavSerial(string portCom, int baudrate)
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while connecting to drone\n" + ex.Message, "Error Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void connectWebSocket(int socket)
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while connecting to drone\n" + ex.Message, "Error Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void disconnect()
        {
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
        #endregion



        private void editDevicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var editFrm = new frmEdit();
            editFrm.Show();
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Error Memory Leak (sometime)
            // Problem in maps control

            Application.ExitThread();
            Process.GetCurrentProcess().Kill();
             // Process.GetCurrentProcess().CloseMainWindow(); => alternative if the line above doesn't works
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

        private void recorder_VlcLibDirectoryNeeded(object sender, VlcLibDirectoryNeededEventArgs e)
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

        private void menuGettingStarted_Click(object sender, EventArgs e)
        {

        }

        private void menuExportMap_Click(object sender, EventArgs e)
        {
            mapView.ShowExportDialog();
        }

        private void menuImportMap_Click(object sender, EventArgs e)
        {
            // TODO : Error importing map database
            mapView.ShowImportDialog();
        }

        public AppSettingsVal readSettings()
        {
            var buff = new AppSettingsVal();
            try
            {
                var settingsFile = ConfigurationManager.AppSettings;
                var buffSaveState = settingsFile["save-video-state"];
                buff.aspectRatio = settingsFile["aspect-ratio"];
                buff.cacheLocation = settingsFile["cache-location"];
                buff.videoFormat = settingsFile["video-format"];
                buff.savePath = settingsFile["save-path"];
                buff.mapsMode = settingsFile["maps-mode"];
                buff.mapLocation = settingsFile["maps-location"];
                if (buffSaveState == "true")
                {
                    buff.saveVideoState = true;
                }else
                {
                    buff.saveVideoState = false;
                }
            }
            catch (ConfigurationErrorsException)
            {
                var result = MessageBox.Show("Error reading application settings", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                switch (result)
                {
                    case DialogResult.OK:
                        Application.ExitThread();
                        Process.GetCurrentProcess().Kill();
                        break;
                }
            }
            return buff;
        }

        private void mapBGWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;

            try
            {
                if (!GMapControl.IsDesignerHosted)
                {
                    applyMapSettings();
                }
            } catch (Exception ex)
            {
                MessageBox.Show("Error during loading map data\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
